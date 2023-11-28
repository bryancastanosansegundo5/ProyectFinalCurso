Public Class ReportePedidoProveedor
    Private Sub ReporteProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Provedor' Puede moverla o quitarla según sea necesario.
        Me.ProvedorTableAdapter.Fill(Me.ProyectoFinalDataSet.Provedor)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.DetalleProveedor' Puede moverla o quitarla según sea necesario.
        Me.DetalleProveedorTableAdapter.Fill(Me.ProyectoFinalDataSet.DetalleProveedor)

        ProvedorBindingSource.Filter = "Id=" & PedidosProveedor.IdProveedor1.Text
        DetalleProveedorBindingSource.Filter = "Id=" & PedidosProveedor.IdProveedor1.Text

        Me.ReportViewer1.RefreshReport()


    End Sub

End Class