<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.CreateLabel = New System.Windows.Forms.Label()
        Me.MinimiseBtn = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Label()
        Me.ShowPassCheck = New System.Windows.Forms.CheckBox()
        Me.UserPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PasswordPanel = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Title4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PasswordPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(-1, -3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(201, 432)
        Me.Panel2.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(85, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Developed By"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Jack Carruthers"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Welcome to our"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "emailing system"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Email_Sender.My.Resources.Resources.SwiftSend
        Me.PictureBox3.Location = New System.Drawing.Point(-38, -30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(278, 253)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.AccessibleName = "txtUsername"
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(47, 9)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(368, 28)
        Me.txtUsername.TabIndex = 39
        '
        'txtPassword
        '
        Me.txtPassword.AccessibleName = "txtPassword"
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(47, 9)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(368, 28)
        Me.txtPassword.TabIndex = 40
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleName = "btnLogin"
        Me.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(343, 298)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(123, 23)
        Me.btnLogin.TabIndex = 41
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'CreateLabel
        '
        Me.CreateLabel.AutoSize = True
        Me.CreateLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.CreateLabel.Location = New System.Drawing.Point(355, 339)
        Me.CreateLabel.Name = "CreateLabel"
        Me.CreateLabel.Size = New System.Drawing.Size(103, 13)
        Me.CreateLabel.TabIndex = 42
        Me.CreateLabel.Text = "Create new account"
        '
        'MinimiseBtn
        '
        Me.MinimiseBtn.AutoSize = True
        Me.MinimiseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MinimiseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimiseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MinimiseBtn.Location = New System.Drawing.Point(349, 5)
        Me.MinimiseBtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MinimiseBtn.Name = "MinimiseBtn"
        Me.MinimiseBtn.Size = New System.Drawing.Size(21, 29)
        Me.MinimiseBtn.TabIndex = 44
        Me.MinimiseBtn.Text = "-"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = True
        Me.CloseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseBtn.Location = New System.Drawing.Point(378, 12)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(20, 20)
        Me.CloseBtn.TabIndex = 43
        Me.CloseBtn.Text = "X"
        '
        'ShowPassCheck
        '
        Me.ShowPassCheck.AutoSize = True
        Me.ShowPassCheck.ForeColor = System.Drawing.Color.White
        Me.ShowPassCheck.Location = New System.Drawing.Point(247, 257)
        Me.ShowPassCheck.Name = "ShowPassCheck"
        Me.ShowPassCheck.Size = New System.Drawing.Size(102, 17)
        Me.ShowPassCheck.TabIndex = 45
        Me.ShowPassCheck.Text = "Show Password"
        Me.ShowPassCheck.UseVisualStyleBackColor = True
        '
        'UserPanel
        '
        Me.UserPanel.AccessibleName = "UserPanel"
        Me.UserPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.UserPanel.Controls.Add(Me.PictureBox1)
        Me.UserPanel.Controls.Add(Me.txtUsername)
        Me.UserPanel.Location = New System.Drawing.Point(200, 144)
        Me.UserPanel.Name = "UserPanel"
        Me.UserPanel.Size = New System.Drawing.Size(418, 45)
        Me.UserPanel.TabIndex = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Email_Sender.My.Resources.Resources.WhiteUser
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PasswordPanel
        '
        Me.PasswordPanel.AccessibleName = "PasswordPanel"
        Me.PasswordPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PasswordPanel.Controls.Add(Me.PictureBox2)
        Me.PasswordPanel.Controls.Add(Me.txtPassword)
        Me.PasswordPanel.Location = New System.Drawing.Point(200, 206)
        Me.PasswordPanel.Name = "PasswordPanel"
        Me.PasswordPanel.Size = New System.Drawing.Size(418, 45)
        Me.PasswordPanel.TabIndex = 50
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Email_Sender.My.Resources.Resources.WhiteLock
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'Title4
        '
        Me.Title4.AutoSize = True
        Me.Title4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Title4.Location = New System.Drawing.Point(76, 5)
        Me.Title4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title4.Name = "Title4"
        Me.Title4.Size = New System.Drawing.Size(182, 39)
        Me.Title4.TabIndex = 30
        Me.Title4.Text = "SwiftSend"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Title4)
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.MinimiseBtn)
        Me.Panel1.Location = New System.Drawing.Point(200, -3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 57)
        Me.Panel1.TabIndex = 51
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(609, 427)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PasswordPanel)
        Me.Controls.Add(Me.UserPanel)
        Me.Controls.Add(Me.ShowPassCheck)
        Me.Controls.Add(Me.CreateLabel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserPanel.ResumeLayout(False)
        Me.UserPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PasswordPanel.ResumeLayout(False)
        Me.PasswordPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents CreateLabel As Label
    Friend WithEvents MinimiseBtn As Label
    Friend WithEvents CloseBtn As Label
    Friend WithEvents ShowPassCheck As CheckBox
    Friend WithEvents UserPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PasswordPanel As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Title4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
