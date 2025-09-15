Imports System.Data.SqlClient
Imports System.Data

Public Class SinhVienFrm

    ' Chuỗi kết nối đến cơ sở dữ liệu
    Dim connectionString As String = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True;"
    Dim conn As New SqlConnection(connectionString)
    Dim adapter As SqlDataAdapter
    Dim dt As New DataTable

    Private Sub SinhVienFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Hàm nạp dữ liệu từ database và hiển thị lên DataGridView
    Private Sub LoadData()
        Try
            conn.Open()
            Dim query As String = "SELECT MaSV, TenSV, Lop, Diem, GioiTinh, QueQuan FROM ThongTinSV"
            adapter = New SqlDataAdapter(query, conn)
            dt.Clear()
            adapter.Fill(dt)
            dgvSinhVien.DataSource = dt

            ' Tự động điều chỉnh độ rộng của các cột để vừa khít với DataGridView
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Lỗi kết nối hoặc truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Hàm làm sạch các TextBox
    Private Sub ClearTextBoxes()
        txtMaSV.Clear()
        txtTenSV.Clear()
        txtLopSV.Clear()
        txtDiemSV.Clear()
        txtGioiTinh.Clear()
        txtDiaChi.Clear()
        txtTimKiem.Clear()
        txtMaSV.Focus()
    End Sub

    ' --- Các nút chức năng ---

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO ThongTinSV (MaSV, TenSV, Lop, Diem, GioiTinh, QueQuan) VALUES (@MaSV, @TenSV, @Lop, @Diem, @GioiTinh, @QueQuan)"
            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
            cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text)
            cmd.Parameters.AddWithValue("@Lop", txtLopSV.Text)
            cmd.Parameters.AddWithValue("@Diem", Single.Parse(txtDiemSV.Text))
            cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text)
            cmd.Parameters.AddWithValue("@QueQuan", txtDiaChi.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
                LoadData()
                ClearTextBoxes()
            End If
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            conn.Open()
            Dim query As String = "UPDATE ThongTinSV SET TenSV = @TenSV, Lop = @Lop, Diem = @Diem, GioiTinh = @GioiTinh, QueQuan = @QueQuan WHERE MaSV = @MaSV"
            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
            cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text)
            cmd.Parameters.AddWithValue("@Lop", txtLopSV.Text)
            cmd.Parameters.AddWithValue("@Diem", Single.Parse(txtDiemSV.Text))
            cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text)
            cmd.Parameters.AddWithValue("@QueQuan", txtDiaChi.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
                LoadData()
                ClearTextBoxes()
            End If
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim maSVToDelete As String = txtMaSV.Text
        If String.IsNullOrEmpty(maSVToDelete) Then
            MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên có mã " & maSVToDelete & " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "DELETE FROM ThongTinSV WHERE MaSV = @MaSV"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MaSV", maSVToDelete)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    LoadData()
                    ClearTextBoxes()
                End If
            End Try
        End If
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        ClearTextBoxes()
        LoadData()
    End Sub

    Private Sub btnTimKiemTheoMaSV_Click(sender As Object, e As EventArgs) Handles btnTimKiemTheoMaSv.Click
        Dim maSVToSearch As String = txtTimKiem.Text
        If String.IsNullOrEmpty(maSVToSearch) Then
            MessageBox.Show("Vui lòng nhập Mã SV để tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT MaSV, TenSV, Lop, Diem, GioiTinh, QueQuan FROM ThongTinSV WHERE MaSV LIKE @MaSV"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MaSV", "%" & maSVToSearch & "%")

            adapter = New SqlDataAdapter(cmd)
            dt.Clear()
            adapter.Fill(dt)
            dgvSinhVien.DataSource = dt

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Không tìm thấy sinh viên với mã này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Sự kiện khi click vào một hàng trong DataGridView
    Private Sub dgvSinhVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSinhVien.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSinhVien.Rows(e.RowIndex)

            If Not IsDBNull(row.Cells("MaSV").Value) Then txtMaSV.Text = row.Cells("MaSV").Value.ToString()
            If Not IsDBNull(row.Cells("TenSV").Value) Then txtTenSV.Text = row.Cells("TenSV").Value.ToString()
            If Not IsDBNull(row.Cells("Lop").Value) Then txtLopSV.Text = row.Cells("Lop").Value.ToString()
            If Not IsDBNull(row.Cells("Diem").Value) Then txtDiemSV.Text = row.Cells("Diem").Value.ToString()
            If Not IsDBNull(row.Cells("GioiTinh").Value) Then txtGioiTinh.Text = row.Cells("GioiTinh").Value.ToString()
            If Not IsDBNull(row.Cells("QueQuan").Value) Then txtDiaChi.Text = row.Cells("QueQuan").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub
End Class