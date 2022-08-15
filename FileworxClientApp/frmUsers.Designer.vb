<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsers
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvUsersList = New System.Windows.Forms.DataGridView()
        Me.btnActivityButton = New System.Windows.Forms.Button()
        CType(Me.dgvUsersList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsersList
        '
        Me.dgvUsersList.AllowUserToAddRows = False
        Me.dgvUsersList.AllowUserToDeleteRows = False
        Me.dgvUsersList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsersList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvUsersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsersList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsersList.EnableHeadersVisualStyles = False
        Me.dgvUsersList.Location = New System.Drawing.Point(12, 27)
        Me.dgvUsersList.MultiSelect = False
        Me.dgvUsersList.Name = "dgvUsersList"
        Me.dgvUsersList.ReadOnly = True
        Me.dgvUsersList.RowHeadersVisible = False
        Me.dgvUsersList.RowTemplate.Height = 25
        Me.dgvUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsersList.Size = New System.Drawing.Size(776, 239)
        Me.dgvUsersList.TabIndex = 20
        '
        'btnActivityButton
        '
        Me.btnActivityButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActivityButton.BackColor = System.Drawing.Color.SteelBlue
        Me.btnActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivityButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnActivityButton.ForeColor = System.Drawing.Color.White
        Me.btnActivityButton.Location = New System.Drawing.Point(694, 272)
        Me.btnActivityButton.Name = "btnActivityButton"
        Me.btnActivityButton.Size = New System.Drawing.Size(92, 26)
        Me.btnActivityButton.TabIndex = 54
        Me.btnActivityButton.UseVisualStyleBackColor = False
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 321)
        Me.Controls.Add(Me.btnActivityButton)
        Me.Controls.Add(Me.dgvUsersList)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 360)
        Me.MinimumSize = New System.Drawing.Size(600, 360)
        Me.Name = "frmUsers"
        Me.Text = "Users"
        CType(Me.dgvUsersList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvUsersList As DataGridView
    Friend WithEvents btnActivityButton As Button
End Class
