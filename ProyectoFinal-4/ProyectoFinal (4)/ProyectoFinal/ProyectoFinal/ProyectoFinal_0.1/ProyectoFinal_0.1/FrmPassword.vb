Public Class Frm_Password
    ' The password will match the characteristics defined in this form
    ' NO spaces as part of the password

    Public provider, datafile, connstring As String
    Public myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection

    Dim username, password, password_confirm As String


    Public Sub Conectarse()

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        datafile = "C:\Users\David Casanova\Documents\Tarea Prepa Tec\Compu\5 semestre\FINAL\ProyectoFinal-4\ProyectoFinal (4)\ProyectoFinal\ProyectoFinal\ProyectoFinal_0.1\ProyectoFinal_0.1\Usernames_Database.accdb"
        connstring = provider & datafile

        myConnection.ConnectionString = connstring

        myConnection.Open()

    End Sub

    Private Sub Btn_create_Click(sender As Object, e As EventArgs) Handles Btn_create.Click
        Dim longitud_username, longitud_password As Integer
        Dim nombre, password, password_confirm, Email, Lastname As String
        Dim Querystring As String

        password = txt_password.Text
        password_confirm = InputBox("Please confirm your password", "Confirmation", "Confirm Password")

        Email = TxtEmail.Text

        If InStr(Email, "@") <> 0 Then
            If password_confirm = password Then
                If txt_password.Text = "" Or TxtEmail.Text = "" Or TxtLastname.Text = "" Or TxtName.Text = "" Or TxtUsername.Text = "" Then
                    MsgBox("Please fill in the information required", MsgBoxStyle.Information, "Password & Username")

                Else

                    username = TxtUsername.Text

                    nombre = TxtName.Text
                    Lastname = TxtLastname.Text



                    longitud_username = Len(username)
                    longitud_password = Len(password)

                    If longitud_password >= 5 Then
                        If password = password_confirm Then
                            If InStr(password, " ") = 0 Then
                                If longitud_username >= 5 Then
                                    If InStr(username, " ") = 0 Then

                                        '************************************************************************************************************

                                        Querystring = "INSERT INTO Usernames(nombre, lastname, username, pssword, email) VALUES('" & nombre & "','" & Lastname & "','" & username & "','" & password & "','" & Email & "')"

                                        Conectarse()

                                        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Querystring, myConnection)

                                        Try
                                            cmd.ExecuteNonQuery()
                                            MsgBox("Query successfully executed", MsgBoxStyle.Information, "Query")
                                        Catch ex As Exception
                                            MsgBox(ex.Message)
                                        End Try

                                        myConnection.Close()

                                        '*************************************************************************************************************
                                        Me.Hide()
                                        Frm_Hello.Show()

                                    Else
                                        MsgBox("No spaces in your username please", MsgBoxStyle.Exclamation, "Error")
                                    End If
3:
                                Else
                                    MsgBox("Your username is too short", MsgBoxStyle.Exclamation, "Error")
                                End If

                            Else
                                MsgBox("No spaces in your password please", MsgBoxStyle.Exclamation, "Error")
                            End If

                        Else
                            MsgBox("Your passwords do not match", MsgBoxStyle.Exclamation, "Error")
                        End If

                    Else
                        MsgBox("Your password is too short", MsgBoxStyle.Exclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Passwords do not match", MsgBoxStyle.Exclamation, "Error")
            End If
        Else
            MsgBox("Invalid email", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click

        Frm_Hello.Show()
        Me.Hide()
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub
End Class
