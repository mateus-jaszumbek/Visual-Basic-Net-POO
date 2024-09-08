Public Class frmListBox

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim intIndex As Integer
        intIndex = lstEstilosMusicais.Items.Add("Metal")
    End Sub

    Private Sub btnremove_click(sender As Object, e As EventArgs) Handles btnremove.Click
        lstEstilosMusicais.Items.RemoveAt(0)
    End Sub

    Private Sub btnlimpa_click(sender As Object, e As EventArgs) Handles btnlimpa.Click
        lstEstilosMusicais.Items.Clear()
    End Sub

    Private Sub btnindex_click(sender As Object, e As EventArgs) Handles btnindex.Click
        MessageBox.Show("Voce selecionou " & lstEstilosMusicais.SelectedItem & ", que tem o seguinte index " & lstEstilosMusicais.SelectedIndex)
    End Sub

End Class
