<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPhoto
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
        Me.PhotoTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PhotoSaveButton = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PhotoDescription = New System.Windows.Forms.TextBox()
        Me.PhotoTitle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PhotoBody = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ImageViewer = New System.Windows.Forms.PictureBox()
        Me.ImagePathLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PhotoTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ImageViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhotoTabControl
        '
        Me.PhotoTabControl.Controls.Add(Me.TabPage1)
        Me.PhotoTabControl.Controls.Add(Me.TabPage2)
        Me.PhotoTabControl.Location = New System.Drawing.Point(2, 1)
        Me.PhotoTabControl.MaximumSize = New System.Drawing.Size(1000, 0)
        Me.PhotoTabControl.MinimumSize = New System.Drawing.Size(605, 349)
        Me.PhotoTabControl.Name = "PhotoTabControl"
        Me.PhotoTabControl.SelectedIndex = 0
        Me.PhotoTabControl.Size = New System.Drawing.Size(605, 349)
        Me.PhotoTabControl.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage1.Controls.Add(Me.PhotoSaveButton)
        Me.TabPage1.Controls.Add(Me.Cancel)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.PhotoDescription)
        Me.TabPage1.Controls.Add(Me.PhotoTitle)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.PhotoBody)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 6, 40)
        Me.TabPage1.Size = New System.Drawing.Size(597, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File Description"
        '
        'PhotoSaveButton
        '
        Me.PhotoSaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhotoSaveButton.BackColor = System.Drawing.Color.SteelBlue
        Me.PhotoSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PhotoSaveButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PhotoSaveButton.ForeColor = System.Drawing.Color.White
        Me.PhotoSaveButton.Location = New System.Drawing.Point(398, 254)
        Me.PhotoSaveButton.Name = "PhotoSaveButton"
        Me.PhotoSaveButton.Size = New System.Drawing.Size(92, 26)
        Me.PhotoSaveButton.TabIndex = 56
        Me.PhotoSaveButton.Text = "Save"
        Me.PhotoSaveButton.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.BackColor = System.Drawing.Color.DimGray
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(496, 254)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(92, 26)
        Me.Cancel.TabIndex = 55
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(23, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 21)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Body"
        '
        'PhotoDescription
        '
        Me.PhotoDescription.Location = New System.Drawing.Point(118, 61)
        Me.PhotoDescription.Name = "PhotoDescription"
        Me.PhotoDescription.Size = New System.Drawing.Size(473, 20)
        Me.PhotoDescription.TabIndex = 53
        '
        'PhotoTitle
        '
        Me.PhotoTitle.Location = New System.Drawing.Point(118, 36)
        Me.PhotoTitle.Name = "PhotoTitle"
        Me.PhotoTitle.Size = New System.Drawing.Size(473, 20)
        Me.PhotoTitle.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(23, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 21)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Description"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(23, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 21)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Title"
        '
        'PhotoBody
        '
        Me.PhotoBody.BackColor = System.Drawing.SystemColors.Window
        Me.PhotoBody.Location = New System.Drawing.Point(118, 86)
        Me.PhotoBody.Name = "PhotoBody"
        Me.PhotoBody.Size = New System.Drawing.Size(473, 162)
        Me.PhotoBody.TabIndex = 49
        Me.PhotoBody.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage2.Controls.Add(Me.ImageViewer)
        Me.TabPage2.Controls.Add(Me.ImagePathLabel)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(597, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Image"
        '
        'ImageViewer
        '
        Me.ImageViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ImageViewer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ImageViewer.Location = New System.Drawing.Point(3, 43)
        Me.ImageViewer.Name = "ImageViewer"
        Me.ImageViewer.Size = New System.Drawing.Size(591, 277)
        Me.ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageViewer.TabIndex = 5
        Me.ImageViewer.TabStop = False
        '
        'ImagePathLabel
        '
        Me.ImagePathLabel.Location = New System.Drawing.Point(115, 17)
        Me.ImagePathLabel.Name = "ImagePathLabel"
        Me.ImagePathLabel.Size = New System.Drawing.Size(596, 20)
        Me.ImagePathLabel.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(17, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AddPhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.PhotoTabControl)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "AddPhoto"
        Me.Text = "AddPhoto"
        Me.PhotoTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ImageViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PhotoTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PhotoSaveButton As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PhotoDescription As TextBox
    Friend WithEvents PhotoTitle As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PhotoBody As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageViewer As PictureBox
    Friend WithEvents ImagePathLabel As Label
    Friend WithEvents Button1 As Button
End Class
