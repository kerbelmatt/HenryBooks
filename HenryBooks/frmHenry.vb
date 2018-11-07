Imports System.Data.SqlClient

Public Class frmHenry
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private myDB As CDB
    Private sqlDR As SqlDataReader

    Private Sub frmHenry_Load(sender As Object, e As EventArgs) Handles Me.Load
        myDB = New CDB
        If Not myDB.OpenDB Then
            Application.Exit()
        End If
        LoadTableNames(cboTable)
    End Sub

    Private Sub LoadTableNames(cbo As ComboBox)
        cbo.Items.Clear()
        sqlDR = myDB.GetDataReaderBySP("sp_getTableList", Nothing)
        While sqlDR.Read
            cbo.Items.Add(sqlDR.Item("name"))
        End While
        sqlDR.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strSP As String = ""
        objSQLCommand.Parameters.Clear()
        objSQLCommand.CommandType = CommandType.StoredProcedure
        Select Case cboTable.SelectedItem.ToString
            Case "AUTHOR"
                strSP = "dbo.sp_getTableAuthor"
            Case "BOOK"
                strSP = "dbo.sp_getTableBook"
            Case "BRANCH"
                'TODO create stored procedures for the rest of the tables
            Case Else
                MessageBox.Show("Invalid table name in btnShow_Click event", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select
        sqlDA = myDB.GetDataAdapterBySP(strSP, Nothing)
        dt = New DataTable
        sqlDA.Fill(dt)
        dgrInventory.DataSource = dt
        dgrInventory.AutoGenerateColumns = True
    End Sub
End Class
