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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.dtpMaterialList = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMaterialList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(932, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(410, 515)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Tên món"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Số lượng"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 74
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tình trạng"
        Me.Column3.Name = "Column3"
        Me.Column3.Text = "Xong"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(543, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 76)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Làm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(781, 490)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Gửi thủ kho"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(781, 449)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 35)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Gửi nhân viên"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DANH SÁCH ĐẶT MÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "DANH SÁCH GHI CHÚ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(555, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DANH SÁCH KHÔNG LÀM ĐƯỢC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(977, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(313, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DANH SÁCH MÓN ĐANG LÀM"
        '
        'ltvOrderList
        '
        Me.ltvOrderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Index, Me.OrderDishName, Me.TimeOrder, Me.OrderAmount})
        Me.ltvOrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ltvExceptionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ltvCantServeList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(575, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 25)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "DANH SÁCH NGUYÊN LIỆU"
        '
        'ltbMessage
        '
        Me.ltbMessage.FormattingEnabled = True
        Me.ltbMessage.Location = New System.Drawing.Point(986, 568)
        Me.ltbMessage.Name = "ltbMessage"
        Me.ltbMessage.Size = New System.Drawing.Size(356, 134)
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
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(311, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Số lượng món"
        '
        'dtpMaterialList
        '
        Me.dtpMaterialList.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dtpMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtpMaterialList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dtpMaterialList.Location = New System.Drawing.Point(520, 37)
        Me.dtpMaterialList.Name = "dtpMaterialList"
        Me.dtpMaterialList.Size = New System.Drawing.Size(406, 406)
        Me.dtpMaterialList.TabIndex = 41
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nguyên liệu"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Số lượng"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = ""
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Đơn vị"
        Me.Column8.Name = "Column8"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 705)
        Me.Controls.Add(Me.dtpMaterialList)
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
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMaterialList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
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
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ltvCantServeList As System.Windows.Forms.ListView
    Friend WithEvents CantServeDishName As System.Windows.Forms.ColumnHeader
    Friend WithEvents CantServeAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Flag As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltbMessage As System.Windows.Forms.ListBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpMaterialList As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
