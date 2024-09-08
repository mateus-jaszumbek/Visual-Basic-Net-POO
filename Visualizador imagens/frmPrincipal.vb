Public Class frmPrincipal
    Private Sub btnSobre_Click(sender As Object, e As EventArgs) Handles btnSobre.Click
        frmSobre.ShowDialog()
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        frmSobre.Show()
    End Sub
End Class