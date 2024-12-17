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
        public static bool CriarTipoComida(string nomecomida, double calorias, DIETA dieta)
        {
            if(!string.IsNullOrEmpty(nomecomida) && calorias <= 0) return false;
            return TiposdeComidas.CriarTipoComida(nomecomida, calorias, dieta);
        }

        public static List<TipodeComida> MostraTodosTipodeComida()
        {
            return TiposdeComidas.Listatipodecomidas;
        }

        public static bool ApagarTipoComida(string nomecomida)
        {
            if (!string.IsNullOrEmpty(nomecomida)) return false;
            return TiposdeComidas.ApagarTipoComida(nomecomida);
        }

       
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