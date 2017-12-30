Public Class UCPembayaranHutang

    Private Sub UCPembayaranHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tabel_Pembayaran_HutangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembayaran_Hutang)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        FPembayaramHutang.ShowDialog()

        Me.Tabel_Pembayaran_HutangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembayaran_Hutang)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_Pembayaran_HutangTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pembayaran_Hutang)

    End Sub

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_Pembayaran_HutangTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Pembayaran_Hutang, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

End Class
