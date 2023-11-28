<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreUsuarioLabel As System.Windows.Forms.Label
        Dim PermisosLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim Numero_telefonoLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim PortalLabel As System.Windows.Forms.Label
        Dim PisoLabel As System.Windows.Forms.Label
        Dim LetraPisoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PermisosComboBox = New System.Windows.Forms.ComboBox()
        Me.PermisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_telefonoTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.PortalTextBox = New System.Windows.Forms.TextBox()
        Me.PisoTextBox = New System.Windows.Forms.TextBox()
        Me.LetraPisoTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PermisosTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.PermisosTableAdapter()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.BuscarTxt = New System.Windows.Forms.TextBox()
        Me.ComboBuscar = New System.Windows.Forms.ComboBox()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreUsuarioLabel = New System.Windows.Forms.Label()
        PermisosLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        Numero_telefonoLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        PortalLabel = New System.Windows.Forms.Label()
        PisoLabel = New System.Windows.Forms.Label()
        LetraPisoLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdLabel.Location = New System.Drawing.Point(249, 160)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 20)
        IdLabel.TabIndex = 130
        IdLabel.Text = "Id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(249, 210)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(76, 20)
        NombreLabel.TabIndex = 132
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.BackColor = System.Drawing.Color.Transparent
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ApellidoLabel.Location = New System.Drawing.Point(249, 260)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(78, 20)
        ApellidoLabel.TabIndex = 134
        ApellidoLabel.Text = "Apellido:"
        '
        'NombreUsuarioLabel
        '
        NombreUsuarioLabel.AutoSize = True
        NombreUsuarioLabel.BackColor = System.Drawing.Color.Transparent
        NombreUsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NombreUsuarioLabel.Location = New System.Drawing.Point(483, 160)
        NombreUsuarioLabel.Name = "NombreUsuarioLabel"
        NombreUsuarioLabel.Size = New System.Drawing.Size(143, 20)
        NombreUsuarioLabel.TabIndex = 136
        NombreUsuarioLabel.Text = "Nombre Usuario:"
        '
        'PermisosLabel
        '
        PermisosLabel.AutoSize = True
        PermisosLabel.BackColor = System.Drawing.Color.Transparent
        PermisosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PermisosLabel.Location = New System.Drawing.Point(538, 210)
        PermisosLabel.Name = "PermisosLabel"
        PermisosLabel.Size = New System.Drawing.Size(87, 20)
        PermisosLabel.TabIndex = 138
        PermisosLabel.Text = "Permisos:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.BackColor = System.Drawing.Color.Transparent
        ContraseñaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ContraseñaLabel.Location = New System.Drawing.Point(519, 260)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(107, 20)
        ContraseñaLabel.TabIndex = 140
        ContraseñaLabel.Text = "Contraseña:"
        '
        'Numero_telefonoLabel
        '
        Numero_telefonoLabel.AutoSize = True
        Numero_telefonoLabel.BackColor = System.Drawing.Color.Transparent
        Numero_telefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Numero_telefonoLabel.Location = New System.Drawing.Point(178, 310)
        Numero_telefonoLabel.Name = "Numero_telefonoLabel"
        Numero_telefonoLabel.Size = New System.Drawing.Size(147, 20)
        Numero_telefonoLabel.TabIndex = 142
        Numero_telefonoLabel.Text = "Numero telefono:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.BackColor = System.Drawing.Color.Transparent
        LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        LocalidadLabel.Location = New System.Drawing.Point(817, 160)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(91, 20)
        LocalidadLabel.TabIndex = 144
        LocalidadLabel.Text = "Localidad:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.BackColor = System.Drawing.Color.Transparent
        CalleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CalleLabel.Location = New System.Drawing.Point(854, 210)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(54, 20)
        CalleLabel.TabIndex = 146
        CalleLabel.Text = "Calle:"
        '
        'PortalLabel
        '
        PortalLabel.AutoSize = True
        PortalLabel.BackColor = System.Drawing.Color.Transparent
        PortalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PortalLabel.Location = New System.Drawing.Point(847, 260)
        PortalLabel.Name = "PortalLabel"
        PortalLabel.Size = New System.Drawing.Size(61, 20)
        PortalLabel.TabIndex = 148
        PortalLabel.Text = "Portal:"
        '
        'PisoLabel
        '
        PisoLabel.AutoSize = True
        PisoLabel.BackColor = System.Drawing.Color.Transparent
        PisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PisoLabel.Location = New System.Drawing.Point(860, 310)
        PisoLabel.Name = "PisoLabel"
        PisoLabel.Size = New System.Drawing.Size(48, 20)
        PisoLabel.TabIndex = 150
        PisoLabel.Text = "Piso:"
        '
        'LetraPisoLabel
        '
        LetraPisoLabel.AutoSize = True
        LetraPisoLabel.BackColor = System.Drawing.Color.Transparent
        LetraPisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        LetraPisoLabel.Location = New System.Drawing.Point(813, 360)
        LetraPisoLabel.Name = "LetraPisoLabel"
        LetraPisoLabel.Size = New System.Drawing.Size(95, 20)
        LetraPisoLabel.TabIndex = 152
        LetraPisoLabel.Text = "Letra Piso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(481, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Cancelar cambios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(330, 477)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Guardar cambios"
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlmacenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DetalleProveedorTableAdapter = Nothing
        Me.TableAdapterManager.DetalleReparacionTableAdapter = Nothing
        Me.TableAdapterManager.DetalleVentaTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.PermisosTableAdapter = Nothing
        Me.TableAdapterManager.ProvedorTableAdapter = Nothing
        Me.TableAdapterManager.ReparacionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'IdLabel1
        '
        Me.IdLabel1.BackColor = System.Drawing.Color.Transparent
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Id", True))
        Me.IdLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdLabel1.Location = New System.Drawing.Point(343, 160)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(121, 23)
        Me.IdLabel1.TabIndex = 131
        Me.IdLabel1.Text = "Label4"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreTextBox.Location = New System.Drawing.Point(343, 210)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(121, 26)
        Me.NombreTextBox.TabIndex = 133
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ApellidoTextBox.Location = New System.Drawing.Point(343, 260)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(121, 26)
        Me.ApellidoTextBox.TabIndex = 135
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "NombreUsuario", True))
        Me.NombreUsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(644, 160)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(121, 26)
        Me.NombreUsuarioTextBox.TabIndex = 137
        '
        'PermisosComboBox
        '
        Me.PermisosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsuarioBindingSource, "Permisos", True))
        Me.PermisosComboBox.DataSource = Me.PermisosBindingSource
        Me.PermisosComboBox.DisplayMember = "Nombre"
        Me.PermisosComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PermisosComboBox.FormattingEnabled = True
        Me.PermisosComboBox.Location = New System.Drawing.Point(644, 210)
        Me.PermisosComboBox.Name = "PermisosComboBox"
        Me.PermisosComboBox.Size = New System.Drawing.Size(121, 28)
        Me.PermisosComboBox.TabIndex = 139
        Me.PermisosComboBox.ValueMember = "Nombre"
        '
        'PermisosBindingSource
        '
        Me.PermisosBindingSource.DataMember = "Permisos"
        Me.PermisosBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(644, 260)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(121, 26)
        Me.ContraseñaTextBox.TabIndex = 141
        '
        'Numero_telefonoTextBox
        '
        Me.Numero_telefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Numero_telefono", True))
        Me.Numero_telefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Numero_telefonoTextBox.Location = New System.Drawing.Point(343, 310)
        Me.Numero_telefonoTextBox.Name = "Numero_telefonoTextBox"
        Me.Numero_telefonoTextBox.Size = New System.Drawing.Size(121, 26)
        Me.Numero_telefonoTextBox.TabIndex = 143
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LocalidadTextBox.Location = New System.Drawing.Point(927, 160)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(121, 26)
        Me.LocalidadTextBox.TabIndex = 145
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Calle", True))
        Me.CalleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CalleTextBox.Location = New System.Drawing.Point(927, 210)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(121, 26)
        Me.CalleTextBox.TabIndex = 147
        '
        'PortalTextBox
        '
        Me.PortalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Portal", True))
        Me.PortalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PortalTextBox.Location = New System.Drawing.Point(927, 260)
        Me.PortalTextBox.Name = "PortalTextBox"
        Me.PortalTextBox.Size = New System.Drawing.Size(121, 26)
        Me.PortalTextBox.TabIndex = 149
        '
        'PisoTextBox
        '
        Me.PisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Piso", True))
        Me.PisoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PisoTextBox.Location = New System.Drawing.Point(927, 310)
        Me.PisoTextBox.Name = "PisoTextBox"
        Me.PisoTextBox.Size = New System.Drawing.Size(121, 26)
        Me.PisoTextBox.TabIndex = 151
        '
        'LetraPisoTextBox
        '
        Me.LetraPisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "LetraPiso", True))
        Me.LetraPisoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LetraPisoTextBox.Location = New System.Drawing.Point(927, 360)
        Me.LetraPisoTextBox.Name = "LetraPisoTextBox"
        Me.LetraPisoTextBox.Size = New System.Drawing.Size(121, 26)
        Me.LetraPisoTextBox.TabIndex = 153
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.aceptar
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(321, 420)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 70)
        Me.Button7.TabIndex = 117
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.cancelar
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(472, 420)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 70)
        Me.Button5.TabIndex = 118
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PermisosTableAdapter
        '
        Me.PermisosTableAdapter.ClearBeforeFill = True
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.editar
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(746, 32)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(52, 51)
        Me.Button12.TabIndex = 154
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.guardar
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(804, 28)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 55)
        Me.Button11.TabIndex = 155
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.eliminar
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(633, 30)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 51)
        Me.Button9.TabIndex = 161
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.add
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(565, 35)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 40)
        Me.Button6.TabIndex = 160
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(402, 37)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 36)
        Me.Button4.TabIndex = 159
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(262, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(339, 37)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 40)
        Me.Button3.TabIndex = 158
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(191, 37)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 40)
        Me.Button2.TabIndex = 157
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(123, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 36)
        Me.Button1.TabIndex = 156
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.BuscarTxt)
        Me.GroupBox1.Controls.Add(Me.ComboBuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(22, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 134)
        Me.GroupBox1.TabIndex = 176
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.Transparent
        Me.Buscar.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.buscar
        Me.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buscar.FlatAppearance.BorderSize = 0
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Location = New System.Drawing.Point(6, 80)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 48)
        Me.Buscar.TabIndex = 173
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'BuscarTxt
        '
        Me.BuscarTxt.Location = New System.Drawing.Point(10, 54)
        Me.BuscarTxt.Name = "BuscarTxt"
        Me.BuscarTxt.Size = New System.Drawing.Size(100, 20)
        Me.BuscarTxt.TabIndex = 171
        '
        'ComboBuscar
        '
        Me.ComboBuscar.FormattingEnabled = True
        Me.ComboBuscar.Items.AddRange(New Object() {"ID", "Nombre de Usuario", "Nombre"})
        Me.ComboBuscar.Location = New System.Drawing.Point(10, 27)
        Me.ComboBuscar.Name = "ComboBuscar"
        Me.ComboBuscar.Size = New System.Drawing.Size(100, 21)
        Me.ComboBuscar.TabIndex = 172
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.Usuarios_de_la_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1069, 521)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreUsuarioLabel)
        Me.Controls.Add(Me.NombreUsuarioTextBox)
        Me.Controls.Add(PermisosLabel)
        Me.Controls.Add(Me.PermisosComboBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(Numero_telefonoLabel)
        Me.Controls.Add(Me.Numero_telefonoTextBox)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Controls.Add(CalleLabel)
        Me.Controls.Add(Me.CalleTextBox)
        Me.Controls.Add(PortalLabel)
        Me.Controls.Add(Me.PortalTextBox)
        Me.Controls.Add(PisoLabel)
        Me.Controls.Add(Me.PisoTextBox)
        Me.Controls.Add(LetraPisoLabel)
        Me.Controls.Add(Me.LetraPisoTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As ProyectoFinalDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents NombreUsuarioTextBox As TextBox
    Friend WithEvents PermisosComboBox As ComboBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents Numero_telefonoTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents PortalTextBox As TextBox
    Friend WithEvents PisoTextBox As TextBox
    Friend WithEvents LetraPisoTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PermisosBindingSource As BindingSource
    Friend WithEvents PermisosTableAdapter As ProyectoFinalDataSetTableAdapters.PermisosTableAdapter
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Buscar As Button
    Friend WithEvents BuscarTxt As TextBox
    Friend WithEvents ComboBuscar As ComboBox
End Class
