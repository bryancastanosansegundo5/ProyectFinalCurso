<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.UsuariosDeLaAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.AlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosAProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.RecogerUnaReparaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReparacionesARealizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.ToolStripSplitButton1, Me.ToolStripSeparator2, Me.ToolStripSplitButton2, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(493, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosDeLaAplicaciónToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripDropDownButton1.Text = "Gestión de usuarios"
        '
        'UsuariosDeLaAplicaciónToolStripMenuItem
        '
        Me.UsuariosDeLaAplicaciónToolStripMenuItem.Name = "UsuariosDeLaAplicaciónToolStripMenuItem"
        Me.UsuariosDeLaAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.UsuariosDeLaAplicaciónToolStripMenuItem.Text = "Usuarios de la aplicación"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmacenToolStripMenuItem, Me.PedidosAProveedoresToolStripMenuItem, Me.MarcasToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripSplitButton1.Text = "Gestión de almacén"
        '
        'AlmacenToolStripMenuItem
        '
        Me.AlmacenToolStripMenuItem.Name = "AlmacenToolStripMenuItem"
        Me.AlmacenToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AlmacenToolStripMenuItem.Text = "Almacen"
        '
        'PedidosAProveedoresToolStripMenuItem
        '
        Me.PedidosAProveedoresToolStripMenuItem.Name = "PedidosAProveedoresToolStripMenuItem"
        Me.PedidosAProveedoresToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PedidosAProveedoresToolStripMenuItem.Text = "Pedidos a proveedores"
        '
        'MarcasToolStripMenuItem
        '
        Me.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        Me.MarcasToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.MarcasToolStripMenuItem.Text = "Marcas"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecogerUnaReparaciónToolStripMenuItem, Me.ReparacionesARealizarToolStripMenuItem})
        Me.ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripSplitButton2.Text = "Reparaciones"
        '
        'RecogerUnaReparaciónToolStripMenuItem
        '
        Me.RecogerUnaReparaciónToolStripMenuItem.Name = "RecogerUnaReparaciónToolStripMenuItem"
        Me.RecogerUnaReparaciónToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RecogerUnaReparaciónToolStripMenuItem.Text = "Recoger una reparación"
        '
        'ReparacionesARealizarToolStripMenuItem
        '
        Me.ReparacionesARealizarToolStripMenuItem.Name = "ReparacionesARealizarToolStripMenuItem"
        Me.ReparacionesARealizarToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ReparacionesARealizarToolStripMenuItem.Text = "Reparaciones a realizar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton1.Text = "Ventas"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.botonPrincipalReparaciones
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(53, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 76)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Reparaciones"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.botonPrincipalVentas
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(331, 252)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(115, 76)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Ventas"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.botonPrincipalAlmacen
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(331, 43)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 76)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Gestión de almacén"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.botonPrincipal1
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(53, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 76)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Usuarios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectFinalVB.My.Resources.Resources.LogoProyectoFinal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(493, 353)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents UsuariosDeLaAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosAProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton2 As ToolStripSplitButton
    Friend WithEvents RecogerUnaReparaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReparacionesARealizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Button2 As Button
End Class
