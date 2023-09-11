using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBloco1.Model
{
    public class ModelProduto
    {
        private string nome;
        private int id, tipo;
        private decimal preco;

        public ModelProduto(string nome, int id, int tipo, decimal preco)
        {
            this.nome = nome;
            this.id = id;
            this.tipo = tipo;
            this.preco = preco;
        }

        public string Nome { get { return nome; } set { this.nome = value; } }
        public int Id { get { return id; } set { this.id = value; } }
        public decimal Preco { get { return preco; } set { this.preco = value; } }
        public int Tipo { get { return tipo; } set { tipo = value; } }

        public virtual void Visualizar() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(
                $"\nO nome é {this.Nome}" +
                $"\nO id é {this.Id}" +
                $"\nO Preco é {this.Preco}"
                );
        }
    }
}
