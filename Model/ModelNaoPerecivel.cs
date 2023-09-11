using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBloco1.Model
{
    public class ModelNaoPerecivel : ModelProduto
    {
        private string estado;
        public ModelNaoPerecivel(string nome, int id, int tipo, decimal preco, string estado) : base(nome, id, tipo, preco)
        {
            this.estado = estado;
        }
        public string Estado { get { return estado; } set => this.estado = value; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"\nO estado atual do produto é {this.Estado}");
        }
    }
}
