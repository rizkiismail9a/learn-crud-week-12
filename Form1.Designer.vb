<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        InputNIM = New TextBox()
        InputName = New TextBox()
        InputAddress = New TextBox()
        InputPhone = New TextBox()
        TableStudents = New DataGridView()
        AddButton = New Button()
        EditButton = New Button()
        DeleteButton = New Button()
        CloseButton = New Button()
        Label6 = New Label()
        CType(TableStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 32)
        Label1.TabIndex = 0
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 32)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 32)
        Label3.TabIndex = 2
        Label3.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 32)
        Label4.TabIndex = 3
        Label4.Text = "Nomor Hp"
        ' 
        ' InputNIM
        ' 
        InputNIM.Location = New Point(233, 33)
        InputNIM.Name = "InputNIM"
        InputNIM.Size = New Size(577, 39)
        InputNIM.TabIndex = 4
        ' 
        ' InputName
        ' 
        InputName.Location = New Point(233, 92)
        InputName.Name = "InputName"
        InputName.Size = New Size(577, 39)
        InputName.TabIndex = 5
        ' 
        ' InputAddress
        ' 
        InputAddress.Location = New Point(233, 169)
        InputAddress.Name = "InputAddress"
        InputAddress.Size = New Size(577, 39)
        InputAddress.TabIndex = 6
        ' 
        ' InputPhone
        ' 
        InputPhone.Location = New Point(233, 245)
        InputPhone.Name = "InputPhone"
        InputPhone.Size = New Size(577, 39)
        InputPhone.TabIndex = 7
        ' 
        ' TableStudents
        ' 
        TableStudents.AllowUserToDeleteRows = False
        TableStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableStudents.Location = New Point(47, 460)
        TableStudents.Name = "TableStudents"
        TableStudents.RowHeadersWidth = 82
        TableStudents.Size = New Size(977, 300)
        TableStudents.TabIndex = 8
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(45, 372)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(222, 46)
        AddButton.TabIndex = 9
        AddButton.Text = "Tambah"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' EditButton
        ' 
        EditButton.Location = New Point(291, 372)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(222, 46)
        EditButton.TabIndex = 10
        EditButton.Text = "Edit"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(541, 372)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(222, 46)
        DeleteButton.TabIndex = 11
        DeleteButton.Text = "Hapus"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(802, 372)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(222, 46)
        CloseButton.TabIndex = 12
        CloseButton.Text = "Keluar"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(833, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(233, 107)
        Label6.TabIndex = 14
        Label6.Text = "tekan enter pada NIM untuk edit atau hapus data"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1078, 772)
        Controls.Add(Label6)
        Controls.Add(CloseButton)
        Controls.Add(DeleteButton)
        Controls.Add(EditButton)
        Controls.Add(AddButton)
        Controls.Add(TableStudents)
        Controls.Add(InputPhone)
        Controls.Add(InputAddress)
        Controls.Add(InputName)
        Controls.Add(InputNIM)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(TableStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InputNIM As TextBox
    Friend WithEvents InputName As TextBox
    Friend WithEvents InputAddress As TextBox
    Friend WithEvents InputPhone As TextBox
    Friend WithEvents TableStudents As DataGridView
    Friend WithEvents AddButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label6 As Label

End Class
