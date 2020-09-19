Public Class frmPP
    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        txtIns.Visible = True
        lblIns.Visible = True
        lblUTP.Visible = False
        lblFISC.Visible = False
        btnRegPP.Visible = True
        btnIns.Visible = False
    End Sub

    Private Sub btnRegPP_Click(sender As Object, e As EventArgs) Handles btnRegPP.Click
        txtIns.Visible = False
        lblIns.Visible = False
        lblUTP.Visible = True
        lblFISC.Visible = True
        btnRegPP.Visible = False
        btnIns.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        frm1.Show()
        Me.Hide()
    End Sub
End Class
