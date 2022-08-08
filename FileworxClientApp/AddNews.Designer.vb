<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNews
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
        Me.AddNewsPanel = New System.Windows.Forms.Panel()
        Me.NewsSaveButton = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NewsCategory = New System.Windows.Forms.ComboBox()
        Me.NewsDesc = New System.Windows.Forms.TextBox()
        Me.NewsTitle = New System.Windows.Forms.TextBox()
        Me.NewsBody = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddNewsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddNewsPanel
        '
        Me.AddNewsPanel.Controls.Add(Me.NewsSaveButton)
        Me.AddNewsPanel.Controls.Add(Me.Cancel)
        Me.AddNewsPanel.Controls.Add(Me.Label7)
        Me.AddNewsPanel.Controls.Add(Me.Label4)
        Me.AddNewsPanel.Controls.Add(Me.NewsCategory)
        Me.AddNewsPanel.Controls.Add(Me.NewsDesc)
        Me.AddNewsPanel.Controls.Add(Me.NewsTitle)
        Me.AddNewsPanel.Controls.Add(Me.NewsBody)
        Me.AddNewsPanel.Controls.Add(Me.Label2)
        Me.AddNewsPanel.Controls.Add(Me.Label6)
        Me.AddNewsPanel.Controls.Add(Me.Label8)
        Me.AddNewsPanel.Location = New System.Drawing.Point(12, 12)
        Me.AddNewsPanel.MaximumSize = New System.Drawing.Size(1000, 0)
        Me.AddNewsPanel.MinimumSize = New System.Drawing.Size(573, 296)
        Me.AddNewsPanel.Name = "AddNewsPanel"
        Me.AddNewsPanel.Size = New System.Drawing.Size(573, 296)
        Me.AddNewsPanel.TabIndex = 50
        '
        'NewsSaveButton
        '
        Me.NewsSaveButton.BackColor = System.Drawing.Color.SteelBlue
        Me.NewsSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewsSaveButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.NewsSaveButton.ForeColor = System.Drawing.Color.White
        Me.NewsSaveButton.Location = New System.Drawing.Point(380, 217)
        Me.NewsSaveButton.Name = "NewsSaveButton"
        Me.NewsSaveButton.Size = New System.Drawing.Size(92, 26)
        Me.NewsSaveButton.TabIndex = 70
        Me.NewsSaveButton.Text = "Save"
        Me.NewsSaveButton.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.DimGray
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(478, 217)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(92, 26)
        Me.Cancel.TabIndex = 69
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(14, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 21)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Body"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 67
        '
        'NewsCategory
        '
        Me.NewsCategory.CausesValidation = False
        Me.NewsCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NewsCategory.FormattingEnabled = True
        Me.NewsCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NewsCategory.Location = New System.Drawing.Point(122, 61)
        Me.NewsCategory.Name = "NewsCategory"
        Me.NewsCategory.Size = New System.Drawing.Size(448, 21)
        Me.NewsCategory.TabIndex = 66
        '
        'NewsDesc
        '
        Me.NewsDesc.Location = New System.Drawing.Point(122, 36)
        Me.NewsDesc.Name = "NewsDesc"
        Me.NewsDesc.Size = New System.Drawing.Size(448, 20)
        Me.NewsDesc.TabIndex = 65
        '
        'NewsTitle
        '
        Me.NewsTitle.Location = New System.Drawing.Point(122, 12)
        Me.NewsTitle.Name = "NewsTitle"
        Me.NewsTitle.Size = New System.Drawing.Size(448, 20)
        Me.NewsTitle.TabIndex = 64
        '
        'NewsBody
        '
        Me.NewsBody.BackColor = System.Drawing.SystemColors.Window
        Me.NewsBody.Location = New System.Drawing.Point(122, 87)
        Me.NewsBody.Name = "NewsBody"
        Me.NewsBody.Size = New System.Drawing.Size(448, 124)
        Me.NewsBody.TabIndex = 60
        Me.NewsBody.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(14, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(14, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 21)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(14, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 21)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Title"
        '
        'AddNews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.AddNewsPanel)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "AddNews"
        Me.Text = "AddNews"
        Me.AddNewsPanel.ResumeLayout(False)
        Me.AddNewsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddNewsPanel As Panel
    Friend WithEvents NewsSaveButton As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NewsCategory As ComboBox
    Friend WithEvents NewsDesc As TextBox
    Friend WithEvents NewsTitle As TextBox
    Friend WithEvents NewsBody As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
