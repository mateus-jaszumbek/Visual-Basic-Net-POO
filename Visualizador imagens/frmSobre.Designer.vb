<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSobre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSobre))
        lblNomeUsuario = New Label()
        txtnome = New TextBox()
        btnok = New Button()
        btncancela = New Button()
        chkMessage = New CheckBox()
        grpCorFundoPadrao = New GroupBox()
        optCorDeFundoBranca = New RadioButton()
        optCorDeFundoPadrao = New RadioButton()
        grpCorFundoPadrao.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNomeUsuario
        ' 
        lblNomeUsuario.AutoSize = True
        lblNomeUsuario.ForeColor = SystemColors.ControlLightLight
        lblNomeUsuario.Location = New Point(21, 36)
        lblNomeUsuario.Name = "lblNomeUsuario"
        lblNomeUsuario.Size = New Size(129, 20)
        lblNomeUsuario.TabIndex = 0
        lblNomeUsuario.Text = "Nome do Usuário:"
        ' 
        ' txtnome
        ' 
        txtnome.Location = New Point(169, 33)
        txtnome.Name = "txtnome"
        txtnome.Size = New Size(256, 27)
        txtnome.TabIndex = 1
        txtnome.Text = " "
        ' 
        ' btnok
        ' 
        btnok.Location = New Point(455, 28)
        btnok.Name = "btnok"
        btnok.Size = New Size(94, 32)
        btnok.TabIndex = 2
        btnok.Text = "Ok"
        btnok.UseVisualStyleBackColor = True
        ' 
        ' btncancela
        ' 
        btncancela.Location = New Point(455, 77)
        btncancela.Name = "btncancela"
        btncancela.Size = New Size(94, 36)
        btncancela.TabIndex = 3
        btncancela.Text = "Cancela"
        btncancela.UseVisualStyleBackColor = True
        ' 
        ' chkMessage
        ' 
        chkMessage.AutoSize = True
        chkMessage.BackColor = SystemColors.GradientActiveCaption
        chkMessage.Location = New Point(21, 80)
        chkMessage.Name = "chkMessage"
        chkMessage.Size = New Size(208, 24)
        chkMessage.TabIndex = 4
        chkMessage.Text = "Mostrar mensagens ao sair"
        chkMessage.UseVisualStyleBackColor = False
        ' 
        ' grpCorFundoPadrao
        ' 
        grpCorFundoPadrao.BackColor = SystemColors.InactiveBorder
        grpCorFundoPadrao.Controls.Add(optCorDeFundoBranca)
        grpCorFundoPadrao.Controls.Add(optCorDeFundoPadrao)
        grpCorFundoPadrao.Location = New Point(169, 133)
        grpCorFundoPadrao.Name = "grpCorFundoPadrao"
        grpCorFundoPadrao.Size = New Size(256, 85)
        grpCorFundoPadrao.TabIndex = 5
        grpCorFundoPadrao.TabStop = False
        grpCorFundoPadrao.Text = "Cor de Fundo Padrão"
        ' 
        ' optCorDeFundoBranca
        ' 
        optCorDeFundoBranca.AutoSize = True
        optCorDeFundoBranca.Checked = True
        optCorDeFundoBranca.Location = New Point(16, 50)
        optCorDeFundoBranca.Name = "optCorDeFundoBranca"
        optCorDeFundoBranca.Size = New Size(102, 24)
        optCorDeFundoBranca.TabIndex = 1
        optCorDeFundoBranca.TabStop = True
        optCorDeFundoBranca.Text = "Cor Branca"
        optCorDeFundoBranca.UseVisualStyleBackColor = True
        ' 
        ' optCorDeFundoPadrao
        ' 
        optCorDeFundoPadrao.AutoSize = True
        optCorDeFundoPadrao.Location = New Point(17, 26)
        optCorDeFundoPadrao.Name = "optCorDeFundoPadrao"
        optCorDeFundoPadrao.Size = New Size(143, 24)
        optCorDeFundoPadrao.TabIndex = 0
        optCorDeFundoPadrao.Text = "Cor Cinza Padrão"
        optCorDeFundoPadrao.UseVisualStyleBackColor = True
        ' 
        ' frmSobre
        ' 
        AcceptButton = btnok
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        CancelButton = btncancela
        ClientSize = New Size(593, 616)
        Controls.Add(grpCorFundoPadrao)
        Controls.Add(chkMessage)
        Controls.Add(btncancela)
        Controls.Add(btnok)
        Controls.Add(txtnome)
        Controls.Add(lblNomeUsuario)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSobre"
        Text = " "
        grpCorFundoPadrao.ResumeLayout(False)
        grpCorFundoPadrao.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNomeUsuario As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents btnok As Button
    Friend WithEvents btncancela As Button
    Friend WithEvents chkMessage As CheckBox
    Friend WithEvents grpCorFundoPadrao As GroupBox
    Friend WithEvents optCorDeFundoBranca As RadioButton
    Friend WithEvents optCorDeFundoPadrao As RadioButton
End Class
