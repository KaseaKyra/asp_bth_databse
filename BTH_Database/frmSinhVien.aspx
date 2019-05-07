<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSinhVien.aspx.cs" Inherits="BTH_Database.frmSinhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>thông tin sinh viên</title>
    <link href="css/styleTable.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>DANH SÁCH SINH VIÊN TRONG CƠ SỞ DỮ LIỆU</h2>
            <table>
                <tr>
                    <th>stt</th>
                    <th>msv</th>
                    <th>tên sinh viên</th>
                    <th>khóa</th>
                    <th>email</th>
                    <th>chi tiết</th>
                </tr>
                <asp:Literal ID="ltrKetQua" runat="server"></asp:Literal>
            </table>
        </div>
    </form>
</body>
</html>
