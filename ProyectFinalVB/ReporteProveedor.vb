Public Class ReporteProveedor
    Private Sub ReporteProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button2.Click
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Provedor' Puede moverla o quitarla según sea necesario.
        Me.ProvedorTableAdapter.Fill(Me.ProyectoFinalDataSet.Provedor)

        Me.ReportViewer1.RefreshReport()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'filtrar por nacionalidad
        Me.ProvedorTableAdapter.FillByNacionalidad(Me.ProyectoFinalDataSet.Provedor, TextBox1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'filtrar por nombre de proveedor
        Me.ProvedorTableAdapter.FillByProveedor(Me.ProyectoFinalDataSet.Provedor, TextBox2.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'filtrar por NIF
        Me.ProvedorTableAdapter.FillByNif(Me.ProyectoFinalDataSet.Provedor, TextBox3.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class