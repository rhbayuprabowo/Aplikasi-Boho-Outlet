Public Class UCReturPembelian

    Private Sub UCReturPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_Retur_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Retur_Pembelian)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        FReturPembelian.ShowDialog()

        Me.Tabel_Retur_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Retur_Pembelian)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_Retur_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Retur_Pembelian)

    End Sub

End Class
