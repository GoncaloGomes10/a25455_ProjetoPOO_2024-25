/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 15:50:56</date>
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
    /// Created on: 16/12/2024 15:50:56
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasHabitats
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
        public static bool CriarHabitat(int idhabitat, string nomehabitat, ZONA zona)
        {
            if(idhabitat <= 0 && !string.IsNullOrEmpty(nomehabitat)) return false;
            return Habitats.CriarHabitat(idhabitat, nomehabitat, zona);
        }


        public static List<Habitat> MostraTodosHabitats()
        {
            return Habitats.Listahabitats;
        }


        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}