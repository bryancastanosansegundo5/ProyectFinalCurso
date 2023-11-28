Public Class login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''Dim fila As VentaBicisBryanDataSet.UsuariosRow
        ''If (UsuariosBindingSource.Find("Nombre", Nombre_UsuarioTextBox.Text()) <> -1) Then
        ''    fila = VentaBicisBryanDataSet.Usuarios.Rows(UsuariosBindingSource.Find("Nombre", Nombre_UsuarioTextBox.Text))
        ''    If fila.Contraseña = ContraseñaTextBox.Text() Then

        ''        If fila.Permisos = "Admin" Then
        ''            'WindowsApplication1.Principal.Label9.Text = Nombre_UsuarioTextBox.Text
        ''            My.Settings.Rol = "Admin"
        ''            'WindowsApplication1.Principal.
        ''            'MainCasino.Form1.Button11.Visible = True



        ''            Principal.Show()
        ''            Me.Hide()
        ''            Nombre_UsuarioTextBox.Text = ""
        ''            ContraseñaTextBox.Text = ""

        ''        End If
        ''        If fila.Permisos = "Currito" Then
        ''            'MainCasino.Form1.Label9.Text = Nombre_loginTextBox.Text
        ''            My.Settings.Rol = "Currito"

        ''            Principal.Show()
        ''            Me.Hide()
        ''            Nombre_UsuarioTextBox.Text = ""
        ''            ContraseñaTextBox.Text = ""
        ''        End If

        ''    End If
        If Nombre_UsuarioTextBox.Text = "" Or ContraseñaTextBox.Text = "" Then
            MessageBox.Show("Introduzca datos de acceso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        Dim fila As ProyectoFinalDataSet.UsuarioRow

        If UsuarioBindingSource.Find("NombreUsuario", Nombre_UsuarioTextBox.Text) <> -1 Then
            fila = ProyectoFinalDataSet.Usuario.Rows(UsuarioBindingSource.Find("NombreUsuario", Nombre_UsuarioTextBox.Text))

            If fila.Contraseña = ContraseñaTextBox.Text Then
                'Administrador
                If fila.Permisos = "Admin" Then

                    My.Settings.Permisos = "Admin"

                    Me.Visible = False

                    Principal.Show()



                    'Empleado
                ElseIf fila.Permisos = "Empleado" Then
                    My.Settings.Permisos = "Empleado"

                    Me.Visible = False

                    'deshabilito el boton
                    PrincipalReparacion.Button1.Enabled = False
                    PrincipalUsuarios.Button3.Enabled = False
                    'deshabilito los tooltip
                    PrincipalReparacion.ReparacionesARealizarToolStripMenuItem.Enabled = False
                    Principal.ReparacionesARealizarToolStripMenuItem.Enabled = False
                    PrincipalAlmacen.ReparacionesARealizarToolStripMenuItem.Enabled = False
                    PrincipalUsuarios.ReparacionesARealizarToolStripMenuItem.Enabled = False

                    Principal.UsuariosDeLaAplicaciónToolStripMenuItem.Enabled = False
                    PrincipalAlmacen.UsuariosDeLaAplicaciónToolStripMenuItem.Enabled = False
                    PrincipalReparacion.UsuariosDeLaAplicaciónToolStripMenuItem.Enabled = False
                    PrincipalUsuarios.UsuariosDeLaAplicaciónToolStripMenuItem.Enabled = False

                    Principal.Show()

                    'Mecánico
                ElseIf fila.Permisos = "Mecanico" Then

                    My.Settings.Permisos = "Mecanico"

                    Me.Visible = False

                    'deshabilito los botones
                    Principal.Button8.Enabled = False
                    PrincipalAlmacen.Button2.Enabled = False
                    Principal.Button3.Enabled = False

                    'deshabilito los toolstrip
                    Principal.ToolStripDropDownButton1.Enabled = False
                    PrincipalAlmacen.ToolStripDropDownButton1.Enabled = False
                    PrincipalReparacion.ToolStripDropDownButton1.Enabled = False

                    Principal.MarcasToolStripMenuItem.Enabled = False
                    PrincipalAlmacen.MarcasToolStripMenuItem.Enabled = False
                    PrincipalReparacion.MarcasToolStripMenuItem.Enabled = False

                    Principal.ToolStripButton1.Enabled = False
                    PrincipalAlmacen.ToolStripButton1.Enabled = False
                    PrincipalReparacion.ToolStripButton1.Enabled = False


                    Principal.Show()


                End If

            End If

        Else
            MessageBox.Show("Usuario o contraseña incorrecto/a.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        ''End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Borramos el texto
        Nombre_UsuarioTextBox.Text = ""
        ContraseñaTextBox.Text = ""
        Me.Close()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoFinalDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.ProyectoFinalDataSet.Usuario)

        'Borramos el texto de acceso
        Nombre_UsuarioTextBox.Text = ""
        ContraseñaTextBox.Text = ""
    End Sub


    'Private Sub Login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    Dim opcionEscogida As DialogResult = MsgBox("¿Quieres cerrar el programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cerrar GestPC")
    '    If opcionEscogida = DialogResult.Yes Then
    '    Else
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub ContraseñaTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles ContraseñaTextBox.KeyUp
        'Al pulsar INTRO pulsa el boton Aceptar
        If e.KeyCode = 13 Then
            Button1.PerformClick()
            'Call Button1AceptarLogin_Click(sender, e)
        End If
    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoFinalDataSet)

    End Sub
End Class