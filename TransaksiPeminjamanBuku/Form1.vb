Public Class Form1
    Sub info()
        Beep()
        MessageBox.Show("Created by XOGDEV" & vbCrLf & "NAMA: XOG" & vbCrLf & "NPM: **********", "Alert")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        info()

        TopMost = False
        cmdHasil.Enabled = False

        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now

        txtJumlahKeterlambatan.ReadOnly = True
        txtJumlahKeterlambatan.BackColor = Color.White
        txtTotalDenda.ReadOnly = True
        txtTotalDenda.BackColor = Color.White
        txtTotalBayar.ReadOnly = True
        txtTotalBayar.BackColor = Color.White
        txtKembalian.ReadOnly = True
        txtKembalian.BackColor = Color.White

        txtPinjamBuku.Text = ""
        txtJumlahKeterlambatan.Text = ""
        txtTotalDenda.Text = ""
        txtUangDibayarkan.Text = ""

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim biaya As Integer
        Dim keterlambatan As Integer
        Dim hasil As Integer

        If True Then
            Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
            Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
            Dim ts As TimeSpan = dt1.Subtract(dt2)

            If Convert.ToInt32(ts.Days) <= 7 Then
                biaya = "2000" 'Rp. 2.000
            ElseIf Convert.ToInt32(ts.Days) <= 14 Then
                biaya = "7500" 'Rp. 7.500
            ElseIf Convert.ToInt32(ts.Days) <= 30 Then
                biaya = "50000" 'Rp. 50.000
            End If
            txtJumlahKeterlambatan.Text = ts.Days
            keterlambatan = Val(txtJumlahKeterlambatan.Text)
            hasil = biaya * keterlambatan
            txtTotalDenda.Text = Format(hasil, "##,##0")
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim biaya As Integer
        Dim keterlambatan As Integer
        Dim hasil As Integer

        If True Then
            Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
            Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
            Dim ts As TimeSpan = dt2.Subtract(dt1)

            If Convert.ToInt32(ts.Days) <= 7 Then
                biaya = "2000" 'Rp. 2.000
            ElseIf Convert.ToInt32(ts.Days) <= 14 Then
                biaya = "7500" 'Rp. 7.500
            ElseIf Convert.ToInt32(ts.Days) <= 30 Then
                biaya = "50000" 'Rp. 50.000
            End If
            txtJumlahKeterlambatan.Text = ts.Days
            keterlambatan = Val(txtJumlahKeterlambatan.Text)
            hasil = biaya * keterlambatan
            txtTotalDenda.Text = Format(hasil, "##,##0")
        End If
    End Sub

    Private Sub txtcmdHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHasil.Click
        'Dim TotalBayar As Integer
        'Dim Kembalian As Integer
        Dim Tunai As Double

        If txtAnggota.Text = String.Empty Then
            MsgBox("No. Anggota Mohon Di isi")
        ElseIf txtKTP.Text = String.Empty Then
            MsgBox("No. KTP Mohon Di isi")
        ElseIf txtNama.Text = String.Empty Then
            MsgBox("Nama Lengkap Mohon Di isi")
        ElseIf txtBukudipinjam.Text = String.Empty Then
            MsgBox("Nama Buku yang akan di Pinjam Mohon Di isi")
        ElseIf txtUangDibayarkan.Text = String.Empty Then
            MsgBox("Uang yang akan di Bayarkan Mohon Di isi")
        ElseIf txtPinjamBuku.Text = String.Empty Then
            MsgBox("Harga Pinjam Buku Mohon Di isi")
        Else
            Tunai = txtUangDibayarkan.Text
            txtKembalian.Text = Format(Tunai, "##,##0")
            txtKembalian.Text = Tunai - txtTotalBayar.Text
            'Kembalian = Val(txtUangDibayarkan.Text) - Val(txtTotalBayar.Text)
            'txtKembalian.Text = Format(Kembalian, "##,##0")
        End If
    End Sub

    Private Sub txtKembalian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKembalian.TextChanged
        Dim value As Integer
        value = txtKembalian.Text
        txtKembalian.Text = Format(value, "##,##0")
    End Sub

    Private Sub txtPinjamBuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPinjamBuku.TextChanged
        Dim value As Integer
        Dim HargaPinjaman As Double

        If txtPinjamBuku.Text = String.Empty Then
            txtPinjamBuku.Text = "0"
        Else
            value = txtPinjamBuku.Text
            txtPinjamBuku.Text = Format(value, "##,##0")
            txtPinjamBuku.SelectionStart = Len(txtPinjamBuku.Text)
            HargaPinjaman = txtPinjamBuku.Text
            txtTotalBayar.Text = HargaPinjaman + txtTotalDenda.Text
        End If
    End Sub

    Private Sub txtUangDibayarkan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUangDibayarkan.TextChanged
        Dim value As Integer

        If txtUangDibayarkan.Text = String.Empty Then
            txtUangDibayarkan.Text = "0"
        Else
            value = txtUangDibayarkan.Text
            txtUangDibayarkan.Text = Format(value, "##,##0")
            txtUangDibayarkan.SelectionStart = Len(txtUangDibayarkan.Text)
            cmdHasil.Enabled = True
        End If
    End Sub

    Private Sub txtTotalBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalBayar.TextChanged
        Dim value As Integer
        value = txtTotalBayar.Text
        txtTotalBayar.Text = Format(value, "##,##0")
    End Sub

    Private Sub txtAnggota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnggota.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "50") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtKTP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKTP.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "50") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtNama_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNama.KeyPress
        Dim unacceptable As String = "0123456789"

        If InStr(unacceptable, e.KeyChar) > 0 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtBukudipinjam_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBukudipinjam.KeyPress
        Dim unacceptable As String = "0123456789"

        If InStr(unacceptable, e.KeyChar) > 0 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtPinjamBuku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPinjamBuku.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "50") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtUangDibayarkan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUangDibayarkan.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "50") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
