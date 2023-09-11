using ProjetoFinalBloco1.Controller;
using ProjetoFinalBloco1.Model;

namespace ProjetoFinalBloco1
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int confirm, tipo, id;
            string nome, validade, estado;
            decimal preco;

            ControllerProduto ctrl = new();
            
            while (true)
            {
                confirm = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(
                    "\n######################################################\n" +
                    "\n                  Bem-vindo a Lojinha                  " +
                    "\n                  ¨¨¨¨¨¨¨¨¨ ¨ ¨¨¨¨¨¨¨                  " +
                    "\n                                                       " +
                    "\n      1- Criar o produto                               " +
                    "\n      2- Listar Produtos                               " +
                    "\n      3- Atualizar Produtos                            " +
                    "\n      4- Buscar Produto por id                         " +
                    "\n      5- Buscar Produto por nome                       " +
                    "\n      6- Sair                                          " +
                    "\n\n######################################################\n"
                    );
                try
                {
                    confirm = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.ResetColor();

                    switch( confirm )
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Cadastro de Produto\n");

                            Console.WriteLine("\nDigite o nome do Produto: ");
                            nome = Console.ReadLine();
                            nome ??= string.Empty;

                            do
                            {
                                Console.WriteLine("\nDigite o tipo do Produto (1 para Perecível e 2 para não Perecível): ");
                                tipo = Convert.ToInt32(Console.ReadLine());
                            } while (tipo != 1 && tipo != 2);

                            Console.WriteLine("\nDigite o preco do produto: ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("\nDigite a validade: ");
                                    validade = Console.ReadLine();
                                   
                                    ctrl.CriarProduto(new ModelPerecivel(nome, ctrl.GerarId(), tipo, preco, validade));
                                    Console.Clear();
                                    KeyPress();
                                    break;

                                case 2:
                                    Console.WriteLine("\nDigite o estado do produto: ");
                                    estado = Console.ReadLine();
                                  
                                    ctrl.CriarProduto(new ModelNaoPerecivel(nome, ctrl.GerarId(), tipo, preco, estado));
                                    Console.Clear();
                                    KeyPress();
                                    break;
                            }
                            break;
                        case 2:
                            ctrl.ListarTodos();
                            KeyPress();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Digite o id do produto:");
                            id = Convert.ToInt32(Console.ReadLine());

                            if (ctrl.BuscarnaCollection(id) is not null)
                            {

                                Console.WriteLine("\nDigite o novo nome do Produto: ");
                                nome = Console.ReadLine();
                                nome ??= string.Empty;

                                Console.WriteLine("\nDigite o novo preco do produto: ");
                                preco = Convert.ToDecimal(Console.ReadLine());

                                tipo = ctrl.RetornarTipo(id);

                                var produto = ctrl.BuscarnaCollectionPerecivel(id);
                                switch (tipo)
                                {
                                    case 1:

                                        ctrl.Atualizar(new ModelPerecivel(nome, id, tipo, preco, produto.Validade));
                                        Console.Clear();
                                        KeyPress();
                                        break;

                                    case 2:
                                        Console.WriteLine("\nDigite o estado atual do produto: ");
                                        estado = Console.ReadLine();

                                        ctrl.Atualizar(new ModelNaoPerecivel(nome, id, tipo, preco, estado));
                                        Console.Clear();
                                        KeyPress();
                                        break;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"O produto {id} não foi encontrada!");
                                Console.ResetColor();
                            }
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Digite o id do produto:");
                            id = Convert.ToInt32(Console.ReadLine());
                            ctrl.Procurar(id);
                            KeyPress();
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Digite o Nome do produto: ");
                            nome = Console.ReadLine();

                            ctrl.ProcurarPorNome(nome);
                            KeyPress();
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(
                                "\n=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+++=+=+=+=+=+=+=+=+=+=+=" +
                                "\nLojinha - Só tem esse nome pois me falta Criatividade\n" +
                                "Cuidado com seu CMD\n");
                            KeyPress();
                            Sobre();
                            System.Environment.Exit(0);
                            break;
                    }
                }catch (FormatException)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insira valores validos");
                    KeyPress();
                }
            }
        }
            static void Sobre()
            {
                Console.WriteLine("\n*********************************************************");
                Console.WriteLine("Projeto Desenvolvido por: ");
                Console.WriteLine("Mateus Siqueira - mateussiqueirasalomao@gmail.com");
                Console.WriteLine("github.com/mateusSiqueira2004");
                Console.WriteLine("*********************************************************");
                Console.ResetColor();
            }
            public static void KeyPress()
            {
                do
                {
                    Console.Write("\nPressione Enter para Continuar...");
                    consoleKeyInfo = Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                } while (consoleKeyInfo.Key != ConsoleKey.Enter);
            }
    }
}