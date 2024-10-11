Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnOddEvenNumbers_Click(sender As Object, e As EventArgs) Handles btnOddEvenNumbers.Click

        ' Connection string to connect to MySQL database
        Dim connectionString As String = "Server=localhost;Database=dbuser;User ID=root;Password=12Yellow34!"

        Dim number As Integer = Convert.ToInt32(txtCheckOddEven.Text)

        Using conn As New MySqlConnection(connectionString)

            ' Open the connection
            conn.Open()

            ' Query to get the output message
            Using cmd As New MySqlCommand("sp_check_even_odd", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Add the input parameter for the stored procedure
                cmd.Parameters.AddWithValue("@input_number", number)

                ' Add the output parameter for the result message
                Dim resultParam As New MySqlParameter("@result_message", MySqlDbType.VarChar)
                resultParam.Direction = ParameterDirection.Output
                resultParam.Size = 50  ' Set the size to match the expected output length
                cmd.Parameters.Add(resultParam)

                ' Execute the stored procedure
                cmd.ExecuteNonQuery()

                ' Execute the query and read the result
                Dim message As String = cmd.Parameters("@result_message").Value.ToString()
                MessageBox.Show(message)

            End Using

        End Using

    End Sub
End Class
