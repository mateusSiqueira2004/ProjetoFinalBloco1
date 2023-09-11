using ProjetoFinalBloco1.Model;
using ProjetoFinalBloco1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBloco1.Controller
{
    public class ControllerProduto : IProdutoRepository
    {
        int id = 0;
        string nome = null;
        private readonly List<ModelProduto> listaProdutos = new();

        public void Atualizar(ModelProduto produto)
        {
            var buscarProduto = BuscarnaCollection(produto.Id);
            if (buscarProduto != null)
            {
                var indexOf = listaProdutos.IndexOf(buscarProduto);
                listaProdutos[indexOf] = produto;
                Console.WriteLine($"O produto {produto.Id} foi atualizada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {id} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void CriarProduto(ModelProduto produto)
        {
            listaProdutos.Add(produto);
        }

        public void Deletar(int id)
        {
            var buscarProduto = BuscarnaCollection(id);
            if (buscarProduto != null)
            {
                if (listaProdutos.Remove(buscarProduto) == true)
                    Console.WriteLine($"O Produto {id} foi removido com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {id} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void ListarTodos()
        {
            foreach (var produto in listaProdutos)
            {
                produto.Visualizar();
            }
        }

        public void Procurar(int id)
        {
            var produto = BuscarnaCollection(id);
            if (produto is not null)
                produto.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {id} não foi encontrada!");
                Console.ResetColor();
            }
        }
        public int GerarId()
        {
            return ++id;
        }


        public ModelProduto? BuscarnaCollection(int id)
        {
            foreach (var model in listaProdutos)
            {
                if (model.Id == id)
                {
                    return model;
                }
            }
            return null;
        }
        public ModelPerecivel? BuscarnaCollectionPerecivel(int id)
        {
            foreach (var model in listaProdutos)
            {
                if (model.Id == id)
                {
                    return (ModelPerecivel?)model;
                }
            }
            return null;
        }
        public int RetornarTipo(int id)
        {
            foreach (var model in listaProdutos)
            {
                if (model.Id == id)
                {
                    return model.Tipo;
                }
            }
            return 0;
        }

        public void ProcurarPorNome(string nome)
        {
            var listarNome = from produto in listaProdutos where produto.Nome.Contains(nome) select produto;
            listarNome.ToList().ForEach(p => p.Visualizar());
        }
    }
}
