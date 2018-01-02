Public Class FDataPemasok
    Public Property Kode_Pemasok As String
    Public Property Nama_Pemasok As String

    Private Sub FDataPemasok_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub

    Private Sub DatagridData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridData.CellDoubleClick
        If e.RowIndex >= 0 Then
            Kode_Pemasok = DatagridData.Item(0, e.RowIndex).Value
            Nama_Pemasok = DatagridData.Item(1, e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_PemasokTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Pemasok, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Me.Close()

    End Sub
End Class