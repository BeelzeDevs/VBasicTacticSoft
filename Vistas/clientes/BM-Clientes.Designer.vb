<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BM_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BM_Clientes))
        Me.panelFilters = New System.Windows.Forms.Panel()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.flayoutClientes = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelErrores = New System.Windows.Forms.Panel()
        Me.tablaErrores = New System.Windows.Forms.TableLayoutPanel()
        Me.panelErroresHead = New System.Windows.Forms.Panel()
        Me.flowlayoutHeadError = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblErrorHeadImagen = New System.Windows.Forms.Label()
        Me.lblErrorHead = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblErrorMensajes = New System.Windows.Forms.Label()
        Me.gvClientes = New Vistas.CustomDataGridView()
        Me.panelFilters.SuspendLayout()
        Me.panelErrores.SuspendLayout()
        Me.tablaErrores.SuspendLayout()
        Me.panelErroresHead.SuspendLayout()
        Me.flowlayoutHeadError.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelFilters
        '
        Me.panelFilters.Controls.Add(Me.txtIdCliente)
        Me.panelFilters.Controls.Add(Me.btnReset)
        Me.panelFilters.Controls.Add(Me.btnBuscarID)
        Me.panelFilters.Controls.Add(Me.lblIdCliente)
        Me.panelFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFilters.Location = New System.Drawing.Point(0, 0)
        Me.panelFilters.Name = "panelFilters"
        Me.panelFilters.Size = New System.Drawing.Size(1010, 74)
        Me.panelFilters.TabIndex = 0
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(290, 31)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(200, 30)
        Me.txtIdCliente.TabIndex = 13
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
        Me.btnReset.TabIndex = 11
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
        Me.btnBuscarID.TabIndex = 12
        Me.btnBuscarID.Text = "Buscar"
        Me.btnBuscarID.UseVisualStyleBackColor = False
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.ForeColor = System.Drawing.Color.White
        Me.lblIdCliente.Location = New System.Drawing.Point(160, 33)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(161, 24)
        Me.lblIdCliente.TabIndex = 10
        Me.lblIdCliente.Text = "Ingrese ID Cliente:"
        '
        'flayoutClientes
        '
        Me.flayoutClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.flayoutClientes.Location = New System.Drawing.Point(0, 74)
        Me.flayoutClientes.Name = "flayoutClientes"
        Me.flayoutClientes.Size = New System.Drawing.Size(1010, 252)
        Me.flayoutClientes.TabIndex = 1
        '
        'panelErrores
        '
        Me.panelErrores.Controls.Add(Me.tablaErrores)
        Me.panelErrores.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelErrores.Location = New System.Drawing.Point(0, 326)
        Me.panelErrores.Name = "panelErrores"
        Me.panelErrores.Size = New System.Drawing.Size(1010, 299)
        Me.panelErrores.TabIndex = 2
        '
        'tablaErrores
        '
        Me.tablaErrores.ColumnCount = 3
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59188!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40812!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
        Me.tablaErrores.Controls.Add(Me.panelErroresHead, 1, 0)
        Me.tablaErrores.Controls.Add(Me.Panel1, 1, 1)
        Me.tablaErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaErrores.Location = New System.Drawing.Point(0, 0)
        Me.tablaErrores.Name = "tablaErrores"
        Me.tablaErrores.RowCount = 2
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.063444!))
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.93655!))
        Me.tablaErrores.Size = New System.Drawing.Size(1010, 299)
        Me.tablaErrores.TabIndex = 7
        '
        'panelErroresHead
        '
        Me.panelErroresHead.Controls.Add(Me.flowlayoutHeadError)
        Me.panelErroresHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelErroresHead.Location = New System.Drawing.Point(225, 3)
        Me.panelErroresHead.Name = "panelErroresHead"
        Me.panelErroresHead.Size = New System.Drawing.Size(642, 21)
        Me.panelErroresHead.TabIndex = 8
        '
        'flowlayoutHeadError
        '
        Me.flowlayoutHeadError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHeadImagen)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHead)
        Me.flowlayoutHeadError.Location = New System.Drawing.Point(249, 1)
        Me.flowlayoutHeadError.Name = "flowlayoutHeadError"
        Me.flowlayoutHeadError.Size = New System.Drawing.Size(127, 100)
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
        Me.Panel1.Location = New System.Drawing.Point(225, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 266)
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
        'gvClientes
        '
        Me.gvClientes.ColumnHeadersHeight = 29
        Me.gvClientes.Location = New System.Drawing.Point(0, 0)
        Me.gvClientes.Name = "gvClientes"
        Me.gvClientes.RowHeadersWidth = 51
        Me.gvClientes.Size = New System.Drawing.Size(240, 150)
        Me.gvClientes.TabIndex = 0
        '
        'BM_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 625)
        Me.Controls.Add(Me.panelErrores)
        Me.Controls.Add(Me.flayoutClientes)
        Me.Controls.Add(Me.panelFilters)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BM_Clientes"
        Me.Text = "BM_Clientes"
        Me.panelFilters.ResumeLayout(False)
        Me.panelFilters.PerformLayout()
        Me.panelErrores.ResumeLayout(False)
        Me.tablaErrores.ResumeLayout(False)
        Me.panelErroresHead.ResumeLayout(False)
        Me.flowlayoutHeadError.ResumeLayout(False)
        Me.flowlayoutHeadError.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFilters As Panel
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents lblIdCliente As Label
    Friend WithEvents flayoutClientes As FlowLayoutPanel
    Friend WithEvents panelErrores As Panel
    Friend WithEvents tablaErrores As TableLayoutPanel
    Friend WithEvents panelErroresHead As Panel
    Friend WithEvents flowlayoutHeadError As FlowLayoutPanel
    Friend WithEvents lblErrorHeadImagen As Label
    Friend WithEvents lblErrorHead As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblErrorMensajes As Label
End Class
