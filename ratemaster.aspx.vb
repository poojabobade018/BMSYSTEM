Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class ratemaster
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        CMD.CommandText = "select stye from CUSTOMERDETAIL"
        dr = CMD.ExecuteReader
        While dr.Read
            Ddlst.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
    End Sub

    Protected Sub BMT_Click(sender As Object, e As EventArgs) Handles BMT.Click
        Str = "INSERT INTO RATEMASTERDELL VALUES(@sty, @cost,@costype,@liningc,@liningcr,@linings,@backdes,@lesss,@lessm,
                 @lessl,@tasselss,@tasselsm,@tasselsl,@zips,@patchs,@patchm,@patchl,@cup,@follb,
                @netf,@kuchuone,@kuchutwo)"
        CMD.Connection = CON
        CMD.CommandText = Str
        CMD.Parameters.AddWithValue("@sty", Ddlst.Text)
        CMD.Parameters.AddWithValue("@cost", Txtco.Text)
        CMD.Parameters.AddWithValue("@costype", costy.Text)
        CMD.Parameters.AddWithValue("@liningc", liningco.Text)
        CMD.Parameters.AddWithValue("@liningcr", linigcr.Text)
        CMD.Parameters.AddWithValue("@linings", linisat.Text)
        CMD.Parameters.AddWithValue("@backdes", backdes.Text)
        CMD.Parameters.AddWithValue("@lesss", small.Text)
        CMD.Parameters.AddWithValue("@lessm", medium.Text)
        CMD.Parameters.AddWithValue("@lessl", large.Text)
        CMD.Parameters.AddWithValue("@tasselss", tassm.Text)
        CMD.Parameters.AddWithValue("@tasselsm", tassme.Text)
        CMD.Parameters.AddWithValue("@tasselsl", taslarg.Text)
        CMD.Parameters.AddWithValue("@zips", zipp.Text)
        CMD.Parameters.AddWithValue("@patchs", patdes.Text)
        CMD.Parameters.AddWithValue("@patchm", patchmed.Text)
        CMD.Parameters.AddWithValue("@patchl", patchlar.Text)
        CMD.Parameters.AddWithValue("@cup", cupp.Text)
        CMD.Parameters.AddWithValue("@follb", sareefoll.Text)
        CMD.Parameters.AddWithValue("@netf", sareenet.Text)
        CMD.Parameters.AddWithValue("@kuchuone", kuchuqon.Text)
        CMD.Parameters.AddWithValue("@kuchutwo", kuchutw.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")


    End Sub


End Class