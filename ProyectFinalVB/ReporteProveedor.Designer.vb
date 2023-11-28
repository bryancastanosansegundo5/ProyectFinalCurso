<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteProveedor))
        Me.ProvedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProvedorTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ProvedorTableAdapter()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "Proveedor"
        ReportDataSource1.Value = Me.ProvedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProyectFinalVB.Proveedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 114)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(973, 401)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProvedorTableAdapter
        '
        Me.ProvedorTableAdapter.ClearBeforeFill = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(392, 73)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 20
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(221, 70)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Filtrar por NIF"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(392, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(221, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(165, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Filtrar por nombre de proveedor"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(392, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(542, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Refrescar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Filtrar por nacionalidad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReporteProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 508)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReporteProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteProveedor"
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProvedorBindingSource As BindingSource
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents ProvedorTableAdapter As ProyectoFinalDataSetTableAdapters.ProvedorTableAdapter
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
