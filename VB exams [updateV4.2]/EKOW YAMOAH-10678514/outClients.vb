Public Class outClients
    Private Sub outClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TimtimDataSetM.clients' table. You can move, or remove it, as needed.
        ' Me.ClientsTableAdapter2.Fill(Me.TimtimDataSetM.clients)
        'TODO: This line of code loads data into the 'TimtimDataSet1.clients' table. You can move, or remove it, as needed.

        ' Me.ClientsTableAdapter1.Fill(Me.TimtimDataSet1.clients)
        'TODO: This line of code loads data into the 'TimtimDataSet.clients' table. You can move, or remove it, as needed.
        'Me.ClientsTableAdapter.Fill(Me.TimtimDataSet.clients)

        PanelList.Visible = False






    End Sub





    Private Sub FormInPanel(child As Object)
        PanelList.Controls.Clear()
        Dim ch As Form
        ch = child
        ch.TopLevel = False
        ch.Dock = DockStyle.Fill
        PanelList.Controls.Add(ch)
        PanelList.Tag = ch
        ch.Show()
    End Sub
    Private Sub BtnViewList_Click_1(sender As Object, e As EventArgs) Handles BtnViewList.Click
        PanelList.Visible = True
        FormInPanel(FormList)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) 
        Close()

    End Sub

    Private Sub BtneX_Click(sender As Object, e As EventArgs) Handles BtneX.Click
        Close()
        loginForm.Show()
    End Sub
End Class