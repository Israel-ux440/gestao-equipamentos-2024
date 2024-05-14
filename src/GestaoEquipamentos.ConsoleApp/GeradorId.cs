using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentos.ConsoleApp
{
    public static class GeradorId
    {
        private static int IdEquipamento = 0;

        public static int GerarIdEquipamento()

        {
            return ++IdEquipamento;
        }

    }
}
