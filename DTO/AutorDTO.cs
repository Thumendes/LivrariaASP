using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrariaASP.DTO
{
    public class AutorDTO
    {
        private int id, idade;
        private string nome;

        public int Id { get => id; set => id = value; }
        public int Idade
        {
            get => idade; 
            set
            {
                if (value.ToString() != string.Empty)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("O campo idade é obrigatório!");
                }
            }
        }
        public string Nome
        {
            get => nome; 
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório!");
                }
            }
        }
    }
}