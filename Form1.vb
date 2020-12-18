Public Class FChooseCollection

    Dim AddForm As FAddKeyNValue

    Public Sub New()


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' RadBtnDcnry.AutoCheck = True

    End Sub

    Private Sub RadBtnDcnry_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnDcnry.CheckedChanged

        'RadBtnDcnry.AutoCheck = True

        If RadBtnDcnry.Checked Then

            AddForm = New FAddKeyNValue()

            AddForm.Show()

            RadBtnDcnry.Checked = False
        End If
    End Sub
End Class

