Imports System.Data
Imports System.Data.SqlClient
Class MainWindow
    Private Sub RadioButton_Checked(sender As Object, e As RoutedEventArgs)
        Dim LS As LoginScreen
        Dim connection As New SqlConnection("Server= Moh's PC; Database = LoginDB; Integrated Security = true")
        Dim command As New SqlCommand("select * from ", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)


        LS = New LoginScreen
        LS.Show()
        LS = Nothing ' Freeing up memory by setting the form memory value to 0, because if too many forms are open, the program could run out of memory and crash'
    End Sub

    Private Sub RadioButton_Checked_1(sender As Object, e As RoutedEventArgs)
        Dim MW As MainWindow
        MW = New MainWindow
        Threading.Thread.Sleep(1500)
        MW.Close()
        Me.Close()
    End Sub
End Class
