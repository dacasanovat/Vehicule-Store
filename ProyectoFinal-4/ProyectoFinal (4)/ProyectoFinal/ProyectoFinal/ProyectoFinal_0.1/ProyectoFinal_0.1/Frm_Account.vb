Public Class Frm_Account

    Public aleatorio As Integer

    Private Sub Btn_buy_Click(sender As Object, e As EventArgs) Handles Btn_buy.Click
        Me.Hide()
        Frm_Carros.Show()

        aleatorio = 0 + Fix(Rnd() * 2)

        If aleatorio = 0 Then
            Video.Show()
        Else
            Video_2.Show()
        End If

    End Sub

    Private Sub Frm_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 5000
        Timer1.Start()

        pic_audi.Visible = True
        pic_ibiza.Visible = False
        Pic_jaguar.Visible = False
        Pic_mustang.Visible = False
        Pic_telsa.Visible = False
        Lbl_AudiTT.Visible = True
        Lbl_Ibiza.Visible = False
        lbl_jaguar.Visible = False
        Lbl_camaro.Visible = False
        lbl_masseratti.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        pic_audi.Visible = False
        pic_ibiza.Visible = True
        Lbl_AudiTT.Visible = False
        Lbl_Ibiza.Visible = True

        Timer2.Interval = 5000
        Timer2.Start()
        Timer1.Stop()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        pic_ibiza.Visible = False
        Pic_jaguar.Visible = True
        Lbl_Ibiza.Visible = False
        lbl_jaguar.Visible = True

        Timer3.Interval = 5000
        Timer3.Start()
        Timer2.Stop()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Pic_jaguar.Visible = False
        Pic_mustang.Visible = True
        lbl_jaguar.Visible = False
        Lbl_camaro.Visible = True

        Timer4.Interval = 5000
        Timer4.Start()
        Timer3.Stop()

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Pic_mustang.Visible = False
        Pic_telsa.Visible = True
        Lbl_camaro.Visible = False
        lbl_masseratti.Visible = True

        Timer5.Interval = 5000
        Timer5.Start()
        Timer4.Stop()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer1.Interval = 5000
        Timer1.Start()

        pic_audi.Visible = True
        pic_ibiza.Visible = False
        Pic_jaguar.Visible = False
        Pic_mustang.Visible = False
        Pic_telsa.Visible = False
        Lbl_AudiTT.Visible = True
        Lbl_Ibiza.Visible = False
        lbl_jaguar.Visible = False
        Lbl_camaro.Visible = False
        lbl_masseratti.Visible = False

        Timer5.Stop()

    End Sub


    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Frm_Hello.Show()
        Me.Hide()
    End Sub


    Private Sub btn_delivery_Click(sender As Object, e As EventArgs) Handles btn_delivery.Click
        Frm_carrito.Show()
        Dim QueryString As String
        Dim numero As Integer

        Frm_Password.Conectarse()

        QueryString = "SELECT Carro, Fecha FROM Compras WHERE  Username = '" & Frm_Hello.username & "'"

        Dim da As New OleDb.OleDbDataAdapter(QueryString, Frm_Password.myConnection)
        Dim dt As New DataTable
        da.Fill(dt)

        numero = dt.Rows.Count

        Frm_carrito.DataGridView1.DataSource = dt

        Frm_Password.myConnection.Close()

    End Sub

End Class