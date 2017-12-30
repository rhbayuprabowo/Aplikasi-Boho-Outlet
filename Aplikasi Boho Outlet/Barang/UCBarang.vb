Imports System.IO
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

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_BarangTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Barang, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

    Private Function ConvertByteToImage(bit As Byte()) As Image
        Using memoryStream As New MemoryStream(bit)
            Return Image.FromStream(memoryStream)
        End Using
    End Function


    Private Sub DatagridBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridBarang.CellClick
        If DatagridBarang.CurrentRow.Index > -1 Then
            With DatagridBarang
                LabelKodeBarang.Text = .Item(0, DatagridBarang.CurrentRow.Index).Value
                LabelNamaBarang.Text = .Item(1, DatagridBarang.CurrentRow.Index).Value
                LabelKategoriBarang.Text = .Item(2, DatagridBarang.CurrentRow.Index).Value
                LabelMerekBarang.Text = .Item(3, DatagridBarang.CurrentRow.Index).Value
                LabelJumlah.Text = .Item(4, DatagridBarang.CurrentRow.Index).Value
                LabelHargaBeli.Text = .Item(6, DatagridBarang.CurrentRow.Index).Value
                LabelHargaJual.Text = .Item(7, DatagridBarang.CurrentRow.Index).Value
                If Not IsDBNull(.Item(8, DatagridBarang.CurrentRow.Index).Value) Then
                    PictureboxBarang.Image = ConvertByteToImage(.Item(8, DatagridBarang.CurrentRow.Index).Value)
                Else
                    PictureboxBarang.Image = Nothing
                End If
            End With
        End If
    End Sub
End Class
