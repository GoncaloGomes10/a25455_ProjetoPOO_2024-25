using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjetosZoo
{
    public class Alimentacao
    {
        Animal animal;
        DateTime tempoAlimentacao;
        double quantidade;
        TipoComida tipocomida;


        public Alimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipoComida tipocomida)
        {
            this.animal = animal;
            this.tempoAlimentacao = tempoAlimentacao;
            this.quantidade = quantidade;
            this.tipocomida = tipocomida;
        }


        public void RegistraAlimentacao()
        {
            Console.WriteLine($"Animal: {animal} Tempo: {tempoAlimentacao}, Quantidade(kg): {quantidade}, Tipo:{tipocomida}");

        }
    }
}
