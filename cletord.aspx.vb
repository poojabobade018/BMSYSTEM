Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class cletord

    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader
    Dim Str1 As String
    Dim Str2 As String



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        CMD.CommandText = "select enqid from CUSTENQUIRY"
        dr = CMD.ExecuteReader
        While dr.Read
            Ddlcid.Items.Add(dr.GetValue(0))
        End While
        dr.Close()

        CMD.CommandText = "select enqid from CUSTENQUIRY"
        dr = CMD.ExecuteReader
        While dr.Read
            Ddlfid.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
    End Sub

    Protected Sub butsub_Click(sender As Object, e As EventArgs) Handles butsub.Click
        Str = "INSERT INTO CORDERS VALUES(@custoid,@cname,@cudate,@faid,@fname,@lin,@pip,@les,@pat,@tas,@cu,@pic,@kuc,@fb,@ffil)"
        CMD.Connection = CON
        CMD.CommandText = Str
        CMD.Parameters.AddWithValue("@custoid", Ddlcid.Text)
        CMD.Parameters.AddWithValue("@cname", Txtnmm.Text)
        CMD.Parameters.AddWithValue("@cudate", Txtdate.Text)
        CMD.Parameters.AddWithValue("@faid", Ddlfid.Text)
        CMD.Parameters.AddWithValue("@fname", Txtfname.Text)
        CMD.Parameters.AddWithValue("@lin", Ddlli.Text)
        CMD.Parameters.AddWithValue("@pip", DdlPI.Text)
        CMD.Parameters.AddWithValue("@les", DdlLS.Text)
        CMD.Parameters.AddWithValue("@pat", DdlPT.Text)
        CMD.Parameters.AddWithValue("@tas", DdlTAS.Text)
        CMD.Parameters.AddWithValue("@cu", Ddlcu.Text)
        CMD.Parameters.AddWithValue("@pic", DdlPI.Text)
        CMD.Parameters.AddWithValue("@kuc", Ddlku.Text)
        CMD.Parameters.AddWithValue("@fb", DdlFB.Text)
        CMD.Parameters.AddWithValue("@ffil", DdlNT.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")
    End Sub


    Protected Sub Ddlcid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ddlcid.SelectedIndexChanged
        Str1 = " select cuname from CUSTENQUIRY where enqid ='" + Ddlcid.Text + "'"
        CMD.Connection = CON
        CMD.CommandText = Str1
        dr = CMD.ExecuteReader
        While dr.Read
            Txtnmm.Text = dr.GetValue(0).ToString
        End While
        dr.Close()
    End Sub




    Protected Sub ButV_Click(sender As Object, e As EventArgs) Handles ButV.Click
        Str1 = " select cuname from CUSTENQUIRY where enqid ='" + Ddlcid.Text + "'"
        CMD.Connection = CON
        CMD.CommandText = Str1
        dr = CMD.ExecuteReader
        While dr.Read
            Txtnmm.Text = dr.GetValue(0).ToString
        End While
        dr.Close()
        Str2 = " select custype from CUSTENQUIRY where enqid ='" + Ddlfid.Text + "'"
        CMD.Connection = CON
        CMD.CommandText = Str2
        dr = CMD.ExecuteReader
        While dr.Read
            Txtfname.Text = dr.GetValue(0).ToString
        End While
        dr.Close()
    End Sub


    Protected Sub Ddlfid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ddlfid.SelectedIndexChanged
        Str2 = " select custype from CUSTENQUIRY where enqid ='" + Ddlfid.Text + "'"
        CMD.Connection = CON
        CMD.CommandText = Str2
        dr = CMD.ExecuteReader
        While dr.Read
            Txtfname.Text = dr.GetValue(0).ToString
        End While
        dr.Close()
    End Sub
End Class
