Public Class UCPemasok

    Private Sub UCPemasok_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        Dim FormTambah As New FPemasok

        FormTambah.EditData(True, "")
        FormTambah.ShowDialog()
        FormTambah.Dispose()

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub

    Private Sub ImageButtonEdit_Click(sender As Object, e As EventArgs) Handles ImageButtonEdit.Click

        Dim KodePemasok = DatagridPemasok.Item(0, DatagridPemasok.SelectedCells.Item(0).RowIndex).Value

        Dim FormEdit As New FPemasok

        FormEdit.EditData(False, KodePemasok)
        FormEdit.ShowDialog()
        FormEdit.Dispose()

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub

    Private Sub ImageButtonHapus_Click(sender As Object, e As EventArgs) Handles ImageButtonHapus.Click

        Dim KodePemasok = DatagridPemasok.CurrentRow.Cells(0).Value

        Tabel_PemasokTableAdapter.DeleteQueryByKodePemasok(KodePemasok)

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub
End Class
