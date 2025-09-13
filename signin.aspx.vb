Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class signin
    Inherits System.Web.UI.Page
    Dim CON As New SqlConnection
    Dim CMD As New SqlCommand
    Dim Str As String
    Dim dr As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Str = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\collage project ty\BMSYSTEM\App_Data\Database1.mdf;Integrated Security=True")
        CON = New SqlConnection(Str)
        CON.Open()
        MsgBox("Connection Done!!!!")
        CMD.Connection = CON

    End Sub

    Protected Sub SUT_Click(sender As Object, e As EventArgs) Handles SUT.Click
        Dim str1, str2, str3 As String
        str1 = " select usnm,cpass FROM SIUP WHERE usnm = '" + Txtus.Text + "'"

        'CON = New SqlConnection(str1)
        CMD.Connection = CON
        CMD.CommandText = str1
        'CON.Open()
        dr = CMD.ExecuteReader
        While dr.Read
            str2 = dr.GetValue(0).ToString
            str3 = dr.GetValue(1).ToString
        End While
        If str2 = Txtus.Text Then
            MsgBox("DONE!!")
        Else
            MsgBox("INCORRECT  USERNAME...!!!")
        End If
        If str3 = Txtpass.Text Then
            MsgBox("DONE!!")
        Else
            MsgBox("INCORRECT PASSWORD...!!!")
        End If
    End Sub
End Class