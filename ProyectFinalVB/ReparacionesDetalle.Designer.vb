<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReparacionesDetalle
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
        Dim IdArticuloLabel As System.Windows.Forms.Label
        Dim ArticuloLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioUnitarioLabel As System.Windows.Forms.Label
        Dim ImporteTotalLabel As System.Windows.Forms.Label
        Dim ModeloDetalleLabel As System.Windows.Forms.Label
        Dim FechaSalidaLabel As System.Windows.Forms.Label
        Dim FechaEntrgaLabel As System.Windows.Forms.Label
        Dim DetallesLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreUsuarioLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReparacionesDetalle))
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ReparacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReparacionesTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ReparacionesTableAdapter()
        Me.AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.DetalleReparacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleReparacionTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.DetalleReparacionTableAdapter()
        Me.IdArticuloLabel1 = New System.Windows.Forms.Label()
        Me.ArticuloLabel1 = New System.Windows.Forms.Label()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioUnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.ImporteTotalTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleReparacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDetalleComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FechaSalidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaEntrgaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TelefonoLabel1 = New System.Windows.Forms.Label()
        Me.ApellidosLabel1 = New System.Windows.Forms.Label()
        Me.UsuarioLabel1 = New System.Windows.Forms.Label()
        Me.IdReparacion = New System.Windows.Forms.Label()
        Me.MarcaLabel2 = New System.Windows.Forms.Label()
        Me.ModeloLabel3 = New System.Windows.Forms.Label()
        Me.DetallesLabel2 = New System.Windows.Forms.Label()
        Me.NombreUsuarioLabel1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        IdArticuloLabel = New System.Windows.Forms.Label()
        ArticuloLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioUnitarioLabel = New System.Windows.Forms.Label()
        ImporteTotalLabel = New System.Windows.Forms.Label()
        ModeloDetalleLabel = New System.Windows.Forms.Label()
        FechaSalidaLabel = New System.Windows.Forms.Label()
        FechaEntrgaLabel = New System.Windows.Forms.Label()
        DetallesLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        NombreUsuarioLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReparacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleReparacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleReparacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdArticuloLabel
        '
        IdArticuloLabel.AutoSize = True
        IdArticuloLabel.BackColor = System.Drawing.Color.Transparent
        IdArticuloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdArticuloLabel.Location = New System.Drawing.Point(146, 403)
        IdArticuloLabel.Name = "IdArticuloLabel"
        IdArticuloLabel.Size = New System.Drawing.Size(96, 20)
        IdArticuloLabel.TabIndex = 306
        IdArticuloLabel.Text = "Id Artículo:"
        '
        'ArticuloLabel
        '
        ArticuloLabel.AutoSize = True
        ArticuloLabel.BackColor = System.Drawing.Color.Transparent
        ArticuloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ArticuloLabel.Location = New System.Drawing.Point(398, 403)
        ArticuloLabel.Name = "ArticuloLabel"
        ArticuloLabel.Size = New System.Drawing.Size(63, 20)
        ArticuloLabel.TabIndex = 308
        ArticuloLabel.Text = "Marca:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.BackColor = System.Drawing.Color.Transparent
        CantidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CantidadLabel.Location = New System.Drawing.Point(728, 403)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(86, 20)
        CantidadLabel.TabIndex = 312
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioUnitarioLabel
        '
        PrecioUnitarioLabel.AutoSize = True
        PrecioUnitarioLabel.BackColor = System.Drawing.Color.Transparent
        PrecioUnitarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PrecioUnitarioLabel.Location = New System.Drawing.Point(682, 453)
        PrecioUnitarioLabel.Name = "PrecioUnitarioLabel"
        PrecioUnitarioLabel.Size = New System.Drawing.Size(132, 20)
        PrecioUnitarioLabel.TabIndex = 314
        PrecioUnitarioLabel.Text = "Precio Unitario:"
        '
        'ImporteTotalLabel
        '
        ImporteTotalLabel.AutoSize = True
        ImporteTotalLabel.BackColor = System.Drawing.Color.Transparent
        ImporteTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ImporteTotalLabel.Location = New System.Drawing.Point(693, 503)
        ImporteTotalLabel.Name = "ImporteTotalLabel"
        ImporteTotalLabel.Size = New System.Drawing.Size(121, 20)
        ImporteTotalLabel.TabIndex = 316
        ImporteTotalLabel.Text = "Importe Total:"
        '
        'ModeloDetalleLabel
        '
        ModeloDetalleLabel.AutoSize = True
        ModeloDetalleLabel.BackColor = System.Drawing.Color.Transparent
        ModeloDetalleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ModeloDetalleLabel.Location = New System.Drawing.Point(389, 453)
        ModeloDetalleLabel.Name = "ModeloDetalleLabel"
        ModeloDetalleLabel.Size = New System.Drawing.Size(72, 20)
        ModeloDetalleLabel.TabIndex = 317
        ModeloDetalleLabel.Text = "Modelo:"
        '
        'FechaSalidaLabel
        '
        FechaSalidaLabel.AutoSize = True
        FechaSalidaLabel.BackColor = System.Drawing.Color.Transparent
        FechaSalidaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        FechaSalidaLabel.Location = New System.Drawing.Point(736, 250)
        FechaSalidaLabel.Name = "FechaSalidaLabel"
        FechaSalidaLabel.Size = New System.Drawing.Size(141, 20)
        FechaSalidaLabel.TabIndex = 272
        FechaSalidaLabel.Text = "Fecha de salida:"
        '
        'FechaEntrgaLabel
        '
        FechaEntrgaLabel.AutoSize = True
        FechaEntrgaLabel.BackColor = System.Drawing.Color.Transparent
        FechaEntrgaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        FechaEntrgaLabel.Location = New System.Drawing.Point(736, 170)
        FechaEntrgaLabel.Name = "FechaEntrgaLabel"
        FechaEntrgaLabel.Size = New System.Drawing.Size(156, 20)
        FechaEntrgaLabel.TabIndex = 270
        FechaEntrgaLabel.Text = "Fecha de entrega:"
        '
        'DetallesLabel
        '
        DetallesLabel.AutoSize = True
        DetallesLabel.BackColor = System.Drawing.Color.Transparent
        DetallesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DetallesLabel.Location = New System.Drawing.Point(453, 230)
        DetallesLabel.Name = "DetallesLabel"
        DetallesLabel.Size = New System.Drawing.Size(80, 20)
        DetallesLabel.TabIndex = 268
        DetallesLabel.Text = "Detalles:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ModeloLabel.Location = New System.Drawing.Point(463, 200)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(72, 20)
        ModeloLabel.TabIndex = 266
        ModeloLabel.Text = "Modelo:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = System.Drawing.Color.Transparent
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        MarcaLabel.Location = New System.Drawing.Point(470, 170)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(63, 20)
        MarcaLabel.TabIndex = 264
        MarcaLabel.Text = "Marca:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.Transparent
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        TelefonoLabel.Location = New System.Drawing.Point(121, 260)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(84, 20)
        TelefonoLabel.TabIndex = 262
        TelefonoLabel.Text = "Teléfono:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.BackColor = System.Drawing.Color.Transparent
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ApellidosLabel.Location = New System.Drawing.Point(120, 230)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(87, 20)
        ApellidosLabel.TabIndex = 260
        ApellidosLabel.Text = "Apellidos:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        UsuarioLabel.Location = New System.Drawing.Point(129, 200)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(76, 20)
        UsuarioLabel.TabIndex = 258
        UsuarioLabel.Text = "Nombre:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdLabel.Location = New System.Drawing.Point(175, 170)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 20)
        IdLabel.TabIndex = 254
        IdLabel.Text = "Id:"
        '
        'NombreUsuarioLabel
        '
        NombreUsuarioLabel.AutoSize = True
        NombreUsuarioLabel.BackColor = System.Drawing.Color.Transparent
        NombreUsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NombreUsuarioLabel.Location = New System.Drawing.Point(164, 290)
        NombreUsuarioLabel.Name = "NombreUsuarioLabel"
        NombreUsuarioLabel.Size = New System.Drawing.Size(43, 20)
        NombreUsuarioLabel.TabIndex = 320
        NombreUsuarioLabel.Text = "NIF:"
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(583, 588)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 238
        Me.Label5.Text = "Cancelar cambios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(422, 588)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 236
        Me.Label6.Text = "Guardar cambios"
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Transparent
        Me.Button19.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.add
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Location = New System.Drawing.Point(683, 333)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(42, 40)
        Me.Button19.TabIndex = 227
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(497, 335)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(47, 36)
        Me.Button8.TabIndex = 235
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(332, 343)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 234
        Me.Label4.Text = "Label4"
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Location = New System.Drawing.Point(424, 333)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(42, 40)
        Me.Button16.TabIndex = 233
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Transparent
        Me.Button18.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Location = New System.Drawing.Point(179, 333)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(47, 36)
        Me.Button18.TabIndex = 231
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.eliminar
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(751, 328)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(54, 51)
        Me.Button10.TabIndex = 228
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
        Me.Button14.Location = New System.Drawing.Point(416, 531)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(102, 70)
        Me.Button14.TabIndex = 229
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.cancelar
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(579, 531)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(102, 70)
        Me.Button15.TabIndex = 230
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Location = New System.Drawing.Point(262, 331)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(42, 40)
        Me.Button17.TabIndex = 232
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(497, 53)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 36)
        Me.Button4.TabIndex = 200
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(424, 53)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 40)
        Me.Button3.TabIndex = 199
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(262, 53)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 40)
        Me.Button2.TabIndex = 198
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(179, 53)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 36)
        Me.Button1.TabIndex = 197
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(332, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Label1"
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        'AlmacenBindingSource
        '
        Me.AlmacenBindingSource.DataMember = "Almacen"
        Me.AlmacenBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'AlmacenTableAdapter
        '
        Me.AlmacenTableAdapter.ClearBeforeFill = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.guardar
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(949, 326)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 55)
        Me.Button11.TabIndex = 291
        Me.Button11.UseVisualStyleBackColor = False
        '
        'DetalleReparacionBindingSource
        '
        Me.DetalleReparacionBindingSource.DataMember = "Reparaciones_DetalleReparacion"
        Me.DetalleReparacionBindingSource.DataSource = Me.ReparacionesBindingSource
        '
        'DetalleReparacionTableAdapter
        '
        Me.DetalleReparacionTableAdapter.ClearBeforeFill = True
        '
        'IdArticuloLabel1
        '
        Me.IdArticuloLabel1.BackColor = System.Drawing.Color.Transparent
        Me.IdArticuloLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleReparacionBindingSource, "idArticulo", True))
        Me.IdArticuloLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdArticuloLabel1.Location = New System.Drawing.Point(258, 403)
        Me.IdArticuloLabel1.Name = "IdArticuloLabel1"
        Me.IdArticuloLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdArticuloLabel1.TabIndex = 307
        Me.IdArticuloLabel1.Text = "Label2"
        '
        'ArticuloLabel1
        '
        Me.ArticuloLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ArticuloLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleReparacionBindingSource, "Articulo", True))
        Me.ArticuloLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ArticuloLabel1.Location = New System.Drawing.Point(491, 403)
        Me.ArticuloLabel1.Name = "ArticuloLabel1"
        Me.ArticuloLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ArticuloLabel1.TabIndex = 309
        Me.ArticuloLabel1.Text = "Label2"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleReparacionBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CantidadTextBox.Location = New System.Drawing.Point(851, 403)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CantidadTextBox.TabIndex = 313
        '
        'PrecioUnitarioTextBox
        '
        Me.PrecioUnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleReparacionBindingSource, "PrecioUnitario", True))
        Me.PrecioUnitarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PrecioUnitarioTextBox.Location = New System.Drawing.Point(851, 453)
        Me.PrecioUnitarioTextBox.Name = "PrecioUnitarioTextBox"
        Me.PrecioUnitarioTextBox.Size = New System.Drawing.Size(100, 26)
        Me.PrecioUnitarioTextBox.TabIndex = 315
        '
        'ImporteTotalTextBox
        '
        Me.ImporteTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleReparacionBindingSource, "ImporteTotal", True))
        Me.ImporteTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ImporteTotalTextBox.Location = New System.Drawing.Point(851, 503)
        Me.ImporteTotalTextBox.Name = "ImporteTotalTextBox"
        Me.ImporteTotalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ImporteTotalTextBox.TabIndex = 317
        '
        'DetalleReparacionDataGridView
        '
        Me.DetalleReparacionDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetalleReparacionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DetalleReparacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleReparacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DetalleReparacionDataGridView.DataSource = Me.DetalleReparacionBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DetalleReparacionDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DetalleReparacionDataGridView.Location = New System.Drawing.Point(134, 553)
        Me.DetalleReparacionDataGridView.Name = "DetalleReparacionDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetalleReparacionDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DetalleReparacionDataGridView.Size = New System.Drawing.Size(743, 111)
        Me.DetalleReparacionDataGridView.TabIndex = 317
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idArticulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Artículo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Articulo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ModeloDetalle"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PrecioUnitario"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Precio Unitario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ImporteTotal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importe Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ModeloDetalleComboBox
        '
        Me.ModeloDetalleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DetalleReparacionBindingSource, "ModeloDetalle", True))
        Me.ModeloDetalleComboBox.DataSource = Me.AlmacenBindingSource
        Me.ModeloDetalleComboBox.DisplayMember = "Modelo"
        Me.ModeloDetalleComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ModeloDetalleComboBox.FormattingEnabled = True
        Me.ModeloDetalleComboBox.Location = New System.Drawing.Point(491, 453)
        Me.ModeloDetalleComboBox.Name = "ModeloDetalleComboBox"
        Me.ModeloDetalleComboBox.Size = New System.Drawing.Size(121, 28)
        Me.ModeloDetalleComboBox.TabIndex = 318
        Me.ModeloDetalleComboBox.ValueMember = "Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(493, 503)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 319
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(401, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 320
        Me.Label3.Text = "Stock:"
        '
        'FechaSalidaDateTimePicker
        '
        Me.FechaSalidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReparacionesBindingSource, "fechaSalida", True))
        Me.FechaSalidaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FechaSalidaDateTimePicker.Location = New System.Drawing.Point(740, 280)
        Me.FechaSalidaDateTimePicker.Name = "FechaSalidaDateTimePicker"
        Me.FechaSalidaDateTimePicker.Size = New System.Drawing.Size(229, 26)
        Me.FechaSalidaDateTimePicker.TabIndex = 273
        '
        'FechaEntrgaDateTimePicker
        '
        Me.FechaEntrgaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReparacionesBindingSource, "fechaEntrga", True))
        Me.FechaEntrgaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FechaEntrgaDateTimePicker.Location = New System.Drawing.Point(740, 200)
        Me.FechaEntrgaDateTimePicker.Name = "FechaEntrgaDateTimePicker"
        Me.FechaEntrgaDateTimePicker.Size = New System.Drawing.Size(229, 26)
        Me.FechaEntrgaDateTimePicker.TabIndex = 271
        '
        'TelefonoLabel1
        '
        Me.TelefonoLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TelefonoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "telefono", True))
        Me.TelefonoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TelefonoLabel1.Location = New System.Drawing.Point(222, 260)
        Me.TelefonoLabel1.Name = "TelefonoLabel1"
        Me.TelefonoLabel1.Size = New System.Drawing.Size(134, 23)
        Me.TelefonoLabel1.TabIndex = 263
        Me.TelefonoLabel1.Text = "Label7"
        '
        'ApellidosLabel1
        '
        Me.ApellidosLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ApellidosLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "apellidos", True))
        Me.ApellidosLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ApellidosLabel1.Location = New System.Drawing.Point(222, 230)
        Me.ApellidosLabel1.Name = "ApellidosLabel1"
        Me.ApellidosLabel1.Size = New System.Drawing.Size(134, 23)
        Me.ApellidosLabel1.TabIndex = 261
        Me.ApellidosLabel1.Text = "Label7"
        '
        'UsuarioLabel1
        '
        Me.UsuarioLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UsuarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "usuario", True))
        Me.UsuarioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UsuarioLabel1.Location = New System.Drawing.Point(222, 200)
        Me.UsuarioLabel1.Name = "UsuarioLabel1"
        Me.UsuarioLabel1.Size = New System.Drawing.Size(134, 23)
        Me.UsuarioLabel1.TabIndex = 259
        Me.UsuarioLabel1.Text = "Label7"
        '
        'IdReparacion
        '
        Me.IdReparacion.BackColor = System.Drawing.Color.Transparent
        Me.IdReparacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "Id", True))
        Me.IdReparacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdReparacion.Location = New System.Drawing.Point(222, 170)
        Me.IdReparacion.Name = "IdReparacion"
        Me.IdReparacion.Size = New System.Drawing.Size(69, 23)
        Me.IdReparacion.TabIndex = 255
        Me.IdReparacion.Text = "Label7"
        '
        'MarcaLabel2
        '
        Me.MarcaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MarcaLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "marca", True))
        Me.MarcaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MarcaLabel2.Location = New System.Drawing.Point(557, 170)
        Me.MarcaLabel2.Name = "MarcaLabel2"
        Me.MarcaLabel2.Size = New System.Drawing.Size(100, 23)
        Me.MarcaLabel2.TabIndex = 288
        Me.MarcaLabel2.Text = "Label2"
        '
        'ModeloLabel3
        '
        Me.ModeloLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ModeloLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "modelo", True))
        Me.ModeloLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ModeloLabel3.Location = New System.Drawing.Point(557, 200)
        Me.ModeloLabel3.Name = "ModeloLabel3"
        Me.ModeloLabel3.Size = New System.Drawing.Size(100, 23)
        Me.ModeloLabel3.TabIndex = 289
        Me.ModeloLabel3.Text = "Label2"
        '
        'DetallesLabel2
        '
        Me.DetallesLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DetallesLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "Detalles", True))
        Me.DetallesLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DetallesLabel2.Location = New System.Drawing.Point(456, 260)
        Me.DetallesLabel2.Name = "DetallesLabel2"
        Me.DetallesLabel2.Size = New System.Drawing.Size(218, 53)
        Me.DetallesLabel2.TabIndex = 290
        Me.DetallesLabel2.Text = "Label2"
        '
        'NombreUsuarioLabel1
        '
        Me.NombreUsuarioLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NombreUsuarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReparacionesBindingSource, "nombreUsuario", True))
        Me.NombreUsuarioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreUsuarioLabel1.Location = New System.Drawing.Point(222, 290)
        Me.NombreUsuarioLabel1.Name = "NombreUsuarioLabel1"
        Me.NombreUsuarioLabel1.Size = New System.Drawing.Size(133, 23)
        Me.NombreUsuarioLabel1.TabIndex = 321
        Me.NombreUsuarioLabel1.Text = "Label7"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.informe2
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(887, 326)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 55)
        Me.Button5.TabIndex = 322
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ReparacionesDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.Reparaciones_a_realizar
        Me.ClientSize = New System.Drawing.Size(1040, 643)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(NombreUsuarioLabel)
        Me.Controls.Add(Me.NombreUsuarioLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(ModeloDetalleLabel)
        Me.Controls.Add(Me.ModeloDetalleComboBox)
        Me.Controls.Add(Me.DetalleReparacionDataGridView)
        Me.Controls.Add(IdArticuloLabel)
        Me.Controls.Add(Me.IdArticuloLabel1)
        Me.Controls.Add(ArticuloLabel)
        Me.Controls.Add(Me.ArticuloLabel1)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(PrecioUnitarioLabel)
        Me.Controls.Add(Me.PrecioUnitarioTextBox)
        Me.Controls.Add(ImporteTotalLabel)
        Me.Controls.Add(Me.ImporteTotalTextBox)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.DetallesLabel2)
        Me.Controls.Add(Me.ModeloLabel3)
        Me.Controls.Add(Me.MarcaLabel2)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdReparacion)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioLabel1)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosLabel1)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoLabel1)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(DetallesLabel)
        Me.Controls.Add(FechaEntrgaLabel)
        Me.Controls.Add(Me.FechaEntrgaDateTimePicker)
        Me.Controls.Add(FechaSalidaLabel)
        Me.Controls.Add(Me.FechaSalidaDateTimePicker)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReparacionesDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReparacionesDetalle"
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReparacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleReparacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleReparacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button19 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ReparacionesBindingSource As BindingSource
    Friend WithEvents ReparacionesTableAdapter As ProyectoFinalDataSetTableAdapters.ReparacionesTableAdapter
    Friend WithEvents AlmacenBindingSource As BindingSource
    Friend WithEvents AlmacenTableAdapter As ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter
    Friend WithEvents Button11 As Button
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DetalleReparacionBindingSource As BindingSource
    Friend WithEvents DetalleReparacionTableAdapter As ProyectoFinalDataSetTableAdapters.DetalleReparacionTableAdapter
    Friend WithEvents ModeloDetalleComboBox As ComboBox
    Friend WithEvents DetalleReparacionDataGridView As DataGridView
    Friend WithEvents IdArticuloLabel1 As Label
    Friend WithEvents ArticuloLabel1 As Label
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents PrecioUnitarioTextBox As TextBox
    Friend WithEvents ImporteTotalTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DetallesLabel2 As Label
    Friend WithEvents ModeloLabel3 As Label
    Friend WithEvents MarcaLabel2 As Label
    Friend WithEvents IdReparacion As Label
    Friend WithEvents UsuarioLabel1 As Label
    Friend WithEvents ApellidosLabel1 As Label
    Friend WithEvents TelefonoLabel1 As Label
    Friend WithEvents FechaEntrgaDateTimePicker As DateTimePicker
    Friend WithEvents FechaSalidaDateTimePicker As DateTimePicker
    Friend WithEvents NombreUsuarioLabel1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
