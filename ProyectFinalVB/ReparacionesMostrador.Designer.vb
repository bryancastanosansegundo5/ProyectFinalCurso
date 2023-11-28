<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReparacionesMostrador
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
        Dim NombreUsuarioLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim FechaEntrgaLabel As System.Windows.Forms.Label
        Dim FechaSalidaLabel As System.Windows.Forms.Label
        Dim IdLabel2 As System.Windows.Forms.Label
        Dim DetallesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReparacionesMostrador))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.ReparacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReparacionesTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ReparacionesTableAdapter()
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Me.NombreUsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioLabel1 = New System.Windows.Forms.Label()
        Me.ApellidosLabel1 = New System.Windows.Forms.Label()
        Me.TelefonoLabel1 = New System.Windows.Forms.Label()
        Me.AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaEntrgaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaSalidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.AlmacenTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UsuarioTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.UsuarioTableAdapter()
        Me.MarcasTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.MarcasTableAdapter()
        Me.IdLabel3 = New System.Windows.Forms.Label()
        Me.DetallesTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloComboBox = New System.Windows.Forms.ComboBox()
        Me.MarcaLabel2 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ClientesTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        NombreUsuarioLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        FechaEntrgaLabel = New System.Windows.Forms.Label()
        FechaSalidaLabel = New System.Windows.Forms.Label()
        IdLabel2 = New System.Windows.Forms.Label()
        DetallesLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReparacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreUsuarioLabel
        '
        NombreUsuarioLabel.AutoSize = True
        NombreUsuarioLabel.BackColor = System.Drawing.Color.Transparent
        NombreUsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NombreUsuarioLabel.Location = New System.Drawing.Point(10, 66)
        NombreUsuarioLabel.Name = "NombreUsuarioLabel"
        NombreUsuarioLabel.Size = New System.Drawing.Size(43, 20)
        NombreUsuarioLabel.TabIndex = 119
        NombreUsuarioLabel.Text = "NIF:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        UsuarioLabel.Location = New System.Drawing.Point(318, 22)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(76, 20)
        UsuarioLabel.TabIndex = 121
        UsuarioLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.BackColor = System.Drawing.Color.Transparent
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ApellidosLabel.Location = New System.Drawing.Point(307, 66)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(87, 20)
        ApellidosLabel.TabIndex = 123
        ApellidosLabel.Text = "Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.Transparent
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        TelefonoLabel.Location = New System.Drawing.Point(644, 16)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(84, 20)
        TelefonoLabel.TabIndex = 125
        TelefonoLabel.Text = "Telefono:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = System.Drawing.Color.Transparent
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        MarcaLabel.Location = New System.Drawing.Point(332, 24)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(63, 20)
        MarcaLabel.TabIndex = 127
        MarcaLabel.Text = "Marca:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ModeloLabel.Location = New System.Drawing.Point(21, 16)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(72, 20)
        ModeloLabel.TabIndex = 129
        ModeloLabel.Text = "Modelo:"
        '
        'FechaEntrgaLabel
        '
        FechaEntrgaLabel.AutoSize = True
        FechaEntrgaLabel.BackColor = System.Drawing.Color.Transparent
        FechaEntrgaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        FechaEntrgaLabel.Location = New System.Drawing.Point(6, 82)
        FechaEntrgaLabel.Name = "FechaEntrgaLabel"
        FechaEntrgaLabel.Size = New System.Drawing.Size(156, 20)
        FechaEntrgaLabel.TabIndex = 133
        FechaEntrgaLabel.Text = "Fecha de entrega:"
        '
        'FechaSalidaLabel
        '
        FechaSalidaLabel.AutoSize = True
        FechaSalidaLabel.BackColor = System.Drawing.Color.Transparent
        FechaSalidaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        FechaSalidaLabel.Location = New System.Drawing.Point(444, 87)
        FechaSalidaLabel.Name = "FechaSalidaLabel"
        FechaSalidaLabel.Size = New System.Drawing.Size(141, 20)
        FechaSalidaLabel.TabIndex = 135
        FechaSalidaLabel.Text = "Fecha de salida:"
        '
        'IdLabel2
        '
        IdLabel2.AutoSize = True
        IdLabel2.BackColor = System.Drawing.Color.Transparent
        IdLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdLabel2.Location = New System.Drawing.Point(23, 19)
        IdLabel2.Name = "IdLabel2"
        IdLabel2.Size = New System.Drawing.Size(30, 20)
        IdLabel2.TabIndex = 137
        IdLabel2.Text = "Id:"
        '
        'DetallesLabel
        '
        DetallesLabel.AutoSize = True
        DetallesLabel.BackColor = System.Drawing.Color.Transparent
        DetallesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DetallesLabel.Location = New System.Drawing.Point(559, 24)
        DetallesLabel.Name = "DetallesLabel"
        DetallesLabel.Size = New System.Drawing.Size(80, 20)
        DetallesLabel.TabIndex = 138
        DetallesLabel.Text = "Detalles:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(487, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Cancelar cambios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(331, 508)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Guardar cambios"
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReparacionesBindingSource
        '
        Me.ReparacionesBindingSource.DataMember = "Reparaciones"
        Me.ReparacionesBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ReparacionesTableAdapter
        '
        Me.ReparacionesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ReparacionesTableAdapter = Me.ReparacionesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'NombreUsuarioComboBox
        '
        Me.NombreUsuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReparacionesBindingSource, "nombreUsuario", True))
        Me.NombreUsuarioComboBox.DataSource = Me.ClientesBindingSource
        Me.NombreUsuarioComboBox.DisplayMember = "NIF"
        Me.NombreUsuarioComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreUsuarioComboBox.FormattingEnabled = True
        Me.NombreUsuarioComboBox.Location = New System.Drawing.Point(85, 63)
        Me.NombreUsuarioComboBox.Name = "NombreUsuarioComboBox"
        Me.NombreUsuarioComboBox.Size = New System.Drawing.Size(199, 28)
        Me.NombreUsuarioComboBox.TabIndex = 120
        Me.NombreUsuarioComboBox.ValueMember = "NIF"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'UsuarioLabel1
        '
        Me.UsuarioLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UsuarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "usuario", True))
        Me.UsuarioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UsuarioLabel1.Location = New System.Drawing.Point(421, 19)
        Me.UsuarioLabel1.Name = "UsuarioLabel1"
        Me.UsuarioLabel1.Size = New System.Drawing.Size(217, 23)
        Me.UsuarioLabel1.TabIndex = 122
        Me.UsuarioLabel1.Text = "Label4"
        '
        'ApellidosLabel1
        '
        Me.ApellidosLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ApellidosLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "apellidos", True))
        Me.ApellidosLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ApellidosLabel1.Location = New System.Drawing.Point(423, 66)
        Me.ApellidosLabel1.Name = "ApellidosLabel1"
        Me.ApellidosLabel1.Size = New System.Drawing.Size(216, 23)
        Me.ApellidosLabel1.TabIndex = 124
        Me.ApellidosLabel1.Text = "Label4"
        '
        'TelefonoLabel1
        '
        Me.TelefonoLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TelefonoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "telefono", True))
        Me.TelefonoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TelefonoLabel1.Location = New System.Drawing.Point(749, 16)
        Me.TelefonoLabel1.Name = "TelefonoLabel1"
        Me.TelefonoLabel1.Size = New System.Drawing.Size(144, 23)
        Me.TelefonoLabel1.TabIndex = 126
        Me.TelefonoLabel1.Text = "Label4"
        '
        'AlmacenBindingSource
        '
        Me.AlmacenBindingSource.DataMember = "Almacen"
        Me.AlmacenBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'FechaEntrgaDateTimePicker
        '
        Me.FechaEntrgaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReparacionesBindingSource, "fechaEntrga", True))
        Me.FechaEntrgaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FechaEntrgaDateTimePicker.Location = New System.Drawing.Point(184, 82)
        Me.FechaEntrgaDateTimePicker.Name = "FechaEntrgaDateTimePicker"
        Me.FechaEntrgaDateTimePicker.Size = New System.Drawing.Size(225, 26)
        Me.FechaEntrgaDateTimePicker.TabIndex = 134
        '
        'FechaSalidaDateTimePicker
        '
        Me.FechaSalidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReparacionesBindingSource, "fechaSalida", True))
        Me.FechaSalidaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FechaSalidaDateTimePicker.Location = New System.Drawing.Point(605, 82)
        Me.FechaSalidaDateTimePicker.Name = "FechaSalidaDateTimePicker"
        Me.FechaSalidaDateTimePicker.Size = New System.Drawing.Size(224, 26)
        Me.FechaSalidaDateTimePicker.TabIndex = 136
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.aceptar
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(316, 444)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 70)
        Me.Button7.TabIndex = 104
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.cancelar
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(476, 444)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 70)
        Me.Button5.TabIndex = 105
        Me.Button5.UseVisualStyleBackColor = False
        '
        'AlmacenTableAdapter
        '
        Me.AlmacenTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'IdLabel3
        '
        Me.IdLabel3.BackColor = System.Drawing.Color.Transparent
        Me.IdLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "Id", True))
        Me.IdLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdLabel3.Location = New System.Drawing.Point(81, 19)
        Me.IdLabel3.Name = "IdLabel3"
        Me.IdLabel3.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel3.TabIndex = 138
        Me.IdLabel3.Text = "Label4"
        '
        'DetallesTextBox
        '
        Me.DetallesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "Detalles", True))
        Me.DetallesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DetallesTextBox.Location = New System.Drawing.Point(664, 24)
        Me.DetallesTextBox.Name = "DetallesTextBox"
        Me.DetallesTextBox.Size = New System.Drawing.Size(203, 26)
        Me.DetallesTextBox.TabIndex = 139
        '
        'ModeloComboBox
        '
        Me.ModeloComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReparacionesBindingSource, "modelo", True))
        Me.ModeloComboBox.DataSource = Me.AlmacenBindingSource
        Me.ModeloComboBox.DisplayMember = "Modelo"
        Me.ModeloComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ModeloComboBox.FormattingEnabled = True
        Me.ModeloComboBox.Location = New System.Drawing.Point(99, 16)
        Me.ModeloComboBox.Name = "ModeloComboBox"
        Me.ModeloComboBox.Size = New System.Drawing.Size(200, 28)
        Me.ModeloComboBox.TabIndex = 140
        Me.ModeloComboBox.ValueMember = "Modelo"
        '
        'MarcaLabel2
        '
        Me.MarcaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MarcaLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "marca", True))
        Me.MarcaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MarcaLabel2.Location = New System.Drawing.Point(401, 24)
        Me.MarcaLabel2.Name = "MarcaLabel2"
        Me.MarcaLabel2.Size = New System.Drawing.Size(132, 23)
        Me.MarcaLabel2.TabIndex = 141
        Me.MarcaLabel2.Text = "Label4"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(IdLabel2)
        Me.GroupBox1.Controls.Add(Me.TelefonoLabel1)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosLabel1)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.UsuarioLabel1)
        Me.GroupBox1.Controls.Add(Me.IdLabel3)
        Me.GroupBox1.Controls.Add(UsuarioLabel)
        Me.GroupBox1.Controls.Add(NombreUsuarioLabel)
        Me.GroupBox1.Controls.Add(Me.NombreUsuarioComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(899, 100)
        Me.GroupBox1.TabIndex = 143
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(ModeloLabel)
        Me.GroupBox2.Controls.Add(Me.FechaSalidaDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.MarcaLabel2)
        Me.GroupBox2.Controls.Add(FechaSalidaLabel)
        Me.GroupBox2.Controls.Add(Me.ModeloComboBox)
        Me.GroupBox2.Controls.Add(Me.FechaEntrgaDateTimePicker)
        Me.GroupBox2.Controls.Add(DetallesLabel)
        Me.GroupBox2.Controls.Add(FechaEntrgaLabel)
        Me.GroupBox2.Controls.Add(Me.DetallesTextBox)
        Me.GroupBox2.Controls.Add(MarcaLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(65, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(899, 153)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la reparación"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.editar
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(745, 45)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(52, 51)
        Me.Button12.TabIndex = 142
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
        Me.Button11.Location = New System.Drawing.Point(803, 41)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 55)
        Me.Button11.TabIndex = 143
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.eliminar
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(632, 43)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 51)
        Me.Button9.TabIndex = 149
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.add
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(564, 48)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 40)
        Me.Button6.TabIndex = 148
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(401, 50)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 36)
        Me.Button4.TabIndex = 147
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(261, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(338, 50)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 40)
        Me.Button3.TabIndex = 146
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(190, 50)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 40)
        Me.Button2.TabIndex = 145
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(122, 50)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 36)
        Me.Button1.TabIndex = 144
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReparacionesMostrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.RecepcionReparacion
        Me.ClientSize = New System.Drawing.Size(987, 555)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReparacionesMostrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReparacionesMostrador"
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReparacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents ReparacionesBindingSource As BindingSource
    Friend WithEvents ReparacionesTableAdapter As ProyectoFinalDataSetTableAdapters.ReparacionesTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombreUsuarioComboBox As ComboBox
    Friend WithEvents UsuarioLabel1 As Label
    Friend WithEvents ApellidosLabel1 As Label
    Friend WithEvents TelefonoLabel1 As Label
    Friend WithEvents FechaEntrgaDateTimePicker As DateTimePicker
    Friend WithEvents FechaSalidaDateTimePicker As DateTimePicker
    Friend WithEvents AlmacenBindingSource As BindingSource
    Friend WithEvents AlmacenTableAdapter As ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As ProyectoFinalDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents MarcasBindingSource As BindingSource
    Friend WithEvents MarcasTableAdapter As ProyectoFinalDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents IdLabel3 As Label
    Friend WithEvents DetallesTextBox As TextBox
    Friend WithEvents ModeloComboBox As ComboBox
    Friend WithEvents MarcaLabel2 As Label
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ProyectoFinalDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
