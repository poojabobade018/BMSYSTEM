Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class forgotpas
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Str = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON = New SqlConnection(Str)
        CON.Open()
        MsgBox("CONNECTION DONE..!!")
        CMD.Connection = CON
    End Sub

    Protected Sub verr_Click(sender As Object, e As EventArgs) Handles verr.Click
        Dim str1 As String
        str1 = "select seque from SIUP where usnm='" + Txtnm.Text + "'"
        CMD.Connection = CON
        CMD.CommandText = str1
        dr = CMD.ExecuteReader
        While dr.Read
            Txtseq.Text = dr.GetValue(0).ToString
        End While
    End Sub

    Protected Sub shop_Click(sender As Object, e As EventArgs) Handles shop.Click
        Dim strconcat, str2 As String
        strconcat = "select seqans,pass from SIUP where usnm='" + Txtnm.Text + " '"
        CMD.Connection = CON
        CMD.CommandText = strconcat
        dr = CMD.ExecuteReader
        While dr.Read
            str2 = dr.GetValue(0).ToString

            If str2 = Txtsean.Text Then
                MsgBox("YOUR OLD PASSWORD IS" & dr.GetValue(1).ToString)
            Else
                MsgBox("YOUR ANSWER DOESN'T MATCH...!!!")

            End If
        End While
    End Sub

    Protected Sub okk_Click(sender As Object, e As EventArgs) Handles okk.Click

    End Sub
End Class