<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Classes))
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRemoveStudentFromClass = New System.Windows.Forms.Button()
        Me.btnAddStudentToClass = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstClasses = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAvailableStudents = New System.Windows.Forms.ListBox()
        Me.lstClassStudents = New System.Windows.Forms.ListBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEmail
        '
        Me.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmail.ForeColor = System.Drawing.Color.White
        Me.btnEmail.Location = New System.Drawing.Point(0, 278)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(107, 35)
        Me.btnEmail.TabIndex = 3
        Me.btnEmail.Text = "Email"
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'btnClasses
        '
        Me.btnClasses.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClasses.ForeColor = System.Drawing.Color.White
        Me.btnClasses.Location = New System.Drawing.Point(0, 235)
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
        Me.btnStudents.Location = New System.Drawing.Point(0, 191)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(107, 35)
        Me.btnStudents.TabIndex = 1
        Me.btnStudents.Text = "Students"
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'btnTemplate
        '
        Me.btnTemplate.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTemplate.ForeColor = System.Drawing.Color.White
        Me.btnTemplate.Location = New System.Drawing.Point(0, 147)
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
        Me.Panel2.Location = New System.Drawing.Point(0, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(107, 510)
        Me.Panel2.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Email_Sender.My.Resources.Resources.SwiftSend1
        Me.PictureBox1.Location = New System.Drawing.Point(3, -2)
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
        Me.Panel1.Location = New System.Drawing.Point(85, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 57)
        Me.Panel1.TabIndex = 38
        '
        'MinimiseBtn
        '
        Me.MinimiseBtn.AutoSize = True
        Me.MinimiseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MinimiseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimiseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MinimiseBtn.Location = New System.Drawing.Point(470, 2)
        Me.MinimiseBtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MinimiseBtn.Name = "MinimiseBtn"
        Me.MinimiseBtn.Size = New System.Drawing.Size(21, 29)
        Me.MinimiseBtn.TabIndex = 41
        Me.MinimiseBtn.Text = "-"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = True
        Me.CloseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseBtn.Location = New System.Drawing.Point(499, 9)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(20, 20)
        Me.CloseBtn.TabIndex = 40
        Me.CloseBtn.Text = "X"
        '
        'LockBtn
        '
        Me.LockBtn.AccessibleName = "LockBtn2"
        Me.LockBtn.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.LockBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LockBtn.ForeColor = System.Drawing.Color.White
        Me.LockBtn.Location = New System.Drawing.Point(387, 6)
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
        Me.Title4.Location = New System.Drawing.Point(62, 6)
        Me.Title4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title4.Name = "Title4"
        Me.Title4.Size = New System.Drawing.Size(301, 24)
        Me.Title4.TabIndex = 30
        Me.Title4.Text = "PRIEISTLEY EMAIL MANAGER"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnRemoveStudentFromClass)
        Me.Panel3.Controls.Add(Me.btnAddStudentToClass)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lstClasses)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lstAvailableStudents)
        Me.Panel3.Controls.Add(Me.lstClassStudents)
        Me.Panel3.Location = New System.Drawing.Point(124, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(471, 422)
        Me.Panel3.TabIndex = 40
        '
        'btnRemoveStudentFromClass
        '
        Me.btnRemoveStudentFromClass.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnRemoveStudentFromClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveStudentFromClass.ForeColor = System.Drawing.Color.White
        Me.btnRemoveStudentFromClass.Location = New System.Drawing.Point(305, 395)
        Me.btnRemoveStudentFromClass.Name = "btnRemoveStudentFromClass"
        Me.btnRemoveStudentFromClass.Size = New System.Drawing.Size(120, 23)
        Me.btnRemoveStudentFromClass.TabIndex = 7
        Me.btnRemoveStudentFromClass.Text = "Remove From Class"
        Me.btnRemoveStudentFromClass.UseVisualStyleBackColor = False
        '
        'btnAddStudentToClass
        '
        Me.btnAddStudentToClass.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnAddStudentToClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStudentToClass.ForeColor = System.Drawing.Color.White
        Me.btnAddStudentToClass.Location = New System.Drawing.Point(187, 196)
        Me.btnAddStudentToClass.Name = "btnAddStudentToClass"
        Me.btnAddStudentToClass.Size = New System.Drawing.Size(95, 23)
        Me.btnAddStudentToClass.TabIndex = 6
        Me.btnAddStudentToClass.Text = "Add to Class"
        Me.btnAddStudentToClass.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(164, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Select Class"
        '
        'lstClasses
        '
        Me.lstClasses.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lstClasses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstClasses.ForeColor = System.Drawing.Color.White
        Me.lstClasses.FormattingEnabled = True
        Me.lstClasses.Items.AddRange(New Object() {""})
        Me.lstClasses.Location = New System.Drawing.Point(167, 20)
        Me.lstClasses.Name = "lstClasses"
        Me.lstClasses.Size = New System.Drawing.Size(136, 156)
        Me.lstClasses.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(299, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Students in Selected Class"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Students To Add"
        '
        'lstAvailableStudents
        '
        Me.lstAvailableStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lstAvailableStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAvailableStudents.ForeColor = System.Drawing.Color.White
        Me.lstAvailableStudents.FormattingEnabled = True
        Me.lstAvailableStudents.Items.AddRange(New Object() {""})
        Me.lstAvailableStudents.Location = New System.Drawing.Point(41, 233)
        Me.lstAvailableStudents.Name = "lstAvailableStudents"
        Me.lstAvailableStudents.Size = New System.Drawing.Size(136, 156)
        Me.lstAvailableStudents.TabIndex = 1
        '
        'lstClassStudents
        '
        Me.lstClassStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lstClassStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstClassStudents.ForeColor = System.Drawing.Color.White
        Me.lstClassStudents.FormattingEnabled = True
        Me.lstClassStudents.Items.AddRange(New Object() {""})
        Me.lstClassStudents.Location = New System.Drawing.Point(296, 233)
        Me.lstClassStudents.Name = "lstClassStudents"
        Me.lstClassStudents.Size = New System.Drawing.Size(140, 156)
        Me.lstClassStudents.TabIndex = 0
        '
        'Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(609, 503)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Classes"
        Me.Text = "Classes"
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
    Friend WithEvents MinimiseBtn As Label
    Friend WithEvents CloseBtn As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lstClassStudents As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstAvailableStudents As ListBox
    Friend WithEvents lstClasses As ListBox
    Friend WithEvents btnAddStudentToClass As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemoveStudentFromClass As Button
End Class
