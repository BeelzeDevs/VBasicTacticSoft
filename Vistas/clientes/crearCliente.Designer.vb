<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crearCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crearCliente))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.tablelayoutForm = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.panelSubmit = New System.Windows.Forms.Panel()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.tablaErrores = New System.Windows.Forms.TableLayoutPanel()
        Me.panelErroresHead = New System.Windows.Forms.Panel()
        Me.flowlayoutHeadError = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblErrorHeadImagen = New System.Windows.Forms.Label()
        Me.lblErrorHead = New System.Windows.Forms.Label()
        Me.panelErrores = New System.Windows.Forms.Panel()
        Me.lblErrorMensajes = New System.Windows.Forms.Label()
        Me.panelForm.SuspendLayout()
        Me.tablelayoutForm.SuspendLayout()
        Me.panelSubmit.SuspendLayout()
        Me.tablaErrores.SuspendLayout()
        Me.panelErroresHead.SuspendLayout()
        Me.flowlayoutHeadError.SuspendLayout()
        Me.panelErrores.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1010, 39)
        Me.panelTop.TabIndex = 1
        '
        'panelForm
        '
        Me.panelForm.Controls.Add(Me.tablelayoutForm)
        Me.panelForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelForm.Location = New System.Drawing.Point(0, 39)
        Me.panelForm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(1010, 180)
        Me.panelForm.TabIndex = 2
        '
        'tablelayoutForm
        '
        Me.tablelayoutForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutForm.ColumnCount = 4
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.04348!))
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.95652!))
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267.0!))
        Me.tablelayoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 361.0!))
        Me.tablelayoutForm.Controls.Add(Me.txtCorreo, 2, 2)
        Me.tablelayoutForm.Controls.Add(Me.lblNombre, 1, 0)
        Me.tablelayoutForm.Controls.Add(Me.txtTelefono, 2, 1)
        Me.tablelayoutForm.Controls.Add(Me.lblTelefono, 1, 1)
        Me.tablelayoutForm.Controls.Add(Me.lblCorreo, 1, 2)
        Me.tablelayoutForm.Controls.Add(Me.txtNombre, 2, 0)
        Me.tablelayoutForm.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutForm.Name = "tablelayoutForm"
        Me.tablelayoutForm.RowCount = 3
        Me.tablelayoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutForm.Size = New System.Drawing.Size(1010, 180)
        Me.tablelayoutForm.TabIndex = 10
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCorreo.Location = New System.Drawing.Point(387, 137)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(255, 26)
        Me.txtCorreo.TabIndex = 12
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(314, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 60)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTelefono.Location = New System.Drawing.Point(387, 77)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(255, 26)
        Me.txtTelefono.TabIndex = 11
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(309, 60)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(69, 60)
        Me.lblTelefono.TabIndex = 15
        Me.lblTelefono.Text = "Telefono:"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorreo
        '
        Me.lblCorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.White
        Me.lblCorreo.Location = New System.Drawing.Point(322, 120)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(56, 60)
        Me.lblCorreo.TabIndex = 16
        Me.lblCorreo.Text = "Correo:"
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.Location = New System.Drawing.Point(387, 17)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(255, 26)
        Me.txtNombre.TabIndex = 10
        '
        'panelSubmit
        '
        Me.panelSubmit.Controls.Add(Me.btnCrear)
        Me.panelSubmit.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubmit.Location = New System.Drawing.Point(0, 219)
        Me.panelSubmit.Name = "panelSubmit"
        Me.panelSubmit.Size = New System.Drawing.Size(1010, 75)
        Me.panelSubmit.TabIndex = 3
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(479, 19)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(84, 37)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
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
        Me.tablaErrores.TabIndex = 4
        Me.tablaErrores.Visible = False
        '
        'panelErroresHead
        '
        Me.panelErroresHead.Controls.Add(Me.flowlayoutHeadError)
        Me.panelErroresHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelErroresHead.Location = New System.Drawing.Point(230, 3)
        Me.panelErroresHead.Name = "panelErroresHead"
        Me.panelErroresHead.Size = New System.Drawing.Size(654, 24)
        Me.panelErroresHead.TabIndex = 8
        '
        'flowlayoutHeadError
        '
        Me.flowlayoutHeadError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHeadImagen)
        Me.flowlayoutHeadError.Controls.Add(Me.lblErrorHead)
        Me.flowlayoutHeadError.Location = New System.Drawing.Point(249, 3)
        Me.flowlayoutHeadError.Name = "flowlayoutHeadError"
        Me.flowlayoutHeadError.Size = New System.Drawing.Size(139, 100)
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
        'crearCliente
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "crearCliente"
        Me.panelForm.ResumeLayout(False)
        Me.tablelayoutForm.ResumeLayout(False)
        Me.tablelayoutForm.PerformLayout()
        Me.panelSubmit.ResumeLayout(False)
        Me.tablaErrores.ResumeLayout(False)
        Me.panelErroresHead.ResumeLayout(False)
        Me.flowlayoutHeadError.ResumeLayout(False)
        Me.flowlayoutHeadError.PerformLayout()
        Me.panelErrores.ResumeLayout(False)
        Me.panelErrores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelTop As Panel
    Friend WithEvents panelForm As Panel
    Friend WithEvents tablelayoutForm As TableLayoutPanel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents panelSubmit As Panel
    Friend WithEvents btnCrear As Button
    Friend WithEvents tablaErrores As TableLayoutPanel
    Friend WithEvents panelErroresHead As Panel
    Friend WithEvents flowlayoutHeadError As FlowLayoutPanel
    Friend WithEvents lblErrorHeadImagen As Label
    Friend WithEvents lblErrorHead As Label
    Friend WithEvents panelErrores As Panel
    Friend WithEvents lblErrorMensajes As Label
End Class
