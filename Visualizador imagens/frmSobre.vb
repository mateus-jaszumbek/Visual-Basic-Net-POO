Public Class frmSobre
    Private Sub frmSobre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon

        txtnome.Text = g_strNomeUsuario
        chkMessage.Checked = g_boolConfirmaSair

        If g_colorFundoPadrao = Color.White Then
            optCorDeFundoBranca.Checked = True
        Else
            optCorDeFundoPadrao.Checked = True

        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.Close()
    End Sub

    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        Me.Close()
    End Sub

    Private Sub frmSobre_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        g_strNomeUsuario = txtnome.Text
        g_boolConfirmaSair = chkMessage.Checked

        If optCorDeFundoBranca.Checked Then
            g_colorFundoPadrao = Color.White
        Else
            g_colorFundoPadrao = SystemColors.Control
        End If
    End Sub
End Class