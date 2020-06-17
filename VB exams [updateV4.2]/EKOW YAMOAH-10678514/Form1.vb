

Imports System.Data.OleDb
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim Olecon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DR YME\Documents\Visual Studio 2015\Projects\EKOW YAMOAH-10678514\Timtim.accdb")
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\DR YME\Documents\Visual Studio 2015\Projects\EKOW YAMOAH-10678514\Timtim.accdb"

    'Dim ConnString As String = Utils.GetConnString()
    Dim SqlString As String = "INTO INTO clients(First Name, Last Name, Gender,COUNTRY OF RESIDENCE, NATIONALITY, TOTAL DISTANCE) VALUES (@First Name, @Last Name, @Gender,@COUNTRY OF RESIDENCE, @NATIONALITY, @TOTAL DISTANCE)"

    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Public dbcmd As New OleDb.OleDbCommand
    Public result As Integer
    Public Sql As String



    Dim museum As Double = 1.5
    Dim mall As Double = 2.5

    Dim UoG As Double = 5.9
    Dim theatre As Double = 7.0

    Dim destinations(5) As String '0,1,2,3
    Dim distances(5) As Double

    Dim SearchDistance As Integer
    Dim SearchDestination As Integer

    Public Sub cleartextfields()
        For Each crt As Control In GroupBox1.Controls
            If crt.GetType Is GetType(TextBox) Then
                crt.Text = Nothing
            End If
        Next
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaxiPic.Visible = False
        WalkPic.Visible = False
        LblTaxi.Visible = False
        LblWalk.Visible = False


        SearchDestination = -1
        SearchDistance = -1


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Dim selDistance As Integer
        Dim SelDestination As String
        SelDestination = DestinCmbBox.Text
        Try
            selDistance = txtMapDist.Text
        Catch Ex As Exception
            Throw Ex

        Finally
            'selDistance = 0

        End Try
        If DestinCmbBox.Text = "" Then
            MsgBox("Please select a desination")
            DestinCmbBox.Text = ""
        End If
        If SearchDestination = 4 Or SearchDistance = 4 Then
            MsgBox("Maximum number destinations per day reached!!", MsgBoxStyle.Information)


            txtMapDist.Text = ""
            DestinCmbBox.Text = ""
            DestinCmbBox.Enabled = False
            txtMapDist.Enabled = False
            BtnAdd.Enabled = False
            BtnProceed.Enabled = False
        Else
            SearchDestination = SearchDestination + 1
            SearchDistance = SearchDistance + 1
            destinations(SearchDestination) = SelDestination
            distances(SearchDistance) = selDistance
            DestinCmbBox.Text = ""
            DestinCmbBox.Focus()
        End If

        Dim AddDext As Integer
        Dim AddNext As Integer

        Dim totalarr As Integer
        For i = 0 To destinations.Length - 1
            totalarr += distances(i)
        Next
        TxtMapkm.Text = (Val(totalarr * 0.25))


        GrpBoxSelected.Visible = True

        If destinations(4) = "0" Then
            MsgBox("Please Add a Destination")
        Else

            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            For AddDext = 0 To SearchDistance
                ListBox2.Items.Add(distances(AddDext))
            Next AddDext
            ListBox2.Sorted = False


            For AddNext = 0 To SearchDestination
                ListBox1.Items.Add(destinations(AddNext))



            Next AddNext

            ListBox1.Sorted = False
        End If

        If TxtMapkm.Text <= 3 Then
            TaxiPic.Visible = False
            WalkPic.Visible = True

            LblTaxi.Visible = False
            LblWalk.Visible = True

        ElseIf TxtMapkm.Text > 3 Then

            TaxiPic.Visible = True
            WalkPic.Visible = False

            LblTaxi.Visible = True
            LblWalk.Visible = False
        End If


    End Sub

    Private Sub DestinCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DestinCmbBox.SelectedIndexChanged
        If DestinCmbBox.SelectedIndex = 0 Then
            txtMapDist.Text = (Val(1.5))
        ElseIf DestinCmbBox.SelectedIndex = 1 Then
            txtMapDist.Text = 2.5
        ElseIf DestinCmbBox.SelectedIndex = 2 Then
            txtMapDist.Text = 5.9
        ElseIf DestinCmbBox.SelectedIndex = 3 Then
            txtMapDist.Text = 7
        End If
    End Sub

    Private Sub BtnProceed_Click(sender As Object, e As EventArgs) Handles BtnProceed.Click

        Try
            ' Sql = "INSERT INTO clients(First Name, Last Name, Gender,COUNTRY OF RESIDENCE, NATIONALITY, TOTAL DISTANCE) VALUES ('loginForm.txtFname.Text', 'loginForm.txtLname.Text','loginForm.CmbGender.Text ','loginForm.CmbCountry.Text ','loginForm.CmbNation.Text','Me.TxtMapkm.Text' )"
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(SqlString, conn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@First Name", loginForm.txtFname.Text)
                    cmd.Parameters.AddWithValue("@Last Name", loginForm.txtLname.Text)
                    cmd.Parameters.AddWithValue("@Gender", loginForm.CmbGender.Text)
                    cmd.Parameters.AddWithValue("@COUNTRY OF RESIDENCE", loginForm.CmbCountry.Text)
                    cmd.Parameters.AddWithValue("@NATIONALITY", loginForm.CmbNation.Text)
                    cmd.Parameters.AddWithValue("@TOTAL DISTANCE", Me.TxtMapkm.Text)



                    conn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using
            Olecon.Open()
                With dbcmd
                    .CommandText = Sql
                    .Connection = Olecon
                End With

                result = dbcmd.ExecuteNonQuery


                If result > 0 Then
                    MsgBox("Enjoy your journey!")
                    Olecon.Close()

                    cleartextfields()

                Else
                    MsgBox("Please enter values")
                End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Olecon.Close()
        End Try


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim AddDext As Integer
        Dim AddNext As Integer

        Dim totalarr As Integer
        For i = 0 To destinations.Length - 1
            totalarr += distances(i)
        Next
        TxtMapkm.Text = (Val(totalarr * 0.25))


        GrpBoxSelected.Visible = True

        If destinations(4) = "0" Then
            MsgBox("Please Add a Destination")
        Else

            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            For AddDext = 0 To SearchDistance
                ListBox2.Items.Add(distances(AddDext))
            Next AddDext
            ListBox2.Sorted = False


            For AddNext = 0 To SearchDestination
                ListBox1.Items.Add(destinations(AddNext))



            Next AddNext

            ListBox1.Sorted = False
        End If

        If TxtMapkm.Text <= 3 Then
            TaxiPic.Visible = False
            WalkPic.Visible = True

            LblTaxi.Visible = False
            LblWalk.Visible = True

        ElseIf TxtMapkm.Text > 3 Then

            TaxiPic.Visible = True
            WalkPic.Visible = False

            LblTaxi.Visible = True
            LblWalk.Visible = False
        End If
    End Sub
End Class
