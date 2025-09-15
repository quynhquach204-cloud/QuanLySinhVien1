<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SinhVienFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.txtTenSV = New System.Windows.Forms.TextBox()
        Me.txtLopSV = New System.Windows.Forms.TextBox()
        Me.txtDiemSV = New System.Windows.Forms.TextBox()
        Me.dgvSinhVien = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.btnTimKiemTheoMaSv = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ Và Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lớp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Điểm Tổng Kết "
        '
        'txtMaSV
        '
        Me.txtMaSV.ForeColor = System.Drawing.Color.Red
        Me.txtMaSV.Location = New System.Drawing.Point(169, 21)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(191, 22)
        Me.txtMaSV.TabIndex = 4
        '
        'txtTenSV
        '
        Me.txtTenSV.ForeColor = System.Drawing.Color.Red
        Me.txtTenSV.Location = New System.Drawing.Point(169, 62)
        Me.txtTenSV.Name = "txtTenSV"
        Me.txtTenSV.Size = New System.Drawing.Size(191, 22)
        Me.txtTenSV.TabIndex = 5
        '
        'txtLopSV
        '
        Me.txtLopSV.ForeColor = System.Drawing.Color.Red
        Me.txtLopSV.Location = New System.Drawing.Point(169, 105)
        Me.txtLopSV.Name = "txtLopSV"
        Me.txtLopSV.Size = New System.Drawing.Size(193, 22)
        Me.txtLopSV.TabIndex = 6
        '
        'txtDiemSV
        '
        Me.txtDiemSV.ForeColor = System.Drawing.Color.Red
        Me.txtDiemSV.Location = New System.Drawing.Point(169, 149)
        Me.txtDiemSV.Name = "txtDiemSV"
        Me.txtDiemSV.Size = New System.Drawing.Size(191, 22)
        Me.txtDiemSV.TabIndex = 7
        '
        'dgvSinhVien
        '
        Me.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvSinhVien.Location = New System.Drawing.Point(30, 220)
        Me.dgvSinhVien.Name = "dgvSinhVien"
        Me.dgvSinhVien.RowHeadersWidth = 51
        Me.dgvSinhVien.RowTemplate.Height = 24
        Me.dgvSinhVien.Size = New System.Drawing.Size(1146, 303)
        Me.dgvSinhVien.TabIndex = 8
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.Location = New System.Drawing.Point(29, 565)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(184, 44)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm Sinh Viên"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSua.Location = New System.Drawing.Point(263, 565)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(184, 44)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "Sửa Dữ Liệu"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Location = New System.Drawing.Point(478, 565)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(184, 44)
        Me.btnXoa.TabIndex = 11
        Me.btnXoa.Text = "Xóa Dữ Liệu"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnLamMoi
        '
        Me.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLamMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLamMoi.Location = New System.Drawing.Point(700, 565)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(184, 44)
        Me.btnLamMoi.TabIndex = 12
        Me.btnLamMoi.Text = "Làm Mới Dữ Liệu"
        Me.btnLamMoi.UseVisualStyleBackColor = False
        '
        'btnTimKiemTheoMaSv
        '
        Me.btnTimKiemTheoMaSv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimKiemTheoMaSv.Location = New System.Drawing.Point(854, 93)
        Me.btnTimKiemTheoMaSv.Name = "btnTimKiemTheoMaSv"
        Me.btnTimKiemTheoMaSv.Size = New System.Drawing.Size(114, 32)
        Me.btnTimKiemTheoMaSv.TabIndex = 13
        Me.btnTimKiemTheoMaSv.Text = "Tìm Kiếm"
        Me.btnTimKiemTheoMaSv.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.ForeColor = System.Drawing.Color.Black
        Me.txtTimKiem.Location = New System.Drawing.Point(786, 44)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(229, 22)
        Me.txtTimKiem.TabIndex = 14
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.ForeColor = System.Drawing.Color.Red
        Me.txtGioiTinh.Location = New System.Drawing.Point(507, 27)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(101, 22)
        Me.txtGioiTinh.TabIndex = 15
        '
        'txtDiaChi
        '
        Me.txtDiaChi.ForeColor = System.Drawing.Color.Red
        Me.txtDiaChi.Location = New System.Drawing.Point(507, 67)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(152, 22)
        Me.txtDiaChi.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Giới Tính"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Địa Chỉ"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button1.Location = New System.Drawing.Point(917, 565)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 44)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.Location = New System.Drawing.Point(773, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Tìm Kiếm Theo Mã Sinh Viên"
        '
        'SinhVienFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1201, 681)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtGioiTinh)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.btnTimKiemTheoMaSv)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvSinhVien)
        Me.Controls.Add(Me.txtDiemSV)
        Me.Controls.Add(Me.txtLopSV)
        Me.Controls.Add(Me.txtTenSV)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "SinhVienFrm"
        Me.Text = "Form1"
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents txtTenSV As TextBox
    Friend WithEvents txtLopSV As TextBox
    Friend WithEvents txtDiemSV As TextBox
    Friend WithEvents dgvSinhVien As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents btnTimKiemTheoMaSv As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents txtGioiTinh As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
End Class
