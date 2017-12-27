Public Class FPenyesuaian

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        Tabel_PenyesuaianTableAdapter.InsertQueryByNomorPenyesuaian(TextboxNomorPenyesuaian.Text,
                                                                    TextboxKodeBarang.Text,
                                                                    TextboxNamaBarang.Text,
                                                                    TextboxJumlah.Text,
                                                                    TextboxKeterangan.Text)
        Tabel_PenyesuaianTableAdapter.UpdateQueryByNomorPenyesuaian(TextboxJumlah.Text,
                                                                         TextboxKodeBarang.Text)
        TextboxNomorPenyesuaian.Text = ""
        TextboxKodeBarang.Text = ""
        TextboxNamaBarang.Text = ""
        TextboxJumlah.Text = ""
        TextboxKeterangan.Text = ""

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Keluar()

    End Sub

End Class