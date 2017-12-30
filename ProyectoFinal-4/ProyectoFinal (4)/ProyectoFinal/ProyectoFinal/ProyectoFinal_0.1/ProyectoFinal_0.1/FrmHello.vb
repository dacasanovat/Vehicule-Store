Public Class Frm_Hello
    Public nombre_usuario, apellido_usuario As String
    Public carros_comprados As Integer
    Public username As String
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Frm_Password.Show()

        MsgBox("Your password and username must be at least 5 characters long", MsgBoxStyle.Information, "Password & Username")
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim password As String


        If TxtUsername.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Please fill in the information required", MsgBoxStyle.Exclamation, "Error")
        Else


            password = TxtPassword.Text
            username = TxtUsername.Text
            elegir()

            Frm_Password.Conectarse()
            Dim querystring As String

            querystring = "SELECT * FROM Usernames where username = '" & username & "' AND pssword = '" & password & "' "

            Dim da As New OleDb.OleDbDataAdapter(querystring, Frm_Password.myConnection)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                nombre_usuario = dt.Rows(0).Item("nombre").ToString
                apellido_usuario = dt.Rows(0).Item("lastname").ToString

                Frm_Account.Lbl_name.Text = nombre_usuario & " " & apellido_usuario


                Me.Hide()
                Frm_Account.Show()

            Else
                MsgBox("Wrong password or username", MsgBoxStyle.Exclamation, "Error")
            End If


            Frm_Password.myConnection.Close()

        End If

    End Sub
    Public Sub elegir()
        Dim QueryString As String

        Frm_Password.Conectarse()

        QueryString = "SELECT carros FROM Usernames WHERE username = '" & username & "'"



        Dim da As New OleDb.OleDbDataAdapter(QueryString, Frm_Password.myConnection)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            carros_comprados = dt.Rows(0).Item("carros").ToString
            Frm_Account.lbl_carroscomprados.Text = carros_comprados
        End If

        Frm_Password.myConnection.Close()


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Frm_Hello_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

    End Sub

End Class
