Imports System.IO
Imports System.Data.SqlClient

Public Class photogallery
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim str, str1 As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles uplod.Click
        Dim folderpath As String = Server.MapPath("~/pic/")
        If Not Directory.Exists(folderpath) Then
            Directory.CreateDirectory(folderpath)

        End If
        FileUpload1.SaveAs(folderpath & Path.GetFileName(FileUpload1.FileName))
        str1 = folderpath + FileUpload1.FileName
        Image1.ImageUrl = "~/pic/" & Path.GetFileName(FileUpload1.FileName)
        Txtup.Text = "/pic/" & Path.GetFileName(FileUpload1.FileName)
        MsgBox(Path.GetFileName(FileUpload1.FileName) + " has been uploaded.")



    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtup.TextChanged

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles savee.Click
        str = "INSERT INTO PGALLERY VALUES(@id,@photoname,@photopath)"
        str1 = Txtup.Text
        CMD.Connection = CON
        CMD.CommandText = str
        CMD.Parameters.AddWithValue("@id", Txtid.Text)
        CMD.Parameters.AddWithValue("@photoname", Txtup.Text)
        CMD.Parameters.AddWithValue("@photopath", str1)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")

    End Sub

End Class