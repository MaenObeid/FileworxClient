<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPhotoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TitleColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreviewPanel = New System.Windows.Forms.SplitContainer()
        Me.previewControl = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PreviewText = New System.Windows.Forms.RichTextBox()
        Me.ImagePage = New System.Windows.Forms.TabPage()
        Me.ImageReview = New System.Windows.Forms.PictureBox()
        Me.categoryLabel = New System.Windows.Forms.Label()
        Me.categoryL = New System.Windows.Forms.Label()
        Me.creationLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviewPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PreviewPanel.Panel1.SuspendLayout()
        Me.PreviewPanel.SuspendLayout()
        Me.previewControl.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ImagePage.SuspendLayout()
        CType(Me.ImageReview, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleColumn, Me.CreationDateColumn, Me.DescriptionColumn})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(10, 28)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(545, 179)
        Me.DataGridView1.TabIndex = 27
        '
        'TitleColumn
        '
        Me.TitleColumn.HeaderText = "Title"
        Me.TitleColumn.Name = "TitleColumn"
        Me.TitleColumn.ReadOnly = True
        Me.TitleColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CreationDateColumn
        '
        Me.CreationDateColumn.HeaderText = "Creation Date"
        Me.CreationDateColumn.Name = "CreationDateColumn"
        Me.CreationDateColumn.ReadOnly = True
        Me.CreationDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DescriptionColumn
        '
        Me.DescriptionColumn.HeaderText = "Description"
        Me.DescriptionColumn.Name = "DescriptionColumn"
        Me.DescriptionColumn.ReadOnly = True
        Me.DescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Location = New System.Drawing.Point(10, 213)
        Me.PreviewPanel.Name = "PreviewPanel"
        Me.PreviewPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'PreviewPanel.Panel1
        '
        Me.PreviewPanel.Panel1.Controls.Add(Me.previewControl)
        Me.PreviewPanel.Panel1.Controls.Add(Me.categoryLabel)
        Me.PreviewPanel.Panel1.Controls.Add(Me.categoryL)
        Me.PreviewPanel.Panel1.Controls.Add(Me.creationLabel)
        Me.PreviewPanel.Panel1.Controls.Add(Me.Label3)
        Me.PreviewPanel.Panel1.Controls.Add(Me.titleLabel)
        Me.PreviewPanel.Panel1.Controls.Add(Me.Label1)
        Me.PreviewPanel.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        '
        'PreviewPanel.Panel2
        '
        Me.PreviewPanel.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.PreviewPanel.Panel2MinSize = 0
        Me.PreviewPanel.Size = New System.Drawing.Size(834, 464)
        Me.PreviewPanel.SplitterDistance = 438
        Me.PreviewPanel.SplitterWidth = 3
        Me.PreviewPanel.TabIndex = 36
        '
        'previewControl
        '
        Me.previewControl.Controls.Add(Me.TabPage3)
        Me.previewControl.Controls.Add(Me.ImagePage)
        Me.previewControl.Location = New System.Drawing.Point(0, 92)
        Me.previewControl.Name = "previewControl"
        Me.previewControl.SelectedIndex = 0
        Me.previewControl.Size = New System.Drawing.Size(565, 341)
        Me.previewControl.TabIndex = 48
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PreviewText)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(557, 315)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Preview"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PreviewText
        '
        Me.PreviewText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviewText.Enabled = False
        Me.PreviewText.Location = New System.Drawing.Point(3, 3)
        Me.PreviewText.Name = "PreviewText"
        Me.PreviewText.Size = New System.Drawing.Size(551, 309)
        Me.PreviewText.TabIndex = 0
        Me.PreviewText.Text = ""
        '
        'ImagePage
        '
        Me.ImagePage.Controls.Add(Me.ImageReview)
        Me.ImagePage.Location = New System.Drawing.Point(4, 22)
        Me.ImagePage.Name = "ImagePage"
        Me.ImagePage.Padding = New System.Windows.Forms.Padding(3)
        Me.ImagePage.Size = New System.Drawing.Size(541, 315)
        Me.ImagePage.TabIndex = 1
        Me.ImagePage.Text = "Image"
        Me.ImagePage.UseVisualStyleBackColor = True
        '
        'ImageReview
        '
        Me.ImageReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ImageReview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageReview.Location = New System.Drawing.Point(3, 3)
        Me.ImageReview.Name = "ImageReview"
        Me.ImageReview.Size = New System.Drawing.Size(535, 309)
        Me.ImageReview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageReview.TabIndex = 1
        Me.ImageReview.TabStop = False
        '
        'categoryLabel
        '
        Me.categoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.categoryLabel.Location = New System.Drawing.Point(102, 60)
        Me.categoryLabel.Name = "categoryLabel"
        Me.categoryLabel.Size = New System.Drawing.Size(463, 20)
        Me.categoryLabel.TabIndex = 47
        '
        'categoryL
        '
        Me.categoryL.AutoSize = True
        Me.categoryL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.categoryL.ForeColor = System.Drawing.Color.Black
        Me.categoryL.Location = New System.Drawing.Point(3, 58)
        Me.categoryL.Name = "categoryL"
        Me.categoryL.Size = New System.Drawing.Size(64, 17)
        Me.categoryL.TabIndex = 46
        Me.categoryL.Text = "Category"
        '
        'creationLabel
        '
        Me.creationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.creationLabel.Location = New System.Drawing.Point(102, 35)
        Me.creationLabel.Name = "creationLabel"
        Me.creationLabel.Size = New System.Drawing.Size(463, 20)
        Me.creationLabel.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Creation Date"
        '
        'titleLabel
        '
        Me.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.titleLabel.Location = New System.Drawing.Point(102, 11)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(463, 20)
        Me.titleLabel.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Title"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1085, 682)
        Me.Controls.Add(Me.PreviewPanel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(688, 439)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PreviewPanel.Panel1.ResumeLayout(False)
        Me.PreviewPanel.Panel1.PerformLayout()
        CType(Me.PreviewPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PreviewPanel.ResumeLayout(False)
        Me.previewControl.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ImagePage.ResumeLayout(False)
        CType(Me.ImageReview, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TitleColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreationDateColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionColumn As DataGridViewTextBoxColumn
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PreviewPanel As SplitContainer
    Friend WithEvents previewControl As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PreviewText As RichTextBox
    Friend WithEvents ImagePage As TabPage
    Friend WithEvents ImageReview As PictureBox
    Friend WithEvents categoryLabel As Label
    Friend WithEvents categoryL As Label
    Friend WithEvents creationLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
End Class
