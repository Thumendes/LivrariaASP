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
    public partial class FormEditora : System.Web.UI.Page
    {
        EditoraBLL editoraBLL = new EditoraBLL();
        EditoraDTO editoraDTO = new EditoraDTO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void reset()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtUF.Text = "";
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                editoraDTO.NomeEditora = txtNome.Text;
                editoraDTO.EnderecoEditora = txtEndereco.Text;
                editoraDTO.UFEditora = txtUF.Text;

                editoraBLL.create(editoraDTO);

                messageError.Visible = false;

                messageSuccess.Visible = true;
                messageSuccess.Text = "Editora salva!";
                this.reset();
            }
            catch (Exception error)
            {
                messageSuccess.Visible = false;
                messageError.Visible = true;
                messageError.Text = error.Message;
            }
        }
    }
}