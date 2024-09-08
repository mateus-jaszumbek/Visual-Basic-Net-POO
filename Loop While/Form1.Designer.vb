<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnclick = New Button()
        lstdados = New ListBox()
        btnlimpa = New Button()
        btsemlimite = New Button()
        btnquatidade = New Button()
        txtnumeroinicial = New TextBox()
        txtnumerofinal = New TextBox()
        SuspendLayout()
        ' 
        ' btnclick
        ' 
        btnclick.Location = New Point(469, 35)
        btnclick.Name = "btnclick"
        btnclick.Size = New Size(127, 29)
        btnclick.TabIndex = 0
        btnclick.Text = "Até 5 numeros"
        btnclick.UseVisualStyleBackColor = True
        ' 
        ' lstdados
        ' 
        lstdados.FormattingEnabled = True
        lstdados.Location = New Point(22, 23)
        lstdados.Name = "lstdados"
        lstdados.Size = New Size(391, 224)
        lstdados.TabIndex = 1
        ' 
        ' btnlimpa
        ' 
        btnlimpa.Location = New Point(469, 124)
        btnlimpa.Name = "btnlimpa"
        btnlimpa.Size = New Size(127, 29)
        btnlimpa.TabIndex = 2
        btnlimpa.Text = "limpa"
        btnlimpa.UseVisualStyleBackColor = True
        ' 
        ' btsemlimite
        ' 
        btsemlimite.Location = New Point(469, 79)
        btsemlimite.Name = "btsemlimite"
        btsemlimite.Size = New Size(127, 29)
        btsemlimite.TabIndex = 3
        btsemlimite.Text = "Sem limite"
        btsemlimite.UseVisualStyleBackColor = True
        ' 
        ' btnquatidade
        ' 
        btnquatidade.Location = New Point(469, 172)
        btnquatidade.Name = "btnquatidade"
        btnquatidade.Size = New Size(163, 29)
        btnquatidade.TabIndex = 4
        btnquatidade.Text = "Quantidade abaixo"
        btnquatidade.UseVisualStyleBackColor = True
        ' 
        ' txtnumeroinicial
        ' 
        txtnumeroinicial.Location = New Point(441, 220)
        txtnumeroinicial.Name = "txtnumeroinicial"
        txtnumeroinicial.Size = New Size(89, 27)
        txtnumeroinicial.TabIndex = 5
        txtnumeroinicial.Text = "valor inicial"
        ' 
        ' txtnumerofinal
        ' 
        txtnumerofinal.Location = New Point(546, 220)
        txtnumerofinal.Name = "txtnumerofinal"
        txtnumerofinal.Size = New Size(86, 27)
        txtnumerofinal.TabIndex = 6
        txtnumerofinal.Text = "valor final"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 275)
        Controls.Add(txtnumerofinal)
        Controls.Add(txtnumeroinicial)
        Controls.Add(btnquatidade)
        Controls.Add(btsemlimite)
        Controls.Add(btnlimpa)
        Controls.Add(lstdados)
        Controls.Add(btnclick)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnclick As Button
    Friend WithEvents lstdados As ListBox
    Friend WithEvents btnlimpa As Button
    Friend WithEvents btsemlimite As Button
    Friend WithEvents btnquatidade As Button
    Friend WithEvents txtnumeroinicial As TextBox
    Friend WithEvents txtnumerofinal As TextBox

End Class
