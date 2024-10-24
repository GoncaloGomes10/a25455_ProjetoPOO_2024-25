using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjetosZoo
{
    public class Animal
    {
        string especie;
        int idade;
        double peso;

        public Animal(string especie, int idade, double peso)
        {
            this.especie = especie;
            this.idade = idade;
            this.peso = peso;
        }

        public void MostraAnimal()
        {
            Console.WriteLine($"");
        }
    }
}
