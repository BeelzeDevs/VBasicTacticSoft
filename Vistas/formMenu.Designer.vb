<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMenu))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.panelMenuImage = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMenuTop = New System.Windows.Forms.Panel()
        Me.panelMainContentTop = New System.Windows.Forms.Panel()
        Me.panelTitle = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panelMainContent = New System.Windows.Forms.Panel()
        Me.panelMenu.SuspendLayout()
        Me.panelMenuImage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMainContentTop.SuspendLayout()
        Me.panelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.panelMenu.Controls.Add(Me.btnReportes)
        Me.panelMenu.Controls.Add(Me.btnVentas)
        Me.panelMenu.Controls.Add(Me.btnProductos)
        Me.panelMenu.Controls.Add(Me.btnClientes)
        Me.panelMenu.Controls.Add(Me.panelMenuImage)
        Me.panelMenu.Controls.Add(Me.panelMenuTop)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(170, 598)
        Me.panelMenu.TabIndex = 0
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.Silver
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 562)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnCerrarSesion.Size = New System.Drawing.Size(170, 36)
        Me.btnCerrarSesion.TabIndex = 7
        Me.btnCerrarSesion.Text = " Cerrar Sesión"
        Me.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.ForeColor = System.Drawing.Color.Silver
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 291)
        Me.btnReportes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnReportes.Size = New System.Drawing.Size(170, 48)
        Me.btnReportes.TabIndex = 5
        Me.btnReportes.Text = " Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.ForeColor = System.Drawing.Color.Silver
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 243)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnVentas.Size = New System.Drawing.Size(170, 48)
        Me.btnVentas.TabIndex = 4
        Me.btnVentas.Text = " Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.ForeColor = System.Drawing.Color.Silver
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 195)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnProductos.Size = New System.Drawing.Size(170, 48)
        Me.btnProductos.TabIndex = 3
        Me.btnProductos.Text = " Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.ForeColor = System.Drawing.Color.Silver
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 147)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnClientes.Size = New System.Drawing.Size(170, 48)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = " Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'panelMenuImage
        '
        Me.panelMenuImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.panelMenuImage.Controls.Add(Me.PictureBox1)
        Me.panelMenuImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMenuImage.Location = New System.Drawing.Point(0, 38)
        Me.panelMenuImage.Name = "panelMenuImage"
        Me.panelMenuImage.Size = New System.Drawing.Size(170, 109)
        Me.panelMenuImage.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-14, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelMenuTop
        '
        Me.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMenuTop.Location = New System.Drawing.Point(0, 0)
        Me.panelMenuTop.Name = "panelMenuTop"
        Me.panelMenuTop.Size = New System.Drawing.Size(170, 38)
        Me.panelMenuTop.TabIndex = 0
        '
        'panelMainContentTop
        '
        Me.panelMainContentTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.panelMainContentTop.Controls.Add(Me.panelTitle)
        Me.panelMainContentTop.Controls.Add(Me.btnExit)
        Me.panelMainContentTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMainContentTop.Location = New System.Drawing.Point(170, 0)
        Me.panelMainContentTop.Name = "panelMainContentTop"
        Me.panelMainContentTop.Size = New System.Drawing.Size(1014, 38)
        Me.panelMainContentTop.TabIndex = 1
        '
        'panelTitle
        '
        Me.panelTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.panelTitle.Controls.Add(Me.lblTitulo)
        Me.panelTitle.Location = New System.Drawing.Point(222, 0)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(551, 38)
        Me.panelTitle.TabIndex = 5
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(223, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(72, 29)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Menú"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Maroon
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Transparent
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(982, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(32, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'panelMainContent
        '
        Me.panelMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainContent.Location = New System.Drawing.Point(170, 38)
        Me.panelMainContent.Name = "panelMainContent"
        Me.panelMainContent.Size = New System.Drawing.Size(1014, 560)
        Me.panelMainContent.TabIndex = 2
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMainContent)
        Me.Controls.Add(Me.panelMainContentTop)
        Me.Controls.Add(Me.panelMenu)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenuImage.ResumeLayout(False)
        Me.panelMenuImage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMainContentTop.ResumeLayout(False)
        Me.panelTitle.ResumeLayout(False)
        Me.panelTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents panelMenuImage As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelMenuTop As Panel
    Friend WithEvents panelMainContentTop As Panel
    Private WithEvents panelMainContent As Panel
    Friend WithEvents panelTitle As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnExit As Button
End Class
