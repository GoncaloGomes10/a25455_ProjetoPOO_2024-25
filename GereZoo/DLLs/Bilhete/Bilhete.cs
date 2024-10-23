using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilhete
{
    public class Bilhete
    {
        string zona;
        double preço;

        public Bilhete(string zona, double preço)
        {
            this.zona = zona;
            this.preço = preço;

        }

        public void VerBilhete()
        {
            Console.WriteLine($"O teu bilhete custou {preço} euros para a zona: {zona}");
        }

    }
}