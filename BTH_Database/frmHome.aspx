<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHome.aspx.cs" Inherits="BTH_Database.frmHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="css/styleTable.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="Qlda_cn" AutoGenerateColumns="False" DataKeyNames="Macn">
                <Columns>
                    <asp:BoundField DataField="Macn" HeaderText="Macn" ReadOnly="True" SortExpression="Macn" />
                    <asp:BoundField DataField="Tencn" HeaderText="Tencn" SortExpression="Tencn" />
                    <asp:BoundField DataField="Ghichu" HeaderText="Ghichu" SortExpression="Ghichu" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="Qlda_cn" runat="server" ConnectionString="<%$ ConnectionStrings:connect_DATN %>" SelectCommand="SELECT * FROM [tbl_chuyennganh] ORDER BY [Macn]"></asp:SqlDataSource>
            <h2>So ho so trong csdl
                <asp:Label ID="lblSoSv" Text="text" runat="server" ForeColor="#ff0066" /><br />
            </h2>
            <table>
                <tr>
                    <th>STT</th>
                    <th>Tên chuyên ngành</th>
                    <th>số sinh viên</th>
                </tr>
                <asp:Literal ID="ltrKetQua" runat="server"></asp:Literal>
            </table>
            <%--  </div>
        <div>
            <h2></h2>--%>
        </div>
    </form>
</body>
</html>
