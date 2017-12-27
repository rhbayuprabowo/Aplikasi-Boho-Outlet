Public Class FPemasok

    Private Tambah As Boolean = True

    Public Sub EditData(TambahBaru As Boolean, KodePemasok As String)

        Me.Tambah = TambahBaru

        If (Not TambahBaru) Then

            Dim Data = Tabel_PemasokTableAdapter.GetDataByKodePemasok(KodePemasok)

            TextboxKodePemasok.Text = Data(0).Kode_Pemasok
            TextboxNamaPemasok.Text = Data(0).Nama_Pemasok
            TextboxTelepon.Text = Data(0).Telepon
            TextboxHP.Text = Data(0).HP
            TextboxAlamat.Text = Data(0).Alamat
            TextboxKota.Text = Data(0).Kota
            TextboxKodePos.Text = Data(0).Kode_Pos
            'PictureboxGambar = Data(0).Gambar

        End If

    End Sub

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        If (Tambah) Then
            'Untuk fungsi data baru
            Tabel_PemasokTableAdapter.InsertQueryByKodePemasok(TextboxKodePemasok.Text,
                                                           TextboxNamaPemasok.Text,
                                                           TextboxTelepon.Text,
                                                           TextboxHP.Text,
                                                           TextboxAlamat.Text,
                                                           TextboxKota.Text,
                                                           TextboxKodePos.Text,
                                                           Nothing)



        Else

            Tabel_PemasokTableAdapter.UpdateQueryByKodePemasok(TextboxKodePemasok.Text,
                                                           TextboxNamaPemasok.Text,
                                                           TextboxTelepon.Text,
                                                           TextboxHP.Text,
                                                           TextboxAlamat.Text,
                                                           TextboxKota.Text,
                                                           TextboxKodePos.Text,
                                                           Nothing,
                                                           TextboxKodePemasok.Text)

        End If

        TextboxKodePemasok.Text = ""
        TextboxNamaPemasok.Text = ""
        TextboxTelepon.Text = ""
        TextboxHP.Text = ""
        TextboxAlamat.Text = ""
        TextboxKota.Text = ""
        TextboxKodePos.Text = ""

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Keluar()

    End Sub

End Class