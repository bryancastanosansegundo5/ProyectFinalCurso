Public Class Proovedor
    'Private Sub ProvedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
    '    Me.Validate()
    '    Me.ProvedorBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

    'End Sub

    Private Sub Proovedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Provedor' Puede moverla o quitarla según sea necesario.
        Me.ProvedorTableAdapter.Fill(Me.ProyectoFinalDataSet.Provedor)
        desactivarControles()
        IdLabel1.Enabled = False
    End Sub
    Private Sub activarControles()
        'activo los controles de interaccion
        NombreTextBox.Enabled = True
        ProveedorTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        NacionalidadTextBox.Enabled = True
        WebTextBox.Enabled = True
        E_MailTextBox.Enabled = True
        ContactoTextBox.Enabled = True
        CodigoPostalTextBox.Enabled = True
        NIFTextBox.Enabled = True
        GroupBox1.Enabled = False

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
        Me.Button8.Enabled = False
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
        Me.Button8.Visible = False
        Me.Button4.Visible = False

    End Sub

    Private Sub desactivarControles()
        'desactivo los controles de interaccion
        NombreTextBox.Enabled = False
        NombreTextBox.Enabled = False
        ProveedorTextBox.Enabled = False
        DireccionTextBox.Enabled = False
        NacionalidadTextBox.Enabled = False
        WebTextBox.Enabled = False
        E_MailTextBox.Enabled = False
        ContactoTextBox.Enabled = False
        CodigoPostalTextBox.Enabled = False
        NIFTextBox.Enabled = False
        GroupBox1.Enabled = True
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
        Button8.Enabled = True
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

        If ProvedorBindingSource.Position > 0 Then
            ProvedorBindingSource.MoveFirst()
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ProvedorBindingSource.Position > 0 Then
            ProvedorBindingSource.MovePrevious()
            Me.Button4.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ProvedorBindingSource.Position < ProvedorBindingSource.Count - 1 Then
            ProvedorBindingSource.MoveNext()
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

        If ProvedorBindingSource.Position < ProvedorBindingSource.Count - 1 Then
            ProvedorBindingSource.MoveLast()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True

        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        activarControles()
        'añado una nueva
        Me.ProvedorBindingSource.AddNew()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'elimino un articulo
        Try
            If MessageBox.Show("Seguro de que desea eliminar este proveedor", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

            Else
                Me.ProvedorBindingSource.RemoveCurrent()
            End If
        Catch
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'creo una variable fila para posteriormente compararla con todos los NIF para que no se repita ningun NIF
        Dim fila As ProyectoFinalDataSet.ProvedorRow
        Try
            'If ProvedorBindingSource.Find("NIF", NIFTextBox.Text) <> -1 Then
            '    fila = ProyectoFinalDataSet.Provedor.Rows(ProvedorBindingSource.Find("NIF", NIFTextBox.Text))

            '    If fila.NIF = NIFTextBox.Text Then

            '        MessageBox.Show("Este NIF ya existe", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

            '        ErrorProvider1.SetError(NIFTextBox, "Este NIF ya existe")

            '    End If

            'Else


            'compruebo que se han introducido todos los campos necesarios

            If (ProveedorTextBox.Text.Equals("") Or NombreTextBox.Text.Equals("") Or DireccionTextBox.Text.Equals("") Or NacionalidadTextBox.Text.Equals("") Or NIFTextBox.Text.Equals("") Or WebTextBox.Text.Equals("") Or E_MailTextBox.Text.Equals("") Or ContactoTextBox.Text.Equals("") Or CodigoPostalTextBox.Text.Equals("")) Then
                    MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    If Me.ProveedorTextBox.Text = "" Then
                        ErrorProvider1.SetError(ProveedorTextBox, "Debe introducir un nombre de proovedor")
                    End If
                    If Me.NombreTextBox.Text = "" Then
                        ErrorProvider1.SetError(NombreTextBox, "Debe introducir el nombre real de la empresa")
                    End If
                    If Me.DireccionTextBox.Text = "" Then
                        ErrorProvider1.SetError(DireccionTextBox, "Debe introducir una dirección")
                    End If

                    If Me.NacionalidadTextBox.Text = "" Then
                        ErrorProvider1.SetError(NacionalidadTextBox, "Debe introducir una nacionalidad de la empresa")
                    End If


                    If Me.WebTextBox.Text = "" Then
                        ErrorProvider1.SetError(WebTextBox, "Debe introducir una web")
                    End If
                    If Me.E_MailTextBox.Text = "" Then
                        ErrorProvider1.SetError(E_MailTextBox, "Debe introducir un mail")
                    End If
                    If Me.CodigoPostalTextBox.Text = "" Then
                        ErrorProvider1.SetError(CodigoPostalTextBox, "Debe introducir un codigo postal")
                    End If
                    If Me.ContactoTextBox.Text = "" Then
                        ErrorProvider1.SetError(ContactoTextBox, "Debe introducir un numero de contacto")
                    End If
                    If Me.NIFTextBox.Text = "" Then
                        ErrorProvider1.SetError(NIFTextBox, "Debe introducir un NIF")
                    End If

                Else
                    'finalizo la edicion
                    Me.ProvedorBindingSource.EndEdit()
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
        Me.ProvedorBindingSource.CancelEdit()

        ErrorProvider1.SetError(NombreTextBox, "")
        ErrorProvider1.SetError(ProveedorTextBox, "")
        ErrorProvider1.SetError(DireccionTextBox, "")
        ErrorProvider1.SetError(NacionalidadTextBox, "")

        ErrorProvider1.SetError(WebTextBox, "")
        ErrorProvider1.SetError(NIFTextBox, "")
        ErrorProvider1.SetError(ContactoTextBox, "")
        ErrorProvider1.SetError(CodigoPostalTextBox, "")
        ErrorProvider1.SetError(E_MailTextBox, "")

        desactivarControles()


    End Sub




    'pongo los errores en blanco cuando se haya validado que estan correctos
    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.Validating
        If Me.NombreTextBox.Text <> ("") Then
            ErrorProvider1.SetError(NombreTextBox, "")
        End If
    End Sub

    Private Sub ModeloTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProveedorTextBox.Validating
        If Me.ProveedorTextBox.Text <> ("") Then
            ErrorProvider1.SetError(ProveedorTextBox, "")
        End If
    End Sub
    Private Sub PrecioTextBox_TextChanged(sender As Object, e As EventArgs) Handles DireccionTextBox.Validating
        If Me.DireccionTextBox.Text <> ("") Then
            ErrorProvider1.SetError(DireccionTextBox, "")
        End If
    End Sub

    Private Sub NacionalidadTextBox_TextChanged(sender As Object, e As EventArgs) Handles NacionalidadTextBox.Validating
        If Me.NacionalidadTextBox.Text <> ("") Then
            ErrorProvider1.SetError(NacionalidadTextBox, "")
        End If
    End Sub
    Private Sub E_MailTextBox_TextChanged(sender As Object, e As EventArgs) Handles E_MailTextBox.Validating
        If Me.E_MailTextBox.Text <> ("") Then
            ErrorProvider1.SetError(E_MailTextBox, "")
        End If
    End Sub

    Private Sub CodigoPostalTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodigoPostalTextBox.Validating
        If Me.CodigoPostalTextBox.Text <> ("") Then
            ErrorProvider1.SetError(CodigoPostalTextBox, "")
        End If
    End Sub
    Private Sub ContactoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactoTextBox.Validating
        If Me.ContactoTextBox.Text <> ("") Then
            ErrorProvider1.SetError(ContactoTextBox, "")
        End If
    End Sub

    Private Sub NIFTextBox_TextChanged(sender As Object, e As EventArgs) Handles NIFTextBox.Validating
        If Me.NIFTextBox.Text <> ("") Then
            ErrorProvider1.SetError(NIFTextBox, "")
        End If
    End Sub
    Private Sub WebTextBox_TextChanged(sender As Object, e As EventArgs) Handles WebTextBox.Validating
        If Me.WebTextBox.Text <> ("") Then
            ErrorProvider1.SetError(WebTextBox, "")
        End If
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'para guardar en la base de datos
        Try
            Me.ProvedorBindingSource.EndEdit()
            Me.ProvedorTableAdapter.Update(ProyectoFinalDataSet)

            Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
            ProyectoFinalDataSet.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If MessageBox.Show("No se pudo guardar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            End If
        End Try
    End Sub
    Private Sub AlmacenBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles ProvedorBindingSource.PositionChanged
        'para que en el label nos indique en que puesto de artículo nos encontramos
        Label1.Text = (ProvedorBindingSource.Position + 1) & " / " & ProvedorBindingSource.Count
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'para modificar el articulo
        activarControles()

    End Sub



    Private Sub Almacen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'para guardar los cambios antes de cerrar la aplicación
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?",
            Me.Text, MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2) =
            DialogResult.Yes Then
                Try
                    Me.ProvedorBindingSource.EndEdit()
                    Me.ProvedorTableAdapter.Update(ProyectoFinalDataSet)
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

    Private Sub Proovedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'para guardar los cambios antes de cerrar la aplicación
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea realmente guardar cambios?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.No Then

            ElseIf DialogResult.Yes Then
                Me.Validate()
                Me.ProvedorBindingSource.EndEdit()
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
        ReporteProveedor.Show()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            If ComboBuscar.Text = "ID" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = ProvedorBindingSource.Find("ID", busqueda)) Then
                    MessageBox.Show("No hay proveedores con ese ID", "Buscar")
                Else
                    ProvedorBindingSource.Position = ProvedorBindingSource.Find("ID", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If

            If ComboBuscar.Text = "Nombre de proveedor" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = ProvedorBindingSource.Find("Proveedor", busqueda)) Then
                    MessageBox.Show("No hay proveedores con ese Nombre", "Buscar")
                Else
                    ProvedorBindingSource.Position = ProvedorBindingSource.Find("Proveedor", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If

            If ComboBuscar.Text = "NIF" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = ProvedorBindingSource.Find("NIF", busqueda)) Then
                    MessageBox.Show("No hay proveedores con ese NIF", "Buscar")
                Else
                    ProvedorBindingSource.Position = ProvedorBindingSource.Find("NIF", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If
        Catch
        End Try
    End Sub
End Class