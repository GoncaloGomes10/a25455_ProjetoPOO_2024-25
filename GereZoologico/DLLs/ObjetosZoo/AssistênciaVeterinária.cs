/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>26/10/2024 17:05:05</date>
*	<description></description>
*/


using System;

namespace ObjetosZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 26/10/2024 17:05:05
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class AssistênciaVeterinária
    {

        #region Attributes

        private Habitat habitat;
        private Animal animal;
        DateTime datadotratamento;
        public static List<AssistênciaVeterinária> assistênciaveterinária = new List<AssistênciaVeterinária>();

        #endregion

        #region Methods

        #region Constructors
        
        public AssistênciaVeterinária(Habitat habitat,Animal animal)
        {
            Habitat = habitat;
            Animal = animal;
            Datadotratamento = DateTime.Now;
        }

        #endregion

        #region Properties
        public Habitat Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public Animal Animal
        {
            get { return animal; }
            set { animal = value; }
        }

        public DateTime Datadotratamento
        {
            get { return datadotratamento; }
            set { datadotratamento = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"Animal tratado: {Animal}, Habitat: {Habitat}, Data: {Datadotratamento}";
        }

        #endregion

        #region OtherMethods

        public static bool RegistaAssistênciaVeterinária(Habitat habitat,Animal animal)
        {
            // Verifica se o animal está no habitat
            if (habitat.ContemAnimal(animal))
            {
                AssistênciaVeterinária tratamento = new AssistênciaVeterinária(habitat, animal);
                assistênciaveterinária.Add(tratamento);
                Console.WriteLine("Registo de assistência veterinária adicionado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine($"Erro: o animal {animal} não está no habitat {habitat}.");
                return false;
            }
        }

        public static void MostraTodosRegistosAssistênciaVeterinária()
        {
            foreach (var tratamento in assistênciaveterinária)
            {
                Console.WriteLine(tratamento.ToString());
            }
        }

        public static bool ApagaRegistos(Habitat habitat,Animal animal)
        {
            // Verifica se o animal está no habitat antes de tentar apagar o registo
            if (habitat.ContemAnimal(animal))
            {
                int removidos = assistênciaveterinária.RemoveAll(tratamento => tratamento.Habitat == habitat && tratamento.Animal == animal);

                if (removidos > 0)
                {
                    Console.WriteLine($"{removidos} registo(s) de assistência removido(s) para o animal {animal} no habitat {habitat}.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Nenhum registo de assistência encontrado para o animal e habitat ditos.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Erro: o animal {animal} não está no habitat {habitat}, portanto, não há registo para apagar.");
                return false;
            }
        }

        public static bool ApagarTodosRegistos()
        {
            int removidos = assistênciaveterinária.Count;
            assistênciaveterinária.Clear();

            if (removidos > 0)
            {
                Console.WriteLine($"{removidos} registo(s) de assistência foram apagados.");
                return true;
            }
            else
            {
                Console.WriteLine("Nenhum registo de assistência para apagar.");
                return false;
            }
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}