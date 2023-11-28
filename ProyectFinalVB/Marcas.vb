Imports System.ComponentModel

Public Class Marcas
    'Private Sub MarcasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.MarcasBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

    'End Sub

    Private Sub Marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ProyectoFinalDataSet.Marcas)
        'activo y desactivo los controles disponibles nada mas acceder a la pantalla
        IdLabel2.Enabled = False
        MarcaTextBox.Enabled = False

        Button9.Enabled = True
        Button11.Enabled = True
        Button5.Visible = False
        Button5.Enabled = False
        Button7.Visible = False
        Button7.Enabled = False
        Label2.Visible = False
        Label3.Visible = False
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Button2.Enabled = False
        Me.Button1.Enabled = False

        If MarcasBindingSource.Position > 0 Then
            MarcasBindingSource.MoveFirst()
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MarcasBindingSource.Position > 0 Then
            MarcasBindingSource.MovePrevious()
            Me.Button4.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MarcasBindingSource.Position < MarcasBindingSource.Count - 1 Then
            MarcasBindingSource.MoveNext()
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

        If MarcasBindingSource.Position < MarcasBindingSource.Count - 1 Then
            MarcasBindingSource.MoveLast()
            Me.Button2.Enabled = True
            Me.Button1.Enabled = True

        End If
    End Sub
    Private Sub activarControles()
        'activo los controles de interaccion
        Me.MarcaTextBox.Enabled = True

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
        Me.MarcaTextBox.Enabled = False

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
        Me.MarcasBindingSource.AddNew()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'elimino un articulo
        Try
            If MessageBox.Show("Seguro de que desea eliminar esta marca", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

            Else
                Me.MarcasBindingSource.RemoveCurrent()
            End If
        Catch
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'compruebo que se han introducido todos los campos necesarios
        Try
            If (MarcaTextBox.Text.Equals("")) Then
                MessageBox.Show("Debe introducir todos los datos obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Me.MarcaTextBox.Text = "" Then
                    ErrorProvider1.SetError(MarcaTextBox, "Debe introducir una marca")
                End If



            Else
                'finalizo la edicion
                Me.MarcasBindingSource.EndEdit()
                desactivarControles()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cancelo la edicion
        Me.MarcasBindingSource.CancelEdit()

        ErrorProvider1.SetError(MarcaTextBox, "")


        desactivarControles()


    End Sub




    'pongo los errores en blanco cuando se haya validado que estan correctos
    Private Sub MarcaTextBox_TextChanged(sender As Object, e As EventArgs) Handles MarcaTextBox.Validating
        If Me.MarcaTextBox.Text <> ("") Then
            ErrorProvider1.SetError(MarcaTextBox, "")
        End If
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'para guardar en la base de datos
        Try
            Me.MarcasBindingSource.EndEdit()
            Me.MarcasTableAdapter.Update(ProyectoFinalDataSet)

            Me.TableAdapterManager.UpdateAll(ProyectoFinalDataSet)
            ProyectoFinalDataSet.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If MessageBox.Show("No se pudo guardar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            End If
        End Try
    End Sub
    Private Sub AlmacenBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles MarcasBindingSource.PositionChanged
        'para que en el label nos indique en que puesto de artículo nos encontramos
        Label1.Text = (MarcasBindingSource.Position + 1) & " / " & MarcasBindingSource.Count
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
                    Me.MarcasBindingSource.EndEdit()
                    Me.MarcasTableAdapter.Update(ProyectoFinalDataSet)
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

    Private Sub Marcas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'para guardar los cambios antes de cerrar la aplicación
        If Not ProyectoFinalDataSet.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea realmente guardar cambios?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.No Then

            ElseIf DialogResult.Yes Then
                Me.Validate()
                Me.MarcasBindingSource.EndEdit()
                Try
                    Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)
                Catch ex As Exception

                End Try

            ElseIf DialogResult = DialogResult.Cancel Then
                e.Cancel = True

            End If
        End If
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            If ComboBuscar.Text = "ID" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = MarcasBindingSource.Find("Id", busqueda)) Then
                    MessageBox.Show("No hay marcas con ese ID", "Buscar")
                Else
                    MarcasBindingSource.Position = MarcasBindingSource.Find("Id", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If

            If ComboBuscar.Text = "Marca" Then
                Dim busqueda As String
                busqueda = BuscarTxt.Text
                'Convert.ToInt64(busqueda)
                If (-1 = MarcasBindingSource.Find("Marca", busqueda)) Then
                    MessageBox.Show("No hay marcas con ese nombre", "Buscar")
                Else
                    MarcasBindingSource.Position = MarcasBindingSource.Find("MArca", busqueda)
                    BuscarTxt.Text = ""
                End If
            End If
        Catch
        End Try
    End Sub
End Class