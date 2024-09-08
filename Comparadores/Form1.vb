Public Class Form1
    Private Sub btnnome_Click(sender As Object, e As EventArgs) Handles btnnome.Click
        Dim nome = ""
        nome = txtnome.Text

        If nome.Length > 10 Then
            MessageBox.Show("Nome excedido o limite")
            Exit Sub

        ElseIf nome <> "" Then
            MessageBox.Show("Bem vindo '" & nome & "', como posso ajudar ?")
        End If

    End Sub

    Private Sub btnclick2_Click(sender As Object, e As EventArgs) Handles btnclick2.Click
        Dim intnumero As Integer = 0
        Try
            intnumero = txttextoint.Text
        Catch ex As Exception
            MessageBox.Show("valor inserido é invalido")
            Exit Sub
        End Try

        If intnumero < 27 Then
            MessageBox.Show("Int numero é menor que 27, valor digitado foi " & intnumero & "")
        Else
            MessageBox.Show("Int numero é Maior que 27, valor digitado foi " & intnumero & "")
        End If

    End Sub
End Class
