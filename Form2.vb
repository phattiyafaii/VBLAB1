Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sales1 As Double
        Dim Sales2 As Double
        Dim SumSales As Double
        Dim Commission1 As Double
        Dim Commission2 As Double
        Dim SumCommission As Double

        Sales1 = txtSales1.Text
        Sales2 = txtSales2.Text
        SumSales = Sales1 + Sales2
        Commission1 = Sales1 * 0.05
        Commission2 = Sales2 * 0.1
        SumCommission = Commission1 + Commission2

        lblCom1.Text = Commission1
        lblCom2.Text = Commission2
        lblSumCom.Text = SumCommission
        lblSumSales.Text = SumSales
        lblSales1.Text = Sales1
        lblSales2.Text = Sales2


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class