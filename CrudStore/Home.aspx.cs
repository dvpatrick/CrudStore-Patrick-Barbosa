using CrudStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudStore
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            // aqui acessaremos o DB com o DataContext.cs
            using (var context = new DataContext())
            {
                var nameInput = txtProduto.Text;       // peguei os dados digitados no front
                var priceInput = Int32.Parse(txtPreco.Text);
                var usr = new Produtos()
                {
                    ProductName= nameInput,
                    Price= priceInput,
                };

                context.Produtos.Add(usr);
                context.SaveChanges();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) // delete button event 
        {
            int num = Int32.Parse(e.CommandArgument.ToString());
            var idToDelete = Int32.Parse(GridView1.Rows[num].Cells[0].Text);

            using (var context = new DataContext())
            {
                var nameFromDb = context.Produtos.First<Produtos>(c => c.Id == idToDelete);

                context.Produtos.Remove(nameFromDb);
                context.SaveChanges();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSearchIdEdit_Click(object sender, EventArgs e)
        {
            var idToSearch = Int32.Parse(txtSearchIdEdit.Text);

            using (var context = new DataContext())
            {
                var prodFromDb = context.Produtos.First<Produtos>(c => c.Id == idToSearch);

                txtEditNome.Text = prodFromDb.ProductName;
                txtEditPrice.Text = Convert.ToString(prodFromDb.Price);
            }

        }

        protected void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            var idToSearch = Int32.Parse(txtSearchIdEdit.Text);

            using (var context = new DataContext())
            {
                var prodFromDb = context.Produtos.First<Produtos>(c => c.Id == idToSearch);

                prodFromDb.ProductName = txtEditNome.Text;
                prodFromDb.Price = Int32.Parse(txtEditPrice.Text);

                context.SaveChanges();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

        }

        protected void btnReload_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}