Public Class Form1
    Private Sub btnclick_Click(sender As Object, e As EventArgs) Handles btnclick.Click
        Dim intConta = 0

        LimpaLista()

        Do While intConta <= 5
            lstdados.Items.Add(intConta.ToString)
            intConta += 1
        Loop
    End Sub
    Public Sub LimpaLista()
        lstdados.Items.Clear()
    End Sub

    Private Sub btsemlimite_Click(sender As Object, e As EventArgs) Handles btsemlimite.Click
        Dim intnumero As Integer = 0

        Do While intnumero <= 5
            lstdados.Items.Add(intnumero.ToString())
            intnumero += 1
        Loop
    End Sub

    Private Sub btnlimpa_Click(sender As Object, e As EventArgs) Handles btnlimpa.Click
        LimpaLista()
    End Sub

    Private Sub btnquatidade_Click(sender As Object, e As EventArgs) Handles btnquatidade.Click
        LimpaLista()

        Dim intnicial As Integer = 0
        Dim intfinal As Integer = 0

        Try
            intnicial = txtnumeroinicial.Text
            intfinal = txtnumerofinal.Text

            If intnicial > intfinal Then
                MessageBox.Show("numero inicial não pode ser maior que o numero final")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("Dado inserido invalido ao solicidado")
            Exit Sub
        End Try

        Do While intnicial <= intfinal
            lstdados.Items.Add(intnicial.ToString())
            intnicial += 1
        Loop

    End Sub
End Class
