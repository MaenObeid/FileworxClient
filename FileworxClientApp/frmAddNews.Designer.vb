<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddNews
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
        Me.btnNewsSaveButton = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboNewsCategory = New System.Windows.Forms.ComboBox()
        Me.txtNewsDesc = New System.Windows.Forms.TextBox()
        Me.txtNewsTitle = New System.Windows.Forms.TextBox()
        Me.rtxtNewsBody = New System.Windows.Forms.RichTextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.AddNewsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddNewsPanel
        '
        Me.AddNewsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddNewsPanel.Controls.Add(Me.btnNewsSaveButton)
        Me.AddNewsPanel.Controls.Add(Me.btnCancel)
        Me.AddNewsPanel.Controls.Add(Me.lblBody)
        Me.AddNewsPanel.Controls.Add(Me.Label4)
        Me.AddNewsPanel.Controls.Add(Me.cboNewsCategory)
        Me.AddNewsPanel.Controls.Add(Me.txtNewsDesc)
        Me.AddNewsPanel.Controls.Add(Me.txtNewsTitle)
        Me.AddNewsPanel.Controls.Add(Me.rtxtNewsBody)
        Me.AddNewsPanel.Controls.Add(Me.lblCategory)
        Me.AddNewsPanel.Controls.Add(Me.lblDescription)
        Me.AddNewsPanel.Controls.Add(Me.lblTitle)
        Me.AddNewsPanel.Location = New System.Drawing.Point(12, 12)
        Me.AddNewsPanel.Name = "AddNewsPanel"
        Me.AddNewsPanel.Size = New System.Drawing.Size(760, 262)
        Me.AddNewsPanel.TabIndex = 50
        '
        'btnNewsSaveButton
        '
        Me.btnNewsSaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewsSaveButton.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNewsSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewsSaveButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnNewsSaveButton.ForeColor = System.Drawing.Color.White
        Me.btnNewsSaveButton.Location = New System.Drawing.Point(567, 217)
        Me.btnNewsSaveButton.Name = "btnNewsSaveButton"
        Me.btnNewsSaveButton.Size = New System.Drawing.Size(92, 26)
        Me.btnNewsSaveButton.TabIndex = 70
        Me.btnNewsSaveButton.Text = "Save"
        Me.btnNewsSaveButton.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.DimGray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(665, 217)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 26)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.BackColor = System.Drawing.Color.Transparent
        Me.lblBody.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblBody.ForeColor = System.Drawing.Color.DimGray
        Me.lblBody.Location = New System.Drawing.Point(14, 84)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(49, 21)
        Me.lblBody.TabIndex = 68
        Me.lblBody.Text = "Body"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 67
        '
        'cboNewsCategory
        '
        Me.cboNewsCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNewsCategory.CausesValidation = False
        Me.cboNewsCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNewsCategory.FormattingEnabled = True
        Me.cboNewsCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboNewsCategory.Location = New System.Drawing.Point(122, 61)
        Me.cboNewsCategory.Name = "cboNewsCategory"
        Me.cboNewsCategory.Size = New System.Drawing.Size(635, 21)
        Me.cboNewsCategory.TabIndex = 66
        '
        'txtNewsDesc
        '
        Me.txtNewsDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNewsDesc.Location = New System.Drawing.Point(122, 36)
        Me.txtNewsDesc.Name = "txtNewsDesc"
        Me.txtNewsDesc.Size = New System.Drawing.Size(635, 20)
        Me.txtNewsDesc.TabIndex = 65
        '
        'txtNewsTitle
        '
        Me.txtNewsTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNewsTitle.Location = New System.Drawing.Point(122, 12)
        Me.txtNewsTitle.Name = "txtNewsTitle"
        Me.txtNewsTitle.Size = New System.Drawing.Size(635, 20)
        Me.txtNewsTitle.TabIndex = 64
        '
        'rtxtNewsBody
        '
        Me.rtxtNewsBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtNewsBody.BackColor = System.Drawing.SystemColors.Window
        Me.rtxtNewsBody.Location = New System.Drawing.Point(122, 87)
        Me.rtxtNewsBody.Name = "rtxtNewsBody"
        Me.rtxtNewsBody.Size = New System.Drawing.Size(635, 124)
        Me.rtxtNewsBody.TabIndex = 60
        Me.rtxtNewsBody.Text = ""
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.DimGray
        Me.lblCategory.Location = New System.Drawing.Point(14, 58)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(80, 21)
        Me.lblCategory.TabIndex = 63
        Me.lblCategory.Text = "Category"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.DimGray
        Me.lblDescription.Location = New System.Drawing.Point(14, 33)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(98, 21)
        Me.lblDescription.TabIndex = 62
        Me.lblDescription.Text = "Description"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitle.Location = New System.Drawing.Point(14, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(44, 21)
        Me.lblTitle.TabIndex = 61
        Me.lblTitle.Text = "Title"
        '
        'frmAddNews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 286)
        Me.Controls.Add(Me.AddNewsPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 325)
        Me.MinimumSize = New System.Drawing.Size(600, 325)
        Me.Name = "frmAddNews"
        Me.Text = "AddNews"
        Me.AddNewsPanel.ResumeLayout(False)
        Me.AddNewsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddNewsPanel As Panel
    Friend WithEvents btnNewsSaveButton As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblBody As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboNewsCategory As ComboBox
    Friend WithEvents txtNewsDesc As TextBox
    Friend WithEvents txtNewsTitle As TextBox
    Friend WithEvents rtxtNewsBody As RichTextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
End Class
