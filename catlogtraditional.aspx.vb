Imports System.IO
Imports System.Data.SqlClient
Public Class catlogtraditional
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim str, str1 As String
    Dim str2 As String
    Dim X As Integer
    Dim dr As SqlDataReader


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        str2 = "select count (catid) from  CATTRAD"
        CMD.CommandText = str2
        dr = CMD.ExecuteReader
        While dr.Read
            X = dr.GetValue(0)
        End While
        X = X + 1
        cid.Text = X
        dr.Close()
    End Sub

    Protected Sub busave_Click(sender As Object, e As EventArgs) Handles busave.Click
        str = "INSERT INTO CATTRAD VALUES(@catid,@costnm,@barate,@svup)"
        str1 = Txtupq.Text
        CMD.Connection = CON
        CMD.CommandText = str
        CMD.Parameters.AddWithValue("@catid", cid.Text)
        CMD.Parameters.AddWithValue("@costnm", costnm.Text)
        CMD.Parameters.AddWithValue("@barate", brate.Text)
        CMD.Parameters.AddWithValue("@svup", Txtupq.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")

    End Sub

    Protected Sub buupp_Click(sender As Object, e As EventArgs) Handles buupp.Click
        Dim folderpath As String = Server.MapPath("~/traditionalwear/")
        If Not Directory.Exists(folderpath) Then
            Directory.CreateDirectory(folderpath)

        End If
        FileUpload1.SaveAs(folderpath & Path.GetFileName(FileUpload1.FileName))
        str1 = folderpath + FileUpload1.FileName
        Image1.ImageUrl = "~/traditionalwear/" & Path.GetFileName(FileUpload1.FileName)
        Txtupq.Text = "/traditionalwear/" & Path.GetFileName(FileUpload1.FileName)
        MsgBox(Path.GetFileName(FileUpload1.FileName) + " has been uploaded.")
    End Sub
End Class