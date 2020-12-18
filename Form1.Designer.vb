<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FChooseCollection
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
        Me.RadBtnDcnry = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'RadBtnDcnry
        '
        Me.RadBtnDcnry.AutoSize = True
        Me.RadBtnDcnry.Location = New System.Drawing.Point(56, 66)
        Me.RadBtnDcnry.Name = "RadBtnDcnry"
        Me.RadBtnDcnry.Size = New System.Drawing.Size(72, 17)
        Me.RadBtnDcnry.TabIndex = 0
        Me.RadBtnDcnry.Text = "Dictionary"
        Me.RadBtnDcnry.UseVisualStyleBackColor = True
        '
        'FChooseCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RadBtnDcnry)
        Me.Name = "FChooseCollection"
        Me.Text = "Choose Collection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadBtnDcnry As RadioButton
End Class
