using ProjetoFinalBloco1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBloco1.Repository
{
    internal interface IProdutoRepository
    {
        public void CriarProduto(ModelProduto produto);
        public void ListarTodos();
        public void Procurar(int id);
        public void ProcurarPorNome(string nome);
        public void Deletar(int id);
        public void Atualizar(ModelProduto produto);
    }
}
