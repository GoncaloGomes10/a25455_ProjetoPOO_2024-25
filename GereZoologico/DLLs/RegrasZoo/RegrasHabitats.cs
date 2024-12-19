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
            if(idhabitat < 0 && !string.IsNullOrEmpty(nomehabitat)) return false;
            return Habitats.CriarHabitat(idhabitat, nomehabitat, zona);
        }

        public static List<Habitat> MostraHabitats()
        {
            return Habitats.Listahabitats;
        }

        public static bool AdicionarAnimal(int idhabitat, Animal animal)
        {
            if(idhabitat < 0 &&  animal == null) return false;
            return Habitats.AdicionarAnimal(idhabitat, animal);
        }

        public static int RemoverAnimal(int idhabitat, int idAnimal)
        {
            if (idhabitat < 0 && idAnimal < 0) return -3;
            return Habitats.RemoverAnimal(idhabitat, idAnimal);
        }

        public static List<Animal>? MostrarAnimais(int idhabitat)
        {
            if(idhabitat < 0) return null;
            return Habitats.MostrarAnimais(idhabitat);
        }

        public static int ObterIdHabitat(Animal animal)
        {
            if (animal == null) return -1;
            return Habitats.ObterIdHabitat(animal);
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}