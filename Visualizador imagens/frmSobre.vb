Public Class frmSobre
    Private Sub frmSobre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.Close()
    End Sub

    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        Me.Close()
    End Sub

End Class