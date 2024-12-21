/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 18:33:56</date>
*	<description></description>
*/


using Dados;
using ObjetosZoo;
using System;

namespace RegrasZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 16/12/2024 18:33:56
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasTiposdeComidas
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
        /// Cria um novo tipo de comida com base nos parâmetros fornecidos.
        /// </summary>
        /// <param name="nomecomida">O nome do tipo de comida.</param>
        /// <param name="calorias">O número de calorias do tipo de comida.</param>
        /// <param name="dieta">A dieta associada ao tipo de comida.</param>
        /// <returns>True se o tipo de comida for criado com sucesso; False caso contrário.</returns>
        public static bool CriarTipoComida(string nomecomida, double calorias, DIETA dieta)
        {
            if(!string.IsNullOrEmpty(nomecomida) && calorias <= 0) return false;
            return TiposdeComidas.CriarTipoComida(nomecomida, calorias, dieta);
        }
        /// <summary>
        /// Obtém uma lista com todos os tipos de comida registados.
        /// </summary>
        /// <returns>Uma lista de objetos do tipo TipodeComida.</returns>
        public static List<TipodeComida> MostraTodosTipodeComida()
        {
            return TiposdeComidas.Listatipodecomidas;
        }
        /// <summary>
        /// Apaga um tipo de comida existente com base no nome fornecido.
        /// </summary>
        /// <param name="nomecomida">O nome do tipo de comida a apagar.</param>
        /// <returns>True se o tipo de comida for apagado com sucesso; False caso contrário.</returns>
        public static bool ApagarTipoComida(string nomecomida)
        {
            if (!string.IsNullOrEmpty(nomecomida)) return false;
            return TiposdeComidas.ApagarTipoComida(nomecomida);
        }

        /// <summary>
        /// Carrega os dados dos tipos de comida a partir de um ficheiro especificado.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro de dados de tipos de comida.</param>
        /// <returns>True se os dados forem carregados com sucesso.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro especificado não for encontrado.</exception>
        public static bool CarregaTiposdeComida(string filePath)
        {
            // Verifica se o ficheiro existe
            if (File.Exists(filePath))
            {
                TiposdeComidas.CarregaTiposdeComida(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }
            return true;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}