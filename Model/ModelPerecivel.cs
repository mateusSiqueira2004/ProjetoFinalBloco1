using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBloco1.Model
{
    public class ModelPerecivel : ModelProduto
    {
        private string validade;
        public ModelPerecivel(string nome, int id, int tipo, decimal preco, string validade) : base(nome, id, tipo, preco)
        {
            this.validade = validade;
        }
        public string Validade 
        {
            get { return validade; } 
            set => this.validade = value;  
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"\nA validade é {validade}");
        }
    }
}
