Imports System.IO
Imports System.Data.SqlClient

Public Class catlog
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim str, str1 As String
    Dim str2 As String
    Dim str3 As String
    Dim X As Integer
    Dim dr As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        str2 = "select count (catid) from  CATLOG"
        CMD.CommandText = str2
        dr = CMD.ExecuteReader
        While dr.Read
            X = dr.GetValue(0)
        End While
        X = X + 1
        Txtcat.Text = X
        dr.Close()

    End Sub

    Protected Sub Bsave_Click(sender As Object, e As EventArgs) Handles Bsave.Click
        str = "INSERT INTO CATLOG VALUES(@catid,@costnm,@barate,@svup,@baup)"
        str1 = Txtupp.Text
        CMD.Connection = CON
        CMD.CommandText = str
        CMD.Parameters.AddWithValue("@catid", Txtcat.Text)
        CMD.Parameters.AddWithValue("@costnm", Txtcostt.Text)
        CMD.Parameters.AddWithValue("@barate", Txtbac.Text)
        CMD.Parameters.AddWithValue("@svup", Txtupp.Text)
        CMD.Parameters.AddWithValue("@baup", Txtup.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")

    End Sub

    Protected Sub Butupppp_Click(sender As Object, e As EventArgs) Handles Butupppp.Click
        Dim folderpath As String = Server.MapPath("~/backneck/")
        If Not Directory.Exists(folderpath) Then
            Directory.CreateDirectory(folderpath)

        End If
        FileUpload2.SaveAs(folderpath & Path.GetFileName(FileUpload2.FileName))
        str2 = folderpath + FileUpload2.FileName
        Image2.ImageUrl = "~/backneck/" & Path.GetFileName(FileUpload2.FileName)
        Txtup.Text = "/backneck/" & Path.GetFileName(FileUpload2.FileName)
        MsgBox(Path.GetFileName(FileUpload2.FileName) + " has been uploaded.")
    End Sub

    Protected Sub Butup_Click(sender As Object, e As EventArgs) Handles Butup.Click
        Dim folderpath As String = Server.MapPath("~/Blousetype/")
        If Not Directory.Exists(folderpath) Then
            Directory.CreateDirectory(folderpath)

        End If
        FileUpload1.SaveAs(folderpath & Path.GetFileName(FileUpload1.FileName))
        str1 = folderpath + FileUpload1.FileName
        Image1.ImageUrl = "~/Blousetype/" & Path.GetFileName(FileUpload1.FileName)
        Txtupp.Text = "/Blousetype/" & Path.GetFileName(FileUpload1.FileName)
        MsgBox(Path.GetFileName(FileUpload1.FileName) + " has been uploaded.")

    End Sub
End Class