<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crearVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crearVenta))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.tableFormulario = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblIDVenta = New System.Windows.Forms.Label()
        Me.lbProducto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtIDVenta = New System.Windows.Forms.TextBox()
        Me.lblPrecioUnitario = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.lblAvisoTotal = New System.Windows.Forms.Label()
        Me.lblPrecioTotalAutomatico = New System.Windows.Forms.Label()
        Me.panelSubmit = New System.Windows.Forms.Panel()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.panelErrores = New System.Windows.Forms.Panel()
        Me.tablaErrores = New System.Windows.Forms.TableLayoutPanel()
        Me.panelErroresHead = New System.Windows.Forms.Panel()
        Me.flowlayoutHeadError = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblErrorHeadImagen = New System.Windows.Forms.Label()
        Me.lblErrorHead = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblErrorMensajes = New System.Windows.Forms.Label()
        Me.panelForm.SuspendLayout()
        Me.tableFormulario.SuspendLayout()
        Me.panelSubmit.SuspendLayout()
        Me.panelErrores.SuspendLayout()
        Me.tablaErrores.SuspendLayout()
        Me.panelErroresHead.SuspendLayout()
        Me.flowlayoutHeadError.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1067, 39)
        Me.panelTop.TabIndex = 2
        '
        'panelForm
        '
        Me.panelForm.Controls.Add(Me.tableFormulario)
        Me.panelForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelForm.Location = New System.Drawing.Point(0, 39)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(1067, 265)
        Me.panelForm.TabIndex = 12
        '
        'tableFormulario
        '
        Me.tableFormulario.ColumnCount = 4
        Me.tableFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.04348!))
        Me.tableFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.95652!))
        Me.tableFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267.0!))
        Me.tableFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 366.0!))
        Me.tableFormulario.Controls.Add(Me.txtCantidad, 2, 2)
        Me.tableFormulario.Controls.Add(Me.lblIDVenta, 1, 0)
        Me.tableFormulario.Controls.Add(Me.lbProducto, 1, 1)
        Me.tableFormulario.Controls.Add(Me.lblCantidad, 1, 2)
        Me.tableFormulario.Controls.Add(Me.txtIDVenta, 2, 0)
        Me.tableFormulario.Controls.Add(Me.lblPrecioUnitario, 1, 3)
        Me.tableFormulario.Controls.Add(Me.txtPrecioUnitario, 2, 3)
        Me.tableFormulario.Controls.Add(Me.lblTotal, 1, 4)
        Me.tableFormulario.Controls.Add(Me.cbProductos, 2, 1)
        Me.tableFormulario.Controls.Add(Me.lblAvisoTotal, 3, 4)
        Me.tableFormulario.Controls.Add(Me.lblPrecioTotalAutomatico, 2, 4)
        Me.tableFormulario.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableFormulario.Location = New System.Drawing.Point(0, 0)
        Me.tableFormulario.Name = "tableFormulario"
        Me.tableFormulario.RowCount = 5
        Me.tableFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableFormulario.Size = New System.Drawing.Size(1067, 256)
        Me.tableFormulario.TabIndex = 12
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCantidad.Location = New System.Drawing.Point(439, 114)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(255, 26)
        Me.txtCantidad.TabIndex = 12
        '
        'lblIDVenta
        '
        Me.lblIDVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIDVenta.AutoSize = True
        Me.lblIDVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDVenta.ForeColor = System.Drawing.Color.White
        Me.lblIDVenta.Location = New System.Drawing.Point(362, 0)
        Me.lblIDVenta.Name = "lblIDVenta"
        Me.lblIDVenta.Size = New System.Drawing.Size(68, 51)
        Me.lblIDVenta.TabIndex = 14
        Me.lblIDVenta.Text = "ID Venta:"
        Me.lblIDVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbProducto
        '
        Me.lbProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbProducto.AutoSize = True
        Me.lbProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProducto.ForeColor = System.Drawing.Color.White
        Me.lbProducto.Location = New System.Drawing.Point(356, 51)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(74, 51)
        Me.lbProducto.TabIndex = 15
        Me.lbProducto.Text = "Producto: "
        Me.lbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.White
        Me.lblCantidad.Location = New System.Drawing.Point(359, 102)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(71, 51)
        Me.lblCantidad.TabIndex = 16
        Me.lblCantidad.Text = "Cantidad:"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIDVenta
        '
        Me.txtIDVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIDVenta.Location = New System.Drawing.Point(439, 12)
        Me.txtIDVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIDVenta.Name = "txtIDVenta"
        Me.txtIDVenta.Size = New System.Drawing.Size(255, 26)
        Me.txtIDVenta.TabIndex = 10
        '
        'lblPrecioUnitario
        '
        Me.lblPrecioUnitario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecioUnitario.AutoSize = True
        Me.lblPrecioUnitario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioUnitario.ForeColor = System.Drawing.Color.White
        Me.lblPrecioUnitario.Location = New System.Drawing.Point(317, 153)
        Me.lblPrecioUnitario.Name = "lblPrecioUnitario"
        Me.lblPrecioUnitario.Size = New System.Drawing.Size(113, 51)
        Me.lblPrecioUnitario.TabIndex = 17
        Me.lblPrecioUnitario.Text = "Precio Unitario: "
        Me.lblPrecioUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(439, 165)
        Me.txtPrecioUnitario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(255, 26)
        Me.txtPrecioUnitario.TabIndex = 18
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(385, 204)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(45, 52)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbProductos
        '
        Me.cbProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProductos.FormattingEnabled = True
        Me.cbProductos.Location = New System.Drawing.Point(436, 66)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(261, 26)
        Me.cbProductos.TabIndex = 21
        '
        'lblAvisoTotal
        '
        Me.lblAvisoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvisoTotal.AutoSize = True
        Me.lblAvisoTotal.ForeColor = System.Drawing.Color.White
        Me.lblAvisoTotal.Location = New System.Drawing.Point(703, 221)
        Me.lblAvisoTotal.Name = "lblAvisoTotal"
        Me.lblAvisoTotal.Size = New System.Drawing.Size(361, 18)
        Me.lblAvisoTotal.TabIndex = 22
        Me.lblAvisoTotal.Text = "* El Total se generará automaticamente"
        '
        'lblPrecioTotalAutomatico
        '
        Me.lblPrecioTotalAutomatico.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecioTotalAutomatico.AutoSize = True
        Me.lblPrecioTotalAutomatico.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblPrecioTotalAutomatico.Location = New System.Drawing.Point(436, 221)
        Me.lblPrecioTotalAutomatico.Name = "lblPrecioTotalAutomatico"
        Me.lblPrecioTotalAutomatico.Size = New System.Drawing.Size(261, 18)
        Me.lblPrecioTotalAutomatico.TabIndex = 23
        Me.lblPrecioTotalAutomatico.Text = "$"
        Me.lblPrecioTotalAutomatico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelSubmit
        '
        Me.panelSubmit.Controls.Add(Me.btnCrear)
        Me.panelSubmit.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubmit.Location = New System.Drawing.Point(0, 304)
        Me.panelSubmit.Name = "panelSubmit"
        Me.panelSubmit.Size = New System.Drawing.Size(1067, 72)
        Me.panelSubmit.TabIndex = 13
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(491, 18)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(84, 37)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'panelErrores
        '
        Me.panelErrores.Controls.Add(Me.tablaErrores)
        Me.panelErrores.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelErrores.Location = New System.Drawing.Point(0, 376)
        Me.panelErrores.Name = "panelErrores"
        Me.panelErrores.Size = New System.Drawing.Size(1067, 246)
        Me.panelErrores.TabIndex = 14
        '
        'tablaErrores
        '
        Me.tablaErrores.ColumnCount = 3
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59188!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40812!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.tablaErrores.Controls.Add(Me.panelErroresHead, 1, 0)
        Me.tablaErrores.Controls.Add(Me.Panel1, 1, 1)
        Me.tablaErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaErrores.Location = New System.Drawing.Point(0, 0)
        Me.tablaErrores.Name = "tablaErrores"
        Me.tablaErrores.RowCount = 2
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.063444!))
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.93655!))
        Me.tablaErrores.Size = New System.Drawing.Size(1067, 246)
        Me.tablaErrores.TabIndex = 5
        Me.tablaErrores.Visible = False
        '
        'panelErroresHead
        '
        Me.panelErroresHead.Controls.Add(Me.flowlayoutHeadError)
        Me.panelErroresHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelErroresHead.Location = New System.Drawing.Point(244, 3)
        Me.panelErroresHead.Name = "panelErroresHead"
        Me.panelErroresHead.Size = New System.Drawing.Size(697, 16)
        Me.panelErroresHead.TabIndex = 8
        '
        'flowlayoutHeadError
        '
        Me.flowlayoutHeadError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHeadImagen)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHead)
        Me.flowlayoutHeadError.Location = New System.Drawing.Point(249, -1)
        Me.flowlayoutHeadError.Name = "flowlayoutHeadError"
        Me.flowlayoutHeadError.Size = New System.Drawing.Size(182, 100)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblErrorMensajes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(244, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 218)
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
        Me.lblErrorMensajes.Size = New System.Drawing.Size(0, 19)
        Me.lblErrorMensajes.TabIndex = 0
        '
        'crearVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 623)
        Me.Controls.Add(Me.panelErrores)
        Me.Controls.Add(Me.panelSubmit)
        Me.Controls.Add(Me.panelForm)
        Me.Controls.Add(Me.panelTop)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "crearVenta"
        Me.panelForm.ResumeLayout(False)
        Me.tableFormulario.ResumeLayout(False)
        Me.tableFormulario.PerformLayout()
        Me.panelSubmit.ResumeLayout(False)
        Me.panelErrores.ResumeLayout(False)
        Me.tablaErrores.ResumeLayout(False)
        Me.panelErroresHead.ResumeLayout(False)
        Me.flowlayoutHeadError.ResumeLayout(False)
        Me.flowlayoutHeadError.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents panelForm As Panel
    Friend WithEvents tableFormulario As TableLayoutPanel
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblIDVenta As Label
    Friend WithEvents lbProducto As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtIDVenta As TextBox
    Friend WithEvents lblPrecioUnitario As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents panelSubmit As Panel
    Friend WithEvents btnCrear As Button
    Friend WithEvents panelErrores As Panel
    Friend WithEvents tablaErrores As TableLayoutPanel
    Friend WithEvents panelErroresHead As Panel
    Friend WithEvents flowlayoutHeadError As FlowLayoutPanel
    Friend WithEvents lblErrorHeadImagen As Label
    Friend WithEvents lblErrorHead As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblErrorMensajes As Label
    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents lblAvisoTotal As Label
    Friend WithEvents lblPrecioTotalAutomatico As Label
End Class
