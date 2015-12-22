<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NhanVien
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
        Me.colNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFood = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaChuyen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.lstMenu = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMaMon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLamMon = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.picTable09 = New System.Windows.Forms.PictureBox()
        Me.picTable08 = New System.Windows.Forms.PictureBox()
        Me.picTable07 = New System.Windows.Forms.PictureBox()
        Me.picTable06 = New System.Windows.Forms.PictureBox()
        Me.picTable05 = New System.Windows.Forms.PictureBox()
        Me.picTable04 = New System.Windows.Forms.PictureBox()
        Me.picTable03 = New System.Windows.Forms.PictureBox()
        Me.picTable02 = New System.Windows.Forms.PictureBox()
        Me.picTable01 = New System.Windows.Forms.PictureBox()
        Me.picBorder = New System.Windows.Forms.PictureBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lstNotAvailable = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateTable = New System.Windows.Forms.Button()
        Me.nudGuestCount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable08, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGuestCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumber, Me.colFood, Me.colQuantity, Me.colNote, Me.colStatus, Me.MaChuyen, Me.colMa})
        Me.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvList.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvList.Location = New System.Drawing.Point(708, 68)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(424, 540)
        Me.dgvList.TabIndex = 19
        '
        'colNumber
        '
        Me.colNumber.HeaderText = "STT"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Width = 20
        '
        'colFood
        '
        Me.colFood.HeaderText = "Tên Món"
        Me.colFood.Name = "colFood"
        Me.colFood.Width = 125
        '
        'colQuantity
        '
        Me.colQuantity.HeaderText = "SL"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colQuantity.Width = 30
        '
        'colNote
        '
        Me.colNote.HeaderText = "Ghi Chú"
        Me.colNote.Name = "colNote"
        Me.colNote.Width = 125
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Tình Trạng"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 80
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
        'lblTittle
        '
        Me.lblTittle.Font = New System.Drawing.Font("Roboto Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTittle.Location = New System.Drawing.Point(708, 9)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(642, 56)
        Me.lblTittle.TabIndex = 21
        Me.lblTittle.Text = "DANH SÁCH MÓN ĂN "
        Me.lblTittle.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.btnLamMon.Location = New System.Drawing.Point(870, 612)
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
        Me.btnPay.Location = New System.Drawing.Point(1032, 612)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(156, 90)
        Me.btnPay.TabIndex = 25
        Me.btnPay.Text = "THANH TOÁN"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'picTable09
        '
        Me.picTable09.BackColor = System.Drawing.SystemColors.Window
        Me.picTable09.Image = Global.Waitor.My.Resources.Resources.table9
        Me.picTable09.ImageLocation = ""
        Me.picTable09.Location = New System.Drawing.Point(510, 486)
        Me.picTable09.Name = "picTable09"
        Me.picTable09.Size = New System.Drawing.Size(156, 156)
        Me.picTable09.TabIndex = 9
        Me.picTable09.TabStop = False
        '
        'picTable08
        '
        Me.picTable08.BackColor = System.Drawing.SystemColors.Window
        Me.picTable08.Image = Global.Waitor.My.Resources.Resources.table8
        Me.picTable08.ImageLocation = ""
        Me.picTable08.Location = New System.Drawing.Point(276, 486)
        Me.picTable08.Name = "picTable08"
        Me.picTable08.Size = New System.Drawing.Size(156, 156)
        Me.picTable08.TabIndex = 8
        Me.picTable08.TabStop = False
        '
        'picTable07
        '
        Me.picTable07.BackColor = System.Drawing.SystemColors.Window
        Me.picTable07.Image = Global.Waitor.My.Resources.Resources.table7
        Me.picTable07.ImageLocation = ""
        Me.picTable07.Location = New System.Drawing.Point(38, 486)
        Me.picTable07.Name = "picTable07"
        Me.picTable07.Size = New System.Drawing.Size(156, 156)
        Me.picTable07.TabIndex = 7
        Me.picTable07.TabStop = False
        '
        'picTable06
        '
        Me.picTable06.BackColor = System.Drawing.SystemColors.Window
        Me.picTable06.Image = Global.Waitor.My.Resources.Resources.table6
        Me.picTable06.ImageLocation = ""
        Me.picTable06.Location = New System.Drawing.Point(510, 270)
        Me.picTable06.Name = "picTable06"
        Me.picTable06.Size = New System.Drawing.Size(156, 156)
        Me.picTable06.TabIndex = 6
        Me.picTable06.TabStop = False
        '
        'picTable05
        '
        Me.picTable05.BackColor = System.Drawing.SystemColors.Window
        Me.picTable05.Image = Global.Waitor.My.Resources.Resources.table5
        Me.picTable05.ImageLocation = ""
        Me.picTable05.Location = New System.Drawing.Point(276, 270)
        Me.picTable05.Name = "picTable05"
        Me.picTable05.Size = New System.Drawing.Size(156, 156)
        Me.picTable05.TabIndex = 5
        Me.picTable05.TabStop = False
        '
        'picTable04
        '
        Me.picTable04.BackColor = System.Drawing.SystemColors.Window
        Me.picTable04.Image = Global.Waitor.My.Resources.Resources.table4
        Me.picTable04.ImageLocation = ""
        Me.picTable04.Location = New System.Drawing.Point(38, 270)
        Me.picTable04.Name = "picTable04"
        Me.picTable04.Size = New System.Drawing.Size(156, 156)
        Me.picTable04.TabIndex = 4
        Me.picTable04.TabStop = False
        '
        'picTable03
        '
        Me.picTable03.BackColor = System.Drawing.SystemColors.Window
        Me.picTable03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picTable03.Image = Global.Waitor.My.Resources.Resources.table3
        Me.picTable03.ImageLocation = ""
        Me.picTable03.Location = New System.Drawing.Point(510, 40)
        Me.picTable03.Name = "picTable03"
        Me.picTable03.Size = New System.Drawing.Size(156, 156)
        Me.picTable03.TabIndex = 3
        Me.picTable03.TabStop = False
        '
        'picTable02
        '
        Me.picTable02.BackColor = System.Drawing.SystemColors.Window
        Me.picTable02.Image = Global.Waitor.My.Resources.Resources.table2
        Me.picTable02.ImageLocation = ""
        Me.picTable02.Location = New System.Drawing.Point(276, 40)
        Me.picTable02.Name = "picTable02"
        Me.picTable02.Size = New System.Drawing.Size(156, 156)
        Me.picTable02.TabIndex = 2
        Me.picTable02.TabStop = False
        '
        'picTable01
        '
        Me.picTable01.BackColor = System.Drawing.SystemColors.Window
        Me.picTable01.Image = Global.Waitor.My.Resources.Resources.table1
        Me.picTable01.ImageLocation = ""
        Me.picTable01.Location = New System.Drawing.Point(38, 40)
        Me.picTable01.Name = "picTable01"
        Me.picTable01.Size = New System.Drawing.Size(156, 156)
        Me.picTable01.TabIndex = 1
        Me.picTable01.TabStop = False
        '
        'picBorder
        '
        Me.picBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBorder.Image = Global.Waitor.My.Resources.Resources.border
        Me.picBorder.ImageLocation = ""
        Me.picBorder.Location = New System.Drawing.Point(8, 7)
        Me.picBorder.Name = "picBorder"
        Me.picBorder.Size = New System.Drawing.Size(704, 706)
        Me.picBorder.TabIndex = 0
        Me.picBorder.TabStop = False
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
        Me.btnDelete.Location = New System.Drawing.Point(708, 611)
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
        'nudGuestCount
        '
        Me.nudGuestCount.Location = New System.Drawing.Point(1274, 586)
        Me.nudGuestCount.Maximum = New Decimal(New Integer() {80000, 0, 0, 0})
        Me.nudGuestCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGuestCount.Name = "nudGuestCount"
        Me.nudGuestCount.Size = New System.Drawing.Size(73, 20)
        Me.nudGuestCount.TabIndex = 31
        Me.nudGuestCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        'NhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1350, 706)
        Me.Controls.Add(Me.nudGuestCount)
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
        Me.Controls.Add(Me.picTable09)
        Me.Controls.Add(Me.picTable08)
        Me.Controls.Add(Me.picTable07)
        Me.Controls.Add(Me.picTable06)
        Me.Controls.Add(Me.picTable05)
        Me.Controls.Add(Me.picTable04)
        Me.Controls.Add(Me.picTable03)
        Me.Controls.Add(Me.picTable02)
        Me.Controls.Add(Me.picTable01)
        Me.Controls.Add(Me.picBorder)
        Me.Controls.Add(Me.Label2)
        Me.Name = "NhanVien"
        Me.Text = "Nhan Vien"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable08, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGuestCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBorder As PictureBox
    Friend WithEvents picTable01 As PictureBox
    Friend WithEvents picTable02 As PictureBox
    Friend WithEvents picTable03 As PictureBox
    Friend WithEvents picTable06 As PictureBox
    Friend WithEvents picTable05 As PictureBox
    Friend WithEvents picTable04 As PictureBox
    Friend WithEvents picTable09 As PictureBox
    Friend WithEvents picTable08 As PictureBox
    Friend WithEvents picTable07 As PictureBox
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
    Friend WithEvents nudGuestCount As NumericUpDown
    Friend WithEvents colNumber As DataGridViewTextBoxColumn
    Friend WithEvents colFood As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colNote As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents MaChuyen As DataGridViewTextBoxColumn
    Friend WithEvents colMa As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
