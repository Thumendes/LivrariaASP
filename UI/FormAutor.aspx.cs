using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LivrariaASP.BLL;
using LivrariaASP.DTO;

namespace LivrariaASP.UI
{
    public partial class FormAutor : System.Web.UI.Page
    {
        AutorBLL autorBLL = new AutorBLL();
        AutorDTO autorDTO = new AutorDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.PopulateGrid();
        }
        public void reset()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                autorDTO.Nome = txtNome.Text;
                autorDTO.Idade = int.Parse(txtIdade.Text);

                autorBLL.create(autorDTO);

                messageError.Visible = false;

                messageSuccess.Visible = true;
                messageSuccess.Text = "Autor salvo!";
                this.reset();
            }
            catch (Exception error)
            {
                messageSuccess.Visible = false;
                messageError.Visible = true;
                messageError.Text = error.Message;
            }
        }

        public void PopulateGrid()
        {
            GridAutor.DataSource = autorBLL.index();
            GridAutor.DataBind();
        }
    }
}