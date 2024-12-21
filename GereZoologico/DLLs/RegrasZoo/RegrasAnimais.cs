/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>10/12/2024 18:24:38</date>
*	<description></description>
*/


using System;
using Dados;
using ObjetosZoo;

namespace RegrasZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 10/12/2024 18:24:38
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasAnimais
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Carrega os dados dos animais a partir de um ficheiro especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro que contém os dados dos animais.</param>
        /// <returns>Retorna verdadeiro se os animais foram carregados com sucesso.</returns>
        /// <exception cref="FileNotFoundException">Lança uma exceção se o ficheiro não for encontrado.</exception>
        public static bool CarregaAnimais(string filePath)
        {
            if (File.Exists(filePath))
            {
                Animais.CarregaAnimais(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }
        /// <summary>
        /// Guarda os dados dos animais num ficheiro especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro onde os dados dos animais serão guardados.</param>
        /// <returns>Retorna -2 em caso de erro ao tentar guardar os dados dos animais.</returns>
        public static int GuardaAnimais(string filePath)
        {
            if (File.Exists(filePath)) Animais.GuardaAnimais(filePath);
            return -2;
        }
        /// <summary>
        /// Cria um novo animal com os dados fornecidos.
        /// </summary>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="especie">Espécie do animal.</param>
        /// <param name="idade">Idade do animal.</param>
        /// <param name="peso">Peso do animal.</param>
        /// <param name="dieta">Dieta do animal.</param>
        /// <returns>Retorna verdadeiro se o animal foi criado com sucesso, caso contrário, retorna falso.</returns>
        public static bool CriarAnimal(string nome, string especie, int idade, double peso, DIETA dieta)
        {
            if (string.IsNullOrEmpty(nome)|| string.IsNullOrEmpty(especie)|| idade <= 0 || peso <= 0 ) return false;
            return Animais.CriarAnimal(nome, especie, idade, peso, dieta);

        }
        /// <summary>
        /// Encontra um animal com base no seu ID.
        /// </summary>
        /// <param name="id">ID do animal a ser encontrado.</param>
        /// <returns>Retorna o animal correspondente ao ID fornecido, ou nulo se não for encontrado.</returns>
        public static Animal? EncontraAnimal(int id)
        {
            if (id <= 0) return null;
            return Animais.EncontraAnimal(id);
            
        }
        /// <summary>
        /// Mostra todos os animais registados.
        /// </summary>
        /// <returns>Retorna uma lista de todos os animais registados.</returns>
        public static List<Animal> MostraAnimais()
        {
            return Animais.Listaanimais;
        }
        /// <summary>
        /// Apaga um animal com base no seu ID.
        /// </summary>
        /// <param name="id">ID do animal a ser apagado.</param>
        /// <returns>Retorna verdadeiro se o animal foi apagado com sucesso, caso contrário, retorna falso.</returns>
        public static bool ApagarAnimal(int id)
        {
            if(id <= 0) return false;
            return Animais.ApagarAnimal(id) ;
        }
        /// <summary>
        /// Escolhe aleatoriamente um animal de uma determinada espécie.
        /// </summary>
        /// <param name="especie">Espécie do animal a ser escolhido.</param>
        /// <returns>Retorna o animal escolhido aleatoriamente da espécie especificada, ou nulo se não encontrar nenhum.</returns>
        public static Animal? EscolherAnimalAleatorio(string especie)
        {
            if(string.IsNullOrEmpty(especie)) return null;
            return Animais.EscolherAnimalAleatorio(especie);
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}