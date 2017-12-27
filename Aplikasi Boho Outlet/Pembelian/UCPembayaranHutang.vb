Public Class UCPembayaranHutang

    Private Sub UCPembayaranHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_Pembayaran_HutangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembayaran_Hutang)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        FPembayaramHutang.ShowDialog()

        Me.Tabel_Pembayaran_HutangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembayaran_Hutang)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_Pembayaran_HutangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembayaran_Hutang)

    End Sub
End Class
