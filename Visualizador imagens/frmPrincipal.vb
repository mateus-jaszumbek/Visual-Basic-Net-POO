Imports System.ComponentModel

Public Class frmPrincipal
    Private Sub btnSobre_Click(sender As Object, e As EventArgs) Handles btnSobre.Click
        frmSobre.ShowDialog()

        mnuConfirmeaoSair.Checked = g_boolConfirmaSair
        picImagem.BackColor = g_colorFundoPadrao
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        frmSobre.Show()
    End Sub

    Private Sub mnuAbrirImagem_Click(sender As Object, e As EventArgs) Handles mnuAbrirImagem.Click
        Dim strNomeArquivo As String = ""
        'Mostra  a caixa d dialogo
        If ofdSelecionaImagem.ShowDialog = DialogResult.OK Then
            Try
                'Carrega imagem no controle
                picImagem.Image = Image.FromFile(ofdSelecionaImagem.FileName)
                'Mostra nome od arquivo no titulo
                Me.Text = "Visualizador de imagens (" & ofdSelecionaImagem.FileName & ")"
            Catch ex As Exception
                MessageBox.Show("Imagem '" & ofdSelecionaImagem.FileName & "' não encontrada .")
                Exit Sub
            Finally
                strNomeArquivo = Application.StartupPath & "\image2.jpg"
            End Try

        Else
            'Define local da imagem caso não de certe
            strNomeArquivo = Application.StartupPath & "\image2.jpg"
        End If


    End Sub

    Private Sub mnuConfirmeaoSair_Click(sender As Object, e As EventArgs) Handles mnuConfirmeaoSair.Click
        mnuConfirmeaoSair.Checked = Not mnuConfirmeaoSair.Checked
        g_boolConfirmaSair = mnuConfirmeaoSair.Checked
    End Sub

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click
        Me.Close()
    End Sub

    Private Sub mnuSobre_Click(sender As Object, e As EventArgs) Handles mnuSobre.Click
        frmSobre.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If g_boolConfirmaSair Then
            If MessageBox.Show("Fechar o visualizado de imagens ?",
                               "Visualizador de imagens ", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True

            End If
        End If
    End Sub
End Class