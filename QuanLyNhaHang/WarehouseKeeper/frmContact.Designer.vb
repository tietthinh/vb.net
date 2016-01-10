<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContact
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
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.txtMail_0 = New System.Windows.Forms.TextBox()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(56, 86)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(127, 35)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Xong"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(36, 9)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(169, 25)
        Me.lblSupplier.TabIndex = 0
        Me.lblSupplier.Text = "Tên nhà cung cấp"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlContainer
        '
        Me.pnlContainer.AutoSize = True
        Me.pnlContainer.Controls.Add(Me.txtMail_0)
        Me.pnlContainer.Location = New System.Drawing.Point(12, 45)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(221, 31)
        Me.pnlContainer.TabIndex = 3
        '
        'txtMail_0
        '
        Me.txtMail_0.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail_0.Location = New System.Drawing.Point(0, 1)
        Me.txtMail_0.Name = "txtMail_0"
        Me.txtMail_0.Size = New System.Drawing.Size(200, 27)
        Me.txtMail_0.TabIndex = 0
        '
        'frmContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(238, 133)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblSupplier)
        Me.Name = "frmContact"
        Me.Text = "Liên lạc"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents txtMail_0 As System.Windows.Forms.TextBox
End Class
