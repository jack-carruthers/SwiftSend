<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Email))
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.btnClasses = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnTemplate = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MinimiseBtn = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Label()
        Me.LockBtn = New System.Windows.Forms.Button()
        Me.Title4 = New System.Windows.Forms.Label()
        Me.txtEmailSubject = New System.Windows.Forms.TextBox()
        Me.txtEmailBody = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkSelectByClass = New System.Windows.Forms.CheckBox()
        Me.btnLoadTemplate = New System.Windows.Forms.Button()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkClasses = New System.Windows.Forms.CheckedListBox()
        Me.chkStudents = New System.Windows.Forms.CheckedListBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmail.ForeColor = System.Drawing.Color.White
        Me.btnEmail.Location = New System.Drawing.Point(1, 278)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(107, 35)
        Me.btnEmail.TabIndex = 3
        Me.btnEmail.Text = "Email"
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'btnClasses
        '
        Me.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClasses.ForeColor = System.Drawing.Color.White
        Me.btnClasses.Location = New System.Drawing.Point(1, 235)
        Me.btnClasses.Name = "btnClasses"
        Me.btnClasses.Size = New System.Drawing.Size(107, 35)
        Me.btnClasses.TabIndex = 2
        Me.btnClasses.Text = "Classes"
        Me.btnClasses.UseVisualStyleBackColor = False
        '
        'btnStudents
        '
        Me.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudents.ForeColor = System.Drawing.Color.White
        Me.btnStudents.Location = New System.Drawing.Point(1, 191)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(107, 35)
        Me.btnStudents.TabIndex = 1
        Me.btnStudents.Text = "Students"
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'btnTemplate
        '
        Me.btnTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTemplate.ForeColor = System.Drawing.Color.White
        Me.btnTemplate.Location = New System.Drawing.Point(1, 147)
        Me.btnTemplate.Name = "btnTemplate"
        Me.btnTemplate.Size = New System.Drawing.Size(107, 35)
        Me.btnTemplate.TabIndex = 0
        Me.btnTemplate.Text = "Templates"
        Me.btnTemplate.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnEmail)
        Me.Panel2.Controls.Add(Me.btnClasses)
        Me.Panel2.Controls.Add(Me.btnStudents)
        Me.Panel2.Controls.Add(Me.btnTemplate)
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(109, 586)
        Me.Panel2.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Email_Sender.My.Resources.Resources.SwiftSend1
        Me.PictureBox1.Location = New System.Drawing.Point(4, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimiseBtn)
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.LockBtn)
        Me.Panel1.Controls.Add(Me.Title4)
        Me.Panel1.Location = New System.Drawing.Point(83, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 57)
        Me.Panel1.TabIndex = 42
        '
        'MinimiseBtn
        '
        Me.MinimiseBtn.AutoSize = True
        Me.MinimiseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MinimiseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimiseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MinimiseBtn.Location = New System.Drawing.Point(473, 1)
        Me.MinimiseBtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MinimiseBtn.Name = "MinimiseBtn"
        Me.MinimiseBtn.Size = New System.Drawing.Size(21, 29)
        Me.MinimiseBtn.TabIndex = 51
        Me.MinimiseBtn.Text = "-"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = True
        Me.CloseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseBtn.Location = New System.Drawing.Point(502, 8)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(20, 20)
        Me.CloseBtn.TabIndex = 50
        Me.CloseBtn.Text = "X"
        '
        'LockBtn
        '
        Me.LockBtn.AccessibleName = "LockBtn2"
        Me.LockBtn.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.LockBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LockBtn.ForeColor = System.Drawing.Color.White
        Me.LockBtn.Location = New System.Drawing.Point(388, 6)
        Me.LockBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LockBtn.Name = "LockBtn"
        Me.LockBtn.Size = New System.Drawing.Size(71, 20)
        Me.LockBtn.TabIndex = 38
        Me.LockBtn.Text = "Lock"
        Me.LockBtn.UseVisualStyleBackColor = False
        '
        'Title4
        '
        Me.Title4.AutoSize = True
        Me.Title4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Title4.Location = New System.Drawing.Point(63, 6)
        Me.Title4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title4.Name = "Title4"
        Me.Title4.Size = New System.Drawing.Size(301, 24)
        Me.Title4.TabIndex = 30
        Me.Title4.Text = "PRIEISTLEY EMAIL MANAGER"
        '
        'txtEmailSubject
        '
        Me.txtEmailSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtEmailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailSubject.ForeColor = System.Drawing.Color.White
        Me.txtEmailSubject.Location = New System.Drawing.Point(47, 177)
        Me.txtEmailSubject.Name = "txtEmailSubject"
        Me.txtEmailSubject.Size = New System.Drawing.Size(383, 22)
        Me.txtEmailSubject.TabIndex = 44
        '
        'txtEmailBody
        '
        Me.txtEmailBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtEmailBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailBody.ForeColor = System.Drawing.Color.White
        Me.txtEmailBody.Location = New System.Drawing.Point(47, 231)
        Me.txtEmailBody.Multiline = True
        Me.txtEmailBody.Name = "txtEmailBody"
        Me.txtEmailBody.Size = New System.Drawing.Size(383, 223)
        Me.txtEmailBody.TabIndex = 45
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel3.Controls.Add(Me.chkStudents)
        Me.Panel3.Controls.Add(Me.chkClasses)
        Me.Panel3.Controls.Add(Me.chkSelectByClass)
        Me.Panel3.Controls.Add(Me.btnLoadTemplate)
        Me.Panel3.Controls.Add(Me.btnSendEmail)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtEmailSubject)
        Me.Panel3.Controls.Add(Me.txtEmailBody)
        Me.Panel3.Location = New System.Drawing.Point(121, 67)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(477, 501)
        Me.Panel3.TabIndex = 43
        '
        'chkSelectByClass
        '
        Me.chkSelectByClass.AutoSize = True
        Me.chkSelectByClass.ForeColor = System.Drawing.Color.White
        Me.chkSelectByClass.Location = New System.Drawing.Point(134, 5)
        Me.chkSelectByClass.Name = "chkSelectByClass"
        Me.chkSelectByClass.Size = New System.Drawing.Size(136, 17)
        Me.chkSelectByClass.TabIndex = 52
        Me.chkSelectByClass.Text = "Check For Class Select"
        Me.chkSelectByClass.UseVisualStyleBackColor = True
        '
        'btnLoadTemplate
        '
        Me.btnLoadTemplate.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnLoadTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadTemplate.ForeColor = System.Drawing.Color.White
        Me.btnLoadTemplate.Location = New System.Drawing.Point(359, 3)
        Me.btnLoadTemplate.Name = "btnLoadTemplate"
        Me.btnLoadTemplate.Size = New System.Drawing.Size(99, 25)
        Me.btnLoadTemplate.TabIndex = 49
        Me.btnLoadTemplate.Text = "Open Template"
        Me.btnLoadTemplate.UseVisualStyleBackColor = False
        '
        'btnSendEmail
        '
        Me.btnSendEmail.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendEmail.ForeColor = System.Drawing.Color.White
        Me.btnSendEmail.Location = New System.Drawing.Point(183, 469)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(105, 23)
        Me.btnSendEmail.TabIndex = 48
        Me.btnSendEmail.Text = "Send"
        Me.btnSendEmail.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Body"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Subject"
        '
        'chkClasses
        '
        Me.chkClasses.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.chkClasses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkClasses.ForeColor = System.Drawing.Color.White
        Me.chkClasses.FormattingEnabled = True
        Me.chkClasses.Location = New System.Drawing.Point(47, 39)
        Me.chkClasses.Name = "chkClasses"
        Me.chkClasses.Size = New System.Drawing.Size(120, 90)
        Me.chkClasses.TabIndex = 53
        '
        'chkStudents
        '
        Me.chkStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.chkStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkStudents.ForeColor = System.Drawing.Color.White
        Me.chkStudents.FormattingEnabled = True
        Me.chkStudents.Location = New System.Drawing.Point(218, 39)
        Me.chkStudents.Name = "chkStudents"
        Me.chkStudents.Size = New System.Drawing.Size(120, 90)
        Me.chkStudents.TabIndex = 54
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(609, 579)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Email"
        Me.Text = "Email"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEmail As Button
    Friend WithEvents btnClasses As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnTemplate As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LockBtn As Button
    Friend WithEvents Title4 As Label
    Friend WithEvents txtEmailSubject As TextBox
    Friend WithEvents txtEmailBody As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoadTemplate As Button
    Friend WithEvents btnSendEmail As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MinimiseBtn As Label
    Friend WithEvents CloseBtn As Label
    Friend WithEvents chkSelectByClass As CheckBox
    Friend WithEvents chkStudents As CheckedListBox
    Friend WithEvents chkClasses As CheckedListBox
End Class
