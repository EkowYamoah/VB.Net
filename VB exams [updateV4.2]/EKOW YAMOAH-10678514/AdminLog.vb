Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Public Class AdminLog

    Dim Olecon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DR YME\Documents\Visual Studio 2015\Projects\EKOW YAMOAH-10678514\Timtim.accdb")
    Dim MySQLcon As New MySqlConnection("server=Localhost;port=3308; user=root; password=;database=timtimtravels;")


    Private Sub AdminLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Olecon.Open()
        'If Olecon.State = ConnectionState.Open Then

        'Else
        'MsgBox("Error in Connecting to Database")
        'Close()
        'End If
        'Olecon.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM admins WHERE Username = '" & txtUsername.Text & "' AND [password] = '" & txtPassword.Text & "' ", Olecon)
        Dim user As String = ""
        Dim pass As String = ""

        Olecon.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader

        If (sdr.Read() = True) Then
            user = sdr("Username")
            pass = sdr("password")

            outClients.Show()
            Olecon.Close()
            Me.Hide()

        Else
            MsgBox("Wrong username or password!")

        End If




    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
        loginForm.Show()
    End Sub
End Class