'DB Connection
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Emp_Order
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\Project\Database\Database.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Application.Exit()
    End Sub
    'load on the panel
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        FillCategory()

    End Sub
    'to show items on menu view
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemGridView.DataSource = ds.Tables(0)
        ItemGridView.Columns("ItId").Visible = False 'to hide Item Id Column
        Con.Close()
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
    'code to show each catogory items on menu view
    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "select * from ItemTbl where ItCat='" & CatCB.SelectedValue.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemGridView.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    'view category in menu view
    Private Sub CatCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CatCB.SelectionChangeCommitted
        FilterByCategory()
    End Sub
    'refresh button
    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        DisplayItem()
    End Sub

    'Code to reduse qty when buy (Validation)
    Private Sub UpdateItem()
        Try 'new
            Dim newQty = stock - Convert.ToInt32(QtyTB.Text)
            Con.open()
            Dim query = "update ItemTbl set ItQty = " & newQty & " where ItId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Added to Cart", MsgBoxStyle.OkOnly, "Salon System")
            Con.Close()
            DisplayItem() 'Instently display on table, the item you added
        Catch ex As Exception 'new
            MsgBox(ex.Message) 'new
        End Try 'new
    End Sub

    'Transaction and Total order code start from here

    Dim ItemName As String
    Dim i = 0, GrdTotal = 0, price, qty
    Private Sub AddBillBTN_Click(sender As Object, e As EventArgs) Handles AddBillBTN.Click
        If key = 0 Then
            MsgBox("Nothing Selected !", MsgBoxStyle.OkOnly, "Salon System")
        ElseIf Convert.ToInt32(QtyTB.Text) > stock Then
            MsgBox("Out Of Stock", MsgBoxStyle.OkOnly, "Salon System")
        Else
            Dim rnum As Integer = BillViewGrid.Rows.Add()
            Dim total = Convert.ToInt32(QtyTB.Text) * price
            i = i + 1 'ID auto Genarate
            BillViewGrid.Rows.Item(rnum).Cells("Column1").Value = i
            BillViewGrid.Rows.Item(rnum).Cells("Column2").Value = ItemName
            BillViewGrid.Rows.Item(rnum).Cells("Column3").Value = price
            BillViewGrid.Rows.Item(rnum).Cells("Column4").Value = QtyTB.Text
            BillViewGrid.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal = GrdTotal + total
            TotalLbl1.Text = "Rs" + Convert.ToString(GrdTotal) 'how to add to bill Rs and show grand total
            UpdateItem()
            QtyTB.Text = ""
            key = 0
        End If
    End Sub

    Dim key = 0, stock

    Private Sub ItemGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemGridView.CellMouseClick
        Dim row As DataGridViewRow = ItemGridView.Rows(e.RowIndex)
        ItemName = row.Cells(1).Value.ToString

        If ItemName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString)
        End If
    End Sub

    'View Orders
    Private Sub AddBill()
        Con.open()
        Dim query = "insert into OrderTbl values('" & DateTime.Today.Date & "', " & GrdTotal & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)

        MsgBox("Print the Bill", MsgBoxStyle.OkOnly, "Salon System")
        Con.Close()
    End Sub
    'print confirm dialog box
    Private Sub PrintBillBtn_Click(sender As Object, e As EventArgs) Handles PrintBillBtn.Click
        AddBill()
        PrintPreviewDialog.Show()
        Reset()
        DisplayItem()
    End Sub
    'print the last bill
    Private Sub PrintBill_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintBill.PrintPage

        Dim bm As New Bitmap(Me.BillViewGrid.Width, Me.BillViewGrid.Height)
        BillViewGrid.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillViewGrid.Width, Me.BillViewGrid.Height))
        e.Graphics.DrawImage(bm, 0, 90)
        e.Graphics.DrawString("Total Bill" + GrdTotal.ToString(), New Font("Arial", 15), Brushes.Black, 325, 580)
        e.Graphics.DrawString("############ Come Again ! ############", New Font("Arial", 15), Brushes.Black, 130, 600)
        Reset()
        DisplayItem()

    End Sub
End Class