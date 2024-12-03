Imports System.Data.SqlClient
Public Class Catogory_Mng

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\Project\Database\Database.mdf;Integrated Security=True;Connect Timeout=30")

    'Dispaly Catogory database tables on Grid View 
    Private Sub DisplayCat()
        Con.Open()
        Dim query = "select * from CategoryTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        CatGridView.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Catogory_Mag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayCat()
    End Sub

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

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Application.Exit()
    End Sub

    Private Sub Reset()
        CatNameTB.Text = ""
        CatCB.SelectedIndex = 0
    End Sub

    Dim key = 0
    Private Sub CatGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CatGridView.CellMouseClick
        Dim row As DataGridViewRow = CatGridView.Rows(e.RowIndex)
        CatCB.SelectedValue = row.Cells(1).Value.ToString
        CatNameTB.Text = row.Cells(1).Value.ToString
        If CatNameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        If key = 0 Then
            MsgBox("Select an Catogory for Delete", MsgBoxStyle.OkOnly, "Salon System")
        Else
            Con.Open()
            Dim query = "delete from CategoryTbl where CatId=" & key & "" 'delete command
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.OkOnly, "Salon System")
            Con.Close()
            Reset()
            DisplayCat()
        End If
    End Sub
    Private Sub CatAddBTN_Click(sender As Object, e As EventArgs) Handles CatAddBTN.Click
        If CatTB.Text = "" Then
            MsgBox("Write A Category First", MsgBoxStyle.OkOnly, "Salon System")
        Else
            Con.open()
            Dim query = "insert into CategoryTbl values('" & CatTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Added to Category", MsgBoxStyle.OkOnly, "Salon System")
            Con.Close()
            CatTB.Text = ""
            FillCategory()
            DisplayCat()
        End If
    End Sub

    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New SqlCommand("select * From CategoryTbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        CatCB.DataSource = Tbl
        CatCB.DisplayMember = "CatName"
        CatCB.ValueMember = "CatName"
        Con.Close()
    End Sub

    Private Sub CatGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CatGridView.CellContentClick

    End Sub
End Class