using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CrudStore.Models;
using static System.Net.Mime.MediaTypeNames;

namespace CrudStore
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            // aqui acessaremos o DB com o DataContext.cs
            using(var context = new DataContext())
            {
                var nameInput = txtUsuario.Text;           // peguei os dados digitados no front
                var usr = new Usuarios()
                {
                    Nome = nameInput,
                };

                context.Usuarios.Add(usr);
                context.SaveChanges();
            }
        }

        protected void btnPalhaco_Click(object sender, EventArgs e)
        {
            using(var context = new DataContext())
            {
                //var nameFromDb = context.Usuarios.Find();     // peguei os dados digitados no front
                //var nameFromDb = (from s in context.Usuarios
                //                //where s.Id == 1
                //                select s).ToList();

                //Label1.Text = nameFromDb[0].Nome;

                context.SaveChanges();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) // delete button event 
        {
            int num = Int32.Parse(e.CommandArgument.ToString());
            var idToDelete = Int32.Parse(GridView1.Rows[num].Cells[0].Text);
            Label1.Text = GridView1.Rows[num].Cells[0].Text;

            using (var context = new DataContext())
            {
                var nameFromDb = context.Usuarios.First<Usuarios>(c => c.Id == idToDelete);

                context.Usuarios.Remove(nameFromDb);
                context.SaveChanges();
            }
        }
    }

}