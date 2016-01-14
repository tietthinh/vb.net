<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietMon
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
        Me.dgvChiTietMon = New System.Windows.Forms.DataGridView()
        Me.colMaSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoLuongTon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lstGui = New System.Windows.Forms.ListView()
        Me.colMaMon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTenMon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSend = New System.Windows.Forms.Button()
        CType(Me.dgvChiTietMon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvChiTietMon
        '
        Me.dgvChiTietMon.AllowUserToAddRows = False
        Me.dgvChiTietMon.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvChiTietMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietMon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaSP, Me.colTenSP, Me.colSoLuongTon, Me.colMaDV, Me.colTenDV})
        Me.dgvChiTietMon.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvChiTietMon.Location = New System.Drawing.Point(130, 84)
        Me.dgvChiTietMon.Name = "dgvChiTietMon"
        Me.dgvChiTietMon.RowHeadersVisible = False
        Me.dgvChiTietMon.Size = New System.Drawing.Size(478, 271)
        Me.dgvChiTietMon.TabIndex = 0
        '
        'colMaSP
        '
        Me.colMaSP.HeaderText = "Mã sản phẩm"
        Me.colMaSP.Name = "colMaSP"
        '
        'colTenSP
        '
        Me.colTenSP.HeaderText = "Tên sản phẩm"
        Me.colTenSP.Name = "colTenSP"
        '
        'colSoLuongTon
        '
        Me.colSoLuongTon.HeaderText = "Số lượng tồn"
        Me.colSoLuongTon.Name = "colSoLuongTon"
        '
        'colMaDV
        '
        Me.colMaDV.HeaderText = "Mã đơn vị"
        Me.colMaDV.Name = "colMaDV"
        '
        'colTenDV
        '
        Me.colTenDV.HeaderText = "Tên đơn vị"
        Me.colTenDV.Name = "colTenDV"
        '
        'lstGui
        '
        Me.lstGui.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colMaMon, Me.colTenMon})
        Me.lstGui.Location = New System.Drawing.Point(12, 12)
        Me.lstGui.Name = "lstGui"
        Me.lstGui.Size = New System.Drawing.Size(112, 343)
        Me.lstGui.TabIndex = 114
        Me.lstGui.UseCompatibleStateImageBehavior = False
        Me.lstGui.View = System.Windows.Forms.View.Details
        '
        'colMaMon
        '
        Me.colMaMon.Text = "Mã món"
        Me.colMaMon.Width = 52
        '
        'colTenMon
        '
        Me.colTenMon.Text = "Tên món"
        Me.colTenMon.Width = 92
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(130, 12)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(92, 37)
        Me.btnSend.TabIndex = 115
        Me.btnSend.Text = "Gửi"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmChiTietMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 367)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lstGui)
        Me.Controls.Add(Me.dgvChiTietMon)
        Me.Name = "frmChiTietMon"
        Me.Text = "Chi tiết món"
        CType(Me.dgvChiTietMon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvChiTietMon As DataGridView
    Friend WithEvents colMaSP As DataGridViewTextBoxColumn
    Friend WithEvents colTenSP As DataGridViewTextBoxColumn
    Friend WithEvents colSoLuongTon As DataGridViewTextBoxColumn
    Friend WithEvents colMaDV As DataGridViewTextBoxColumn
    Friend WithEvents colTenDV As DataGridViewTextBoxColumn
    Friend WithEvents lstGui As ListView
    Friend WithEvents colMaMon As ColumnHeader
    Friend WithEvents colTenMon As ColumnHeader
    Friend WithEvents btnSend As Button
End Class
