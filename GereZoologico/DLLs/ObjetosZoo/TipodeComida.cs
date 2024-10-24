using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    public enum Dieta
    {
        Carnivoro,
        Herbivoro,
        Omnivoro
    }
    public class TipoComida
    {
        public Dieta dieta;
        public string nome;
        public double calorias;

        public TipoComida(string nome, double calorias, Dieta dieta)
        {
            this.nome = nome;
            this.calorias = calorias;
            this.dieta = dieta;
        }
        
        public bool MostraDetalhesTipodeComida()
        {
            Console.WriteLine($"Comida: {nome}, Calorias: {calorias}, Tipo:{dieta}");
            return true;
        }

    }
}
