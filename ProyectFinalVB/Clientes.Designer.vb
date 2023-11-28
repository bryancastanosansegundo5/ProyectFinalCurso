<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim Numero_telefonoLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim PortalLabel As System.Windows.Forms.Label
        Dim PisoLabel As System.Windows.Forms.Label
        Dim LetraPisoLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_telefonoTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.PortalTextBox = New System.Windows.Forms.TextBox()
        Me.PisoTextBox = New System.Windows.Forms.TextBox()
        Me.LetraPisoTextBox = New System.Windows.Forms.TextBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.BuscarTxt = New System.Windows.Forms.TextBox()
        Me.ComboBuscar = New System.Windows.Forms.ComboBox()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Numero_telefonoLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        PortalLabel = New System.Windows.Forms.Label()
        PisoLabel = New System.Windows.Forms.Label()
        LetraPisoLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdLabel.Location = New System.Drawing.Point(228, 157)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 20)
        IdLabel.TabIndex = 143
        IdLabel.Text = "Id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(228, 195)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(76, 20)
        NombreLabel.TabIndex = 145
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.BackColor = System.Drawing.Color.Transparent
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ApellidoLabel.Location = New System.Drawing.Point(228, 232)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(78, 20)
        ApellidoLabel.TabIndex = 147
        ApellidoLabel.Text = "Apellido:"
        '
        'Numero_telefonoLabel
        '
        Numero_telefonoLabel.AutoSize = True
        Numero_telefonoLabel.BackColor = System.Drawing.Color.Transparent
        Numero_telefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Numero_telefonoLabel.Location = New System.Drawing.Point(228, 273)
        Numero_telefonoLabel.Name = "Numero_telefonoLabel"
        Numero_telefonoLabel.Size = New System.Drawing.Size(147, 20)
        Numero_telefonoLabel.TabIndex = 149
        Numero_telefonoLabel.Text = "Número teléfono:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.BackColor = System.Drawing.Color.Transparent
        ProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ProvinciaLabel.Location = New System.Drawing.Point(582, 160)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(86, 20)
        ProvinciaLabel.TabIndex = 151
        ProvinciaLabel.Text = "Provincia:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.BackColor = System.Drawing.Color.Transparent
        LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        LocalidadLabel.Location = New System.Drawing.Point(582, 195)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(91, 20)
        LocalidadLabel.TabIndex = 153
        LocalidadLabel.Text = "Localidad:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.BackColor = System.Drawing.Color.Transparent
        CalleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CalleLabel.Location = New System.Drawing.Point(582, 232)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(54, 20)
        CalleLabel.TabIndex = 155
        CalleLabel.Text = "Calle:"
        '
        'PortalLabel
        '
        PortalLabel.AutoSize = True
        PortalLabel.BackColor = System.Drawing.Color.Transparent
        PortalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PortalLabel.Location = New System.Drawing.Point(582, 273)
        PortalLabel.Name = "PortalLabel"
        PortalLabel.Size = New System.Drawing.Size(61, 20)
        PortalLabel.TabIndex = 157
        PortalLabel.Text = "Portal:"
        '
        'PisoLabel
        '
        PisoLabel.AutoSize = True
        PisoLabel.BackColor = System.Drawing.Color.Transparent
        PisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PisoLabel.Location = New System.Drawing.Point(582, 316)
        PisoLabel.Name = "PisoLabel"
        PisoLabel.Size = New System.Drawing.Size(48, 20)
        PisoLabel.TabIndex = 159
        PisoLabel.Text = "Piso:"
        '
        'LetraPisoLabel
        '
        LetraPisoLabel.AutoSize = True
        LetraPisoLabel.BackColor = System.Drawing.Color.Transparent
        LetraPisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        LetraPisoLabel.Location = New System.Drawing.Point(582, 357)
        LetraPisoLabel.Name = "LetraPisoLabel"
        LetraPisoLabel.Size = New System.Drawing.Size(95, 20)
        LetraPisoLabel.TabIndex = 161
        LetraPisoLabel.Text = "Letra Piso:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.BackColor = System.Drawing.Color.Transparent
        NIFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NIFLabel.Location = New System.Drawing.Point(228, 322)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(43, 20)
        NIFLabel.TabIndex = 163
        NIFLabel.Text = "NIF:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(289, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(466, 480)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Cancelar cambios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(315, 480)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Guardar cambios"
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlmacenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.DetalleProveedorTableAdapter = Nothing
        Me.TableAdapterManager.DetalleReparacionTableAdapter = Nothing
        Me.TableAdapterManager.DetalleVentaTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.PermisosTableAdapter = Nothing
        Me.TableAdapterManager.ProvedorTableAdapter = Nothing
        Me.TableAdapterManager.ReparacionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'IdLabel1
        '
        Me.IdLabel1.BackColor = System.Drawing.Color.Transparent
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Id", True))
        Me.IdLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdLabel1.Location = New System.Drawing.Point(397, 160)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(136, 23)
        Me.IdLabel1.TabIndex = 144
        Me.IdLabel1.Text = "Label4"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreTextBox.Location = New System.Drawing.Point(397, 195)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(136, 26)
        Me.NombreTextBox.TabIndex = 146
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ApellidoTextBox.Location = New System.Drawing.Point(397, 232)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(136, 26)
        Me.ApellidoTextBox.TabIndex = 148
        '
        'Numero_telefonoTextBox
        '
        Me.Numero_telefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Numero_telefono", True))
        Me.Numero_telefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Numero_telefonoTextBox.Location = New System.Drawing.Point(397, 273)
        Me.Numero_telefonoTextBox.Name = "Numero_telefonoTextBox"
        Me.Numero_telefonoTextBox.Size = New System.Drawing.Size(136, 26)
        Me.Numero_telefonoTextBox.TabIndex = 150
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(751, 160)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(136, 26)
        Me.ProvinciaTextBox.TabIndex = 152
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LocalidadTextBox.Location = New System.Drawing.Point(751, 195)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(136, 26)
        Me.LocalidadTextBox.TabIndex = 154
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Calle", True))
        Me.CalleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CalleTextBox.Location = New System.Drawing.Point(751, 232)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(136, 26)
        Me.CalleTextBox.TabIndex = 156
        '
        'PortalTextBox
        '
        Me.PortalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Portal", True))
        Me.PortalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PortalTextBox.Location = New System.Drawing.Point(751, 273)
        Me.PortalTextBox.Name = "PortalTextBox"
        Me.PortalTextBox.Size = New System.Drawing.Size(136, 26)
        Me.PortalTextBox.TabIndex = 158
        '
        'PisoTextBox
        '
        Me.PisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Piso", True))
        Me.PisoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PisoTextBox.Location = New System.Drawing.Point(751, 316)
        Me.PisoTextBox.Name = "PisoTextBox"
        Me.PisoTextBox.Size = New System.Drawing.Size(136, 26)
        Me.PisoTextBox.TabIndex = 160
        '
        'LetraPisoTextBox
        '
        Me.LetraPisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "LetraPiso", True))
        Me.LetraPisoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LetraPisoTextBox.Location = New System.Drawing.Point(751, 357)
        Me.LetraPisoTextBox.Name = "LetraPisoTextBox"
        Me.LetraPisoTextBox.Size = New System.Drawing.Size(136, 26)
        Me.LetraPisoTextBox.TabIndex = 162
        '
        'NIFTextBox
        '
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NIF", True))
        Me.NIFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NIFTextBox.Location = New System.Drawing.Point(397, 316)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(136, 26)
        Me.NIFTextBox.TabIndex = 164
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.editar
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(742, 41)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(52, 51)
        Me.Button12.TabIndex = 17
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
        Me.Button11.Location = New System.Drawing.Point(846, 39)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 55)
        Me.Button11.TabIndex = 134
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.eliminar
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(623, 43)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 51)
        Me.Button9.TabIndex = 140
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.add
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(555, 48)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 40)
        Me.Button6.TabIndex = 139
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(429, 48)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 36)
        Me.Button4.TabIndex = 138
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(366, 48)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 40)
        Me.Button3.TabIndex = 137
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(218, 48)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 40)
        Me.Button2.TabIndex = 136
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(150, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 36)
        Me.Button1.TabIndex = 135
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.aceptar
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(307, 418)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 70)
        Me.Button7.TabIndex = 130
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.cancelar
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(460, 418)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 70)
        Me.Button5.TabIndex = 131
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.informe2
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(794, 39)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 55)
        Me.Button8.TabIndex = 169
        Me.Button8.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.BuscarTxt)
        Me.GroupBox1.Controls.Add(Me.ComboBuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(43, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 134)
        Me.GroupBox1.TabIndex = 175
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
        Me.ComboBuscar.Items.AddRange(New Object() {"ID", "Nombre del Cliente", "Provincia"})
        Me.ComboBuscar.Location = New System.Drawing.Point(10, 27)
        Me.ComboBuscar.Name = "ComboBuscar"
        Me.ComboBuscar.Size = New System.Drawing.Size(100, 21)
        Me.ComboBuscar.TabIndex = 172
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.Clientes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(930, 521)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Numero_telefonoLabel)
        Me.Controls.Add(Me.Numero_telefonoTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
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
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFTextBox)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ProyectoFinalDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents Numero_telefonoTextBox As TextBox
    Friend WithEvents ProvinciaTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents PortalTextBox As TextBox
    Friend WithEvents PisoTextBox As TextBox
    Friend WithEvents LetraPisoTextBox As TextBox
    Friend WithEvents NIFTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Buscar As Button
    Friend WithEvents BuscarTxt As TextBox
    Friend WithEvents ComboBuscar As ComboBox
End Class
