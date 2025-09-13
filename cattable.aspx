<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="cattable.aspx.vb" Inherits="BMSYSTEM.cattable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="370px" Width="933px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:TemplateField HeaderText="PHOTO" SortExpression="svup">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("svup") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="237px" ImageUrl='<%# Eval("svup") %>' Width="249px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="catid" HeaderText="CUSTOMER ID" SortExpression="catid" />
                    <asp:BoundField DataField="costnm" HeaderText="COSTUME NAME" SortExpression="costnm" />
                    <asp:BoundField DataField="barate" HeaderText="RATE" SortExpression="barate" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            &nbsp;&nbsp;
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [svup], [catid], [costnm], [barate] FROM [CATLOG]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [catid], [costnm], [barate], [svup], [baup] FROM [CATLOG]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
