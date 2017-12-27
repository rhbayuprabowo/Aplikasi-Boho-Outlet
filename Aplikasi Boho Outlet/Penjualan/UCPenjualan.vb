Public Class UCPenjualan

    Private Sub UCPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        Dim FormTambah As New FPenjualan

        FormTambah.EditData(True, "")
        FormTambah.ShowDialog()
        FormTambah.Dispose()

        Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    End Sub

    Private Sub ImageButtonEdit_Click(sender As Object, e As EventArgs) Handles ImageButtonEdit.Click

        Dim FormTambah As New FPenjualan

        FormTambah.EditData(False, "")
        FormTambah.ShowDialog()
        FormTambah.Dispose()

        Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    End Sub

    Private Sub ImageButtonHapus_Click(sender As Object, e As EventArgs) Handles ImageButtonHapus.Click

        Dim NomorPenjualan = DataGridPenjualan.CurrentRow.Cells(0).Value

        Tabel_PenjualanTableAdapter.DeleteQueryByNomorPenjualan(NomorPenjualan)

        Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    End Sub

End Class
