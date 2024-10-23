using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipodeComida
{
    public enum Dieta
    {
        Carnivoro,
        Herbivoro,
        Omnivoro
    }
    public class TipoComida
    {
        Dieta dieta;
        string nome;
        double calorias;

        public TipoComida(string nome, double calorias, Dieta dieta)
        {
            this.nome = nome;
            this.calorias = calorias;
            this.dieta = dieta;
        }
        
        public void MostraDetalhesTipodeComida()
        {
            Console.WriteLine($"Comida: {nome}, Calorias: {calorias}");
        }

    }
}
