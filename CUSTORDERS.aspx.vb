Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class CUSTORDERS
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader
    Dim Str1 As String
    Dim Str2 As String
    Dim X As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        'MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        CMD.CommandText = "select enqid from CUSTENQUIRY"
        dr = CMD.ExecuteReader
        While dr.Read
            Ddlcid.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
        Str2 = "select count (faid) from  CORDERS"
        CMD.CommandText = Str2
        dr = CMD.ExecuteReader
        While dr.Read
            X = dr.GetValue(0)
        End While
        X = X + 1
        Txtfid.Text = X
        dr.Close()

    End Sub

    Protected Sub ButSUB_Click(sender As Object, e As EventArgs) Handles ButSUB.Click
        Str = "INSERT INTO CORDERS VALUES(@custoid,@cname,@cudate,@faid,@fname,@lin,@pip,@les,@pat,@tas,@cu,@des,@pic,@kuc,@fb,@ffil)"
        CMD.Connection = CON
        CMD.CommandText = Str
        CMD.Parameters.AddWithValue("@custoid", Ddlcid.Text)
        CMD.Parameters.AddWithValue("@cname", Txtnm.Text)
        CMD.Parameters.AddWithValue("@cudate", Txtdate.Text)
        CMD.Parameters.AddWithValue("@faid", Txtfid.Text)
        CMD.Parameters.AddWithValue("@fname", Txtfnm.Text)
        CMD.Parameters.AddWithValue("@lin", Ddllini.Text)
        CMD.Parameters.AddWithValue("@pip", Ddlpip.Text)
        CMD.Parameters.AddWithValue("@les", Ddlles.Text)
        CMD.Parameters.AddWithValue("@pat", Ddlpat.Text)
        CMD.Parameters.AddWithValue("@tas", Ddltass.Text)
        CMD.Parameters.AddWithValue("@cu", Ddlcup.Text)
        CMD.Parameters.AddWithValue("@des", Ddldes.Text)
        CMD.Parameters.AddWithValue("@pic", Ddlpic.Text)
        CMD.Parameters.AddWithValue("@kuc", Ddlkuch.Text)
        CMD.Parameters.AddWithValue("@fb", Ddlfbi.Text)
        CMD.Parameters.AddWithValue("@ffil", Ddlffill.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")
    End Sub

    Protected Sub BuTVIEW_Click(sender As Object, e As EventArgs) Handles BuTVIEW.Click
        Str1 = " select cuname,custype from CUSTENQUIRY where enqid ='" + Ddlcid.Text + "'"
        CMD.Connection = CON
        CMD.CommandText = Str1
        dr = CMD.ExecuteReader
        While dr.Read
            Txtnm.Text = dr.GetValue(0).ToString
            Txtfnm.Text = dr.GetValue(1).ToString

        End While
        dr.Close()
    End Sub

    Protected Sub Ddlcid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ddlcid.SelectedIndexChanged
        Str1 = " select cuname,custype from CUSTENQUIRY where enqid ='" + Ddlcid.Text + "'"
        CMD.Connection = CON
        CMD.CommandText = Str1
        dr = CMD.ExecuteReader
        While dr.Read
            Txtnm.Text = dr.GetValue(0).ToString
            Txtfnm.Text = dr.GetValue(1).ToString
        End While
        dr.Close()
    End Sub
End Class