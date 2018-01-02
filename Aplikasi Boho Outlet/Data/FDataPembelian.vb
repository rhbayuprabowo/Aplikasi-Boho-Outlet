Public Class FDataPembelian
    Public Property Nomor_Pembelian As String
    Public Property Kode_Barang As String
    Public Property Nama_Barang As String
    Public Property Harga As String

    Private Sub FDataPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembelian)

    End Sub

    Private Sub DatagridData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridData.CellDoubleClick
        If e.RowIndex >= 0 Then
            Nomor_Pembelian = DatagridData.Item(0, e.RowIndex).Value
            Kode_Barang = DatagridData.Item(5, e.RowIndex).Value
            Nama_Barang = DatagridData.Item(6, e.RowIndex).Value
            Harga = DatagridData.Item(9, e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_PembelianTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Pembelian, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembelian)

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click
        Me.Close()
    End Sub
End Class