Public Class frm1
    Private Sub btnID_Click(sender As Object, e As EventArgs) Handles btnID.Click
        Dim nombre As String = Nothing
        nombre = InputBox("Ingrese Nombre", "Registro de Datos Personales", "", 100, 50)
        If nombre IsNot "" Then
            MsgBox("Bienvenido Usuario: " + nombre, MsgBoxStyle.OkOnly, "Registro de Datos")
        End If
    End Sub

    Private Sub btnTer_Click(sender As Object, e As EventArgs) Handles btnTer.Click
        Dim opcion As DialogResult
        opcion = MsgBox("¿Realmente desea salir?", vbYesNo + vbQuestion, "Salir del programa")
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class