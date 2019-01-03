Public Class frmJob6
    Dim total As Integer
    Private Sub chkCarForMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForMe.CheckedChanged

        If chkCarForMe.Checked Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Enabled = True
            lblPaidPrice.Text = total
        Else

            If MsgBox(" ต้องการยกเลิกการซื้อรถใช่หรือไม่ ", vbYesNo) = vbYes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkItemsAddl1.Checked = False
                chkItemsAddl2.Checked = False
                chkItemsAddl3.Checked = False
                chkItemsAddl4.Checked = False
                chkFreel1.Checked = False
                chkFreel2.Checked = False
                chkFreel3.Checked = False
                lblPaidPrice.Text = ""
            Else
                chkCarForMe.Checked = True

            End If
        End If


    End Sub

    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        lblPaidPrice.Enabled = False
        total = Val(lblSartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
        lblPaidPrice.Text = total


    End Sub

    Private Sub chkItemsAddl1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAddl1.CheckedChanged
        If chkItemsAddl1.Checked Then
            total = Val(lblItemsPricel1.Text) + Val(lblPaidPrice.Text)
            lblPaidPrice.Text = total
        Else
            total -= (lblItemsPricel1.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkItemsAddl2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAddl2.CheckedChanged
        If chkItemsAddl2.Checked Then
            total = Val(lblItemsPricel2.Text) + Val(lblPaidPrice.Text)
            lblPaidPrice.Text = total
        Else
            total -= (lblItemsPricel2.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkItemsAddl3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAddl3.CheckedChanged
        If chkItemsAddl3.Checked Then
            total = Val(lblItemsPricel3.Text) + Val(lblPaidPrice.Text)
            lblPaidPrice.Text = total
        Else
            total -= (lblItemsPricel3.Text)
            lblPaidPrice.Text = total
        End If
    End Sub


    Private Sub chkItemsAddl4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAddl4.CheckedChanged
        If chkItemsAddl4.Checked Then
            total = Val(lblItemsPricel4.Text) + Val(lblPaidPrice.Text)
            lblPaidPrice.Text = total
        Else
            total -= (lblItemsPricel4.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFreel1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreel1.CheckedChanged
        If chkFreel1.Checked Then
            total -= Val(lblFree1.Text)
            lblPaidPrice.Text = total
        Else
            total = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFreel2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreel2.CheckedChanged
        If chkFreel2.Checked Then
            total -= Val(lblFree2.Text)
            lblPaidPrice.Text = total
        Else
            total = Val(lblPaidPrice.Text) + Val(lblFree2.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFreel3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreel3.CheckedChanged
        If chkFreel3.Checked Then
            total -= Val(lblFree3.Text)
            lblPaidPrice.Text = total
        Else
            total = Val(lblPaidPrice.Text) + Val(lblFree3.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
End Class