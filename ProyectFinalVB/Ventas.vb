Imports System.ComponentModel

Public Class Ventas
    'Private Sub VentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.VentasBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

    'End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ProyectoFinalDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
        Me.DetalleVentaTableAdapter.Fill(Me.ProyectoFinalDataSet.DetalleVenta)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.ProyectoFinalDataSet.Almacen)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.ProyectoFinalDataSet.Almacen)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
        Me.DetalleVentaTableAdapter.Fill(Me.ProyectoFinalDataSet.DetalleVenta)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.ProyectoFinalDataSet.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ProyectoFinalDataSet.Ventas)


        'activo y desactivo los controles disponibles nada mas acceder a la pantalla
        IdLabel1.Enabled = False
        desactivarControles()
        deshabilitardetalle()
        DetalleVentaDataGridView.Enabled = False
    End Sub
    Private Sub activarControles()
        'activo los controles de interaccion
        UsuarioComboBox.Enabled = True
        NombreLabel1.Enabled = True
        ApellidosLabel1.Enabled = True
        TelefonoTextBox.Enabled = True

        LocalidadTextBox.Enabled = True
        CalleTextBox.Enabled = True
        PortalTextBox.Enabled = True
        PisoTextBox.Enabled = True
        LetraPisoTextBox.Enabled = True
        Fecha_VentaDateTimePicker.Enabled = True
        ProvinciaTextBox.Enabled = True

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
        'Me.Button12.Enabled = False
        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        Me.Button4.Enabled = False
        Button13.Enabled = False
        'los hago no visibles los controles principales
        Me.Button6.Visible = False
        Button13.Visible = False
        Me.Button9.Visible = False
        Me.Button11.Visible = False
        'Me.Button12.Visible = False
        Me.Button1.Visible = False
        Me.Button2.Visible = False
        Me.Button3.Visible = False
        Me.Button4.Visible = False
        Label4.Visible = False

    End Sub
    Private Sub desactivarControlesPrincipal()
        Me.Button6.Enabled = False
        Me.Button9.Enabled = False
        Me.Button11.Enabled = False
        'Me.Button12.Enabled = False
        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        Me.Button4.Enabled = False
        Button13.Enabled = False

    End Sub
    Private Sub activarControlesPrincipal()
        Me.Button6.Enabled = True
        Me.Button9.Enabled = True
        Me.Button11.Enabled = True
        'Me.Button12.Enabled = True
        Me.Button1.Enabled = True
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
        Me.Button4.Enabled = True
        Button13.Enabled = True

    End Sub

    Private Sub desactivarControles()
        'desactivo los controles de interaccion
        UsuarioComboBox.Enabled = False
        NombreLabel1.Enabled = False
        ApellidosLabel1.Enabled = False
        TelefonoTextBox.Enabled = False

        LocalidadTextBox.Enabled = False
        CalleTextBox.Enabled = False
        PortalTextBox.Enabled = False
        PisoTextBox.Enabled = False
        LetraPisoTextBox.Enabled = False
        Fecha_VentaDateTimePicker.Enabled = False
        ProvinciaTextBox.Enabled = False

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
        'Me.Button12.Enabled = True
        Me.Button1.Enabled = True
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
        Me.Button4.Enabled = True
        Button13.Enabled = True
        'los hago visibles los controles principales
        Me.Button6.Visible = True
        Button13.Visible = True
        Me.Button9.Visible = True
        Me.Button11.Visible = True
        'Me.Button12.Visible = True
        Me.Button1.Visible = True
        Me.Button2.Visible = True
        Me.Button3.Visible = True
        Me.Button4.Visible = True
        Label4.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.UsuariosBindingSource.MoveFirst()
        Me.Button2.Enabled = False
        Me.Button1.Enabled = False

        If VentasBindingSource.Position > 0 Then
            VentasBindingSource.MoveFirst()
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'Me.UsuariosBindingSource.MoveFirst()
        Me.Button17.Enabled = False
        Me.Button18.Enabled = False

        If DetalleVentaBindingSource.Position > 0 Then
            DetalleVentaBindingSource.MoveFirst()
            Me.Button16.Enabled = True
            Me.Button8.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.UsuariosBindingSource.MovePrevious()
        If VentasBindingSource.Position > 0 Then
            VentasBindingSource.MovePrevious()
            Me.Button4.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False

        End If
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'Me.UsuariosBindingSource.MovePrevious()
        If DetalleVentaBindingSource.Position > 0 Then
            DetalleVentaBindingSource.MovePrevious()
            Me.Button16.Enabled = True
            Me.Button8.Enabled = True
        Else
            Me.Button18.Enabled = False
            Me.Button17.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If VentasBindingSource.Position < VentasBindingSource.Count - 1 Then
            VentasBindingSource.MoveNext()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True
        Else
            Me.Button4.Enabled = False
            Me.Button3.Enabled = False

        End If
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If DetalleVentaBindingSource.Position < DetalleVentaBindingSource.Count - 1 Then
            DetalleVentaBindingSource.MoveNext()
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

        If VentasBindingSource.Position < VentasBindingSource.Count - 1 Then
            VentasBindingSource.MoveLast()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True

        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Me.UsuariosBindingSource.MoveLast()
        Me.Button16.Enabled = False
        Me.Button8.Enabled = False

        If DetalleVentaBindingSource.Position < DetalleVentaBindingSource.Count - 1 Then
            DetalleVentaBindingSource.MoveLast()
            Me.Button17.Enabled = True
            Me.Button18.Enabled = True

        End If
    End Sub
    Private Sub ocultardetalle()
        Button18.Visible = False
        Button17.Visible = False
        Button16.Visible = False
        Button8.Visible = False
        Button19.Visible = False
        Button10.Visible = False
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'añado una nueva
        Me.VentasBindingSource.AddNew()

        activarControles()


        'desactivo los botones de interaccion del del detalle para que no haya confusiones
        ocultardetalle()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'elimino un articulo
        If MessageBox.Show("Seguro de que desea eliminar esta venta", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

        Else
            Try
                If (DetalleVentaBindingSource.Count > 0) Then
                    If MessageBox.Show("Se van a eliminar todas las lineas del detalle de la venta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                        While (DetalleVentaBindingSource.Count > 0)
                            Me.DetalleVentaBindingSource.RemoveCurrent()
                        End While


                    End If
                End If








                Me.VentasBindingSource.RemoveCurrent()
            Catch ex As Exception
                MessageBox.Show("No hay mas ventas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try


        End If
    End Sub
    Sub habilitardetalle()

        Button5.Enabled = False
        Button7.Enabled = False
        Button5.Visible = False
        Button7.Visible = False
        Label5.Visible = True
        ' Button13.Visible = True   'para el informe

        Label2.Visible = False
        Label3.Visible = False

        Button14.Visible = True
        Button14.Enabled = True
        Button15.Visible = True
        Button15.Enabled = True
        Label6.Visible = True
        Label5.Visible = True

        Button8.Visible = True
        Button8.Enabled = False
        Button16.Visible = True
        Button16.Enabled = False
        Button17.Visible = True
        Button17.Enabled = False
        Button19.Visible = True
        Button19.Enabled = False
        Button10.Visible = True
        Button10.Enabled = False
        Button8.Enabled = False
        Button8.Visible = True
        Button18.Visible = True
        Button18.Enabled = False
        Label4.Visible = True


        Button1.Visible = True
        Button1.Enabled = True
        Button6.Visible = True
        Button6.Enabled = True
        Button2.Visible = True
        Button2.Enabled = True
        Button3.Visible = True
        Button3.Enabled = True
        Button9.Enabled = True
        Button9.Visible = True
        Button4.Visible = True
        Button4.Enabled = True
        Button11.Visible = True
        Button11.Enabled = True

        BiciLabel2.Enabled = True
        ModeloComboBox.Enabled = True
        Precio_UnitarioTextBox.Enabled = True
        CantidadTextBox.Enabled = True
        Importe_totalTextBox.Enabled = True
        Label7.Enabled = True

    End Sub

    Sub deshabilitardetalle()

        Button1.Enabled = True
        Button1.Visible = True
        Label5.Visible = True
        'Button13.Visible = True    'para el informe
        Button11.Enabled = True
        Button11.Visible = True
        Button2.Enabled = True
        Button2.Visible = True
        Button8.Visible = True
        Button8.Enabled = True
        Button10.Enabled = True
        Button10.Visible = True
        Button16.Visible = True
        Button16.Enabled = True
        Button17.Visible = True
        Button17.Enabled = True
        Button19.Visible = True
        Button19.Enabled = True
        Button8.Enabled = True
        Button8.Visible = True
        Button18.Visible = True
        Button18.Enabled = True
        Button3.Enabled = True
        Button3.Visible = True
        Button4.Enabled = True
        Button4.Visible = True
        Button6.Enabled = True
        Button6.Visible = True
        Button9.Enabled = True
        Button9.Visible = True
        Button14.Enabled = False
        Button14.Visible = False
        'Button8.Visible = False
        'Button8.Enabled = False
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


        BiciLabel2.Enabled = False
        ModeloComboBox.Enabled = False
        Precio_UnitarioTextBox.Enabled = False
        CantidadTextBox.Enabled = False
        Importe_totalTextBox.Enabled = False
        Label7.Enabled = False

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '------------------------Hacer lo de poner visible el detalle
        Dim resultado As Integer
        resultado = MessageBox.Show("¿Desea finalizar la cabecera?", "Aceptar", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Information)
        Try
            If resultado = 1 Then

                'compruebo que se han introducido todos los campos necesarios

                If (UsuarioComboBox.Text.Equals("") Or TelefonoTextBox.Text.Equals("") Or LocalidadTextBox.Text.Equals("") Or CalleTextBox.Text.Equals("") Or PisoTextBox.Text.Equals("")) Then
                    MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    If Me.UsuarioComboBox.Text = "" Then
                        ErrorProvider1.SetError(UsuarioComboBox, "Debe introducir el nombre del usuario")
                    End If

                    If Me.TelefonoTextBox.Text = "" Then
                        ErrorProvider1.SetError(TelefonoTextBox, "Debe introducir un numero de telefono")
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

                    'habilitamos el detalle para añadir ventas


                Else
                    'finalizo la edicion
                    Me.VentasBindingSource.EndEdit()

                    desactivarControles()

                    'activo los botones de interaccion del del detalle que los desactive antes
                    Button18.Visible = True
                    Button17.Visible = True
                    Button16.Visible = True
                    Button8.Visible = True
                    Button19.Visible = True
                    Button10.Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cancelo la edicion
        Me.VentasBindingSource.CancelEdit()

        ErrorProvider1.SetError(UsuarioComboBox, "")


        ErrorProvider1.SetError(TelefonoTextBox, "")
        ErrorProvider1.SetError(LocalidadTextBox, "")
        ErrorProvider1.SetError(CalleTextBox, "")
        ErrorProvider1.SetError(PisoTextBox, "")


        desactivarControles()
        deshabilitardetalle()


    End Sub




    'pongo los errores en blanco cuando se haya validado que estan correctos
    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsuarioComboBox.Validating
        If Me.UsuarioComboBox.Text <> ("") Then
            ErrorProvider1.SetError(UsuarioComboBox, "")
        End If
    End Sub

    Private Sub CodigoPostalTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelefonoTextBox.Validating
        If Me.TelefonoTextBox.Text <> ("") Then
            ErrorProvider1.SetError(TelefonoTextBox, "")
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



            Me.VentasBindingSource.EndEdit()
            Me.VentasTableAdapter.Update(ProyectoFinalDataSet)

            Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
            Me.DetalleVentaTableAdapter.Update(ProyectoFinalDataSet.DetalleVenta)

            ProyectoFinalDataSet.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If MessageBox.Show("No se pudo guardar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            End If
        End Try
    End Sub
    Private Sub UsuarioBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles VentasBindingSource.PositionChanged
        'para que en el label nos indique en que puesto de artículo nos encontramos
        Label1.Text = (VentasBindingSource.Position + 1) & " / " & VentasBindingSource.Count
    End Sub
    Private Sub DetalleVentaBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles DetalleVentaBindingSource.PositionChanged
        Label4.Text = (DetalleVentaBindingSource.Position + 1) & " / " & DetalleVentaBindingSource.Count
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs)
        'para modificar el articulo
        activarControles()
        ocultardetalle()


    End Sub

    Private Sub Ventas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea realmente guardar cambios?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.No Then

            ElseIf DialogResult.Yes Then
                Me.Validate()
                Me.VentasBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)
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
                    Me.VentasBindingSource.EndEdit()
                    Me.VentasTableAdapter.Update(ProyectoFinalDataSet)
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

    'para cargar los datos del usuario en esta vista
    Private Sub UsuarioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsuarioComboBox.SelectedIndexChanged
        If Me.UsuarioComboBox.SelectedIndex <> -1 Then

            Dim cliente As ProyectoFinalDataSet.ClientesRow
            cliente = Me.ProyectoFinalDataSet.Clientes.Rows(UsuarioComboBox.SelectedIndex)

            With cliente
                Me.NombreLabel1.Text = .Nombre
                Me.ApellidosLabel1.Text = .Apellido
                Me.TelefonoTextBox.Text = .Numero_telefono
                Me.ProvinciaTextBox.Text = .Provincia

                Me.LocalidadTextBox.Text = .Localidad
                Me.CalleTextBox.Text = .Calle
                Me.PisoTextBox.Text = .Piso
                Me.PortalTextBox.Text = .Portal
                Me.LetraPisoTextBox.Text = .LetraPiso

                'para que nos escriba en blanco si no dispone de portal ni letra ya que si no da error
                'If String.IsNullOrEmpty(PortalTextBox.Text = .Portal) Then
                '    Me.PortalTextBox.Text = ""
                'End If




                'If Me.UsuarioComboBox.SelectedIndex <> 0 Then
                '    Me.LetraPisoTextBox.Text = .LetraPiso
                'Else
                '    Me.LetraPisoTextBox.Text = ""
                'End If




            End With
        End If
    End Sub

    'para cargar los datos del articulo en esta vista
    Private Sub BiciComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModeloComboBox.SelectedIndexChanged
        Dim porcen As Double
        If Me.ModeloComboBox.SelectedIndex <> -1 Then

            Dim filaArticulo As ProyectoFinalDataSet.AlmacenRow
            filaArticulo = Me.ProyectoFinalDataSet.Almacen.Rows(ModeloComboBox.SelectedIndex)

            With filaArticulo
                porcen = (.PrecioCoste * .PVP) / 100
                Me.Id_BiciLabel3.Text = .Id
                Me.BiciLabel2.Text = .Marca
                Me.Precio_UnitarioTextBox.Text = .PrecioCoste + porcen
                Me.Label7.Text = .Cantidad





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

            ' Try
            'compruebo que se han introducido todos los campos necesarios

            If (BiciLabel2.Text.Equals("") Or ModeloComboBox.Text.Equals("") Or CantidadTextBox.Text.Equals("") Or Precio_UnitarioTextBox.Text.Equals("")) Then
                MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Me.BiciLabel2.Text = "" Then
                    ErrorProvider1.SetError(BiciLabel2, "Debe introducir la marca del articulo")
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


                'compruebo que no venda mas de los que tengo en stock
            ElseIf AlmacenBindingSource.Find("Modelo", ModeloComboBox.Text) <> -1 Then
                Dim fila As ProyectoFinalDataSet.AlmacenRow
                fila = ProyectoFinalDataSet.Almacen.Rows(AlmacenBindingSource.Find("Modelo", ModeloComboBox.Text))

                If fila.Cantidad < CantidadTextBox.Text Then

                    MessageBox.Show("La cantidad es mayor a la existente en stock", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ErrorProvider1.SetError(CantidadTextBox, "La cantidad es mayor a la existente en stock")
                Else

                    'If DetalleVentaBindingSource.Find("Modelo", ModeloComboBox.Text) <> -1 Then
                    '    Dim fila2 As ProyectoFinalDataSet.DetalleVentaRow
                    '    fila2 = ProyectoFinalDataSet.DetalleVenta.Rows(DetalleVentaBindingSource.Find("Modelo", ModeloComboBox.Text))
                    '    If fila2.Modelo = ModeloComboBox.Text Then




                    precio = Convert.ToDouble(Precio_UnitarioTextBox.Text)
                    cantidad = Convert.ToDouble(CantidadTextBox.Text)

                    resultado1 = cantidad * precio
                    Importe_totalTextBox.Text = resultado1




                    ' Try

                    ErrorProvider1.SetError(BiciLabel2, "")
                    ErrorProvider1.SetError(ModeloComboBox, "")
                    ErrorProvider1.SetError(CantidadTextBox, "")
                    ErrorProvider1.SetError(Importe_totalTextBox, "")
                    ErrorProvider1.SetError(Precio_UnitarioTextBox, "")



                    Try

                        DetalleVentaBindingSource.EndEdit()
                        DetalleVentaDataGridView.Refresh()
                        deshabilitardetalle()
                        activarControlesPrincipal()
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


                    Catch ex As Exception
                        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
                    End Try



                End If

            End If

        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If MessageBox.Show("¿Desea cancelar la linea? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            ErrorProvider1.SetError(BiciLabel2, "")
            ErrorProvider1.SetError(ModeloComboBox, "")
            ErrorProvider1.SetError(CantidadTextBox, "")
            ErrorProvider1.SetError(Importe_totalTextBox, "")
            ErrorProvider1.SetError(Precio_UnitarioTextBox, "")

            DetalleVentaBindingSource.CancelEdit()

            activarControlesPrincipal()
            deshabilitardetalle()
        Else
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            DetalleVentaBindingSource.AddNew()
            habilitardetalle()
            desactivarControlesPrincipal()
        Catch ex As Exception
            MessageBox.Show("Rellena anteriormente la cabecera y/o el detalle", Me.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If MessageBox.Show("Seguro de que desea eliminar esta venta", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

        Else
            Try
                Me.DetalleVentaBindingSource.RemoveCurrent()
            Catch
                MessageBox.Show("No hay mas ventas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        deshabilitardetalle()
    End Sub

    Private Sub NIFTextBox_TextChanged(sender As Object, e As CancelEventArgs) Handles PisoTextBox.Validating

    End Sub

    Private Sub ContactoTextBox_TextChanged(sender As Object, e As CancelEventArgs) Handles CalleTextBox.Validating

    End Sub

    Private Sub WebTextBox_TextChanged(sender As Object, e As CancelEventArgs) Handles LocalidadTextBox.Validating

    End Sub

    Private Sub CodigoPostalTextBox_TextChanged(sender As Object, e As CancelEventArgs) Handles TelefonoTextBox.Validating

    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As CancelEventArgs) Handles UsuarioComboBox.Validating

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ReporteVentas.Show()
    End Sub

    Private Sub DetalleVentaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DetalleVentaDataGridView.CellContentClick

    End Sub
End Class