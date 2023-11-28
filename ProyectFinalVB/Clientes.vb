Imports System.ComponentModel

Public Class Clientes
    'Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.ClientesBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

    'End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ProyectoFinalDataSet.Clientes)

        desactivarControles()
    End Sub

    Private Sub activarControles()
        'activo los controles de interaccion
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        NIFTextBox.Enabled = True
        ProvinciaTextBox.Enabled = True
        Numero_telefonoTextBox.Enabled = True
        LocalidadTextBox.Enabled = True
        CalleTextBox.Enabled = True
        PortalTextBox.Enabled = True
        PisoTextBox.Enabled = True
        LetraPisoTextBox.Enabled = True
        ComboBuscar.Enabled = False
        BuscarTxt.Enabled = False
        Buscar.Enabled = False
        Buscar.Visible = False

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
        Button8.Enabled = False
        'los hago no visibles los controles principales
        Me.Button6.Visible = False
        Me.Button9.Visible = False
        Me.Button11.Visible = False
        Me.Button12.Visible = False
        Me.Button1.Visible = False
        Me.Button2.Visible = False
        Me.Button3.Visible = False
        Button8.Visible = False
        Me.Button4.Visible = False

    End Sub

    Private Sub desactivarControles()
        'desactivo los controles de interaccion
        NombreTextBox.Enabled = False
        ApellidoTextBox.Enabled = False
        NIFTextBox.Enabled = False
        ProvinciaTextBox.Enabled = False
        Numero_telefonoTextBox.Enabled = False
        LocalidadTextBox.Enabled = False
        CalleTextBox.Enabled = False
        PortalTextBox.Enabled = False
        PisoTextBox.Enabled = False
        LetraPisoTextBox.Enabled = False
        ComboBuscar.Enabled = True
        BuscarTxt.Enabled = True
        Buscar.Enabled = True
        Buscar.Visible = True

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
        Button8.Enabled = True
        Me.Button11.Enabled = True
        Me.Button12.Enabled = True
        Me.Button1.Enabled = True
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
        Me.Button4.Enabled = True
        'los hago visibles los controles principales
        Me.Button6.Visible = True
        Button8.Visible = True
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

        If ClientesBindingSource.Position > 0 Then
            ClientesBindingSource.MoveFirst()
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ClientesBindingSource.Position > 0 Then
            ClientesBindingSource.MovePrevious()
            Me.Button4.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ClientesBindingSource.Position < ClientesBindingSource.Count - 1 Then
            ClientesBindingSource.MoveNext()
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

        If ClientesBindingSource.Position < ClientesBindingSource.Count - 1 Then
            ClientesBindingSource.MoveLast()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True

        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        activarControles()
        'añado una nueva
        Me.ClientesBindingSource.AddNew()

    End Sub


    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            If ComboBuscar.Text = "ID" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = ClientesBindingSource.Find("Id", busqueda)) Then
                    MessageBox.Show("No hay clientes con ese ID", "Buscar")
                Else
                    ClientesBindingSource.Position = ClientesBindingSource.Find("Id", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If

            If ComboBuscar.Text = "Nombre del Cliente" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = ClientesBindingSource.Find("Nombre", busqueda)) Then
                    MessageBox.Show("No hay clientes con ese Nombre", "Buscar")
                Else
                    ClientesBindingSource.Position = ClientesBindingSource.Find("Nombre", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If

            If ComboBuscar.Text = "Provincia" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = ClientesBindingSource.Find("Provincia", busqueda)) Then
                    MessageBox.Show("No hay provincias con ese Nombre", "Buscar")
                Else
                    ClientesBindingSource.Position = ClientesBindingSource.Find("Provincia", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If
        Catch
        End Try
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'elimino un articulo
        Try
            If MessageBox.Show("Seguro de que desea eliminar este cliente", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

            Else
                Me.ClientesBindingSource.RemoveCurrent()
            End If
        Catch
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'creo una variable fila para posteriormente compararla con todos los NIF para que no se repita ningun NIF
        Dim fila As ProyectoFinalDataSet.ClientesRow
        Try
            'If ClientesBindingSource.Find("NIF", NIFTextBox.Text) <> -1 Then
            '    fila = ProyectoFinalDataSet.Clientes.Rows(ClientesBindingSource.Find("NIF", NIFTextBox.Text))

            '    If fila.NIF = NIFTextBox.Text Then

            '        MessageBox.Show("Este nif ya existe", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

            '        ErrorProvider1.SetError(NIFTextBox, "Este nif ya existe")

            '    End If

            'Else


            'compruebo que se han introducido todos los campos necesarios

            If (NombreTextBox.Text.Equals("") Or Numero_telefonoTextBox.Text.Equals("") Or LocalidadTextBox.Text.Equals("") Or CalleTextBox.Text.Equals("") Or PisoTextBox.Text.Equals("")) Then
                    MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    If Me.NombreTextBox.Text = "" Then
                        ErrorProvider1.SetError(NombreTextBox, "Debe introducir el nombre del usuario")
                    End If



                    If Me.Numero_telefonoTextBox.Text = "" Then
                        ErrorProvider1.SetError(Numero_telefonoTextBox, "Debe introducir un numero de telefono")
                    End If
                    If Me.LocalidadTextBox.Text = "" Then
                        ErrorProvider1.SetError(LocalidadTextBox, "Debe introducir una localidad")
                    End If
                    If Me.CalleTextBox.Text = "" Then
                        ErrorProvider1.SetError(CalleTextBox, "Debe introducir una calle")
                    End If


                    If Me.PisoTextBox.Text = "" Then
                        ErrorProvider1.SetError(PisoTextBox, "Debe introducir un piso")
                    End If

                Else
                    'finalizo la edicion
                    Me.ClientesBindingSource.EndEdit()
                    desactivarControles()
                End If
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cancelo la edicion
        Me.ClientesBindingSource.CancelEdit()

        ErrorProvider1.SetError(NombreTextBox, "")
        ErrorProvider1.SetError(NIFTextBox, "")

        ErrorProvider1.SetError(Numero_telefonoTextBox, "")
        ErrorProvider1.SetError(LocalidadTextBox, "")
        ErrorProvider1.SetError(CalleTextBox, "")
        ErrorProvider1.SetError(PisoTextBox, "")


        desactivarControles()


    End Sub




    'pongo los errores en blanco cuando se haya validado que estan correctos
    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.Validating
        If Me.NombreTextBox.Text <> ("") Then
            ErrorProvider1.SetError(NombreTextBox, "")
        End If
    End Sub





    Private Sub CodigoPostalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Numero_telefonoTextBox.Validating
        If Me.Numero_telefonoTextBox.Text <> ("") Then
            ErrorProvider1.SetError(Numero_telefonoTextBox, "")
        End If
    End Sub
    Private Sub ContactoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CalleTextBox.Validating
        If Me.CalleTextBox.Text <> ("") Then
            ErrorProvider1.SetError(CalleTextBox, "")
        End If
    End Sub

    Private Sub NIFTextBox_TextChanged(sender As Object, e As EventArgs) Handles PisoTextBox.Validating
        If Me.PisoTextBox.Text <> ("") Then
            ErrorProvider1.SetError(PisoTextBox, "")
        End If
    End Sub
    Private Sub WebTextBox_TextChanged(sender As Object, e As EventArgs) Handles LocalidadTextBox.Validating
        If Me.LocalidadTextBox.Text <> ("") Then
            ErrorProvider1.SetError(LocalidadTextBox, "")
        End If
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'para guardar en la base de datos
        Try
            Me.ClientesBindingSource.EndEdit()
            Me.ClientesTableAdapter.Update(ProyectoFinalDataSet)

            Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
            ProyectoFinalDataSet.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If MessageBox.Show("No se pudo guardar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            End If
        End Try
    End Sub
    Private Sub UsuarioBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles ClientesBindingSource.PositionChanged
        'para que en el label nos indique en que puesto de artículo nos encontramos
        Label1.Text = (ClientesBindingSource.Position + 1) & " / " & ClientesBindingSource.Count
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'para modificar el articulo
        activarControles()

    End Sub



    Private Sub Usuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'para guardar los cambios antes de cerrar la aplicación
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?",
            Me.Text, MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2) =
            DialogResult.Yes Then
                Try
                    Me.ClientesBindingSource.EndEdit()
                    Me.ClientesTableAdapter.Update(ProyectoFinalDataSet)
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

    Private Sub Usuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'para guardar los cambios antes de cerrar la aplicación
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea realmente guardar cambios?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.No Then

            ElseIf DialogResult.Yes Then
                Me.Validate()
                Me.ClientesBindingSource.EndEdit()
                Try
                    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)
                Catch ex As Exception

                End Try

            ElseIf DialogResult = DialogResult.Cancel Then
                e.Cancel = True

            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ReporteClientes.Show()
    End Sub

    Private Sub NIFTextBox_Validating(sender As Object, e As CancelEventArgs) Handles NIFTextBox.Validating
        If Me.NIFTextBox.Text <> ("") Then
            ErrorProvider1.SetError(NIFTextBox, "")
        End If
    End Sub


End Class