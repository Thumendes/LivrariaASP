using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using LivrariaASP.DAL;
using LivrariaASP.DTO;

namespace LivrariaASP.BLL
{
    public class LivroBLL
    {
        private Connection database = new Connection();

        public DataTable index()
        {
            string query = string.Format($@"SELECT * FROM TBL_Livro");
            return database.execQuery(query);
        }

        public void create(LivroDTO data)
        {
            string query = string.Format($@"INSERT INTO TBL_Livro VALUES(NULL, '{data.IdAutor}', '{data.IdEditora}', '{data.Titulo}', '{data.DataCadastro.ToString("yyyy-MM-dd")}', '{data.NumPaginas}', '{data.Valor}');");
            database.execCommand(query);
        }

        public void delete(LivroDTO data)
        {
            string query = string.Format($@"DELETE FROM TBL_Livro where idLivro = {data.IdLivro};");
            database.execCommand(query);
        }

        public void update(LivroDTO data)
        {
            string query = string.Format($@"UPDATE TBL_Livro SET idAutor = '{data.IdAutor}', idEditora = '{data.IdEditora}', titulo = '{data.Titulo}', dataCadastro = '{data.DataCadastro.ToString("yyyy-MM-dd")}', numPaginas = '{data.NumPaginas}', valor = '{data.Valor}' WHERE idLivro = '{data.IdLivro}';");
            database.execCommand(query);
        }
    }
}