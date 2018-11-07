Imports System.Data.SqlClient

Module modDB
    Public objSQLConn As SqlConnection
    Public objSQLCommand As SqlCommand
    Public gstrConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=D:\HenryBooks\HBooks_2017.mdf;Integrated Security=True"
End Module
