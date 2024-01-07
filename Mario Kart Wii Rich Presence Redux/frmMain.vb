Imports System.Text.RegularExpressions
Imports DiscordRPC
Imports DiscordRPC.Logging
Imports Newtonsoft.Json

Public Class frmMain
    Private details As String = ""
    Private state As String = ""
    Private track As String = ""
    Private large_image As String = ""
    Private small_image As String = ""
    Private party_size As Integer = 0

    Private conf_startUrl As String = "https://wiimmfi.de/stats/mkw/room/p1"
    Private conf_shareBtn As Boolean = True
    Private conf_addText As String = "0000-0000-0000"
    Private conf_useOwnApp As Boolean = False
    Private conf_userAppId As String = ""
    Private conf_useTrackState As Boolean = False
    Private conf_useTextDetails As Boolean = False
    Private conf_useCustomCourseImages As Boolean = False

    Public default_app_id = "662481965840072717"

    Private client As DiscordRpcClient

    Private Sub conf_load()
        If My.Computer.FileSystem.FileExists("config.json") Then
            Dim conf = My.Computer.FileSystem.ReadAllText("config.json")
            Try
                Dim j = Linq.JObject.Parse(conf)
                If j.ContainsKey("startUrl") Then conf_startUrl = j.GetValue("startUrl")
                If j.ContainsKey("shareBtn") Then conf_shareBtn = j.GetValue("shareBtn")
                If j.ContainsKey("addText") Then conf_addText = j.GetValue("addText")
                If j.ContainsKey("userAppId") Then conf_userAppId = j.GetValue("userAppId")
                Try
                    If j.ContainsKey("useOwnApp") Then conf_useOwnApp = j.GetValue("useOwnApp")
                    If j.ContainsKey("useTrackState") Then conf_useTrackState = j.GetValue("useTrackState")
                    If j.ContainsKey("useTextDetails") Then conf_useTextDetails = j.GetValue("useTextDetails")
                    If j.ContainsKey("useCustomCourseImages") Then conf_useCustomCourseImages = j.GetValue("useCustomCourseImages")
                Catch ex As Exception
                    ' booleans in config aren't booleans
                End Try
            Catch e As JsonReaderException
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub conf_save()
        Dim ob As New Dictionary(Of String, Object)

        ob.Add("startUrl", conf_startUrl)
        ob.Add("shareBtn", conf_shareBtn)
        ob.Add("addText", conf_addText)
        ob.Add("userAppId", conf_userAppId)
        ob.Add("useOwnApp", conf_useOwnApp)
        ob.Add("useTrackState", conf_useTrackState)
        ob.Add("useTextDetails", conf_useTextDetails)
        ob.Add("useCustomCourseImages", conf_useCustomCourseImages)

        Dim json As String = JsonConvert.SerializeObject(ob, Formatting.indented)

        My.Computer.FileSystem.WriteAllText("config.json", json, False)
    End Sub

    Private Async Sub UpdateRPC() Handles webView.NavigationCompleted
        TextBox3.Text = webView.Source.AbsoluteUri

        'get profile url
        Dim rgx As Regex = New Regex("p([0-9])+")
        Dim matches = rgx.Matches(webView.Source.AbsoluteUri)
        'CheckBox1.Checked = matches.Count > 0
        If matches.Count > 0 Then

            TextBox2.Text = webView.Source.AbsoluteUri
            conf_startUrl = webView.Source.AbsoluteUri.ToString

            'scraping :)
            ' <a href="https://ct.wiimm.de/i/3459">N64 Sherbet Land (Nintendo)</a>
            Dim html As String
            Try
                html = Await webView.ExecuteScriptAsync("document.documentElement.outerHTML;")
            Catch ex As System.InvalidOperationException
                ' browser not yet loaded
                Exit Sub
            End Try


            ' "The Html comes back with unicode character codes, other escaped characters, And
            ' wrapped in double quotes, so I'm using this code to clean it up for what I'm doing."
            html = Regex.Unescape(html)
            html = html.Remove(0, 1)
            html = html.Remove(html.Length - 1, 1)
            'https://stackoverflow.com/a/62461284 thanks!

            'And now for some really hacky parsing..
            If html.Contains("No room found!") Then
                details = "Not in a room"
                large_image = "placeholder"
                party_size = 0
            End If

            If html.Contains(">Worldwide room") Then
                details = "Worldwide"
            ElseIf html.Contains(">Global room") Then
                details = "Global"
                state = "Waiting for room info"
                track = "Waiting for room info"
            ElseIf html.Contains(">Private room") Then
                details = "Friends"
            ElseIf html.Contains(">Continental room") Then
                details = "Regional"
            End If


            Dim trackrgx As Regex = New Regex("Last track: .*>(.*)</a>")
            Dim tmatches = trackrgx.Matches(html)
            If tmatches.Count > 0 Then
                track = tmatches(0).Groups(1).Value.Replace("Wii ", "")
            ElseIf details = "Not in a room" Then
                track = ""
            Else
                track = "Custom"
            End If
            If html.Contains("<td align=center>bt</td>") Or html.Contains("<td align=""center"">bt</td>") Then
                state = "Battle"
            Else
                state = "VS Race"
            End If

            small_image = "mario"

            If Not track.EndsWith("(Nintendo)") Then
                large_image = "custom"
            End If

            track = track.Split("(").First
            If conf_useCustomCourseImages Or Not large_image = "custom" Then
                large_image = track.Replace(" ", "").Replace("'", "").ToLower()
                large_image = Regex.Replace(large_image, "[^a-z0-9\-/]", "_")
                'large_image = track.Replace(" ", "").Replace("'", "").ToLower().Replace(".", "_").Replace(",", "_")
            End If


            If details = "Not in a room" Then
                large_image = "placeholder"
                state = conf_addText
            End If

            If large_image.Length > 32 Then
                'large_image = large_image.Substring(0, 32).Split("(").First
                large_image = "custom"
            End If
            If track.Length > 128 Then
                track = track.Substring(0, 128)
            End If

            lvInfos.Items.Clear()
            Dim d As New ListViewItem
            d.Text = "Details"
            d.SubItems.Add(details)
            lvInfos.Items.Add(d)
            Dim s As New ListViewItem
            s.Text = "State"
            s.SubItems.Add(state)
            lvInfos.Items.Add(s)
            Dim t As New ListViewItem
            t.Text = "Track"
            t.SubItems.Add(track)
            lvInfos.Items.Add(t)
            Dim li As New ListViewItem
            li.Text = "Large image"
            li.SubItems.Add(large_image)
            lvInfos.Items.Add(li)
            Dim si As New ListViewItem
            si.Text = "Small image"
            si.SubItems.Add(small_image)
            lvInfos.Items.Add(si)

            If useTrackState.Checked And Not details = "Not in a room" Then
                Dim actualstate = state
                state = track
                track = actualstate
                ' hover large image to get state (VS Race or Battle) and state field has track name
            End If
            Dim smallimagetext = txtAddText.Text
            If useTextDetails.Checked And Not details = "Not in a room" Then
                smallimagetext = details
                details = txtAddText.Text
                ' hover small image to get details (Friends, Worldwide, Regional) and details field has own text
            End If
            If details = "Not in a room" Then
                smallimagetext = "MKWii-RPRedux"
            End If

            Dim pres As New RichPresence() With {
                                   .Details = details,
                                   .State = state,
                                   .Assets = New Assets() With {
                                   .LargeImageKey = large_image,
                                   .SmallImageKey = small_image,
                                   .LargeImageText = track,
                                   .SmallImageText = smallimagetext}}

            If conf_shareBtn Then
                Try
                    Dim btn As New DiscordRPC.Button
                    btn.Url = txtUserURL.Text
                    btn.Label = "View details"
                    pres.Buttons = {btn}
                Catch ex As ArgumentException
                    ' url invalid
                End Try
            End If

            client.SetPresence(pres)
            conf_save()
        End If
    End Sub

    Private Sub Form1_Load() Handles MyBase.Load
        conf_load()
        Me.Size = New Size(Me.MinimumSize.Width, Me.MinimumSize.Height)

        chkShare.Checked = conf_shareBtn
        txtUserURL.Text = conf_startUrl
        Try
            webView.Source = New Uri(conf_startUrl)
        Catch ex As UriFormatException
            webView.Source = New Uri("https://wiimmfi.de/stats/mkw/room/p1")
        End Try
        txtAddText.Text = conf_addText

        useOwnApp.Checked = conf_useOwnApp
        useTrackState.Checked = conf_useTrackState
        useTextDetails.Checked = conf_useTextDetails
        init_client()
    End Sub
    Private Sub init_client()
        If conf_useOwnApp Then
            Try
                client = New DiscordRpcClient(conf_userAppId)
            Catch ex As Exception
                MsgBox(ex.Message & vbNewLine & "Using own application ID has been disabled.", MsgBoxStyle.Exclamation)
                client = New DiscordRpcClient(default_app_id)
            End Try
        Else
            client = New DiscordRpcClient(default_app_id)
        End If

        client.Logger = New ConsoleLogger() With {
            .Level = LogLevel.Warning
        }

        client.Initialize()
        If Not client.IsInitialized Then
            MsgBox("There could be an issue with the provided client ID, or you don't have Discord running.")
        End If
        client.SetPresence(New RichPresence() With {
            .Details = "MKW-RPRedux active",
            .State = "Starting up",
            .Assets = New Assets() With {
                .LargeImageKey = "placeholder",
                .LargeImageText = "MKWii-RPRedux",
                .SmallImageKey = "mario"
            }
        })
    End Sub

    Private Sub btnSaveUpdate_Click(sender As Object, e As EventArgs) Handles btnSaveUpdate.Click
        conf_addText = txtAddText.Text
        webView.CoreWebView2.Navigate(txtUserURL.Text)
        UpdateRPC()
    End Sub

    Private Sub lnkList_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkList.LinkClicked
        Process.Start("https://wiimmfi.de/stats/mkw/")
    End Sub

    Private Sub btnOpenClose_Click(sender As Object, e As EventArgs) Handles btnOpenClose.Click
        If Me.Tag = "expanded" Then
            Me.WindowState = FormWindowState.Normal
            Me.Tag = ""
            Me.Size = New Size(Me.MinimumSize.Width, Me.MinimumSize.Height)
            Me.MaximizeBox = False
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            btnOpenClose.Text = "Expand >>"
        Else
            Me.Tag = "expanded"
            Me.Size = New Size(1000, Me.Height)
            Me.MaximizeBox = True
            Me.FormBorderStyle = FormBorderStyle.Sizable
            btnOpenClose.Text = "<< Retract"
        End If
        webView.Visible = Me.Tag = "expanded"
    End Sub

    Private Sub LinkGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGithub.LinkClicked
        Process.Start("https://github.com/dotcomboom/mkwii-rpredux")
    End Sub

    Private Sub useOwnApp_CheckedChanged(sender As Object, e As EventArgs) Handles useOwnApp.Click
        If useOwnApp.Checked Then
            frmOwnRPC.ClientId.Text = conf_userAppId
            frmOwnRPC.useCustomImages.Checked = conf_useCustomCourseImages
            If frmOwnRPC.ShowDialog = DialogResult.OK Then
                conf_userAppId = frmOwnRPC.ClientId.Text
                conf_useCustomCourseImages = frmOwnRPC.useCustomImages.Checked
            Else
                useOwnApp.Checked = False
            End If
        End If
        If conf_userAppId = "" Then
            useOwnApp.Checked = False
        End If
        conf_useOwnApp = useOwnApp.Checked
        client.ClearPresence()
        client.Dispose()
        init_client()
        UpdateRPC()
    End Sub

    Private Sub chkShare_CheckedChanged(sender As Object, e As EventArgs) Handles chkShare.CheckedChanged
        conf_shareBtn = chkShare.Checked
        UpdateRPC()
    End Sub

    Private Sub useTrackState_CheckedChanged(sender As Object, e As EventArgs) Handles useTrackState.CheckedChanged
        conf_useTrackState = useTrackState.Checked
        UpdateRPC()
    End Sub

    Private Sub useTextDetails_CheckedChanged(sender As Object, e As EventArgs) Handles useTextDetails.CheckedChanged
        conf_useTextDetails = useTextDetails.Checked
        UpdateRPC()
    End Sub
End Class
