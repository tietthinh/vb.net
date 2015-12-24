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
        Me.ltvOrderList = New System.Windows.Forms.ListView()
        Me.Index = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TransID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DishID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OrderDishName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimeOrder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OrderQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OrderNote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ltvCantServeList = New System.Windows.Forms.ListView()
        Me.CantServeTransID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantServeDishID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantServeDishName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantServeQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantServeTimeOrder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantServeNote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WaitorFlag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WarehouseFlag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ltbMessage = New System.Windows.Forms.ListBox()
        Me.txtTotalQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvMaterialList = New System.Windows.Forms.DataGridView()
        Me.ltbException = New System.Windows.Forms.ListBox()
        Me.lblMaterialQuantity = New System.Windows.Forms.Label()
        Me.DetailDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Decrease = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MaterialQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Increase = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MaterialUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultIncrease = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDouble = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCookList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMaterialList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ltvOrderList
        '
        Me.ltvOrderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Index, Me.TransID, Me.DishID, Me.OrderDishName, Me.TimeOrder, Me.OrderQuantity, Me.OrderNote})
        Me.ltvOrderList.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltvOrderList.FullRowSelect = True
        Me.ltvOrderList.Location = New System.Drawing.Point(12, 37)
        Me.ltvOrderList.Name = "ltvOrderList"
        Me.ltvOrderList.Size = New System.Drawing.Size(502, 469)
        Me.ltvOrderList.TabIndex = 33
        Me.ltvOrderList.UseCompatibleStateImageBehavior = False
        Me.ltvOrderList.View = System.Windows.Forms.View.Details
        '
        'Index
        '
        Me.Index.Text = "STT"
        '
        'TransID
        '
        Me.TransID.Text = "Mã chuyển"
        Me.TransID.Width = 0
        '
        'DishID
        '
        Me.DishID.Text = "Mã đặt món"
        Me.DishID.Width = 0
        '
        'OrderDishName
        '
        Me.OrderDishName.Text = "Tên món"
        Me.OrderDishName.Width = 158
        '
        'TimeOrder
        '
        Me.TimeOrder.Text = "Giờ đặt"
        Me.TimeOrder.Width = 140
        '
        'OrderQuantity
        '
        Me.OrderQuantity.Text = "Số lượng"
        Me.OrderQuantity.Width = 140
        '
        'OrderNote
        '
        Me.OrderNote.Text = "Ghi chú"
        Me.OrderNote.Width = 0
        '
        'ltvCantServeList
        '
        Me.ltvCantServeList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CantServeTransID, Me.CantServeDishID, Me.CantServeDishName, Me.CantServeQuantity, Me.CantServeTimeOrder, Me.CantServeNote, Me.WaitorFlag, Me.WarehouseFlag})
        Me.ltvCantServeList.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltvCantServeList.FullRowSelect = True
        Me.ltvCantServeList.Location = New System.Drawing.Point(520, 558)
        Me.ltvCantServeList.Name = "ltvCantServeList"
        Me.ltvCantServeList.Size = New System.Drawing.Size(460, 144)
        Me.ltvCantServeList.TabIndex = 36
        Me.ltvCantServeList.UseCompatibleStateImageBehavior = False
        Me.ltvCantServeList.View = System.Windows.Forms.View.Details
        '
        'CantServeTransID
        '
        Me.CantServeTransID.Text = "Mã chuyển"
        Me.CantServeTransID.Width = 0
        '
        'CantServeDishID
        '
        Me.CantServeDishID.Text = "Mã đặt món"
        Me.CantServeDishID.Width = 0
        '
        'CantServeDishName
        '
        Me.CantServeDishName.Text = "Tên món"
        Me.CantServeDishName.Width = 272
        '
        'CantServeQuantity
        '
        Me.CantServeQuantity.Text = "Số lượng"
        Me.CantServeQuantity.Width = 184
        '
        'CantServeTimeOrder
        '
        Me.CantServeTimeOrder.Text = "Giờ đặt"
        Me.CantServeTimeOrder.Width = 0
        '
        'CantServeNote
        '
        Me.CantServeNote.Text = "Ghi chú"
        '
        'WaitorFlag
        '
        Me.WaitorFlag.Text = "Tín hiệu phục vụ"
        Me.WaitorFlag.Width = 0
        '
        'WarehouseFlag
        '
        Me.WarehouseFlag.Text = "Tín hiệu thủ kho"
        Me.WarehouseFlag.Width = 0
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
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Empty
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
        Me.MaterialQuantity.Width = 91
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
        Me.MaterialUnit.Width = 74
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
        'frmChef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 705)
        Me.Controls.Add(Me.lblMaterialQuantity)
        Me.Controls.Add(Me.ltbException)
        Me.Controls.Add(Me.dgvMaterialList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalQuantity)
        Me.Controls.Add(Me.ltbMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ltvCantServeList)
        Me.Controls.Add(Me.ltvOrderList)
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
    Friend WithEvents ltvOrderList As System.Windows.Forms.ListView
    Friend WithEvents Index As System.Windows.Forms.ColumnHeader
    Friend WithEvents OrderDishName As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeOrder As System.Windows.Forms.ColumnHeader
    Friend WithEvents OrderQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltvCantServeList As System.Windows.Forms.ListView
    Friend WithEvents CantServeDishName As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantServeQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WaitorFlag As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltbMessage As System.Windows.Forms.ListBox
    Friend WithEvents txtTotalQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvMaterialList As System.Windows.Forms.DataGridView
    Friend WithEvents DishID As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantServeDishID As System.Windows.Forms.ColumnHeader
    Friend WithEvents WarehouseFlag As System.Windows.Forms.ColumnHeader
    Friend WithEvents TransID As System.Windows.Forms.ColumnHeader
    Friend WithEvents OrderNote As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltbException As System.Windows.Forms.ListBox
    Friend WithEvents CantServeTimeOrder As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantServeTransID As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantServeNote As System.Windows.Forms.ColumnHeader
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
End Class
