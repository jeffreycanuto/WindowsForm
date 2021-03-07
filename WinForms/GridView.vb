Public Class GridView
    Public SQL As New SQLControl

    Private Sub GridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = MainForm
        LoadGrid()
        LoadCBX()
    End Sub

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM Address;")
            txtCount.Text = SQL.RecordCount
        Else
            SQL.ExecQuery(Query)
        End If


        'ERROR HANDLING
        If SQL.HasException(True) Then
            Exit Sub
        End If

        dvgData.DataSource = SQL.DBDT
    End Sub
    Public Sub LoadCBX()
        'REFRESH COMBOBOX 
        cbxItem.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT CityProvince FROM Address GROUP BY CityProvince ORDER BY 1;")

        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD COMBOBOX
        For Each r As DataRow In SQL.DBDT.Rows
            cbxItem.Items.Add(r("CityProvince").ToString)
        Next
    End Sub

    Private Sub FindCityProv()
        SQL.AddParam("@CityProv", "%" & txtSearch.Text & "%")
        LoadGrid("SELECT * FROM Address WHERE CityProvince LIKE @CityProv; ")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FindCityProv()
    End Sub

    Private Sub dvgData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dvgData.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dvgData.Rows(e.RowIndex)
            txtAddress1.Text = row.Cells(0).Value.ToString
            txtAddress2.Text = row.Cells(1).Value.ToString
            'txtCountry.Text = row.Cells(2).Value.ToString
        End If
    End Sub
    Private Sub dvgData_KeyDown(sender As Object, e As KeyEventArgs) Handles dvgData.KeyDown

        If e.KeyCode = Keys.ControlKey And Keys.Down Or e.KeyCode = Keys.ControlKey And Keys.Up Then
            'Dim row As DataGridViewRow = dvgData.Rows(e.RowIndex)

            Dim crRowIndex As Integer = Me.dvgData.CurrentCell.RowIndex
            txtAddress1.Text = row.Cells(0).Value.ToString
            txtAddress2.Text = row.Cells(1).Value.ToString

            If crRowIndex + 1 = dvgData.Rows.Count Then
                MsgBox("This is last row!")
            Else
                dvgData.Rows(crRowIndex).Selected = False
                dvgData.Rows(crRowIndex + 1).Selected = True
                Me.dvgData.CurrentCell = Me.dvgData(0, crRowIndex + 1)
                txtAddress1.Text = Me.dvgData.Rows(crRowIndex + 1).Cells(0).Value.ToString
                txtAddress2.Text = Me.dvgData.Rows(crRowIndex + 1).Cells(1).Value.ToString
            End If
        End If

    End Sub
End Class