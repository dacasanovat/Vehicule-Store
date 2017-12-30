Public Class Frm_Carros
    Public precio As Integer
    Public nombre As String

    Private Sub Btn_Fiesta_Click(sender As Object, e As EventArgs) Handles Btn_Fiesta.Click
        nombre = "Ford Fiesta"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Ford_Fiesta.Visible = True
        Frm_Info.Jaguar_Ftype.Visible = False
        Frm_Info.Honda_Fit.Visible = False
        Frm_Info.Audi_TT.Visible = False
        Frm_Info.Seat_Ibiza.Visible = False
        Frm_Info.Chevy_Camaro.Visible = False
        Frm_Info.Ford_Mustang.Visible = False
        Frm_Info.Tesla_ModelS.Visible = False
        Frm_Info.Masseratti_Ghibli.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = True
        Frm_PagosMensuales.Jaguar_Ftype.Visible = False
        Frm_PagosMensuales.Honda_Fit.Visible = False
        Frm_PagosMensuales.Audi_TT.Visible = False
        Frm_PagosMensuales.Seat_Ibiza.Visible = False
        Frm_PagosMensuales.Chevy_Camaro.Visible = False
        Frm_PagosMensuales.Ford_Mustang.Visible = False
        Frm_PagosMensuales.Tesla_ModelS.Visible = False
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = False

        Frm_Info.Show()
        Me.Hide()

        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'fiesta'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")

    End Sub

    Private Sub Btn_Fit_Click(sender As Object, e As EventArgs) Handles Btn_Fit.Click
        nombre = "Honda Fit"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Honda_Fit.Visible = True
        Frm_Info.Jaguar_Ftype.Visible = False
        Frm_Info.Audi_TT.Visible = False
        Frm_Info.Ford_Fiesta.Visible = False
        Frm_Info.Seat_Ibiza.Visible = False
        Frm_Info.Chevy_Camaro.Visible = False
        Frm_Info.Ford_Mustang.Visible = False
        Frm_Info.Tesla_ModelS.Visible = False
        Frm_Info.Masseratti_Ghibli.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = False
        Frm_PagosMensuales.Jaguar_Ftype.Visible = False
        Frm_PagosMensuales.Honda_Fit.Visible = True
        Frm_PagosMensuales.Audi_TT.Visible = False
        Frm_PagosMensuales.Seat_Ibiza.Visible = False
        Frm_PagosMensuales.Chevy_Camaro.Visible = False
        Frm_PagosMensuales.Ford_Mustang.Visible = False
        Frm_PagosMensuales.Tesla_ModelS.Visible = False
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = False

        Frm_Info.Show()
        Me.Hide()

        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'fit'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")

    End Sub

    Private Sub Btn_Ibiza_Click(sender As Object, e As EventArgs) Handles Btn_Ibiza.Click
        nombre = "Seat Ibiza"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Seat_Ibiza.Visible = True
        Frm_Info.Jaguar_Ftype.Visible = False
        Frm_Info.Honda_Fit.Visible = False
        Frm_Info.Audi_TT.Visible = False
        Frm_Info.Ford_Fiesta.Visible = False
        Frm_Info.Chevy_Camaro.Visible = False
        Frm_Info.Ford_Mustang.Visible = False
        Frm_Info.Tesla_ModelS.Visible = False
        Frm_Info.Masseratti_Ghibli.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = False
        Frm_PagosMensuales.Jaguar_Ftype.Visible = False
        Frm_PagosMensuales.Honda_Fit.Visible = False
        Frm_PagosMensuales.Audi_TT.Visible = False
        Frm_PagosMensuales.Seat_Ibiza.Visible = True
        Frm_PagosMensuales.Chevy_Camaro.Visible = False
        Frm_PagosMensuales.Ford_Mustang.Visible = False
        Frm_PagosMensuales.Tesla_ModelS.Visible = False
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = False

        Frm_Info.Show()
        Me.Hide()

        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'ibiza'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")
    End Sub

    Private Sub Btn_Camaro_Click(sender As Object, e As EventArgs) Handles Btn_Camaro.Click
        nombre = "Chevy Camaro"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Chevy_Camaro.Visible = True
        Frm_Info.Jaguar_Ftype.Visible = False
        Frm_Info.Honda_Fit.Visible = False
        Frm_Info.Audi_TT.Visible = False
        Frm_Info.Ford_Fiesta.Visible = False
        Frm_Info.Seat_Ibiza.Visible = False
        Frm_Info.Ford_Mustang.Visible = False
        Frm_Info.Tesla_ModelS.Visible = False
        Frm_Info.Masseratti_Ghibli.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = False
        Frm_PagosMensuales.Jaguar_Ftype.Visible = False
        Frm_PagosMensuales.Honda_Fit.Visible = False
        Frm_PagosMensuales.Audi_TT.Visible = False
        Frm_PagosMensuales.Seat_Ibiza.Visible = False
        Frm_PagosMensuales.Chevy_Camaro.Visible = True
        Frm_PagosMensuales.Ford_Mustang.Visible = False
        Frm_PagosMensuales.Tesla_ModelS.Visible = False
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = False

        Frm_Info.Show()
        Me.Hide()


        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'camaro'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")
    End Sub

    Private Sub Btn_Mustang_Click(sender As Object, e As EventArgs) Handles Btn_Mustang.Click
        nombre = "Ford Mustang"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Ford_Mustang.Visible = True
        Frm_Info.Jaguar_Ftype.Visible = False
        Frm_Info.Honda_Fit.Visible = False
        Frm_Info.Audi_TT.Visible = False
        Frm_Info.Ford_Fiesta.Visible = False
        Frm_Info.Seat_Ibiza.Visible = False
        Frm_Info.Chevy_Camaro.Visible = False
        Frm_Info.Tesla_ModelS.Visible = False
        Frm_Info.Masseratti_Ghibli.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = False
        Frm_PagosMensuales.Jaguar_Ftype.Visible = False
        Frm_PagosMensuales.Honda_Fit.Visible = False
        Frm_PagosMensuales.Audi_TT.Visible = False
        Frm_PagosMensuales.Seat_Ibiza.Visible = False
        Frm_PagosMensuales.Chevy_Camaro.Visible = False
        Frm_PagosMensuales.Ford_Mustang.Visible = True
        Frm_PagosMensuales.Tesla_ModelS.Visible = False
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = False

        Frm_Info.Show()
        Me.Hide()

        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'mstang'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")

    End Sub


    Private Sub Btn_TT_Click(sender As Object, e As EventArgs) Handles Btn_TT.Click
        nombre = "Audi TT"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Audi_TT.Visible = True
        Frm_Info.Jaguar_Ftype.Visible = False
        Frm_Info.Honda_Fit.Visible = False
        Frm_Info.Ford_Fiesta.Visible = False
        Frm_Info.Seat_Ibiza.Visible = False
        Frm_Info.Chevy_Camaro.Visible = False
        Frm_Info.Ford_Mustang.Visible = False
        Frm_Info.Tesla_ModelS.Visible = False
        Frm_Info.Masseratti_Ghibli.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = False
        Frm_PagosMensuales.Jaguar_Ftype.Visible = False
        Frm_PagosMensuales.Honda_Fit.Visible = False
        Frm_PagosMensuales.Audi_TT.Visible = True
        Frm_PagosMensuales.Seat_Ibiza.Visible = False
        Frm_PagosMensuales.Chevy_Camaro.Visible = False
        Frm_PagosMensuales.Ford_Mustang.Visible = False
        Frm_PagosMensuales.Tesla_ModelS.Visible = False
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = False

        Frm_Info.Show()
        Me.Hide()

        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'tt'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")

    End Sub

    Private Sub Btn_Masseratti_Click(sender As Object, e As EventArgs) Handles Btn_Masseratti.Click
        nombre = "Masseratti Ghibli"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Masseratti_Ghibli.Visible = True
        Frm_Info.Jaguar_Ftype.Visible = False
        Frm_Info.Honda_Fit.Visible = False
        Frm_Info.Audi_TT.Visible = False
        Frm_Info.Ford_Fiesta.Visible = False
        Frm_Info.Seat_Ibiza.Visible = False
        Frm_Info.Chevy_Camaro.Visible = False
        Frm_Info.Ford_Mustang.Visible = False
        Frm_Info.Tesla_ModelS.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = False
        Frm_PagosMensuales.Jaguar_Ftype.Visible = False
        Frm_PagosMensuales.Honda_Fit.Visible = False
        Frm_PagosMensuales.Audi_TT.Visible = False
        Frm_PagosMensuales.Seat_Ibiza.Visible = False
        Frm_PagosMensuales.Chevy_Camaro.Visible = False
        Frm_PagosMensuales.Ford_Mustang.Visible = False
        Frm_PagosMensuales.Tesla_ModelS.Visible = False
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = True

        Frm_Info.Show()
        Me.Hide()

        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'ghibli'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")

    End Sub

    Private Sub Btn_Jaguar_Click(sender As Object, e As EventArgs) Handles Btn_Jaguar.Click
        nombre = "Jaguar F-Type"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Jaguar_Ftype.Visible = True
        Frm_Info.Honda_Fit.Visible = False
        Frm_Info.Audi_TT.Visible = False
        Frm_Info.Ford_Fiesta.Visible = False
        Frm_Info.Seat_Ibiza.Visible = False
        Frm_Info.Chevy_Camaro.Visible = False
        Frm_Info.Ford_Mustang.Visible = False
        Frm_Info.Tesla_ModelS.Visible = False
        Frm_Info.Masseratti_Ghibli.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = False
        Frm_PagosMensuales.Jaguar_Ftype.Visible = True
        Frm_PagosMensuales.Honda_Fit.Visible = False
        Frm_PagosMensuales.Audi_TT.Visible = False
        Frm_PagosMensuales.Seat_Ibiza.Visible = False
        Frm_PagosMensuales.Chevy_Camaro.Visible = False
        Frm_PagosMensuales.Ford_Mustang.Visible = False
        Frm_PagosMensuales.Tesla_ModelS.Visible = False
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = False

        Frm_Info.Show()
        Me.Hide()

        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'f-type'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")

    End Sub

    Private Sub Btn_Tesla_Click(sender As Object, e As EventArgs) Handles Btn_Tesla.Click
        nombre = "Tesla Model S"
        Frm_Info.Lbl_SelectedCar.Text = nombre
        Frm_Info.Tesla_ModelS.Visible = True
        Frm_Info.Jaguar_Ftype.Visible = False
        Frm_Info.Honda_Fit.Visible = False
        Frm_Info.Audi_TT.Visible = False
        Frm_Info.Ford_Fiesta.Visible = False
        Frm_Info.Seat_Ibiza.Visible = False
        Frm_Info.Chevy_Camaro.Visible = False
        Frm_Info.Ford_Mustang.Visible = False
        Frm_Info.Masseratti_Ghibli.Visible = False

        Frm_PagosMensuales.Ford_Fiesta.Visible = False
        Frm_PagosMensuales.Jaguar_Ftype.Visible = False
        Frm_PagosMensuales.Honda_Fit.Visible = False
        Frm_PagosMensuales.Audi_TT.Visible = False
        Frm_PagosMensuales.Seat_Ibiza.Visible = False
        Frm_PagosMensuales.Chevy_Camaro.Visible = False
        Frm_PagosMensuales.Ford_Mustang.Visible = False
        Frm_PagosMensuales.Tesla_ModelS.Visible = True
        Frm_PagosMensuales.Masseratti_Ghibli.Visible = False

        Frm_Info.Show()
        Me.Hide()

        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT precio FROM carros WHERE carro = 'models'"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Dim resultado_query = cmd.ExecuteScalar
        If Not resultado_query Is Nothing And Not resultado_query Is DBNull.Value Then
            precio = Val(resultado_query)
        End If

        Frm_Password.myConnection.Close()

        Frm_Info.Lbl_Price.Text = Format(precio, "$ #,###,##0.00")

    End Sub



    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        Frm_Account.Show()

    End Sub

End Class
