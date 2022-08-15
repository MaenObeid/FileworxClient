<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPhoto
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
        Me.lblBody = New System.Windows.Forms.Label()
        Me.txtPhotoDescription = New System.Windows.Forms.TextBox()
        Me.txtPhotoTitle = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtPhotoBody = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.picImageViewer = New System.Windows.Forms.PictureBox()
        Me.lblImagePathLabel = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PhotoTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.picImageViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhotoTabControl
        '
        Me.PhotoTabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhotoTabControl.Controls.Add(Me.TabPage1)
        Me.PhotoTabControl.Controls.Add(Me.TabPage2)
        Me.PhotoTabControl.Location = New System.Drawing.Point(2, 1)
        Me.PhotoTabControl.Name = "PhotoTabControl"
        Me.PhotoTabControl.SelectedIndex = 0
        Me.PhotoTabControl.Size = New System.Drawing.Size(770, 349)
        Me.PhotoTabControl.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage1.Controls.Add(Me.PhotoSaveButton)
        Me.TabPage1.Controls.Add(Me.Cancel)
        Me.TabPage1.Controls.Add(Me.lblBody)
        Me.TabPage1.Controls.Add(Me.txtPhotoDescription)
        Me.TabPage1.Controls.Add(Me.txtPhotoTitle)
        Me.TabPage1.Controls.Add(Me.lblDescription)
        Me.TabPage1.Controls.Add(Me.lblTitle)
        Me.TabPage1.Controls.Add(Me.txtPhotoBody)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 6, 40)
        Me.TabPage1.Size = New System.Drawing.Size(762, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File Description"
        '
        'PhotoSaveButton
        '
        Me.PhotoSaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhotoSaveButton.BackColor = System.Drawing.Color.SteelBlue
        Me.PhotoSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PhotoSaveButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PhotoSaveButton.ForeColor = System.Drawing.Color.White
        Me.PhotoSaveButton.Location = New System.Drawing.Point(563, 254)
        Me.PhotoSaveButton.Name = "PhotoSaveButton"
        Me.PhotoSaveButton.Size = New System.Drawing.Size(92, 26)
        Me.PhotoSaveButton.TabIndex = 56
        Me.PhotoSaveButton.Text = "Save"
        Me.PhotoSaveButton.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.BackColor = System.Drawing.Color.DimGray
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(661, 254)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(92, 26)
        Me.Cancel.TabIndex = 55
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblBody.ForeColor = System.Drawing.Color.DimGray
        Me.lblBody.Location = New System.Drawing.Point(23, 86)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(49, 21)
        Me.lblBody.TabIndex = 54
        Me.lblBody.Text = "Body"
        '
        'txtPhotoDescription
        '
        Me.txtPhotoDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhotoDescription.Location = New System.Drawing.Point(118, 61)
        Me.txtPhotoDescription.Name = "txtPhotoDescription"
        Me.txtPhotoDescription.Size = New System.Drawing.Size(635, 20)
        Me.txtPhotoDescription.TabIndex = 53
        '
        'txtPhotoTitle
        '
        Me.txtPhotoTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhotoTitle.Location = New System.Drawing.Point(118, 36)
        Me.txtPhotoTitle.Name = "txtPhotoTitle"
        Me.txtPhotoTitle.Size = New System.Drawing.Size(635, 20)
        Me.txtPhotoTitle.TabIndex = 52
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.DimGray
        Me.lblDescription.Location = New System.Drawing.Point(23, 62)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(98, 21)
        Me.lblDescription.TabIndex = 51
        Me.lblDescription.Text = "Description"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitle.Location = New System.Drawing.Point(23, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(44, 21)
        Me.lblTitle.TabIndex = 50
        Me.lblTitle.Text = "Title"
        '
        'txtPhotoBody
        '
        Me.txtPhotoBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhotoBody.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhotoBody.Location = New System.Drawing.Point(118, 86)
        Me.txtPhotoBody.Name = "txtPhotoBody"
        Me.txtPhotoBody.Size = New System.Drawing.Size(635, 162)
        Me.txtPhotoBody.TabIndex = 49
        Me.txtPhotoBody.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage2.Controls.Add(Me.picImageViewer)
        Me.TabPage2.Controls.Add(Me.lblImagePathLabel)
        Me.TabPage2.Controls.Add(Me.btnBrowse)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(762, 0)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Image"
        '
        'picImageViewer
        '
        Me.picImageViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picImageViewer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picImageViewer.Location = New System.Drawing.Point(3, -225)
        Me.picImageViewer.Name = "picImageViewer"
        Me.picImageViewer.Size = New System.Drawing.Size(756, 277)
        Me.picImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImageViewer.TabIndex = 5
        Me.picImageViewer.TabStop = False
        '
        'lblImagePathLabel
        '
        Me.lblImagePathLabel.Location = New System.Drawing.Point(115, 17)
        Me.lblImagePathLabel.Name = "lblImagePathLabel"
        Me.lblImagePathLabel.Size = New System.Drawing.Size(596, 20)
        Me.lblImagePathLabel.TabIndex = 4
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(17, 11)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(92, 26)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'frmAddPhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.PhotoTabControl)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 400)
        Me.MinimumSize = New System.Drawing.Size(605, 400)
        Me.Name = "frmAddPhoto"
        Me.Text = "AddPhoto"
        Me.PhotoTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.picImageViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PhotoTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PhotoSaveButton As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents lblBody As Label
    Friend WithEvents txtPhotoDescription As TextBox
    Friend WithEvents txtPhotoTitle As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtPhotoBody As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents picImageViewer As PictureBox
    Friend WithEvents lblImagePathLabel As Label
    Friend WithEvents btnBrowse As Button
End Class
