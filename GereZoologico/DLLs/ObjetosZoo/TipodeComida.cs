using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObjetosZoo
{ 
    public class TipoComida
    {
        public string nome;
        public double calorias;

        public TipoComida(string nome, double calorias)
        {
            this.nome = nome;
            this.calorias = calorias;
        }
        
        public bool MostraDetalhesTipodeComida()
        {
            Console.WriteLine($"Comida: {nome}, Calorias: {calorias}");
            return true;
        }

        public override string ToString()  
        {
            string outStr = String.Format("Nome: {0}\t Calorias: {1}\t",nome,calorias);
            return outStr;
        }

    }
}
