/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 15:33:44</date>
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
    /// Created on: 16/12/2024 15:33:44
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasEspetaculos
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
        public static bool CriarEspetaculo(int id, TIPOESPETACULO tipoespetaculo, string nome, DateTime horario)
        {
            if(id <=0 && !string.IsNullOrEmpty(nome) && horario == null) return false;
            return Espetaculos.CriarEspetaculo(id, tipoespetaculo, nome, horario);
        }

        public static List<Espetaculo> MostrarTodosEspetaculos()
        {
            return Espetaculos.Listaespetaculos;
        }

        public static bool ApagarEspetaculo(Espetaculo espetaculorecebido)
        {
            if(espetaculorecebido == null) return false;
            return Espetaculos.ApagarEspetaculo(espetaculorecebido);
        }

        /// <summary>
        /// Carrega informações dos espetáculos de um ficheiro para a lista de espetáculos.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro com informações dos espetáculos.</param>
        /// <returns>Retorna true se o carregamento for bem-sucedido.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro não for encontrado.</exception>
        /// <exception cref="Exception">Lançada se o formato de uma linha do ficheiro estiver incorreto.</exception>
        public static bool CarregarEspetaculos(string filePath)
        {
            // Verifica se o ficheiro existe
            if (File.Exists(filePath))
            {
               Espetaculos.CarregarEspetaculos(filePath);
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