Public Class ReporteClientes
    Private Sub ReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button2.Click
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ProyectoFinalDataSet.Clientes)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'filtrar por provincia
        Me.ClientesTableAdapter.FillByCiudad(Me.ProyectoFinalDataSet.Clientes, TextBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'filtrar por localidad
        Me.ClientesTableAdapter.FillByLocalidad(Me.ProyectoFinalDataSet.Clientes, TextBox2.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'filtrar por provincia y localidad
        Me.ClientesTableAdapter.FillByAmbos(Me.ProyectoFinalDataSet.Clientes, TextBox1.Text, TextBox2.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class