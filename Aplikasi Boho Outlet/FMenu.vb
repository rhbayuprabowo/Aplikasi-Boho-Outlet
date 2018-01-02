Public Class FMenu


    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PanelMenu.Controls.Add(UCPemasok)
        'PanelMenu.Controls.Add(UCBarang)
        'PanelMenu.Controls.Add(UCPenyesuaian)
        'PanelMenu.Controls.Add(UCPembelian)
        'PanelMenu.Controls.Add(UCReturPembelian)
        'PanelMenu.Controls.Add(UCPembayaranHutang)
        'PanelMenu.Controls.Add(UCPenjualan)

        'PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        'PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPemasok_Click(sender As Object, e As EventArgs) Handles ButtonPemasok.Click
        Dim UCPemasok As New UCPemasok
        For i = 0 To PanelMenu.Controls.Count - 1
            PanelMenu.Controls.RemoveAt(i)
        Next
        PanelMenu.Controls.Add(UCPemasok)


        'PanelMenu.Controls.Item(UCPemasok.Name).Visible = True
        'PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonBarang_Click(sender As Object, e As EventArgs) Handles ButtonBarang.Click

        Dim UCBarang As New UCBarang

        For i = 0 To PanelMenu.Controls.Count - 1
            PanelMenu.Controls.RemoveAt(i)
        Next
        PanelMenu.Controls.Add(UCBarang)

        'PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        'PanelMenu.Controls.Item(UCBarang.Name).Visible = True
        'PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPenyesuaian_Click(sender As Object, e As EventArgs) Handles ButtonPenyesuaian.Click

        Dim UCPenyesuaian As New UCPenyesuaian

        For i = 0 To PanelMenu.Controls.Count - 1
            PanelMenu.Controls.RemoveAt(i)
        Next
        PanelMenu.Controls.Add(UCPenyesuaian)



        'PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        'PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = True
        'PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPembelian_Click(sender As Object, e As EventArgs) Handles ButtonPembelian.Click

        Dim UCPembelian As New UCPembelian

        For i = 0 To PanelMenu.Controls.Count - 1
            PanelMenu.Controls.RemoveAt(i)
        Next
        PanelMenu.Controls.Add(UCPembelian)



        'PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        'PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembelian.Name).Visible = True
        'PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonReturPembelian_Click(sender As Object, e As EventArgs) Handles ButtonReturPembelian.Click

        Dim UCReturPembelian As New UCReturPembelian

        For i = 0 To PanelMenu.Controls.Count - 1
            PanelMenu.Controls.RemoveAt(i)
        Next
        PanelMenu.Controls.Add(UCReturPembelian)



        'PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        'PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = True
        'PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPembayaranHutang_Click(sender As Object, e As EventArgs) Handles ButtonPembayaranHutang.Click

        Dim UCPembayaranHutang As New UCPembayaranHutang

        For i = 0 To PanelMenu.Controls.Count - 1
            PanelMenu.Controls.RemoveAt(i)
        Next
        PanelMenu.Controls.Add(UCPembayaranHutang)


        'PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        'PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = True
        'PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPenjualan_Click(sender As Object, e As EventArgs) Handles ButtonPenjualan.Click

        Dim UCPenjualan As New UCPenjualan
        For i = 0 To PanelMenu.Controls.Count - 1
            PanelMenu.Controls.RemoveAt(i)
        Next
        PanelMenu.Controls.Add(UCPenjualan)




        'PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        'PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        'PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        'PanelMenu.Controls.Item(UCPenjualan.Name).Visible = True

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Application.Exit()

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Application.Exit()

    End Sub

    Private Sub ImageButtonMemperkecil_Click(sender As Object, e As EventArgs) Handles ImageButtonMemperkecil.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class