Public Class FShowItems

    Public dct As New Dictionary(Of Integer, String)

    Public Sub New(ByRef dct As Dictionary(Of Integer, String))

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dct = dct

    End Sub

    Private Sub FShowItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will populate the dictionary (dct) in checkedlistbox and combobox.

        For i As Integer = 0 To dct.Count - 1

            If Not ComBox.Items.Contains(dct.ElementAt(i).Value) Then

                ComBox.Items.Add(dct.ElementAt(i).Value)


            End If

            CheckedListBox.Items.Add(dct.ElementAt(i))

        Next
        If Not dct.Count = 0 Then

            ComBox.SelectedIndex = 0
        End If
        If ComBox.SelectedItem IsNot Nothing Or Not ComBox.Text = "" Then

            BtnDelete.Enabled = True

        End If


    End Sub

    'Remove(s) the selected items from the combobox and that ones from the checkedboxlist having same value.   
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Dim i As Integer

        For i = 0 To dct.Count - 1
            If ComBox.SelectedItem.Equals(CheckedListBox.Items.Item(i).Value) Or ComBox.Text.Equals(CheckedListBox.Items.Item(i).Value) Then

                dct.Remove(CheckedListBox.Items.Item(i).Key)
                'CheckedListBox.Items.RemoveAt(i)

            End If

        Next

        ComBox.Items.Remove(ComBox.SelectedItem)
        ComBox.Text = ""

        'MessageBox.Show("Item(s) deleted Succesfully.")

        CheckedListBox.Items.Clear()

        For Each item As KeyValuePair(Of Integer, String) In dct

            CheckedListBox.Items.Add(item)

        Next

        If Not ComBox.Items.Count = 0 Then

            ComBox.SelectedIndex = 0

        End If
        If Not ComBox.Text = "" Then

            BtnDelete.Enabled = True

        Else

            BtnDelete.Enabled = False

        End If
    End Sub

    Private Sub ComBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBox.SelectedIndexChanged

        If ComBox.SelectedItem IsNot Nothing Or Not ComBox.Text = "" Then

            BtnDelete.Enabled = True

        End If
    End Sub
End Class