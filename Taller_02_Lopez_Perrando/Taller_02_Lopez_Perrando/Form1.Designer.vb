<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Universidad Tecnologica de Panama"
        '
        'btnDatos
        '
        Me.btnDatos.Location = New System.Drawing.Point(117, 166)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(112, 42)
        Me.btnDatos.TabIndex = 0
        Me.btnDatos.Text = "Ingresar Datos"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'btnTerminar
        '
        Me.btnTerminar.Location = New System.Drawing.Point(294, 166)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(111, 42)
        Me.btnTerminar.TabIndex = 1
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'frmPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(515, 277)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnDatos)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPP"
        Me.Text = "Pagina de Presentacion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDatos As Button
    Friend WithEvents btnTerminar As Button
End Class
