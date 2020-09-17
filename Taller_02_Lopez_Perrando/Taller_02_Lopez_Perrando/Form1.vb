Public Class frmPP

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click

        Dim nombre As String = Nothing

        nombre = InputBox("Ingrese Nombre", "Registro de Datos Personales", "", 100, 50)

        If nombre IsNot "" Then
            MsgBox("Bienvenido Usuario: " + nombre, MsgBoxStyle.OkOnly, "Registro de Datos")
        End If

    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Dim opcion As DialogResult
        opcion = MsgBox("¿Realmente desea salir?", vbYesNo + vbQuestion, "Salir del programa")
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
