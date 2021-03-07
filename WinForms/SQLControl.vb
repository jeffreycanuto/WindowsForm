Imports System.Data.SqlClient

Public Class SQLControl
    ' CONNECTION
    ' Private DBCon As New SqlConnection("Server=JEFFKYLER;Database=MEDICAL;Trusted_Connection=True")
    Private DBCon As New SqlConnection("Server=JEFFKYLER;Database=MEDICAL;User=sa;Pwd=SQL@dm1n;")
    Private DBCmd As SqlCommand

    ' DB Data - setup a data table using data adapter
    Public DBDA As SqlDataAdapter ''Pass a command to the database sequel data adapter fill up a data table
    Public DBDT As DataTable  ''Data table to retrieve our data from the database

    ' Query Parameters
    Public Params As New List(Of SqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()
    End Sub

    ' Allow connection string override
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    ' EXECUTE QUERY SUB
    ' Public Sub ExecQuery(Query As String, Optional ReturnIdentity As Boolean = False)
    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            'CREATE SQL DB COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            'LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'CLEAR PARAM LIST
            Params.Clear()

            'EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

            ''TO SEE LAST INSERTED RECORD @ Optional value
            'If ReturnIdentity = True Then
            '    Dim ReturnQuery As String = "SELECT @@IDENTITY as LastID;"
            ' @@IDENTITY - SESSION
            ' SCOPE_IDENTITY() - SESSION & SCOPE
            ' IDENT_CURRENT(tablename)
            '    DBCmd = New SqlCommand(ReturnQuery, DBCon)
            '    DBDT = New DataTable
            '    DBDA = New SqlDataAdapter(DBCmd)
            '    RecordCount = DBDA.Fill(DBDT)
            'End If

        Catch ex As Exception
            'CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try

    End Sub

    'ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception")
        Return True
    End Function

End Class
