Public Class Frm_Info
    Public meses As Integer
    Public interest_rate As Single
    Public final As Single

    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Frm_Carros.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles Btn_submit.Click
        Dim contador As Integer
        Dim dinero As Integer

        contador = 0
        dinero = 0
        Do
            contador = contador + 1
            dinero = (((Frm_Carros.precio * (interest_rate)) / meses))
            Frm_PagosMensuales.Lst_months.Items.Add("Month " & contador & " : " & Format(dinero, "$ ###,###,###.00"))

        Loop Until contador = meses
        final = Frm_Carros.precio * (interest_rate + 1)
        Frm_PagosMensuales.Lbl_totalprice.Text = Format(final, "$ ###,###,##0.00")
        Frm_PagosMensuales.Show()
        Me.Hide()
    End Sub



    Private Sub Rdo_1year_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_1year.CheckedChanged
        meses = 12
        interest_rate = 0.05
        Lbl_InterestRate.Text = interest_rate
    End Sub

    Private Sub Rdo_2year_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_2year.CheckedChanged
        meses = 24
        interest_rate = 0.07
        Lbl_InterestRate.Text = interest_rate
    End Sub

    Private Sub Rdo_3years_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_3years.CheckedChanged
        meses = 36
        interest_rate = 0.1
        Lbl_InterestRate.Text = interest_rate
    End Sub


End Class