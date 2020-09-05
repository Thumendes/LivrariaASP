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
    public partial class FormLivro : System.Web.UI.Page
    {

        AutorBLL autorBLL = new AutorBLL();
        EditoraBLL editoraBLL = new EditoraBLL();

        LivroBLL livroBLL = new LivroBLL();
        LivroDTO livroDTO = new LivroDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            drpAutor.DataSource = autorBLL.index();
            drpAutor.DataTextField = "nome";
            drpAutor.DataValueField = "idAutor";
            drpAutor.DataBind();

            drpEditora.DataSource = editoraBLL.index();
            drpEditora.DataTextField = "nome";
            drpEditora.DataValueField = "idEditora";
            drpEditora.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                livroDTO.IdAutor = int.Parse(drpAutor.SelectedValue.ToString());
                livroDTO.IdEditora = int.Parse(drpEditora.SelectedValue.ToString());
                livroDTO.DataCadastro = txtDataCadastro.Text;
                livroDTO.Titulo = txtTitulo.Text;
                livroDTO.NumPaginas = int.Parse(txtNumPaginas.Text);
                livroDTO.Valor = double.Parse(txtValor.Text);

                livroBLL.create(livroDTO);

                messageError.Visible = false;

                messageSuccess.Visible = true;
                messageSuccess.Text = "Livro salvo!";
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