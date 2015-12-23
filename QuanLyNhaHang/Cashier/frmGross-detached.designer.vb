<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGross_detached
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
        Me.ltvChiTietBan = New System.Windows.Forms.ListView()
        Me.VTBan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaHoaDon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnGopBan = New System.Windows.Forms.Button()
        Me.btnTachBan = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltvChiTietBan
        '
        Me.ltvChiTietBan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.VTBan, Me.MaHoaDon})
        Me.ltvChiTietBan.FullRowSelect = True
        Me.ltvChiTietBan.GridLines = True
        Me.ltvChiTietBan.Location = New System.Drawing.Point(12, 12)
        Me.ltvChiTietBan.Name = "ltvChiTietBan"
        Me.ltvChiTietBan.Size = New System.Drawing.Size(536, 219)
        Me.ltvChiTietBan.TabIndex = 0
        Me.ltvChiTietBan.UseCompatibleStateImageBehavior = False
        Me.ltvChiTietBan.View = System.Windows.Forms.View.Details
        '
        'VTBan
        '
        Me.VTBan.Text = "Vị trí bàn"
        Me.VTBan.Width = 264
        '
        'MaHoaDon
        '
        Me.MaHoaDon.Text = "Mã hóa đơn"
        Me.MaHoaDon.Width = 266
        '
        'btnGopBan
        '
        Me.btnGopBan.Enabled = False
        Me.btnGopBan.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGopBan.Location = New System.Drawing.Point(24, 255)
        Me.btnGopBan.Name = "btnGopBan"
        Me.btnGopBan.Size = New System.Drawing.Size(150, 50)
        Me.btnGopBan.TabIndex = 7
        Me.btnGopBan.Text = "Gộp Bàn"
        Me.btnGopBan.UseVisualStyleBackColor = True
        '
        'btnTachBan
        '
        Me.btnTachBan.Enabled = False
        Me.btnTachBan.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTachBan.Location = New System.Drawing.Point(209, 255)
        Me.btnTachBan.Name = "btnTachBan"
        Me.btnTachBan.Size = New System.Drawing.Size(150, 50)
        Me.btnTachBan.TabIndex = 8
        Me.btnTachBan.Text = "Tách Bàn"
        Me.btnTachBan.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Enabled = False
        Me.btnThoat.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(398, 255)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(150, 50)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmGross_detached
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 365)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTachBan)
        Me.Controls.Add(Me.btnGopBan)
        Me.Controls.Add(Me.ltvChiTietBan)
        Me.Name = "frmGross_detached"
        Me.Text = "frmGross_detached"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ltvChiTietBan As System.Windows.Forms.ListView
    Friend WithEvents MaHoaDon As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGopBan As System.Windows.Forms.Button
    Friend WithEvents btnTachBan As System.Windows.Forms.Button
    Friend WithEvents VTBan As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnThoat As System.Windows.Forms.Button
End Class
