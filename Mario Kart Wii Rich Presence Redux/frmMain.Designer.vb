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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkGithub = New System.Windows.Forms.LinkLabel()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Friend Code (cosmetic)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 23)
        Me.TextBox1.TabIndex = 3
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
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 213)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(259, 154)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(319, 11)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(49, 23)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(14, 81)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(259, 23)
        Me.TextBox4.TabIndex = 11
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(11, 63)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(114, 15)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Tag = ""
        Me.LinkLabel1.Text = "Wiimmfi Profile URL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 52)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "To get the watch URL, find your friend code on the linked Wiimmfi page during a m" &
    "atch, right click the 👁 icon and copy the link."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(199, 373)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = ">> Expand"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(14, 110)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 19)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Active!"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkGithub
        '
        Me.LinkGithub.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkGithub.AutoSize = True
        Me.LinkGithub.Location = New System.Drawing.Point(13, 377)
        Me.LinkGithub.Name = "LinkGithub"
        Me.LinkGithub.Size = New System.Drawing.Size(43, 15)
        Me.LinkGithub.TabIndex = 20
        Me.LinkGithub.TabStop = True
        Me.LinkGithub.Text = "Github"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(290, 401)
        Me.Controls.Add(Me.LinkGithub)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebView21)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MKW Rich Presence Redux"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkGithub As LinkLabel
End Class
