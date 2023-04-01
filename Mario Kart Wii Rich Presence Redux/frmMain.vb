Imports System.Text.RegularExpressions
Imports DiscordRPC
Imports DiscordRPC.Logging

Public Class frmMain
    Private details As String = ""
    Private state As String = ""
    Private track As String = ""
    Private large_image As String = ""
    Private small_image As String = ""
    Private party_size As Integer = 0

    Public default_app_id = "662481965840072717"

    Private client As DiscordRpcClient

    Private Async Sub WebView21_NavigationCompletedAsync(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        TextBox3.Text = WebView21.Source.AbsoluteUri

        'get profile url
        Dim rgx As Regex = New Regex("p([0-9])+")
        Dim matches = rgx.Matches(WebView21.Source.AbsoluteUri)
        'CheckBox1.Checked = matches.Count > 0
        If matches.Count > 0 Then

            TextBox2.Text = WebView21.Source.AbsoluteUri
            My.Settings.startUrl = WebView21.Source

            'scraping :)
            ' <a href="https://ct.wiimm.de/i/3459">N64 Sherbet Land (Nintendo)</a>
            Dim html As String
            html = Await WebView21.ExecuteScriptAsync("document.documentElement.outerHTML;")

            ' "The Html comes back with unicode character codes, other escaped characters, and
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


            Dim trackrgx As Regex = New Regex("Last track: .*>(.*) \(Nintendo\)</a>")
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
            large_image = track.Replace(" ", "").Replace("'", "").ToLower()

            If details = "Not in a room" Then
                large_image = "placeholder"
                state = My.Settings.addText
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


            Dim pres As New RichPresence() With {
                               .Details = details,
                               .State = state,
                               .Assets = New Assets() With {
                               .LargeImageKey = large_image,
                               .SmallImageKey = small_image,
                               .LargeImageText = track,
                               .SmallImageText = txtAddText.Text}}

            If My.Settings.shareBtn Then
                Dim btn As New DiscordRPC.Button
                btn.Url = txtUserURL.Text
                btn.Label = "View details"
                pres.Buttons = {btn}
            End If

            client.SetPresence(pres)

        End If


    End Sub

    Private Sub Form1_Load() Handles MyBase.Load
        If My.Settings.startUrl.AbsolutePath = "about:blank" Then
            My.Settings.startUrl = New Uri("https://wiimmfi.de/stats/mkw/room/p")
        End If
        chkShare.Checked = My.Settings.shareBtn
        txtUserURL.Text = My.Settings.startUrl.AbsoluteUri
        WebView21.Source = My.Settings.startUrl
        txtAddText.Text = My.Settings.addText

        useOwnApp.Checked = My.Settings.useOwnApp

        init_client()
    End Sub
    Private Sub init_client()
        If My.Settings.useOwnApp Then
            Try
                client = New DiscordRpcClient(My.Settings.userAppId)
            Catch ex As Exception
                MsgBox(ex.Message & "\r\nUsing own application ID has been disabled.", MsgBoxStyle.Exclamation)
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
            .State = "Starting up (or configuring)",
            .Assets = New Assets() With {
                .LargeImageKey = "placeholder",
                .LargeImageText = "MKWii-RPRedux",
                .SmallImageKey = "mario"
            }
        })
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveUpdate.Click
        My.Settings.addText = txtAddText.Text
        WebView21.CoreWebView2.Navigate(txtUserURL.Text)
    End Sub

    Private Sub lnkList_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkList.LinkClicked
        Process.Start("https://wiimmfi.de/stats/mkw/")
    End Sub

    Private Sub btnOpenClose_Click(sender As Object, e As EventArgs) Handles btnOpenClose.Click
        If Me.Tag = "expanded" Then
            Me.Tag = ""
            Me.Size = New Size(306, 440)
            Me.MaximizeBox = False
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            btnOpenClose.Text = "Expand >>"
        Else
            Me.Tag = "expanded"
            Me.Size = New Size(784, 440)
            Me.MaximizeBox = True
            Me.FormBorderStyle = FormBorderStyle.Sizable
            btnOpenClose.Text = "<< Retract"
        End If
        WebView21.Visible = Me.Tag = "expanded"
    End Sub

    Private Sub LinkGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGithub.LinkClicked
        Process.Start("https://github.com/dotcomboom/mkwii-rpredux")
    End Sub

    Private Sub chkShare_CheckedChanged(sender As Object, e As EventArgs) Handles chkShare.CheckedChanged
        My.Settings.shareBtn = chkShare.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles useOwnApp.Click
        If useOwnApp.Checked Then
            frmOwnRPC.ClientId.Text = My.Settings.userAppId
            If frmOwnRPC.ShowDialog = DialogResult.OK Then
                My.Settings.userAppId = frmOwnRPC.ClientId.Text
            Else
                useOwnApp.Checked = False
            End If
        End If
        If My.Settings.userAppId = "" Then
            useOwnApp.Checked = False
        End If
        My.Settings.useOwnApp = useOwnApp.Checked
        client.ClearPresence()
        client.Dispose()
        init_client()
    End Sub
End Class
