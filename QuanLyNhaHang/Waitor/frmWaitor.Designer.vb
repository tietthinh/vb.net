<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWaitor
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
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.lstMenu = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMaMon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLamMon = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lstNotAvailable = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateTable = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstTable = New System.Windows.Forms.ListView()
        Me.colDanhSachBan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nudGuestCount = New System.Windows.Forms.NumericUpDown()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.colNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFood = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaChuyen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGuestCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeColumns = False
        Me.dgvList.AllowUserToResizeRows = False
        Me.dgvList.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvList.ColumnHeadersHeight = 40
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumber, Me.colFood, Me.colQuantity, Me.colNote, Me.colStatus, Me.MaChuyen, Me.colMa})
        Me.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvList.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvList.Location = New System.Drawing.Point(687, 68)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(445, 540)
        Me.dgvList.TabIndex = 19
        '
        'lblTittle
        '
        Me.lblTittle.Font = New System.Drawing.Font("Roboto Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTittle.Location = New System.Drawing.Point(687, 9)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(445, 56)
        Me.lblTittle.TabIndex = 21
        Me.lblTittle.Text = "DANH SÁCH MÓN ĂN "
        Me.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstMenu
        '
        Me.lstMenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colMaMon})
        Me.lstMenu.Enabled = False
        Me.lstMenu.FullRowSelect = True
        Me.lstMenu.Location = New System.Drawing.Point(1138, 253)
        Me.lstMenu.Name = "lstMenu"
        Me.lstMenu.Size = New System.Drawing.Size(212, 327)
        Me.lstMenu.TabIndex = 23
        Me.lstMenu.TileSize = New System.Drawing.Size(168, 40)
        Me.lstMenu.UseCompatibleStateImageBehavior = False
        '
        'colName
        '
        Me.colName.Text = "Tên Món"
        Me.colName.Width = 103
        '
        'colMaMon
        '
        Me.colMaMon.Text = "MaMon"
        Me.colMaMon.Width = 71
        '
        'btnLamMon
        '
        Me.btnLamMon.BackColor = System.Drawing.Color.Orange
        Me.btnLamMon.Font = New System.Drawing.Font("Roboto Condensed", 21.75!, System.Drawing.FontStyle.Bold)
        Me.btnLamMon.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLamMon.Location = New System.Drawing.Point(856, 612)
        Me.btnLamMon.Name = "btnLamMon"
        Me.btnLamMon.Size = New System.Drawing.Size(156, 90)
        Me.btnLamMon.TabIndex = 24
        Me.btnLamMon.Text = "LÀM MÓN"
        Me.btnLamMon.UseVisualStyleBackColor = False
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Orange
        Me.btnPay.Font = New System.Drawing.Font("Roboto Condensed", 21.75!, System.Drawing.FontStyle.Bold)
        Me.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPay.Location = New System.Drawing.Point(1026, 612)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(156, 90)
        Me.btnPay.TabIndex = 25
        Me.btnPay.Text = "THANH TOÁN"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'lblMenu
        '
        Me.lblMenu.BackColor = System.Drawing.Color.Blue
        Me.lblMenu.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu.ForeColor = System.Drawing.SystemColors.Window
        Me.lblMenu.Location = New System.Drawing.Point(1138, 229)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(212, 21)
        Me.lblMenu.TabIndex = 26
        Me.lblMenu.Text = "THỰC ĐƠN"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Orange
        Me.btnDelete.Font = New System.Drawing.Font("Roboto Condensed", 21.75!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(687, 612)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(156, 90)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "XÓA MÓN"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lstNotAvailable
        '
        Me.lstNotAvailable.Location = New System.Drawing.Point(1138, 92)
        Me.lstNotAvailable.MultiSelect = False
        Me.lstNotAvailable.Name = "lstNotAvailable"
        Me.lstNotAvailable.Size = New System.Drawing.Size(212, 134)
        Me.lstNotAvailable.TabIndex = 28
        Me.lstNotAvailable.UseCompatibleStateImageBehavior = False
        Me.lstNotAvailable.View = System.Windows.Forms.View.List
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1138, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "MÓN CHƯA LÀM ĐƯỢC"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdateTable
        '
        Me.btnUpdateTable.BackColor = System.Drawing.Color.Orange
        Me.btnUpdateTable.Font = New System.Drawing.Font("Roboto Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdateTable.Location = New System.Drawing.Point(1194, 612)
        Me.btnUpdateTable.Name = "btnUpdateTable"
        Me.btnUpdateTable.Size = New System.Drawing.Size(156, 90)
        Me.btnUpdateTable.TabIndex = 30
        Me.btnUpdateTable.Text = "CẬP NHẬT BÀN"
        Me.btnUpdateTable.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(1138, 583)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "SỐ LƯỢNG KHÁCH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstTable
        '
        Me.lstTable.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lstTable.BackColor = System.Drawing.Color.White
        Me.lstTable.BackgroundImageTiled = True
        Me.lstTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDanhSachBan})
        Me.lstTable.Font = New System.Drawing.Font("Roboto Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTable.Location = New System.Drawing.Point(12, 12)
        Me.lstTable.Margin = New System.Windows.Forms.Padding(13)
        Me.lstTable.MultiSelect = False
        Me.lstTable.Name = "lstTable"
        Me.lstTable.Size = New System.Drawing.Size(659, 680)
        Me.lstTable.TabIndex = 33
        Me.lstTable.TileSize = New System.Drawing.Size(200, 200)
        Me.lstTable.UseCompatibleStateImageBehavior = False
        '
        'nudGuestCount
        '
        Me.nudGuestCount.Location = New System.Drawing.Point(1284, 586)
        Me.nudGuestCount.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudGuestCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGuestCount.Name = "nudGuestCount"
        Me.nudGuestCount.Size = New System.Drawing.Size(54, 20)
        Me.nudGuestCount.TabIndex = 34
        Me.nudGuestCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1254, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(84, 56)
        Me.btnLogout.TabIndex = 35
        Me.btnLogout.Text = "Đăng Xuất"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'colNumber
        '
        Me.colNumber.HeaderText = "STT"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Width = 35
        '
        'colFood
        '
        Me.colFood.HeaderText = "Tên Món"
        Me.colFood.Name = "colFood"
        Me.colFood.Width = 140
        '
        'colQuantity
        '
        Me.colQuantity.HeaderText = "SL"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colQuantity.Width = 35
        '
        'colNote
        '
        Me.colNote.HeaderText = "Ghi Chú"
        Me.colNote.Name = "colNote"
        Me.colNote.Width = 145
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Tình Trạng"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 85
        '
        'MaChuyen
        '
        Me.MaChuyen.HeaderText = "Mã Chuyển"
        Me.MaChuyen.Name = "MaChuyen"
        Me.MaChuyen.Visible = False
        '
        'colMa
        '
        Me.colMa.HeaderText = "Mã Món"
        Me.colMa.Name = "colMa"
        Me.colMa.Visible = False
        '
        'Waitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1350, 706)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.nudGuestCount)
        Me.Controls.Add(Me.lstTable)
        Me.Controls.Add(Me.btnUpdateTable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNotAvailable)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnLamMon)
        Me.Controls.Add(Me.lstMenu)
        Me.Controls.Add(Me.lblTittle)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Waitor"
        Me.Text = "Nhan Vien"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGuestCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents lblTittle As Label
    Friend WithEvents lstMenu As ListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colMaMon As ColumnHeader
    Friend WithEvents btnLamMon As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lstNotAvailable As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdateTable As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstTable As ListView
    Friend WithEvents nudGuestCount As NumericUpDown
    Friend WithEvents colDanhSachBan As ColumnHeader
    Friend WithEvents btnLogout As Button
    Friend WithEvents colNumber As DataGridViewTextBoxColumn
    Friend WithEvents colFood As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colNote As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents MaChuyen As DataGridViewTextBoxColumn
    Friend WithEvents colMa As DataGridViewTextBoxColumn
End Class
