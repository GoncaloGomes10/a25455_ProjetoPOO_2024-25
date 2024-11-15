/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>26/10/2024 16:24:23</date>
*	<description></description>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace ObjetosZoo
{
    /// <summary>
    /// Enumerado de tipos de dieta que um animal pode ter.
    /// </summary>
    public enum DIETA
    {
        Carnivoro,
        Herbivoro,
        Omnivoro
    }

    /// <summary>
    /// Class que representa um animal no zoológico.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    
    public class Animal
    {
        #region Attributes

        private DIETA dieta; 
        private int id; 
        private static int idstatic; 
        private string nome; 
        private string especie; 
        private int idade; 
        private double peso; 
        public static List<Animal> animais = new List<Animal>(); 

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Constructor para criar um animal com os atributos principais.
        /// </summary>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="especie">Espécie do animal.</param>
        /// <param name="idade">Idade do animal em anos.</param>
        /// <param name="peso">Peso do animal em quilogramas.</param>
        /// <param name="dieta">Tipo de dieta do animal.</param>
        public Animal(string nome, string especie, int idade, double peso, DIETA dieta)
        {
            idstatic++;
            id = idstatic;
            Nome = nome;
            Especie = especie;
            Idade = idade;
            Peso = peso;
            Dieta = dieta;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public DIETA Dieta
        {
            get { return dieta; }
            set { dieta = value; }
        }

        #endregion

        #region Operators 

        #endregion

        #region Overrides
        /// <summary>
        /// Retorna uma string formatada com as principais informações do animal.
        /// </summary>
        /// <returns>String com nome, espécie, idade, peso, dieta e ID do animal.</returns>
        public override string ToString()
        {
            return String.Format("Nome: {0} Especie: {1} Idade: {2} Peso: {3} kg Tipo: {4} Id: {5}", Nome, Especie, Idade, Peso, Dieta, Id);
        }

        #endregion

        #region OtherMethods 
        /// <summary>
        /// Cria um novo animal e adiciona-o à lista de animais.
        /// </summary>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="especie">Espécie do animal.</param>
        /// <param name="idade">Idade do animal em anos.</param>
        /// <param name="peso">Peso do animal em quilogramas.</param>
        /// <param name="dieta">Tipo de dieta do animal.</param>
        /// <returns>Retorna true se o animal for criado e adicionado com sucesso.</returns>
        public static bool CriarAnimal(string nome, string especie, int idade, double peso, DIETA dieta)
        {
            Animal animal = new Animal(nome, especie, idade, peso, dieta);
            animais.Add(animal);
            return true;
        }

        /// <summary>
        /// Exibe todos os animais da lista na consola.
        /// </summary>
        /// <returns>Retorna true após exibir a lista.</returns>
        public static bool MostraAnimais()
        {
            foreach (var animal in animais)
            {
                Console.WriteLine(animal.ToString());
            }
            return true;
        }

        /// <summary>
        /// Procura um animal específico pelo ID.
        /// </summary>
        /// <param name="id">ID do animal a ser encontrado.</param>
        /// <returns>Retorna o animal se encontrado; caso contrário, retorna null.</returns>
        public static Animal? EncontraAnimal(int id)
        {
            Animal? animal = animais.Find(animais => animais.Id == id);
            if (animal != null)
            {
                return animal;
            }
            else
            {
                Console.WriteLine($"Animal com ID {id} não existe.");
                return null;
            }
        }

        /// <summary>
        /// Remove um animal da lista com base no ID.
        /// </summary>
        /// <param name="id">ID do animal a ser removido.</param>
        /// <returns>Retorna true se o animal for removido com sucesso; caso contrário, false.</returns>
        public static bool ApagarAnimal(int id)
        {
            Animal? animal = animais.Find(animal => animal.Id == id);
            if (animal != null)
            {
                animais.Remove(animal);
                Console.WriteLine($"Animal com ID {id} foi removido.");
                return true;
            }
            else
            {
                Console.WriteLine($"Animal com ID {id} não encontrado.");
                return false;
            }
        }

        /// <summary>
        /// Seleciona aleatoriamente um animal de uma espécie específica.
        /// </summary>
        /// <param name="especie">Espécie desejada do animal.</param>
        /// <returns>Retorna um animal aleatório da espécie; null se não houver animais da espécie.</returns>
        public static Animal? EscolherAnimalAleatorio(string especie)
        {
            // Filtra os animais pela espécie desejada
            var animaisDaEspecie = animais.Where(a => a.Especie == especie).ToList();

            // Verifica se há animais disponíveis para a espécie especificada
            if (animaisDaEspecie.Count == 0)
            {
                Console.WriteLine($"Nenhum animal disponível para a espécie {especie}.");
                return null;
            }

            // Seleciona aleatoriamente um animal da lista filtrada
            Random random = new Random();
            int index = random.Next(animaisDaEspecie.Count);
            return animaisDaEspecie[index];
        }

        #endregion

        #region Destructor
        #endregion

        #endregion


    }

}
