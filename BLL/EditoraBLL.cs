using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using LivrariaASP.DAL;
using LivrariaASP.DTO;

namespace LivrariaASP.BLL
{
    public class EditoraBLL
    {
        private Connection database = new Connection();

        public DataTable index()
        {
            string query = string.Format($@"SELECT * FROM TBL_Editora");
            return database.execQuery(query);
        }

        public void create(EditoraDTO data)
        {
            string query = string.Format($@"INSERT INTO TBL_Editora VALUES (NULL, '{data.NomeEditora}', '{data.EnderecoEditora}', '{data.UFEditora}');");
            database.execCommand(query);
        }

        public void delete(EditoraDTO data)
        {
            string query = string.Format($@"DELETE FROM TBL_Editora where id = {data.IdEditora};");
            database.execCommand(query);
        }

        public void update(EditoraDTO data)
        {
            string query = string.Format($@"UPDATE TBL_Editora SET nome = '{data.NomeEditora}', endereco = '{data.EnderecoEditora}', UF = '{data.UFEditora}' ) WHERE id = {data.IdEditora};");
            database.execCommand(query);
        }
    }
}