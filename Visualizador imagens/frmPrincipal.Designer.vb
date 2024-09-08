<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        btnSobre = New Button()
        btnshow = New Button()
        mnuPrincipal = New MenuStrip()
        ArquivoToolStripMenuItem = New ToolStripMenuItem()
        mnuAbrirImagem = New ToolStripMenuItem()
        mnuConfirmeaoSair = New ToolStripMenuItem()
        mnuSair = New ToolStripMenuItem()
        AjudaToolStripMenuItem = New ToolStripMenuItem()
        mnuSobre = New ToolStripMenuItem()
        picImagem = New PictureBox()
        ofdSelecionaImagem = New OpenFileDialog()
        mnuPrincipal.SuspendLayout()
        CType(picImagem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSobre
        ' 
        btnSobre.Location = New Point(465, 53)
        btnSobre.Name = "btnSobre"
        btnSobre.Size = New Size(122, 62)
        btnSobre.TabIndex = 0
        btnSobre.Text = "Abrir Modal"
        btnSobre.UseVisualStyleBackColor = True
        ' 
        ' btnshow
        ' 
        btnshow.Location = New Point(465, 140)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(122, 62)
        btnshow.TabIndex = 1
        btnshow.Text = "Abrir Show"
        btnshow.UseVisualStyleBackColor = True
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.ImageScalingSize = New Size(20, 20)
        mnuPrincipal.Items.AddRange(New ToolStripItem() {ArquivoToolStripMenuItem, AjudaToolStripMenuItem})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(656, 28)
        mnuPrincipal.TabIndex = 2
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' ArquivoToolStripMenuItem
        ' 
        ArquivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAbrirImagem, mnuConfirmeaoSair, mnuSair})
        ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        ArquivoToolStripMenuItem.Size = New Size(75, 24)
        ArquivoToolStripMenuItem.Text = "&Arquivo"
        ' 
        ' mnuAbrirImagem
        ' 
        mnuAbrirImagem.Name = "mnuAbrirImagem"
        mnuAbrirImagem.Size = New Size(224, 26)
        mnuAbrirImagem.Text = "&Abrir Imagem"
        ' 
        ' mnuConfirmeaoSair
        ' 
        mnuConfirmeaoSair.Name = "mnuConfirmeaoSair"
        mnuConfirmeaoSair.Size = New Size(224, 26)
        mnuConfirmeaoSair.Text = "&Confirme ao Sair"
        ' 
        ' mnuSair
        ' 
        mnuSair.Name = "mnuSair"
        mnuSair.Size = New Size(224, 26)
        mnuSair.Text = "&Sair"
        ' 
        ' AjudaToolStripMenuItem
        ' 
        AjudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuSobre})
        AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        AjudaToolStripMenuItem.Size = New Size(62, 24)
        AjudaToolStripMenuItem.Text = "A&juda"
        ' 
        ' mnuSobre
        ' 
        mnuSobre.Name = "mnuSobre"
        mnuSobre.Size = New Size(224, 26)
        mnuSobre.Text = "&Sobre"
        ' 
        ' picImagem
        ' 
        picImagem.Location = New Point(18, 53)
        picImagem.Name = "picImagem"
        picImagem.Size = New Size(375, 310)
        picImagem.TabIndex = 3
        picImagem.TabStop = False
        ' 
        ' ofdSelecionaImagem
        ' 
        ofdSelecionaImagem.Filter = "Windows Bitmaps|*.BMP|JPEG Files|*.JPG"
        ofdSelecionaImagem.Title = "Selecione uma Imagem"
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(656, 388)
        Controls.Add(picImagem)
        Controls.Add(btnshow)
        Controls.Add(btnSobre)
        Controls.Add(mnuPrincipal)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = mnuPrincipal
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmPrincipal"
        Text = "frmPrincipal"
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        CType(picImagem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSobre As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbrirImagem As ToolStripMenuItem
    Friend WithEvents mnuSair As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSobre As ToolStripMenuItem
    Friend WithEvents mnuConfirmeaoSair As ToolStripMenuItem
    Friend WithEvents picImagem As PictureBox
    Friend WithEvents ofdSelecionaImagem As OpenFileDialog
End Class
