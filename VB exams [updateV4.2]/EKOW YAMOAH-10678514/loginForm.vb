Imports System.Data.OleDb


Public Class loginForm
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 426
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Me.Hide()
        AdminLog.Show()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub FormInPanel(child As Object)
        'PanelM.Controls.Clear()
        Dim ch As Form
        ch = child
        ch.TopLevel = False
        ch.Dock = DockStyle.Fill
        PanelM.Controls.Add(ch)
        PanelM.Tag = ch
        ch.Show()
    End Sub

    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click


        If txtFname.Text = "" Or txtLname.Text = "" Or CmbGender.Text = "" Or CmbCountry.Text = "" Or CmbNation.Text = "" Then
            MsgBox("Please Fill the form")
        Else

            Me.Width = 1253
            FormInPanel(Form1)

        End If

    End Sub
End Class