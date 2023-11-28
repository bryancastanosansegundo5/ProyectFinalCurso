Public Class ReporteReparacion
    Private Sub ReporteReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Reparaciones' Puede moverla o quitarla según sea necesario.
        Me.ReparacionesTableAdapter.Fill(Me.ProyectoFinalDataSet.Reparaciones)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.DetalleReparacion' Puede moverla o quitarla según sea necesario.
        Me.DetalleReparacionTableAdapter.Fill(Me.ProyectoFinalDataSet.DetalleReparacion)

        ReparacionesBindingSource.Filter = "Id=" & ReparacionesDetalle.IdReparacion.Text

        DetalleReparacionBindingSource.Filter = "Id=" & ReparacionesDetalle.IdReparacion.Text

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class