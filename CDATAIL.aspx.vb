Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class CDATAIL
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim STR As String
    Dim dr As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        STR = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True"
        CON = New SqlConnection(STR)
        CON.Open()
        MsgBox("CONNECTION DONE!!!!")
    End Sub

    Protected Sub Bshow_Click(sender As Object, e As EventArgs) Handles Bshow.Click
        STR = "select * from  CORDERS "
        CMD.Connection = CON
        CMD.CommandText = STR
        dr = CMD.ExecuteReader
        GridView1.DataSource = dr
        GridView1.DataBind()
        dr.Close()
    End Sub
End Class