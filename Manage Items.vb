'DB Connection
Imports System.Data.SqlClient
Public Class Manage_Items
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\Project\Database\Database.mdf;Integrated Security=True;Connect Timeout=30")
    'Logout Button code to Going Back Login Form
    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
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

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Application.Exit()
    End Sub
    'Reset Button Code
    Private Sub Reset()
        ItemNameTB.Text = ""
        PriceNameTab.Text = ""
        ItemQtyTB.Text = ""
        CatCB.SelectedIndex = 0
    End Sub
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Reset()
    End Sub
    'DB connections to Category Table & Code for Category Combo Box 
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
    'When load Manage Items Show Category
    Private Sub Manage_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()
    End Sub
    'Code for adding a item and validation for add button
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If CatCB.SelectedIndex = -1 Or ItemNameTB.Text = "" Or PriceNameTab.Text = "" Or ItemQtyTB.Text = "" Then
            MsgBox("Fill the Details", MsgBoxStyle.OkOnly, "Salon System")
        Else
            Con.open()
            Dim query = "insert into ItemTbl values('" & ItemNameTB.Text & "', '" & CatCB.SelectedValue.ToString() & "', " & PriceNameTab.Text & "," & ItemQtyTB.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Added the Item", MsgBoxStyle.OkOnly, "Salon System")
            Con.Close()
            Reset() 'clear all text boxers after added
            DisplayItem() 'Instently display on table, the item you added 
        End If
    End Sub
    'Code for Item View on Table
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemGridView.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    'Code for when select a row, then it will fill the textboxes and combobox
    Dim key = 0
    Private Sub ItemGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemGridView.CellMouseClick
        Dim row As DataGridViewRow = ItemGridView.Rows(e.RowIndex)
        ItemNameTB.Text = row.Cells(1).Value.ToString
        CatCB.SelectedValue = row.Cells(2).Value.ToString
        PriceNameTab.Text = row.Cells(3).Value.ToString
        ItemQtyTB.Text = row.Cells(4).Value.ToString
        If ItemNameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    'code for the delete button
    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        If key = 0 Then
            MsgBox("Select an Item for Delete", MsgBoxStyle.OkOnly, "Salon System")
        Else
            Con.Open()
            Dim query = "delete from ItemTbl where ItId=" & key & "" 'delete command
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.OkOnly, "Salon System")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub
    'code for edit button
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If CatCB.SelectedIndex = -1 Or ItemNameTB.Text = "" Or PriceNameTab.Text = "" Or ItemQtyTB.Text = "" Then
            MsgBox("Fill the Details", MsgBoxStyle.OkOnly, "Salon System")
        Else
            Try 'new
                Con.open()
                Dim query = "update ItemTbl set ItName='" & ItemNameTB.Text & "',ItCat='" & CatCB.SelectedValue.ToString() & "' ,ItPrice=" & PriceNameTab.Text & ",ItQty=" & ItemQtyTB.Text & " where ItId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Added the Item", MsgBoxStyle.OkOnly, "Salon System")
                Con.Close()
                Reset() 'clear all text boxers after added
                DisplayItem() 'Instently display on table, the item you added
            Catch ex As Exception 'new
                MsgBox(ex.Message) 'new
            End Try 'new
        End If
    End Sub

End Class