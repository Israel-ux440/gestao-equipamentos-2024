using GestaoEquipamentos.ConsoleApp.Apresentacao;
using GestaoEquipamentos.ConsoleApp.Dominio;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Program
    {
    
        static void Main(string[] args)
        { 
            TelaEquipamento telaEquipamento = new TelaEquipamento();

            bool opcaoSairEscolhida = false;

            while (!opcaoSairEscolhida)
            {
                char opcaoEscolhida = ApresentarMenuPrincipal();

                switch (opcaoEscolhida)
                {
                    case '1':
                        char operacaoEscolhida = telaEquipamento.ApresentarMenu();

                        if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                            break;

                        if (operacaoEscolhida == '1')
                            telaEquipamento.CadastarEquipamento();

                        else if (operacaoEscolhida == '2')
                            telaEquipamento.EditarEquipamento();

                        else if (operacaoEscolhida == '3')
                            telaEquipamento.ExcluirEquipamento();

                        else if (operacaoEscolhida == '4')
                            telaEquipamento.VisualizarEquipamentos(true);

                        break;

                    default: opcaoSairEscolhida = true; break;
                }

            }

        }

        private static char ApresentarMenuPrincipal()
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
            return opcaoEscolhida;
        }

        public static void Exibirmensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();

            Console.WriteLine(mensagem);

            Console.ResetColor();

            Console.ReadLine();
        }
    }

}
        