Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCuentas.Click
        Form2.Show()
    End Sub

    Private Sub BtnTabla_Click(sender As Object, e As EventArgs) Handles BtnTabla.Click
        Form3.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class
