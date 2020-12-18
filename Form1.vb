Public Class FCalculator

    Dim FoundExp As Boolean = False     ' Becomes true when some expression is there 

    Dim TxtChanged As Boolean = False   ' True when 2nd no. is entered

    Dim count As Integer = 0            ' count the numbers being entered 

    Dim oprn As String = ""             ' stores mathematical operation character

    Dim exp As String = ""              ' stores whole expression as string

    Dim num1 As Double = 0              ' stores first input 

    Dim num2 As Double = 0

    'Handles Number  Buttons' click

    Private Sub Num_Click(sender As Object, e As EventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, Btn0.Click

        Dim b As Button = sender

        If FoundExp Or Text1.Text = "" Then

            Text1.Text = b.Text
            FoundExp = False
            exp += b.Text

        Else

            Text1.Text += b.Text
            exp += b.Text

        End If

    End Sub


    'handles mathematical operation

    Private Sub Oprn_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click, BtnMultiply.Click, BtnMinus.Click, BtnDivide.Click

        Dim b As Button = sender

        If num1 = 0 Then

            num1 = CDbl(Text1.Text)

        End If

        exp += b.Text

        BtnEquals.PerformClick()

        oprn = b.Text

        count = 1

        'LblPrblm.Text += " " + oprn

        FoundExp = True

    End Sub


    ' Configure TxtChange for second input

    Private Sub Text1_TextChanged(sender As Object, e As EventArgs) Handles Text1.TextChanged

        If count = 1 Then
            TxtChanged = True
        End If

    End Sub

    'perform operation on click of equals button

    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles BtnEquals.Click

        If oprn = "" Then Exit Sub

        'LblPrblm.Text += " " + Text1.Text
        If TxtChanged Then

            Dim c As Char

            For Each c In exp

                If c = "+" Or c = "-" Or c = "*" Or c = "/" Then
                    exp = exp.Replace(c, "")
                    Exit For
                Else
                    exp = exp.Replace(c, "")
                End If

            Next

            Select Case c

                Case "+"
                    Text1.Text = (num1 + CDbl(Text1.Text))

                Case "-"
                    Dim num As Double = (num1 - CDbl(Text1.Text))

                    If num < 0 Then
                        Text1.Text = CStr(Math.Abs(num)) + "-"
                    Else
                        Text1.Text = num
                    End If

                Case "/"

                    If Not CDbl(Text1.Text) = 0 Then

                        Text1.Text = (num1 / CDbl(Text1.Text))
                    Else
                        MessageBox.Show("Cannot Divide by Zero.")
                    End If

                Case "*"
                    Text1.Text = (num1 * CDbl(Text1.Text))

            End Select

            num1 = CDbl(Text1.Text)
            For Each c In exp
                Dim i As Integer = Asc(c)
                If i > 47 And i < 58 Then
                    exp = exp.Replace(c, "")
                End If
            Next
            exp = CStr(num1) + exp
            count = 0

            ' LblPrblm.Text = Text1.Text

        End If

    End Sub

    Private Sub BtnCut_Click(sender As Object, e As EventArgs) Handles BtnCut.Click

        If Not Text1.Text = "" Then
            Text1.Text = Text1.Text.Remove(Text1.Text.Length - 1, 1)

        Else
            MessageBox.Show("Please enter a no first.")

        End If

    End Sub
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BtnClear.Click, BtnCE.Click

        exp = ""
        Text1.Text = ""
        exp = ""
        count = 0
        TxtChanged = False
        FoundExp = False
        num1 = 0
        oprn = ""

    End Sub

    Private Sub BtnSquare_Click(sender As Object, e As EventArgs) Handles BtnSquare.Click

        If Not Text1.Text = "" Then

            num2 = Convert.ToDouble(Text1.Text)

            Text1.Text = num2 * num2
        Else
            MessageBox.Show("Please enter a no first.")

        End If


    End Sub

    Private Sub BtnSign_Click(sender As Object, e As EventArgs) Handles BtnSign.Click

        If Not Text1.Text = "" Then

            'Text1.Text = String.Concat(Text1.Text, "-")
            Text1.Text += "-"
        Else
            MessageBox.Show("Please enter a no first.")

        End If
    End Sub

    Private Sub BtnDot_Click_1(sender As Object, e As EventArgs) Handles BtnDot.Click
        If Not Text1.Text.Contains(".") Then
            Text1.Text += "."
        End If
    End Sub

    Private Sub BtnPercent_Click(sender As Object, e As EventArgs) Handles BtnPercent.Click

        If Not Text1.Text = "" Then

            Text1.Text = CStr(Convert.ToDouble(Text1.Text) / CDbl(100))

        Else
            MessageBox.Show("Please enter a no first.")

        End If

    End Sub

    Private Sub Btn1Upon_Click(sender As Object, e As EventArgs) Handles Btn1Upon.Click
        If Not Text1.Text = "" Then

            num2 = CDbl(Text1.Text)
            Text1.Text = (CDbl(1) / num2)

        Else
            MessageBox.Show("Please enter a no first.")

        End If
    End Sub

    Private Sub BtnSquareRoot_Click(sender As Object, e As EventArgs) Handles BtnSquareRoot.Click

        If Not Text1.Text = "" Then
            Text1.Text = Math.Sqrt(CDbl(Text1.Text))

        Else
            MessageBox.Show("Please enter a no first.")

        End If

    End Sub

    'Change color on mouse move and leave
    Private Sub Btn1Upon_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSign.MouseMove, BtnSquareRoot.MouseMove, BtnSquare.MouseMove, BtnPercent.MouseMove, BtnMultiply.MouseMove, BtnMinus.MouseMove, BtnDot.MouseMove, BtnDivide.MouseMove, BtnCut.MouseMove, BtnClear.MouseMove, BtnCE.MouseMove, BtnAdd.MouseMove, Btn9.MouseMove, Btn8.MouseMove, Btn7.MouseMove, Btn6.MouseMove, Btn5.MouseMove, Btn4.MouseMove, Btn3.MouseMove, Btn2.MouseMove, Btn1Upon.MouseMove, Btn1.MouseMove, Btn0.MouseMove

        sender.BackColor = SystemColors.ActiveCaption

    End Sub

    Private Sub Btn1Upon_MouseLeave_1(sender As Object, e As EventArgs) Handles BtnSign.MouseLeave, BtnDot.MouseLeave, Btn9.MouseLeave, Btn8.MouseLeave, Btn7.MouseLeave, Btn6.MouseLeave, Btn5.MouseLeave, Btn4.MouseLeave, Btn3.MouseLeave, Btn2.MouseLeave, Btn1.MouseLeave, Btn0.MouseLeave

        sender.BackColor = SystemColors.ButtonHighlight

    End Sub

    Private Sub Btn1Upon_MouseLeave_2(sender As Object, e As EventArgs) Handles BtnSquareRoot.MouseLeave, BtnSquare.MouseLeave, BtnPercent.MouseLeave, BtnDivide.MouseLeave, BtnCut.MouseLeave, BtnClear.MouseLeave, BtnCE.MouseLeave, Btn1Upon.MouseLeave

        sender.BackColor = SystemColors.Control

    End Sub

    Private Sub BtnAdd_MouseLeave(sender As Object, e As EventArgs) Handles BtnMultiply.MouseLeave, BtnMinus.MouseLeave, BtnAdd.MouseLeave

        sender.BackColor = SystemColors.Control

    End Sub


End Class
