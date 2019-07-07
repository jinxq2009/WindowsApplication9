Public Class Form1
    Dim sqlConnection1 As SqlClient.SqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strConnet As String = "data source=192.168.43.15;initial catalog =atguigu;user id=sa;password=" + Trim(TextBox1.Text) + ";"
        sqlConnection1 = New System.Data.SqlClient.SqlConnection(strConnet)

        sqlConnection1.Open()
        MsgBox(sqlConnection1.ToString())


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConnection1.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
