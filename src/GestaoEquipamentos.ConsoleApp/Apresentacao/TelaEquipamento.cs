namespace GestaoEquipamentos.ConsoleApp.Apresentacao
{
    public class TelaEquipamento
    {
        public void ApresentarMenu()
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

