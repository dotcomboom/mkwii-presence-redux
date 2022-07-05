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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
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
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(296, 9)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(0, 380)
        Me.WebView21.Source = New System.Uri("https://wiimmfi.de/stats/mkw", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 1
        Me.WebView21.Visible = False
        Me.WebView21.ZoomFactor = 1.0R
        '
        'lblAddText
        '
        Me.lblAddText.AutoSize = True
        Me.lblAddText.Location = New System.Drawing.Point(11, 9)
        Me.lblAddText.Name = "lblAddText"
        Me.lblAddText.Size = New System.Drawing.Size(166, 15)
        Me.lblAddText.TabIndex = 2
        Me.lblAddText.Text = "Additional text or Friend Code"
        '
        'txtAddText
        '
        Me.txtAddText.Location = New System.Drawing.Point(14, 27)
        Me.txtAddText.Name = "txtAddText"
        Me.txtAddText.Size = New System.Drawing.Size(260, 23)
        Me.txtAddText.TabIndex = 3
        '
        'lvInfos
        '
        Me.lvInfos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvInfos.HideSelection = False
        Me.lvInfos.Location = New System.Drawing.Point(16, 213)
        Me.lvInfos.Name = "lvInfos"
        Me.lvInfos.Size = New System.Drawing.Size(259, 154)
        Me.lvInfos.TabIndex = 8
        Me.lvInfos.UseCompatibleStateImageBehavior = False
        Me.lvInfos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Key"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 110
        '
        'txtUserURL
        '
        Me.txtUserURL.Location = New System.Drawing.Point(14, 81)
        Me.txtUserURL.Name = "txtUserURL"
        Me.txtUserURL.Size = New System.Drawing.Size(259, 23)
        Me.txtUserURL.TabIndex = 11
        '
        'lnkList
        '
        Me.lnkList.AutoSize = True
        Me.lnkList.Location = New System.Drawing.Point(11, 63)
        Me.lnkList.Name = "lnkList"
        Me.lnkList.Size = New System.Drawing.Size(114, 15)
        Me.lnkList.TabIndex = 12
        Me.lnkList.TabStop = True
        Me.lnkList.Tag = ""
        Me.lnkList.Text = "Wiimmfi Profile URL"
        '
        'btnSaveUpdate
        '
        Me.btnSaveUpdate.Location = New System.Drawing.Point(198, 119)
        Me.btnSaveUpdate.Name = "btnSaveUpdate"
        Me.btnSaveUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveUpdate.TabIndex = 13
        Me.btnSaveUpdate.Text = "Save"
        Me.btnSaveUpdate.UseVisualStyleBackColor = True
        '
        'lblTutorial
        '
        Me.lblTutorial.Location = New System.Drawing.Point(13, 154)
        Me.lblTutorial.Name = "lblTutorial"
        Me.lblTutorial.Size = New System.Drawing.Size(263, 52)
        Me.lblTutorial.TabIndex = 17
        Me.lblTutorial.Text = "To get the profile URL, find your friend code on the linked Wiimmfi page during a" &
    " match, right click the 👁 icon and copy the link."
        '
        'btnOpenClose
        '
        Me.btnOpenClose.Location = New System.Drawing.Point(199, 373)
        Me.btnOpenClose.Name = "btnOpenClose"
        Me.btnOpenClose.Size = New System.Drawing.Size(76, 23)
        Me.btnOpenClose.TabIndex = 18
        Me.btnOpenClose.Text = ">> Expand"
        Me.btnOpenClose.UseVisualStyleBackColor = True
        '
        'lnkGithub
        '
        Me.lnkGithub.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkGithub.AutoSize = True
        Me.lnkGithub.Location = New System.Drawing.Point(13, 377)
        Me.lnkGithub.Name = "lnkGithub"
        Me.lnkGithub.Size = New System.Drawing.Size(43, 15)
        Me.lnkGithub.TabIndex = 20
        Me.lnkGithub.TabStop = True
        Me.lnkGithub.Text = "Github"
        '
        'chkShare
        '
        Me.chkShare.AutoSize = True
        Me.chkShare.Location = New System.Drawing.Point(14, 110)
        Me.chkShare.Name = "chkShare"
        Me.chkShare.Size = New System.Drawing.Size(128, 19)
        Me.chkShare.TabIndex = 21
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
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(319, 11)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(49, 23)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(290, 401)
        Me.Controls.Add(Me.chkShare)
        Me.Controls.Add(Me.lnkGithub)
        Me.Controls.Add(Me.btnOpenClose)
        Me.Controls.Add(Me.lblTutorial)
        Me.Controls.Add(Me.btnSaveUpdate)
        Me.Controls.Add(Me.lnkList)
        Me.Controls.Add(Me.txtUserURL)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lvInfos)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAddText)
        Me.Controls.Add(Me.lblAddText)
        Me.Controls.Add(Me.WebView21)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "MKWii-RPRedux"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
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
End Class
