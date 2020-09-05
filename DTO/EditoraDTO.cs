using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrariaASP.DTO
{
    public class EditoraDTO
    {
        private int id;
        private string nome, endereco, UF;

        public int IdEditora { get => id; set => id = value; }
        public string NomeEditora
        {
            get => nome;
            set
            {
                if(value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório!");
                }
            }
        }
        public string EnderecoEditora
        {
            get => endereco;
            set
            {
                if (value != string.Empty)
                {
                    this.endereco = value;
                }
                else
                {
                    throw new Exception("O campo endereço é obrigatório!");
                }
            }
        }
        public string UFEditora
        {
            get => UF;
            set
            {
                if (value != string.Empty)
                {
                    this.UF = value;
                }
                else
                {
                    throw new Exception("O campo UF é obrigatório!");
                }
            }
        }
    }
}