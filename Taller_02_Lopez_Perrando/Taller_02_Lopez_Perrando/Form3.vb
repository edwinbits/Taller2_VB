Public Class frm2
    Private Sub btnTer_Click(sender As Object, e As EventArgs) Handles btnTer.Click
        Dim opcion As DialogResult
        opcion = MsgBox("¿Realmente desea salir?", vbYesNo + vbQuestion, "Salir del programa")
        If opcion = DialogResult.Yes Then
            Close()
            Application.Exit()
            End
        End If
    End Sub

    Private Sub frm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTexto.Text = " "
        txtTexto.BackColor = Color.White
        txtTexto.ForeColor = Color.Black

        If chkMayuscula.CheckState = CheckState.Checked Then
            chkMayuscula.CheckState = CheckState.Unchecked
        End If

        If chkNegrita.CheckState = CheckState.Checked Then
            chkNegrita.CheckState = CheckState.Unchecked
        End If

        txtTexto.Focus()
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnLim.Click
        txtTexto.Text = " "
        txtTexto.BackColor = Color.White
        txtTexto.ForeColor = Color.Black

        If chkMayuscula.CheckState = CheckState.Checked Then
            chkMayuscula.CheckState = CheckState.Unchecked
        End If

        If chkNegrita.CheckState = CheckState.Checked Then
            chkNegrita.CheckState = CheckState.Unchecked
        End If

        txtTexto.Focus()
    End Sub

    Private Sub btnRCambios_Click(sender As Object, e As EventArgs) Handles btnRCambios.Click
        If optFondoVerde.Checked = True Then
            txtTexto.BackColor = Color.DarkGreen
        ElseIf optFondoRojo.Checked = True Then
            txtTexto.BackColor = Color.DarkRed
        ElseIf optFondoAzul.Checked = True Then
            txtTexto.BackColor = Color.DarkBlue
        End If

        If optFuenteCyan.Checked = True Then
            txtTexto.BackColor = Color.DarkCyan
        ElseIf optFuenteMagenta.Checked = True Then
            txtTexto.BackColor = Color.DarkMagenta
        ElseIf optFuenteBlanco.Checked = True Then
            txtTexto.BackColor = Color.White
        End If

        If chkMayuscula.Checked = True Then
            txtTexto.Text = UCase(txtTexto.Text)
        Else
            txtTexto.Text = LCase(txtTexto.Text)
        End If

        If chkNegrita.Checked = True Then
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Bold)
        Else
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub btnSig_Click_1(sender As Object, e As EventArgs) Handles btnSig.Click
        Me.Hide()
        frm3.Show()
    End Sub
End Class