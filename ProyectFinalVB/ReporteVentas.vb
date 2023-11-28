Public Class ReporteVentas
    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ProyectoFinalDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
        Me.DetalleVentaTableAdapter.Fill(Me.ProyectoFinalDataSet.DetalleVenta)

        VentasBindingSource.Filter = "Id=" & Ventas.IdLabel1.Text
        DetalleVentaBindingSource.Filter = "Id=" & Ventas.IdLabel1.Text

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class