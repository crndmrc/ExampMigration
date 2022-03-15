<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sale.aspx.cs" Inherits="ExampMigration.Sale" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblidInfo" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Product"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlProduct" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Customer"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCustomer" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Unit"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUnit" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCreate" runat="server" Text="Create" Width="104px" OnClick="btnCreate_Click"/>
            &nbsp;<asp:Button ID="btnRead" runat="server" Text="Read" Width="104px" OnClick="btnRead_Click" />
            &nbsp;<asp:Button ID="btnUpdate" runat="server" Text="Update" Width="104px" OnClick="btnUpdate_Click" />
            &nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" Width="104px" OnClick="btnDelete_Click" />
            &nbsp;
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnFind" runat="server" Text="Find" Width="104px" OnClick="btnFind_Click" />
            <br />
            <asp:GridView ID="gvData" runat="server" DataKeyNames="id" OnSelectedIndexChanged="gvData_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
