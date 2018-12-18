Public Class frmJob4
    Dim datNowDate As DateTime
    Dim dblYearSalar, dblBonus, dblAllIncome, dblAllowance, dblTax As Double

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Format(Now, "Long Date")
    End Sub

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Format(Now, "Short Date")
    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Const decR_Bonus As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07


        dblYearSalar = txtSalary.Text * 12
        dblBonus = dblYearSalar * decR_Bonus
        dblAllIncome = dblYearSalar + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = Val(dblAllIncome - dblAllowance) * decR_TAX

        lblYearSalary.Text = dblYearSalar
        lblBonus.Text = dblBonus
        lblAlllncome.Text = dblAllIncome
        lblAlllowance.Text = dblAllowance
        lblTax.Text = dblTax


    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToShortDateString
    End Sub
End Class