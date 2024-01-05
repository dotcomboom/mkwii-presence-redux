<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
		Me.lblAddText = New System.Windows.Forms.Label()
		Me.txtAddText = New System.Windows.Forms.TextBox()
		Me.lvInfos = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.txtUserURL = New System.Windows.Forms.TextBox()
		Me.lnkList = New System.Windows.Forms.LinkLabel()
		Me.btnSaveUpdate = New System.Windows.Forms.Button()
		Me.lblTutorial = New System.Windows.Forms.Label()
		Me.btnOpenClose = New System.Windows.Forms.Button()
		Me.lnkGithub = New System.Windows.Forms.LinkLabel()
		Me.chkShare = New System.Windows.Forms.CheckBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.useOwnApp = New System.Windows.Forms.CheckBox()
		Me.useTrackState = New System.Windows.Forms.CheckBox()
		Me.useTextDetails = New System.Windows.Forms.CheckBox()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'webView
		'
		Me.webView.AllowExternalDrop = True
		Me.webView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.webView.CreationProperties = Nothing
		Me.webView.DefaultBackgroundColor = System.Drawing.Color.White
		Me.webView.Location = New System.Drawing.Point(280, 7)
		Me.webView.Name = "webView"
		Me.webView.Size = New System.Drawing.Size(284, 423)
		Me.webView.Source = New System.Uri("https://wiimmfi.de/stats/mkw", System.UriKind.Absolute)
		Me.webView.TabIndex = 13
		Me.webView.Visible = False
		Me.webView.ZoomFactor = 1.0R
		'
		'lblAddText
		'
		Me.lblAddText.AutoSize = True
		Me.lblAddText.Location = New System.Drawing.Point(9, 9)
		Me.lblAddText.Name = "lblAddText"
		Me.lblAddText.Size = New System.Drawing.Size(85, 15)
		Me.lblAddText.TabIndex = 1
		Me.lblAddText.Text = "Additional text"
		'
		'txtAddText
		'
		Me.txtAddText.Location = New System.Drawing.Point(12, 27)
		Me.txtAddText.Name = "txtAddText"
		Me.txtAddText.Size = New System.Drawing.Size(260, 23)
		Me.txtAddText.TabIndex = 2
		'
		'lvInfos
		'
		Me.lvInfos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
		Me.lvInfos.HideSelection = False
		Me.lvInfos.Location = New System.Drawing.Point(12, 191)
		Me.lvInfos.Name = "lvInfos"
		Me.lvInfos.Size = New System.Drawing.Size(260, 135)
		Me.lvInfos.TabIndex = 10
		Me.lvInfos.UseCompatibleStateImageBehavior = False
		Me.lvInfos.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "Key"
		Me.ColumnHeader1.Width = 94
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "Value"
		Me.ColumnHeader2.Width = 162
		'
		'txtUserURL
		'
		Me.txtUserURL.Location = New System.Drawing.Point(12, 80)
		Me.txtUserURL.Name = "txtUserURL"
		Me.txtUserURL.Size = New System.Drawing.Size(260, 23)
		Me.txtUserURL.TabIndex = 4
		'
		'lnkList
		'
		Me.lnkList.AutoSize = True
		Me.lnkList.Location = New System.Drawing.Point(10, 62)
		Me.lnkList.Name = "lnkList"
		Me.lnkList.Size = New System.Drawing.Size(114, 15)
		Me.lnkList.TabIndex = 3
		Me.lnkList.TabStop = True
		Me.lnkList.Tag = ""
		Me.lnkList.Text = "Wiimmfi Profile URL"
		Me.ToolTip1.SetToolTip(Me.lnkList, "To get the profile URL, find your friend code on the linked Wiimmfi page during a" &
		" match, right click the 👁 icon and copy the link.")
		'
		'btnSaveUpdate
		'
		Me.btnSaveUpdate.Location = New System.Drawing.Point(197, 109)
		Me.btnSaveUpdate.Name = "btnSaveUpdate"
		Me.btnSaveUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnSaveUpdate.TabIndex = 6
		Me.btnSaveUpdate.Text = "Save"
		Me.btnSaveUpdate.UseVisualStyleBackColor = True
		'
		'lblTutorial
		'
		Me.lblTutorial.Location = New System.Drawing.Point(9, 138)
		Me.lblTutorial.Name = "lblTutorial"
		Me.lblTutorial.Size = New System.Drawing.Size(263, 52)
		Me.lblTutorial.TabIndex = 7
		Me.lblTutorial.Text = "To get the profile URL, find your friend code on the linked Wiimmfi page during a" &
	" match, right click the 👁 icon and copy the link."
		'
		'btnOpenClose
		'
		Me.btnOpenClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnOpenClose.Location = New System.Drawing.Point(196, 407)
		Me.btnOpenClose.Name = "btnOpenClose"
		Me.btnOpenClose.Size = New System.Drawing.Size(76, 23)
		Me.btnOpenClose.TabIndex = 12
		Me.btnOpenClose.Text = ">> Expand"
		Me.btnOpenClose.UseVisualStyleBackColor = True
		'
		'lnkGithub
		'
		Me.lnkGithub.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lnkGithub.AutoSize = True
		Me.lnkGithub.Location = New System.Drawing.Point(9, 411)
		Me.lnkGithub.Name = "lnkGithub"
		Me.lnkGithub.Size = New System.Drawing.Size(43, 15)
		Me.lnkGithub.TabIndex = 11
		Me.lnkGithub.TabStop = True
		Me.lnkGithub.Text = "Github"
		'
		'chkShare
		'
		Me.chkShare.AutoSize = True
		Me.chkShare.Location = New System.Drawing.Point(12, 109)
		Me.chkShare.Name = "chkShare"
		Me.chkShare.Size = New System.Drawing.Size(128, 19)
		Me.chkShare.TabIndex = 5
		Me.chkShare.Text = "Share link on status"
		Me.chkShare.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(316, 94)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 15)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Watching profile"
		Me.Label2.Visible = False
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(319, 112)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = True
		Me.TextBox2.Size = New System.Drawing.Size(92, 23)
		Me.TextBox2.TabIndex = 99999
		Me.TextBox2.Visible = False
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(319, 11)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.ReadOnly = True
		Me.TextBox3.Size = New System.Drawing.Size(49, 23)
		Me.TextBox3.TabIndex = 9999
		Me.TextBox3.Visible = False
		'
		'useOwnApp
		'
		Me.useOwnApp.AutoSize = True
		Me.useOwnApp.Location = New System.Drawing.Point(12, 384)
		Me.useOwnApp.Name = "useOwnApp"
		Me.useOwnApp.Size = New System.Drawing.Size(193, 19)
		Me.useOwnApp.TabIndex = 9
		Me.useOwnApp.Text = "Use custom Discord application"
		Me.useOwnApp.UseVisualStyleBackColor = True
		'
		'useTrackState
		'
		Me.useTrackState.AutoSize = True
		Me.useTrackState.Location = New System.Drawing.Point(12, 334)
		Me.useTrackState.Name = "useTrackState"
		Me.useTrackState.Size = New System.Drawing.Size(251, 19)
		Me.useTrackState.TabIndex = 7
		Me.useTrackState.Text = "Display current track in State during match"
		Me.useTrackState.UseVisualStyleBackColor = True
		'
		'useTextDetails
		'
		Me.useTextDetails.AutoSize = True
		Me.useTextDetails.Location = New System.Drawing.Point(12, 359)
		Me.useTextDetails.Name = "useTextDetails"
		Me.useTextDetails.Size = New System.Drawing.Size(239, 19)
		Me.useTextDetails.TabIndex = 8
		Me.useTextDetails.Text = "Display own text in Details during match"
		Me.useTextDetails.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(574, 436)
		Me.Controls.Add(Me.useTextDetails)
		Me.Controls.Add(Me.lblTutorial)
		Me.Controls.Add(Me.txtAddText)
		Me.Controls.Add(Me.lblAddText)
		Me.Controls.Add(Me.useTrackState)
		Me.Controls.Add(Me.useOwnApp)
		Me.Controls.Add(Me.chkShare)
		Me.Controls.Add(Me.lnkGithub)
		Me.Controls.Add(Me.btnOpenClose)
		Me.Controls.Add(Me.btnSaveUpdate)
		Me.Controls.Add(Me.lnkList)
		Me.Controls.Add(Me.txtUserURL)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.lvInfos)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.webView)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(300, 475)
		Me.Name = "frmMain"
		Me.Text = "MKWii-RPRedux"
		CType(Me.webView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents lblAddText As Label
    Friend WithEvents txtAddText As TextBox
    Friend WithEvents lvInfos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents txtUserURL As TextBox
    Friend WithEvents lnkList As LinkLabel
    Friend WithEvents btnSaveUpdate As Button
    Friend WithEvents lblTutorial As Label
    Friend WithEvents btnOpenClose As Button
    Friend WithEvents lnkGithub As LinkLabel
    Friend WithEvents chkShare As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents useOwnApp As CheckBox
	Friend WithEvents useTrackState As CheckBox
	Friend WithEvents useTextDetails As CheckBox
	Friend WithEvents ToolTip1 As ToolTip
End Class
