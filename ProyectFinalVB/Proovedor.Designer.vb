<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proovedor
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
        Dim ProveedorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim E_MailLabel As System.Windows.Forms.Label
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proovedor))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.ProvedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvedorTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ProvedorTableAdapter()
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NacionalidadTextBox = New System.Windows.Forms.TextBox()
        Me.WebTextBox = New System.Windows.Forms.TextBox()
        Me.E_MailTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.ComboBuscar = New System.Windows.Forms.ComboBox()
        Me.BuscarTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        IdLabel = New System.Windows.Forms.Label()
        ProveedorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        WebLabel = New System.Windows.Forms.Label()
        E_MailLabel = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdLabel.Location = New System.Drawing.Point(269, 156)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 20)
        IdLabel.TabIndex = 109
        IdLabel.Text = "Id:"
        '
        'ProveedorLabel
        '
        ProveedorLabel.AutoSize = True
        ProveedorLabel.BackColor = System.Drawing.Color.Transparent
        ProveedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ProveedorLabel.Location = New System.Drawing.Point(204, 206)
        ProveedorLabel.Name = "ProveedorLabel"
        ProveedorLabel.Size = New System.Drawing.Size(95, 20)
        ProveedorLabel.TabIndex = 111
        ProveedorLabel.Text = "Proveedor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(223, 256)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(76, 20)
        NombreLabel.TabIndex = 113
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.BackColor = System.Drawing.Color.Transparent
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DireccionLabel.Location = New System.Drawing.Point(508, 156)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(89, 20)
        DireccionLabel.TabIndex = 115
        DireccionLabel.Text = "Dirección:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.BackColor = System.Drawing.Color.Transparent
        NacionalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NacionalidadLabel.Location = New System.Drawing.Point(480, 206)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(117, 20)
        NacionalidadLabel.TabIndex = 117
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.BackColor = System.Drawing.Color.Transparent
        WebLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        WebLabel.Location = New System.Drawing.Point(799, 156)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(50, 20)
        WebLabel.TabIndex = 119
        WebLabel.Text = "Web:"
        '
        'E_MailLabel
        '
        E_MailLabel.AutoSize = True
        E_MailLabel.BackColor = System.Drawing.Color.Transparent
        E_MailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        E_MailLabel.Location = New System.Drawing.Point(785, 206)
        E_MailLabel.Name = "E_MailLabel"
        E_MailLabel.Size = New System.Drawing.Size(64, 20)
        E_MailLabel.TabIndex = 121
        E_MailLabel.Text = "E-Mail:"
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.BackColor = System.Drawing.Color.Transparent
        CodigoPostalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CodigoPostalLabel.Location = New System.Drawing.Point(472, 256)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(125, 20)
        CodigoPostalLabel.TabIndex = 123
        CodigoPostalLabel.Text = "Codigo Postal:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.BackColor = System.Drawing.Color.Transparent
        ContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ContactoLabel.Location = New System.Drawing.Point(762, 256)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(87, 20)
        ContactoLabel.TabIndex = 125
        ContactoLabel.Text = "Contacto:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.BackColor = System.Drawing.Color.Transparent
        NIFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NIFLabel.Location = New System.Drawing.Point(806, 306)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(43, 20)
        NIFLabel.TabIndex = 127
        NIFLabel.Text = "NIF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(450, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Cancelar cambios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(294, 443)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Guardar cambios"
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProvedorBindingSource
        '
        Me.ProvedorBindingSource.DataMember = "Provedor"
        Me.ProvedorBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ProvedorTableAdapter
        '
        Me.ProvedorTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ProvedorTableAdapter = Me.ProvedorTableAdapter
        Me.TableAdapterManager.ReparacionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.aceptar
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(288, 369)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 70)
        Me.Button7.TabIndex = 106
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.cancelar
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(439, 369)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 70)
        Me.Button5.TabIndex = 107
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'IdLabel1
        '
        Me.IdLabel1.BackColor = System.Drawing.Color.Transparent
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Id", True))
        Me.IdLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdLabel1.Location = New System.Drawing.Point(332, 156)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 110
        Me.IdLabel1.Text = "Label4"
        '
        'ProveedorTextBox
        '
        Me.ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Proveedor", True))
        Me.ProveedorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ProveedorTextBox.Location = New System.Drawing.Point(332, 206)
        Me.ProveedorTextBox.Name = "ProveedorTextBox"
        Me.ProveedorTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ProveedorTextBox.TabIndex = 112
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreTextBox.Location = New System.Drawing.Point(332, 256)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NombreTextBox.TabIndex = 114
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DireccionTextBox.Location = New System.Drawing.Point(632, 156)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DireccionTextBox.TabIndex = 116
        '
        'NacionalidadTextBox
        '
        Me.NacionalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Nacionalidad", True))
        Me.NacionalidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NacionalidadTextBox.Location = New System.Drawing.Point(632, 206)
        Me.NacionalidadTextBox.Name = "NacionalidadTextBox"
        Me.NacionalidadTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NacionalidadTextBox.TabIndex = 118
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Web", True))
        Me.WebTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.WebTextBox.Location = New System.Drawing.Point(901, 156)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(100, 26)
        Me.WebTextBox.TabIndex = 120
        '
        'E_MailTextBox
        '
        Me.E_MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "EMail", True))
        Me.E_MailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.E_MailTextBox.Location = New System.Drawing.Point(901, 206)
        Me.E_MailTextBox.Name = "E_MailTextBox"
        Me.E_MailTextBox.Size = New System.Drawing.Size(100, 26)
        Me.E_MailTextBox.TabIndex = 122
        '
        'CodigoPostalTextBox
        '
        Me.CodigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "CodigoPostal", True))
        Me.CodigoPostalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CodigoPostalTextBox.Location = New System.Drawing.Point(632, 256)
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        Me.CodigoPostalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CodigoPostalTextBox.TabIndex = 124
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Contacto", True))
        Me.ContactoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ContactoTextBox.Location = New System.Drawing.Point(901, 256)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ContactoTextBox.TabIndex = 126
        '
        'NIFTextBox
        '
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "NIF", True))
        Me.NIFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NIFTextBox.Location = New System.Drawing.Point(901, 306)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NIFTextBox.TabIndex = 128
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.editar
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(701, 36)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(52, 51)
        Me.Button12.TabIndex = 151
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
        Me.Button11.Location = New System.Drawing.Point(821, 34)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 55)
        Me.Button11.TabIndex = 152
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.eliminar
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(588, 34)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 51)
        Me.Button9.TabIndex = 158
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.add
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(520, 39)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 40)
        Me.Button6.TabIndex = 157
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(357, 41)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 36)
        Me.Button4.TabIndex = 156
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(217, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(294, 41)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 40)
        Me.Button3.TabIndex = 155
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(146, 41)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 40)
        Me.Button2.TabIndex = 154
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(78, 41)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 36)
        Me.Button1.TabIndex = 153
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.informe2
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(759, 34)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 55)
        Me.Button8.TabIndex = 170
        Me.Button8.UseVisualStyleBackColor = False
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
        'ComboBuscar
        '
        Me.ComboBuscar.FormattingEnabled = True
        Me.ComboBuscar.Items.AddRange(New Object() {"ID", "Nombre de proveedor", "NIF"})
        Me.ComboBuscar.Location = New System.Drawing.Point(10, 27)
        Me.ComboBuscar.Name = "ComboBuscar"
        Me.ComboBuscar.Size = New System.Drawing.Size(100, 21)
        Me.ComboBuscar.TabIndex = 172
        '
        'BuscarTxt
        '
        Me.BuscarTxt.Location = New System.Drawing.Point(10, 54)
        Me.BuscarTxt.Name = "BuscarTxt"
        Me.BuscarTxt.Size = New System.Drawing.Size(100, 20)
        Me.BuscarTxt.TabIndex = 171
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.BuscarTxt)
        Me.GroupBox1.Controls.Add(Me.ComboBuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(33, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 134)
        Me.GroupBox1.TabIndex = 174
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'Proovedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.Proveedores
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 521)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button8)
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
        Me.Controls.Add(ProveedorLabel)
        Me.Controls.Add(Me.ProveedorTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(Me.NacionalidadTextBox)
        Me.Controls.Add(WebLabel)
        Me.Controls.Add(Me.WebTextBox)
        Me.Controls.Add(E_MailLabel)
        Me.Controls.Add(Me.E_MailTextBox)
        Me.Controls.Add(CodigoPostalLabel)
        Me.Controls.Add(Me.CodigoPostalTextBox)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Proovedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proovedor"
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProvedorBindingSource As BindingSource
    Friend WithEvents ProvedorTableAdapter As ProyectoFinalDataSetTableAdapters.ProvedorTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents ProveedorTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents NacionalidadTextBox As TextBox
    Friend WithEvents WebTextBox As TextBox
    Friend WithEvents E_MailTextBox As TextBox
    Friend WithEvents CodigoPostalTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents NIFTextBox As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Buscar As Button
    Friend WithEvents ComboBuscar As ComboBox
    Friend WithEvents BuscarTxt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
