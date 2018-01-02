Public Class UCPenjualan

    Private Sub UCPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        'Dim FormTambah As New FPenjualan

        'FormTambah.EditData(True, "")
        FPenjualan.ShowDialog()
        FPenjualan.Dispose()

        Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    End Sub

    'Private Sub ImageButtonEdit_Click(sender As Object, e As EventArgs) Handles ImageButtonEdit.Click

    '    Dim NomorPenjualan = DataGridPenjualan.Item(0, DataGridPenjualan.SelectedCells.Item(0).RowIndex).Value

    '    Dim FormTambah As New FPenjualan

    '    FormTambah.EditData(False, NomorPenjualan)
    '    FormTambah.ShowDialog()
    '    FormTambah.Dispose()

    '    Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    'End Sub

    'Private Sub ImageButtonHapus_Click(sender As Object, e As EventArgs) Handles ImageButtonHapus.Click

    '    Dim NomorPenjualan = DataGridPenjualan.CurrentRow.Cells(0).Value

    '    Tabel_PenjualanTableAdapter.DeleteQueryByNomorPenjualan(NomorPenjualan)

    '    Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    'End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_PenjualanTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penjualan)

    End Sub

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_PenjualanTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Penjualan, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

End Class
