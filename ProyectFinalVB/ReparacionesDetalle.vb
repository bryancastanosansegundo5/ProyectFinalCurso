Imports System.ComponentModel

Public Class ReparacionesDetalle

    Private Sub ReparacionesDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.DetalleReparacion' Puede moverla o quitarla según sea necesario.
        Me.DetalleReparacionTableAdapter.Fill(Me.ProyectoFinalDataSet.DetalleReparacion)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.ProyectoFinalDataSet.Almacen)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.DetalleReparacion' Puede moverla o quitarla según sea necesario.
        Me.DetalleReparacionTableAdapter.Fill(Me.ProyectoFinalDataSet.DetalleReparacion)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Reparaciones' Puede moverla o quitarla según sea necesario.
        Me.ReparacionesTableAdapter.Fill(Me.ProyectoFinalDataSet.Reparaciones)

        'activo y desactivo los controles disponibles nada mas acceder a la pantalla
        IdReparacion.Enabled = False
        desactivarControles()
        deshabilitardetalle()
        DetalleReparacionDataGridView.Enabled = False
    End Sub
    Private Sub desactivarControles()
        'activo los controles de interaccion
        'NombreUsuarioLabel2.Enabled = False
        UsuarioLabel1.Enabled = False
        NombreUsuarioLabel1.Enabled = False
        ApellidosLabel1.Enabled = False
        TelefonoLabel1.Enabled = False
        FechaEntrgaDateTimePicker.Enabled = False
        FechaSalidaDateTimePicker.Enabled = False
        MarcaLabel2.Enabled = False
        ModeloLabel3.Enabled = False
        DetallesLabel2.Enabled = False

    End Sub


    Sub desactivardesplaza()

        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        Me.Button4.Enabled = False


    End Sub
    Sub activardesplaza()

        Me.Button1.Enabled = True
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
        Me.Button4.Enabled = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.UsuariosBindingSource.MoveFirst()
        Me.Button2.Enabled = False
        Me.Button1.Enabled = False

        If ReparacionesBindingSource.Position > 0 Then
            ReparacionesBindingSource.MoveFirst()
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'Me.UsuariosBindingSource.MoveFirst()
        Me.Button17.Enabled = False
        Me.Button18.Enabled = False

        If DetalleReparacionBindingSource.Position > 0 Then
            DetalleReparacionBindingSource.MoveFirst()
            Me.Button16.Enabled = True
            Me.Button8.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.UsuariosBindingSource.MovePrevious()
        If ReparacionesBindingSource.Position > 0 Then
            ReparacionesBindingSource.MovePrevious()
            Me.Button4.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False

        End If
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'Me.UsuariosBindingSource.MovePrevious()
        If DetalleReparacionBindingSource.Position > 0 Then
            DetalleReparacionBindingSource.MovePrevious()
            Me.Button16.Enabled = True
            Me.Button8.Enabled = True
        Else
            Me.Button18.Enabled = False
            Me.Button17.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ReparacionesBindingSource.Position < ReparacionesBindingSource.Count - 1 Then
            ReparacionesBindingSource.MoveNext()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True
        Else
            Me.Button4.Enabled = False
            Me.Button3.Enabled = False

        End If
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If DetalleReparacionBindingSource.Position < DetalleReparacionBindingSource.Count - 1 Then
            DetalleReparacionBindingSource.MoveNext()
            Me.Button18.Enabled = True
            Me.Button17.Enabled = True
        Else
            Me.Button16.Enabled = False
            Me.Button8.Enabled = False

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Me.UsuariosBindingSource.MoveLast()
        Me.Button4.Enabled = False
        Me.Button3.Enabled = False

        If ReparacionesBindingSource.Position < ReparacionesBindingSource.Count - 1 Then
            ReparacionesBindingSource.MoveLast()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True

        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Me.UsuariosBindingSource.MoveLast()
        Me.Button16.Enabled = False
        Me.Button8.Enabled = False

        If DetalleReparacionBindingSource.Position < DetalleReparacionBindingSource.Count - 1 Then
            DetalleReparacionBindingSource.MoveLast()
            Me.Button17.Enabled = True
            Me.Button18.Enabled = True

        End If
    End Sub



    Sub habilitardetalle()


        ' Button13.Visible = True   'para el informe



        Button14.Visible = True
        Button14.Enabled = True
        Button15.Visible = True
        Button15.Enabled = True
        Label6.Visible = True
        Label5.Visible = True

        Button10.Enabled = False
        Button11.Enabled = False
        Button5.Enabled = False
        Button8.Visible = True
        Button8.Enabled = False
        Button16.Visible = True
        Button16.Enabled = False
        Button17.Visible = True
        Button17.Enabled = False
        Button19.Visible = True
        Button19.Enabled = False

        Button18.Visible = True
        Button18.Enabled = False
        Label4.Visible = True


        Button1.Visible = True
        Button1.Enabled = True

        Button2.Visible = True
        Button2.Enabled = True
        Button3.Visible = True
        Button3.Enabled = True

        Button4.Visible = True
        Button4.Enabled = True

        Label2.Enabled = True
        ArticuloLabel1.Enabled = True
        ModeloDetalleComboBox.Enabled = True
        PrecioUnitarioTextBox.Enabled = True
        CantidadTextBox.Enabled = True
        ImporteTotalTextBox.Enabled = True
        DetalleReparacionDataGridView.Visible = False

    End Sub

    Sub deshabilitardetalle()

        Button1.Enabled = True
        Button1.Visible = True
        Label5.Visible = True
        'Button13.Visible = True    'para el informe

        Button10.Enabled = True
        Button11.Enabled = True

        Button5.Enabled = True
        Button2.Enabled = True
        Button2.Visible = True
        Button8.Visible = True
        Button8.Enabled = True
        Button16.Visible = True
        Button16.Enabled = True
        Button17.Visible = True
        Button17.Enabled = True
        Button19.Visible = True
        Button19.Enabled = True

        Button18.Visible = True
        Button18.Enabled = True
        Button3.Enabled = True
        Button3.Visible = True
        Button4.Enabled = True
        Button4.Visible = True

        Button14.Enabled = False
        Button14.Visible = False

        Button15.Enabled = False
        Button15.Visible = False
        Label6.Visible = False
        Label5.Visible = False

        Button14.Visible = False
        Button14.Enabled = False
        Button15.Visible = False
        Button15.Enabled = False
        Label6.Visible = False
        Label5.Visible = False

        Label2.Enabled = False
        ArticuloLabel1.Enabled = False
        ModeloDetalleComboBox.Enabled = False
        PrecioUnitarioTextBox.Enabled = False
        CantidadTextBox.Enabled = False
        ImporteTotalTextBox.Enabled = False
        DetalleReparacionDataGridView.Visible = True

    End Sub











    Private Sub UsuarioBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles ReparacionesBindingSource.PositionChanged
        'para que en el label nos indique en que puesto de artículo nos encontramos
        Label1.Text = (ReparacionesBindingSource.Position + 1) & " / " & ReparacionesBindingSource.Count
    End Sub
    Private Sub DetalleVentaBindingSource_PositionChanged(sender As Object, e As EventArgs)
        Label4.Text = (DetalleReparacionBindingSource.Position + 1) & " / " & DetalleReparacionBindingSource.Count
    End Sub


    Private Sub ReparacionesDetalle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea realmente guardar cambios?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.No Then

            ElseIf DialogResult.Yes Then
                Me.Validate()
                'Me.DetalleReparacionBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

                Me.DetalleReparacionBindingSource.EndEdit()
                Me.DetalleReparacionTableAdapter.Update(ProyectoFinalDataSet)
                TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
                ProyectoFinalDataSet.AcceptChanges()
            ElseIf DialogResult = DialogResult.Cancel Then
                e.Cancel = True

            End If
        End If
    End Sub
    Private Sub Ventas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?",
            Me.Text, MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2) =
            DialogResult.Yes Then
                Try
                    Me.DetalleReparacionBindingSource.EndEdit()
                    Me.DetalleReparacionTableAdapter.Update(ProyectoFinalDataSet)
                    TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
                    ProyectoFinalDataSet.AcceptChanges()
                    MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                End Try
            End If
        End If
    End Sub



    'para cargar los datos del modelo en esta vista
    Private Sub ModeloComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModeloDetalleComboBox.SelectedIndexChanged
        Dim porcen As Double
        If Me.ModeloDetalleComboBox.SelectedIndex <> -1 Then

            Dim filaArticulo As ProyectoFinalDataSet.AlmacenRow
            filaArticulo = Me.ProyectoFinalDataSet.Almacen.Rows(ModeloDetalleComboBox.SelectedIndex)

            With filaArticulo
                porcen = (.PrecioCoste * .PVP) / 100
                Me.IdArticuloLabel1.Text = .Id
                Me.ArticuloLabel1.Text = .Marca
                Me.PrecioUnitarioTextBox.Text = .PrecioCoste + porcen
                Me.Label2.Text = .Cantidad




            End With
        End If
    End Sub



    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'creo variables para poder calcular el precio final
        Dim cantidad As Double
        Dim precio As Double
        Dim resultado1 As Double
        Dim resultado As Integer
        Dim cant As String
        resultado = MessageBox.Show("¿Desea finalizar el detalle?", "Aceptar", MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Information)


        'Try


        'If DetalleReparacionBindingSource.Find("idArticulo", IdArticuloLabel1.Text) <> -1 Then
        '    '  MessageBox.Show("if", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    Dim fila As ProyectoFinalDataSet.DetalleReparacionRow
        '    ' MessageBox.Show("dim", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    fila = ProyectoFinalDataSet.DetalleReparacion.Rows(DetalleReparacionBindingSource.Find("idArticulo", IdArticuloLabel1.Text))
        '    'MessageBox.Show("fila", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    If fila.idArticulo = IdArticuloLabel1.Text Then

        '        MessageBox.Show("Este articulo ya se añadio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        '        ErrorProvider1.SetError(CantidadTextBox, "Este articulo ya se añadio")
        '    End If
        'Else
        If resultado = 1 Then

            'compruebo que se han introducido todos los campos necesarios

            If (ArticuloLabel1.Text.Equals("") Or ModeloDetalleComboBox.Text.Equals("") Or CantidadTextBox.Text.Equals("") Or PrecioUnitarioTextBox.Text.Equals("")) Then
                MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Me.ArticuloLabel1.Text = "" Then
                    ErrorProvider1.SetError(ArticuloLabel1, "Debe introducir la marca del articulo")
                End If
                If Me.ModeloDetalleComboBox.Text = "" Then
                    ErrorProvider1.SetError(ModeloDetalleComboBox, "Debe introducir un modelo")
                End If

                If Me.CantidadTextBox.Text = "" Then
                    ErrorProvider1.SetError(CantidadTextBox, "Debe introducir una cantidad")
                End If
                If Me.PrecioUnitarioTextBox.Text = "" Then
                    ErrorProvider1.SetError(PrecioUnitarioTextBox, "Debe existir un precio unitario")
                End If








            ElseIf AlmacenBindingSource.Find("Modelo", ModeloDetalleComboBox.Text) <> -1 Then
                Dim fila As ProyectoFinalDataSet.AlmacenRow



                fila = ProyectoFinalDataSet.Almacen.Rows(AlmacenBindingSource.Find("Modelo", ModeloDetalleComboBox.Text))


                If fila.Cantidad < CantidadTextBox.Text Then

                    MessageBox.Show("La cantidad es mayor a la existente en stock", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ErrorProvider1.SetError(CantidadTextBox, "La cantidad es mayor a la existente en stock")
                Else

                    Try
                        precio = Convert.ToDouble(PrecioUnitarioTextBox.Text)
                        cantidad = Convert.ToDouble(CantidadTextBox.Text)
                        resultado1 = cantidad * precio
                        ImporteTotalTextBox.Text = resultado1



                        deshabilitardetalle()

                    Catch

                    End Try

                    Try
                        ErrorProvider1.SetError(ArticuloLabel1, "")
                        ErrorProvider1.SetError(ModeloDetalleComboBox, "")
                        ErrorProvider1.SetError(CantidadTextBox, "")
                        ErrorProvider1.SetError(ImporteTotalTextBox, "")
                        ErrorProvider1.SetError(PrecioUnitarioTextBox, "")

                        DetalleReparacionBindingSource.EndEdit()
                        DetalleReparacionDataGridView.Refresh()


                    Catch

                    End Try
                    'hago la resta al stock total
                    cant = Me.CantidadTextBox.Text
                    fila.Cantidad = fila.Cantidad - cant

                    Me.AlmacenTableAdapter.Update(ProyectoFinalDataSet)
                    'Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
                    If fila.Cantidad < 3 Then
                        MessageBox.Show("Se está agotando el stock", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf fila.Cantidad <= 0 Then

                        MessageBox.Show("Se ha agotado el stock", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
        'End If





    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If MessageBox.Show("¿Desea cancelar la linea? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            DetalleReparacionBindingSource.CancelEdit()

            ErrorProvider1.SetError(ArticuloLabel1, "")
            ErrorProvider1.SetError(ModeloDetalleComboBox, "")
            ErrorProvider1.SetError(CantidadTextBox, "")
            ErrorProvider1.SetError(ImporteTotalTextBox, "")
            ErrorProvider1.SetError(PrecioUnitarioTextBox, "")

            deshabilitardetalle()
        Else
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            DetalleReparacionBindingSource.AddNew()
            habilitardetalle()
        Catch ex As Exception
            MessageBox.Show("Rellena anteriormente la cabecera y/o el detalle", Me.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If MessageBox.Show("Seguro de que desea eliminar esta reparación", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

        Else
            Try
                Me.DetalleReparacionBindingSource.RemoveCurrent()
            Catch
                MessageBox.Show("No hay mas reparaciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        deshabilitardetalle()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click



        'para guardar en la base de datos
        Try




            Me.DetalleReparacionBindingSource.EndEdit()
            Me.DetalleReparacionTableAdapter.Update(ProyectoFinalDataSet)
            'actualizo almacen despues de hacer la resta de stock
            Me.AlmacenTableAdapter.Update(ProyectoFinalDataSet)

            Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
            ProyectoFinalDataSet.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If MessageBox.Show("No se pudo guardar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            End If
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReporteReparacion.Show()
    End Sub
End Class