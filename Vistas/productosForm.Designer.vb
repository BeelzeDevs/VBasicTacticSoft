<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productosForm
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
        Me.layoutContainerBtns = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCrearProducto = New System.Windows.Forms.Button()
        Me.btnBajaModProducto = New System.Windows.Forms.Button()
        Me.btnListarProducto = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.layoutContainerBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'layoutContainerBtns
        '
        Me.layoutContainerBtns.Controls.Add(Me.btnCrearProducto)
        Me.layoutContainerBtns.Controls.Add(Me.btnBajaModProducto)
        Me.layoutContainerBtns.Controls.Add(Me.btnListarProducto)
        Me.layoutContainerBtns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutContainerBtns.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.layoutContainerBtns.Location = New System.Drawing.Point(0, 0)
        Me.layoutContainerBtns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.layoutContainerBtns.Name = "layoutContainerBtns"
        Me.layoutContainerBtns.Size = New System.Drawing.Size(1200, 689)
        Me.layoutContainerBtns.TabIndex = 0
        '
        'btnCrearProducto
        '
        Me.btnCrearProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnCrearProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearProducto.ForeColor = System.Drawing.Color.White
        Me.btnCrearProducto.Location = New System.Drawing.Point(4, 4)
        Me.btnCrearProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCrearProducto.Name = "btnCrearProducto"
        Me.btnCrearProducto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCrearProducto.Size = New System.Drawing.Size(273, 62)
        Me.btnCrearProducto.TabIndex = 2
        Me.btnCrearProducto.Text = "Crear Producto"
        Me.btnCrearProducto.UseVisualStyleBackColor = False
        '
        'btnBajaModProducto
        '
        Me.btnBajaModProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBajaModProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBajaModProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBajaModProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBajaModProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaModProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaModProducto.ForeColor = System.Drawing.Color.White
        Me.btnBajaModProducto.Location = New System.Drawing.Point(4, 74)
        Me.btnBajaModProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBajaModProducto.Name = "btnBajaModProducto"
        Me.btnBajaModProducto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaModProducto.Size = New System.Drawing.Size(273, 66)
        Me.btnBajaModProducto.TabIndex = 1
        Me.btnBajaModProducto.Text = "Baja - Modificacion Venta"
        Me.btnBajaModProducto.UseVisualStyleBackColor = False
        '
        'btnListarProducto
        '
        Me.btnListarProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnListarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnListarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnListarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarProducto.ForeColor = System.Drawing.Color.White
        Me.btnListarProducto.Location = New System.Drawing.Point(4, 148)
        Me.btnListarProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnListarProducto.Name = "btnListarProducto"
        Me.btnListarProducto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnListarProducto.Size = New System.Drawing.Size(273, 62)
        Me.btnListarProducto.TabIndex = 3
        Me.btnListarProducto.Text = "Buscador de productos"
        Me.btnListarProducto.UseVisualStyleBackColor = False
        '
        'productosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 689)
        Me.Controls.Add(Me.layoutContainerBtns)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "productosForm"
        Me.layoutContainerBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutContainerBtns As FlowLayoutPanel
    Friend WithEvents btnBajaModProducto As Button
    Friend WithEvents btnCrearProducto As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnListarProducto As Button
End Class
