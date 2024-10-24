using System;
using ObjetosZoo;


namespace Main // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TipoComida tipo1 = new TipoComida("Pernas Coelho", 350.4,Dieta.Carnivoro);
            TipoComida.MostraDetalhesTipoComida(tipo1);

            
        }
    }
}