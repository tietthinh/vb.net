﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCookList = New System.Windows.Forms.DataGridView()
        Me.CookListDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CookListAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.OrderDishName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimeOrder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OrderAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ltvExceptionList = New System.Windows.Forms.ListView()
        Me.ExceptionDishName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Exception = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExceptionAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ltvCantServeList = New System.Windows.Forms.ListView()
        Me.CantServeDishName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantServeAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Flag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ltbMessage = New System.Windows.Forms.ListBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvMaterialList = New System.Windows.Forms.DataGridView()
        Me.MaterialName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Decrease = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MaterialAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Increase = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MaterialUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCookList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCookList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CookListDishName, Me.CookListAmount, Me.CookListDone})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCookList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCookList.Location = New System.Drawing.Point(932, 37)
        Me.dgvCookList.Name = "dgvCookList"
        Me.dgvCookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCookList.Size = New System.Drawing.Size(410, 515)
        Me.dgvCookList.TabIndex = 2
        '
        'CookListDishName
        '
        Me.CookListDishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CookListDishName.HeaderText = "Tên món"
        Me.CookListDishName.Name = "CookListDishName"
        '
        'CookListAmount
        '
        Me.CookListAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CookListAmount.HeaderText = "Số lượng"
        Me.CookListAmount.Name = "CookListAmount"
        Me.CookListAmount.Width = 91
        '
        'CookListDone
        '
        Me.CookListDone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CookListDone.HeaderText = ""
        Me.CookListDone.Name = "CookListDone"
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
        Me.Label2.Location = New System.Drawing.Point(148, 487)
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
        Me.ltvOrderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Index, Me.OrderDishName, Me.TimeOrder, Me.OrderAmount})
        Me.ltvOrderList.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltvOrderList.FullRowSelect = True
        Me.ltvOrderList.Location = New System.Drawing.Point(12, 37)
        Me.ltvOrderList.Name = "ltvOrderList"
        Me.ltvOrderList.Size = New System.Drawing.Size(502, 444)
        Me.ltvOrderList.TabIndex = 33
        Me.ltvOrderList.UseCompatibleStateImageBehavior = False
        Me.ltvOrderList.View = System.Windows.Forms.View.Details
        '
        'Index
        '
        Me.Index.Text = "STT"
        '
        'OrderDishName
        '
        Me.OrderDishName.Text = "Tên món"
        Me.OrderDishName.Width = 134
        '
        'TimeOrder
        '
        Me.TimeOrder.Text = "Giờ đặt"
        Me.TimeOrder.Width = 140
        '
        'OrderAmount
        '
        Me.OrderAmount.Text = "Số lượng"
        Me.OrderAmount.Width = 140
        '
        'ltvExceptionList
        '
        Me.ltvExceptionList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ExceptionDishName, Me.Exception, Me.ExceptionAmount})
        Me.ltvExceptionList.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltvExceptionList.FullRowSelect = True
        Me.ltvExceptionList.Location = New System.Drawing.Point(12, 518)
        Me.ltvExceptionList.Name = "ltvExceptionList"
        Me.ltvExceptionList.Size = New System.Drawing.Size(502, 184)
        Me.ltvExceptionList.TabIndex = 35
        Me.ltvExceptionList.UseCompatibleStateImageBehavior = False
        Me.ltvExceptionList.View = System.Windows.Forms.View.Details
        '
        'ExceptionDishName
        '
        Me.ExceptionDishName.Text = "Tên món"
        Me.ExceptionDishName.Width = 138
        '
        'Exception
        '
        Me.Exception.Text = "Ghi chú"
        Me.Exception.Width = 128
        '
        'ExceptionAmount
        '
        Me.ExceptionAmount.Text = "Số lượng"
        Me.ExceptionAmount.Width = 114
        '
        'ltvCantServeList
        '
        Me.ltvCantServeList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CantServeDishName, Me.CantServeAmount, Me.Flag})
        Me.ltvCantServeList.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltvCantServeList.FullRowSelect = True
        Me.ltvCantServeList.Location = New System.Drawing.Point(520, 558)
        Me.ltvCantServeList.Name = "ltvCantServeList"
        Me.ltvCantServeList.Size = New System.Drawing.Size(460, 144)
        Me.ltvCantServeList.TabIndex = 36
        Me.ltvCantServeList.UseCompatibleStateImageBehavior = False
        Me.ltvCantServeList.View = System.Windows.Forms.View.Details
        '
        'CantServeDishName
        '
        Me.CantServeDishName.Text = "Tên món"
        Me.CantServeDishName.Width = 172
        '
        'CantServeAmount
        '
        Me.CantServeAmount.Text = "Số lượng"
        Me.CantServeAmount.Width = 184
        '
        'Flag
        '
        Me.Flag.Text = ""
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
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(462, 10)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(52, 26)
        Me.txtTotalAmount.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(302, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Số lượng món"
        '
        'dgvMaterialList
        '
        Me.dgvMaterialList.AllowUserToAddRows = False
        Me.dgvMaterialList.AllowUserToDeleteRows = False
        Me.dgvMaterialList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMaterialList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMaterialList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMaterialList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterialList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialName, Me.Decrease, Me.MaterialAmount, Me.Increase, Me.MaterialUnit})
        Me.dgvMaterialList.Location = New System.Drawing.Point(520, 37)
        Me.dgvMaterialList.Name = "dgvMaterialList"
        Me.dgvMaterialList.ReadOnly = True
        Me.dgvMaterialList.Size = New System.Drawing.Size(406, 406)
        Me.dgvMaterialList.TabIndex = 41
        '
        'MaterialName
        '
        Me.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        'MaterialAmount
        '
        Me.MaterialAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaterialAmount.HeaderText = "Số lượng"
        Me.MaterialAmount.Name = "MaterialAmount"
        Me.MaterialAmount.ReadOnly = True
        Me.MaterialAmount.Width = 84
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
        Me.MaterialUnit.HeaderText = "Đơn vị"
        Me.MaterialUnit.Name = "MaterialUnit"
        Me.MaterialUnit.ReadOnly = True
        Me.MaterialUnit.Width = 59
        '
        'frmChef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 705)
        Me.Controls.Add(Me.dgvMaterialList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.ltbMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ltvCantServeList)
        Me.Controls.Add(Me.ltvExceptionList)
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
    Friend WithEvents OrderAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltvExceptionList As System.Windows.Forms.ListView
    Friend WithEvents ExceptionDishName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Exception As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExceptionAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltvCantServeList As System.Windows.Forms.ListView
    Friend WithEvents CantServeDishName As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantServeAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Flag As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltbMessage As System.Windows.Forms.ListBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvMaterialList As System.Windows.Forms.DataGridView
    Friend WithEvents CookListDishName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CookListAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CookListDone As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MaterialName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Decrease As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MaterialAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Increase As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MaterialUnit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class