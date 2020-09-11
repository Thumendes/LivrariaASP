using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrariaASP.DTO
{
    public class LivroDTO
    {
        private int idLivro, idAutor, idEditora, numPaginas;
        private double valor;
        private string titulo;
        private DateTime dataCadastro;

        public int IdLivro { get => idLivro; set => idLivro = value; }
        public int IdAutor { get => idAutor; set {
                if (value.ToString() != string.Empty)
                {
                    this.idAutor = value;
                }
                else
                {
                    throw new Exception("O campo autor é obrigatório!");
                }
            } }
        public int IdEditora { get => idEditora; set {
                if (value.ToString() != string.Empty)
                {
                    this.idEditora = value;
                }
                else
                {
                    throw new Exception("O campo editora é obrigatório!");
                }
            } }
        public int NumPaginas { get => numPaginas; set
            {
                if (value.ToString() != string.Empty)
                {
                    this.numPaginas = value;
                }
                else
                {
                    throw new Exception("O campo número de páginas é obrigatório!");
                }
            }
        }
        public DateTime DataCadastro { get => dataCadastro; set
            {
                if (value != null)
                {
                    this.dataCadastro = value;
                }
                else
                {
                    throw new Exception("O campo data de cadastro é obrigatório!");
                }
            }
        }
        public double Valor { get => valor; set
            {
                if (value.ToString() != string.Empty)
                {
                    this.valor = value;
                }
                else
                {
                    throw new Exception("O campo valor é obrigatório!");
                }
            }
        }
        public string Titulo { get => titulo; set
            {
                if (value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("O campo título é obrigatório!");
                }
            }
        }
    }
}