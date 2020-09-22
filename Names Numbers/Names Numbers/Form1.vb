Public Class Form1

    Dim Number As String


    Private Sub rtbIn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbIn.TextChanged, cbGroupsToWords.CheckedChanged, txtGroupsToShow.TextChanged

        rtbOut.Clear()

        Dim Number As String = rtbIn.Text
        Dim GroupToWords As Boolean = cbGroupsToWords.Checked

        lblNumberLength.Text = "Number has " & rtbIn.TextLength & " digits."

        'Don't allow an int32 overflow
        If Val(txtGroupsToShow.Text) > 9999 Then
            txtGroupsToShow.Text = 9999
        End If

        Dim ShowGroups As Int32 = Val(txtGroupsToShow.Text)

        rtbOut.AppendText(NameOfNumber(Number, GroupToWords, ShowGroups))

    End Sub

End Class
