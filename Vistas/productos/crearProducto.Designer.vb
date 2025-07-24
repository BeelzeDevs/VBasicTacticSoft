<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crearProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crearProducto))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.panelSubmit = New System.Windows.Forms.Panel()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.tablelayoutForm = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtOtraCateg = New System.Windows.Forms.TextBox()
        Me.lblOtraCategoria = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.tablaErrores = New System.Windows.Forms.TableLayoutPanel()
        Me.panelErroresHead = New System.Windows.Forms.Panel()
        Me.flowHeadError = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblErrorHeadImagen = New System.Windows.Forms.Label()
        Me.lblErrorHead = New System.Windows.Forms.Label()
        Me.panelErrores = New System.Windows.Forms.Panel()
        Me.lblErrorMensajes = New System.Windows.Forms.Label()
        Me.panelSubmit.SuspendLayout()
        Me.panelForm.SuspendLayout()
        Me.tablelayoutForm.SuspendLayout()
        Me.tablaErrores.SuspendLayout()
        Me.panelErroresHead.SuspendLayout()
        Me.flowHeadError.SuspendLayout()
        Me.panelErrores.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSubmit
        '
        Me.panelSubmit.Controls.Add(Me.btnCrear)
        Me.panelSubmit.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubmit.Location = New System.Drawing.Point(0, 219)
        Me.panelSubmit.Name = "panelSubmit"
        Me.panelSubmit.Size = New System.Drawing.Size(1010, 75)
        Me.panelSubmit.TabIndex = 6
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(463, 19)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(84, 37)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'panelForm
        '
        Me.panelForm.Controls.Add(Me.tablelayoutForm)
        Me.panelForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelForm.Location = New System.Drawing.Point(0, 39)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(1010, 180)
        Me.panelForm.TabIndex = 5
        '
        'tablelayoutForm
        '
        Me.tablelayoutForm.ColumnCount = 5
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.04348!))
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.95652!))
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195.0!))
        Me.tablelayoutForm.Controls.Add(Me.lblNombre, 1, 0)
        Me.tablelayoutForm.Controls.Add(Me.txtPrecio, 2, 1)
        Me.tablelayoutForm.Controls.Add(Me.lblPrecio, 1, 1)
        Me.tablelayoutForm.Controls.Add(Me.lblCategoria, 1, 2)
        Me.tablelayoutForm.Controls.Add(Me.txtNombre, 2, 0)
        Me.tablelayoutForm.Controls.Add(Me.cbCategoria, 2, 2)
        Me.tablelayoutForm.Controls.Add(Me.txtOtraCateg, 4, 2)
        Me.tablelayoutForm.Controls.Add(Me.lblOtraCategoria, 3, 2)
        Me.tablelayoutForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutForm.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutForm.Name = "tablelayoutForm"
        Me.tablelayoutForm.RowCount = 3
        Me.tablelayoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutForm.Size = New System.Drawing.Size(1010, 180)
        Me.tablelayoutForm.TabIndex = 11
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(362, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 60)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio
        '
        Me.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecio.Location = New System.Drawing.Point(432, 77)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(226, 26)
        Me.txtPrecio.TabIndex = 11
        '
        'lblPrecio
        '
        Me.lblPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.White
        Me.lblPrecio.Location = New System.Drawing.Point(373, 60)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(53, 60)
        Me.lblPrecio.TabIndex = 15
        Me.lblPrecio.Text = "Precio:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategoria
        '
        Me.lblCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.White
        Me.lblCategoria.Location = New System.Drawing.Point(350, 120)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(76, 60)
        Me.lblCategoria.TabIndex = 16
        Me.lblCategoria.Text = "Categoría:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.Location = New System.Drawing.Point(432, 17)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(226, 26)
        Me.txtNombre.TabIndex = 10
        '
        'cbCategoria
        '
        Me.cbCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Items.AddRange(New Object() {"Limpieza", "Comestibles", "Bebidas"})
        Me.cbCategoria.Location = New System.Drawing.Point(432, 139)
        Me.cbCategoria.MaxDropDownItems = 6
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(226, 26)
        Me.cbCategoria.TabIndex = 17
        '
        'txtOtraCateg
        '
        Me.txtOtraCateg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOtraCateg.Location = New System.Drawing.Point(817, 137)
        Me.txtOtraCateg.Name = "txtOtraCateg"
        Me.txtOtraCateg.Size = New System.Drawing.Size(190, 26)
        Me.txtOtraCateg.TabIndex = 19
        '
        'lblOtraCategoria
        '
        Me.lblOtraCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblOtraCategoria.AutoSize = True
        Me.lblOtraCategoria.ForeColor = System.Drawing.Color.White
        Me.lblOtraCategoria.Location = New System.Drawing.Point(715, 132)
        Me.lblOtraCategoria.Name = "lblOtraCategoria"
        Me.lblOtraCategoria.Size = New System.Drawing.Size(96, 36)
        Me.lblOtraCategoria.TabIndex = 18
        Me.lblOtraCategoria.Text = "Categoria Pesonalizada: "
        Me.lblOtraCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelTop
        '
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1010, 39)
        Me.panelTop.TabIndex = 3
        '
        'tablaErrores
        '
        Me.tablaErrores.ColumnCount = 3
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59188!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40812!))
        Me.tablaErrores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.tablaErrores.Controls.Add(Me.panelErroresHead, 1, 0)
        Me.tablaErrores.Controls.Add(Me.panelErrores, 1, 1)
        Me.tablaErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaErrores.Location = New System.Drawing.Point(0, 294)
        Me.tablaErrores.Name = "tablaErrores"
        Me.tablaErrores.RowCount = 2
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.063444!))
        Me.tablaErrores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.93655!))
        Me.tablaErrores.Size = New System.Drawing.Size(1010, 331)
        Me.tablaErrores.TabIndex = 7
        Me.tablaErrores.Visible = False
        '
        'panelErroresHead
        '
        Me.panelErroresHead.Controls.Add(Me.flowHeadError)
        Me.panelErroresHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelErroresHead.Location = New System.Drawing.Point(230, 3)
        Me.panelErroresHead.Name = "panelErroresHead"
        Me.panelErroresHead.Size = New System.Drawing.Size(654, 24)
        Me.panelErroresHead.TabIndex = 8
        '
        'flowHeadError
        '
        Me.flowHeadError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowHeadError.Controls.Add(Me.lblErrorHeadImagen)
        Me.flowHeadError.Controls.Add(Me.lblErrorHead)
        Me.flowHeadError.Location = New System.Drawing.Point(249, 3)
        Me.flowHeadError.Name = "flowHeadError"
        Me.flowHeadError.Size = New System.Drawing.Size(139, 100)
        Me.flowHeadError.TabIndex = 0
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
        'panelErrores
        '
        Me.panelErrores.Controls.Add(Me.lblErrorMensajes)
        Me.panelErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelErrores.Location = New System.Drawing.Point(230, 33)
        Me.panelErrores.Name = "panelErrores"
        Me.panelErrores.Size = New System.Drawing.Size(654, 295)
        Me.panelErrores.TabIndex = 9
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
        'crearProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 625)
        Me.Controls.Add(Me.tablaErrores)
        Me.Controls.Add(Me.panelSubmit)
        Me.Controls.Add(Me.panelForm)
        Me.Controls.Add(Me.panelTop)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "crearProducto"
        Me.panelSubmit.ResumeLayout(False)
        Me.panelForm.ResumeLayout(False)
        Me.tablelayoutForm.ResumeLayout(False)
        Me.tablelayoutForm.PerformLayout()
        Me.tablaErrores.ResumeLayout(False)
        Me.panelErroresHead.ResumeLayout(False)
        Me.flowHeadError.ResumeLayout(False)
        Me.flowHeadError.PerformLayout()
        Me.panelErrores.ResumeLayout(False)
        Me.panelErrores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents panelSubmit As Panel
    Friend WithEvents panelForm As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents tablaErrores As TableLayoutPanel
    Friend WithEvents panelErroresHead As Panel
    Friend WithEvents flowHeadError As FlowLayoutPanel
    Friend WithEvents lblErrorHeadImagen As Label
    Friend WithEvents lblErrorHead As Label
    Friend WithEvents panelErrores As Panel
    Friend WithEvents lblErrorMensajes As Label
    Friend WithEvents tablelayoutForm As TableLayoutPanel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents lblOtraCategoria As Label
    Friend WithEvents txtOtraCateg As TextBox
End Class
