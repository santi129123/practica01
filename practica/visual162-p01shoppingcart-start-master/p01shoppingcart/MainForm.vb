Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub BOTO1_Click(sender As Object, e As EventArgs) Handles BOTONHOMBRE.Click
        BOTONHOMBRE.ForeColor = Color.SteelBlue
        BOTONMUJERES.ForeColor = Color.Black
        BOTONCALZADO.ForeColor = Color.Black
        BOTONACSESORIOS.ForeColor = Color.Black
    End Sub

    Private Sub BOTONMUJERES_Click(sender As Object, e As EventArgs) Handles BOTONMUJERES.Click
        BOTONHOMBRE.ForeColor = Color.Black
        BOTONMUJERES.ForeColor = Color.SteelBlue
        BOTONCALZADO.ForeColor = Color.Black
        BOTONACSESORIOS.ForeColor = Color.Black
    End Sub

    Private Sub BOTONCALZADO_Click(sender As Object, e As EventArgs) Handles BOTONCALZADO.Click
        BOTONHOMBRE.ForeColor = Color.Black
        BOTONMUJERES.ForeColor = Color.Black
        BOTONCALZADO.ForeColor = Color.SteelBlue
        BOTONACSESORIOS.ForeColor = Color.Black
    End Sub

    Private Sub BOTONACSESORIOS_Click(sender As Object, e As EventArgs) Handles BOTONACSESORIOS.Click
        BOTONHOMBRE.ForeColor = Color.Black
        BOTONMUJERES.ForeColor = Color.Black
        BOTONCALZADO.ForeColor = Color.Black
        BOTONACSESORIOS.ForeColor = Color.SteelBlue
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        lblTituloProducto.Text = nombrecamisa.Text

        lblprecio.Text = lblprecio1.Text
        bpCover.Image = ilProductos.Images.Item(0)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        lblTituloProducto.Text = lbl2.Text

        lblprecio.Text = lblprecio2.Text
        bpCover.Image = ilProductos.Images.Item(1)


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        lblTituloProducto.Text = lbl3.Text

        lblprecio.Text = lblprecio3.Text
        bpCover.Image = ilProductos.Images.Item(2)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        lblTituloProducto.Text = lbl4.Text

        lblprecio.Text = lblprecio4.Text
        bpCover.Image = ilProductos.Images.Item(3)

    End Sub
End Class