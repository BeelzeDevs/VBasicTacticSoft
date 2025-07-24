<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BM_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BM_Ventas))
        Me.panelFilters = New System.Windows.Forms.Panel()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.lblBuscadorFecha = New System.Windows.Forms.Label()
        Me.flayoutDetalleVentas = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelTotalDetalle = New System.Windows.Forms.Panel()
        Me.gvTotalVenta = New System.Windows.Forms.DataGridView()
        Me.panelErrores = New System.Windows.Forms.Panel()
        Me.tablaErrores = New System.Windows.Forms.TableLayoutPanel()
        Me.panelErroresHead = New System.Windows.Forms.Panel()
        Me.flowlayoutHeadError = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblErrorHeadImagen = New System.Windows.Forms.Label()
        Me.lblErrorHead = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblErrorMensajes = New System.Windows.Forms.Label()
        Me.gvDetalleVentas = New Vistas.CustomDataGridView()
        Me.panelFilters.SuspendLayout()
        Me.panelTotalDetalle.SuspendLayout()
        CType(Me.gvTotalVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelErrores.SuspendLayout()
        Me.tablaErrores.SuspendLayout()
        Me.panelErroresHead.SuspendLayout()
        Me.flowlayoutHeadError.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gvDetalleVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelFilters
        '
        Me.panelFilters.Controls.Add(Me.txtIdVenta)
        Me.panelFilters.Controls.Add(Me.btnReset)
        Me.panelFilters.Controls.Add(Me.btnBuscarID)
        Me.panelFilters.Controls.Add(Me.lblBuscadorFecha)
        Me.panelFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFilters.Location = New System.Drawing.Point(0, 0)
        Me.panelFilters.Name = "panelFilters"
        Me.panelFilters.Size = New System.Drawing.Size(1010, 74)
        Me.panelFilters.TabIndex = 0
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Location = New System.Drawing.Point(290, 31)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(200, 30)
        Me.txtIdVenta.TabIndex = 9
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
        Me.btnReset.TabIndex = 5
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
        Me.btnBuscarID.TabIndex = 7
        Me.btnBuscarID.Text = "Buscar"
        Me.btnBuscarID.UseVisualStyleBackColor = False
        '
        'lblBuscadorFecha
        '
        Me.lblBuscadorFecha.AutoSize = True
        Me.lblBuscadorFecha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscadorFecha.ForeColor = System.Drawing.Color.White
        Me.lblBuscadorFecha.Location = New System.Drawing.Point(160, 33)
        Me.lblBuscadorFecha.Name = "lblBuscadorFecha"
        Me.lblBuscadorFecha.Size = New System.Drawing.Size(154, 24)
        Me.lblBuscadorFecha.TabIndex = 4
        Me.lblBuscadorFecha.Text = "Ingrese ID venta :"
        '
        'flayoutDetalleVentas
        '
        Me.flayoutDetalleVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.flayoutDetalleVentas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flayoutDetalleVentas.Location = New System.Drawing.Point(0, 74)
        Me.flayoutDetalleVentas.MaximumSize = New System.Drawing.Size(0, 220)
        Me.flayoutDetalleVentas.Name = "flayoutDetalleVentas"
        Me.flayoutDetalleVentas.Size = New System.Drawing.Size(1010, 220)
        Me.flayoutDetalleVentas.TabIndex = 4
        '
        'panelTotalDetalle
        '
        Me.panelTotalDetalle.Controls.Add(Me.gvTotalVenta)
        Me.panelTotalDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTotalDetalle.Location = New System.Drawing.Point(0, 294)
        Me.panelTotalDetalle.Name = "panelTotalDetalle"
        Me.panelTotalDetalle.Size = New System.Drawing.Size(1010, 56)
        Me.panelTotalDetalle.TabIndex = 5
        '
        'gvTotalVenta
        '
        Me.gvTotalVenta.AllowUserToAddRows = False
        Me.gvTotalVenta.AllowUserToDeleteRows = False
        Me.gvTotalVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.gvTotalVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvTotalVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvTotalVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.gvTotalVenta.Location = New System.Drawing.Point(0, 0)
        Me.gvTotalVenta.Name = "gvTotalVenta"
        Me.gvTotalVenta.RowHeadersWidth = 51
        Me.gvTotalVenta.Size = New System.Drawing.Size(1010, 150)
        Me.gvTotalVenta.TabIndex = 0
        '
        'panelErrores
        '
        Me.panelErrores.Controls.Add(Me.tablaErrores)
        Me.panelErrores.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelErrores.Location = New System.Drawing.Point(0, 350)
        Me.panelErrores.Name = "panelErrores"
        Me.panelErrores.Size = New System.Drawing.Size(1010, 279)
        Me.panelErrores.TabIndex = 6
        '
        'tablaErrores
        '
        Me.tablaErrores.ColumnCount = 3
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59188!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40812!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tablaErrores.Controls.Add(Me.panelErroresHead, 1, 0)
        Me.tablaErrores.Controls.Add(Me.Panel1, 1, 1)
        Me.tablaErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaErrores.Location = New System.Drawing.Point(0, 0)
        Me.tablaErrores.Name = "tablaErrores"
        Me.tablaErrores.RowCount = 2
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.063444!))
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.93655!))
        Me.tablaErrores.Size = New System.Drawing.Size(1010, 279)
        Me.tablaErrores.TabIndex = 6
        Me.tablaErrores.Visible = False
        '
        'panelErroresHead
        '
        Me.panelErroresHead.Controls.Add(Me.flowlayoutHeadError)
        Me.panelErroresHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelErroresHead.Location = New System.Drawing.Point(228, 3)
        Me.panelErroresHead.Name = "panelErroresHead"
        Me.panelErroresHead.Size = New System.Drawing.Size(648, 19)
        Me.panelErroresHead.TabIndex = 8
        '
        'flowlayoutHeadError
        '
        Me.flowlayoutHeadError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHeadImagen)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHead)
        Me.flowlayoutHeadError.Location = New System.Drawing.Point(249, 0)
        Me.flowlayoutHeadError.Name = "flowlayoutHeadError"
        Me.flowlayoutHeadError.Size = New System.Drawing.Size(133, 100)
        Me.flowlayoutHeadError.TabIndex = 0
        '
        'lblErrorHeadImagen
        '
        Me.lblErrorHeadImagen.AutoSize = True
        Me.lblErrorHeadImagen.Image = CType(resources.GetObject("lblErrorHeadImagen.Image"), System.Drawing.Image)
        Me.lblErrorHeadImagen.Location = New System.Drawing.Point(3, 0)
        Me.lblErrorHeadImagen.Name = "lblErrorHeadImagen"
        Me.lblErrorHeadImagen.Size = New System.Drawing.Size(30, 23)
        Me.lblErrorHeadImagen.TabIndex = 3
        Me.lblErrorHeadImagen.Text = "     "
        '
        'lblErrorHead
        '
        Me.lblErrorHead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblErrorHead.AutoSize = True
        Me.lblErrorHead.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorHead.ForeColor = System.Drawing.Color.White
        Me.lblErrorHead.Location = New System.Drawing.Point(39, 0)
        Me.lblErrorHead.Name = "lblErrorHead"
        Me.lblErrorHead.Size = New System.Drawing.Size(52, 24)
        Me.lblErrorHead.TabIndex = 2
        Me.lblErrorHead.Text = "Error"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblErrorMensajes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(228, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 248)
        Me.Panel1.TabIndex = 9
        '
        'lblErrorMensajes
        '
        Me.lblErrorMensajes.AutoSize = True
        Me.lblErrorMensajes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblErrorMensajes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMensajes.ForeColor = System.Drawing.Color.White
        Me.lblErrorMensajes.Location = New System.Drawing.Point(0, 0)
        Me.lblErrorMensajes.Name = "lblErrorMensajes"
        Me.lblErrorMensajes.Size = New System.Drawing.Size(0, 24)
        Me.lblErrorMensajes.TabIndex = 0
        '
        'gvDetalleVentas
        '
        Me.gvDetalleVentas.ColumnHeadersHeight = 29
        Me.gvDetalleVentas.Location = New System.Drawing.Point(0, 0)
        Me.gvDetalleVentas.Name = "gvDetalleVentas"
        Me.gvDetalleVentas.RowHeadersWidth = 51
        Me.gvDetalleVentas.Size = New System.Drawing.Size(240, 150)
        Me.gvDetalleVentas.TabIndex = 0
        '
        'BM_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 625)
        Me.Controls.Add(Me.panelErrores)
        Me.Controls.Add(Me.panelTotalDetalle)
        Me.Controls.Add(Me.flayoutDetalleVentas)
        Me.Controls.Add(Me.panelFilters)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BM_Ventas"
        Me.Text = "ABM_Ventas"
        Me.panelFilters.ResumeLayout(False)
        Me.panelFilters.PerformLayout()
        Me.panelTotalDetalle.ResumeLayout(False)
        CType(Me.gvTotalVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelErrores.ResumeLayout(False)
        Me.tablaErrores.ResumeLayout(False)
        Me.panelErroresHead.ResumeLayout(False)
        Me.flowlayoutHeadError.ResumeLayout(False)
        Me.flowlayoutHeadError.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gvDetalleVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFilters As Panel
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents lblBuscadorFecha As Label
    Friend WithEvents flayoutDetalleVentas As FlowLayoutPanel
    Friend WithEvents panelTotalDetalle As Panel
    Friend WithEvents gvTotalVenta As DataGridView
    Friend WithEvents panelErrores As Panel
    Friend WithEvents tablaErrores As TableLayoutPanel
    Friend WithEvents panelErroresHead As Panel
    Friend WithEvents flowlayoutHeadError As FlowLayoutPanel
    Friend WithEvents lblErrorHeadImagen As Label
    Friend WithEvents lblErrorHead As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblErrorMensajes As Label
End Class
