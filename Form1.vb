Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lbl1.Text = Val(txtSalary.Text * 12)
        lbl2.Text = Val(lbl1.Text * 0.05)
        lbl3.Text = Val(lbl1.Text - lbl2.Text)


    End Sub
End Class
