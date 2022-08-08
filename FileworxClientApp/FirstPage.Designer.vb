<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FirstPage
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.passwordSignIn = New System.Windows.Forms.TextBox()
        Me.loginNameSignIn = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(1, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 261)
        Me.Panel2.TabIndex = 55
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Login)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.passwordSignIn)
        Me.Panel1.Controls.Add(Me.loginNameSignIn)
        Me.Panel1.Location = New System.Drawing.Point(0, 19)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 218)
        Me.Panel1.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(20, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 21)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Name"
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.SteelBlue
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Login.ForeColor = System.Drawing.Color.White
        Me.Login.Location = New System.Drawing.Point(494, 121)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(92, 26)
        Me.Login.TabIndex = 53
        Me.Login.Text = "Sign In"
        Me.Login.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(20, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 21)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Password"
        '
        'passwordSignIn
        '
        Me.passwordSignIn.Location = New System.Drawing.Point(112, 95)
        Me.passwordSignIn.Name = "passwordSignIn"
        Me.passwordSignIn.Size = New System.Drawing.Size(474, 20)
        Me.passwordSignIn.TabIndex = 52
        Me.passwordSignIn.UseSystemPasswordChar = True
        '
        'loginNameSignIn
        '
        Me.loginNameSignIn.Location = New System.Drawing.Point(112, 70)
        Me.loginNameSignIn.Name = "loginNameSignIn"
        Me.loginNameSignIn.Size = New System.Drawing.Size(474, 20)
        Me.loginNameSignIn.TabIndex = 51
        '
        'FirstPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(786, 461)
        Me.Controls.Add(Me.Panel2)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FirstPage"
        Me.Text = "FirstPage"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Login As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents passwordSignIn As TextBox
    Friend WithEvents loginNameSignIn As TextBox
End Class
