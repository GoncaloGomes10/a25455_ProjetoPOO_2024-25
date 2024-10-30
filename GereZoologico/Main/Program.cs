/*
*	<copyright file="Main" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>26/10/2024 16:27:23</date>
*	<description></description>
*/

using System;
using ObjetosZoo;


namespace Main 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal.CriarAnimal("Manel","Leao",12,250.3,DIETA.Carnivoro);
            Animal.CriarAnimal("Josefina","Elefante",20,700.4,DIETA.Herbivoro);

            TipoComida tipo1 = new TipoComida("Pernas Coelho", 350.4);
            tipo1.MostraDetalhesTipodeComida();

            Alimentacao.RegistraAlimentacao(Animal.animais[0], DateTime.Now, 20, tipo1);
            Alimentacao.RegistraAlimentacao(Animal.animais[1], DateTime.Now, 20, tipo1);
            Alimentacao.MostraTodasAlimentacoes();


            Bilhete.ComprarBilhete(ZONA.Savana, TIPOBILHETE.Passeio, 12.5);
            Bilhete.ComprarBilhete(ZONA.Deserto, TIPOBILHETE.Completo, 20);
            Bilhete.VerTodosBilhetes();

            
            Habitat.CriarHabitat(1, "Macaco");
            Habitat.CriarHabitat(2, "Cegonhas");
            Habitat.habitats[0].AdicionaAnimalHabitat(Animal.animais[0]);
            Habitat.habitats[0].AdicionaAnimalHabitat(Animal.animais[0]);
            Habitat.MostraTodosHabitats();


            LimpezaHabitat limpezahabitat1 =new LimpezaHabitat(Habitat.habitats[0], DateTime.Now);
            limpezahabitat1.RegistrarHabitatLimpo();

            Animal.MostraAnimais();

            


        }
    }
}