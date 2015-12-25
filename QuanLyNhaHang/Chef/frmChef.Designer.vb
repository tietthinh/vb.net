<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChef
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCookList = New System.Windows.Forms.DataGridView()
        Me.CookListTransID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CookListDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CookListQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CookListDone = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCook = New System.Windows.Forms.Button()
        Me.btnSendWarehouse = New System.Windows.Forms.Button()
        Me.btnSendWaitor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ltbMessage = New System.Windows.Forms.ListBox()
        Me.txtTotalQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvMaterialList = New System.Windows.Forms.DataGridView()
        Me.DetailDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Decrease = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MaterialQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Increase = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MaterialUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultIncrease = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDouble = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltbException = New System.Windows.Forms.ListBox()
        Me.lblMaterialQuantity = New System.Windows.Forms.Label()
        Me.dgvOrderList = New System.Windows.Forms.DataGridView()
        Me.Ordered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTransID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCantServeList = New System.Windows.Forms.DataGridView()
        Me.CantServeTransID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantServeDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantServeDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantServeQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantServeTimeOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantServeNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitorFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarehouseFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCookList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMaterialList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCantServeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCookList
        '
        Me.dgvCookList.AllowUserToAddRows = False
        Me.dgvCookList.AllowUserToDeleteRows = False
        Me.dgvCookList.AllowUserToResizeColumns = False
        Me.dgvCookList.AllowUserToResizeRows = False
        Me.dgvCookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCookList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCookList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCookList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CookListTransID, Me.CookListDishName, Me.CookListQuantity, Me.CookListDone})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCookList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCookList.Location = New System.Drawing.Point(932, 37)
        Me.dgvCookList.Name = "dgvCookList"
        Me.dgvCookList.ReadOnly = True
        Me.dgvCookList.RowHeadersVisible = False
        Me.dgvCookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCookList.Size = New System.Drawing.Size(410, 515)
        Me.dgvCookList.TabIndex = 2
        '
        'CookListTransID
        '
        Me.CookListTransID.DataPropertyName = "MaChuyen"
        Me.CookListTransID.HeaderText = "Mã chuyển"
        Me.CookListTransID.Name = "CookListTransID"
        Me.CookListTransID.ReadOnly = True
        Me.CookListTransID.Visible = False
        Me.CookListTransID.Width = 103
        '
        'CookListDishName
        '
        Me.CookListDishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CookListDishName.DataPropertyName = "TenMon"
        Me.CookListDishName.HeaderText = "Tên món"
        Me.CookListDishName.Name = "CookListDishName"
        Me.CookListDishName.ReadOnly = True
        '
        'CookListQuantity
        '
        Me.CookListQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CookListQuantity.DataPropertyName = "SoLuong"
        Me.CookListQuantity.HeaderText = "Số lượng"
        Me.CookListQuantity.Name = "CookListQuantity"
        Me.CookListQuantity.ReadOnly = True
        Me.CookListQuantity.Width = 91
        '
        'CookListDone
        '
        Me.CookListDone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CookListDone.HeaderText = ""
        Me.CookListDone.Name = "CookListDone"
        Me.CookListDone.ReadOnly = True
        Me.CookListDone.Text = "Xong"
        Me.CookListDone.UseColumnTextForButtonValue = True
        Me.CookListDone.Width = 5
        '
        'btnCook
        '
        Me.btnCook.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCook.Location = New System.Drawing.Point(543, 449)
        Me.btnCook.Name = "btnCook"
        Me.btnCook.Size = New System.Drawing.Size(201, 76)
        Me.btnCook.TabIndex = 4
        Me.btnCook.Text = "Làm"
        Me.btnCook.UseVisualStyleBackColor = True
        '
        'btnSendWarehouse
        '
        Me.btnSendWarehouse.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendWarehouse.Location = New System.Drawing.Point(763, 490)
        Me.btnSendWarehouse.Name = "btnSendWarehouse"
        Me.btnSendWarehouse.Size = New System.Drawing.Size(147, 35)
        Me.btnSendWarehouse.TabIndex = 6
        Me.btnSendWarehouse.Text = "Gửi thủ kho"
        Me.btnSendWarehouse.UseVisualStyleBackColor = True
        '
        'btnSendWaitor
        '
        Me.btnSendWaitor.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendWaitor.Location = New System.Drawing.Point(763, 449)
        Me.btnSendWaitor.Name = "btnSendWaitor"
        Me.btnSendWaitor.Size = New System.Drawing.Size(147, 35)
        Me.btnSendWaitor.TabIndex = 7
        Me.btnSendWaitor.Text = "Gửi nhân viên"
        Me.btnSendWaitor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DANH SÁCH ĐẶT MÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 509)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "DANH SÁCH GHI CHÚ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(586, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DANH SÁCH KHÔNG LÀM ĐƯỢC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1007, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DANH SÁCH MÓN ĐANG LÀM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(605, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 25)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "DANH SÁCH NGUYÊN LIỆU"
        '
        'ltbMessage
        '
        Me.ltbMessage.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbMessage.FormattingEnabled = True
        Me.ltbMessage.ItemHeight = 20
        Me.ltbMessage.Location = New System.Drawing.Point(986, 558)
        Me.ltbMessage.Name = "ltbMessage"
        Me.ltbMessage.Size = New System.Drawing.Size(356, 144)
        Me.ltbMessage.TabIndex = 38
        '
        'txtTotalQuantity
        '
        Me.txtTotalQuantity.Enabled = False
        Me.txtTotalQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQuantity.Location = New System.Drawing.Point(462, 10)
        Me.txtTotalQuantity.Name = "txtTotalQuantity"
        Me.txtTotalQuantity.Size = New System.Drawing.Size(52, 26)
        Me.txtTotalQuantity.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(332, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Số lượng món"
        '
        'dgvMaterialList
        '
        Me.dgvMaterialList.AllowUserToAddRows = False
        Me.dgvMaterialList.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMaterialList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMaterialList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMaterialList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMaterialList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMaterialList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterialList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailDishID, Me.MaterialID, Me.MaterialName, Me.Decrease, Me.MaterialQuantity, Me.Increase, Me.MaterialUnit, Me.DefaultIncrease, Me.IsDouble})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMaterialList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMaterialList.Location = New System.Drawing.Point(520, 37)
        Me.dgvMaterialList.Name = "dgvMaterialList"
        Me.dgvMaterialList.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMaterialList.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMaterialList.RowHeadersVisible = False
        Me.dgvMaterialList.Size = New System.Drawing.Size(406, 406)
        Me.dgvMaterialList.TabIndex = 41
        '
        'DetailDishID
        '
        Me.DetailDishID.DataPropertyName = "MaMon"
        Me.DetailDishID.HeaderText = "Mã món"
        Me.DetailDishID.Name = "DetailDishID"
        Me.DetailDishID.ReadOnly = True
        Me.DetailDishID.Visible = False
        Me.DetailDishID.Width = 67
        '
        'MaterialID
        '
        Me.MaterialID.DataPropertyName = "MaSP"
        Me.MaterialID.HeaderText = "Mã nguyên liệu"
        Me.MaterialID.Name = "MaterialID"
        Me.MaterialID.ReadOnly = True
        Me.MaterialID.Visible = False
        Me.MaterialID.Width = 112
        '
        'MaterialName
        '
        Me.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaterialName.DataPropertyName = "TenSP"
        Me.MaterialName.HeaderText = "Nguyên liệu"
        Me.MaterialName.Name = "MaterialName"
        Me.MaterialName.ReadOnly = True
        '
        'Decrease
        '
        Me.Decrease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Decrease.HeaderText = ""
        Me.Decrease.Name = "Decrease"
        Me.Decrease.ReadOnly = True
        Me.Decrease.Text = "-"
        Me.Decrease.UseColumnTextForButtonValue = True
        Me.Decrease.Width = 5
        '
        'MaterialQuantity
        '
        Me.MaterialQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaterialQuantity.DataPropertyName = "SoLuong"
        DataGridViewCellStyle5.Format = "#,###0.#######"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.MaterialQuantity.DefaultCellStyle = DataGridViewCellStyle5
        Me.MaterialQuantity.HeaderText = "Số lượng"
        Me.MaterialQuantity.Name = "MaterialQuantity"
        Me.MaterialQuantity.ReadOnly = True
        Me.MaterialQuantity.Width = 84
        '
        'Increase
        '
        Me.Increase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Increase.HeaderText = ""
        Me.Increase.Name = "Increase"
        Me.Increase.ReadOnly = True
        Me.Increase.Text = "+"
        Me.Increase.UseColumnTextForButtonValue = True
        Me.Increase.Width = 5
        '
        'MaterialUnit
        '
        Me.MaterialUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaterialUnit.DataPropertyName = "TenDV"
        Me.MaterialUnit.HeaderText = "Đơn vị"
        Me.MaterialUnit.Name = "MaterialUnit"
        Me.MaterialUnit.ReadOnly = True
        Me.MaterialUnit.Width = 59
        '
        'DefaultIncrease
        '
        Me.DefaultIncrease.DataPropertyName = "DoTangMacDinh"
        Me.DefaultIncrease.HeaderText = "Giá trị tăng mặc định"
        Me.DefaultIncrease.Name = "DefaultIncrease"
        Me.DefaultIncrease.ReadOnly = True
        Me.DefaultIncrease.Visible = False
        Me.DefaultIncrease.Width = 169
        '
        'IsDouble
        '
        Me.IsDouble.DataPropertyName = "SoThuc"
        Me.IsDouble.HeaderText = "Số thực"
        Me.IsDouble.Name = "IsDouble"
        Me.IsDouble.ReadOnly = True
        Me.IsDouble.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsDouble.Visible = False
        Me.IsDouble.Width = 83
        '
        'ltbException
        '
        Me.ltbException.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbException.FormattingEnabled = True
        Me.ltbException.ItemHeight = 20
        Me.ltbException.Location = New System.Drawing.Point(12, 538)
        Me.ltbException.Name = "ltbException"
        Me.ltbException.Size = New System.Drawing.Size(502, 164)
        Me.ltbException.TabIndex = 42
        '
        'lblMaterialQuantity
        '
        Me.lblMaterialQuantity.AutoSize = True
        Me.lblMaterialQuantity.Location = New System.Drawing.Point(835, 18)
        Me.lblMaterialQuantity.Name = "lblMaterialQuantity"
        Me.lblMaterialQuantity.Size = New System.Drawing.Size(93, 13)
        Me.lblMaterialQuantity.TabIndex = 43
        Me.lblMaterialQuantity.Text = "Material's Quantity"
        Me.lblMaterialQuantity.Visible = False
        '
        'dgvOrderList
        '
        Me.dgvOrderList.AllowUserToAddRows = False
        Me.dgvOrderList.AllowUserToDeleteRows = False
        Me.dgvOrderList.AllowUserToResizeColumns = False
        Me.dgvOrderList.AllowUserToResizeRows = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvOrderList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ordered, Me.OrderTransID, Me.OrderDishID, Me.OrderDishName, Me.TimeOrder, Me.OrderQuantity, Me.OrderNote})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderList.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvOrderList.Location = New System.Drawing.Point(12, 37)
        Me.dgvOrderList.Name = "dgvOrderList"
        Me.dgvOrderList.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderList.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvOrderList.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvOrderList.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderList.Size = New System.Drawing.Size(502, 469)
        Me.dgvOrderList.TabIndex = 44
        '
        'Ordered
        '
        Me.Ordered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ordered.HeaderText = "STT"
        Me.Ordered.Name = "Ordered"
        Me.Ordered.ReadOnly = True
        Me.Ordered.Width = 58
        '
        'OrderTransID
        '
        Me.OrderTransID.DataPropertyName = "MaChuyen"
        Me.OrderTransID.HeaderText = "Mã chuyển"
        Me.OrderTransID.Name = "OrderTransID"
        Me.OrderTransID.ReadOnly = True
        Me.OrderTransID.Visible = False
        '
        'OrderDishID
        '
        Me.OrderDishID.DataPropertyName = "MaMon"
        Me.OrderDishID.HeaderText = "Mã món"
        Me.OrderDishID.Name = "OrderDishID"
        Me.OrderDishID.ReadOnly = True
        Me.OrderDishID.Visible = False
        '
        'OrderDishName
        '
        Me.OrderDishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrderDishName.DataPropertyName = "TenMon"
        Me.OrderDishName.HeaderText = "Tên món"
        Me.OrderDishName.Name = "OrderDishName"
        Me.OrderDishName.ReadOnly = True
        '
        'TimeOrder
        '
        Me.TimeOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TimeOrder.DataPropertyName = "ThoiGian"
        Me.TimeOrder.HeaderText = "Giờ đặt"
        Me.TimeOrder.Name = "TimeOrder"
        Me.TimeOrder.ReadOnly = True
        Me.TimeOrder.Width = 80
        '
        'OrderQuantity
        '
        Me.OrderQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OrderQuantity.DataPropertyName = "SoLuong"
        Me.OrderQuantity.HeaderText = "Số lượng"
        Me.OrderQuantity.Name = "OrderQuantity"
        Me.OrderQuantity.ReadOnly = True
        Me.OrderQuantity.Width = 91
        '
        'OrderNote
        '
        Me.OrderNote.DataPropertyName = "GhiChu"
        Me.OrderNote.HeaderText = "Ghi chú"
        Me.OrderNote.Name = "OrderNote"
        Me.OrderNote.ReadOnly = True
        Me.OrderNote.Visible = False
        '
        'dgvCantServeList
        '
        Me.dgvCantServeList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCantServeList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCantServeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCantServeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CantServeTransID, Me.CantServeDishID, Me.CantServeDishName, Me.CantServeQuantity, Me.CantServeTimeOrder, Me.CantServeNote, Me.WaitorFlag, Me.WarehouseFlag})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCantServeList.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvCantServeList.Location = New System.Drawing.Point(520, 558)
        Me.dgvCantServeList.Name = "dgvCantServeList"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCantServeList.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvCantServeList.RowHeadersVisible = False
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCantServeList.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvCantServeList.Size = New System.Drawing.Size(460, 144)
        Me.dgvCantServeList.TabIndex = 45
        '
        'CantServeTransID
        '
        Me.CantServeTransID.DataPropertyName = "MaChuyen"
        Me.CantServeTransID.HeaderText = "Mã chuyển"
        Me.CantServeTransID.Name = "CantServeTransID"
        Me.CantServeTransID.Visible = False
        '
        'CantServeDishID
        '
        Me.CantServeDishID.DataPropertyName = "MaMon"
        Me.CantServeDishID.HeaderText = "Mã món"
        Me.CantServeDishID.Name = "CantServeDishID"
        Me.CantServeDishID.Visible = False
        '
        'CantServeDishName
        '
        Me.CantServeDishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantServeDishName.DataPropertyName = "TenMon"
        Me.CantServeDishName.HeaderText = "Tên món"
        Me.CantServeDishName.Name = "CantServeDishName"
        '
        'CantServeQuantity
        '
        Me.CantServeQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CantServeQuantity.DataPropertyName = "SoLuong"
        Me.CantServeQuantity.HeaderText = "Số lượng"
        Me.CantServeQuantity.Name = "CantServeQuantity"
        Me.CantServeQuantity.Width = 91
        '
        'CantServeTimeOrder
        '
        Me.CantServeTimeOrder.DataPropertyName = "ThoiGian"
        Me.CantServeTimeOrder.HeaderText = "Giờ đặt"
        Me.CantServeTimeOrder.Name = "CantServeTimeOrder"
        Me.CantServeTimeOrder.Visible = False
        '
        'CantServeNote
        '
        Me.CantServeNote.DataPropertyName = "GhiChu"
        Me.CantServeNote.HeaderText = "Ghi chú"
        Me.CantServeNote.Name = "CantServeNote"
        Me.CantServeNote.Visible = False
        '
        'WaitorFlag
        '
        Me.WaitorFlag.HeaderText = "Tín hiệu phục vụ"
        Me.WaitorFlag.Name = "WaitorFlag"
        Me.WaitorFlag.Visible = False
        '
        'WarehouseFlag
        '
        Me.WarehouseFlag.HeaderText = "Tín hiệu kho"
        Me.WarehouseFlag.Name = "WarehouseFlag"
        Me.WarehouseFlag.Visible = False
        '
        'frmChef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 705)
        Me.Controls.Add(Me.dgvCantServeList)
        Me.Controls.Add(Me.dgvOrderList)
        Me.Controls.Add(Me.lblMaterialQuantity)
        Me.Controls.Add(Me.ltbException)
        Me.Controls.Add(Me.dgvMaterialList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalQuantity)
        Me.Controls.Add(Me.ltbMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSendWaitor)
        Me.Controls.Add(Me.btnSendWarehouse)
        Me.Controls.Add(Me.btnCook)
        Me.Controls.Add(Me.dgvCookList)
        Me.Name = "frmChef"
        Me.Text = "Đầu bếp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvCookList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMaterialList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCantServeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCookList As System.Windows.Forms.DataGridView
    Friend WithEvents btnCook As System.Windows.Forms.Button
    Friend WithEvents btnSendWarehouse As System.Windows.Forms.Button
    Friend WithEvents btnSendWaitor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ltbMessage As System.Windows.Forms.ListBox
    Friend WithEvents txtTotalQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvMaterialList As System.Windows.Forms.DataGridView
    Friend WithEvents ltbException As System.Windows.Forms.ListBox
    Friend WithEvents CookListTransID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CookListDishName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CookListQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CookListDone As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lblMaterialQuantity As System.Windows.Forms.Label
    Friend WithEvents DetailDishID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Decrease As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MaterialQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Increase As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MaterialUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefaultIncrease As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsDouble As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvOrderList As System.Windows.Forms.DataGridView
    Friend WithEvents Ordered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderTransID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderDishID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderDishName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCantServeList As System.Windows.Forms.DataGridView
    Friend WithEvents CantServeTransID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantServeDishID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantServeDishName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantServeQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantServeTimeOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantServeNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitorFlag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WarehouseFlag As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
