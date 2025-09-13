Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class costumescat
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim STR As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON

    End Sub
    Protected Sub sbm_Click(sender As Object, e As EventArgs) Handles sbm.Click

        STR = "INSERT INTO COSTUMECAT VALUES(@catid,@costyp)"

        CMD.Connection = CON
        CMD.CommandText = STR
        CMD.Parameters.AddWithValue("@catid", caid.Text)
        CMD.Parameters.AddWithValue("@costyp", cotype.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")

    End Sub
End Class