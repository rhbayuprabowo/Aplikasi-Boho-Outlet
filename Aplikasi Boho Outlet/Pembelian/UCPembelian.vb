Public Class UCPembelian

    Private Sub UCPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Tabel_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembelian)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        Dim FormTambah As New FPembelian

        FormTambah.EditData(True, "")
        FormTambah.ShowDialog()
        FormTambah.Dispose()

        Me.Tabel_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembelian)

    End Sub

    Private Sub ImageButtonEdit_Click(sender As Object, e As EventArgs) Handles ImageButtonEdit.Click

        Dim FormTambah As New FPembelian

        FormTambah.EditData(False, "")
        FormTambah.ShowDialog()
        FormTambah.Dispose()

        Me.Tabel_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembelian)

    End Sub

    Private Sub ImageButtonHapus_Click(sender As Object, e As EventArgs) Handles ImageButtonHapus.Click

        Dim NomorPembelian = DataGridPembelian.CurrentRow.Cells(0).Value

        Tabel_PembelianTableAdapter.DeleteQueryByNomorPembelian(NomorPembelian)

        Me.Tabel_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembelian)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembelian)

    End Sub
End Class
