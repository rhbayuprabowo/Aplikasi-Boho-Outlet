Public Class FMenu
    Dim UCPemasok As New UCPemasok
    Dim UCBarang As New UCBarang
    Dim UCPenyesuaian As New UCPenyesuaian
    Dim UCPembelian As New UCPembelian
    Dim UCReturPembelian As New UCReturPembelian
    Dim UCPembayaranHutang As New UCPembayaranHutang
    Dim UCPenjualan As New UCPenjualan

    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PanelMenu.Controls.Add(UCPemasok)
        PanelMenu.Controls.Add(UCBarang)
        PanelMenu.Controls.Add(UCPenyesuaian)
        PanelMenu.Controls.Add(UCPembelian)
        PanelMenu.Controls.Add(UCReturPembelian)
        PanelMenu.Controls.Add(UCPembayaranHutang)
        PanelMenu.Controls.Add(UCPenjualan)

        PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPemasok_Click(sender As Object, e As EventArgs) Handles ButtonPemasok.Click

        PanelMenu.Controls.Item(UCPemasok.Name).Visible = True
        PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonBarang_Click(sender As Object, e As EventArgs) Handles ButtonBarang.Click

        PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        PanelMenu.Controls.Item(UCBarang.Name).Visible = True
        PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPenyesuaian_Click(sender As Object, e As EventArgs) Handles ButtonPenyesuaian.Click

        PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = True
        PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPembelian_Click(sender As Object, e As EventArgs) Handles ButtonPembelian.Click

        PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembelian.Name).Visible = True
        PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonReturPembelian_Click(sender As Object, e As EventArgs) Handles ButtonReturPembelian.Click

        PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = True
        PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPembayaranHutang_Click(sender As Object, e As EventArgs) Handles ButtonPembayaranHutang.Click

        PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = True
        PanelMenu.Controls.Item(UCPenjualan.Name).Visible = False

    End Sub

    Private Sub ButtonPenjualan_Click(sender As Object, e As EventArgs) Handles ButtonPenjualan.Click

        PanelMenu.Controls.Item(UCPemasok.Name).Visible = False
        PanelMenu.Controls.Item(UCBarang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenyesuaian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCReturPembelian.Name).Visible = False
        PanelMenu.Controls.Item(UCPembayaranHutang.Name).Visible = False
        PanelMenu.Controls.Item(UCPenjualan.Name).Visible = True

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