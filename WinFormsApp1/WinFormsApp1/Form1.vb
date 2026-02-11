Imports System.DirectoryServices.ActiveDirectory
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("Name", "ชื่อสินค้า")
        DataGridView1.Columns.Add("price", "ราคา")
        DataGridView1.Columns.Add("vat", "ภาษี")
        DataGridView1.Columns.Add("total", "ราคาสุทธิ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Or Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("กรุณาใส่ราคาให้ถูกต้อง", "ระวัง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Clear()
            TextBox1.Focus()
            Return
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("กรุณาใส่ชื่อสินค้าให้ถูกต้อง", "ระวัง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Clear()
            TextBox2.Focus()
            Return

            Dim price As Decimal = TextBox1.Text
        Dim vat As Decimal = price * 0.07
        Dim total As Decimal = price + vat
        Dim ttt As Decimal = 0
        DataGridView1.Rows.Add(TextBox2.Text, price.ToString("N2"), vat.ToString("N2"), total.ToString("N2"))
        TextBox2.Clear()
        TextBox1.Clear()
        TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("ไม่มีข้อมูลสำหรับส่งออก", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return
    End Sub
End Class
