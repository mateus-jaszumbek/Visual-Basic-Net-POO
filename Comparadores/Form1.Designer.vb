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
        btnnome = New Button()
        txtnome = New TextBox()
        txttextoint = New TextBox()
        btnclick2 = New Button()
        SuspendLayout()
        ' 
        ' btnnome
        ' 
        btnnome.Location = New Point(130, 75)
        btnnome.Name = "btnnome"
        btnnome.Size = New Size(118, 29)
        btnnome.TabIndex = 0
        btnnome.Text = "click"
        btnnome.TextAlign = ContentAlignment.TopCenter
        btnnome.UseVisualStyleBackColor = True
        ' 
        ' txtnome
        ' 
        txtnome.Location = New Point(130, 28)
        txtnome.Name = "txtnome"
        txtnome.Size = New Size(337, 27)
        txtnome.TabIndex = 1
        ' 
        ' txttextoint
        ' 
        txttextoint.Location = New Point(130, 153)
        txttextoint.Name = "txttextoint"
        txttextoint.Size = New Size(337, 27)
        txttextoint.TabIndex = 3
        ' 
        ' btnclick2
        ' 
        btnclick2.Location = New Point(130, 200)
        btnclick2.Name = "btnclick2"
        btnclick2.Size = New Size(118, 29)
        btnclick2.TabIndex = 2
        btnclick2.Text = "click"
        btnclick2.TextAlign = ContentAlignment.TopCenter
        btnclick2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 392)
        Controls.Add(txttextoint)
        Controls.Add(btnclick2)
        Controls.Add(txtnome)
        Controls.Add(btnnome)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnnome As Button
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txttextoint As TextBox
    Friend WithEvents btnclick2 As Button

End Class
