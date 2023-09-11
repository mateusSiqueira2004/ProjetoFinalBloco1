using ProjetoFinalBloco1.Model;

namespace ProjetoFinalBloco1
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int confirm;

            ModelPerecivel mp = new("bolacha", 1, 1, 10000, "13/05/2026");
            while (true)
            {
                confirm = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(
                    "\n######################################################\n" +
                    "\n                  Bem-vindo a Lojinha                  " +
                    "\n                  ¨¨¨¨¨¨¨¨¨ ¨ ¨¨¨¨¨¨¨" +
                    "\n     " +
                    "\n      1- Criar o produto" +
                    "\n      2- Listar Produtos" +
                    "\n      3- Atualizar Produtos" +
                    "\n      4- Buscar Produto por id" +
                    "\n      5- Buscar Produto por nome" +
                    "\n      6- Sair" +
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

                            break;
                        case 2:
                            mp.Visualizar();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
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