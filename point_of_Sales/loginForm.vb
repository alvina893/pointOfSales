Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class loginForm
    Dim nameLogin As String
    Dim username As String
    Dim password As String
    Dim role As String

    <DllImport("dwmapi.dll")>
    Private Shared Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Private Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function
    Structure MARGINS
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure


    Private Sub EnableShadow()
        Dim val As Integer = 2 ' DWMNCRP_ENABLED
        DwmSetWindowAttribute(Me.Handle, 2, val, 4)

        Dim m As New MARGINS With {
        .Left = 1,
        .Right = 1,
        .Top = 1,
        .Bottom = 1
    }
        DwmExtendFrameIntoClientArea(Me.Handle, m)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Public Function VerifyPassword(inputPassword As String, storedSalt As String) As String
        Dim saltBytes() As Byte = Convert.FromBase64String(storedSalt)

        Using pbkdf2 As New Rfc2898DeriveBytes(inputPassword, saltBytes, 10000)
            Dim hashBytes = pbkdf2.GetBytes(32)
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Username atau Password tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        Try
            conn.Open()

            Dim sql As String =
                "SELECT name, username, password_hash, password_salt, role 
             FROM tbluser
             WHERE username = @username"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@username", txtUser.Text)

            dr = cmd.ExecuteReader()

            If Not dr.Read() Then
                MsgBox("Warning: Username atau Password salah!", vbExclamation)
                dr.Close()
                conn.Close()
                Exit Sub
            End If

            Dim dbName As String = dr("name").ToString()
            Dim dbRole As String = dr("role").ToString()
            Dim dbHash As String = dr("password_hash").ToString()
            Dim dbSalt As String = dr("password_salt").ToString()

            dr.Close()

            ' Hash password input menggunakan salt yang tersimpan
            Dim inputHash As String = VerifyPassword(txtPass.Text, dbSalt)

            If inputHash <> dbHash Then
                MsgBox("Warning: Username atau Password salah!", vbExclamation)
                conn.Close()
                Exit Sub
            End If

            conn.Close()

            ' LOGIN OK
            MsgBox("Hi there, " & dbName & "!", vbInformation)

            Select Case UCase(dbRole)
                Case "ADMIN"
                    Me.Hide()
                    mainForm_Admin.Show()

                Case "CASHIER"
                    Me.Hide()
                    mainForm_Cashier.Show()

                Case "EMPLOYEE"
                    Me.Hide()
                    mainForm_Employee.Show()
            End Select

            txtUser.Clear()
            txtPass.Clear()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
