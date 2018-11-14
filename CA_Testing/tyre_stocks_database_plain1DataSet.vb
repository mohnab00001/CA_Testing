Partial Class tyre_stocks_database_plain1DataSet
    Partial Public Class StocksDataTable
        Private Sub StocksDataTable_ColumnChanging(sender As Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
