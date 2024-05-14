using GestaoDeEquipamentos.ConsoleApp;
using System.Linq.Expressions;
using System.Text;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static Equipamento[] equipamentos = new Equipamento[100];

        static int contadorEquipamentosCadastrados = 0;
        static void Main(string[] args)
        { 
           Equipamento equiptest =  new Equipamento("Notebook", "AEX120", "Acer", 2000.00m, DateTime.Now);
            equiptest.Id = GeradorId.GerarIdEquipamento();

            equipamentos[contadorEquipamentosCadastrados++] = equiptest;

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
                    Console.WriteLine();

                    Console.Write("Escolha uma das opções:");
                    char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

                    switch (operacaoEscolhida)
                    {
                        case '1': CadastarEquipamento(); break;
                        case '2': EditarEquipamento(); break;
                        case '3': ExcluirEquipamento(); break;
                        case '4': VisualizarEquipamentos(true); break;

                        default:; break;

                    }


                }

            }

        }

        private static void CadastarEquipamento()
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

            equipamento.Id = GeradorId.GerarIdEquipamento();

            equipamentos[contadorEquipamentosCadastrados++] = equipamento;

            Exibirmensagem("O equipamento foi cadastrado com sucesso!", ConsoleColor.Green);
        }

        static void VisualizarEquipamentos(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                Console.Clear();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("         GESTÃO DE EQUIPAMENTOS        ");
                Console.WriteLine("---------------------------------------");

                Console.WriteLine();

                Console.WriteLine("Visualizando Equipamento...");

            }

            Console.WriteLine();

            Console.WriteLine(
                "{0,-10} | {1,-15} | {2,-15} | {3,-10} | {4,-10}",
                "Id", "Nome", "Fabricante", "Preço", "Data de Fabricação"
                );

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if (e == null)
                    continue;

                Console.WriteLine(
                    "{0,-10} | {1,-15} | {2,-15} | {3,-10} | {4,-10}",
                    e.Id, e.Nome, e.Fabricante, e.PrecoAquisicao, e.DataFabricacao.ToShortDateString()
                    );

            }
            Console.ReadLine();

            Console.WriteLine();
        }

        public static void EditarEquipamento()
        {
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("         GESTÃO DE EQUIPAMENTOS        ");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine();

            Console.Write("Editando Equipamento...");

            Console.WriteLine();

            VisualizarEquipamentos(false);

            Console.Write("Digite o Id do equipamento que deseja editar:");
            int idEquipamentoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!EquipamentoExiste(idEquipamentoEscolhido))
            {
                Console.WriteLine("O equipamento mencionado não existe.", ConsoleColor.DarkYellow);
                return;
            }

            Console.Write("Digite o nome do equipamento:");
            string nome = Console.ReadLine();
            Console.Write("Digite o número da série:");
            string numeroSerie = Console.ReadLine();

            Console.Write("Digite o nome do fabricante do equipamento:");
            string fabricante = Console.ReadLine();

            Console.Write("Digite o preço de aquisição do equipamento: R$");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a data de fabricação do equipamento: (formato dd-mm-aaaa)");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoEquipamento = 
                new Equipamento(nome, numeroSerie, fabricante, precoAquisicao, dataFabricacao);

            novoEquipamento.Id = idEquipamentoEscolhido;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null)
                    continue;

                else if (equipamentos[i].Id == idEquipamentoEscolhido)
                {
                    equipamentos[i] = novoEquipamento;
                    break;
                }
            }

            Console.WriteLine(equipamentos);

            Console.ForegroundColor = ConsoleColor.Green;

            Exibirmensagem("O equipamento foi editado com sucesso!", ConsoleColor.Green);
        }
        public static void ExcluirEquipamento()
        {
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("         GESTÃO DE EQUIPAMENTOS        ");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine();

            Console.Write("Excluindo Equipamento...");

            Console.WriteLine();

            VisualizarEquipamentos(false);

            Console.Write("Digite o Id do equipamento que deseja excluir:");
            int equipamentoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!EquipamentoExiste(equipamentoEscolhido))
            {
                Console.WriteLine("O equipamento mencionado não existe.", ConsoleColor.DarkYellow);
                return;
            }

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null)
                    continue;

                else if (equipamentos[i].Id == equipamentoEscolhido)

                {
                    equipamentos[i] = null;
                    break;

                }
            }

            Exibirmensagem("O equipamento foi excluído com sucesso!", ConsoleColor.Green);
        }

        public static bool EquipamentoExiste(int IdEquipamento)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];
                if (e == null)
                    continue;

                else if (e.Id == IdEquipamento)
                    return true;
            }
            return false;
        }
        public static Equipamento EncontrarEquipamentoPorId(int idEscolhido)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if (e == null)
                    continue;

                if (e.Id == idEscolhido)
                    return e;
            }
            return null;
        }
        static void GerenciarChamados()
        {

        }

        private static void Exibirmensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();

            Console.WriteLine(mensagem);

            Console.ResetColor();

            Console.ReadLine();
        }
    }

}