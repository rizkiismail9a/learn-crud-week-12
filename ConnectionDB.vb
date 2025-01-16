Imports System.Data.Odbc


Module ConnectionDB
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public cmd As OdbcCommand
    Public Str As String
    Public Conn As New OdbcConnection("DSN=kampusbaru")

    Public Sub Connect()
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                'MsgBox("Koneksi Berhasil")
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal")
        End Try
    End Sub
End Module
