Public Class UCBarang

    Private Sub UCBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_BarangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Barang)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        Dim FormTambah As New FBarang

        FormTambah.EditData(True, "")
        FormTambah.ShowDialog()
        FormTambah.Dispose()

        Me.Tabel_BarangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Barang)

    End Sub

    Private Sub ImageButtonEdit_Click(sender As Object, e As EventArgs) Handles ImageButtonEdit.Click

        Dim KodePemasok = DatagridBarang.Item(0, DatagridBarang.SelectedCells.Item(0).RowIndex).Value

        Dim FormEdit As New FBarang

        FormEdit.EditData(False, KodePemasok)
        FormEdit.ShowDialog()
        FormEdit.Dispose()

        Me.Tabel_BarangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Barang)

    End Sub

    Private Sub ImageButtonHapus_Click(sender As Object, e As EventArgs) Handles ImageButtonHapus.Click

        Dim KodeBarang = DatagridBarang.CurrentRow.Cells(0).Value

        Tabel_BarangTableAdapter.DeleteQueryByKodeBarang(KodeBarang)

        Me.Tabel_BarangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Barang)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_BarangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Barang)

    End Sub
End Class
