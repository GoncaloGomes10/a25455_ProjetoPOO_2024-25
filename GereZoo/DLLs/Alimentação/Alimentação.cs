using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alimentação
{
    public class Alimentacao : TipodeComida
    {
        DateTime tempoAlimentacao;
        double quantidade;

        public Alimentacao(DateTime tempoAlimentacao, double quantidade)
        {
            this.tempoAlimentacao = tempoAlimentacao;
            this.quantidade = quantidade;
        }


        public void RegistraAlimentacao()
        {
            Console.WriteLine($"");

        }
    }
}
