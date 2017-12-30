Imports System.IO
Imports Bunifu.Framework.UI

Public Class FBarang

    Private Tambah As Boolean = True
    Private fileName As String = ""

    Public Sub EditData(TambahBaru As Boolean, KodeBarang As String)

        Me.Tambah = TambahBaru

        If (Not TambahBaru) Then

            Dim Data = Tabel_BarangTableAdapter.GetDataByKodeBarang(KodeBarang)

            TextboxKodeBarang.Text = Data(0).Kode_Barang
            TextboxNamaBarang.Text = Data(0).Nama_Barang
            DropdownKategoriBarang.selectedIndex = Array.IndexOf(DropdownKategoriBarang.Items, Data(0).Kategori_Barang)
            DropdownMerekBarang.selectedIndex = Array.IndexOf(DropdownMerekBarang.Items, Data(0).Merek_Barang)
            TextboxJumlah.Text = Data(0).Jumlah
            DropdownSatuan.selectedIndex = Array.IndexOf(DropdownSatuan.Items, Data(0).Satuan)
            TextboxHargaBeli.Text = Data(0).Harga_Beli
            TextboxHargaJual.Text = Data(0).Harga_Jual
            If Not Data(0).Gambar Is Nothing Then
                PictureboxBarang.Image = ConvertByteToImage(Data(0).Gambar)
            End If


        End If

    End Sub

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        If (Tambah) Then
            'Untuk fungsi data baru
            Tabel_BarangTableAdapter.InsertQueryByKodeBarang(TextboxKodeBarang.Text,
                                                           TextboxNamaBarang.Text,
                                                           DropdownKategoriBarang.selectedValue,
                                                           DropdownMerekBarang.selectedValue,
                                                           TextboxJumlah.Text,
                                                           DropdownSatuan.selectedValue,
                                                           TextboxHargaBeli.Text,
                                                           TextboxHargaJual.Text,
                                                           ConvertImageToByte(PictureboxBarang.Image))

        Else

            Tabel_BarangTableAdapter.UpdateQueryByKodeBarang(TextboxKodeBarang.Text,
                                                           TextboxNamaBarang.Text,
                                                           DropdownKategoriBarang.selectedValue,
                                                           DropdownMerekBarang.selectedValue,
                                                           TextboxJumlah.Text,
                                                           DropdownSatuan.selectedValue,
                                                           TextboxHargaBeli.Text,
                                                           TextboxHargaJual.Text,
                                                           ConvertImageToByte(PictureboxBarang.Image),
                                                           TextboxKodeBarang.Text)

        End If

        TextboxKodeBarang.Text = ""
        TextboxNamaBarang.Text = ""
        DropdownKategoriBarang.Clear()
        DropdownMerekBarang.Clear()
        TextboxJumlah.Text = ""
        DropdownSatuan.Clear()
        TextboxHargaBeli.Text = ""
        TextboxHargaJual.Text = ""
        PictureboxBarang.Image = Nothing

    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click

        TextboxKodeBarang.Text = ""
        TextboxNamaBarang.Text = ""
        DropdownKategoriBarang.Clear()
        DropdownMerekBarang.Clear()
        TextboxJumlah.Text = ""
        DropdownSatuan.Clear()
        TextboxHargaBeli.Text = ""
        TextboxHargaJual.Text = ""
        PictureboxBarang.Image = Nothing

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
            PictureboxBarang.Image = Image.FromFile(fileName)
        End If
    End Sub

    Private Sub ButtonHapusGambar_Click(sender As Object, e As EventArgs) Handles ButtonHapusGambar.Click
        fileName = ""
        PictureboxBarang.Image = Nothing
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

    Private Sub ValidatingTextBoxes(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextboxKodeBarang.Validating,
                                                                                                          TextboxNamaBarang.Validating,
                                                                                                          TextboxJumlah.Validating,
                                                                                                          TextboxHargaBeli.Validating,
                                                                                                          TextboxHargaJual.Validating

        Dim TextBoxes = DirectCast(sender, BunifuMaterialTextbox).Text
        Dim IsError As String = ErrorMessageKodeBarang(TextBoxes)
        If Not IsError = "" Then
            TooltipError(DirectCast(sender, BunifuMaterialTextbox), IsError)
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(255, 20, 20)
            e.Cancel = True
        Else
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(48, 48, 48)
        End If
    End Sub

    Private Function ErrorMessageKodeBarang(TextBoxes As String) As String
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