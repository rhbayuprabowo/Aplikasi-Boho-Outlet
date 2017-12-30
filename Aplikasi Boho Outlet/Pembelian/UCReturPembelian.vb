Public Class UCReturPembelian

    Private Sub UCReturPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_Retur_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Retur_Pembelian)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        FReturPembelian.ShowDialog()

        Me.Tabel_Retur_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Retur_Pembelian)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_Retur_PembelianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Retur_Pembelian)

    End Sub

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_Retur_PembelianTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Retur_Pembelian, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

End Class
