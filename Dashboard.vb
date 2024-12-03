Imports System.Data.SqlClient
Public Class Dashboard

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\Project\Database\Database.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DashGOBTN_Click(sender As Object, e As EventArgs) Handles DashGOBTN.Click
        Dim Obj = New Dashboard
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub CatMngGOBTN_Click(sender As Object, e As EventArgs) Handles CatMngGOBTN.Click
        Dim Obj = New Catogory_Mng
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub ItemMngGOBTN_Click(sender As Object, e As EventArgs) Handles ItemMngGOBTN.Click
        Dim Obj = New Manage_Items
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub ExitBTN2_Click(sender As Object, e As EventArgs) Handles ExitBTN2.Click
        Application.Exit()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' for get sum for Total Lable

        Dim cmd As New SqlCommand("select * from OrderTbl", Con)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        OrderGridView.DataSource = dt
        Con.Close()
        Dim colsum As Decimal
        For Each row As DataGridViewRow In OrderGridView.Rows
            colsum += row.Cells(2).Value
        Next
        GrandTot.Text = colsum

        ' to get how many
        Dim cmd1 As New SqlCommand("select * from OrderTbl", Con)
        Dim da1 As New SqlDataAdapter
        da1.SelectCommand = cmd
        Dim dt1 As New DataTable
        dt1.Clear()
        da1.Fill(dt1)
        OrderGridView.DataSource = dt1
        Con.Close()
        Dim count As Integer = 0 ' in this count can be change any word you like. it is out of box thing
        For Each row As DataGridViewRow In OrderGridView.Rows
            Dim itemcount As String = row.Cells(2).Value
            count = count + 1
        Next
        CountTxt.Text = count.ToString
    End Sub


    'Connect to Order Table
    Private Sub DisplayBill()
        Con.Open()
        Dim query = "select * from OrderTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        OrderGridView.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    'Show on detail on Grid View
    Private Sub View_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill()
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub
End Class