/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>14/12/2024 18:56:02</date>
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
    /// Created on: 14/12/2024 18:56:02
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasBilhetes
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
        /// Efetua a compra de um bilhete com base na zona, tipo de bilhete e preço fornecidos.
        /// </summary>
        /// <param name="zona">Zona onde o bilhete será comprado.</param>
        /// <param name="tipobilhete">Tipo de bilhete a ser comprado.</param>
        /// <param name="preço">Preço do bilhete.</param>
        /// <returns>Retorna verdadeiro se a compra foi bem-sucedida, caso contrário, retorna falso.</returns>
        public static bool ComprarBilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            if(preço <= 0) return false;
            return Bilhetes.ComprarBilhete(zona, tipobilhete,preço);
        }
        /// <summary>
        /// Obtém todos os bilhetes disponíveis na lista.
        /// </summary>
        /// <returns>Retorna uma lista com todos os bilhetes.</returns>
        public static List<Bilhete> VerTodosBilhetes()
        {
            return Bilhetes.Listabilhetes;
        }

        /// <summary>
        /// Apaga todos os bilhetes da lista.
        /// </summary>
        /// <returns>Retorna verdadeiro se os bilhetes foram apagados com sucesso.</returns>
        public static bool ApagarTodosBilhetes()
        {
            return Bilhetes.ApagarTodosBilhetes();
        }
        /// <summary>
        /// Apaga um bilhete específico da lista.
        /// </summary>
        /// <param name="bilheterecebido">Bilhete a ser removido.</param>
        /// <returns>Retorna verdadeiro se o bilhete foi removido com sucesso, caso contrário, retorna falso.</returns>
        public static bool ApagarBilhete(Bilhete bilheterecebido)
        {
            if(bilheterecebido == null) return false;
            return Bilhetes.ApagarBilhete(bilheterecebido);
        }
        /// <summary>
        /// Guarda todos os bilhetes em um ficheiro especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro onde os bilhetes serão guardados.</param>
        /// <returns>Retorna verdadeiro se os bilhetes foram guardados com sucesso.</returns>
        public static bool GuardarBilhetes(string filePath)
        {
            if (File.Exists(filePath)) Bilhetes.GuardarBilhetes(filePath);
            return false;
        }
        /// <summary>
        /// Carrega os bilhetes de um ficheiro especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro contendo os dados dos bilhetes.</param>
        /// <returns>Retorna verdadeiro se os bilhetes foram carregados com sucesso.</returns>
        /// <exception cref="FileNotFoundException">Lança uma exceção se o ficheiro não for encontrado.</exception>
        public static bool CarregarBilhetes(string filePath)
        {
            if (File.Exists(filePath))
            {
                Bilhetes.CarregarBilhetes(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }
        /// <summary>
        /// Carrega os preços dos bilhetes a partir de um ficheiro especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro contendo os preços dos bilhetes.</param>
        /// <returns>Retorna verdadeiro se os preços dos bilhetes foram carregados com sucesso.</returns>
        /// <exception cref="FileNotFoundException">Lança uma exceção se o ficheiro não for encontrado.</exception>
        public static bool CarregarPrecosBilhetes(string filePath)
        {
            if (File.Exists(filePath))
            {
                Bilhetes.CarregarPrecosBilhetes((string)filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }
        /// <summary>
        /// Obtém o preço de um bilhete com base no seu tipo.
        /// </summary>
        /// <param name="tipoBilhete">Tipo de bilhete para o qual se deseja obter o preço.</param>
        /// <returns>Retorna o preço do bilhete, ou 0 se o tipo de bilhete não tiver preço definido.</returns>
        public static decimal ObterPreco(TIPOBILHETE tipoBilhete)
        {
            return Bilhetes.ObterPreco(tipoBilhete);
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}