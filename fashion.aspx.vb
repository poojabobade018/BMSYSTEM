Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class fashion
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader
    Dim str1 As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Str = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON = New SqlConnection(Str)
        CON.Open()
        MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        CMD.CommandText = "select enqid from CUSTENQUIRY"
        dr = CMD.ExecuteReader
        While dr.Read
            Ddlcuid.Items.Add(dr.GetValue(0))
        End While
        dr.Close()

    End Sub

    Protected Sub ButSUBM_Click(sender As Object, e As EventArgs) Handles ButSUBM.Click
        Str = "INSERT INTO FASHIONDEL VALUES(@cusid,@cuname,@custype)"
        CMD.Connection = CON
        CMD.CommandText = Str
        CMD.Parameters.AddWithValue("@cusid", Ddlcuid.Text)
        CMD.Parameters.AddWithValue("@cuname", cusnm.Text)
        CMD.Parameters.AddWithValue("@custype", ctyp.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED...!!!!")

    End Sub

    Protected Sub ButVIEW_Click(sender As Object, e As EventArgs) Handles ButVIEW.Click

        Str = "select * from RATEDETL "
        CMD.Connection = CON
        CMD.CommandText = Str
        dr = CMD.ExecuteReader
        GridView1.DataSource = dr
        GridView1.DataBind()
        dr.Close()
    End Sub

    Protected Sub Ddlcuid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ddlcuid.SelectedIndexChanged
        str1 = " select cuname,custype from CUSTENQUIRY where enqid ='" + Ddlcuid.Text + "'"
        CMD.Connection = CON
        CMD.CommandText = str1
        dr = CMD.ExecuteReader
        While dr.Read
            cusnm.Text = dr.GetValue(0).ToString
            ctyp.Text = dr.GetValue(1).ToString


        End While
        dr.Close()
    End Sub
End Class