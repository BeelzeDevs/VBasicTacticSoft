<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BM_Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BM_Productos))
        Me.panelFilters = New System.Windows.Forms.Panel()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.lblIngreseIDProducto = New System.Windows.Forms.Label()
        Me.flayoutProductos = New System.Windows.Forms.FlowLayoutPanel()
        Me.gvProductos = New Vistas.CustomDataGridView()
        Me.panelErrores = New System.Windows.Forms.Panel()
        Me.tablaErrores = New System.Windows.Forms.TableLayoutPanel()
        Me.panelErroresHead = New System.Windows.Forms.Panel()
        Me.flowlayoutHeadError = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblErrorHeadImagen = New System.Windows.Forms.Label()
        Me.lblErrorHead = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblErrorMensajes = New System.Windows.Forms.Label()
        Me.panelFilters.SuspendLayout()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelErrores.SuspendLayout()
        Me.tablaErrores.SuspendLayout()
        Me.panelErroresHead.SuspendLayout()
        Me.flowlayoutHeadError.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelFilters
        '
        Me.panelFilters.Controls.Add(Me.txtIdProducto)
        Me.panelFilters.Controls.Add(Me.btnReset)
        Me.panelFilters.Controls.Add(Me.btnBuscarID)
        Me.panelFilters.Controls.Add(Me.lblIngreseIDProducto)
        Me.panelFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFilters.Location = New System.Drawing.Point(0, 0)
        Me.panelFilters.Name = "panelFilters"
        Me.panelFilters.Size = New System.Drawing.Size(1010, 74)
        Me.panelFilters.TabIndex = 0
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(290, 31)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(200, 26)
        Me.txtIdProducto.TabIndex = 17
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
        Me.btnReset.Location = New System.Drawing.Point(22, 14)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(55, 48)
        Me.btnReset.TabIndex = 15
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnBuscarID
        '
        Me.btnBuscarID.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBuscarID.FlatAppearance.BorderSize = 0
        Me.btnBuscarID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnBuscarID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBuscarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarID.ForeColor = System.Drawing.Color.White
        Me.btnBuscarID.Location = New System.Drawing.Point(510, 33)
        Me.btnBuscarID.Name = "btnBuscarID"
        Me.btnBuscarID.Size = New System.Drawing.Size(94, 23)
        Me.btnBuscarID.TabIndex = 16
        Me.btnBuscarID.Text = "Buscar"
        Me.btnBuscarID.UseVisualStyleBackColor = False
        '
        'lblIngreseIDProducto
        '
        Me.lblIngreseIDProducto.AutoSize = True
        Me.lblIngreseIDProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseIDProducto.ForeColor = System.Drawing.Color.White
        Me.lblIngreseIDProducto.Location = New System.Drawing.Point(145, 33)
        Me.lblIngreseIDProducto.Name = "lblIngreseIDProducto"
        Me.lblIngreseIDProducto.Size = New System.Drawing.Size(144, 19)
        Me.lblIngreseIDProducto.TabIndex = 14
        Me.lblIngreseIDProducto.Text = "Ingrese ID Producto :"
        '
        'flayoutProductos
        '
        Me.flayoutProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.flayoutProductos.Location = New System.Drawing.Point(0, 74)
        Me.flayoutProductos.Name = "flayoutProductos"
        Me.flayoutProductos.Size = New System.Drawing.Size(1010, 252)
        Me.flayoutProductos.TabIndex = 2
        '
        'gvProductos
        '
        Me.gvProductos.Location = New System.Drawing.Point(0, 0)
        Me.gvProductos.Name = "gvProductos"
        Me.gvProductos.Size = New System.Drawing.Size(240, 150)
        Me.gvProductos.TabIndex = 0
        '
        'panelErrores
        '
        Me.panelErrores.Controls.Add(Me.tablaErrores)
        Me.panelErrores.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelErrores.Location = New System.Drawing.Point(0, 326)
        Me.panelErrores.Name = "panelErrores"
        Me.panelErrores.Size = New System.Drawing.Size(1010, 299)
        Me.panelErrores.TabIndex = 3
        '
        'tablaErrores
        '
        Me.tablaErrores.ColumnCount = 3
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59188!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40812!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.tablaErrores.Controls.Add(Me.panelErroresHead, 1, 0)
        Me.tablaErrores.Controls.Add(Me.Panel2, 1, 1)
        Me.tablaErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaErrores.Location = New System.Drawing.Point(0, 0)
        Me.tablaErrores.Name = "tablaErrores"
        Me.tablaErrores.RowCount = 2
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.063444!))
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.93655!))
        Me.tablaErrores.Size = New System.Drawing.Size(1010, 299)
        Me.tablaErrores.TabIndex = 8
        Me.tablaErrores.Visible = False
        '
        'panelErroresHead
        '
        Me.panelErroresHead.Controls.Add(Me.flowlayoutHeadError)
        Me.panelErroresHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelErroresHead.Location = New System.Drawing.Point(227, 3)
        Me.panelErroresHead.Name = "panelErroresHead"
        Me.panelErroresHead.Size = New System.Drawing.Size(646, 21)
        Me.panelErroresHead.TabIndex = 8
        '
        'flowlayoutHeadError
        '
        Me.flowlayoutHeadError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHeadImagen)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHead)
        Me.flowlayoutHeadError.Location = New System.Drawing.Point(249, 1)
        Me.flowlayoutHeadError.Name = "flowlayoutHeadError"
        Me.flowlayoutHeadError.Size = New System.Drawing.Size(131, 100)
        Me.flowlayoutHeadError.TabIndex = 0
        '
        'lblErrorHeadImagen
        '
        Me.lblErrorHeadImagen.AutoSize = True
        Me.lblErrorHeadImagen.Image = CType(resources.GetObject("lblErrorHeadImagen.Image"), System.Drawing.Image)
        Me.lblErrorHeadImagen.Location = New System.Drawing.Point(3, 0)
        Me.lblErrorHeadImagen.Name = "lblErrorHeadImagen"
        Me.lblErrorHeadImagen.Size = New System.Drawing.Size(23, 18)
        Me.lblErrorHeadImagen.TabIndex = 3
        Me.lblErrorHeadImagen.Text = "     "
        '
        'lblErrorHead
        '
        Me.lblErrorHead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblErrorHead.AutoSize = True
        Me.lblErrorHead.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorHead.ForeColor = System.Drawing.Color.White
        Me.lblErrorHead.Location = New System.Drawing.Point(32, 0)
        Me.lblErrorHead.Name = "lblErrorHead"
        Me.lblErrorHead.Size = New System.Drawing.Size(40, 19)
        Me.lblErrorHead.TabIndex = 2
        Me.lblErrorHead.Text = "Error"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblErrorMensajes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(227, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 266)
        Me.Panel2.TabIndex = 9
        '
        'lblErrorMensajes
        '
        Me.lblErrorMensajes.AutoSize = True
        Me.lblErrorMensajes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblErrorMensajes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMensajes.ForeColor = System.Drawing.Color.White
        Me.lblErrorMensajes.Location = New System.Drawing.Point(0, 0)
        Me.lblErrorMensajes.Name = "lblErrorMensajes"
        Me.lblErrorMensajes.Size = New System.Drawing.Size(0, 19)
        Me.lblErrorMensajes.TabIndex = 0
        '
        'BM_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 625)
        Me.Controls.Add(Me.panelErrores)
        Me.Controls.Add(Me.flayoutProductos)
        Me.Controls.Add(Me.panelFilters)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BM_Productos"
        Me.Text = "BM_Productos"
        Me.panelFilters.ResumeLayout(False)
        Me.panelFilters.PerformLayout()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelErrores.ResumeLayout(False)
        Me.tablaErrores.ResumeLayout(False)
        Me.panelErroresHead.ResumeLayout(False)
        Me.flowlayoutHeadError.ResumeLayout(False)
        Me.flowlayoutHeadError.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFilters As Panel
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents lblIngreseIDProducto As Label
    Friend WithEvents flayoutProductos As FlowLayoutPanel
    Friend WithEvents panelErrores As Panel
    Friend WithEvents tablaErrores As TableLayoutPanel
    Friend WithEvents panelErroresHead As Panel
    Friend WithEvents flowlayoutHeadError As FlowLayoutPanel
    Friend WithEvents lblErrorHeadImagen As Label
    Friend WithEvents lblErrorHead As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblErrorMensajes As Label
End Class
