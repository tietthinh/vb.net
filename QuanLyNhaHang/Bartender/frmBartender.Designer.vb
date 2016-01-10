<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBartender
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultIncrease = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDouble = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvOrderList = New System.Windows.Forms.DataGridView()
        Me.Ordered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTransID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMaterialQuantity = New System.Windows.Forms.Label()
        Me.ltbException = New System.Windows.Forms.ListBox()
        Me.dgvCantServeList = New System.Windows.Forms.DataGridView()
        Me.CantServeDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantServeDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantServeQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitorFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarehouseFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Increase = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Decrease = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CookListDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CookListDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMaterialList = New System.Windows.Forms.DataGridView()
        Me.DetailDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalQuantity = New System.Windows.Forms.TextBox()
        Me.ltbMessage = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CookListQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSendWaitor = New System.Windows.Forms.Button()
        Me.btnSendWarehouse = New System.Windows.Forms.Button()
        Me.btnCook = New System.Windows.Forms.Button()
        Me.dgvCookList = New System.Windows.Forms.DataGridView()
        Me.CookListDone = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCantServeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMaterialList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCookList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialQuantity
        '
        Me.MaterialQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaterialQuantity.DataPropertyName = "SoLuong"
        DataGridViewCellStyle17.Format = "#,###0.#######"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.MaterialQuantity.DefaultCellStyle = DataGridViewCellStyle17
        Me.MaterialQuantity.HeaderText = "Số lượng"
        Me.MaterialQuantity.Name = "MaterialQuantity"
        Me.MaterialQuantity.ReadOnly = True
        Me.MaterialQuantity.Width = 84
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
        'dgvOrderList
        '
        Me.dgvOrderList.AllowUserToAddRows = False
        Me.dgvOrderList.AllowUserToDeleteRows = False
        Me.dgvOrderList.AllowUserToResizeColumns = False
        Me.dgvOrderList.AllowUserToResizeRows = False
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvOrderList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ordered, Me.OrderTransID, Me.OrderDishID, Me.OrderDishName, Me.TimeOrder, Me.OrderQuantity, Me.OrderNote})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderList.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvOrderList.Location = New System.Drawing.Point(12, 34)
        Me.dgvOrderList.Name = "dgvOrderList"
        Me.dgvOrderList.ReadOnly = True
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderList.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvOrderList.RowHeadersVisible = False
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvOrderList.RowsDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderList.Size = New System.Drawing.Size(502, 469)
        Me.dgvOrderList.TabIndex = 61
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
        'lblMaterialQuantity
        '
        Me.lblMaterialQuantity.AutoSize = True
        Me.lblMaterialQuantity.Location = New System.Drawing.Point(835, 15)
        Me.lblMaterialQuantity.Name = "lblMaterialQuantity"
        Me.lblMaterialQuantity.Size = New System.Drawing.Size(93, 13)
        Me.lblMaterialQuantity.TabIndex = 60
        Me.lblMaterialQuantity.Text = "Material's Quantity"
        Me.lblMaterialQuantity.Visible = False
        '
        'ltbException
        '
        Me.ltbException.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbException.FormattingEnabled = True
        Me.ltbException.ItemHeight = 20
        Me.ltbException.Location = New System.Drawing.Point(12, 535)
        Me.ltbException.Name = "ltbException"
        Me.ltbException.Size = New System.Drawing.Size(502, 164)
        Me.ltbException.TabIndex = 59
        '
        'dgvCantServeList
        '
        Me.dgvCantServeList.AllowUserToAddRows = False
        Me.dgvCantServeList.AllowUserToDeleteRows = False
        Me.dgvCantServeList.AllowUserToResizeColumns = False
        Me.dgvCantServeList.AllowUserToResizeRows = False
        Me.dgvCantServeList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCantServeList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgvCantServeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCantServeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CantServeDishID, Me.CantServeDishName, Me.CantServeQuantity, Me.WaitorFlag, Me.WarehouseFlag})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCantServeList.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvCantServeList.Location = New System.Drawing.Point(520, 555)
        Me.dgvCantServeList.Name = "dgvCantServeList"
        Me.dgvCantServeList.ReadOnly = True
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCantServeList.RowHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvCantServeList.RowHeadersVisible = False
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCantServeList.RowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvCantServeList.Size = New System.Drawing.Size(460, 144)
        Me.dgvCantServeList.TabIndex = 62
        '
        'CantServeDishID
        '
        Me.CantServeDishID.DataPropertyName = "MaMon"
        Me.CantServeDishID.HeaderText = "Mã món"
        Me.CantServeDishID.Name = "CantServeDishID"
        Me.CantServeDishID.ReadOnly = True
        Me.CantServeDishID.Visible = False
        '
        'CantServeDishName
        '
        Me.CantServeDishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantServeDishName.DataPropertyName = "TenMon"
        Me.CantServeDishName.HeaderText = "Tên món"
        Me.CantServeDishName.Name = "CantServeDishName"
        Me.CantServeDishName.ReadOnly = True
        '
        'CantServeQuantity
        '
        Me.CantServeQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CantServeQuantity.DataPropertyName = "SoLuong"
        Me.CantServeQuantity.HeaderText = "Số lượng"
        Me.CantServeQuantity.Name = "CantServeQuantity"
        Me.CantServeQuantity.ReadOnly = True
        Me.CantServeQuantity.Width = 91
        '
        'WaitorFlag
        '
        Me.WaitorFlag.HeaderText = "Tín hiệu phục vụ"
        Me.WaitorFlag.Name = "WaitorFlag"
        Me.WaitorFlag.ReadOnly = True
        Me.WaitorFlag.Visible = False
        '
        'WarehouseFlag
        '
        Me.WarehouseFlag.HeaderText = "Tín hiệu kho"
        Me.WarehouseFlag.Name = "WarehouseFlag"
        Me.WarehouseFlag.ReadOnly = True
        Me.WarehouseFlag.Visible = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 506)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "DANH SÁCH GHI CHÚ"
        '
        'CookListDishID
        '
        Me.CookListDishID.DataPropertyName = "MaMon"
        Me.CookListDishID.HeaderText = "Mã món"
        Me.CookListDishID.Name = "CookListDishID"
        Me.CookListDishID.ReadOnly = True
        Me.CookListDishID.Visible = False
        Me.CookListDishID.Width = 67
        '
        'CookListDishName
        '
        Me.CookListDishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CookListDishName.DataPropertyName = "TenMon"
        Me.CookListDishName.HeaderText = "Tên món"
        Me.CookListDishName.Name = "CookListDishName"
        Me.CookListDishName.ReadOnly = True
        '
        'dgvMaterialList
        '
        Me.dgvMaterialList.AllowUserToAddRows = False
        Me.dgvMaterialList.AllowUserToDeleteRows = False
        Me.dgvMaterialList.AllowUserToResizeColumns = False
        Me.dgvMaterialList.AllowUserToResizeRows = False
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMaterialList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvMaterialList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMaterialList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMaterialList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMaterialList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterialList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailDishID, Me.MaterialID, Me.MaterialName, Me.Decrease, Me.MaterialQuantity, Me.Increase, Me.MaterialUnit, Me.DefaultIncrease, Me.IsDouble})
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMaterialList.DefaultCellStyle = DataGridViewCellStyle29
        Me.dgvMaterialList.Location = New System.Drawing.Point(520, 34)
        Me.dgvMaterialList.Name = "dgvMaterialList"
        Me.dgvMaterialList.ReadOnly = True
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMaterialList.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvMaterialList.RowHeadersVisible = False
        Me.dgvMaterialList.Size = New System.Drawing.Size(406, 406)
        Me.dgvMaterialList.TabIndex = 58
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(332, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 25)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Số lượng món"
        '
        'txtTotalQuantity
        '
        Me.txtTotalQuantity.Enabled = False
        Me.txtTotalQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQuantity.Location = New System.Drawing.Point(462, 7)
        Me.txtTotalQuantity.Name = "txtTotalQuantity"
        Me.txtTotalQuantity.Size = New System.Drawing.Size(52, 26)
        Me.txtTotalQuantity.TabIndex = 56
        '
        'ltbMessage
        '
        Me.ltbMessage.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbMessage.FormattingEnabled = True
        Me.ltbMessage.ItemHeight = 20
        Me.ltbMessage.Location = New System.Drawing.Point(986, 555)
        Me.ltbMessage.Name = "ltbMessage"
        Me.ltbMessage.Size = New System.Drawing.Size(356, 144)
        Me.ltbMessage.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(605, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 25)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "DANH SÁCH NGUYÊN LIỆU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1007, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 25)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "DANH SÁCH MÓN ĐANG LÀM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(586, 527)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 25)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "DANH SÁCH KHÔNG LÀM ĐƯỢC"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "DANH SÁCH ĐẶT MÓN"
        '
        'btnSendWaitor
        '
        Me.btnSendWaitor.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendWaitor.Location = New System.Drawing.Point(763, 446)
        Me.btnSendWaitor.Name = "btnSendWaitor"
        Me.btnSendWaitor.Size = New System.Drawing.Size(147, 35)
        Me.btnSendWaitor.TabIndex = 49
        Me.btnSendWaitor.Text = "Gửi nhân viên"
        Me.btnSendWaitor.UseVisualStyleBackColor = True
        '
        'btnSendWarehouse
        '
        Me.btnSendWarehouse.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendWarehouse.Location = New System.Drawing.Point(763, 487)
        Me.btnSendWarehouse.Name = "btnSendWarehouse"
        Me.btnSendWarehouse.Size = New System.Drawing.Size(147, 35)
        Me.btnSendWarehouse.TabIndex = 48
        Me.btnSendWarehouse.Text = "Gửi thủ kho"
        Me.btnSendWarehouse.UseVisualStyleBackColor = True
        '
        'btnCook
        '
        Me.btnCook.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCook.Location = New System.Drawing.Point(543, 446)
        Me.btnCook.Name = "btnCook"
        Me.btnCook.Size = New System.Drawing.Size(201, 76)
        Me.btnCook.TabIndex = 47
        Me.btnCook.Text = "Làm"
        Me.btnCook.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCookList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.dgvCookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCookList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CookListDishID, Me.CookListDishName, Me.CookListQuantity, Me.CookListDone})
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCookList.DefaultCellStyle = DataGridViewCellStyle32
        Me.dgvCookList.Location = New System.Drawing.Point(932, 34)
        Me.dgvCookList.Name = "dgvCookList"
        Me.dgvCookList.ReadOnly = True
        Me.dgvCookList.RowHeadersVisible = False
        Me.dgvCookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCookList.Size = New System.Drawing.Size(410, 515)
        Me.dgvCookList.TabIndex = 46
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
        'frmBartender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 705)
        Me.Controls.Add(Me.dgvOrderList)
        Me.Controls.Add(Me.lblMaterialQuantity)
        Me.Controls.Add(Me.ltbException)
        Me.Controls.Add(Me.dgvCantServeList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvMaterialList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalQuantity)
        Me.Controls.Add(Me.ltbMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSendWaitor)
        Me.Controls.Add(Me.btnSendWarehouse)
        Me.Controls.Add(Me.btnCook)
        Me.Controls.Add(Me.dgvCookList)
        Me.Name = "frmBartender"
        Me.Text = "Pha chế"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCantServeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMaterialList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCookList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents lblMaterialQuantity As System.Windows.Forms.Label
    Friend WithEvents ltbException As System.Windows.Forms.ListBox
    Friend WithEvents dgvCantServeList As System.Windows.Forms.DataGridView
    Friend WithEvents CantServeDishID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantServeDishName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantServeQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitorFlag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WarehouseFlag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Increase As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Decrease As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CookListDishID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CookListDishName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMaterialList As System.Windows.Forms.DataGridView
    Friend WithEvents DetailDishID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalQuantity As System.Windows.Forms.TextBox
    Friend WithEvents ltbMessage As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CookListQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSendWaitor As System.Windows.Forms.Button
    Friend WithEvents btnSendWarehouse As System.Windows.Forms.Button
    Friend WithEvents btnCook As System.Windows.Forms.Button
    Friend WithEvents dgvCookList As System.Windows.Forms.DataGridView
    Friend WithEvents CookListDone As System.Windows.Forms.DataGridViewButtonColumn

End Class
