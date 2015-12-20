<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Blue
        Me.btnAccept.Font = New System.Drawing.Font("Roboto Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAccept.Location = New System.Drawing.Point(12, 179)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(130, 56)
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "ĐỒNG Ý"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Blue
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Roboto Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(142, 179)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 56)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "THOÁT"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(15, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Số Lượng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(30, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ghi Chú"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(116, 106)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(156, 67)
        Me.txtNote.TabIndex = 4
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(116, 77)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(156, 20)
        Me.nudQuantity.TabIndex = 5
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTitle
        '
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Roboto Black", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Firebrick
        Me.lblTitle.Location = New System.Drawing.Point(18, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(254, 55)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "CHI TIẾT ĐẶT MÓN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 246)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Location = New System.Drawing.Point(700, 300)
        Me.Name = "Add"
        Me.ShowInTaskbar = False
        Me.Text = "Add"
        Me.TopMost = True
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccept As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents lblTitle As Label
End Class
