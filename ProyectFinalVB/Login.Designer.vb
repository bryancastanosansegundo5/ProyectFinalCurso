<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Nombre_UsuarioLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Nombre_UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectoFinalDataSet = New ProyectFinalVB.ProyectoFinalDataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New ProyectFinalVB.ProyectoFinalDataSetTableAdapters.TableAdapterManager()
        Nombre_UsuarioLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre_UsuarioLabel
        '
        Nombre_UsuarioLabel.AutoSize = True
        Nombre_UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        Nombre_UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Nombre_UsuarioLabel.ForeColor = System.Drawing.Color.Black
        Nombre_UsuarioLabel.Location = New System.Drawing.Point(25, 37)
        Nombre_UsuarioLabel.Name = "Nombre_UsuarioLabel"
        Nombre_UsuarioLabel.Size = New System.Drawing.Size(143, 20)
        Nombre_UsuarioLabel.TabIndex = 6
        Nombre_UsuarioLabel.Text = "Nombre Usuario:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.BackColor = System.Drawing.Color.Transparent
        ContraseñaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        ContraseñaLabel.ForeColor = System.Drawing.Color.Black
        ContraseñaLabel.Location = New System.Drawing.Point(61, 80)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(107, 20)
        ContraseñaLabel.TabIndex = 5
        ContraseñaLabel.Text = "Contraseña:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(93, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Location = New System.Drawing.Point(191, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Nombre_UsuarioTextBox
        '
        Me.Nombre_UsuarioTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Nombre_UsuarioTextBox.Location = New System.Drawing.Point(191, 37)
        Me.Nombre_UsuarioTextBox.Name = "Nombre_UsuarioTextBox"
        Me.Nombre_UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_UsuarioTextBox.TabIndex = 2
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(191, 80)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñaTextBox.TabIndex = 3
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
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.login2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(309, 182)
        Me.Controls.Add(Nombre_UsuarioLabel)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(Me.Nombre_UsuarioTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.ProyectoFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Nombre_UsuarioTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents ProyectoFinalDataSet As ProyectoFinalDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As ProyectoFinalDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoFinalDataSetTableAdapters.TableAdapterManager
End Class
