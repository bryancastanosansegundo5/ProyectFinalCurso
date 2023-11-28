<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim LetraPisoLabel As System.Windows.Forms.Label
        Dim PisoLabel As System.Windows.Forms.Label
        Dim PortalLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim Id_BiciLabel2 As System.Windows.Forms.Label
        Dim BiciLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim Precio_UnitarioLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Importe_totalLabel As System.Windows.Forms.Label
        Dim Fecha_VentaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.VentasTableAdapter()
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UsuarioTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.UsuarioTableAdapter()
        Me.AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AlmacenTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter()
        Me.DetalleVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleVentaTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.DetalleVentaTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.ClientesTableAdapter()
        Me.LetraPisoTextBox = New System.Windows.Forms.TextBox()
        Me.PisoTextBox = New System.Windows.Forms.TextBox()
        Me.PortalTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosLabel1 = New System.Windows.Forms.Label()
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.UsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleVentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_BiciLabel3 = New System.Windows.Forms.Label()
        Me.Precio_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Importe_totalTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloComboBox = New System.Windows.Forms.ComboBox()
        Me.BiciLabel2 = New System.Windows.Forms.Label()
        Me.Fecha_VentaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button13 = New System.Windows.Forms.Button()
        LetraPisoLabel = New System.Windows.Forms.Label()
        PisoLabel = New System.Windows.Forms.Label()
        PortalLabel = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        Id_BiciLabel2 = New System.Windows.Forms.Label()
        BiciLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Importe_totalLabel = New System.Windows.Forms.Label()
        Fecha_VentaLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleVentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LetraPisoLabel
        '
        LetraPisoLabel.AutoSize = True
        LetraPisoLabel.BackColor = System.Drawing.Color.Transparent
        LetraPisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        LetraPisoLabel.Location = New System.Drawing.Point(873, 260)
        LetraPisoLabel.Name = "LetraPisoLabel"
        LetraPisoLabel.Size = New System.Drawing.Size(95, 20)
        LetraPisoLabel.TabIndex = 149
        LetraPisoLabel.Text = "Letra Piso:"
        '
        'PisoLabel
        '
        PisoLabel.AutoSize = True
        PisoLabel.BackColor = System.Drawing.Color.Transparent
        PisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PisoLabel.Location = New System.Drawing.Point(920, 220)
        PisoLabel.Name = "PisoLabel"
        PisoLabel.Size = New System.Drawing.Size(48, 20)
        PisoLabel.TabIndex = 147
        PisoLabel.Text = "Piso:"
        '
        'PortalLabel
        '
        PortalLabel.AutoSize = True
        PortalLabel.BackColor = System.Drawing.Color.Transparent
        PortalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PortalLabel.Location = New System.Drawing.Point(907, 180)
        PortalLabel.Name = "PortalLabel"
        PortalLabel.Size = New System.Drawing.Size(61, 20)
        PortalLabel.TabIndex = 145
        PortalLabel.Text = "Portal:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.BackColor = System.Drawing.Color.Transparent
        CalleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CalleLabel.Location = New System.Drawing.Point(520, 260)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(54, 20)
        CalleLabel.TabIndex = 143
        CalleLabel.Text = "Calle:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.BackColor = System.Drawing.Color.Transparent
        LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        LocalidadLabel.Location = New System.Drawing.Point(486, 220)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(91, 20)
        LocalidadLabel.TabIndex = 141
        LocalidadLabel.Text = "Localidad:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.Transparent
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        TelefonoLabel.Location = New System.Drawing.Point(156, 300)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(84, 20)
        TelefonoLabel.TabIndex = 137
        TelefonoLabel.Text = "Teléfono:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.BackColor = System.Drawing.Color.Transparent
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ApellidosLabel.Location = New System.Drawing.Point(156, 260)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(87, 20)
        ApellidosLabel.TabIndex = 135
        ApellidosLabel.Text = "Apellidos:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(164, 220)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(76, 20)
        NombreLabel.TabIndex = 133
        NombreLabel.Text = "Nombre:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        UsuarioLabel.Location = New System.Drawing.Point(197, 180)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(43, 20)
        UsuarioLabel.TabIndex = 131
        UsuarioLabel.Text = "NIF:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdLabel.Location = New System.Drawing.Point(35, 180)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 20)
        IdLabel.TabIndex = 129
        IdLabel.Text = "Id:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.BackColor = System.Drawing.Color.Transparent
        ProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ProvinciaLabel.Location = New System.Drawing.Point(491, 180)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(86, 20)
        ProvinciaLabel.TabIndex = 193
        ProvinciaLabel.Text = "Provincia:"
        '
        'Id_BiciLabel2
        '
        Id_BiciLabel2.AutoSize = True
        Id_BiciLabel2.BackColor = System.Drawing.Color.Transparent
        Id_BiciLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Id_BiciLabel2.Location = New System.Drawing.Point(135, 447)
        Id_BiciLabel2.Name = "Id_BiciLabel2"
        Id_BiciLabel2.Size = New System.Drawing.Size(96, 20)
        Id_BiciLabel2.TabIndex = 196
        Id_BiciLabel2.Text = "Id Artículo:"
        '
        'BiciLabel
        '
        BiciLabel.AutoSize = True
        BiciLabel.BackColor = System.Drawing.Color.Transparent
        BiciLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        BiciLabel.Location = New System.Drawing.Point(373, 497)
        BiciLabel.Name = "BiciLabel"
        BiciLabel.Size = New System.Drawing.Size(63, 20)
        BiciLabel.TabIndex = 198
        BiciLabel.Text = "Marca:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ModeloLabel.Location = New System.Drawing.Point(364, 447)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(72, 20)
        ModeloLabel.TabIndex = 200
        ModeloLabel.Text = "Modelo:"
        '
        'Precio_UnitarioLabel
        '
        Precio_UnitarioLabel.AutoSize = True
        Precio_UnitarioLabel.BackColor = System.Drawing.Color.Transparent
        Precio_UnitarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Precio_UnitarioLabel.Location = New System.Drawing.Point(304, 547)
        Precio_UnitarioLabel.Name = "Precio_UnitarioLabel"
        Precio_UnitarioLabel.Size = New System.Drawing.Size(132, 20)
        Precio_UnitarioLabel.TabIndex = 202
        Precio_UnitarioLabel.Text = "Precio Unitario:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.BackColor = System.Drawing.Color.Transparent
        CantidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CantidadLabel.Location = New System.Drawing.Point(729, 447)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(86, 20)
        CantidadLabel.TabIndex = 204
        CantidadLabel.Text = "Cantidad:"
        '
        'Importe_totalLabel
        '
        Importe_totalLabel.AutoSize = True
        Importe_totalLabel.BackColor = System.Drawing.Color.Transparent
        Importe_totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Importe_totalLabel.Location = New System.Drawing.Point(698, 547)
        Importe_totalLabel.Name = "Importe_totalLabel"
        Importe_totalLabel.Size = New System.Drawing.Size(117, 20)
        Importe_totalLabel.TabIndex = 206
        Importe_totalLabel.Text = "Importe total:"
        '
        'Fecha_VentaLabel
        '
        Fecha_VentaLabel.AutoSize = True
        Fecha_VentaLabel.BackColor = System.Drawing.Color.Transparent
        Fecha_VentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Fecha_VentaLabel.Location = New System.Drawing.Point(851, 300)
        Fecha_VentaLabel.Name = "Fecha_VentaLabel"
        Fecha_VentaLabel.Size = New System.Drawing.Size(117, 20)
        Fecha_VentaLabel.TabIndex = 209
        Fecha_VentaLabel.Text = "Fecha Venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(368, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(598, 401)
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
        Me.Label2.Location = New System.Drawing.Point(477, 401)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Guardar cambios"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.guardar
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(1043, 61)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 55)
        Me.Button11.TabIndex = 121
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.eliminar
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(806, 58)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 51)
        Me.Button9.TabIndex = 127
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.add
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(738, 63)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 40)
        Me.Button6.TabIndex = 126
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(552, 63)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 36)
        Me.Button4.TabIndex = 125
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(483, 61)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 40)
        Me.Button3.TabIndex = 124
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(272, 61)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 40)
        Me.Button2.TabIndex = 123
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(196, 63)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 36)
        Me.Button1.TabIndex = 122
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
        Me.Button7.Location = New System.Drawing.Point(468, 343)
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
        Me.Button5.Location = New System.Drawing.Point(592, 343)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 70)
        Me.Button5.TabIndex = 118
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'AlmacenBindingSource
        '
        Me.AlmacenBindingSource.DataMember = "Almacen"
        Me.AlmacenBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Transparent
        Me.Button19.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.add
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Location = New System.Drawing.Point(721, 371)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(42, 40)
        Me.Button19.TabIndex = 166
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ultimo
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(535, 375)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(47, 36)
        Me.Button8.TabIndex = 174
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(351, 383)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Label4"
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.sigueinte
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Location = New System.Drawing.Point(454, 373)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(42, 40)
        Me.Button16.TabIndex = 172
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.anterior
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Location = New System.Drawing.Point(272, 373)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(42, 40)
        Me.Button17.TabIndex = 171
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Transparent
        Me.Button18.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.primero
        Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Location = New System.Drawing.Point(190, 375)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(47, 36)
        Me.Button18.TabIndex = 170
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.eliminar
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(789, 366)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(54, 51)
        Me.Button10.TabIndex = 167
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
        Me.Button14.Location = New System.Drawing.Point(448, 583)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(102, 70)
        Me.Button14.TabIndex = 168
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.cancelar
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(590, 583)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(102, 70)
        Me.Button15.TabIndex = 169
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(596, 642)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "Cancelar cambios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(455, 642)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = "Guardar cambios"
        '
        'AlmacenTableAdapter
        '
        Me.AlmacenTableAdapter.ClearBeforeFill = True
        '
        'DetalleVentaBindingSource
        '
        Me.DetalleVentaBindingSource.DataMember = "Ventas_DetalleVenta"
        Me.DetalleVentaBindingSource.DataSource = Me.VentasBindingSource
        '
        'DetalleVentaTableAdapter
        '
        Me.DetalleVentaTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(829, 497)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 192
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(755, 497)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 193
        Me.Label8.Text = "Stock:"
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
        'LetraPisoTextBox
        '
        Me.LetraPisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "LetraPiso", True))
        Me.LetraPisoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LetraPisoTextBox.Location = New System.Drawing.Point(984, 260)
        Me.LetraPisoTextBox.Name = "LetraPisoTextBox"
        Me.LetraPisoTextBox.Size = New System.Drawing.Size(33, 26)
        Me.LetraPisoTextBox.TabIndex = 150
        '
        'PisoTextBox
        '
        Me.PisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Piso", True))
        Me.PisoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PisoTextBox.Location = New System.Drawing.Point(984, 220)
        Me.PisoTextBox.Name = "PisoTextBox"
        Me.PisoTextBox.Size = New System.Drawing.Size(226, 26)
        Me.PisoTextBox.TabIndex = 148
        '
        'PortalTextBox
        '
        Me.PortalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Portal", True))
        Me.PortalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PortalTextBox.Location = New System.Drawing.Point(984, 180)
        Me.PortalTextBox.Name = "PortalTextBox"
        Me.PortalTextBox.Size = New System.Drawing.Size(226, 26)
        Me.PortalTextBox.TabIndex = 146
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Calle", True))
        Me.CalleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CalleTextBox.Location = New System.Drawing.Point(590, 260)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CalleTextBox.TabIndex = 144
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LocalidadTextBox.Location = New System.Drawing.Point(590, 220)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(200, 26)
        Me.LocalidadTextBox.TabIndex = 142
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TelefonoTextBox.Location = New System.Drawing.Point(252, 300)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TelefonoTextBox.TabIndex = 138
        '
        'ApellidosLabel1
        '
        Me.ApellidosLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ApellidosLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Apellidos", True))
        Me.ApellidosLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ApellidosLabel1.Location = New System.Drawing.Point(252, 260)
        Me.ApellidosLabel1.Name = "ApellidosLabel1"
        Me.ApellidosLabel1.Size = New System.Drawing.Size(200, 23)
        Me.ApellidosLabel1.TabIndex = 136
        Me.ApellidosLabel1.Text = "Label4"
        '
        'NombreLabel1
        '
        Me.NombreLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Nombre", True))
        Me.NombreLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NombreLabel1.Location = New System.Drawing.Point(252, 220)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(200, 23)
        Me.NombreLabel1.TabIndex = 134
        Me.NombreLabel1.Text = "Label4"
        '
        'UsuarioComboBox
        '
        Me.UsuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "Usuario", True))
        Me.UsuarioComboBox.DataSource = Me.ClientesBindingSource
        Me.UsuarioComboBox.DisplayMember = "NIF"
        Me.UsuarioComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UsuarioComboBox.FormattingEnabled = True
        Me.UsuarioComboBox.Location = New System.Drawing.Point(252, 180)
        Me.UsuarioComboBox.Name = "UsuarioComboBox"
        Me.UsuarioComboBox.Size = New System.Drawing.Size(200, 28)
        Me.UsuarioComboBox.TabIndex = 132
        Me.UsuarioComboBox.ValueMember = "NIF"
        '
        'IdLabel1
        '
        Me.IdLabel1.BackColor = System.Drawing.Color.Transparent
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Id", True))
        Me.IdLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdLabel1.Location = New System.Drawing.Point(77, 180)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(71, 23)
        Me.IdLabel1.TabIndex = 130
        Me.IdLabel1.Text = "Label4"
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(590, 180)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ProvinciaTextBox.TabIndex = 194
        '
        'DetalleVentaDataGridView
        '
        Me.DetalleVentaDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetalleVentaDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DetalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleVentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DetalleVentaDataGridView.DataSource = Me.DetalleVentaBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DetalleVentaDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DetalleVentaDataGridView.Location = New System.Drawing.Point(190, 660)
        Me.DetalleVentaDataGridView.Name = "DetalleVentaDataGridView"
        Me.DetalleVentaDataGridView.Size = New System.Drawing.Size(743, 95)
        Me.DetalleVentaDataGridView.TabIndex = 194
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id venta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Bici"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id artículo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Bici"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Artículo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio_Unitario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio Unitario"
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
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Importe_total"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Importe total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Id_BiciLabel3
        '
        Me.Id_BiciLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Id_BiciLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleVentaBindingSource, "Id_Bici", True))
        Me.Id_BiciLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Id_BiciLabel3.Location = New System.Drawing.Point(237, 447)
        Me.Id_BiciLabel3.Name = "Id_BiciLabel3"
        Me.Id_BiciLabel3.Size = New System.Drawing.Size(100, 23)
        Me.Id_BiciLabel3.TabIndex = 197
        Me.Id_BiciLabel3.Text = "Label9"
        '
        'Precio_UnitarioTextBox
        '
        Me.Precio_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleVentaBindingSource, "Precio_Unitario", True))
        Me.Precio_UnitarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Precio_UnitarioTextBox.Location = New System.Drawing.Point(454, 547)
        Me.Precio_UnitarioTextBox.Name = "Precio_UnitarioTextBox"
        Me.Precio_UnitarioTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Precio_UnitarioTextBox.TabIndex = 203
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleVentaBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CantidadTextBox.Location = New System.Drawing.Point(833, 447)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CantidadTextBox.TabIndex = 205
        '
        'Importe_totalTextBox
        '
        Me.Importe_totalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleVentaBindingSource, "Importe_total", True))
        Me.Importe_totalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Importe_totalTextBox.Location = New System.Drawing.Point(833, 547)
        Me.Importe_totalTextBox.Name = "Importe_totalTextBox"
        Me.Importe_totalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Importe_totalTextBox.TabIndex = 207
        '
        'ModeloComboBox
        '
        Me.ModeloComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DetalleVentaBindingSource, "Modelo", True))
        Me.ModeloComboBox.DataSource = Me.AlmacenBindingSource
        Me.ModeloComboBox.DisplayMember = "Modelo"
        Me.ModeloComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ModeloComboBox.FormattingEnabled = True
        Me.ModeloComboBox.Location = New System.Drawing.Point(454, 447)
        Me.ModeloComboBox.Name = "ModeloComboBox"
        Me.ModeloComboBox.Size = New System.Drawing.Size(146, 28)
        Me.ModeloComboBox.TabIndex = 208
        Me.ModeloComboBox.ValueMember = "Modelo"
        '
        'BiciLabel2
        '
        Me.BiciLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BiciLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleVentaBindingSource, "Bici", True))
        Me.BiciLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BiciLabel2.Location = New System.Drawing.Point(450, 497)
        Me.BiciLabel2.Name = "BiciLabel2"
        Me.BiciLabel2.Size = New System.Drawing.Size(100, 23)
        Me.BiciLabel2.TabIndex = 209
        Me.BiciLabel2.Text = "Label9"
        '
        'Fecha_VentaDateTimePicker
        '
        Me.Fecha_VentaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "Fecha_Venta", True))
        Me.Fecha_VentaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Fecha_VentaDateTimePicker.Location = New System.Drawing.Point(984, 300)
        Me.Fecha_VentaDateTimePicker.Name = "Fecha_VentaDateTimePicker"
        Me.Fecha_VentaDateTimePicker.Size = New System.Drawing.Size(226, 26)
        Me.Fecha_VentaDateTimePicker.TabIndex = 210
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.informe2
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(984, 61)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(56, 55)
        Me.Button13.TabIndex = 211
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.ventas
        Me.ClientSize = New System.Drawing.Size(1284, 733)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Fecha_VentaLabel)
        Me.Controls.Add(Me.Fecha_VentaDateTimePicker)
        Me.Controls.Add(Me.BiciLabel2)
        Me.Controls.Add(Me.ModeloComboBox)
        Me.Controls.Add(Id_BiciLabel2)
        Me.Controls.Add(Me.Id_BiciLabel3)
        Me.Controls.Add(BiciLabel)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Precio_UnitarioLabel)
        Me.Controls.Add(Me.Precio_UnitarioTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Importe_totalLabel)
        Me.Controls.Add(Me.Importe_totalTextBox)
        Me.Controls.Add(Me.DetalleVentaDataGridView)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioComboBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreLabel1)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosLabel1)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
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
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleVentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As ProyectoFinalDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As ProyectoFinalDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button19 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents AlmacenBindingSource As BindingSource
    Friend WithEvents AlmacenTableAdapter As ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter
    Friend WithEvents DetalleVentaBindingSource As BindingSource
    Friend WithEvents DetalleVentaTableAdapter As ProyectoFinalDataSetTableAdapters.DetalleVentaTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ProyectoFinalDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents UsuarioComboBox As ComboBox
    Friend WithEvents NombreLabel1 As Label
    Friend WithEvents ApellidosLabel1 As Label
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents PortalTextBox As TextBox
    Friend WithEvents PisoTextBox As TextBox
    Friend WithEvents LetraPisoTextBox As TextBox
    Friend WithEvents Id_BiciLabel3 As Label
    Friend WithEvents Precio_UnitarioTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents Importe_totalTextBox As TextBox
    Friend WithEvents DetalleVentaDataGridView As DataGridView
    Friend WithEvents ProvinciaTextBox As TextBox
    Friend WithEvents ModeloComboBox As ComboBox
    Friend WithEvents BiciLabel2 As Label
    Friend WithEvents Fecha_VentaDateTimePicker As DateTimePicker
    Friend WithEvents Button13 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
