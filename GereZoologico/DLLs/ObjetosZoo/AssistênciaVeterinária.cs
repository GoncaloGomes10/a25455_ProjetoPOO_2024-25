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
    /// Classe que representa um registo de assistência veterinária a um animal.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 17:05:05
    /// </summary>
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
        /// <summary>
        /// Construtor para criar um registo de assistência veterinária.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal se encontra.</param>
        /// <param name="animal">O animal que recebeu assistência veterinária.</param>
        public AssistênciaVeterinária(Habitat habitat, Animal animal)
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
        /// <summary>
        /// Retorna uma string com as principais informações sobre o tratamento realizado.
        /// </summary>
        /// <returns>String com o animal tratado, habitat e data do tratamento.</returns>
        public override string ToString()
        {
            return $"Animal tratado: {Animal}, Habitat: {Habitat}, Data: {Datadotratamento}";
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Regista uma nova assistência veterinária para um animal específico no seu habitat.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal se encontra.</param>
        /// <param name="animal">O animal que receberá assistência veterinária.</param>
        /// <returns>Retorna true se o registo for adicionado com sucesso, false caso contrário.</returns>
        public static bool RegistaAssistênciaVeterinária(Habitat habitat, Animal animal)
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

        /// <summary>
        /// Exibe todos os registos de assistência veterinária no console.
        /// </summary>
        public static void MostraTodosRegistosAssistênciaVeterinária()
        {
            foreach (var tratamento in assistênciaveterinária)
            {
                Console.WriteLine(tratamento.ToString());
            }
        }

        /// <summary>
        /// Apaga os registos de assistência veterinária para um animal específico no habitat dado.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal se encontra.</param>
        /// <param name="animal">O animal cujos registos serão apagados.</param>
        /// <returns>Retorna true se houver registos apagados, false caso contrário.</returns>
        public static bool ApagaRegistos(Habitat habitat, Animal animal)
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

        /// <summary>
        /// Apaga todos os registos de assistência veterinária.
        /// </summary>
        /// <returns>Retorna true se algum registo for apagado, false caso contrário.</returns>
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