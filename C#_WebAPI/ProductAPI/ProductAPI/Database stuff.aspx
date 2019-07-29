<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Database stuff.aspx.cs" Inherits="ProductAPI.Database_stuff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
.grid-container {
  display: grid;
  grid-template-columns: auto auto auto auto;
  background-color: #2196F3;
  padding: 10px;
}

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 706px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:table ID="dataTable" runat="server">
                
            </asp:table>
            
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="ProductsDBEFMigration">
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="ProductsDBEFMigration" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsDBEFConnectionString %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">ProductID</td>
                    <td>
                        <asp:TextBox ID="tbProdId" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Price</td>
                    <td>
                        <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Description</td>
                    <td>
                        <asp:TextBox ID="tbDesc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Item" />
                        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="height: 26px" Text="Edit" />
                        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                        <asp:Button ID="btnGetProd" runat="server" OnClick="btnGetProd_Click" Text="Get Product" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            
        </div>

        <asp:Label ID="lbResult" runat="server" Text="Success" Visible="False"></asp:Label>

    </form>
</body>
</html>
