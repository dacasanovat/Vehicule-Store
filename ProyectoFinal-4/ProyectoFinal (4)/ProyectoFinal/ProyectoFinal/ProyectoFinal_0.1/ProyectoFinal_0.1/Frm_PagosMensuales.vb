Public Class Frm_PagosMensuales
    Public Tiempo As String

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Frm_Carros.Show()
        Me.Hide()
        Lst_months.Items.Clear()
    End Sub

    Private Sub btn_buy_Click(sender As Object, e As EventArgs) Handles btn_buy.Click
        Dim answer As Integer
        Dim QueryString As String

        answer = MsgBox("Are you sure you want to buy this car?", MsgBoxStyle.YesNo, "Confirmation")


        If answer = 6 Then
            Lst_months.Items.Clear()
            Frm_Hello.carros_comprados += 1
            Mejora()
            Frm_Account.lbl_carroscomprados.Text = Frm_Hello.carros_comprados
            Me.Hide()
            Frm_Account.Show()
            MsgBox("Congratulations! You have bought a beautiful " & Frm_Carros.nombre & "                                      A sales representative is coming your way! Enjoy!", MsgBoxStyle.OkOnly, "Congratulations")


            Tiempo = DateString

            QueryString = "INSERT INTO Compras (Username, carro, Fecha) " & _
                          "VALUES('" & Frm_Hello.username & "','" & Frm_Carros.nombre & "','" & Tiempo & "')"



            Frm_Password.Conectarse()

            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Query successfully executed", MsgBoxStyle.Information, "Query")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Frm_Password.myConnection.Close()
        End If
    End Sub

    Public Sub Mejora()
        Dim QueryString As String

        QueryString = "UPDATE Usernames  SET carros = '" & Frm_Hello.carros_comprados & "' WHERE username = '" & Frm_Hello.username & "'"
        Frm_Password.Conectarse()

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(QueryString, Frm_Password.myConnection)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Query successfully executed", MsgBoxStyle.Information, "Query")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Frm_Password.myConnection.Close()

    End Sub

End Class

