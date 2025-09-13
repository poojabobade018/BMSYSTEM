Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class billdet
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader
    Dim PAYMENT As String
    Dim str1 As String
    Dim Str2 As String
    Dim X As Integer


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Str = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON = New SqlConnection(Str)
        CON.Open()
        'MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        CMD.CommandText = "select enqid from CUSTENQUIRY"
        dr = CMD.ExecuteReader
        While dr.Read
            Ddlc.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
        Str2 = "select count (billno) from  BILLDET"
        CMD.CommandText = Str2
        dr = CMD.ExecuteReader
        While dr.Read
            X = dr.GetValue(0)
        End While
        X = X + 1
        bnoo.Text = X
        dr.Close()


    End Sub

    Protected Sub sub_Click(sender As Object, e As EventArgs) Handles [sub].Click
        If RBCASH.Checked = True Then
            PAYMENT = RBCASH.Text
        Else
            PAYMENT = RBONPAY.Text
        End If

        Str = "INSERT INTO BILLDET VALUES(@billno,@bildate,@cusid,@cusnm,@contact,@ddate,@totalam,@paymt,@bval)"
        CMD.Connection = CON
        CMD.CommandText = Str
        CMD.Parameters.AddWithValue("@billno", bnoo.Text)
        CMD.Parameters.AddWithValue("@bildate", bdate.Text)
        CMD.Parameters.AddWithValue("@cusid", Ddlc.Text)
        CMD.Parameters.AddWithValue("@cusnm", Txtcu.Text)
        CMD.Parameters.AddWithValue("@contact", Txcont.Text)
        CMD.Parameters.AddWithValue("@ddate", Txtdate.Text)
        CMD.Parameters.AddWithValue("@totalam", Txttotl.Text)
        CMD.Parameters.AddWithValue("@paymt", PAYMENT)
        CMD.Parameters.AddWithValue("@bval", Txtbill.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED...!!!!")
    End Sub


    Protected Sub Ddlc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ddlc.SelectedIndexChanged
        str1 = "select cuname,cmobno from CUSTENQUIRY where enqid=" + Ddlc.Text
        MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        CMD.CommandText = str1
        dr = CMD.ExecuteReader
        While dr.Read
            Txtcu.Text = dr.GetValue(0).ToString
            Txcont.Text = dr.GetValue(1).ToString
        End While
        dr.Close()

    End Sub

    Protected Sub Buvi_Click(sender As Object, e As EventArgs) Handles Buvi.Click
        CMD.CommandText = "select enqid from CUSTENQUIRY"
        dr = CMD.ExecuteReader
        While dr.Read
            Ddlc.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
    End Sub



    Protected Sub Butbil_Click(sender As Object, e As EventArgs) Handles Butbil.Click
        Txtbill.Text = Val(GridView1.SelectedRow.Cells(2).Text) +
             Val(GridView1.SelectedRow.Cells(3).Text) +
             Val(GridView1.SelectedRow.Cells(4).Text) +
             Val(GridView1.SelectedRow.Cells(5).Text) +
             Val(GridView1.SelectedRow.Cells(6).Text) +
             Val(GridView1.SelectedRow.Cells(7).Text) +
             Val(GridView1.SelectedRow.Cells(8).Text) +
             Val(GridView1.SelectedRow.Cells(9).Text) +
             Val(GridView1.SelectedRow.Cells(10).Text) +
             Val(GridView1.SelectedRow.Cells(11).Text) +
             Val(GridView1.SelectedRow.Cells(12).Text) +
              Val(GridView1.SelectedRow.Cells(13).Text) +
               Val(GridView1.SelectedRow.Cells(14).Text)

    End Sub


End Class