<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CrudStore.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" aria-checked="undefined">
        <div>
            <h1>Login</h1><br />
            <label>Usuario</label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox><br />
            <label>Senha</label>
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label1" runat="server">Label1</asp:Label><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Registrar" OnClick="btnCadastrar_Click" /><br />
            <asp:Button ID="btnPalhaco" runat="server" Text="Palhaco" OnClick="btnPalhaco_Click" /><br />
            <asp:Literal ID="lblOut" runat="server" />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="274px" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:ButtonField ButtonType="Button" HeaderText="Button delete" ShowHeader="True" Text="Delete" />
                <asp:ButtonField ButtonType="Button" CommandName="Cancel" HeaderText="dlt2" ShowHeader="True" Text="delete2" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DbFromMigrationConnectionString %>" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>
    </form>
</body>
</html>
