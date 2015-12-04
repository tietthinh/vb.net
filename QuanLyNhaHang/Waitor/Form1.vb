Public Class Form1
    Private path As String = My.Application.Info.DirectoryPath
    ' Effect
    ' Hiệu ứng khi nhấp vào
    Private Sub table01_MouseDown(sender As Object, e As MouseEventArgs) Handles table01.MouseDown
        table01.BackColor = Color.Yellow
    End Sub

    Private Sub table01_MouseUp(sender As Object, e As MouseEventArgs) Handles table01.MouseUp
        table01.BackColor = Color.White
    End Sub
    Private Sub table02_MouseDown(sender As Object, e As MouseEventArgs) Handles table02.MouseDown
        table02.BackColor = Color.Yellow
    End Sub

    Private Sub table02_MouseUp(sender As Object, e As MouseEventArgs) Handles table02.MouseUp
        table02.BackColor = Color.White
    End Sub
    Private Sub table03_MouseDown(sender As Object, e As MouseEventArgs) Handles table03.MouseDown
        table03.BackColor = Color.Yellow
    End Sub

    Private Sub table03_MouseUp(sender As Object, e As MouseEventArgs) Handles table03.MouseUp
        table03.BackColor = Color.White
    End Sub

    Private Sub table04_MouseDown(sender As Object, e As MouseEventArgs) Handles table04.MouseDown
        table04.BackColor = Color.Yellow
    End Sub

    Private Sub table04_MouseUp(sender As Object, e As MouseEventArgs) Handles table04.MouseUp
        table04.BackColor = Color.White
    End Sub

    Private Sub table05_MouseDown(sender As Object, e As MouseEventArgs) Handles table05.MouseDown
        table05.BackColor = Color.Yellow
    End Sub

    Private Sub table05_MouseUp(sender As Object, e As MouseEventArgs) Handles table05.MouseUp
        table05.BackColor = Color.White
    End Sub

    Private Sub table06_MouseDown(sender As Object, e As MouseEventArgs) Handles table06.MouseDown
        table06.BackColor = Color.Yellow
    End Sub

    Private Sub table06_MouseUp(sender As Object, e As MouseEventArgs) Handles table06.MouseUp
        table06.BackColor = Color.White
    End Sub
    Private Sub table07_MouseDown(sender As Object, e As MouseEventArgs) Handles table07.MouseDown
        table07.BackColor = Color.Yellow
    End Sub

    Private Sub table07_MouseUp(sender As Object, e As MouseEventArgs) Handles table07.MouseUp
        table07.BackColor = Color.White
    End Sub

    Private Sub table08_MouseDown(sender As Object, e As MouseEventArgs) Handles table08.MouseDown
        table08.BackColor = Color.Yellow
    End Sub

    Private Sub table08_MouseUp(sender As Object, e As MouseEventArgs) Handles table08.MouseUp
        table08.BackColor = Color.White
    End Sub

    Private Sub table09_MouseDown(sender As Object, e As MouseEventArgs) Handles table09.MouseDown
        table09.BackColor = Color.Yellow
    End Sub

    Private Sub table09_MouseUp(sender As Object, e As MouseEventArgs) Handles table09.MouseUp
        table09.BackColor = Color.White
    End Sub

    'Show content
    'Hiển thị nội dung
    Private Sub table01_Click(sender As Object, e As EventArgs) Handles table01.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 1"
        LoadMenu()
    End Sub

    Private Sub table02_Click(sender As Object, e As EventArgs) Handles table02.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 2"
        LoadMenu()
    End Sub

    Private Sub table03_Click(sender As Object, e As EventArgs) Handles table03.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 3"
        LoadMenu()
    End Sub

    Private Sub table04_Click(sender As Object, e As EventArgs) Handles table04.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 4"
        LoadMenu()
    End Sub
    Private Sub table05_Click(sender As Object, e As EventArgs) Handles table05.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 5"
        LoadMenu()
    End Sub
    Private Sub table06_Click(sender As Object, e As EventArgs) Handles table06.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 6"
        LoadMenu()
    End Sub
    Private Sub table07_Click(sender As Object, e As EventArgs) Handles table07.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 7"
        LoadMenu()
    End Sub
    Private Sub table08_Click(sender As Object, e As EventArgs) Handles table08.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 8"
        LoadMenu()
    End Sub
    Private Sub table09_Click(sender As Object, e As EventArgs) Handles table09.Click
        lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN 9"
        LoadMenu()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadImg()
    End Sub
    Private Sub LoadMenu()
        listMenu.Clear()
        Dim imgList As New ImageList
        Dim bow As String = IO.Path.Combine(path, "..\..\img\bow.png")
        Dim dish As String = IO.Path.Combine(path, "..\..\img\dishs.png")
        imgList.Images.Add(Image.FromFile(bow))
        imgList.Images.Add(Image.FromFile(dish))
        listMenu.LargeImageList = imgList
        listMenu.Items.Add("Mì gói")
        listMenu.Items.Add("Cơm chay")
        listMenu.Items(0).ImageIndex = 0
        listMenu.Items(1).ImageIndex = 1
    End Sub
    Private Sub LoadImg()
        Dim border As String = IO.Path.Combine(path, "..\..\img\border.png")
        Dim table01Img As String = IO.Path.Combine(path, "..\..\img\table1.png")
        Dim table02Img As String = IO.Path.Combine(path, "..\..\img\table2.png")
        Dim table03Img As String = IO.Path.Combine(path, "..\..\img\table3.png")
        Dim table04Img As String = IO.Path.Combine(path, "..\..\img\table4.png")
        Dim table05Img As String = IO.Path.Combine(path, "..\..\img\table5.png")
        Dim table06Img As String = IO.Path.Combine(path, "..\..\img\table6.png")
        Dim table07Img As String = IO.Path.Combine(path, "..\..\img\table7.png")
        Dim table08Img As String = IO.Path.Combine(path, "..\..\img\table8.png")
        Dim table09Img As String = IO.Path.Combine(path, "..\..\img\table9.png")
        picBorder.ImageLocation = border
        table01.ImageLocation = table01Img
        table02.ImageLocation = table02Img
        table03.ImageLocation = table03Img
        table04.ImageLocation = table04Img
        table05.ImageLocation = table05Img
        table06.ImageLocation = table06Img
        table07.ImageLocation = table07Img
        table08.ImageLocation = table08Img
        table09.ImageLocation = table09Img

    End Sub
    Private Sub listMenu_Click(sender As Object, e As EventArgs) Handles listMenu.Click
        Dim add As New Add
        add.Show()
    End Sub

    Private Sub dtgList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellContentClick
        Dim add As New Add
        add.Show()
    End Sub
End Class
