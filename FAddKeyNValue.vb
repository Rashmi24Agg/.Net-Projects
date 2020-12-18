Public Class FAddKeyNValue

    Public dct As New Dictionary(Of Integer, String)

    Public Key As Integer

    Public Value As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Try
            Dim k As String = Text1.Text

            If Not IsNumeric(k) Then

                Throw New NotNaturalNumberException(" Please Enter Some natural number as Key.")

            Else

                Key = Convert.ToInt32(k)

                If dct.ContainsKey(Key) Then

                    Throw New DuplicateKeyException(" This key is already entered.Please enter a new key")

                End If

            End If

            Value = (Text2.Text)

            dct.Add(Key, Value)

            MessageBox.Show("Key Value pair added successfully.")

            BtnShow.Enabled = True

        Catch ex As NotNaturalNumberException

            MessageBox.Show(ex.Message(), "Numerical Error Message")

        Catch excpn As DuplicateKeyException

            MessageBox.Show(excpn.Message(), "Duplicate Key Error Message")

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnShow.Click

        Try
            If Not dct.Count = 0 Then

                Dim ElementsForm As New FShowItems(dct)

                'If ElementsForm Is Nothing Then

                'ElementsForm = New FShowElements(dct)
                ElementsForm.Show()

            Else

                Throw New NotNaturalNumberException(" Please Enter Some natural number as Key first.")

            End If

        Catch exp As NotNaturalNumberException

            MessageBox.Show(exp.Message(), "Numerical Error Message")

        End Try

    End Sub
    Public Class NotNaturalNumberException : Inherits System.ApplicationException

        Public Sub New(ByRef msg As String)

            MyBase.New(msg)

        End Sub

    End Class

    Public Class DuplicateKeyException : Inherits System.ApplicationException

        Public Sub New(ByRef msg As String)

            MyBase.New(msg)

        End Sub

    End Class

End Class