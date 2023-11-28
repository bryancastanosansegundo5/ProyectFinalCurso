Public Class PrincipalUsuarios

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Proovedor.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Usuario.Show()
    End Sub

    Private Sub UsuariosDeLaAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosDeLaAplicaciónToolStripMenuItem.Click
        Usuario.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.Show()
    End Sub

    Private Sub AlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenToolStripMenuItem.Click
        Almacen.Show()
    End Sub

    Private Sub PedidosAProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosAProveedoresToolStripMenuItem.Click
        PedidosProveedor.Show()

    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        Marcas.Show()

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Proovedor.Show()

    End Sub

    Private Sub RecogerUnaReparaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecogerUnaReparaciónToolStripMenuItem.Click
        ReparacionesMostrador.Show()
    End Sub

    Private Sub ReparacionesARealizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReparacionesARealizarToolStripMenuItem.Click
        ReparacionesDetalle.Show()

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Ventas.Show()

    End Sub


End Class