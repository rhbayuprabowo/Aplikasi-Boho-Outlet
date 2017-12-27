Public Class FPembayaramHutang

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        Tabel_Pembayaran_HutangTableAdapter.InsertQueryByNomorPembayaran(TextboxNomorPembayaranHutang.Text,
                                                                         DatepickerTanggalPembayaran.Value.ToShortDateString(),
                                                                         TextboxNomorPembelian.Text,
                                                                         TextboxKodePemasok.Text,
                                                                         TextboxNamaPemasok.Text,
                                                                         DropdownStatus.selectedValue)

        TextboxNomorPembayaranHutang.Text = ""
        DatepickerTanggalPembayaran.Value = Date.Now
        TextboxNomorPembelian.Text = ""
        TextboxKodePemasok.Text = ""
        TextboxNamaPemasok.Text = ""
        DropdownStatus.Clear()

    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click

        TextboxNomorPembayaranHutang.Text = ""
        DatepickerTanggalPembayaran.Value = Date.Now
        TextboxNomorPembelian.Text = ""
        TextboxKodePemasok.Text = ""
        TextboxNamaPemasok.Text = ""
        DropdownStatus.Clear()

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Keluar()

    End Sub

End Class