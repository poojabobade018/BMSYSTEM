Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class sigup
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        MsgBox("Connection Done!!!!")
        CMD.Connection = CON
    End Sub

    Protected Sub smt_Click(sender As Object, e As EventArgs) Handles smt.Click
        Str = "INSERT INTO SIUP VALUES(@usnm,@pass,@cpass,@seque,@seqans)"
        CMD.Connection = CON
        CMD.CommandText = Str
        CMD.Parameters.AddWithValue("@usnm", Txtuser.Text)
        CMD.Parameters.AddWithValue("@pass", Txtpaass.Text)
        CMD.Parameters.AddWithValue("@cpass", Txtcon.Text)
        CMD.Parameters.AddWithValue("@seque", Ddlsqu.Text)
        CMD.Parameters.AddWithValue("@seqans", Txtan.Text)
        CMD.ExecuteNonQuery()
        MsgBox("REGISTERED SUCCESSFULLY...!!!")

    End Sub

    Protected Sub email_TextChanged(sender As Object, e As EventArgs) Handles Txtuser.TextChanged

    End Sub
End Class