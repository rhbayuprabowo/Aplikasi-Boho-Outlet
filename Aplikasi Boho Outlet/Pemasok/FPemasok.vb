Imports System.IO
Imports Bunifu.Framework.UI

Public Class FPemasok

    Private Tambah As Boolean = True
    Private fileName As String = ""

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
            If Not Data(0).Gambar Is Nothing Then
                PictureboxPemasok.Image = ConvertByteToImage(Data(0).Gambar)
            End If


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
                                                           ConvertImageToByte(PictureboxPemasok.Image))



        Else

            Tabel_PemasokTableAdapter.UpdateQueryByKodePemasok(TextboxKodePemasok.Text,
                                                           TextboxNamaPemasok.Text,
                                                           TextboxTelepon.Text,
                                                           TextboxHP.Text,
                                                           TextboxAlamat.Text,
                                                           TextboxKota.Text,
                                                           TextboxKodePos.Text,
                                                           ConvertImageToByte(PictureboxPemasok.Image),
                                                           TextboxKodePemasok.Text)

        End If

        TextboxKodePemasok.Text = ""
        TextboxNamaPemasok.Text = ""
        TextboxTelepon.Text = ""
        TextboxHP.Text = ""
        TextboxAlamat.Text = ""
        TextboxKota.Text = ""
        TextboxKodePos.Text = ""
        PictureboxPemasok.Image = Nothing

        Me.Tabel_PemasokTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Pemasok)

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ButtonPilihGambar_Click(sender As Object, e As EventArgs) Handles ButtonPilihGambar.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = "c:\",
            .Filter = "File Gambar(*.bmp;*.jpg;*.jpeg;*.png;)|*.bmp;*.jpg;*.jpeg;*.png",
            .FilterIndex = 2,
            .RestoreDirectory = True,
            .Multiselect = False
        }

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fileName = openFileDialog1.FileName
            PictureboxPemasok.Image = Image.FromFile(fileName)
        End If
    End Sub

    Private Sub ButtonHapusGambar_Click(sender As Object, e As EventArgs) Handles ButtonHapusGambar.Click
        fileName = ""
        PictureboxPemasok.Image = Nothing
    End Sub

    Private Function ConvertImageToByte(img As Image) As Byte()
        Using memoryStream As New MemoryStream
            img.Save(memoryStream, Imaging.ImageFormat.Jpeg)
            Return memoryStream.ToArray
        End Using
    End Function

    Private Function ConvertByteToImage(bit As Byte()) As Image
        Using memoryStream As New MemoryStream(bit)
            Return Image.FromStream(memoryStream)
        End Using
    End Function

    Private Sub ValidatingTextBoxes(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextboxKodePemasok.Validating,
                                                                                                          TextboxNamaPemasok.Validating,
                                                                                                          TextboxAlamat.Validating,
                                                                                                          TextboxHP.Validating,
                                                                                                          TextboxTelepon.Validating,
                                                                                                          TextboxKota.Validating,
                                                                                                          TextboxKodePos.Validating

        Dim TextBoxes = DirectCast(sender, BunifuMaterialTextbox).Text
        Dim IsError As String = ErrorMessageKodePemasok(TextBoxes)
        If Not IsError = "" Then
            TooltipError(DirectCast(sender, BunifuMaterialTextbox), IsError)
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(255, 20, 20)
            e.Cancel = True
        Else
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(48, 48, 48)
        End If
    End Sub

    Private Function ErrorMessageKodePemasok(TextBoxes As String) As String
        If TextBoxes.Length = 0 Then
            Return "Tidak boleh kosong.!!!"
        Else
            Return ""
        End If
    End Function


    Private Sub TooltipError(TextBoxes As BunifuMaterialTextbox, Pesan As String)
        Dim toolTip1 As New ToolTip With {
            .ShowAlways = True
        }
        toolTip1.Show(Pesan, TextBoxes, 0, -25, 1000)
    End Sub

End Class