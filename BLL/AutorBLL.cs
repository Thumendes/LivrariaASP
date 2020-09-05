using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using LivrariaASP.DAL;
using LivrariaASP.DTO;

namespace LivrariaASP.BLL
{
    public class AutorBLL
    {
        private Connection database = new Connection();

        public DataTable index()
        {
            string query = string.Format($@"SELECT * FROM TBL_Autor");
            return database.execQuery(query);
        }

        public void create(AutorDTO data)
        {
            string query = string.Format($@"INSERT INTO TBL_Autor VALUES (NULL, '{data.Nome}', '{data.Idade}');");
            database.execCommand(query);
        }

        public void delete(AutorDTO data)
        {
            string query = string.Format($@"DELETE FROM TBL_Autor where id = {data.Id};");
            database.execCommand(query);
        }

        public void update(AutorDTO data)
        {
            string query = string.Format($@"UPDATE TBL_Autor SET nome = '{data.Nome}', idade = '{data.Idade}') WHERE id = {data.Id};");
            database.execCommand(query);
        }
    }
}