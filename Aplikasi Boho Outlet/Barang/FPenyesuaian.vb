Imports System.IO
Imports Bunifu.Framework.UI
Public Class FPenyesuaian

    Private fileName As String = ""

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        Tabel_PenyesuaianTableAdapter.InsertQueryByNomorPenyesuaian(TextboxNomorPenyesuaian.Text,
                                                                    TextboxKodeBarang.Text,
                                                                    TextboxNamaBarang.Text,
                                                                    TextboxJumlah.Text,
                                                                    TextboxKeterangan.Text)

        Tabel_PenyesuaianTableAdapter.UpdateQueryByNomorPenyesuaian(TextboxJumlah.Text,
                                                                    TextboxKodeBarang.Text)
        TextboxNomorPenyesuaian.Text = ""
        TextboxKodeBarang.Text = ""
        TextboxNamaBarang.Text = ""
        TextboxJumlah.Text = ""
        TextboxKeterangan.Text = ""

    End Sub

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ValidatingTextBoxes(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextboxNomorPenyesuaian.Validating,
                                                                                                         TextboxKodeBarang.Validating,
                                                                                                         TextboxNamaBarang.Validating,
                                                                                                         TextboxJumlah.Validating,
                                                                                                         TextboxKeterangan.Validating

        Dim TextBoxes = DirectCast(sender, BunifuMaterialTextbox).Text
        Dim IsError As String = ErrorMessageNomorPenyesuaian(TextBoxes)
        If Not IsError = "" Then
            TooltipError(DirectCast(sender, BunifuMaterialTextbox), IsError)
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(255, 20, 20)
            e.Cancel = True
        Else
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(48, 48, 48)
        End If
    End Sub

    Private Function ErrorMessageNomorPenyesuaian(TextBoxes As String) As String
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

    Private Sub FPenyesuaian_Load(sender As Object, e As EventArgs) Handles Me.Load

        Using data_tabel = Tabel_PenyesuaianTableAdapter.GetData()
            If data_tabel.Rows.Count = 0 Then
                TextboxNomorPenyesuaian.Text = "NPENY-" + 1.ToString("D4")
            Else
                Dim NomorArray = data_tabel(data_tabel.Count - 1).Nomor_Penyesuaian.Split("-"c)
                Dim NomorPenyesuaian = Convert.ToInt32(NomorArray(1)) + 1
                TextboxNomorPenyesuaian.Text = "NPENY-" + NomorPenyesuaian.ToString("D4")
            End If
        End Using

    End Sub

    Private Sub ImageButtonKodeBarang_Click(sender As Object, e As EventArgs) Handles ImageButtonKodeBarang.Click

        Dim FormData = New FDataBarang
        FormData.ShowDialog()
        TextboxKodeBarang.Text = FormData.Kode_Barang
        TextboxNamaBarang.Text = FormData.Nama_Barang
        FormData.Dispose()

    End Sub
End Class