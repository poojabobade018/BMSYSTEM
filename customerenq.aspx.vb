Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class customerenq
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader
    Dim Str2 As String
    Dim X As Integer




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CON = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON.Open()
        ' MsgBox("CONNECTION DONE..!!!")
        CMD.Connection = CON
        Str2 = "select count (enqid) from  CUSTENQUIRY"
        CMD.CommandText = Str2
        dr = CMD.ExecuteReader
        While dr.Read
            X = dr.GetValue(0)
        End While
        X = X + 201
        enqide.Text = X
        dr.Close()
    End Sub

    Protected Sub sub_Click(sender As Object, e As EventArgs) Handles [sub].Click
        Str = "INSERT INTO CUSTENQUIRY VALUES(@enqid,@daate,@cuname,@cuaddres,@cmobno,@cuemail,@custype)"
        CMD.Connection = CON
        CMD.CommandText = Str
        CMD.Parameters.AddWithValue("@enqid", enqide.Text)
        CMD.Parameters.AddWithValue("@daate", txtdate.Text)
        CMD.Parameters.AddWithValue("@cuname", Txtcunm.Text)
        CMD.Parameters.AddWithValue("@cuaddres", cuadder.Text)
        CMD.Parameters.AddWithValue("@cmobno", cumn.Text)
        CMD.Parameters.AddWithValue("@cuemail", email.Text)
        CMD.Parameters.AddWithValue("@custype", Ddlty.Text)
        CMD.ExecuteNonQuery()
        MsgBox("RECORD INSERTED..!!!")


    End Sub

    Protected Sub sub_Click1(sender As Object, e As EventArgs) Handles [sub].Click

    End Sub

    Protected Sub sub_Click2(sender As Object, e As EventArgs) Handles [sub].Click

    End Sub

    Protected Sub sub_Click3(sender As Object, e As EventArgs) Handles [sub].Click

    End Sub

    Protected Sub sub_Click4(sender As Object, e As EventArgs) Handles [sub].Click

    End Sub

    Protected Sub sub_Click5(sender As Object, e As EventArgs) Handles [sub].Click

    End Sub
End Class