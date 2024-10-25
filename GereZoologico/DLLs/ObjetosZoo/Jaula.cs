using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    public class Jaula
    {
        int idjaula;
        List<Animal> animaisjaula;



        public Jaula(int idjaula)
        {
            this.idjaula = idjaula;
            animaisjaula = new List<Animal>();
        }

        public void MostraJaula()
        {
            Console.WriteLine($"Jaula com ID:{idjaula}");
        }


        public override string ToString()  
        {
            string outStr = String.Format("IDJaula: {0}",idjaula);
            return outStr;
        }


    }
}
