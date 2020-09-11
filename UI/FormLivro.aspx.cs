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
            if (IsPostBack == false)
            {
                drpAutor.DataSource = autorBLL.index();
                drpAutor.DataTextField = "nome";
                drpAutor.DataValueField = "idAutor";
                drpAutor.DataBind();

                drpEditora.DataSource = editoraBLL.index();
                drpEditora.DataTextField = "nome";
                drpEditora.DataValueField = "idEditora";
                drpEditora.DataBind();

                PopulateGrid();
            }
        }

        public void PopulateGrid()
        {
            GridLivro.DataSource = livroBLL.index();
            GridLivro.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                livroDTO.IdAutor = int.Parse(drpAutor.SelectedValue.ToString());
                livroDTO.IdEditora = int.Parse(drpEditora.SelectedValue.ToString());
                livroDTO.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                livroDTO.Titulo = txtTitulo.Text;
                livroDTO.NumPaginas = int.Parse(txtNumPaginas.Text);
                livroDTO.Valor = double.Parse(txtValor.Text);

                livroBLL.create(livroDTO);

                messageError.Visible = false;

                PopulateGrid();

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

        protected void GridLivro_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                livroDTO.IdLivro = Convert.ToInt32(e.Values[0]);
                livroBLL.delete(livroDTO);

                messageSuccess.Visible = true;
                messageSuccess.Text = "Livro deletado!";

                PopulateGrid();
            }
            catch (Exception ex)
            {
                messageError.Visible = true;
                messageError.Text = ex.Message;
            }
        }

        protected void GridLivro_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridLivro.EditIndex = e.NewEditIndex;
            PopulateGrid();
        }

        protected void GridLivro_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                livroDTO.IdLivro = int.Parse(e.NewValues[0].ToString());
                livroDTO.IdAutor = int.Parse(e.NewValues[1].ToString());
                livroDTO.IdEditora = int.Parse(e.NewValues[2].ToString());
                livroDTO.Titulo = e.NewValues[3].ToString();
                livroDTO.DataCadastro = Convert.ToDateTime(e.NewValues[4]);
                livroDTO.NumPaginas = int.Parse(e.NewValues[5].ToString());
                livroDTO.Valor = double.Parse(e.NewValues[6].ToString());

                livroBLL.update(livroDTO);

                GridLivro.EditIndex = -1;
                PopulateGrid();
            }
            catch (Exception ex)
            {
                messageError.Visible = true;
                messageError.Text = ex.Message;
            }
        }

        protected void GridLivro_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridLivro.EditIndex = -1;
            PopulateGrid();
        }
    }
}