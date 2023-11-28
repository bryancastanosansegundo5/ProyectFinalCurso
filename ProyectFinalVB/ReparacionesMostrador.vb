Public Class ReparacionesMostrador
    'Private Sub ReparacionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.ReparacionesBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

    'End Sub

    Private Sub Reparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ProyectoFinalDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ProyectoFinalDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.ProyectoFinalDataSet.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.ProyectoFinalDataSet.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.ProyectoFinalDataSet.Almacen)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.ProyectoFinalDataSet.Almacen)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Reparaciones' Puede moverla o quitarla según sea necesario.
        Me.ReparacionesTableAdapter.Fill(Me.ProyectoFinalDataSet.Reparaciones)

        desactivarControles()
        IdLabel3.Enabled = False
    End Sub
    Private Sub activarControles()
        'activo los controles de interaccion
        NombreUsuarioComboBox.Enabled = True
        UsuarioLabel1.Enabled = True
        ApellidosLabel1.Enabled = True
        TelefonoLabel1.Enabled = True
        MarcaLabel2.Enabled = True
        ModeloComboBox.Enabled = True
        ' CantidadTextBox.Enabled = True
        FechaEntrgaDateTimePicker.Enabled = True
        FechaSalidaDateTimePicker.Enabled = True
        DetallesTextBox.Enabled = True

        Me.Button7.Enabled = True
        Me.Button5.Enabled = True
        Me.Button7.Visible = True
        Me.Button5.Visible = True
        Me.Label2.Enabled = True
        Me.Label3.Enabled = True
        Me.Label2.Visible = True
        Me.Label3.Visible = True
        'desactivo los controles principales
        Me.Button6.Enabled = False
        Me.Button9.Enabled = False
        Me.Button11.Enabled = False
        Me.Button12.Enabled = False
        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        Me.Button4.Enabled = False
        'los hago no visibles los controles principales
        Me.Button6.Visible = False
        Me.Button9.Visible = False
        Me.Button11.Visible = False
        Me.Button12.Visible = False
        Me.Button1.Visible = False
        Me.Button2.Visible = False
        Me.Button3.Visible = False
        Me.Button4.Visible = False

    End Sub

    Private Sub desactivarControles()
        'desactivo los controles de interaccion
        NombreUsuarioComboBox.Enabled = False
        UsuarioLabel1.Enabled = False
        ApellidosLabel1.Enabled = False
        TelefonoLabel1.Enabled = False
        MarcaLabel2.Enabled = False
        ModeloComboBox.Enabled = False
        ' CantidadTextBox.Enabled = False
        FechaEntrgaDateTimePicker.Enabled = False
        FechaSalidaDateTimePicker.Enabled = False
        DetallesTextBox.Enabled = False

        Me.Button7.Enabled = False
        Me.Button5.Enabled = False
        Me.Button7.Visible = False
        Me.Button5.Visible = False
        Me.Label2.Enabled = False
        Me.Label3.Enabled = False
        Me.Label2.Visible = False
        Me.Label3.Visible = False

        'activo los controles principales
        Me.Button6.Enabled = True
        Me.Button9.Enabled = True
        Me.Button11.Enabled = True
        Me.Button12.Enabled = True
        Me.Button1.Enabled = True
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
        Me.Button4.Enabled = True
        'los hago visibles los controles principales
        Me.Button6.Visible = True
        Me.Button9.Visible = True
        Me.Button11.Visible = True
        Me.Button12.Visible = True
        Me.Button1.Visible = True
        Me.Button2.Visible = True
        Me.Button3.Visible = True
        Me.Button4.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Button2.Enabled = False
        Me.Button1.Enabled = False

        If ReparacionesBindingSource.Position > 0 Then
            ReparacionesBindingSource.MoveFirst()
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ReparacionesBindingSource.Position > 0 Then
            ReparacionesBindingSource.MovePrevious()
            Me.Button4.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Button4.Enabled = False
        Me.Button3.Enabled = False

        If ReparacionesBindingSource.Position < ReparacionesBindingSource.Count - 1 Then
            ReparacionesBindingSource.MoveLast()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True

        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        activarControles()
        'añado una nueva entrada
        Me.ReparacionesBindingSource.AddNew()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'elimino un articulo
        Try
            If MessageBox.Show("Seguro de que desea eliminar esta reparación", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

            Else
                Me.ReparacionesBindingSource.RemoveCurrent()
            End If
        Catch
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'compruebo que se han introducido todos los campos necesarios
        Try
            If (MarcaLabel2.Text.Equals("") Or ModeloComboBox.Text.Equals("") Or FechaEntrgaDateTimePicker.ToString.Equals("") Or FechaSalidaDateTimePicker.Value.ToShortDateString.Equals("") Or NombreUsuarioComboBox.Text.Equals("") Or DetallesTextBox.Text.Equals("")) Then
                MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Me.MarcaLabel2.Text = "" Then
                    ErrorProvider1.SetError(MarcaLabel2, "Debe introducir una marca")
                End If
                If Me.ModeloComboBox.Text = "" Then
                    ErrorProvider1.SetError(ModeloComboBox, "Debe introducir un modelo")
                End If


                If Me.FechaEntrgaDateTimePicker.ToString = "" Then
                    ErrorProvider1.SetError(FechaEntrgaDateTimePicker, "Debe introducir una fecha de entrega")
                End If

                If Me.FechaSalidaDateTimePicker.ToString = "" Then
                    ErrorProvider1.SetError(FechaSalidaDateTimePicker, "Debe introducir una fecha de salida")
                End If
                If Me.NombreUsuarioComboBox.Text = "" Then
                    ErrorProvider1.SetError(NombreUsuarioComboBox, "Debe introducir un usuario")
                End If
                If Me.DetallesTextBox.Text = "" Then
                    ErrorProvider1.SetError(DetallesTextBox, "Debe introducir una descripcion de el motivo")
                End If

            Else
                ErrorProvider1.SetError(MarcaLabel2, "")
                ErrorProvider1.SetError(NombreUsuarioComboBox, "")
                ErrorProvider1.SetError(ModeloComboBox, "")
                ErrorProvider1.SetError(FechaSalidaDateTimePicker, "")
                ErrorProvider1.SetError(FechaEntrgaDateTimePicker, "")
                ErrorProvider1.SetError(DetallesTextBox, "")


                'finalizo la edicion
                Me.ReparacionesBindingSource.EndEdit()
                desactivarControles()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Error)



        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cancelo la edicion
        Me.ReparacionesBindingSource.CancelEdit()

        ErrorProvider1.SetError(MarcaLabel2, "")
        ErrorProvider1.SetError(NombreUsuarioComboBox, "")
        ErrorProvider1.SetError(ModeloComboBox, "")
        'ErrorProvider1.SetError(CantidadTextBox, "")

        ErrorProvider1.SetError(FechaSalidaDateTimePicker, "")
        ErrorProvider1.SetError(FechaEntrgaDateTimePicker, "")

        desactivarControles()


    End Sub




    'pongo los errores en blanco cuando se haya validado que estan correctos
    Private Sub MarcaTextBox_TextChanged(sender As Object, e As EventArgs) Handles MarcaLabel2.Validating
        If Me.MarcaLabel2.Text <> ("") Then
            ErrorProvider1.SetError(MarcaLabel2, "")
        End If
    End Sub

    Private Sub NombreUsuarioComboBox_TextChanged(sender As Object, e As EventArgs) Handles NombreUsuarioComboBox.Validating
        If Me.NombreUsuarioComboBox.Text <> ("") Then
            ErrorProvider1.SetError(NombreUsuarioComboBox, "")
        End If
    End Sub
    Private Sub ModeloComboBox_TextChanged(sender As Object, e As EventArgs) Handles ModeloComboBox.Validating
        If Me.ModeloComboBox.Text <> ("") Then
            ErrorProvider1.SetError(ModeloComboBox, "")
        End If
    End Sub

    Private Sub FechaEntrgaDateTimePicker_TextChanged(sender As Object, e As EventArgs) Handles FechaEntrgaDateTimePicker.Validating
        If Me.FechaEntrgaDateTimePicker.Text <> ("") Then
            ErrorProvider1.SetError(FechaEntrgaDateTimePicker, "")
        End If
    End Sub
    'Private Sub CantidadTextBox_TextChanged(sender As Object, e As EventArgs) Handles CantidadTextBox.Validating
    '    If Me.CantidadTextBox.Text <> ("") Then
    '        ErrorProvider1.SetError(CantidadTextBox, "")
    '    End If
    'End Sub

    Private Sub FechaSalidaDateTimePicker_TextChanged(sender As Object, e As EventArgs) Handles FechaSalidaDateTimePicker.Validating
        If Me.FechaSalidaDateTimePicker.Text <> ("") Then
            ErrorProvider1.SetError(FechaSalidaDateTimePicker, "")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'para guardar en la base de datos
        Try
            Me.ReparacionesBindingSource.EndEdit()
            Me.ReparacionesTableAdapter.Update(ProyectoFinalDataSet)

            Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
            ProyectoFinalDataSet.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If MessageBox.Show("No se pudo guardar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            End If
        End Try
    End Sub
    Private Sub ReparacionesBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles ReparacionesBindingSource.PositionChanged
        'para que en el label nos indique en que puesto de artículo nos encontramos
        Label1.Text = (ReparacionesBindingSource.Position + 1) & " / " & ReparacionesBindingSource.Count
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'para modificar el articulo
        activarControles()

    End Sub



    Private Sub Reparaciones_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'para guardar los cambios antes de cerrar la aplicación
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?",
            Me.Text, MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2) =
            DialogResult.Yes Then
                Try
                    Me.ReparacionesBindingSource.EndEdit()
                    Me.ReparacionesTableAdapter.Update(ProyectoFinalDataSet)
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

    Private Sub Reparaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'para guardar los cambios antes de cerrar la aplicación
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea realmente guardar cambios?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.No Then

            ElseIf DialogResult.Yes Then
                Me.Validate()
                Me.ReparacionesBindingSource.EndEdit()
                Try
                    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)
                Catch ex As Exception

                End Try

            ElseIf DialogResult = DialogResult.Cancel Then
                e.Cancel = True

            End If
        End If
    End Sub
    'para cargar los datos del usuario en esta vista
    Private Sub UsuarioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreUsuarioComboBox.SelectedIndexChanged
        If Me.NombreUsuarioComboBox.SelectedIndex <> -1 Then

            Dim filaProveedor As ProyectoFinalDataSet.ClientesRow
            filaProveedor = Me.ProyectoFinalDataSet.Clientes.Rows(NombreUsuarioComboBox.SelectedIndex)

            With filaProveedor
                Me.UsuarioLabel1.Text = .Nombre
                Me.ApellidosLabel1.Text = .Apellido
                Me.TelefonoLabel1.Text = .Numero_telefono

            End With
        End If
    End Sub
    Private Sub BiciComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModeloComboBox.SelectedIndexChanged
        If Me.ModeloComboBox.SelectedIndex <> -1 Then

            Dim filaArticulo As ProyectoFinalDataSet.AlmacenRow
            filaArticulo = Me.ProyectoFinalDataSet.Almacen.Rows(ModeloComboBox.SelectedIndex)

            With filaArticulo

                Me.MarcaLabel2.Text = .Marca

            End With
        End If
    End Sub


End Class