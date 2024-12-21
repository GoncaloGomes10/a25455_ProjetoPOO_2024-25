/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>07/12/2024 17:50:47</date>
*	<description></description>
*/


using System;
using ObjetosZoo;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 07/12/2024 17:50:47
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Animais
    {
        #region Attributes
        private static List<Animal> listaanimais = new List<Animal>();

        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<Animal> Listaanimais
        {
            get { return listaanimais; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Carrega informações dos animais de um ficheiro para a lista de animais.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro com informações dos animais.</param>
        /// <returns>Retorna true se o carregamento for bem-sucedido.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro não for encontrado.</exception>
        /// <exception cref="Exception">Lançada se o formato de uma linha do ficheiro estiver incorreto.</exception>
        public static bool CarregaAnimais(string filePath)
        {
                // Lê todas as linhas do ficheiro
                string[] linhas = File.ReadAllLines(filePath);

                // Para cada linha no ficheiro, processa o conteúdo
                foreach (string linha in linhas)
                {
                    // Divide a linha em partes
                    string[] partes = linha.Split(';');

                    // Verifica se há exatamente 6 partes
                    if (partes.Length == 6)
                    {
                        string nome = partes[0];
                        string especie = partes[1];
                        int idade = int.Parse(partes[2]);
                        double peso = double.Parse(partes[3]);
                        DIETA dieta = (DIETA)Enum.Parse(typeof(DIETA), partes[4]);
                        int idHabitat = int.Parse(partes[5]);

                        // Cria o objeto Animal e adiciona-o à lista de animais
                        Animal animal = new Animal(nome, especie, idade, peso, dieta);
                        Animais.listaanimais.Add(animal);

                        Habitats.AdicionarAnimal(idHabitat, animal);
                       
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

            return true;
        }

        /// <summary>
        /// Guarda os dados dos animais num ficheiro especificado, incluindo informações como nome, espécie, idade, peso, dieta e habitat.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro onde os dados dos animais serão guardados.</param>
        /// <returns>Retorna 1 se os dados dos animais foram guardados com sucesso, ou -1 em caso de erro.</returns>
        public static int GuardaAnimais(string filePath)
        {
            try
            {
                // Lista para armazenar as linhas que serão gravadas no ficheiro
                List<string> linhas = new List<string>();

                // Itera pela lista de animais
                foreach (Animal animal in Animais.listaanimais)
                {
                    // Formata os dados do animal em uma linha
                    string linha = string.Join(";",
                        animal.Nome,
                        animal.Especie,
                        animal.Idade.ToString(),
                        animal.Peso.ToString("F2"),
                        animal.Dieta.ToString(),
                        Habitats.ObterIdHabitat(animal));

                    // Adiciona a linha à lista de linhas
                    linhas.Add(linha);
                }

                // Escreve todas as linhas no ficheiro
                File.WriteAllLines(filePath, linhas);

                return 1;
            }
            catch
            {
                return -1;
            }
        }




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
            listaanimais.Add(animal);
            return true;
        }


        /// <summary>
        /// Procura um animal específico pelo ID.
        /// </summary>
        /// <param name="id">ID do animal a ser encontrado.</param>
        /// <returns>Retorna o animal se encontrado; caso contrário, retorna null.</returns>
        public static Animal? EncontraAnimal(int id)
        {
            Animal? animal = listaanimais.Find(animais => animais.Id == id);
            if (animal != null)
            {
                return animal;
            }
            else
            {
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
            Animal? animal = listaanimais.Find(animal => animal.Id == id);
            if (animal != null)
            {
                listaanimais.Remove(animal);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Seleciona aleatoriamente um animal de uma espécie específica.
        /// </summary>
        /// <param name="especie">Espécie desejada do animal.</param>
        /// <returns>Retorna um animal aleatório da espécie; null se não houver animais da espécie.</returns>
        public static Animal? EscolherAnimalAleatorio(string especie)
        {
            // Filtra os animais pela espécie desejada
            var animaisDaEspecie = listaanimais.Where(a => a.Especie == especie).ToList();

            // Verifica se há animais disponíveis para a espécie especificada
            if (animaisDaEspecie.Count == 0) return null;

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