<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FShowItems
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
        Me.ComBox = New System.Windows.Forms.ComboBox()
        Me.CheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComBox
        '
        Me.ComBox.FormattingEnabled = True
        Me.ComBox.Location = New System.Drawing.Point(12, 45)
        Me.ComBox.Name = "ComBox"
        Me.ComBox.Size = New System.Drawing.Size(114, 21)
        Me.ComBox.TabIndex = 0
        '
        'CheckedListBox
        '
        Me.CheckedListBox.FormattingEnabled = True
        Me.CheckedListBox.Location = New System.Drawing.Point(141, 45)
        Me.CheckedListBox.Name = "CheckedListBox"
        Me.CheckedListBox.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox.TabIndex = 1
        '
        'BtnDelete
        '
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.Location = New System.Drawing.Point(89, 182)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FShowItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.CheckedListBox)
        Me.Controls.Add(Me.ComBox)
        Me.Name = "FShowItems"
        Me.Text = "Items"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComBox As ComboBox
    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents BtnDelete As Button
End Class
