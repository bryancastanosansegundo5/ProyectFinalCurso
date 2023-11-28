<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim EspecificacionesLabel As System.Windows.Forms.Label
        Dim ImagenLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim PrecioCosteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Almacen))
        Me.MarcaComboBox = New System.Windows.Forms.ComboBox()
        Me.AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.EspecificacionesTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.AlmacenTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter()
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Me.MarcasTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.MarcasTableAdapter()
        Me.IdLabel2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrecioCosteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.BuscarTxt = New System.Windows.Forms.TextBox()
        Me.ComboBuscar = New System.Windows.Forms.ComboBox()
        IdLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        EspecificacionesLabel = New System.Windows.Forms.Label()
        ImagenLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        PrecioCosteLabel = New System.Windows.Forms.Label()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        IdLabel.Location = New System.Drawing.Point(249, 186)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 20)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = System.Drawing.Color.Transparent
        MarcaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        MarcaLabel.Location = New System.Drawing.Point(249, 225)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(63, 20)
        MarcaLabel.TabIndex = 3
        MarcaLabel.Text = "Marca:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        ModeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ModeloLabel.Location = New System.Drawing.Point(249, 265)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(72, 20)
        ModeloLabel.TabIndex = 5
        ModeloLabel.Text = "Modelo:"
        '
        'EspecificacionesLabel
        '
        EspecificacionesLabel.AutoSize = True
        EspecificacionesLabel.BackColor = System.Drawing.Color.Transparent
        EspecificacionesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        EspecificacionesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        EspecificacionesLabel.Location = New System.Drawing.Point(249, 415)
        EspecificacionesLabel.Name = "EspecificacionesLabel"
        EspecificacionesLabel.Size = New System.Drawing.Size(149, 20)
        EspecificacionesLabel.TabIndex = 7
        EspecificacionesLabel.Text = "Especificaciones:"
        '
        'ImagenLabel
        '
        ImagenLabel.AutoSize = True
        ImagenLabel.BackColor = System.Drawing.Color.Transparent
        ImagenLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        ImagenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ImagenLabel.Location = New System.Drawing.Point(594, 197)
        ImagenLabel.Name = "ImagenLabel"
        ImagenLabel.Size = New System.Drawing.Size(74, 20)
        ImagenLabel.TabIndex = 9
        ImagenLabel.Text = "Imagen:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.BackColor = System.Drawing.Color.Transparent
        CantidadLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        CantidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        CantidadLabel.Location = New System.Drawing.Point(249, 297)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(86, 20)
        CantidadLabel.TabIndex = 11
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.BackColor = System.Drawing.Color.Transparent
        PrecioLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        PrecioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PrecioLabel.Location = New System.Drawing.Point(249, 379)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(113, 20)
        PrecioLabel.TabIndex = 13
        PrecioLabel.Text = "Precio coste:"
        '
        'PrecioCosteLabel
        '
        PrecioCosteLabel.AutoSize = True
        PrecioCosteLabel.BackColor = System.Drawing.Color.Transparent
        PrecioCosteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        PrecioCosteLabel.Location = New System.Drawing.Point(249, 338)
        PrecioCosteLabel.Name = "PrecioCosteLabel"
        PrecioCosteLabel.Size = New System.Drawing.Size(139, 20)
        PrecioCosteLabel.TabIndex = 150
        PrecioCosteLabel.Text = "Porcentaje PVP:"
        AddHandler PrecioCosteLabel.Click, AddressOf Me.PrecioCosteLabel_Click
        '
        'MarcaComboBox
        '
        Me.MarcaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AlmacenBindingSource, "Marca", True))
        Me.MarcaComboBox.DataSource = Me.MarcasBindingSource
        Me.MarcaComboBox.DisplayMember = "Marca"
        Me.MarcaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.MarcaComboBox.FormattingEnabled = True
        Me.MarcaComboBox.Location = New System.Drawing.Point(404, 223)
        Me.MarcaComboBox.Name = "MarcaComboBox"
        Me.MarcaComboBox.Size = New System.Drawing.Size(121, 26)
        Me.MarcaComboBox.TabIndex = 4
        Me.MarcaComboBox.ValueMember = "Marca"
        '
        'AlmacenBindingSource
        '
        Me.AlmacenBindingSource.DataMember = "Almacen"
        Me.AlmacenBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ProyectoFinalDataSet
        '
        Me.ProyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet"
        Me.ProyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.ProyectoFinalDataSet
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenBindingSource, "Modelo", True))
        Me.ModeloTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ModeloTextBox.Location = New System.Drawing.Point(404, 261)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(121, 24)
        Me.ModeloTextBox.TabIndex = 6
        '
        'EspecificacionesTextBox
        '
        Me.EspecificacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenBindingSource, "Especificaciones", True))
        Me.EspecificacionesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.EspecificacionesTextBox.Location = New System.Drawing.Point(404, 413)
        Me.EspecificacionesTextBox.Name = "EspecificacionesTextBox"
        Me.EspecificacionesTextBox.Size = New System.Drawing.Size(121, 24)
        Me.EspecificacionesTextBox.TabIndex = 8
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CantidadTextBox.Location = New System.Drawing.Point(404, 293)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(121, 24)
        Me.CantidadTextBox.TabIndex = 12
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenBindingSource, "PVP", True))
        Me.PrecioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.PrecioTextBox.Location = New System.Drawing.Point(404, 334)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(121, 24)
        Me.PrecioTextBox.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(468, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Cancelar cambios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(305, 526)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Guardar cambios"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.cancelar
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(460, 463)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 70)
        Me.Button5.TabIndex = 43
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.aceptar
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(294, 463)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 70)
        Me.Button7.TabIndex = 42
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ImagenPictureBox.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.camara
        Me.ImagenPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.AlmacenBindingSource, "Imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(684, 197)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(233, 224)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPictureBox.TabIndex = 10
        Me.ImagenPictureBox.TabStop = False
        '
        'AlmacenTableAdapter
        '
        Me.AlmacenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlmacenTableAdapter = Me.AlmacenTableAdapter
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
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'IdLabel2
        '
        Me.IdLabel2.BackColor = System.Drawing.Color.Transparent
        Me.IdLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IdLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenBindingSource, "Id", True))
        Me.IdLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IdLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IdLabel2.Location = New System.Drawing.Point(404, 185)
        Me.IdLabel2.Name = "IdLabel2"
        Me.IdLabel2.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel2.TabIndex = 80
        Me.IdLabel2.Text = "Label4"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.editar
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(720, 27)
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
        Me.Button11.Location = New System.Drawing.Point(778, 23)
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
        Me.Button9.Location = New System.Drawing.Point(607, 25)
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
        Me.Button6.Location = New System.Drawing.Point(539, 30)
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
        Me.Button4.Location = New System.Drawing.Point(376, 32)
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
        Me.Label1.Location = New System.Drawing.Point(236, 42)
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
        Me.Button3.Location = New System.Drawing.Point(313, 32)
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
        Me.Button2.Location = New System.Drawing.Point(165, 32)
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
        Me.Button1.Location = New System.Drawing.Point(97, 32)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 36)
        Me.Button1.TabIndex = 144
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrecioCosteTextBox
        '
        Me.PrecioCosteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenBindingSource, "PrecioCoste", True))
        Me.PrecioCosteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.PrecioCosteTextBox.Location = New System.Drawing.Point(404, 375)
        Me.PrecioCosteTextBox.Name = "PrecioCosteTextBox"
        Me.PrecioCosteTextBox.Size = New System.Drawing.Size(121, 24)
        Me.PrecioCosteTextBox.TabIndex = 151
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.BuscarTxt)
        Me.GroupBox1.Controls.Add(Me.ComboBuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(41, 186)
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
        Me.ComboBuscar.Items.AddRange(New Object() {"ID", "Modelo"})
        Me.ComboBuscar.Location = New System.Drawing.Point(10, 27)
        Me.ComboBuscar.Name = "ComboBuscar"
        Me.ComboBuscar.Size = New System.Drawing.Size(100, 21)
        Me.ComboBuscar.TabIndex = 172
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.Almacen
        Me.ClientSize = New System.Drawing.Size(937, 585)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(PrecioCosteLabel)
        Me.Controls.Add(Me.PrecioCosteTextBox)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IdLabel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaComboBox)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(EspecificacionesLabel)
        Me.Controls.Add(Me.EspecificacionesTextBox)
        Me.Controls.Add(ImagenLabel)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Almacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacén"
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents AlmacenBindingSource As BindingSource
    Friend WithEvents AlmacenTableAdapter As ProyectoFinalDataSetTableAdapters.AlmacenTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MarcaComboBox As ComboBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents EspecificacionesTextBox As TextBox
    Friend WithEvents ImagenPictureBox As PictureBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents MarcasBindingSource As BindingSource
    Friend WithEvents MarcasTableAdapter As ProyectoFinalDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents IdLabel2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PrecioCosteTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Buscar As Button
    Friend WithEvents BuscarTxt As TextBox
    Friend WithEvents ComboBuscar As ComboBox
End Class
