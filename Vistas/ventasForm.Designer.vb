<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventasForm
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
        Me.layoutContainerBtns = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCrearVenta = New System.Windows.Forms.Button()
        Me.btnBajaModificacionVenta = New System.Windows.Forms.Button()
        Me.btnListarVenta = New System.Windows.Forms.Button()
        Me.layoutContainerBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'layoutContainerBtns
        '
        Me.layoutContainerBtns.Controls.Add(Me.btnCrearVenta)
        Me.layoutContainerBtns.Controls.Add(Me.btnBajaModificacionVenta)
        Me.layoutContainerBtns.Controls.Add(Me.btnListarVenta)
        Me.layoutContainerBtns.Dock = System.Windows.Forms.DockStyle.Left
        Me.layoutContainerBtns.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.layoutContainerBtns.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.layoutContainerBtns.Location = New System.Drawing.Point(0, 0)
        Me.layoutContainerBtns.Margin = New System.Windows.Forms.Padding(4)
        Me.layoutContainerBtns.Name = "layoutContainerBtns"
        Me.layoutContainerBtns.Size = New System.Drawing.Size(1200, 689)
        Me.layoutContainerBtns.TabIndex = 1
        '
        'btnCrearVenta
        '
        Me.btnCrearVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearVenta.ForeColor = System.Drawing.Color.White
        Me.btnCrearVenta.Location = New System.Drawing.Point(4, 4)
        Me.btnCrearVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrearVenta.Name = "btnCrearVenta"
        Me.btnCrearVenta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCrearVenta.Size = New System.Drawing.Size(265, 62)
        Me.btnCrearVenta.TabIndex = 6
        Me.btnCrearVenta.Text = "Crear Venta"
        Me.btnCrearVenta.UseVisualStyleBackColor = False
        '
        'btnBajaModificacionVenta
        '
        Me.btnBajaModificacionVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBajaModificacionVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBajaModificacionVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBajaModificacionVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBajaModificacionVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaModificacionVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaModificacionVenta.ForeColor = System.Drawing.Color.White
        Me.btnBajaModificacionVenta.Location = New System.Drawing.Point(4, 74)
        Me.btnBajaModificacionVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBajaModificacionVenta.Name = "btnBajaModificacionVenta"
        Me.btnBajaModificacionVenta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaModificacionVenta.Size = New System.Drawing.Size(265, 62)
        Me.btnBajaModificacionVenta.TabIndex = 5
        Me.btnBajaModificacionVenta.Text = "Baja - Modificacion Venta"
        Me.btnBajaModificacionVenta.UseVisualStyleBackColor = False
        '
        'btnListarVenta
        '
        Me.btnListarVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnListarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnListarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnListarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarVenta.ForeColor = System.Drawing.Color.White
        Me.btnListarVenta.Location = New System.Drawing.Point(4, 144)
        Me.btnListarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListarVenta.Name = "btnListarVenta"
        Me.btnListarVenta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnListarVenta.Size = New System.Drawing.Size(265, 62)
        Me.btnListarVenta.TabIndex = 4
        Me.btnListarVenta.Text = "Buscador de ventas"
        Me.btnListarVenta.UseVisualStyleBackColor = False
        '
        'ventasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 689)
        Me.Controls.Add(Me.layoutContainerBtns)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ventasForm"
        Me.Text = "Form1"
        Me.layoutContainerBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutContainerBtns As FlowLayoutPanel
    Friend WithEvents btnCrearVenta As Button
    Friend WithEvents btnBajaModificacionVenta As Button
    Friend WithEvents btnListarVenta As Button
End Class
