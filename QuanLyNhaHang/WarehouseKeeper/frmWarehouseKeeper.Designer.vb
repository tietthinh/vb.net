<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWarehouseKeeper
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPhieuNhan = New System.Windows.Forms.Button()
        Me.dgvDSSanPham = New System.Windows.Forms.DataGridView()
        Me.colMaSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoLuongTon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPhieuNhap = New System.Windows.Forms.Button()
        Me.cboDonVi = New System.Windows.Forms.ComboBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtTenSanPham = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSuaSP = New System.Windows.Forms.Button()
        Me.btnXoaSP = New System.Windows.Forms.Button()
        Me.btnThemSP = New System.Windows.Forms.Button()
        Me.btnTimSP = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSDT = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtChietKhau = New System.Windows.Forms.TextBox()
        Me.txtTenNCC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblChietKhau = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSuaNCC = New System.Windows.Forms.Button()
        Me.btnXoaNCC = New System.Windows.Forms.Button()
        Me.btnThemNCC = New System.Windows.Forms.Button()
        Me.btnTimNCC = New System.Windows.Forms.Button()
        Me.dgvDSNhaCungCap = New System.Windows.Forms.DataGridView()
        Me.colMaNCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenNCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChietKhau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colSDT = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.btnCong1 = New System.Windows.Forms.Button()
        Me.btnCong2 = New System.Windows.Forms.Button()
        Me.errMain = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTimSP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTimNCC = New System.Windows.Forms.TextBox()
        Me.cboEmail = New System.Windows.Forms.ComboBox()
        Me.cboDienThoai = New System.Windows.Forms.ComboBox()
        Me.stsMain = New System.Windows.Forms.StatusStrip()
        Me.tslMaNV = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslTenNV = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnThemEmail = New System.Windows.Forms.Button()
        Me.btnXoaEmail = New System.Windows.Forms.Button()
        Me.btnSuaEmail = New System.Windows.Forms.Button()
        Me.btnThemSDT = New System.Windows.Forms.Button()
        Me.btnXoaSDT = New System.Windows.Forms.Button()
        Me.btnSuaSDT = New System.Windows.Forms.Button()
        Me.btnHoanTat = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        CType(Me.dgvDSSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDSNhaCungCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(482, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SẢN PHẨM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPhieuNhan
        '
        Me.btnPhieuNhan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPhieuNhan.AutoSize = True
        Me.btnPhieuNhan.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhieuNhan.Location = New System.Drawing.Point(1204, 338)
        Me.btnPhieuNhan.Name = "btnPhieuNhan"
        Me.btnPhieuNhan.Size = New System.Drawing.Size(83, 46)
        Me.btnPhieuNhan.TabIndex = 19
        Me.btnPhieuNhan.Text = "Phiếu Nhận"
        Me.btnPhieuNhan.UseVisualStyleBackColor = True
        '
        'dgvDSSanPham
        '
        Me.dgvDSSanPham.AllowUserToOrderColumns = True
        Me.dgvDSSanPham.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvDSSanPham.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDSSanPham.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSSanPham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaSP, Me.colTenSP, Me.colSoLuongTon, Me.colMaDV, Me.colTenDV})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDSSanPham.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDSSanPham.Location = New System.Drawing.Point(15, 306)
        Me.dgvDSSanPham.Name = "dgvDSSanPham"
        Me.dgvDSSanPham.RowHeadersVisible = False
        Me.dgvDSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSSanPham.Size = New System.Drawing.Size(427, 375)
        Me.dgvDSSanPham.TabIndex = 6
        '
        'colMaSP
        '
        Me.colMaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaSP.DataPropertyName = "MaSP"
        Me.colMaSP.HeaderText = "Mã sản phẩm"
        Me.colMaSP.Name = "colMaSP"
        Me.colMaSP.ReadOnly = True
        Me.colMaSP.Visible = False
        '
        'colTenSP
        '
        Me.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTenSP.DataPropertyName = "TenSP"
        Me.colTenSP.HeaderText = "Tên sản phẩm"
        Me.colTenSP.Name = "colTenSP"
        Me.colTenSP.ReadOnly = True
        '
        'colSoLuongTon
        '
        Me.colSoLuongTon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSoLuongTon.DataPropertyName = "SoLuongTon"
        Me.colSoLuongTon.HeaderText = "Số lượng"
        Me.colSoLuongTon.Name = "colSoLuongTon"
        Me.colSoLuongTon.ReadOnly = True
        '
        'colMaDV
        '
        Me.colMaDV.DataPropertyName = "MaDV"
        Me.colMaDV.HeaderText = "Mã đơn vị"
        Me.colMaDV.Name = "colMaDV"
        Me.colMaDV.Visible = False
        '
        'colTenDV
        '
        Me.colTenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTenDV.DataPropertyName = "TenDV"
        Me.colTenDV.HeaderText = "Đơn vị"
        Me.colTenDV.Name = "colTenDV"
        Me.colTenDV.ReadOnly = True
        '
        'btnPhieuNhap
        '
        Me.btnPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPhieuNhap.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhieuNhap.Location = New System.Drawing.Point(568, 338)
        Me.btnPhieuNhap.Name = "btnPhieuNhap"
        Me.btnPhieuNhap.Size = New System.Drawing.Size(83, 46)
        Me.btnPhieuNhap.TabIndex = 18
        Me.btnPhieuNhap.Text = "Phiếu Nhập"
        Me.btnPhieuNhap.UseVisualStyleBackColor = True
        '
        'cboDonVi
        '
        Me.cboDonVi.FormattingEnabled = True
        Me.cboDonVi.Location = New System.Drawing.Point(95, 162)
        Me.cboDonVi.Name = "cboDonVi"
        Me.cboDonVi.Size = New System.Drawing.Size(423, 21)
        Me.cboDonVi.TabIndex = 3
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(95, 117)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(423, 20)
        Me.txtSoLuong.TabIndex = 2
        '
        'txtTenSanPham
        '
        Me.txtTenSanPham.Location = New System.Drawing.Point(130, 72)
        Me.txtTenSanPham.Name = "txtTenSanPham"
        Me.txtTenSanPham.Size = New System.Drawing.Size(388, 20)
        Me.txtTenSanPham.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Đơn vị"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(202, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Số lượng"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Tên sản phẩm"
        '
        'btnSuaSP
        '
        Me.btnSuaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaSP.Location = New System.Drawing.Point(377, 248)
        Me.btnSuaSP.Name = "btnSuaSP"
        Me.btnSuaSP.Size = New System.Drawing.Size(81, 34)
        Me.btnSuaSP.TabIndex = 6
        Me.btnSuaSP.Text = "Sửa"
        Me.btnSuaSP.UseVisualStyleBackColor = True
        '
        'btnXoaSP
        '
        Me.btnXoaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaSP.Location = New System.Drawing.Point(210, 248)
        Me.btnXoaSP.Name = "btnXoaSP"
        Me.btnXoaSP.Size = New System.Drawing.Size(81, 34)
        Me.btnXoaSP.TabIndex = 5
        Me.btnXoaSP.Text = "Xóa"
        Me.btnXoaSP.UseVisualStyleBackColor = True
        '
        'btnThemSP
        '
        Me.btnThemSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemSP.Location = New System.Drawing.Point(55, 248)
        Me.btnThemSP.Name = "btnThemSP"
        Me.btnThemSP.Size = New System.Drawing.Size(81, 34)
        Me.btnThemSP.TabIndex = 4
        Me.btnThemSP.Text = "Thêm"
        Me.btnThemSP.UseVisualStyleBackColor = True
        '
        'btnTimSP
        '
        Me.btnTimSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimSP.Location = New System.Drawing.Point(475, 207)
        Me.btnTimSP.Name = "btnTimSP"
        Me.btnTimSP.Size = New System.Drawing.Size(43, 22)
        Me.btnTimSP.TabIndex = 7
        Me.btnTimSP.Text = "Tìm"
        Me.btnTimSP.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(1320, 45)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "QUẢN LÝ KHO HÀNG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSDT
        '
        Me.lblSDT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSDT.AutoSize = True
        Me.lblSDT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSDT.Location = New System.Drawing.Point(988, 107)
        Me.lblSDT.Name = "lblSDT"
        Me.lblSDT.Size = New System.Drawing.Size(82, 20)
        Me.lblSDT.TabIndex = 81
        Me.lblSDT.Text = "Điện thoại"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(574, 109)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 20)
        Me.lblEmail.TabIndex = 80
        Me.lblEmail.Text = "Email"
        '
        'txtChietKhau
        '
        Me.txtChietKhau.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtChietKhau.Location = New System.Drawing.Point(1080, 66)
        Me.txtChietKhau.Name = "txtChietKhau"
        Me.txtChietKhau.Size = New System.Drawing.Size(253, 20)
        Me.txtChietKhau.TabIndex = 10
        '
        'txtTenNCC
        '
        Me.txtTenNCC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTenNCC.Location = New System.Drawing.Point(687, 67)
        Me.txtTenNCC.Name = "txtTenNCC"
        Me.txtTenNCC.Size = New System.Drawing.Size(295, 20)
        Me.txtTenNCC.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(574, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Ghi chú"
        '
        'lblChietKhau
        '
        Me.lblChietKhau.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblChietKhau.AutoSize = True
        Me.lblChietKhau.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChietKhau.Location = New System.Drawing.Point(988, 65)
        Me.lblChietKhau.Name = "lblChietKhau"
        Me.lblChietKhau.Size = New System.Drawing.Size(86, 20)
        Me.lblChietKhau.TabIndex = 73
        Me.lblChietKhau.Text = "Chiết khấu"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(574, 169)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 20)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Địa chỉ"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(574, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 20)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Nhà cung cấp"
        '
        'btnSuaNCC
        '
        Me.btnSuaNCC.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaNCC.Location = New System.Drawing.Point(1028, 350)
        Me.btnSuaNCC.Name = "btnSuaNCC"
        Me.btnSuaNCC.Size = New System.Drawing.Size(81, 34)
        Me.btnSuaNCC.TabIndex = 16
        Me.btnSuaNCC.Text = "Sửa"
        Me.btnSuaNCC.UseVisualStyleBackColor = True
        '
        'btnXoaNCC
        '
        Me.btnXoaNCC.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaNCC.Location = New System.Drawing.Point(876, 350)
        Me.btnXoaNCC.Name = "btnXoaNCC"
        Me.btnXoaNCC.Size = New System.Drawing.Size(81, 34)
        Me.btnXoaNCC.TabIndex = 15
        Me.btnXoaNCC.Text = "Xóa"
        Me.btnXoaNCC.UseVisualStyleBackColor = True
        '
        'btnThemNCC
        '
        Me.btnThemNCC.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemNCC.Location = New System.Drawing.Point(724, 350)
        Me.btnThemNCC.Name = "btnThemNCC"
        Me.btnThemNCC.Size = New System.Drawing.Size(81, 34)
        Me.btnThemNCC.TabIndex = 14
        Me.btnThemNCC.Text = "Thêm"
        Me.btnThemNCC.UseVisualStyleBackColor = True
        '
        'btnTimNCC
        '
        Me.btnTimNCC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTimNCC.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimNCC.Location = New System.Drawing.Point(1293, 297)
        Me.btnTimNCC.Name = "btnTimNCC"
        Me.btnTimNCC.Size = New System.Drawing.Size(40, 24)
        Me.btnTimNCC.TabIndex = 17
        Me.btnTimNCC.Text = "Tìm"
        Me.btnTimNCC.UseVisualStyleBackColor = True
        '
        'dgvDSNhaCungCap
        '
        Me.dgvDSNhaCungCap.AllowUserToAddRows = False
        Me.dgvDSNhaCungCap.AllowUserToDeleteRows = False
        Me.dgvDSNhaCungCap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDSNhaCungCap.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDSNhaCungCap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDSNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSNhaCungCap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaNCC, Me.colTenNCC, Me.colDiaChi, Me.colChietKhau, Me.colGhiChu, Me.colEmail, Me.colSDT})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDSNhaCungCap.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDSNhaCungCap.Location = New System.Drawing.Point(448, 419)
        Me.dgvDSNhaCungCap.Name = "dgvDSNhaCungCap"
        Me.dgvDSNhaCungCap.RowHeadersVisible = False
        Me.dgvDSNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSNhaCungCap.Size = New System.Drawing.Size(902, 262)
        Me.dgvDSNhaCungCap.TabIndex = 88
        '
        'colMaNCC
        '
        Me.colMaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaNCC.DataPropertyName = "MaNCC"
        Me.colMaNCC.HeaderText = "Mã nhà cung cấp"
        Me.colMaNCC.Name = "colMaNCC"
        Me.colMaNCC.ReadOnly = True
        Me.colMaNCC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colMaNCC.Visible = False
        '
        'colTenNCC
        '
        Me.colTenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTenNCC.DataPropertyName = "TenNCC"
        Me.colTenNCC.HeaderText = "Tên nhà cung cấp"
        Me.colTenNCC.Name = "colTenNCC"
        Me.colTenNCC.ReadOnly = True
        '
        'colDiaChi
        '
        Me.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDiaChi.DataPropertyName = "DiaChi"
        Me.colDiaChi.HeaderText = "Địa chỉ"
        Me.colDiaChi.Name = "colDiaChi"
        Me.colDiaChi.ReadOnly = True
        '
        'colChietKhau
        '
        Me.colChietKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colChietKhau.DataPropertyName = "ChietKhau"
        Me.colChietKhau.HeaderText = "Chiết khấu"
        Me.colChietKhau.Name = "colChietKhau"
        Me.colChietKhau.ReadOnly = True
        '
        'colGhiChu
        '
        Me.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colGhiChu.DataPropertyName = "GhiChu"
        Me.colGhiChu.HeaderText = "Ghi chú"
        Me.colGhiChu.Name = "colGhiChu"
        Me.colGhiChu.ReadOnly = True
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmail.DataPropertyName = "MaNCC_Email"
        Me.colEmail.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.colEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colSDT
        '
        Me.colSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSDT.DataPropertyName = "MaNCC_SDT"
        Me.colSDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colSDT.HeaderText = "Điện thoại"
        Me.colSDT.Name = "colSDT"
        Me.colSDT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(500, 387)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(846, 29)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "DANH SÁCH NHÀ CUNG CẤP"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDiaChi.Location = New System.Drawing.Point(687, 169)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(646, 40)
        Me.txtDiaChi.TabIndex = 12
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtGhiChu.Location = New System.Drawing.Point(687, 233)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(646, 40)
        Me.txtGhiChu.TabIndex = 13
        '
        'btnCong1
        '
        Me.btnCong1.Location = New System.Drawing.Point(963, 106)
        Me.btnCong1.Name = "btnCong1"
        Me.btnCong1.Size = New System.Drawing.Size(19, 20)
        Me.btnCong1.TabIndex = 95
        Me.btnCong1.Text = "+"
        Me.btnCong1.UseVisualStyleBackColor = True
        '
        'btnCong2
        '
        Me.btnCong2.Location = New System.Drawing.Point(1321, 106)
        Me.btnCong2.Name = "btnCong2"
        Me.btnCong2.Size = New System.Drawing.Size(19, 20)
        Me.btnCong2.TabIndex = 96
        Me.btnCong2.Text = "+"
        Me.btnCong2.UseVisualStyleBackColor = True
        '
        'errMain
        '
        Me.errMain.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Tìm kiếm"
        '
        'txtTimSP
        '
        Me.txtTimSP.Location = New System.Drawing.Point(95, 210)
        Me.txtTimSP.Name = "txtTimSP"
        Me.txtTimSP.Size = New System.Drawing.Size(374, 20)
        Me.txtTimSP.TabIndex = 98
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(574, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Tìm kiếm"
        '
        'txtTimNCC
        '
        Me.txtTimNCC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTimNCC.Location = New System.Drawing.Point(687, 298)
        Me.txtTimNCC.Name = "txtTimNCC"
        Me.txtTimNCC.Size = New System.Drawing.Size(600, 20)
        Me.txtTimNCC.TabIndex = 100
        '
        'cboEmail
        '
        Me.cboEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboEmail.FormattingEnabled = True
        Me.cboEmail.Location = New System.Drawing.Point(687, 107)
        Me.cboEmail.Name = "cboEmail"
        Me.cboEmail.Size = New System.Drawing.Size(270, 21)
        Me.cboEmail.TabIndex = 101
        '
        'cboDienThoai
        '
        Me.cboDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboDienThoai.FormattingEnabled = True
        Me.cboDienThoai.Location = New System.Drawing.Point(1080, 106)
        Me.cboDienThoai.Name = "cboDienThoai"
        Me.cboDienThoai.Size = New System.Drawing.Size(235, 21)
        Me.cboDienThoai.TabIndex = 102
        '
        'stsMain
        '
        Me.stsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslMaNV, Me.tslTenNV})
        Me.stsMain.Location = New System.Drawing.Point(0, 684)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(1362, 22)
        Me.stsMain.TabIndex = 103
        Me.stsMain.Text = "StatusStrip1"
        '
        'tslMaNV
        '
        Me.tslMaNV.Name = "tslMaNV"
        Me.tslMaNV.Size = New System.Drawing.Size(121, 17)
        Me.tslMaNV.Text = "ToolStripStatusLabel1"
        '
        'tslTenNV
        '
        Me.tslTenNV.Name = "tslTenNV"
        Me.tslTenNV.Size = New System.Drawing.Size(121, 17)
        Me.tslTenNV.Text = "ToolStripStatusLabel1"
        '
        'btnThemEmail
        '
        Me.btnThemEmail.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemEmail.Location = New System.Drawing.Point(687, 134)
        Me.btnThemEmail.Name = "btnThemEmail"
        Me.btnThemEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnThemEmail.TabIndex = 104
        Me.btnThemEmail.Text = "Thêm"
        Me.btnThemEmail.UseVisualStyleBackColor = True
        '
        'btnXoaEmail
        '
        Me.btnXoaEmail.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaEmail.Location = New System.Drawing.Point(797, 134)
        Me.btnXoaEmail.Name = "btnXoaEmail"
        Me.btnXoaEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaEmail.TabIndex = 105
        Me.btnXoaEmail.Text = "Xóa"
        Me.btnXoaEmail.UseVisualStyleBackColor = True
        '
        'btnSuaEmail
        '
        Me.btnSuaEmail.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaEmail.Location = New System.Drawing.Point(907, 134)
        Me.btnSuaEmail.Name = "btnSuaEmail"
        Me.btnSuaEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnSuaEmail.TabIndex = 106
        Me.btnSuaEmail.Text = "Sửa"
        Me.btnSuaEmail.UseVisualStyleBackColor = True
        '
        'btnThemSDT
        '
        Me.btnThemSDT.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemSDT.Location = New System.Drawing.Point(1080, 132)
        Me.btnThemSDT.Name = "btnThemSDT"
        Me.btnThemSDT.Size = New System.Drawing.Size(75, 23)
        Me.btnThemSDT.TabIndex = 107
        Me.btnThemSDT.Text = "Thêm"
        Me.btnThemSDT.UseVisualStyleBackColor = True
        '
        'btnXoaSDT
        '
        Me.btnXoaSDT.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaSDT.Location = New System.Drawing.Point(1170, 132)
        Me.btnXoaSDT.Name = "btnXoaSDT"
        Me.btnXoaSDT.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaSDT.TabIndex = 108
        Me.btnXoaSDT.Text = "Xóa"
        Me.btnXoaSDT.UseVisualStyleBackColor = True
        '
        'btnSuaSDT
        '
        Me.btnSuaSDT.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaSDT.Location = New System.Drawing.Point(1261, 132)
        Me.btnSuaSDT.Name = "btnSuaSDT"
        Me.btnSuaSDT.Size = New System.Drawing.Size(75, 23)
        Me.btnSuaSDT.TabIndex = 109
        Me.btnSuaSDT.Text = "Sửa"
        Me.btnSuaSDT.UseVisualStyleBackColor = True
        '
        'btnHoanTat
        '
        Me.btnHoanTat.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoanTat.Location = New System.Drawing.Point(992, 133)
        Me.btnHoanTat.Name = "btnHoanTat"
        Me.btnHoanTat.Size = New System.Drawing.Size(75, 23)
        Me.btnHoanTat.TabIndex = 112
        Me.btnHoanTat.Text = "Hoàn tất"
        Me.btnHoanTat.UseVisualStyleBackColor = True
        Me.btnHoanTat.Visible = False
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(463, 326)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(92, 63)
        Me.btnSend.TabIndex = 114
        Me.btnSend.Text = "Chi Tiết Món Ăn"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmWarehouseKeeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1362, 706)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnHoanTat)
        Me.Controls.Add(Me.btnSuaSDT)
        Me.Controls.Add(Me.btnXoaSDT)
        Me.Controls.Add(Me.btnThemSDT)
        Me.Controls.Add(Me.btnSuaEmail)
        Me.Controls.Add(Me.btnXoaEmail)
        Me.Controls.Add(Me.btnThemEmail)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.cboDienThoai)
        Me.Controls.Add(Me.cboEmail)
        Me.Controls.Add(Me.txtTimNCC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTimSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCong2)
        Me.Controls.Add(Me.btnCong1)
        Me.Controls.Add(Me.dgvDSNhaCungCap)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnSuaNCC)
        Me.Controls.Add(Me.btnXoaNCC)
        Me.Controls.Add(Me.btnThemNCC)
        Me.Controls.Add(Me.btnTimNCC)
        Me.Controls.Add(Me.lblSDT)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtChietKhau)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenNCC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblChietKhau)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnSuaSP)
        Me.Controls.Add(Me.btnXoaSP)
        Me.Controls.Add(Me.btnThemSP)
        Me.Controls.Add(Me.btnTimSP)
        Me.Controls.Add(Me.cboDonVi)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtTenSanPham)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPhieuNhap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDSSanPham)
        Me.Controls.Add(Me.btnPhieuNhan)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmWarehouseKeeper"
        Me.Text = "Thủ kho - Quản lý"
        CType(Me.dgvDSSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDSNhaCungCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsMain.ResumeLayout(False)
        Me.stsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPhieuNhan As Button
    Friend WithEvents dgvDSSanPham As DataGridView
    Friend WithEvents btnPhieuNhap As Button
    Friend WithEvents cboDonVi As ComboBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtTenSanPham As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSuaSP As Button
    Friend WithEvents btnXoaSP As Button
    Friend WithEvents btnThemSP As Button
    Friend WithEvents btnTimSP As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSDT As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtChietKhau As TextBox
    Friend WithEvents txtTenNCC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblChietKhau As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSuaNCC As Button
    Friend WithEvents btnXoaNCC As Button
    Friend WithEvents btnThemNCC As Button
    Friend WithEvents btnTimNCC As Button
    Friend WithEvents dgvDSNhaCungCap As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents btnCong1 As Button
    Friend WithEvents btnCong2 As Button
    Friend WithEvents errMain As ErrorProvider
    Friend WithEvents txtTimSP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents colMaSP As DataGridViewTextBoxColumn
    Friend WithEvents colTenSP As DataGridViewTextBoxColumn
    Friend WithEvents colSoLuongTon As DataGridViewTextBoxColumn
    Friend WithEvents colMaDV As DataGridViewTextBoxColumn
    Friend WithEvents colTenDV As DataGridViewTextBoxColumn
    Friend WithEvents txtTimNCC As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboDienThoai As ComboBox
    Friend WithEvents cboEmail As ComboBox
    Friend WithEvents colMaNCC As DataGridViewTextBoxColumn
    Friend WithEvents colTenNCC As DataGridViewTextBoxColumn
    Friend WithEvents colDiaChi As DataGridViewTextBoxColumn
    Friend WithEvents colChietKhau As DataGridViewTextBoxColumn
    Friend WithEvents colGhiChu As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewComboBoxColumn
    Friend WithEvents colSDT As DataGridViewComboBoxColumn
    Friend WithEvents stsMain As StatusStrip
    Friend WithEvents tslMaNV As ToolStripStatusLabel
    Friend WithEvents tslTenNV As ToolStripStatusLabel
    Friend WithEvents btnSuaSDT As Button
    Friend WithEvents btnXoaSDT As Button
    Friend WithEvents btnThemSDT As Button
    Friend WithEvents btnSuaEmail As Button
    Friend WithEvents btnXoaEmail As Button
    Friend WithEvents btnThemEmail As Button
    Friend WithEvents btnHoanTat As Button
    Friend WithEvents btnSend As Button
End Class
