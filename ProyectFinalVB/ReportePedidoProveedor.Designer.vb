<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportePedidoProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportePedidoProveedor))
        Me.ProvedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.DetalleProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProvedorTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ProvedorTableAdapter()
        Me.DetalleProveedorTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.DetalleProveedorTableAdapter()
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProvedorBindingSource
        '
        Me.ProvedorBindingSource.DataMember = "Provedor"
        Me.ProvedorBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleProveedorBindingSource
        '
        Me.DetalleProveedorBindingSource.DataMember = "DetalleProveedor"
        Me.DetalleProveedorBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Proveedor"
        ReportDataSource1.Value = Me.ProvedorBindingSource
        ReportDataSource2.Name = "DetalleProveedor"
        ReportDataSource2.Value = Me.DetalleProveedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProyectFinalVB.PedidosProveedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-3, -5)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1091, 653)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProvedorTableAdapter
        '
        Me.ProvedorTableAdapter.ClearBeforeFill = True
        '
        'DetalleProveedorTableAdapter
        '
        Me.DetalleProveedorTableAdapter.ClearBeforeFill = True
        '
        'ReportePedidoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 647)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReportePedidoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteProveedor"
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProvedorBindingSource As BindingSource
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents DetalleProveedorBindingSource As BindingSource
    Friend WithEvents ProvedorTableAdapter As ProyectoFinalDataSetTableAdapters.ProvedorTableAdapter
    Friend WithEvents DetalleProveedorTableAdapter As ProyectoFinalDataSetTableAdapters.DetalleProveedorTableAdapter
End Class
