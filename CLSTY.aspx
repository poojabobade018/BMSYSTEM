<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CLSTY.aspx.vb" Inherits="BMSYSTEM.CLSTY" MasterPageFile="~/ADMIN.Master" %>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1">
        <div style="background-color: #FFCC99">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="REPORT OF CLIENT STYLE"></asp:Label>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Report Date :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="redate" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="showd" runat="server" Text="SHOW DETAILS" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
 </asp:Content>

