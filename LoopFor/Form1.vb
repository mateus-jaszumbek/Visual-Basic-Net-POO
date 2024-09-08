Public Class Form1
    Private Sub btnclick_Click(sender As Object, e As EventArgs) Handles btnclick.Click
        Dim intConta As Integer

        limpaLista()

        For intConta = 1 To 5
            lstDados.Items.Add("Eu sou o item" & intConta.ToString() & "na lista!!")
        Next

    End Sub

    Private Sub limpaLista()
        lstDados.Items.Clear()

    End Sub

    Private Sub btnlimpa_Click(sender As Object, e As EventArgs) Handles btnlimpa.Click
        lstDados.Items.Clear()
    End Sub
End Class
