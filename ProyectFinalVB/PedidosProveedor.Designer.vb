<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosProveedor
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
        Dim Id_BiciLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim Precio_UnitarioLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Importe_totalLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim FechaPedidoLabel As System.Windows.Forms.Label
        Dim FechaLLegadaLabel As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim ProveedorLabel1 As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim DireccionLabel1 As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim E_MailLabel As System.Windows.Forms.Label
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidosProveedor))
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.ProvedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvedorTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ProvedorTableAdapter()
        Me.DetalleProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleProveedorTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.DetalleProveedorTableAdapter()
        Me.Id_BiciLabel1 = New System.Windows.Forms.Label()
        Me.ModeloComboBox = New System.Windows.Forms.ComboBox()
        Me.AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Precio_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Importe_totalTextBox = New System.Windows.Forms.TextBox()
        Me.FechaLLegadaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DetalleProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlmacenTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProvedorDetalleProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdProveedor1 = New System.Windows.Forms.Label()
        Me.ProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreLabel2 = New System.Windows.Forms.Label()
        Me.DireccionLabel2 = New System.Windows.Forms.Label()
        Me.NacionalidadLabel1 = New System.Windows.Forms.Label()
        Me.WebLabel1 = New System.Windows.Forms.Label()
        Me.E_MailLabel1 = New System.Windows.Forms.Label()
        Me.CodigoPostalLabel1 = New System.Windows.Forms.Label()
        Me.ContactoLabel1 = New System.Windows.Forms.Label()
        Me.NIFLabel1 = New System.Windows.Forms.Label()
        Me.MarcaLabel2 = New System.Windows.Forms.Label()
        Me.FechaPedidoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Id_BiciLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Importe_totalLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        FechaPedidoLabel = New System.Windows.Forms.Label()
        FechaLLegadaLabel = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        ProveedorLabel1 = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        DireccionLabel1 = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        WebLabel = New System.Windows.Forms.Label()
        E_MailLabel = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvedorDetalleProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_BiciLabel
        '
        Id_BiciLabel.AutoSize = True
        Id_BiciLabel.BackColor = System.Drawing.Color.Transparent
        Id_BiciLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Id_BiciLabel.Location = New System.Drawing.Point(74, 426)
        Id_BiciLabel.Name = "Id_BiciLabel"
        Id_BiciLabel.Size = New System.Drawing.Size(96, 20)
        Id_BiciLabel.TabIndex = 365
        Id_BiciLabel.Text = "Id Artículo:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ModeloLabel.Location = New System.Drawing.Point(99, 468)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(72, 20)
        ModeloLabel.TabIndex = 367
        ModeloLabel.Text = "Modelo:"
        '
        'Precio_UnitarioLabel
        '
        Precio_UnitarioLabel.AutoSize = True
        Precio_UnitarioLabel.BackColor = System.Drawing.Color.Transparent
        Precio_UnitarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Precio_UnitarioLabel.Location = New System.Drawing.Point(429, 426)
        Precio_UnitarioLabel.Name = "Precio_UnitarioLabel"
        Precio_UnitarioLabel.Size = New System.Drawing.Size(132, 20)
        Precio_UnitarioLabel.TabIndex = 369
        Precio_UnitarioLabel.Text = "Precio Unitario:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.BackColor = System.Drawing.Color.Transparent
        CantidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CantidadLabel.Location = New System.Drawing.Point(475, 468)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(86, 20)
        CantidadLabel.TabIndex = 371
        CantidadLabel.Text = "Cantidad:"
        '
        'Importe_totalLabel
        '
        Importe_totalLabel.AutoSize = True
        Importe_totalLabel.BackColor = System.Drawing.Color.Transparent
        Importe_totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Importe_totalLabel.Location = New System.Drawing.Point(444, 510)
        Importe_totalLabel.Name = "Importe_totalLabel"
        Importe_totalLabel.Size = New System.Drawing.Size(117, 20)
        Importe_totalLabel.TabIndex = 373
        Importe_totalLabel.Text = "Importe total:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = System.Drawing.Color.Transparent
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        MarcaLabel.Location = New System.Drawing.Point(107, 510)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(63, 20)
        MarcaLabel.TabIndex = 377
        MarcaLabel.Text = "Marca:"
        '
        'FechaPedidoLabel
        '
        FechaPedidoLabel.AutoSize = True
        FechaPedidoLabel.BackColor = System.Drawing.Color.Transparent
        FechaPedidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        FechaPedidoLabel.Location = New System.Drawing.Point(765, 468)
        FechaPedidoLabel.Name = "FechaPedidoLabel"
        FechaPedidoLabel.Size = New System.Drawing.Size(124, 20)
        FechaPedidoLabel.TabIndex = 379
        FechaPedidoLabel.Text = "Fecha Pedido:"
        '
        'FechaLLegadaLabel
        '
        FechaLLegadaLabel.AutoSize = True
        FechaLLegadaLabel.BackColor = System.Drawing.Color.Transparent
        FechaLLegadaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        FechaLLegadaLabel.Location = New System.Drawing.Point(753, 510)
        FechaLLegadaLabel.Name = "FechaLLegadaLabel"
        FechaLLegadaLabel.Size = New System.Drawing.Size(139, 20)
        FechaLLegadaLabel.TabIndex = 381
        FechaLLegadaLabel.Text = "Fecha LLegada:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.BackColor = System.Drawing.Color.Transparent
        IdLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdLabel1.Location = New System.Drawing.Point(253, 190)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(30, 20)
        IdLabel1.TabIndex = 390
        IdLabel1.Text = "Id:"
        '
        'ProveedorLabel1
        '
        ProveedorLabel1.AutoSize = True
        ProveedorLabel1.BackColor = System.Drawing.Color.Transparent
        ProveedorLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ProveedorLabel1.Location = New System.Drawing.Point(188, 230)
        ProveedorLabel1.Name = "ProveedorLabel1"
        ProveedorLabel1.Size = New System.Drawing.Size(95, 20)
        ProveedorLabel1.TabIndex = 392
        ProveedorLabel1.Text = "Proveedor:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.BackColor = System.Drawing.Color.Transparent
        NombreLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NombreLabel1.Location = New System.Drawing.Point(207, 270)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(76, 20)
        NombreLabel1.TabIndex = 394
        NombreLabel1.Text = "Nombre:"
        '
        'DireccionLabel1
        '
        DireccionLabel1.AutoSize = True
        DireccionLabel1.BackColor = System.Drawing.Color.Transparent
        DireccionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DireccionLabel1.Location = New System.Drawing.Point(496, 305)
        DireccionLabel1.Name = "DireccionLabel1"
        DireccionLabel1.Size = New System.Drawing.Size(89, 20)
        DireccionLabel1.TabIndex = 396
        DireccionLabel1.Text = "Dirección:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.BackColor = System.Drawing.Color.Transparent
        NacionalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NacionalidadLabel.Location = New System.Drawing.Point(466, 270)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(117, 20)
        NacionalidadLabel.TabIndex = 398
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.BackColor = System.Drawing.Color.Transparent
        WebLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        WebLabel.Location = New System.Drawing.Point(533, 190)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(50, 20)
        WebLabel.TabIndex = 400
        WebLabel.Text = "Web:"
        '
        'E_MailLabel
        '
        E_MailLabel.AutoSize = True
        E_MailLabel.BackColor = System.Drawing.Color.Transparent
        E_MailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        E_MailLabel.Location = New System.Drawing.Point(796, 190)
        E_MailLabel.Name = "E_MailLabel"
        E_MailLabel.Size = New System.Drawing.Size(64, 20)
        E_MailLabel.TabIndex = 402
        E_MailLabel.Text = "E-Mail:"
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.BackColor = System.Drawing.Color.Transparent
        CodigoPostalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CodigoPostalLabel.Location = New System.Drawing.Point(735, 230)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(125, 20)
        CodigoPostalLabel.TabIndex = 404
        CodigoPostalLabel.Text = "Codigo Postal:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.BackColor = System.Drawing.Color.Transparent
        ContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ContactoLabel.Location = New System.Drawing.Point(496, 230)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(87, 20)
        ContactoLabel.TabIndex = 406
        ContactoLabel.Text = "Contacto:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.BackColor = System.Drawing.Color.Transparent
        NIFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NIFLabel.Location = New System.Drawing.Point(817, 270)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(43, 20)
        NIFLabel.TabIndex = 408
        NIFLabel.Text = "NIF:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlmacenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.guardar
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(959, 344)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 55)
        Me.Button11.TabIndex = 343
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(615, 637)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 307
        Me.Label5.Text = "Cancelar cambios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(445, 637)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 306
        Me.Label6.Text = "Guardar cambios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(302, 363)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 304
        Me.Label4.Text = "Label4"
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Transparent
        Me.Button19.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.add
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Location = New System.Drawing.Point(705, 353)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(42, 40)
        Me.Button19.TabIndex = 297
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(447, 353)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(47, 36)
        Me.Button8.TabIndex = 305
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Location = New System.Drawing.Point(384, 353)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(42, 40)
        Me.Button16.TabIndex = 303
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Transparent
        Me.Button18.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Location = New System.Drawing.Point(168, 353)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(47, 36)
        Me.Button18.TabIndex = 301
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.eliminar
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(769, 348)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(54, 51)
        Me.Button10.TabIndex = 298
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.aceptar
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.Color.Transparent
        Me.Button14.Location = New System.Drawing.Point(441, 580)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(102, 70)
        Me.Button14.TabIndex = 299
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.cancelar
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(604, 580)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(102, 70)
        Me.Button15.TabIndex = 300
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Location = New System.Drawing.Point(236, 353)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(42, 40)
        Me.Button17.TabIndex = 302
        Me.Button17.UseVisualStyleBackColor = False
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
        'DetalleProveedorBindingSource
        '
        Me.DetalleProveedorBindingSource.DataMember = "Provedor_DetalleProveedor"
        Me.DetalleProveedorBindingSource.DataSource = Me.ProvedorBindingSource
        '
        'DetalleProveedorTableAdapter
        '
        Me.DetalleProveedorTableAdapter.ClearBeforeFill = True
        '
        'Id_BiciLabel1
        '
        Me.Id_BiciLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Id_BiciLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleProveedorBindingSource, "Id_Bici", True))
        Me.Id_BiciLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Id_BiciLabel1.Location = New System.Drawing.Point(190, 426)
        Me.Id_BiciLabel1.Name = "Id_BiciLabel1"
        Me.Id_BiciLabel1.Size = New System.Drawing.Size(200, 23)
        Me.Id_BiciLabel1.TabIndex = 366
        Me.Id_BiciLabel1.Text = "Label2"
        '
        'ModeloComboBox
        '
        Me.ModeloComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DetalleProveedorBindingSource, "Modelo", True))
        Me.ModeloComboBox.DataSource = Me.AlmacenBindingSource
        Me.ModeloComboBox.DisplayMember = "Modelo"
        Me.ModeloComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ModeloComboBox.FormattingEnabled = True
        Me.ModeloComboBox.Location = New System.Drawing.Point(190, 465)
        Me.ModeloComboBox.Name = "ModeloComboBox"
        Me.ModeloComboBox.Size = New System.Drawing.Size(200, 28)
        Me.ModeloComboBox.TabIndex = 368
        Me.ModeloComboBox.ValueMember = "Modelo"
        '
        'AlmacenBindingSource
        '
        Me.AlmacenBindingSource.DataMember = "Almacen"
        Me.AlmacenBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'Precio_UnitarioTextBox
        '
        Me.Precio_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleProveedorBindingSource, "Precio_Unitario", True))
        Me.Precio_UnitarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Precio_UnitarioTextBox.Location = New System.Drawing.Point(572, 423)
        Me.Precio_UnitarioTextBox.Name = "Precio_UnitarioTextBox"
        Me.Precio_UnitarioTextBox.Size = New System.Drawing.Size(138, 26)
        Me.Precio_UnitarioTextBox.TabIndex = 370
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleProveedorBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CantidadTextBox.Location = New System.Drawing.Point(572, 465)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(138, 26)
        Me.CantidadTextBox.TabIndex = 372
        '
        'Importe_totalTextBox
        '
        Me.Importe_totalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleProveedorBindingSource, "Importe_total", True))
        Me.Importe_totalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Importe_totalTextBox.Location = New System.Drawing.Point(572, 508)
        Me.Importe_totalTextBox.Name = "Importe_totalTextBox"
        Me.Importe_totalTextBox.Size = New System.Drawing.Size(138, 26)
        Me.Importe_totalTextBox.TabIndex = 374
        '
        'FechaLLegadaDateTimePicker
        '
        Me.FechaLLegadaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DetalleProveedorBindingSource, "FechaLLegada", True))
        Me.FechaLLegadaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FechaLLegadaDateTimePicker.Location = New System.Drawing.Point(898, 508)
        Me.FechaLLegadaDateTimePicker.Name = "FechaLLegadaDateTimePicker"
        Me.FechaLLegadaDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.FechaLLegadaDateTimePicker.TabIndex = 382
        '
        'DetalleProveedorDataGridView
        '
        Me.DetalleProveedorDataGridView.AutoGenerateColumns = False
        Me.DetalleProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DetalleProveedorDataGridView.DataSource = Me.DetalleProveedorBindingSource
        Me.DetalleProveedorDataGridView.Location = New System.Drawing.Point(78, 580)
        Me.DetalleProveedorDataGridView.Name = "DetalleProveedorDataGridView"
        Me.DetalleProveedorDataGridView.Size = New System.Drawing.Size(943, 143)
        Me.DetalleProveedorDataGridView.TabIndex = 382
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Bici"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Artículo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Precio_Unitario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio Unitario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Importe_total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Importe total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FechaPedido"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Pedido"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FechaLLegada"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha Llegada"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'AlmacenTableAdapter
        '
        Me.AlmacenTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(111, 544)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 383
        Me.Label2.Text = "Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(190, 544)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 384
        '
        'ProvedorDetalleProveedorBindingSource
        '
        Me.ProvedorDetalleProveedorBindingSource.DataMember = "Provedor_DetalleProveedor"
        Me.ProvedorDetalleProveedorBindingSource.DataSource = Me.ProvedorBindingSource
        '
        'IdProveedor1
        '
        Me.IdProveedor1.BackColor = System.Drawing.Color.Transparent
        Me.IdProveedor1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Id", True))
        Me.IdProveedor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdProveedor1.Location = New System.Drawing.Point(313, 190)
        Me.IdProveedor1.Name = "IdProveedor1"
        Me.IdProveedor1.Size = New System.Drawing.Size(121, 23)
        Me.IdProveedor1.TabIndex = 391
        Me.IdProveedor1.Text = "Label7"
        '
        'ProveedorComboBox
        '
        Me.ProveedorComboBox.DataSource = Me.ProvedorBindingSource
        Me.ProveedorComboBox.DisplayMember = "Proveedor"
        Me.ProveedorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ProveedorComboBox.FormattingEnabled = True
        Me.ProveedorComboBox.Location = New System.Drawing.Point(317, 230)
        Me.ProveedorComboBox.Name = "ProveedorComboBox"
        Me.ProveedorComboBox.Size = New System.Drawing.Size(121, 28)
        Me.ProveedorComboBox.TabIndex = 393
        '
        'NombreLabel2
        '
        Me.NombreLabel2.BackColor = System.Drawing.Color.Transparent
        Me.NombreLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Nombre", True))
        Me.NombreLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreLabel2.Location = New System.Drawing.Point(313, 270)
        Me.NombreLabel2.Name = "NombreLabel2"
        Me.NombreLabel2.Size = New System.Drawing.Size(121, 23)
        Me.NombreLabel2.TabIndex = 395
        Me.NombreLabel2.Text = "Label7"
        '
        'DireccionLabel2
        '
        Me.DireccionLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DireccionLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Direccion", True))
        Me.DireccionLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DireccionLabel2.Location = New System.Drawing.Point(600, 305)
        Me.DireccionLabel2.Name = "DireccionLabel2"
        Me.DireccionLabel2.Size = New System.Drawing.Size(121, 23)
        Me.DireccionLabel2.TabIndex = 397
        Me.DireccionLabel2.Text = "Label7"
        '
        'NacionalidadLabel1
        '
        Me.NacionalidadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NacionalidadLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Nacionalidad", True))
        Me.NacionalidadLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NacionalidadLabel1.Location = New System.Drawing.Point(600, 270)
        Me.NacionalidadLabel1.Name = "NacionalidadLabel1"
        Me.NacionalidadLabel1.Size = New System.Drawing.Size(121, 23)
        Me.NacionalidadLabel1.TabIndex = 399
        Me.NacionalidadLabel1.Text = "Label7"
        '
        'WebLabel1
        '
        Me.WebLabel1.BackColor = System.Drawing.Color.Transparent
        Me.WebLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Web", True))
        Me.WebLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.WebLabel1.Location = New System.Drawing.Point(600, 190)
        Me.WebLabel1.Name = "WebLabel1"
        Me.WebLabel1.Size = New System.Drawing.Size(121, 23)
        Me.WebLabel1.TabIndex = 401
        Me.WebLabel1.Text = "Label7"
        '
        'E_MailLabel1
        '
        Me.E_MailLabel1.BackColor = System.Drawing.Color.Transparent
        Me.E_MailLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "EMail", True))
        Me.E_MailLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.E_MailLabel1.Location = New System.Drawing.Point(894, 190)
        Me.E_MailLabel1.Name = "E_MailLabel1"
        Me.E_MailLabel1.Size = New System.Drawing.Size(121, 23)
        Me.E_MailLabel1.TabIndex = 403
        Me.E_MailLabel1.Text = "Label7"
        '
        'CodigoPostalLabel1
        '
        Me.CodigoPostalLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CodigoPostalLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "CodigoPostal", True))
        Me.CodigoPostalLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CodigoPostalLabel1.Location = New System.Drawing.Point(894, 230)
        Me.CodigoPostalLabel1.Name = "CodigoPostalLabel1"
        Me.CodigoPostalLabel1.Size = New System.Drawing.Size(121, 23)
        Me.CodigoPostalLabel1.TabIndex = 405
        Me.CodigoPostalLabel1.Text = "Label7"
        '
        'ContactoLabel1
        '
        Me.ContactoLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ContactoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "Contacto", True))
        Me.ContactoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ContactoLabel1.Location = New System.Drawing.Point(600, 230)
        Me.ContactoLabel1.Name = "ContactoLabel1"
        Me.ContactoLabel1.Size = New System.Drawing.Size(121, 23)
        Me.ContactoLabel1.TabIndex = 407
        Me.ContactoLabel1.Text = "Label7"
        '
        'NIFLabel1
        '
        Me.NIFLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NIFLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProvedorBindingSource, "NIF", True))
        Me.NIFLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NIFLabel1.Location = New System.Drawing.Point(894, 270)
        Me.NIFLabel1.Name = "NIFLabel1"
        Me.NIFLabel1.Size = New System.Drawing.Size(121, 23)
        Me.NIFLabel1.TabIndex = 409
        Me.NIFLabel1.Text = "Label7"
        '
        'MarcaLabel2
        '
        Me.MarcaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MarcaLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleProveedorBindingSource, "Marca", True))
        Me.MarcaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MarcaLabel2.Location = New System.Drawing.Point(190, 510)
        Me.MarcaLabel2.Name = "MarcaLabel2"
        Me.MarcaLabel2.Size = New System.Drawing.Size(100, 23)
        Me.MarcaLabel2.TabIndex = 410
        Me.MarcaLabel2.Text = "Label7"
        '
        'FechaPedidoDateTimePicker
        '
        Me.FechaPedidoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DetalleProveedorBindingSource, "FechaPedido", True))
        Me.FechaPedidoDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FechaPedidoDateTimePicker.Location = New System.Drawing.Point(898, 465)
        Me.FechaPedidoDateTimePicker.Name = "FechaPedidoDateTimePicker"
        Me.FechaPedidoDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.FechaPedidoDateTimePicker.TabIndex = 411
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(446, 85)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 36)
        Me.Button4.TabIndex = 415
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(301, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 416
        Me.Label1.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(383, 85)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 40)
        Me.Button3.TabIndex = 414
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(235, 85)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 40)
        Me.Button2.TabIndex = 413
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(167, 85)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 36)
        Me.Button1.TabIndex = 412
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.informe2
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(898, 344)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 55)
        Me.Button5.TabIndex = 417
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PedidosProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.pedidos_a_proveedores
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1177, 733)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FechaPedidoDateTimePicker)
        Me.Controls.Add(Me.MarcaLabel2)
        Me.Controls.Add(IdLabel1)
        Me.Controls.Add(Me.IdProveedor1)
        Me.Controls.Add(ProveedorLabel1)
        Me.Controls.Add(Me.ProveedorComboBox)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.NombreLabel2)
        Me.Controls.Add(DireccionLabel1)
        Me.Controls.Add(Me.DireccionLabel2)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(Me.NacionalidadLabel1)
        Me.Controls.Add(WebLabel)
        Me.Controls.Add(Me.WebLabel1)
        Me.Controls.Add(E_MailLabel)
        Me.Controls.Add(Me.E_MailLabel1)
        Me.Controls.Add(CodigoPostalLabel)
        Me.Controls.Add(Me.CodigoPostalLabel1)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoLabel1)
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DetalleProveedorDataGridView)
        Me.Controls.Add(Id_BiciLabel)
        Me.Controls.Add(Me.Id_BiciLabel1)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloComboBox)
        Me.Controls.Add(Precio_UnitarioLabel)
        Me.Controls.Add(Me.Precio_UnitarioTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Importe_totalLabel)
        Me.Controls.Add(Me.Importe_totalTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(FechaPedidoLabel)
        Me.Controls.Add(FechaLLegadaLabel)
        Me.Controls.Add(Me.FechaLLegadaDateTimePicker)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button17)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PedidosProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PedidosProveedor"
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvedorDetalleProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ProvedorBindingSource As BindingSource
    Friend WithEvents Button11 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button19 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents ProvedorTableAdapter As ProyectoFinalDataSetTableAdapters.ProvedorTableAdapter
    Friend WithEvents DetalleProveedorBindingSource As BindingSource
    Friend WithEvents DetalleProveedorTableAdapter As ProyectoFinalDataSetTableAdapters.DetalleProveedorTableAdapter
    Friend WithEvents DetalleProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Id_BiciLabel1 As Label
    Friend WithEvents ModeloComboBox As ComboBox
    Friend WithEvents Precio_UnitarioTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents Importe_totalTextBox As TextBox
    Friend WithEvents FechaLLegadaDateTimePicker As DateTimePicker
    Friend WithEvents AlmacenBindingSource As BindingSource
    Friend WithEvents AlmacenTableAdapter As ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProvedorDetalleProveedorBindingSource As BindingSource
    Friend WithEvents IdProveedor1 As Label
    Friend WithEvents ProveedorComboBox As ComboBox
    Friend WithEvents NombreLabel2 As Label
    Friend WithEvents DireccionLabel2 As Label
    Friend WithEvents NacionalidadLabel1 As Label
    Friend WithEvents WebLabel1 As Label
    Friend WithEvents E_MailLabel1 As Label
    Friend WithEvents CodigoPostalLabel1 As Label
    Friend WithEvents ContactoLabel1 As Label
    Friend WithEvents NIFLabel1 As Label
    Friend WithEvents MarcaLabel2 As Label
    Friend WithEvents FechaPedidoDateTimePicker As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
