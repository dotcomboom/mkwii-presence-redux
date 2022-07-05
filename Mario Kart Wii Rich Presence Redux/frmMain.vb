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

    Private client As DiscordRpcClient

    Private Async Sub WebView21_NavigationCompletedAsync(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        TextBox3.Text = WebView21.Source.AbsoluteUri

        'get profile url
        Dim rgx As Regex = New Regex("p([0-9])+")
        Dim matches = rgx.Matches(WebView21.Source.AbsoluteUri)
        CheckBox1.Checked = matches.Count > 0
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


            ListView1.Items.Clear()
            Dim d As New ListViewItem
            d.Text = "Details"
            d.SubItems.Add(details)
            ListView1.Items.Add(d)
            Dim s As New ListViewItem
            s.Text = "State"
            s.SubItems.Add(state)
            ListView1.Items.Add(s)
            Dim t As New ListViewItem
            t.Text = "Track"
            t.SubItems.Add(track)
            ListView1.Items.Add(t)
            Dim li As New ListViewItem
            li.Text = "Large image"
            li.SubItems.Add(large_image)
            ListView1.Items.Add(li)
            Dim si As New ListViewItem
            si.Text = "Small image"
            si.SubItems.Add(small_image)
            ListView1.Items.Add(si)

            client.SetPresence(New RichPresence() With {
                               .Details = details,
                               .State = state,
                               .Assets = New Assets() With {
                               .LargeImageKey = large_image,
                               .SmallImageKey = small_image,
                               .LargeImageText = track,
                               .SmallImageText = TextBox1.Text}})

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.startUrl.AbsolutePath = "about:blank" Then
            My.Settings.startUrl = New Uri("https://wiimmfi.de/stats/mkw/room/p")
        End If
        TextBox4.Text = My.Settings.startUrl.AbsoluteUri
        WebView21.Source = My.Settings.startUrl

        client = New DiscordRpcClient("662481965840072717")
        client.Logger = New ConsoleLogger() With {
            .Level = LogLevel.Warning
        }

        client.Initialize()
        client.SetPresence(New RichPresence() With {
            .Details = "Example Project",
            .State = "csharp example",
            .Assets = New Assets() With {
                .LargeImageKey = "image_large",
                .LargeImageText = "Lachee's Discord IPC Library",
                .SmallImageKey = "image_small"
            }
        })
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebView21.CoreWebView2.Navigate(TextBox4.Text)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://wiimmfi.de/stats/mkw/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.Tag = "expanded" Then
            Me.Tag = ""
            Me.Size = New Size(306, 440)
            Me.MaximizeBox = False
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Button2.Text = "Expand >>"
        Else
            Me.Tag = "expanded"
            Me.Size = New Size(784, 440)
            Me.MaximizeBox = True
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Button2.Text = "<< Retract"
        End If
        WebView21.Visible = Me.Tag = "expanded"
    End Sub

    Private Sub LinkGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkGithub.LinkClicked
        Process.Start("https://github.com/dotcomboom/mkwii-rpredux")
    End Sub
End Class
