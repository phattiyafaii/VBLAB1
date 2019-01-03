Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Double

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        gpdPaid.Enabled = False
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        gpdPaid.Enabled = True
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        gpdPaid.Enabled = True
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalculate_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim r1 As String = txtProduct.Text
        Dim r2 As Integer = Val(txtPrice.Text)
        Dim r3 As Integer = Val(txtUnit.Text)
        If r1 = "" Or r2 <= 0 Or r3 = 0 Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked And radPaid.Checked Then
                If lblTotal.Text < 1000 Then
                    decDiscount = 0
                    lblDiscount.Text = Val(lblTotal.Text * decDiscount)
                ElseIf lblTotal.Text < 5000 Then
                    decDiscount = 0.05
                    lblDiscount.Text = Val(lblTotal.Text * decDiscount)
                ElseIf lblTotal.Text < 10000 Then
                    decDiscount = 0.1
                    lblDiscount.Text = Val(lblTotal.Text * decDiscount)
                ElseIf lblTotal.Text >= 10000 Then
                    decDiscount = 0.15
                    lblDiscount.Text = Val(lblTotal.Text * decDiscount)
                End If
                lblPaid.Text = Val(lblTotal.Text) - Val(lblTotal.Text * decDiscount)
                lblCredit.Text = 0
            ElseIf radMember.Checked And radCredit.Checked Or radOther.Checked Then
                decDiscount = 0
                lblDiscount.Text = 0
                lblPaid.Text = lblTotal.Text
                lblCredit.Text = lblPaid.Text

            End If
        End If
    End Sub

    Private Sub frmLab5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        gpdPaid.Enabled = True
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""



    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal

    End Sub
End Class