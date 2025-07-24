<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listarProductos))
        Me.panelFilters = New System.Windows.Forms.Panel()
        Me.panelSearchProducto = New System.Windows.Forms.Panel()
        Me.lblBuscadorNombre = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblBuscadorID = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.chkboxSoloActivos = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.panelProductos = New System.Windows.Forms.Panel()
        Me.gvProductos = New System.Windows.Forms.DataGridView()
        Me.panelPaginacionFutura = New System.Windows.Forms.Panel()
        Me.panelFilters.SuspendLayout()
        Me.panelSearchProducto.SuspendLayout()
        Me.panelProductos.SuspendLayout()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelFilters
        '
        Me.panelFilters.Controls.Add(Me.panelSearchProducto)
        Me.panelFilters.Controls.Add(Me.btnReset)
        Me.panelFilters.Controls.Add(Me.chkboxSoloActivos)
        Me.panelFilters.Controls.Add(Me.btnBuscar)
        Me.panelFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFilters.Location = New System.Drawing.Point(0, 0)
        Me.panelFilters.Name = "panelFilters"
        Me.panelFilters.Size = New System.Drawing.Size(1010, 98)
        Me.panelFilters.TabIndex = 1
        '
        'panelSearchProducto
        '
        Me.panelSearchProducto.Controls.Add(Me.lblBuscadorNombre)
        Me.panelSearchProducto.Controls.Add(Me.txtID)
        Me.panelSearchProducto.Controls.Add(Me.txtNombre)
        Me.panelSearchProducto.Controls.Add(Me.lblBuscadorID)
        Me.panelSearchProducto.Location = New System.Drawing.Point(125, 3)
        Me.panelSearchProducto.Name = "panelSearchProducto"
        Me.panelSearchProducto.Size = New System.Drawing.Size(516, 95)
        Me.panelSearchProducto.TabIndex = 15
        '
        'lblBuscadorNombre
        '
        Me.lblBuscadorNombre.AutoSize = True
        Me.lblBuscadorNombre.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscadorNombre.ForeColor = System.Drawing.Color.White
        Me.lblBuscadorNombre.Location = New System.Drawing.Point(321, 17)
        Me.lblBuscadorNombre.Name = "lblBuscadorNombre"
        Me.lblBuscadorNombre.Size = New System.Drawing.Size(128, 19)
        Me.lblBuscadorNombre.TabIndex = 11
        Me.lblBuscadorNombre.Text = "Buscador Nombre:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(42, 49)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(200, 26)
        Me.txtID.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(293, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 26)
        Me.txtNombre.TabIndex = 10
        '
        'lblBuscadorID
        '
        Me.lblBuscadorID.AutoSize = True
        Me.lblBuscadorID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscadorID.ForeColor = System.Drawing.Color.White
        Me.lblBuscadorID.Location = New System.Drawing.Point(85, 17)
        Me.lblBuscadorID.Name = "lblBuscadorID"
        Me.lblBuscadorID.Size = New System.Drawing.Size(91, 19)
        Me.lblBuscadorID.TabIndex = 4
        Me.lblBuscadorID.Text = "Buscador ID:"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(39, 32)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(55, 48)
        Me.btnReset.TabIndex = 12
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'chkboxSoloActivos
        '
        Me.chkboxSoloActivos.AutoSize = True
        Me.chkboxSoloActivos.Checked = True
        Me.chkboxSoloActivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxSoloActivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkboxSoloActivos.ForeColor = System.Drawing.Color.White
        Me.chkboxSoloActivos.Location = New System.Drawing.Point(776, 53)
        Me.chkboxSoloActivos.Name = "chkboxSoloActivos"
        Me.chkboxSoloActivos.Size = New System.Drawing.Size(68, 22)
        Me.chkboxSoloActivos.TabIndex = 14
        Me.chkboxSoloActivos.Text = "Estado"
        Me.chkboxSoloActivos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(647, 53)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 23)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'panelProductos
        '
        Me.panelProductos.Controls.Add(Me.gvProductos)
        Me.panelProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelProductos.Location = New System.Drawing.Point(0, 98)
        Me.panelProductos.Name = "panelProductos"
        Me.panelProductos.Size = New System.Drawing.Size(1010, 404)
        Me.panelProductos.TabIndex = 2
        '
        'gvProductos
        '
        Me.gvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvProductos.Location = New System.Drawing.Point(0, 0)
        Me.gvProductos.Name = "gvProductos"
        Me.gvProductos.Size = New System.Drawing.Size(1010, 404)
        Me.gvProductos.TabIndex = 0
        '
        'panelPaginacionFutura
        '
        Me.panelPaginacionFutura.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelPaginacionFutura.Location = New System.Drawing.Point(0, 502)
        Me.panelPaginacionFutura.Name = "panelPaginacionFutura"
        Me.panelPaginacionFutura.Size = New System.Drawing.Size(1010, 66)
        Me.panelPaginacionFutura.TabIndex = 3
        '
        'listarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 625)
        Me.Controls.Add(Me.panelPaginacionFutura)
        Me.Controls.Add(Me.panelProductos)
        Me.Controls.Add(Me.panelFilters)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "listarProductos"
        Me.Text = "listarProductos"
        Me.panelFilters.ResumeLayout(False)
        Me.panelFilters.PerformLayout()
        Me.panelSearchProducto.ResumeLayout(False)
        Me.panelSearchProducto.PerformLayout()
        Me.panelProductos.ResumeLayout(False)
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFilters As Panel
    Friend WithEvents panelProductos As Panel
    Friend WithEvents panelPaginacionFutura As Panel
    Friend WithEvents panelSearchProducto As Panel
    Friend WithEvents lblBuscadorNombre As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblBuscadorID As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents chkboxSoloActivos As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents gvProductos As DataGridView
End Class
