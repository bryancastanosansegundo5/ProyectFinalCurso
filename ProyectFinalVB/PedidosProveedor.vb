Imports System.ComponentModel

Public Class PedidosProveedor
    'Private Sub ProvedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProvedorBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.ProvedorBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

    'End Sub

    Private Sub PedidosProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.ProyectoFinalDataSet.Almacen)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.DetalleProveedor' Puede moverla o quitarla según sea necesario.
        Me.DetalleProveedorTableAdapter.Fill(Me.ProyectoFinalDataSet.DetalleProveedor)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Provedor' Puede moverla o quitarla según sea necesario.
        Me.ProvedorTableAdapter.Fill(Me.ProyectoFinalDataSet.Provedor)

        FechaLLegadaDateTimePicker.Format = DateTimePickerFormat.Custom
        FechaLLegadaDateTimePicker.CustomFormat = "dd/MM/yyyy"

        FechaPedidoDateTimePicker.Format = DateTimePickerFormat.Custom
        FechaPedidoDateTimePicker.CustomFormat = "dd/MM/yyyy"

        'IdLabel1.Enabled = False
        desactivarControles()
        deshabilitardetalle()
        DetalleProveedorDataGridView.Enabled = False
    End Sub
    Private Sub desactivarControles()
        'desactivo los controles de interaccion
        ProveedorComboBox.Enabled = False
        NombreLabel2.Enabled = False
        DireccionLabel2.Enabled = False
        NacionalidadLabel1.Enabled = False
        WebLabel1.Enabled = False
        E_MailLabel1.Enabled = False
        CodigoPostalLabel1.Enabled = False
        ContactoLabel1.Enabled = False
        NIFLabel1.Enabled = False

    End Sub
    Private Sub activarControles()
        'desactivo los controles de interaccion
        ProveedorComboBox.Enabled = True
        NombreLabel2.Enabled = True
        DireccionLabel2.Enabled = True
        NacionalidadLabel1.Enabled = True
        WebLabel1.Enabled = True
        E_MailLabel1.Enabled = True
        CodigoPostalLabel1.Enabled = True
        ContactoLabel1.Enabled = True
        NIFLabel1.Enabled = True

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

        If ProvedorBindingSource.Position > 0 Then
            ProvedorBindingSource.MoveFirst()
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'Me.UsuariosBindingSource.MoveFirst()
        Me.Button17.Enabled = False
        Me.Button18.Enabled = False

        If DetalleProveedorBindingSource.Position > 0 Then
            DetalleProveedorBindingSource.MoveFirst()
            Me.Button16.Enabled = True
            Me.Button8.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.UsuariosBindingSource.MovePrevious()
        If ProvedorBindingSource.Position > 0 Then
            ProvedorBindingSource.MovePrevious()
            Me.Button4.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False

        End If
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'Me.UsuariosBindingSource.MovePrevious()
        If DetalleProveedorBindingSource.Position > 0 Then
            DetalleProveedorBindingSource.MovePrevious()
            Me.Button16.Enabled = True
            Me.Button8.Enabled = True
        Else
            Me.Button18.Enabled = False
            Me.Button17.Enabled = False

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
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If DetalleProveedorBindingSource.Position < DetalleProveedorBindingSource.Count - 1 Then
            DetalleProveedorBindingSource.MoveNext()
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

        If ProvedorBindingSource.Position < ProvedorBindingSource.Count - 1 Then
            ProvedorBindingSource.MoveLast()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True

        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Me.UsuariosBindingSource.MoveLast()
        Me.Button16.Enabled = False
        Me.Button8.Enabled = False

        If DetalleProveedorBindingSource.Position < DetalleProveedorBindingSource.Count - 1 Then
            DetalleProveedorBindingSource.MoveLast()
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


        ModeloComboBox.Enabled = True
        MarcaLabel2.Enabled = True
        Precio_UnitarioTextBox.Enabled = True
        CantidadTextBox.Enabled = True
        Importe_totalTextBox.Enabled = True
        FechaLLegadaDateTimePicker.Enabled = True
        FechaPedidoDateTimePicker.Enabled = True
        DetalleProveedorDataGridView.Visible = False

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


        ModeloComboBox.Enabled = False
        MarcaLabel2.Enabled = False
        Precio_UnitarioTextBox.Enabled = False
        CantidadTextBox.Enabled = False
        Importe_totalTextBox.Enabled = False
        FechaLLegadaDateTimePicker.Enabled = False
        FechaPedidoDateTimePicker.Enabled = False
        DetalleProveedorDataGridView.Visible = True

    End Sub

    Private Sub UsuarioBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles ProvedorBindingSource.PositionChanged
        'para que en el label nos indique en que puesto de artículo nos encontramos
        Label1.Text = (ProvedorBindingSource.Position + 1) & " / " & ProvedorBindingSource.Count
    End Sub
    Private Sub DetalleVentaBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles DetalleProveedorBindingSource.PositionChanged
        Label4.Text = (DetalleProveedorBindingSource.Position + 1) & " / " & DetalleProveedorBindingSource.Count
    End Sub


    Private Sub ReparacionesDetalle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea realmente guardar cambios?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.No Then

            ElseIf DialogResult.Yes Then

                Me.Validate()

                Try
                    Me.DetalleProveedorBindingSource.EndEdit()
                    Me.DetalleProveedorTableAdapter.Update(ProyectoFinalDataSet)
                    'TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
                    ProyectoFinalDataSet.AcceptChanges()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                End Try
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
                    Me.DetalleProveedorBindingSource.EndEdit()
                    Me.DetalleProveedorTableAdapter.Update(ProyectoFinalDataSet)
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
    Private Sub ModeloComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModeloComboBox.SelectedIndexChanged
        If Me.ModeloComboBox.SelectedIndex <> -1 Then

            Dim filaArticulo As ProyectoFinalDataSet.AlmacenRow
            filaArticulo = Me.ProyectoFinalDataSet.Almacen.Rows(ModeloComboBox.SelectedIndex)

            With filaArticulo
                Me.Id_BiciLabel1.Text = .Id
                Me.MarcaLabel2.Text = .Marca
                Me.Precio_UnitarioTextBox.Text = .PrecioCoste
                Me.Label3.Text = .Cantidad

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

        If resultado = 1 Then


            'compruebo que se han introducido todos los campos necesarios

            If (MarcaLabel2.Text.Equals("") Or ModeloComboBox.Text.Equals("") Or CantidadTextBox.Text.Equals("") Or Precio_UnitarioTextBox.Text.Equals("") Or FechaPedidoDateTimePicker.Text.Equals("") Or FechaLLegadaDateTimePicker.Text.Equals("")) Then
                MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Me.MarcaLabel2.Text = "" Then
                    ErrorProvider1.SetError(MarcaLabel2, "Debe introducir la marca del articulo")
                End If
                If Me.ModeloComboBox.Text = "" Then
                    ErrorProvider1.SetError(ModeloComboBox, "Debe introducir un modelo")
                End If

                If Me.CantidadTextBox.Text = "" Then
                    ErrorProvider1.SetError(CantidadTextBox, "Debe introducir una cantidad")
                End If
                If Me.Precio_UnitarioTextBox.Text = "" Then
                    ErrorProvider1.SetError(Precio_UnitarioTextBox, "Debe existir un precio unitario")
                End If

                If Me.FechaLLegadaDateTimePicker.Text = "" Then
                    ErrorProvider1.SetError(FechaLLegadaDateTimePicker, "Debe introducir la fecha prevista de llegada")
                End If
                If Me.FechaPedidoDateTimePicker.Text = "" Then
                    ErrorProvider1.SetError(FechaPedidoDateTimePicker, "Debe introducir la fecha cuando se realizo pedido")
                End If

                'ElseIf AlmacenBindingSource.Find("Modelo", ModeloComboBox.Text) <> -1 Then

                'Dim fila As ProyectoFinalDataSet.AlmacenRow

                'fila = ProyectoFinalDataSet.Almacen.Rows(AlmacenBindingSource.Find("Modelo", ModeloComboBox.Text))

                'Dim fec As Date = Date.Today
                'Dim fac As String
                'fac = Convert.ToString(FechaLLegadaDateTimePicker.Value.ToShortDateString)
                'If fac = fec Then
                '    'hago la resta al stock total
                '    cant = Me.CantidadTextBox.Text
                '    fila.Cantidad = fila.Cantidad + cant
                '    Label3.Text = fila.Cantidad


                '    If fila.Cantidad > 20 Then
                '        MessageBox.Show("Hay bastante stock", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                '    End If
                ' End If

            Else


                precio = Convert.ToDouble(Precio_UnitarioTextBox.Text)
                cantidad = Convert.ToDouble(CantidadTextBox.Text)
                resultado1 = cantidad * precio
                Importe_totalTextBox.Text = resultado1

                ErrorProvider1.SetError(MarcaLabel2, "")
                ErrorProvider1.SetError(ModeloComboBox, "")
                ErrorProvider1.SetError(CantidadTextBox, "")

                ErrorProvider1.SetError(Precio_UnitarioTextBox, "")
                ErrorProvider1.SetError(FechaPedidoDateTimePicker, "")
                ErrorProvider1.SetError(FechaLLegadaDateTimePicker, "")
                Try



                    DetalleProveedorBindingSource.EndEdit()
                    DetalleProveedorDataGridView.Refresh()
                    deshabilitardetalle()

                    'para sumar el stock si la fecha es la de hoy
                    Dim fila As ProyectoFinalDataSet.AlmacenRow

                    fila = ProyectoFinalDataSet.Almacen.Rows(AlmacenBindingSource.Find("Modelo", ModeloComboBox.Text))

                    Dim fec As Date = Date.Today
                    Dim fac As String
                    fac = Convert.ToString(FechaLLegadaDateTimePicker.Value.ToShortDateString)
                    If fac = fec Then
                        'hago la resta al stock total
                        cant = Me.CantidadTextBox.Text
                        fila.Cantidad = fila.Cantidad + cant
                        Label3.Text = fila.Cantidad


                        If fila.Cantidad > 20 Then
                            MessageBox.Show("Hay bastante stock", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End If
                    AlmacenTableAdapter.Update(ProyectoFinalDataSet)

                Catch
                    MessageBox.Show("Introduce la fecha correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If MessageBox.Show("¿Desea cancelar la linea? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            DetalleProveedorBindingSource.CancelEdit()

            ErrorProvider1.SetError(MarcaLabel2, "")
            deshabilitardetalle()
        Else
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try

            DetalleProveedorBindingSource.AddNew()
            Label3.Text = ""
            habilitardetalle()
        Catch ex As Exception
            MessageBox.Show("Rellena anteriormente la cabecera y/o el detalle", Me.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If MessageBox.Show("¿Seguro de que desea eliminar este pedido?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

        Else
            Try
                Me.DetalleProveedorBindingSource.RemoveCurrent()
            Catch
                MessageBox.Show("No hay mas pedidos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        deshabilitardetalle()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'para guardar en la base de datos
        Try
            Me.DetalleProveedorBindingSource.EndEdit()
            Me.DetalleProveedorTableAdapter.Update(ProyectoFinalDataSet)

            ' Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
            ProyectoFinalDataSet.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End Try
    End Sub





    Private Sub ProveedorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProveedorComboBox.SelectedIndexChanged
        If Me.ProveedorComboBox.SelectedIndex <> -1 Then

            Dim filaProveedor As ProyectoFinalDataSet.ProvedorRow
            filaProveedor = Me.ProyectoFinalDataSet.Provedor.Rows(ProveedorComboBox.SelectedIndex)

            With filaProveedor
                Me.IdProveedor1.Text = .Id
                Me.NombreLabel2.Text = .Nombre
                Me.DireccionLabel2.Text = .Direccion

                Me.NacionalidadLabel1.Text = .Nacionalidad
                Me.WebLabel1.Text = .Web
                Me.E_MailLabel1.Text = .EMail
                Me.CodigoPostalLabel1.Text = .CodigoPostal
                Me.NIFLabel1.Text = .NIF
                Me.ContactoLabel1.Text = .Contacto

            End With
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReportePedidoProveedor.Show()
    End Sub
End Class