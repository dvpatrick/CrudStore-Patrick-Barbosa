<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CrudStore.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 599px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Cadastrar Produto</h3><br />
            <label>
            <asp:TextBox ID="txtProduto" runat="server" style="margin-top: 0px"></asp:TextBox>Nome do Produto</label>
            <br />
            <label>
            <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>Preço</label> <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Registrar" OnClick="btnCadastrar_Click" BackColor="#009933" ForeColor="Black" /><br />
        </div>
        <div>
            <h3>Editar Produto</h3><br />            
            <label>
            <asp:TextBox ID="txtSearchIdEdit" runat="server" style="margin-top: 0px"></asp:TextBox>Id do produto</label>
            <asp:Button ID="btnSearchIdEdit" runat="server" Text="Buscar" OnClick="btnSearchIdEdit_Click" />
            <br /><br />
            <label>
            <asp:TextBox ID="txtEditNome" runat="server" style="margin-top: 0px"></asp:TextBox>Nome do produto</label>
            <label>
            <asp:TextBox ID="txtEditPrice" runat="server" style="margin-top: 0px"></asp:TextBox>Price do produto</label>
            <asp:Button ID="btnConfirmEdit" runat="server" Text="Atualizar" OnClick="btnConfirmEdit_Click" /><br />
        </div>
        <div>
            <h3>Produtos cadastrados</h3><br />
            <asp:Button ID="btnReload" runat="server" Text="Atualizar Produtos" OnClick="btnReload_Click" BackColor="Yellow" /><br />
            <asp:SqlDataSource ID="SqlDataProdutos" runat="server" ConnectionString="<%$ ConnectionStrings:DbFromMigrationConnectionString %>" SelectCommand="SELECT * FROM [Produtos]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataProdutos" Height="182px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="511px" OnRowCommand="GridView1_RowCommand" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:ButtonField ButtonType="Button" CommandName="Cancel" HeaderText="Deletar" ShowHeader="True" Text="Excluir" >
                    <ControlStyle BackColor="Red" />
                    </asp:ButtonField>

                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
         </div>
    </form>
</body>
</html>
