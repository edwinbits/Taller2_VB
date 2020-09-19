<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIns = New System.Windows.Forms.Label()
        Me.lblUTP = New System.Windows.Forms.Label()
        Me.lblFISC = New System.Windows.Forms.Label()
        Me.txtIns = New System.Windows.Forms.TextBox()
        Me.lblLDS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAP = New System.Windows.Forms.Label()
        Me.lblEL = New System.Windows.Forms.Label()
        Me.lbl1LS132 = New System.Windows.Forms.Label()
        Me.btnRegPP = New System.Windows.Forms.Button()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
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
        'lblIns
        '
        Me.lblIns.AutoSize = True
        Me.lblIns.BackColor = System.Drawing.Color.Transparent
        Me.lblIns.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIns.Location = New System.Drawing.Point(447, 28)
        Me.lblIns.Name = "lblIns"
        Me.lblIns.Size = New System.Drawing.Size(234, 39)
        Me.lblIns.TabIndex = 10
        Me.lblIns.Text = "Instrucciones"
        Me.lblIns.Visible = False
        '
        'lblUTP
        '
        Me.lblUTP.AutoSize = True
        Me.lblUTP.BackColor = System.Drawing.Color.Transparent
        Me.lblUTP.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUTP.Location = New System.Drawing.Point(268, 28)
        Me.lblUTP.Name = "lblUTP"
        Me.lblUTP.Size = New System.Drawing.Size(544, 35)
        Me.lblUTP.TabIndex = 11
        Me.lblUTP.Text = "Universidad Tecnologica De Panama"
        '
        'lblFISC
        '
        Me.lblFISC.AutoSize = True
        Me.lblFISC.BackColor = System.Drawing.Color.Transparent
        Me.lblFISC.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFISC.Location = New System.Drawing.Point(186, 78)
        Me.lblFISC.Name = "lblFISC"
        Me.lblFISC.Size = New System.Drawing.Size(793, 35)
        Me.lblFISC.TabIndex = 12
        Me.lblFISC.Text = "Facultad De Ingenieria En Sistemas Computacionales"
        '
        'txtIns
        '
        Me.txtIns.BackColor = System.Drawing.Color.White
        Me.txtIns.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIns.Location = New System.Drawing.Point(122, 130)
        Me.txtIns.Multiline = True
        Me.txtIns.Name = "txtIns"
        Me.txtIns.ReadOnly = True
        Me.txtIns.Size = New System.Drawing.Size(884, 458)
        Me.txtIns.TabIndex = 13
        Me.txtIns.Text = "AQUI VA LA INSTRUCCION"
        Me.txtIns.Visible = False
        '
        'lblLDS
        '
        Me.lblLDS.AutoSize = True
        Me.lblLDS.BackColor = System.Drawing.Color.Transparent
        Me.lblLDS.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDS.Location = New System.Drawing.Point(262, 130)
        Me.lblLDS.Name = "lblLDS"
        Me.lblLDS.Size = New System.Drawing.Size(589, 35)
        Me.lblLDS.TabIndex = 14
        Me.lblLDS.Text = "Licenciatura En Desarrollo De Software"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(343, 33)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Desarrollo De Software VIII"
        '
        'lblAP
        '
        Me.lblAP.AutoSize = True
        Me.lblAP.BackColor = System.Drawing.Color.Transparent
        Me.lblAP.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAP.Location = New System.Drawing.Point(427, 307)
        Me.lblAP.Name = "lblAP"
        Me.lblAP.Size = New System.Drawing.Size(191, 33)
        Me.lblAP.TabIndex = 16
        Me.lblAP.Text = "Anna Perrando"
        '
        'lblEL
        '
        Me.lblEL.AutoSize = True
        Me.lblEL.BackColor = System.Drawing.Color.Transparent
        Me.lblEL.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEL.Location = New System.Drawing.Point(438, 377)
        Me.lblEL.Name = "lblEL"
        Me.lblEL.Size = New System.Drawing.Size(163, 33)
        Me.lblEL.TabIndex = 17
        Me.lblEL.Text = "Edwin Lopez"
        '
        'lbl1LS132
        '
        Me.lbl1LS132.AutoSize = True
        Me.lbl1LS132.BackColor = System.Drawing.Color.Transparent
        Me.lbl1LS132.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1LS132.Location = New System.Drawing.Point(463, 465)
        Me.lbl1LS132.Name = "lbl1LS132"
        Me.lbl1LS132.Size = New System.Drawing.Size(103, 33)
        Me.lbl1LS132.TabIndex = 18
        Me.lbl1LS132.Text = "1LS132"
        '
        'btnRegPP
        '
        Me.btnRegPP.BackColor = System.Drawing.Color.GhostWhite
        Me.btnRegPP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegPP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegPP.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegPP.Location = New System.Drawing.Point(122, 657)
        Me.btnRegPP.Name = "btnRegPP"
        Me.btnRegPP.Size = New System.Drawing.Size(163, 61)
        Me.btnRegPP.TabIndex = 19
        Me.btnRegPP.Text = "Regresar"
        Me.btnRegPP.UseVisualStyleBackColor = False
        Me.btnRegPP.Visible = False
        '
        'btnIns
        '
        Me.btnIns.BackColor = System.Drawing.Color.GhostWhite
        Me.btnIns.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIns.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIns.Location = New System.Drawing.Point(122, 657)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(163, 61)
        Me.btnIns.TabIndex = 20
        Me.btnIns.Text = "Instrucciones"
        Me.btnIns.UseVisualStyleBackColor = False
        '
        'btnSig
        '
        Me.btnSig.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSig.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSig.Location = New System.Drawing.Point(836, 657)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(163, 61)
        Me.btnSig.TabIndex = 21
        Me.btnSig.Text = "Siguiente"
        Me.btnSig.UseVisualStyleBackColor = False
        '
        'frmPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1136, 779)
        Me.Controls.Add(Me.txtIns)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.btnRegPP)
        Me.Controls.Add(Me.lbl1LS132)
        Me.Controls.Add(Me.lblEL)
        Me.Controls.Add(Me.lblAP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLDS)
        Me.Controls.Add(Me.lblFISC)
        Me.Controls.Add(Me.lblUTP)
        Me.Controls.Add(Me.lblIns)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPP"
        Me.Text = "Pagina de Presentacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIns As Label
    Friend WithEvents lblUTP As Label
    Friend WithEvents lblFISC As Label
    Friend WithEvents txtIns As TextBox
    Friend WithEvents lblLDS As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAP As Label
    Friend WithEvents lblEL As Label
    Friend WithEvents lbl1LS132 As Label
    Friend WithEvents btnRegPP As Button
    Friend WithEvents btnIns As Button
    Friend WithEvents btnSig As Button
End Class
