Public Class FMasuk

    Sub Masuk()

        Dim HitungMasuk = Tabel_MasukTableAdapter.GetDataByNamaPengguna(TextboxNamaPengguna.Text,
                                                                        TextboxKataSandi.Text).Count
        If HitungMasuk = 1 Then

            Me.Hide()

            FMenu.Show()
        Else

            MessageBox.Show("Nama Pengguna dan Kata Sandi yang Anda masukkan salah. Silahkan hubungi administrator untuk dapat login", "Program Penjualan, Pembelian dan Persediaan", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub ButtonMasuk_Click(sender As Object, e As EventArgs) Handles ButtonMasuk.Click

        Masuk()

    End Sub

    Private Sub TextboxNamaPengguna_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxNamaPengguna.KeyDown

        If e.KeyCode = Keys.Enter Then
            Masuk()
        End If

    End Sub

    Private Sub TextboxKataSandi_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxKataSandi.KeyDown

        If e.KeyCode = Keys.Enter Then
            Masuk()
        End If

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Application.Exit()

    End Sub

End Class
