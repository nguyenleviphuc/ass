Imports System.Data.SqlClient
Imports System.Data.DataTable




Public Class demo
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=demo222;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If btnsua.Text = "Sửa" Then
            txtMaSP.ReadOnly = True
            btnsua.Text = "Update"
            txtTenSP.Focus()
        ElseIf btnsua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update DEMO222 set TenSP=@TENSP, Soluong=@SOLUONG, Dongia=@DONGIA where MaSP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMaSP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDongia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaSP.ReadOnly = False
            btnsua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Nhap MaSP cần xóa")
            txtMaSP.Focus()
        Else
            Dim delquery As String = "delete from DEMO222 where MaSP=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnnhaplai_Click(sender As Object, e As EventArgs) Handles btnnhaplai.Click

    End Sub

    Private Sub btnluu_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            txtMaSP.Focus()
        ElseIf txtTenSP.Text = "" Then
            MessageBox.Show("Chua nhap Tên sản phẩm")
            txtTenSP.Focus()
        ElseIf txtSoluong.Text = "" Then
            MessageBox.Show("Chua nhap Số lượng")
            txtSoluong.Focus()
        ElseIf txtDongia.Text = "" Then
            MessageBox.Show("Chua nhap đơn giá")
            txtDongia.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into DEMO222 values(@MASP,@TENSP,@SOLUONG,@DONGIA)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMaSP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDongia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã SP' ,TenSP as 'Tên Sản phẩm', Soluong as 'Số lượng', Dongia as 'Đơn giá', Soluong * Dongia as 'Thành tiền' from DEMO222", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
End Class
