﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        SuspendLayout()
        ' 
        ' btnSobre
        ' 
        btnSobre.Location = New Point(88, 44)
        btnSobre.Name = "btnSobre"
        btnSobre.Size = New Size(122, 62)
        btnSobre.TabIndex = 0
        btnSobre.Text = "Abrir Modal"
        btnSobre.UseVisualStyleBackColor = True
        ' 
        ' btnshow
        ' 
        btnshow.Location = New Point(88, 141)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(122, 62)
        btnshow.TabIndex = 1
        btnshow.Text = "Abrir Show"
        btnshow.UseVisualStyleBackColor = True
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(311, 249)
        Controls.Add(btnshow)
        Controls.Add(btnSobre)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmPrincipal"
        Text = "frmPrincipal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSobre As Button
    Friend WithEvents btnshow As Button
End Class
