using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    public class LimpezaJaula
    {
        Jaula jaula;
        DateTime horalimpeza;


        public LimpezaJaula (Jaula jaula, DateTime horalimpeza)
        {
            this.jaula = jaula;
            this.horalimpeza = horalimpeza;
        }

        public void JaulaLimpa()
        {
            Console.WriteLine($"{jaula} foi limpa: {horalimpeza}");
        }

        
        


    }
}