namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static Equipamento[] equipamentos = new Equipamento[100];

        static int contadorEquipamentosCadastrados = 0;
        static void Main(string[] args)
        {
            equipamentos[contadorEquipamentosCadastrados++] =
                new Equipamento("Notebook", "AEX120", "Acer", 2000.00m, DateTime.Now);

            bool opcaoSairEscolhida = false;

            while (!opcaoSairEscolhida)
            {
                Console.Clear();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("         GESTÃO DE EQUIPAMENTOS        ");
                Console.WriteLine("---------------------------------------");

                Console.WriteLine();

                Console.WriteLine("1 - Gerência de Equipamentos");
                Console.WriteLine("2 - Controle de Chamadas [Não Disponível] ");
                Console.WriteLine("S - Sair");

                Console.WriteLine();

                Console.Write("Escolha uma das opções:");
                char opcaoEscolhida = Console.ReadLine()[0];

                switch (opcaoEscolhida)
                {
                    case '1': GerenciarEquipamentos(); break;
                    case '2': GerenciarChamados(); break;
                    case '3': break;

                    default: opcaoSairEscolhida = true; break;
                }

                static void GerenciarEquipamentos()
                {
                    Console.Clear();

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("         GESTÃO DE EQUIPAMENTOS        ");
                    Console.WriteLine("---------------------------------------");

                    Console.WriteLine("1 - Cadasrtar Equipamentos");
                    Console.WriteLine("2 - Editar Equipamentos ");
                    Console.WriteLine("3 - Excluir Equipamentos");
                    Console.WriteLine("4 - Visualizar Equipamentos");

                    Console.WriteLine("S - Voltar");

                    Console.Write("Escolha uma das opções");
                    char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

                    switch (operacaoEscolhida)
                    {
                        case '1': CadastarEquipamento(); break;
                        case '2':; break;
                        case '3':; break;
                        case '4': VisualizarEquipamentos(); break;

                        default:; break;

                    }

                    Console.ReadLine();

                }

            }

            Console.ReadLine();

        }

        static void CadastarEquipamento()
        {
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("         GESTÃO DE EQUIPAMENTOS        ");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Cadastrando Equipamento...");

            Console.WriteLine();

            Console.Write("Digite o nome do equipamento:");
            string nome = Console.ReadLine();

            Console.Write("Digite o número da série:");
            string numeroSerie = Console.ReadLine();

            Console.Write("Digite o nome do fabricante do equipamento:");
            string Fabricante = Console.ReadLine();

            Console.Write("Digite o preço de aquisição do equipamento: R$");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a data de fabricação do equipamento: (formato dd-mm-aaaa)");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento equipamento = new Equipamento(nome, numeroSerie, Fabricante, precoAquisicao, dataFabricacao);

            equipamentos[contadorEquipamentosCadastrados++] = equipamento;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();

            Console.WriteLine("O equipamento foi cadastrado com sucesso");

            Console.ResetColor();

            Console.ReadLine();

        }

        static void VisualizarEquipamentos()
        {
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("         GESTÃO DE EQUIPAMENTOS        ");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Visualizando Equipamento...");

            Console.WriteLine();

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if (e == null)
                    continue;
                Console.WriteLine($"{e.Nome}\t{e.Fabricante}\t {e.NumeroSerie}\t{e.PrecoAquisicao}\t");
            }
            Console.ReadLine();
        }

        static void GerenciarChamados()
        {

        }
    }
}
