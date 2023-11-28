Imports System.ComponentModel

Public Class Almacen
    'Private Sub AlmacenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.AlmacenBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

    'End Sub

    Private Sub Almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ProyectoFinalDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ProyectoFinalDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.ProyectoFinalDataSet.Almacen)

        'activo y desactivo los controles disponibles nada mas acceder a la pantalla
        IdLabel2.Enabled = False
        MarcaComboBox.Enabled = False
        ModeloTextBox.Enabled = False
        EspecificacionesTextBox.Enabled = False
        PrecioTextBox.Enabled = False
        PrecioCosteTextBox.Enabled = False
        ImagenPictureBox.Enabled = False
        CantidadTextBox.Enabled = False
        Button9.Enabled = True
        Button11.Enabled = True
        Button5.Visible = False
        Button5.Enabled = False
        Button7.Visible = False
        Button7.Enabled = False
        Label2.Visible = False
        Label3.Visible = False

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Button2.Enabled = False
        Me.Button1.Enabled = False

        If AlmacenBindingSource.Position > 0 Then
            AlmacenBindingSource.MoveFirst()
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If AlmacenBindingSource.Position > 0 Then
            AlmacenBindingSource.MovePrevious()
            Me.Button4.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If AlmacenBindingSource.Position < AlmacenBindingSource.Count - 1 Then
            AlmacenBindingSource.MoveNext()
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

        If AlmacenBindingSource.Position < AlmacenBindingSource.Count - 1 Then
            AlmacenBindingSource.MoveLast()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True

        End If
    End Sub
    Private Sub activarControles()
        'activo los controles de interaccion
        Me.MarcaComboBox.Enabled = True
        Me.ModeloTextBox.Enabled = True
        Me.PrecioTextBox.Enabled = True
        Me.EspecificacionesTextBox.Enabled = True
        Me.ImagenPictureBox.Enabled = True
        Me.CantidadTextBox.Enabled = True
        PrecioCosteTextBox.Enabled = True
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
        GroupBox1.Enabled = False

    End Sub

    Private Sub desactivarControles()
        'desactivo los controles de interaccion
        Me.MarcaComboBox.Enabled = False
        Me.ModeloTextBox.Enabled = False
        Me.PrecioTextBox.Enabled = False
        Me.EspecificacionesTextBox.Enabled = False
        Me.ImagenPictureBox.Enabled = False
        Me.CantidadTextBox.Enabled = False
        PrecioCosteTextBox.Enabled = False
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
        GroupBox1.Enabled = True
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        activarControles()
        'añado una nueva
        Me.AlmacenBindingSource.AddNew()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'elimino un articulo
        Try
            If MessageBox.Show("Seguro de que desea eliminar este artículo", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

            Else
                Me.AlmacenBindingSource.RemoveCurrent()
            End If
        Catch
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Try

            'compruebo que se han introducido todos los campos necesarios
            If (MarcaComboBox.Text.Equals("") Or ModeloTextBox.Text.Equals("") Or PrecioTextBox.Text.Equals("") Or EspecificacionesTextBox.Text.Equals("")) Then
                MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                'If Me.MarcaComboBox.Text <> Ma.text Then

                '    ErrorProvider1.SetError(MarcaComboBox, "Debe introducir una marca correcta")
                'End If
                If Me.MarcaComboBox.Text = "" Then
                    MessageBox.Show("Debe seleccionar una marca", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ErrorProvider1.SetError(MarcaComboBox, "Debe introducir una marca")
                End If
                If Me.PrecioTextBox.Text = "" Then
                    ErrorProvider1.SetError(PrecioTextBox, "Debe introducir un precio")
                End If
                If Me.CantidadTextBox.Text = "" Then
                    ErrorProvider1.SetError(CantidadTextBox, "Debe introducir una cantidad")
                End If

                If Me.ModeloTextBox.Text = "" Then
                    ErrorProvider1.SetError(ModeloTextBox, "Debe introducir un modelo")
                End If
                If Me.EspecificacionesTextBox.Text = "" Then
                    ErrorProvider1.SetError(EspecificacionesTextBox, "Debe introducir unas especificaciones")
                End If

            Else
                'finalizo la edicion
                Me.AlmacenBindingSource.EndEdit()
                desactivarControles()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cancelo la edicion
        Me.AlmacenBindingSource.CancelEdit()

        ErrorProvider1.SetError(MarcaComboBox, "")
        ErrorProvider1.SetError(ModeloTextBox, "")
        ErrorProvider1.SetError(EspecificacionesTextBox, "")
        ErrorProvider1.SetError(ImagenPictureBox, "")
        ErrorProvider1.SetError(CantidadTextBox, "")
        ErrorProvider1.SetError(PrecioTextBox, "")

        desactivarControles()


    End Sub

    Private Sub ImagenPictureBox_Click(sender As Object, e As EventArgs) Handles ImagenPictureBox.Click
        'abro una ventana para seleccionar una imagen
        OpenFileDialog1.Filter = "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ImagenPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            ImagenPictureBox.Image = Nothing
        End If
    End Sub


    'pongo los errores en blanco cuando se haya validado que estan correctos
    Private Sub MarcaTextBox_TextChanged(sender As Object, e As EventArgs) Handles MarcaComboBox.Validating
        If Me.MarcaComboBox.Text <> ("") Then
            ErrorProvider1.SetError(MarcaComboBox, "")
        End If
    End Sub

    Private Sub ModeloTextBox_TextChanged(sender As Object, e As EventArgs) Handles ModeloTextBox.Validating
        If Me.ModeloTextBox.Text <> ("") Then
            ErrorProvider1.SetError(ModeloTextBox, "")
        End If
    End Sub
    Private Sub PrecioTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrecioTextBox.Validating
        If Me.PrecioTextBox.Text <> ("") Then
            ErrorProvider1.SetError(PrecioTextBox, "")
        End If
    End Sub

    Private Sub ImagenPictureBox_TextChanged(sender As Object, e As EventArgs) Handles ImagenPictureBox.Validating
        If Me.ImagenPictureBox.Text <> ("") Then
            ErrorProvider1.SetError(ImagenPictureBox, "")
        End If
    End Sub
    Private Sub CantidadTextBox_TextChanged(sender As Object, e As EventArgs) Handles CantidadTextBox.Validating
        If Me.CantidadTextBox.Text <> ("") Then
            ErrorProvider1.SetError(CantidadTextBox, "")
        End If
    End Sub

    Private Sub EspecificacionesTextBox_TextChanged(sender As Object, e As EventArgs) Handles EspecificacionesTextBox.Validating
        If Me.EspecificacionesTextBox.Text <> ("") Then
            ErrorProvider1.SetError(EspecificacionesTextBox, "")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'para guardar en la base de datos
        Try
            Me.AlmacenBindingSource.EndEdit()
            Me.AlmacenTableAdapter.Update(ProyectoFinalDataSet)

            Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
            ProyectoFinalDataSet.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If MessageBox.Show("No se pudo guardar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            End If
        End Try
    End Sub
    Private Sub AlmacenBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles AlmacenBindingSource.PositionChanged
        'para que en el label nos indique en que puesto de artículo nos encontramos
        Label1.Text = (AlmacenBindingSource.Position + 1) & " / " & AlmacenBindingSource.Count
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'para modificar el articulo
        activarControles()

    End Sub

    Private Sub Almacen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'para guardar los cambios antes de cerrar la aplicación
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea realmente guardar cambios?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.No Then

            ElseIf DialogResult.Yes Then
                Me.Validate()
                Me.AlmacenBindingSource.EndEdit()
                Try
                    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)
                Catch ex As Exception

                End Try

            ElseIf DialogResult = DialogResult.Cancel Then
                e.Cancel = True

            End If
        End If
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
                    Me.AlmacenBindingSource.EndEdit()
                    Me.AlmacenTableAdapter.Update(ProyectoFinalDataSet)
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

    Private Sub PrecioCosteLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrecioCosteTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrecioCosteTextBox.TextChanged

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            If ComboBuscar.Text = "ID" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = AlmacenBindingSource.Find("Id", busqueda)) Then
                    MessageBox.Show("No hay articulos con ese ID", "Buscar")
                Else
                    AlmacenBindingSource.Position = AlmacenBindingSource.Find("Id", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If

            If ComboBuscar.Text = "Modelo" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = AlmacenBindingSource.Find("Modelo", busqueda)) Then
                    MessageBox.Show("No hay articulos con ese modelo", "Buscar")
                Else
                    AlmacenBindingSource.Position = AlmacenBindingSource.Find("Modelo", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If
        Catch
        End Try

    End Sub
End Class
