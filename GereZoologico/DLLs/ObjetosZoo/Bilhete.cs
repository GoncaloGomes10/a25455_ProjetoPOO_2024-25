using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    public enum ZONA
    {
        Savana,
        Deserto,
        Aquática
    }

    public enum TIPOBILHETE
    {
        Passeio,
        Espetáculo,
        Completo
    }
    public class Bilhete
    {
        ZONA zona;
        TIPOBILHETE tipobilhete;
        double preço;

        public Bilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            this.zona = zona;
            this.preço = preço;
            this.tipobilhete = tipobilhete;

        }

        public void VerBilhete()
        {
            Console.WriteLine($"O teu bilhete do tipo {tipobilhete} custou {preço} euros para a zona: {zona}");
        }

    }
}