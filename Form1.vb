Imports System.Data.Odbc

Public Class Form1

    Private Sub ViewData()
        Connect()
        Da = New OdbcDataAdapter("Select * from mahasiswa", Conn) 'Ambil data dari database
        Ds = New DataSet() 'Buat object dataset
        Ds.Clear() 'Bersihkan dataset
        Da.Fill(Ds, "mahasiswa") 'Apa yang mau di-fill? Ds, pake apa? "mahasiswa"
        TableStudents.DataSource = Ds.Tables("mahasiswa") 'Isi toolbox TableStudents dengan Dataset
    End Sub

    Private Sub ClearData()
        InputAddress.Text = ""
        InputName.Text = ""
        InputNIM.Text = ""
        InputPhone.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewData()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If InputNIM.Text = "" Or InputName.Text = "" Or InputAddress.Text = "" Or InputPhone.Text = "" Then
            MsgBox("Isi semua isian dengan benar")
        Else
            Try
                Dim query = "INSERT INTO mahasiswa (nim, name, address, phone) VALUES ('" & InputNIM.Text & "', '" & InputName.Text & "', '" & InputAddress.Text & "', '" & InputPhone.Text & "')"
                cmd = New OdbcCommand(query, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan!")
                ViewData()
                ClearData()
            Catch ex As Exception
                MsgBox("Input Gagal, " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If InputNIM.Text = "" Or InputName.Text = "" Or InputAddress.Text = "" Or InputPhone.Text = "" Then
            MsgBox("Isi semua isian dengan benar")

        Else

            Try
                Dim query = $"UPDATE mahasiswa SET name = '{InputName.Text}', address = '{InputAddress.Text}', phone = '{InputPhone.Text}' WHERE nim = '{InputNIM.Text}'"
                cmd = New OdbcCommand(query, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diedit!")
                ViewData()
                ClearData()
            Catch ex As Exception
                MsgBox("Edit Gagal, " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            Dim confrim = MessageBox.Show("Apa Anda yakin menghapusnya?", "Peringatan", MessageBoxButtons.YesNo)

            If confrim = DialogResult.Yes Then
                Dim query = $"DELETE FROM mahasiswa WHERE nim = {InputNIM.Text}"
                cmd = New OdbcCommand(query, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
                ViewData()
                ClearData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub InputNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputNIM.KeyPress
        Try
            If e.KeyChar = Chr(13) Then 'Chr(13) adalah tombol Enter. Ini berdasarkan kode ASCII
                Dim query = $"SELECT * FROM mahasiswa WHERE nim = {InputNIM.Text}"
                cmd = New OdbcCommand(query, Conn)

                Rd = cmd.ExecuteReader
                Rd.Read()

                If Rd.HasRows Then
                    InputName.Text = Rd.Item("name")
                    InputAddress.Text = Rd.Item("address")
                    InputPhone.Text = Rd.Item("phone")
                Else
                    MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class
