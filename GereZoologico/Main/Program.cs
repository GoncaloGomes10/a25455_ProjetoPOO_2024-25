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

            string caminhoDoFicheiro = @"C:\Users\gonca\OneDrive\Ambiente de Trabalho\a25455_ProjetoPOO_2024-25\GereZoologico\Animais.txt";
            GereFicheiros.CarregaAnimais(caminhoDoFicheiro);
            Animal.MostraAnimais();
            
            Animal? animal = Animal.EncontraAnimal(1);
            Console.WriteLine(animal);


            TipoComida.CriarTipoComida("Pernas galinha", 27.3,DIETA.Carnivoro);
            TipoComida.CriarTipoComida("Mato", 15.2, DIETA.Herbivoro);
            TipoComida.MostraTodosTipodeComida();

            Alimentacao.RegistraAlimentacao(Animal.animais[0], DateTime.Now, 20, TipoComida.tipocomidas[0]);
            Alimentacao.RegistraAlimentacao(Animal.animais[1], DateTime.Now, 20, TipoComida.tipocomidas[1]);
            Alimentacao.MostraTodasAlimentacoes();


            Bilhete.ComprarBilhete(ZONA.Savana, TIPOBILHETE.Passeio, 12.5);
            Bilhete.ComprarBilhete(ZONA.Deserto, TIPOBILHETE.Completo, 20);
            Bilhete.VerTodosBilhetes();

            
            Habitat.CriarHabitat(1, "Leao",ZONA.Savana);
            Habitat.CriarHabitat(2, "Elefante", ZONA.Savana);
            Habitat.habitats[0].AdicionaAnimalHabitat(Animal.animais[0]);
            Habitat.habitats[0].AdicionaAnimalHabitat(Animal.animais[0]);
            Habitat.habitats[1].AdicionaAnimalHabitat(Animal.animais[1]);
            Habitat.habitats[1].AdicionaAnimalHabitat(Animal.animais[1]);

            Habitat.habitats[0].RemoverAnimalHabitat(Animal.animais[0]);
            Habitat.habitats[0].RemoverAnimalHabitat(Animal.animais[1]);
            Habitat.MostraTodosHabitats();
            Habitat.habitats[0].MostraHabitat();


            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0],DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0], DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0], DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[1], DateTime.Now);
            LimpezaHabitat.MostraTodosHabitatsLimpos();
            LimpezaHabitat.ApagarTodoRegistoLimpezaHabitat(Habitat.habitats[0]);
            
            

            

            


        }
    }
}