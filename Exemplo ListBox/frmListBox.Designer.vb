<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstEstilosMusicais = New ListBox()
        btnadd = New Button()
        btnremove = New Button()
        btnlimpa = New Button()
        btnindex = New Button()
        cboCores = New ComboBox()
        SuspendLayout()
        ' 
        ' lstEstilosMusicais
        ' 
        lstEstilosMusicais.FormattingEnabled = True
        lstEstilosMusicais.Items.AddRange(New Object() {"Rock", "Funk", "Pop", "Classica", "Reaggea", "Fol", "Metal", "Country"})
        lstEstilosMusicais.Location = New Point(24, 102)
        lstEstilosMusicais.Name = "lstEstilosMusicais"
        lstEstilosMusicais.Size = New Size(219, 164)
        lstEstilosMusicais.TabIndex = 0
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(24, 289)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(104, 41)
        btnadd.TabIndex = 1
        btnadd.Text = "Adiciona"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnremove
        ' 
        btnremove.Location = New Point(149, 289)
        btnremove.Name = "btnremove"
        btnremove.Size = New Size(94, 41)
        btnremove.TabIndex = 2
        btnremove.Text = "Remove"
        btnremove.UseVisualStyleBackColor = True
        ' 
        ' btnlimpa
        ' 
        btnlimpa.Location = New Point(24, 336)
        btnlimpa.Name = "btnlimpa"
        btnlimpa.Size = New Size(104, 35)
        btnlimpa.TabIndex = 3
        btnlimpa.Text = "Limpa Estilos"
        btnlimpa.UseVisualStyleBackColor = True
        ' 
        ' btnindex
        ' 
        btnindex.Location = New Point(149, 342)
        btnindex.Name = "btnindex"
        btnindex.Size = New Size(94, 29)
        btnindex.TabIndex = 4
        btnindex.Text = "Mostrar Selecionado"
        btnindex.UseVisualStyleBackColor = True
        ' 
        ' cboCores
        ' 
        cboCores.AutoCompleteMode = AutoCompleteMode.Append
        cboCores.AutoCompleteSource = AutoCompleteSource.ListItems
        cboCores.FormattingEnabled = True
        cboCores.Items.AddRange(New Object() {"Preto", "Azul", "Dourado", "Verde", "Branco", "Vermelho", "Amarelo"})
        cboCores.Location = New Point(24, 42)
        cboCores.Name = "cboCores"
        cboCores.Size = New Size(219, 28)
        cboCores.TabIndex = 5
        ' 
        ' frmListBox
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(516, 450)
        Controls.Add(cboCores)
        Controls.Add(btnindex)
        Controls.Add(btnlimpa)
        Controls.Add(btnremove)
        Controls.Add(btnadd)
        Controls.Add(lstEstilosMusicais)
        Name = "frmListBox"
        Text = "Exemplo com ListBox"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstEstilosMusicais As ListBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnlimpa As Button
    Friend WithEvents btnindex As Button
    Friend WithEvents cboCores As ComboBox

End Class
