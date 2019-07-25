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

</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:table ID="dataTable" runat="server">
                
            </asp:table>
            
        </div>

    </form>
</body>
</html>
