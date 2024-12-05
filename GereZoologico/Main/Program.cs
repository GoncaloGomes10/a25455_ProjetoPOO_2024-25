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
            ////UTILIZADOR LOGADO
            //Utilizador? userlogado = null ;
            //int? tipologado = null;

            // Criar habitats
            Habitat.CriarHabitat(1, "Leões", ZONA.Savana);
            Habitat.CriarHabitat(2, "Elefante da Savana", ZONA.Savana);
            Habitat.CriarHabitat(3, "Camelos",ZONA.Deserto);
            Habitat.CriarHabitat(4, "Dromedários", ZONA.Deserto);
            Habitat.CriarHabitat(5, "Golfinhos", ZONA.Aquática);
            Habitat.CriarHabitat(6, "Tubarões-Tigres", ZONA.Aquática);
            Habitat.CriarHabitat(7, "Gorilas", ZONA.Floresta);
            Habitat.CriarHabitat(8, "Pandas-Vermelhos", ZONA.Floresta);

            string caminhodoficheiro3 = @"C:\Users\gonca\OneDrive\Ambiente de Trabalho\a25455_ProjetoPOO_2024-25\GereZoologico\Espetaculos-do-mes.txt";
            GereFicheiros.CarregarEspetaculos(caminhodoficheiro3);
            string caminhodoficheiro2 = @"C:\Users\gonca\OneDrive\Ambiente de Trabalho\a25455_ProjetoPOO_2024-25\GereZoologico\TiposComida.txt";
            GereFicheiros.CarregaTiposdeComida(caminhodoficheiro2); 
            TipoComida.MostraTodosTipodeComida();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            string caminhodoficheiro1 = @"C:\Users\gonca\OneDrive\Ambiente de Trabalho\a25455_ProjetoPOO_2024-25\GereZoologico\Animais.txt";
            GereFicheiros.CarregaAnimais(caminhodoficheiro1);
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Animal.MostraAnimais();

            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Encontrar um animal:");
            Animal? animal = Animal.EncontraAnimal(1);
            Console.WriteLine(animal);



            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Alimentacao.RegistraAlimentacao(Animal.animais[0], DateTime.Now, 20, TipoComida.tipocomidas[0]);
            Alimentacao.RegistraAlimentacao(Animal.animais[1], DateTime.Now, 20, TipoComida.tipocomidas[1]);
            Alimentacao.MostraTodasAlimentacoes();
            Alimentacao.ApagarAlimentacao(1);
            Alimentacao.MostraTodasAlimentacoes();
            

            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Bilhete.ComprarBilhete(ZONA.Savana, TIPOBILHETE.Passeio, 12.5);
            Bilhete.ComprarBilhete(ZONA.Deserto, TIPOBILHETE.Completo, 20);
            Bilhete.VerTodosBilhetes();
            Bilhete.ApagarBilhete(Bilhete.bilhetes[0]);
            Bilhete.ApagarTodosBilhetes();

            Console.WriteLine("---------------------------------------------------------------------------------------------");
           /* Espetáculo.CriarEspetaculo(1,TIPOESPETÁCULO.Leão,"Espetáculo do Leão",DateTime.Now);
            Espetáculo.CriarEspetaculo(2, TIPOESPETÁCULO.Leão, "Espetáculo do Leão", DateTime.Now);
            Espetáculo.CriarEspetaculo(3, TIPOESPETÁCULO.Leão, "Espetáculo do Leão", DateTime.Now);
            Espetáculo.CriarEspetaculo(4, TIPOESPETÁCULO.Tubarão, "Espetáculo do Tubarão", DateTime.Now);*/
            Espetáculo.MostrarTodosEspetaculos();
            //Espetáculo.ApagarEspetaculo(Espetáculo.espetaculos[0]);
            Espetáculo.ApagarTodosEspetaculos();


            Console.WriteLine("---------------------------------------------------------------------------------------------");
            AssistênciaVeterinária.RegistaAssistênciaVeterinária(Habitat.habitats[0],Animal.animais[0]);
            AssistênciaVeterinária.RegistaAssistênciaVeterinária(Habitat.habitats[1],Animal.animais[1]);
            AssistênciaVeterinária.MostraTodosRegistosAssistênciaVeterinária();
            AssistênciaVeterinária.ApagaRegistos(Habitat.habitats[1], Animal.animais[1]);
            AssistênciaVeterinária.ApagaRegistos(Habitat.habitats[0], Animal.animais[0]);
            AssistênciaVeterinária.ApagarTodosRegistos();

            Console.WriteLine("---------------------------------------------------------------------------------------------");
            //Habitat.habitats[0].RemoverAnimalHabitat(Animal.animais[0]);
            //Habitat.habitats[0].RemoverAnimalHabitat(Animal.animais[1]);
            Habitat.MostraHabitatsAnimais();
            Habitat.MostraTodosHabitats();


            Console.WriteLine("---------------------------------------------------------------------------------------------");
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0],DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0], DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[0], DateTime.Now);
            LimpezaHabitat.RegistarHabitatLimpo(Habitat.habitats[1], DateTime.Now);
            LimpezaHabitat.MostraTodosHabitatsLimpos();
            LimpezaHabitat.ApagarTodoRegistoLimpezaHabitat(Habitat.habitats[0]);
            LimpezaHabitat.ApagarTodosRegistosdeLimpeza();


          
            Utilizador.Registo("DiegoMilos", "password", "milos@mail.com", "Milos", "99292929", 2);
            Utilizador.Registo("MilosFunc", "password", "milosfunc@mail.com", "MilosFunc", "09090909", 1);

            Utilizador.VerificaAutenticação();

            Utilizador.Login("DiegoMilos", "password");

            Utilizador.VerificaAutenticação();


        }
    }
}