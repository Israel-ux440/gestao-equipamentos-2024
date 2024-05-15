using GestaoEquipamentos.ConsoleApp.Dominio;

namespace GestaoEquipamentos.ConsoleApp.Infraestrutura
{
    internal class RepositorioEquipamento
    {
        private Equipamento[] equipamentos = new Equipamento[100];
        private int contadorEquipamentosCadastrados = 0;

        public void CadastrarEquipamento()
        {
            equipamento.Id = GeradorId.GerarIdEquipamento();

            equipamentos[contadorEquipamentosCadastrados++] = equipamento;
        }

        public bool EditarEquipamento()
        {

        }

        public bool ExcluirEquipamento()
        {

        }

        public Equipamento[] SelecionarEquipamentos()
        {

        }

        public bool ExisteEquipamento() 
        { 
        
        }

        private void RegistrarItem(Equipamento equipamento)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] != null) 
                    continue;

                else
                {
                    equipamentos[i] = equipamento;
                    break;
                }
            }
        }
    }
}
