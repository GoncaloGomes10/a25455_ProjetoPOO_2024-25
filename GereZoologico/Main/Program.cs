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
            // Criar habitats
            Habitat.CriarHabitat(1, "Leões", ZONA.Savana);
            Habitat.CriarHabitat(2, "Elefante da Savana", ZONA.Savana);
            Habitat.CriarHabitat(3, "Camelos",ZONA.Deserto);
            Habitat.CriarHabitat(4, "Dromedários", ZONA.Deserto);
            Habitat.CriarHabitat(5, "Golfinhos", ZONA.Aquática);
            Habitat.CriarHabitat(6, "Tubarões-Tigres", ZONA.Aquática);
            Habitat.CriarHabitat(7, "Gorilas", ZONA.Floresta);
            Habitat.CriarHabitat(8, "Pandas-Vermelhos", ZONA.Floresta);


            string caminhoDoFicheiro = @"C:\Users\gonca\OneDrive\Ambiente de Trabalho\a25455_ProjetoPOO_2024-25\GereZoologico\Animais.txt";
            GereFicheiros.CarregaAnimais(caminhoDoFicheiro);
            Animal.MostraAnimais();

            Console.WriteLine("Encontrar um animal:");
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

            AssistênciaVeterinária.RegistaAssistênciaVeterinária(Habitat.habitats[0],Animal.animais[0]);
            AssistênciaVeterinária.RegistaAssistênciaVeterinária(Habitat.habitats[1],Animal.animais[1]);
            AssistênciaVeterinária.MostraTodosRegistosAssistênciaVeterinária();
            AssistênciaVeterinária.ApagaRegistos(Habitat.habitats[1], Animal.animais[1]);
            AssistênciaVeterinária.ApagaRegistos(Habitat.habitats[0], Animal.animais[0]);
            AssistênciaVeterinária.ApagarTodosRegistos();


            //Habitat.habitats[0].RemoverAnimalHabitat(Animal.animais[0]);
            //Habitat.habitats[0].RemoverAnimalHabitat(Animal.animais[1]);
            Habitat.MostraHabitatsAnimais();
            Habitat.MostraTodosHabitats();
           


            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0],DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0], DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0], DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[1], DateTime.Now);
            LimpezaHabitat.MostraTodosHabitatsLimpos();
            LimpezaHabitat.ApagarTodoRegistoLimpezaHabitat(Habitat.habitats[0]);
            LimpezaHabitat.ApagarTodosRegistosdeLimpeza();
            
            

            

            


        }
    }
}