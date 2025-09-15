Imports System.Data.SqlClient
Imports System.Data

Public Class LoginFrm

    ' Chuỗi kết nối đến cơ sở dữ liệu
    Dim connectionString As String = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;"
    Dim conn As New SqlConnection(connectionString)

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        ' Lấy tên đăng nhập và mật khẩu từ TextBox
        Dim tenDangNhap As String = txtDangNhap.Text
        Dim matKhau As String = txtMatKhau.Text

        If String.IsNullOrEmpty(tenDangNhap) OrElse String.IsNullOrEmpty(matKhau) Then
            MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau"
            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap)
            cmd.Parameters.AddWithValue("@MatKhau", matKhau)

            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Ẩn form hiện tại và hiển thị form chính
                Me.Hide()
                Dim mainForm As New SinhVienFrm()
                mainForm.Show()
            Else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối hoặc truy vấn: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class