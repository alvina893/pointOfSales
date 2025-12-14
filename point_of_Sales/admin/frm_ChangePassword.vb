Imports MySql.Data.MySqlClient
Public Class frm_ChangePassword
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub frm_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        If txtOldPass.Text = String.Empty Then
            MsgBox("Please Enter OLD Password!", vbExclamation)
            Return
        ElseIf txtNewPass.Text = String.Empty Or txtReEnterPass.Text = String.Empty Then
            MsgBox("Enter NEW Password!", vbExclamation)
            Return
        ElseIf StrComp(txtNewPass.Text, txtReEnterPass.Text, CompareMethod.Binary) Then
            MsgBox("NEW Password does NOT Match!", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `tbluser` SET `password` =@password WHERE `password` =@password1", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@password", txtReEnterPass.Text)
                cmd.Parameters.AddWithValue("@password1", txtOldPass.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password Successfully Changed!", vbInformation)
                Else
                    MsgBox("Password Change Failed!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
        txtNewPass.Clear()
        txtOldPass.Clear()
        txtReEnterPass.Clear()
        Me.Close()
        loginForm.Show()
    End Sub
End Class