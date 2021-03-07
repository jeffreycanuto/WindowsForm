<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dvgData = New System.Windows.Forms.DataGridView()
        Me.cbxItem = New System.Windows.Forms.ComboBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        CType(Me.dvgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(13, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 20)
        Me.txtSearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(187, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 20)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dvgData
        '
        Me.dvgData.AllowUserToAddRows = False
        Me.dvgData.AllowUserToDeleteRows = False
        Me.dvgData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgData.Location = New System.Drawing.Point(13, 39)
        Me.dvgData.Name = "dvgData"
        Me.dvgData.ReadOnly = True
        Me.dvgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgData.Size = New System.Drawing.Size(808, 372)
        Me.dvgData.TabIndex = 4
        '
        'cbxItem
        '
        Me.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItem.FormattingEnabled = True
        Me.cbxItem.Location = New System.Drawing.Point(325, 11)
        Me.cbxItem.Name = "cbxItem"
        Me.cbxItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxItem.TabIndex = 5
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(761, 13)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(60, 20)
        Me.txtCount.TabIndex = 6
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(477, 13)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(110, 20)
        Me.txtAddress1.TabIndex = 7
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(593, 13)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(110, 20)
        Me.txtAddress2.TabIndex = 8
        '
        'GridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 423)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.cbxItem)
        Me.Controls.Add(Me.dvgData)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "GridView"
        Me.Text = "GridView"
        CType(Me.dvgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dvgData As DataGridView
    Friend WithEvents cbxItem As ComboBox
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtAddress2 As TextBox
End Class
