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
        lstDados = New ListBox()
        btnlimpa = New Button()
        SuspendLayout()
        ' 
        ' btnclick
        ' 
        btnclick.Location = New Point(426, 22)
        btnclick.Name = "btnclick"
        btnclick.Size = New Size(94, 39)
        btnclick.TabIndex = 0
        btnclick.Text = "click"
        btnclick.UseVisualStyleBackColor = True
        ' 
        ' lstDados
        ' 
        lstDados.FormattingEnabled = True
        lstDados.Location = New Point(37, 22)
        lstDados.Name = "lstDados"
        lstDados.Size = New Size(326, 364)
        lstDados.TabIndex = 1
        ' 
        ' btnlimpa
        ' 
        btnlimpa.Location = New Point(426, 99)
        btnlimpa.Name = "btnlimpa"
        btnlimpa.Size = New Size(94, 39)
        btnlimpa.TabIndex = 2
        btnlimpa.Text = "click"
        btnlimpa.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(550, 450)
        Controls.Add(btnlimpa)
        Controls.Add(lstDados)
        Controls.Add(btnclick)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnclick As Button
    Friend WithEvents lstDados As ListBox
    Friend WithEvents btnlimpa As Button

End Class
