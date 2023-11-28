<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteReparacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteReparacion))
        Me.ReparacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.DetalleReparacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReparacionesTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ReparacionesTableAdapter()
        Me.DetalleReparacionTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.DetalleReparacionTableAdapter()
        CType(Me.ReparacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleReparacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReparacionesBindingSource
        '
        Me.ReparacionesBindingSource.DataMember = "Reparaciones"
        Me.ReparacionesBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleReparacionBindingSource
        '
        Me.DetalleReparacionBindingSource.DataMember = "DetalleReparacion"
        Me.DetalleReparacionBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Reparaciones"
        ReportDataSource1.Value = Me.ReparacionesBindingSource
        ReportDataSource2.Name = "DetalleReparacion"
        ReportDataSource2.Value = Me.DetalleReparacionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProyectFinalVB.Reparaciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-3, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(948, 686)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReparacionesTableAdapter
        '
        Me.ReparacionesTableAdapter.ClearBeforeFill = True
        '
        'DetalleReparacionTableAdapter
        '
        Me.DetalleReparacionTableAdapter.ClearBeforeFill = True
        '
        'ReporteReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 647)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReporteReparacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteReparacion"
        CType(Me.ReparacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleReparacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReparacionesBindingSource As BindingSource
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents DetalleReparacionBindingSource As BindingSource
    Friend WithEvents ReparacionesTableAdapter As ProyectoFinalDataSetTableAdapters.ReparacionesTableAdapter
    Friend WithEvents DetalleReparacionTableAdapter As ProyectoFinalDataSetTableAdapters.DetalleReparacionTableAdapter
End Class
