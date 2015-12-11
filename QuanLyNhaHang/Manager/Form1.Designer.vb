<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.TbCtrNhanVien = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcmnd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxLoaiNV = New System.Windows.Forms.ComboBox()
        Me.dtpThoiGianBD = New System.Windows.Forms.DateTimePicker()
        Me.dtgNhanVien = New System.Windows.Forms.DataGridView()
        Me.MaNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThoiGianBatDau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenChucVu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbNam = New System.Windows.Forms.RadioButton()
        Me.rdbNu = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbDangLam = New System.Windows.Forms.RadioButton()
        Me.rdbDaNghi = New System.Windows.Forms.RadioButton()
        Me.cbxTenChucVu = New System.Windows.Forms.ComboBox()
        Me.TbCtrNhanVien.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(491, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MaNV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Họ Tên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Thời Gian Bắt Đầu"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(987, 10)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(116, 42)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(987, 58)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(116, 42)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(987, 106)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(116, 42)
        Me.btnXoa.TabIndex = 11
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'TbCtrNhanVien
        '
        Me.TbCtrNhanVien.Controls.Add(Me.TabPage1)
        Me.TbCtrNhanVien.Controls.Add(Me.TabPage2)
        Me.TbCtrNhanVien.Location = New System.Drawing.Point(12, 72)
        Me.TbCtrNhanVien.Name = "TbCtrNhanVien"
        Me.TbCtrNhanVien.SelectedIndex = 0
        Me.TbCtrNhanVien.Size = New System.Drawing.Size(1185, 430)
        Me.TbCtrNhanVien.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dtgNhanVien)
        Me.TabPage1.Controls.Add(Me.btnXoa)
        Me.TabPage1.Controls.Add(Me.btnSua)
        Me.TabPage1.Controls.Add(Me.btnThem)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1177, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nhân Viên"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.TextBox10)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox8)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1025, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Đặt Món"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(178, 18)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(251, 22)
        Me.txtMaNV.TabIndex = 0
        Me.txtMaNV.Visible = False
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(178, 55)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(251, 22)
        Me.txtTen.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CMND"
        '
        'txtcmnd
        '
        Me.txtcmnd.Location = New System.Drawing.Point(178, 132)
        Me.txtcmnd.Name = "txtcmnd"
        Me.txtcmnd.Size = New System.Drawing.Size(251, 22)
        Me.txtcmnd.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(475, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Loại NV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Ngày Sinh"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(707, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Tên Chức Vụ"
        '
        'cbxLoaiNV
        '
        Me.cbxLoaiNV.FormattingEnabled = True
        Me.cbxLoaiNV.Location = New System.Drawing.Point(541, 84)
        Me.cbxLoaiNV.Name = "cbxLoaiNV"
        Me.cbxLoaiNV.Size = New System.Drawing.Size(143, 24)
        Me.cbxLoaiNV.TabIndex = 7
        '
        'dtpThoiGianBD
        '
        Me.dtpThoiGianBD.CustomFormat = "dd/MM/yyyy hh:MM:ss"
        Me.dtpThoiGianBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThoiGianBD.Location = New System.Drawing.Point(178, 167)
        Me.dtpThoiGianBD.Name = "dtpThoiGianBD"
        Me.dtpThoiGianBD.Size = New System.Drawing.Size(251, 22)
        Me.dtpThoiGianBD.TabIndex = 2
        '
        'dtgNhanVien
        '
        Me.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgNhanVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNV, Me.HoTen, Me.ThoiGianBatDau, Me.CMND, Me.TinhTrang, Me.NgaySinh, Me.GioiTinh, Me.LoaiNV, Me.TenChucVu})
        Me.dtgNhanVien.Location = New System.Drawing.Point(6, 218)
        Me.dtgNhanVien.Name = "dtgNhanVien"
        Me.dtgNhanVien.RowTemplate.Height = 24
        Me.dtgNhanVien.Size = New System.Drawing.Size(1163, 180)
        Me.dtgNhanVien.TabIndex = 6
        '
        'MaNV
        '
        Me.MaNV.HeaderText = "MaNV"
        Me.MaNV.Name = "MaNV"
        Me.MaNV.Width = 90
        '
        'HoTen
        '
        Me.HoTen.HeaderText = "Họ Tên"
        Me.HoTen.Name = "HoTen"
        Me.HoTen.Width = 220
        '
        'ThoiGianBatDau
        '
        Me.ThoiGianBatDau.HeaderText = "Thời Gian Bắt Đầu"
        Me.ThoiGianBatDau.Name = "ThoiGianBatDau"
        Me.ThoiGianBatDau.Width = 150
        '
        'CMND
        '
        Me.CMND.HeaderText = "CMND"
        Me.CMND.Name = "CMND"
        Me.CMND.Width = 150
        '
        'TinhTrang
        '
        Me.TinhTrang.HeaderText = "Tình Trạng"
        Me.TinhTrang.Name = "TinhTrang"
        '
        'NgaySinh
        '
        Me.NgaySinh.HeaderText = "Ngày Sinh"
        Me.NgaySinh.Name = "NgaySinh"
        Me.NgaySinh.Width = 150
        '
        'GioiTinh
        '
        Me.GioiTinh.HeaderText = "Giới Tính"
        Me.GioiTinh.Name = "GioiTinh"
        Me.GioiTinh.Width = 80
        '
        'LoaiNV
        '
        Me.LoaiNV.HeaderText = "Loại NV"
        Me.LoaiNV.Name = "LoaiNV"
        Me.LoaiNV.Width = 80
        '
        'TenChucVu
        '
        Me.TenChucVu.HeaderText = "Tên Chức Vụ"
        Me.TenChucVu.Name = "TenChucVu"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Mã Đặt Món"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(665, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Thời Gian"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(339, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 29)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Tổng Tiền"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(665, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Ghi Chú"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(143, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 22)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(484, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(164, 22)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(765, 17)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(212, 22)
        Me.TextBox4.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(327, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Số Bàn Chung"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(327, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Số Lượng Khách"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Tên Nhân Viên"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(472, 17)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(131, 22)
        Me.TextBox5.TabIndex = 1
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(472, 51)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(131, 22)
        Me.TextBox8.TabIndex = 1
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(143, 53)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(127, 22)
        Me.TextBox10.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(765, 51)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(212, 22)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DataGridView2
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Location = New System.Drawing.Point(25, 181)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(978, 198)
        Me.DataGridView2.TabIndex = 3
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(541, 130)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(93, 32)
        Me.btnTimKiem.TabIndex = 11
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(655, 135)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(251, 22)
        Me.txtTimKiem.TabIndex = 8
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CustomFormat = "dd/MM/yyyy hh:MM:ss"
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaySinh.Location = New System.Drawing.Point(178, 91)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(251, 22)
        Me.dtpNgaySinh.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtpNgaySinh)
        Me.GroupBox1.Controls.Add(Me.dtpThoiGianBD)
        Me.GroupBox1.Controls.Add(Me.cbxTenChucVu)
        Me.GroupBox1.Controls.Add(Me.cbxLoaiNV)
        Me.GroupBox1.Controls.Add(Me.txtTimKiem)
        Me.GroupBox1.Controls.Add(Me.txtcmnd)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Controls.Add(Me.txtMaNV)
        Me.GroupBox1.Controls.Add(Me.btnTimKiem)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 203)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Nhân Viên"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbNu)
        Me.GroupBox2.Controls.Add(Me.rdbNam)
        Me.GroupBox2.Location = New System.Drawing.Point(478, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 44)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Giới Tính"
        '
        'rdbNam
        '
        Me.rdbNam.AutoSize = True
        Me.rdbNam.Location = New System.Drawing.Point(15, 19)
        Me.rdbNam.Name = "rdbNam"
        Me.rdbNam.Size = New System.Drawing.Size(58, 21)
        Me.rdbNam.TabIndex = 0
        Me.rdbNam.TabStop = True
        Me.rdbNam.Text = "Nam"
        Me.rdbNam.UseVisualStyleBackColor = True
        '
        'rdbNu
        '
        Me.rdbNu.AutoSize = True
        Me.rdbNu.Location = New System.Drawing.Point(112, 19)
        Me.rdbNu.Name = "rdbNu"
        Me.rdbNu.Size = New System.Drawing.Size(47, 21)
        Me.rdbNu.TabIndex = 0
        Me.rdbNu.TabStop = True
        Me.rdbNu.Text = "Nữ"
        Me.rdbNu.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbDangLam)
        Me.GroupBox3.Controls.Add(Me.rdbDaNghi)
        Me.GroupBox3.Location = New System.Drawing.Point(700, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 44)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tình Trạng"
        '
        'rdbDangLam
        '
        Me.rdbDangLam.AutoSize = True
        Me.rdbDangLam.Location = New System.Drawing.Point(112, 19)
        Me.rdbDangLam.Name = "rdbDangLam"
        Me.rdbDangLam.Size = New System.Drawing.Size(94, 21)
        Me.rdbDangLam.TabIndex = 0
        Me.rdbDangLam.TabStop = True
        Me.rdbDangLam.Text = "Đang Làm"
        Me.rdbDangLam.UseVisualStyleBackColor = True
        '
        'rdbDaNghi
        '
        Me.rdbDaNghi.AutoSize = True
        Me.rdbDaNghi.Location = New System.Drawing.Point(15, 19)
        Me.rdbDaNghi.Name = "rdbDaNghi"
        Me.rdbDaNghi.Size = New System.Drawing.Size(80, 21)
        Me.rdbDaNghi.TabIndex = 0
        Me.rdbDaNghi.TabStop = True
        Me.rdbDaNghi.Text = "Đã Nghĩ"
        Me.rdbDaNghi.UseVisualStyleBackColor = True
        '
        'cbxTenChucVu
        '
        Me.cbxTenChucVu.FormattingEnabled = True
        Me.cbxTenChucVu.Location = New System.Drawing.Point(803, 84)
        Me.cbxTenChucVu.Name = "cbxTenChucVu"
        Me.cbxTenChucVu.Size = New System.Drawing.Size(143, 24)
        Me.cbxTenChucVu.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 514)
        Me.Controls.Add(Me.TbCtrNhanVien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "QUAN LY"
        Me.TbCtrNhanVien.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents TbCtrNhanVien As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtcmnd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpThoiGianBD As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxLoaiNV As System.Windows.Forms.ComboBox
    Friend WithEvents dtgNhanVien As System.Windows.Forms.DataGridView
    Friend WithEvents MaNV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoTen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThoiGianBatDau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgaySinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioiTinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoaiNV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenChucVu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTimKiem As System.Windows.Forms.TextBox
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents dtpNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDangLam As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDaNghi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbNu As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNam As System.Windows.Forms.RadioButton
    Friend WithEvents cbxTenChucVu As System.Windows.Forms.ComboBox

End Class
