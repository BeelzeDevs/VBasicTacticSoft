<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clientesForm
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
        Me.btnBuscadorClientes = New System.Windows.Forms.Button()
        Me.btnCrearCliente = New System.Windows.Forms.Button()
        Me.layoutContainerBtns = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBajaModClientes = New System.Windows.Forms.Button()
        Me.layoutContainerBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscadorClientes
        '
        Me.btnBuscadorClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnBuscadorClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBuscadorClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscadorClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscadorClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscadorClientes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscadorClientes.ForeColor = System.Drawing.Color.White
        Me.btnBuscadorClientes.Location = New System.Drawing.Point(4, 148)
        Me.btnBuscadorClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscadorClientes.Name = "btnBuscadorClientes"
        Me.btnBuscadorClientes.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscadorClientes.Size = New System.Drawing.Size(273, 66)
        Me.btnBuscadorClientes.TabIndex = 5
        Me.btnBuscadorClientes.Text = "Buscador de clientes"
        Me.btnBuscadorClientes.UseVisualStyleBackColor = False
        '
        'btnCrearCliente
        '
        Me.btnCrearCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnCrearCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCliente.ForeColor = System.Drawing.Color.White
        Me.btnCrearCliente.Location = New System.Drawing.Point(4, 4)
        Me.btnCrearCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCrearCliente.Name = "btnCrearCliente"
        Me.btnCrearCliente.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCrearCliente.Size = New System.Drawing.Size(273, 62)
        Me.btnCrearCliente.TabIndex = 6
        Me.btnCrearCliente.Text = "Crear Cliente"
        Me.btnCrearCliente.UseVisualStyleBackColor = False
        '
        'layoutContainerBtns
        '
        Me.layoutContainerBtns.Controls.Add(Me.btnCrearCliente)
        Me.layoutContainerBtns.Controls.Add(Me.btnBajaModClientes)
        Me.layoutContainerBtns.Controls.Add(Me.btnBuscadorClientes)
        Me.layoutContainerBtns.Dock = System.Windows.Forms.DockStyle.Left
        Me.layoutContainerBtns.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.layoutContainerBtns.Location = New System.Drawing.Point(0, 0)
        Me.layoutContainerBtns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.layoutContainerBtns.Name = "layoutContainerBtns"
        Me.layoutContainerBtns.Size = New System.Drawing.Size(1200, 689)
        Me.layoutContainerBtns.TabIndex = 0
        '
        'btnBajaModClientes
        '
        Me.btnBajaModClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnBajaModClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnBajaModClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBajaModClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBajaModClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaModClientes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaModClientes.ForeColor = System.Drawing.Color.White
        Me.btnBajaModClientes.Location = New System.Drawing.Point(4, 74)
        Me.btnBajaModClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBajaModClientes.Name = "btnBajaModClientes"
        Me.btnBajaModClientes.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaModClientes.Size = New System.Drawing.Size(273, 66)
        Me.btnBajaModClientes.TabIndex = 7
        Me.btnBajaModClientes.Text = "Baja - Modificacion Clientes"
        Me.btnBajaModClientes.UseVisualStyleBackColor = False
        '
        'clientesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 689)
        Me.Controls.Add(Me.layoutContainerBtns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "clientesForm"
        Me.layoutContainerBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscadorClientes As Button
    Friend WithEvents btnCrearCliente As Button
    Friend WithEvents layoutContainerBtns As FlowLayoutPanel
    Friend WithEvents btnBajaModClientes As Button
End Class
