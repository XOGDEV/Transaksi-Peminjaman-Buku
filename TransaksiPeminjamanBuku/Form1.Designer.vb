<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAnggota = New System.Windows.Forms.TextBox()
        Me.txtKTP = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtBukudipinjam = New System.Windows.Forms.TextBox()
        Me.txtJumlahKeterlambatan = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalDenda = New System.Windows.Forms.TextBox()
        Me.txtPinjamBuku = New System.Windows.Forms.TextBox()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.txtUangDibayarkan = New System.Windows.Forms.TextBox()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.cmdHasil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaksi Peminjaman Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. KTP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Lengkap"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Buku Yang Akan di Pinjam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Peminjaman"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal Pengembalian"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Jumlah Keterlambatan (Hari)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Total Biaya Denda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Harga Peminjaman Buku"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Total Bayar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Uang Yang di Bayarkan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(39, 340)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Kembalian"
        '
        'txtAnggota
        '
        Me.txtAnggota.Location = New System.Drawing.Point(252, 51)
        Me.txtAnggota.Name = "txtAnggota"
        Me.txtAnggota.Size = New System.Drawing.Size(200, 20)
        Me.txtAnggota.TabIndex = 13
        '
        'txtKTP
        '
        Me.txtKTP.Location = New System.Drawing.Point(252, 77)
        Me.txtKTP.Name = "txtKTP"
        Me.txtKTP.Size = New System.Drawing.Size(200, 20)
        Me.txtKTP.TabIndex = 14
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(252, 103)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 20)
        Me.txtNama.TabIndex = 15
        '
        'txtBukudipinjam
        '
        Me.txtBukudipinjam.Location = New System.Drawing.Point(252, 129)
        Me.txtBukudipinjam.Name = "txtBukudipinjam"
        Me.txtBukudipinjam.Size = New System.Drawing.Size(200, 20)
        Me.txtBukudipinjam.TabIndex = 16
        '
        'txtJumlahKeterlambatan
        '
        Me.txtJumlahKeterlambatan.Location = New System.Drawing.Point(252, 207)
        Me.txtJumlahKeterlambatan.Name = "txtJumlahKeterlambatan"
        Me.txtJumlahKeterlambatan.Size = New System.Drawing.Size(200, 20)
        Me.txtJumlahKeterlambatan.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(252, 155)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(252, 181)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 19
        '
        'txtTotalDenda
        '
        Me.txtTotalDenda.Location = New System.Drawing.Point(252, 233)
        Me.txtTotalDenda.Name = "txtTotalDenda"
        Me.txtTotalDenda.Size = New System.Drawing.Size(200, 20)
        Me.txtTotalDenda.TabIndex = 20
        '
        'txtPinjamBuku
        '
        Me.txtPinjamBuku.Location = New System.Drawing.Point(252, 259)
        Me.txtPinjamBuku.Name = "txtPinjamBuku"
        Me.txtPinjamBuku.Size = New System.Drawing.Size(200, 20)
        Me.txtPinjamBuku.TabIndex = 21
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Location = New System.Drawing.Point(252, 285)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(200, 20)
        Me.txtTotalBayar.TabIndex = 22
        '
        'txtUangDibayarkan
        '
        Me.txtUangDibayarkan.Location = New System.Drawing.Point(252, 311)
        Me.txtUangDibayarkan.Name = "txtUangDibayarkan"
        Me.txtUangDibayarkan.Size = New System.Drawing.Size(200, 20)
        Me.txtUangDibayarkan.TabIndex = 23
        '
        'txtKembalian
        '
        Me.txtKembalian.Location = New System.Drawing.Point(252, 337)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(200, 20)
        Me.txtKembalian.TabIndex = 24
        '
        'cmdHasil
        '
        Me.cmdHasil.Location = New System.Drawing.Point(42, 373)
        Me.cmdHasil.Name = "cmdHasil"
        Me.cmdHasil.Size = New System.Drawing.Size(410, 28)
        Me.cmdHasil.TabIndex = 25
        Me.cmdHasil.Text = "Hasil"
        Me.cmdHasil.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 413)
        Me.Controls.Add(Me.cmdHasil)
        Me.Controls.Add(Me.txtKembalian)
        Me.Controls.Add(Me.txtUangDibayarkan)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.txtPinjamBuku)
        Me.Controls.Add(Me.txtTotalDenda)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtJumlahKeterlambatan)
        Me.Controls.Add(Me.txtBukudipinjam)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKTP)
        Me.Controls.Add(Me.txtAnggota)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(523, 452)
        Me.MinimumSize = New System.Drawing.Size(523, 452)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Peminjaman Buku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAnggota As System.Windows.Forms.TextBox
    Friend WithEvents txtKTP As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtBukudipinjam As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlahKeterlambatan As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTotalDenda As System.Windows.Forms.TextBox
    Friend WithEvents txtPinjamBuku As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtUangDibayarkan As System.Windows.Forms.TextBox
    Friend WithEvents txtKembalian As System.Windows.Forms.TextBox
    Friend WithEvents cmdHasil As System.Windows.Forms.Button

End Class
