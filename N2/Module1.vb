Imports System.Data.OleDb
Imports System.Text

Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As New ADODB.Command
    Public usr As String
    Public conUp As Boolean

    Sub db_connect()

        conUp = False
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySql ODBC 3.51 Driver};SERVER=127.0.0.1;DATABASE=db_artesanatos-julia;UID=user;PWD=mysqldbcon;port=3307;option=3")
            conUp = True
            sql.ActiveConnection = db
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco de dados" + vbNewLine + "Se este erro persistir informe a gerência", vbOKOnly + vbExclamation, "Erro 1")
            Application.Exit()
        End Try
    End Sub
    Sub clean_up()
        If conUp Then
            db.Close()
        End If
    End Sub
    Function get_cell_content(grid As Object, row As Integer, column As Integer) As String
        Return grid.Rows(row).Cells(column).Value.ToString
    End Function

    Sub get_data(s As String, dtgr As DataGridView)
        Try
            sql.CommandText = s
            rs = sql.Execute()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Erro")
        End Try

        Dim adapter As New OleDbDataAdapter()
        Dim dttb As New DataTable

        adapter.Fill(dttb, rs)
        dtgr.DataSource = Nothing
        dtgr.DataSource = dttb
        dtgr.Refresh()
    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As Random = New Random()
        Return Generator.Next(Min, Max)
    End Function

    Sub prepare(param As String, type As ADODB.DataTypeEnum, size As Integer, value As String)
        sql.Parameters.Append(sql.CreateParameter(param, type,, size, value))
    End Sub

End Module
