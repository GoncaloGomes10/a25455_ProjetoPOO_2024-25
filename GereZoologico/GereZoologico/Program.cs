using System;
using ObjetosZoo;


namespace Main // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TipoComida tipo1 = new TipoComida("Pernas Coelho", 350.4);
            tipo1.MostraDetalhesTipodeComida();

            Alimentacao alimentacao1 =new Alimentacao(new DateTime(2025,10,23,20,35,45),5.4,tipo1);
            alimentacao1.RegistraAlimentacao();

            Bilhete bilhete1 = new Bilhete(ZONA.Savana, TIPOBILHETE.Passeio, 12.5);
            bilhete1.VerBilhete();

            Jaula jaula1 = new Jaula(1);
            jaula1.MostraJaula();

            LimpezaJaula limpezajaula1 =new LimpezaJaula(jaula1,DateTime.Now);
            limpezajaula1.JaulaLimpa();

            Animal.CriarAnimal("Manel","Leao",12,250.3,DIETA.Carnivoro);


        }
    }
}