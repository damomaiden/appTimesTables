Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumbers() As Integer
        Dim intMultiply As Integer
        Dim intStart As Integer
        Dim intEnd As Integer



        lboDisplay.Items.Clear()

        intMultiply = Val(txtNumber.Text)
        intEnd = Val(txtEnd.Text)
        intStart = Val(txtStart.Text)

        'Re dimensioning, giving a vairable a different tsize
        ReDim intNumbers(intEnd)

        For i = intStart To intEnd
            intNumbers(i) = i * intMultiply
            lboDisplay.Items.Add(intMultiply.ToString & " Times " & i & " = " & intNumbers(i))
        Next




    End Sub
End Class
