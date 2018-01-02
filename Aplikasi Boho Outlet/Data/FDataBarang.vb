Public Class FDataBarang
    Public Property Kode_Barang As String
    Public Property Nama_Barang As String
    Public Property Satuan As String
    Public Property Harga As String

    Private Sub FDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_BarangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Barang)

    End Sub

    Private Sub DatagridData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridData.CellDoubleClick
        If e.RowIndex >= 0 Then
            Kode_Barang = DatagridData.Item(0, e.RowIndex).Value
            Nama_Barang = DatagridData.Item(1, e.RowIndex).Value
            Satuan = DatagridData.Item(5, e.RowIndex).Value
            Harga = DatagridData.Item(6, e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_BarangTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Barang, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_BarangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Barang)

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Me.Close()

    End Sub
End Class