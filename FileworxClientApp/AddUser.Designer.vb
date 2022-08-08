<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddUserCancelButton = New System.Windows.Forms.Button()
        Me.SignUp = New System.Windows.Forms.Button()
        Me.passwordSignUp = New System.Windows.Forms.TextBox()
        Me.loginNameSignUp = New System.Windows.Forms.TextBox()
        Me.nameSignUp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddUserCancelButton)
        Me.Panel1.Controls.Add(Me.SignUp)
        Me.Panel1.Controls.Add(Me.passwordSignUp)
        Me.Panel1.Controls.Add(Me.loginNameSignUp)
        Me.Panel1.Controls.Add(Me.nameSignUp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NameLabel)
        Me.Panel1.Location = New System.Drawing.Point(22, 37)
        Me.Panel1.MaximumSize = New System.Drawing.Size(1000, 0)
        Me.Panel1.MinimumSize = New System.Drawing.Size(592, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Panel1.Size = New System.Drawing.Size(592, 143)
        Me.Panel1.TabIndex = 64
        '
        'AddUserCancelButton
        '
        Me.AddUserCancelButton.BackColor = System.Drawing.Color.DimGray
        Me.AddUserCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddUserCancelButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.AddUserCancelButton.ForeColor = System.Drawing.Color.White
        Me.AddUserCancelButton.Location = New System.Drawing.Point(424, 90)
        Me.AddUserCancelButton.Name = "AddUserCancelButton"
        Me.AddUserCancelButton.Size = New System.Drawing.Size(92, 26)
        Me.AddUserCancelButton.TabIndex = 71
        Me.AddUserCancelButton.Text = "Cancel"
        Me.AddUserCancelButton.UseVisualStyleBackColor = False
        '
        'SignUp
        '
        Me.SignUp.BackColor = System.Drawing.Color.SteelBlue
        Me.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignUp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SignUp.ForeColor = System.Drawing.Color.White
        Me.SignUp.Location = New System.Drawing.Point(326, 90)
        Me.SignUp.Name = "SignUp"
        Me.SignUp.Size = New System.Drawing.Size(92, 26)
        Me.SignUp.TabIndex = 70
        Me.SignUp.Text = "Save"
        Me.SignUp.UseVisualStyleBackColor = False
        '
        'passwordSignUp
        '
        Me.passwordSignUp.Location = New System.Drawing.Point(131, 64)
        Me.passwordSignUp.Name = "passwordSignUp"
        Me.passwordSignUp.Size = New System.Drawing.Size(385, 20)
        Me.passwordSignUp.TabIndex = 69
        Me.passwordSignUp.UseSystemPasswordChar = True
        '
        'loginNameSignUp
        '
        Me.loginNameSignUp.Location = New System.Drawing.Point(131, 39)
        Me.loginNameSignUp.Name = "loginNameSignUp"
        Me.loginNameSignUp.Size = New System.Drawing.Size(385, 20)
        Me.loginNameSignUp.TabIndex = 68
        '
        'nameSignUp
        '
        Me.nameSignUp.Location = New System.Drawing.Point(131, 15)
        Me.nameSignUp.Name = "nameSignUp"
        Me.nameSignUp.Size = New System.Drawing.Size(385, 20)
        Me.nameSignUp.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(19, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(19, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Login Name"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NameLabel.ForeColor = System.Drawing.Color.DimGray
        Me.NameLabel.Location = New System.Drawing.Point(19, 13)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(56, 21)
        Me.NameLabel.TabIndex = 64
        Me.NameLabel.Text = "Name"
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "AddUser"
        Me.Text = "AddUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SignUp As Button
    Friend WithEvents passwordSignUp As TextBox
    Friend WithEvents loginNameSignUp As TextBox
    Friend WithEvents nameSignUp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddUserCancelButton As Button
End Class
