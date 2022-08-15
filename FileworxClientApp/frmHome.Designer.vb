<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPhotoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPostsData = New System.Windows.Forms.DataGridView()
        Me.scPreviewPanel = New System.Windows.Forms.SplitContainer()
        Me.tcPreviewControl = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rtxtPreviewText = New System.Windows.Forms.RichTextBox()
        Me.ImagePage = New System.Windows.Forms.TabPage()
        Me.picImageReview = New System.Windows.Forms.PictureBox()
        Me.lblCategoryData = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblCreationDateData = New System.Windows.Forms.Label()
        Me.lblCreationDate = New System.Windows.Forms.Label()
        Me.lblTitleData = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPostsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scPreviewPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scPreviewPanel.Panel1.SuspendLayout()
        Me.scPreviewPanel.SuspendLayout()
        Me.tcPreviewControl.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ImagePage.SuspendLayout()
        CType(Me.picImageReview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.AddToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1085, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "&Home"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.UsersToolStripMenuItem.Text = "&Users"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SignOutToolStripMenuItem.Text = "&Sign Out"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewsToolStripMenuItem1, Me.AddPhotoToolStripMenuItem1, Me.AddUserToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'AddNewsToolStripMenuItem1
        '
        Me.AddNewsToolStripMenuItem1.Name = "AddNewsToolStripMenuItem1"
        Me.AddNewsToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.AddNewsToolStripMenuItem1.Text = "&Add News"
        '
        'AddPhotoToolStripMenuItem1
        '
        Me.AddPhotoToolStripMenuItem1.Name = "AddPhotoToolStripMenuItem1"
        Me.AddPhotoToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.AddPhotoToolStripMenuItem1.Text = "&Add Photo"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AddUserToolStripMenuItem.Text = "&Add User"
        '
        'dgvPostsData
        '
        Me.dgvPostsData.AllowUserToAddRows = False
        Me.dgvPostsData.AllowUserToDeleteRows = False
        Me.dgvPostsData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPostsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPostsData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPostsData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPostsData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPostsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPostsData.EnableHeadersVisualStyles = False
        Me.dgvPostsData.Location = New System.Drawing.Point(10, 28)
        Me.dgvPostsData.MultiSelect = False
        Me.dgvPostsData.Name = "dgvPostsData"
        Me.dgvPostsData.ReadOnly = True
        Me.dgvPostsData.RowHeadersVisible = False
        Me.dgvPostsData.RowTemplate.Height = 25
        Me.dgvPostsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPostsData.Size = New System.Drawing.Size(1063, 179)
        Me.dgvPostsData.TabIndex = 27
        '
        'scPreviewPanel
        '
        Me.scPreviewPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scPreviewPanel.Location = New System.Drawing.Point(10, 213)
        Me.scPreviewPanel.Name = "scPreviewPanel"
        Me.scPreviewPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scPreviewPanel.Panel1
        '
        Me.scPreviewPanel.Panel1.Controls.Add(Me.tcPreviewControl)
        Me.scPreviewPanel.Panel1.Controls.Add(Me.lblCategoryData)
        Me.scPreviewPanel.Panel1.Controls.Add(Me.lblCategory)
        Me.scPreviewPanel.Panel1.Controls.Add(Me.lblCreationDateData)
        Me.scPreviewPanel.Panel1.Controls.Add(Me.lblCreationDate)
        Me.scPreviewPanel.Panel1.Controls.Add(Me.lblTitleData)
        Me.scPreviewPanel.Panel1.Controls.Add(Me.lblTitle)
        Me.scPreviewPanel.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        '
        'scPreviewPanel.Panel2
        '
        Me.scPreviewPanel.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.scPreviewPanel.Panel2MinSize = 0
        Me.scPreviewPanel.Size = New System.Drawing.Size(1063, 464)
        Me.scPreviewPanel.SplitterDistance = 435
        Me.scPreviewPanel.SplitterWidth = 3
        Me.scPreviewPanel.TabIndex = 36
        '
        'tcPreviewControl
        '
        Me.tcPreviewControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcPreviewControl.Controls.Add(Me.TabPage3)
        Me.tcPreviewControl.Controls.Add(Me.ImagePage)
        Me.tcPreviewControl.Location = New System.Drawing.Point(0, 92)
        Me.tcPreviewControl.Name = "tcPreviewControl"
        Me.tcPreviewControl.SelectedIndex = 0
        Me.tcPreviewControl.Size = New System.Drawing.Size(1060, 337)
        Me.tcPreviewControl.TabIndex = 48
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.rtxtPreviewText)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1052, 311)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Preview"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rtxtPreviewText
        '
        Me.rtxtPreviewText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtPreviewText.Enabled = False
        Me.rtxtPreviewText.Location = New System.Drawing.Point(3, 3)
        Me.rtxtPreviewText.Name = "rtxtPreviewText"
        Me.rtxtPreviewText.Size = New System.Drawing.Size(1046, 305)
        Me.rtxtPreviewText.TabIndex = 0
        Me.rtxtPreviewText.Text = ""
        '
        'ImagePage
        '
        Me.ImagePage.Controls.Add(Me.picImageReview)
        Me.ImagePage.Location = New System.Drawing.Point(4, 22)
        Me.ImagePage.Name = "ImagePage"
        Me.ImagePage.Padding = New System.Windows.Forms.Padding(3)
        Me.ImagePage.Size = New System.Drawing.Size(1052, 311)
        Me.ImagePage.TabIndex = 1
        Me.ImagePage.Text = "Image"
        Me.ImagePage.UseVisualStyleBackColor = True
        '
        'picImageReview
        '
        Me.picImageReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picImageReview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picImageReview.Location = New System.Drawing.Point(3, 3)
        Me.picImageReview.Name = "picImageReview"
        Me.picImageReview.Size = New System.Drawing.Size(1046, 305)
        Me.picImageReview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImageReview.TabIndex = 1
        Me.picImageReview.TabStop = False
        '
        'lblCategoryData
        '
        Me.lblCategoryData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCategoryData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCategoryData.Location = New System.Drawing.Point(102, 60)
        Me.lblCategoryData.Name = "lblCategoryData"
        Me.lblCategoryData.Size = New System.Drawing.Size(958, 20)
        Me.lblCategoryData.TabIndex = 47
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Location = New System.Drawing.Point(3, 58)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(64, 17)
        Me.lblCategory.TabIndex = 46
        Me.lblCategory.Text = "Category"
        '
        'lblCreationDateData
        '
        Me.lblCreationDateData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreationDateData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreationDateData.Location = New System.Drawing.Point(102, 35)
        Me.lblCreationDateData.Name = "lblCreationDateData"
        Me.lblCreationDateData.Size = New System.Drawing.Size(958, 20)
        Me.lblCreationDateData.TabIndex = 45
        '
        'lblCreationDate
        '
        Me.lblCreationDate.AutoSize = True
        Me.lblCreationDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCreationDate.ForeColor = System.Drawing.Color.Black
        Me.lblCreationDate.Location = New System.Drawing.Point(3, 33)
        Me.lblCreationDate.Name = "lblCreationDate"
        Me.lblCreationDate.Size = New System.Drawing.Size(93, 17)
        Me.lblCreationDate.TabIndex = 44
        Me.lblCreationDate.Text = "Creation Date"
        '
        'lblTitleData
        '
        Me.lblTitleData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitleData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitleData.Location = New System.Drawing.Point(102, 11)
        Me.lblTitleData.Name = "lblTitleData"
        Me.lblTitleData.Size = New System.Drawing.Size(958, 20)
        Me.lblTitleData.TabIndex = 43
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(36, 17)
        Me.lblTitle.TabIndex = 42
        Me.lblTitle.Text = "Title"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1085, 682)
        Me.Controls.Add(Me.scPreviewPanel)
        Me.Controls.Add(Me.dgvPostsData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(688, 439)
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPostsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scPreviewPanel.Panel1.ResumeLayout(False)
        Me.scPreviewPanel.Panel1.PerformLayout()
        CType(Me.scPreviewPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scPreviewPanel.ResumeLayout(False)
        Me.tcPreviewControl.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ImagePage.ResumeLayout(False)
        CType(Me.picImageReview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddPhotoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvPostsData As DataGridView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents scPreviewPanel As SplitContainer
    Friend WithEvents tcPreviewControl As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents rtxtPreviewText As RichTextBox
    Friend WithEvents ImagePage As TabPage
    Friend WithEvents picImageReview As PictureBox
    Friend WithEvents lblCategoryData As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblCreationDateData As Label
    Friend WithEvents lblCreationDate As Label
    Friend WithEvents lblTitleData As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
End Class
