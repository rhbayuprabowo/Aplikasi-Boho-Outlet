Imports System.IO

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

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_PemasokTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Pemasok, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

    Private Function ConvertByteToImage(bit As Byte()) As Image
        Using memoryStream As New MemoryStream(bit)
            Return Image.FromStream(memoryStream)
        End Using
    End Function

    Private Sub DatagridPemasok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridPemasok.CellClick

        If DatagridPemasok.CurrentRow.Index > -1 Then
            With DatagridPemasok
                LabelKodePemasok.Text = .Item(0, DatagridPemasok.CurrentRow.Index).Value
                LabelNamaPemasok.Text = .Item(1, DatagridPemasok.CurrentRow.Index).Value
                LabelTelepon.Text = .Item(2, DatagridPemasok.CurrentRow.Index).Value
                LabelHP.Text = .Item(3, DatagridPemasok.CurrentRow.Index).Value
                LabelAlamat.Text = .Item(4, DatagridPemasok.CurrentRow.Index).Value
                LabelKota.Text = .Item(5, DatagridPemasok.CurrentRow.Index).Value
                LabelKodePos.Text = .Item(6, DatagridPemasok.CurrentRow.Index).Value
                If Not IsDBNull(.Item(7, DatagridPemasok.CurrentRow.Index).Value) Then
                    PictureboxPemasok.Image = ConvertByteToImage(.Item(7, DatagridPemasok.CurrentRow.Index).Value)
                Else
                    PictureboxPemasok.Image = Nothing
                End If
            End With
        End If

    End Sub
End Class
