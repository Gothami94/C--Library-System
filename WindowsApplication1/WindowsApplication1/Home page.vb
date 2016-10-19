Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb1.Click

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        lb1.Text = "Welcome to UCSC Library!"
        Dim frm2 As New Form2
        frm2.Show()
        Me.Hide()

    End Sub
End Class
