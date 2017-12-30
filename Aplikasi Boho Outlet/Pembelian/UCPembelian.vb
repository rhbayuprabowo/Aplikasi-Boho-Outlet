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

        Dim NomorPembelian = DataGridPembelian.Item(0, DataGridPembelian.SelectedCells.Item(0).RowIndex).Value

        Dim FormTambah As New FPembelian

        FormTambah.EditData(False, NomorPembelian)
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

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_PembelianTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Pembelian, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

End Class
