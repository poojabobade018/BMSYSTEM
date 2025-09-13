Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class cusdetails
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
            enqid.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
    End Sub

    Protected Sub sum_Click(sender As Object, e As EventArgs) Handles sum.Click
        Str = "INSERT INTO CUSTOMERDETAIL VALUES(@enquyid,@datte,@custname,@stye,@bottm,@fndesign,@bndesign,@sleevedes,@openingdes,@tasselsdes,@pipingdes,@liningdes,@cup,@sare)"
        CMD.Connection = CON
        CMD.CommandText = Str
        CMD.Parameters.AddWithValue("@enquyid", enqid.Text)
        CMD.Parameters.AddWithValue("@datte", datee.Text)
        CMD.Parameters.AddWithValue("@custname", cunm.Text)
        CMD.Parameters.AddWithValue("@stye", Ddlsty.Text)
        CMD.Parameters.AddWithValue("@bottm", Ddlbot.Text)
        CMD.Parameters.AddWithValue("@fndesign", Ddlfnd.Text)
        CMD.Parameters.AddWithValue("@bndesign", Ddlbnd.Text)
        CMD.Parameters.AddWithValue("@sleevedes", Ddlsleed.Text)
        CMD.Parameters.AddWithValue("@openingdes", Ddloped.Text)
        CMD.Parameters.AddWithValue("@tasselsdes", Ddltas.Text)
        CMD.Parameters.AddWithValue("@pipingdes", Ddlpip.Text)
        CMD.Parameters.AddWithValue("@liningdes", Ddllin.Text)
        CMD.Parameters.AddWithValue("@cup", Ddlcu.Text)
        CMD.Parameters.AddWithValue("@sare", Ddlsar.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")
    End Sub

    Protected Sub enqid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles enqid.SelectedIndexChanged
        str1 = "select nm from CLIENT where cusid=" + enqid.Text
        CMD.Connection = CON
        CMD.CommandText = str1
        dr = CMD.ExecuteReader
        While dr.Read
            cunm.Text = dr.GetValue(0).ToString

        End While
        dr.Close()

    End Sub
End Class