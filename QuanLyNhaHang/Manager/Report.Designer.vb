﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptThongKe
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds_ThongKe = New Manager.ds_ThongKe()
        Me.ThongKeMonHoanThanh = New Manager.ThongKeMonHoanThanh()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_ThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThongKeMonHoanThanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Manager.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(668, 515)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.ds_ThongKe
        '
        'ds_ThongKe
        '
        Me.ds_ThongKe.DataSetName = "ds_ThongKe"
        Me.ds_ThongKe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ThongKeMonHoanThanh
        '
        Me.ThongKeMonHoanThanh.DataSetName = "ThongKeMonHoanThanh"
        Me.ThongKeMonHoanThanh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptThongKe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 515)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptThongKe"
        Me.Text = "Thống Kê"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_ThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThongKeMonHoanThanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ds_ThongKe As Manager.ds_ThongKe
    Friend WithEvents ThongKeMonHoanThanh As Manager.ThongKeMonHoanThanh
End Class
