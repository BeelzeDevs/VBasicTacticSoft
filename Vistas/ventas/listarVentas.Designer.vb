<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listarVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listarVentas))
        Me.panelFilters = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.chkboxSoloActivos = New System.Windows.Forms.CheckBox()
        Me.btnBuscarFecha = New System.Windows.Forms.Button()
        Me.fechaSeleccionada = New System.Windows.Forms.DateTimePicker()
        Me.lblBuscadorFecha = New System.Windows.Forms.Label()
        Me.gvVentas = New System.Windows.Forms.DataGridView()
        Me.panelVentas = New System.Windows.Forms.Panel()
        Me.panelPaginacionFutura = New System.Windows.Forms.Panel()
        Me.panelDetalleVentas = New System.Windows.Forms.Panel()
        Me.gvDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.lblDetalleVenta = New System.Windows.Forms.Label()
        Me.panelFilters.SuspendLayout()
        CType(Me.gvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelVentas.SuspendLayout()
        Me.panelDetalleVentas.SuspendLayout()
        CType(Me.gvDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelFilters
        '
        Me.panelFilters.Controls.Add(Me.btnReset)
        Me.panelFilters.Controls.Add(Me.chkboxSoloActivos)
        Me.panelFilters.Controls.Add(Me.btnBuscarFecha)
        Me.panelFilters.Controls.Add(Me.fechaSeleccionada)
        Me.panelFilters.Controls.Add(Me.lblBuscadorFecha)
        Me.panelFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFilters.Location = New System.Drawing.Point(0, 0)
        Me.panelFilters.Name = "panelFilters"
        Me.panelFilters.Size = New System.Drawing.Size(1010, 98)
        Me.panelFilters.TabIndex = 0
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
        Me.btnReset.Location = New System.Drawing.Point(37, 33)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(55, 48)
        Me.btnReset.TabIndex = 1
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
        Me.chkboxSoloActivos.Location = New System.Drawing.Point(680, 50)
        Me.chkboxSoloActivos.Name = "chkboxSoloActivos"
        Me.chkboxSoloActivos.Size = New System.Drawing.Size(68, 22)
        Me.chkboxSoloActivos.TabIndex = 3
        Me.chkboxSoloActivos.Text = "Estado"
        Me.chkboxSoloActivos.UseVisualStyleBackColor = True
        '
        'btnBuscarFecha
        '
        Me.btnBuscarFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBuscarFecha.FlatAppearance.BorderSize = 0
        Me.btnBuscarFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnBuscarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarFecha.ForeColor = System.Drawing.Color.White
        Me.btnBuscarFecha.Location = New System.Drawing.Point(522, 48)
        Me.btnBuscarFecha.Name = "btnBuscarFecha"
        Me.btnBuscarFecha.Size = New System.Drawing.Size(94, 23)
        Me.btnBuscarFecha.TabIndex = 2
        Me.btnBuscarFecha.Text = "Buscar"
        Me.btnBuscarFecha.UseVisualStyleBackColor = False
        '
        'fechaSeleccionada
        '
        Me.fechaSeleccionada.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fechaSeleccionada.CustomFormat = ""
        Me.fechaSeleccionada.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaSeleccionada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaSeleccionada.Location = New System.Drawing.Point(298, 46)
        Me.fechaSeleccionada.MaxDate = New Date(2025, 1, 11, 0, 0, 0, 0)
        Me.fechaSeleccionada.Name = "fechaSeleccionada"
        Me.fechaSeleccionada.Size = New System.Drawing.Size(200, 27)
        Me.fechaSeleccionada.TabIndex = 1
        Me.fechaSeleccionada.Value = New Date(2025, 1, 11, 0, 0, 0, 0)
        '
        'lblBuscadorFecha
        '
        Me.lblBuscadorFecha.AutoSize = True
        Me.lblBuscadorFecha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscadorFecha.ForeColor = System.Drawing.Color.White
        Me.lblBuscadorFecha.Location = New System.Drawing.Point(147, 48)
        Me.lblBuscadorFecha.Name = "lblBuscadorFecha"
        Me.lblBuscadorFecha.Size = New System.Drawing.Size(129, 19)
        Me.lblBuscadorFecha.TabIndex = 0
        Me.lblBuscadorFecha.Text = "Ingrese una fecha:"
        '
        'gvVentas
        '
        Me.gvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.gvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvVentas.Location = New System.Drawing.Point(0, 0)
        Me.gvVentas.Name = "gvVentas"
        Me.gvVentas.Size = New System.Drawing.Size(1010, 188)
        Me.gvVentas.TabIndex = 0
        '
        'panelVentas
        '
        Me.panelVentas.Controls.Add(Me.gvVentas)
        Me.panelVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelVentas.Location = New System.Drawing.Point(0, 98)
        Me.panelVentas.Name = "panelVentas"
        Me.panelVentas.Size = New System.Drawing.Size(1010, 188)
        Me.panelVentas.TabIndex = 2
        '
        'panelPaginacionFutura
        '
        Me.panelPaginacionFutura.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelPaginacionFutura.Location = New System.Drawing.Point(0, 286)
        Me.panelPaginacionFutura.Name = "panelPaginacionFutura"
        Me.panelPaginacionFutura.Size = New System.Drawing.Size(1010, 66)
        Me.panelPaginacionFutura.TabIndex = 4
        '
        'panelDetalleVentas
        '
        Me.panelDetalleVentas.Controls.Add(Me.gvDetalleVenta)
        Me.panelDetalleVentas.Controls.Add(Me.lblDetalleVenta)
        Me.panelDetalleVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelDetalleVentas.Location = New System.Drawing.Point(0, 352)
        Me.panelDetalleVentas.Name = "panelDetalleVentas"
        Me.panelDetalleVentas.Size = New System.Drawing.Size(1010, 261)
        Me.panelDetalleVentas.TabIndex = 5
        '
        'gvDetalleVenta
        '
        Me.gvDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.gvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvDetalleVenta.Location = New System.Drawing.Point(0, 19)
        Me.gvDetalleVenta.Name = "gvDetalleVenta"
        Me.gvDetalleVenta.Size = New System.Drawing.Size(1010, 242)
        Me.gvDetalleVenta.TabIndex = 5
        '
        'lblDetalleVenta
        '
        Me.lblDetalleVenta.AutoSize = True
        Me.lblDetalleVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDetalleVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalleVenta.ForeColor = System.Drawing.Color.White
        Me.lblDetalleVenta.Location = New System.Drawing.Point(0, 0)
        Me.lblDetalleVenta.Name = "lblDetalleVenta"
        Me.lblDetalleVenta.Size = New System.Drawing.Size(97, 19)
        Me.lblDetalleVenta.TabIndex = 0
        Me.lblDetalleVenta.Text = "Detalle Venta"
        Me.lblDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 625)
        Me.Controls.Add(Me.panelDetalleVentas)
        Me.Controls.Add(Me.panelPaginacionFutura)
        Me.Controls.Add(Me.panelVentas)
        Me.Controls.Add(Me.panelFilters)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "listarVentas"
        Me.Text = "listarVentas"
        Me.panelFilters.ResumeLayout(False)
        Me.panelFilters.PerformLayout()
        CType(Me.gvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelVentas.ResumeLayout(False)
        Me.panelDetalleVentas.ResumeLayout(False)
        Me.panelDetalleVentas.PerformLayout()
        CType(Me.gvDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFilters As Panel
    Friend WithEvents gvVentas As DataGridView
    Friend WithEvents panelVentas As Panel
    Friend WithEvents fechaSeleccionada As DateTimePicker
    Friend WithEvents lblBuscadorFecha As Label
    Friend WithEvents btnBuscarFecha As Button
    Friend WithEvents chkboxSoloActivos As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents panelPaginacionFutura As Panel
    Friend WithEvents panelDetalleVentas As Panel
    Friend WithEvents gvDetalleVenta As DataGridView
    Friend WithEvents lblDetalleVenta As Label
End Class
