Public Class Form1
    Dim sqlConnection1 As SqlClient.SqlConnection
    Dim strConnet As String = "data source=192.168.43.15;initial catalog =atguigu;user id=sa;password=11099wo;"
    Dim strConnet1 As String = "Data Source=192.168.41.15;Initial Catalog=atguigu;Integrated Security=true;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConnection1 = New System.Data.SqlClient.SqlConnection(strConnet)

        sqlConnection1.Open()
        MsgBox(sqlConnection1.ToString())


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConnection1.Close()

    End Sub
End Class
