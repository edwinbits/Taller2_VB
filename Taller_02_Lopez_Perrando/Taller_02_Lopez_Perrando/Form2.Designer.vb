<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.btnID = New System.Windows.Forms.Button()
        Me.btnTer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnID
        '
        Me.btnID.BackColor = System.Drawing.Color.GhostWhite
        Me.btnID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnID.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnID.Location = New System.Drawing.Point(240, 132)
        Me.btnID.Name = "btnID"
        Me.btnID.Size = New System.Drawing.Size(233, 89)
        Me.btnID.TabIndex = 11
        Me.btnID.Text = "Ingresar Datos"
        Me.btnID.UseVisualStyleBackColor = False
        Me.btnID.Visible = False
        '
        'btnTer
        '
        Me.btnTer.BackColor = System.Drawing.Color.GhostWhite
        Me.btnTer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTer.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTer.Location = New System.Drawing.Point(515, 281)
        Me.btnTer.Name = "btnTer"
        Me.btnTer.Size = New System.Drawing.Size(163, 61)
        Me.btnTer.TabIndex = 12
        Me.btnTer.Text = "Terminar"
        Me.btnTer.UseVisualStyleBackColor = False
        Me.btnTer.Visible = False
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(728, 386)
        Me.Controls.Add(Me.btnTer)
        Me.Controls.Add(Me.btnID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm1"
        Me.Text = "Ejemplo Entrada y Salida de Datos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnID As Button
    Friend WithEvents btnTer As Button
End Class
