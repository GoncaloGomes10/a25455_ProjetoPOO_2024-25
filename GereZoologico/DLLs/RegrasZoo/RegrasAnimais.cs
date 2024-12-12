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

        public static bool CriarAnimal(string nome, string especie, int idade, double peso, DIETA dieta)
        {
            if (string.IsNullOrEmpty(nome)|| string.IsNullOrEmpty(especie)|| idade <= 0 || peso <= 0 ) return false;
            return Animais.CriarAnimal(nome, especie, idade, peso, dieta);

        }

        public static Animal? EncontraAnimal(int id)
        {
            if (id <= 0) return null;
            return Animais.EncontraAnimal(id);
            
        }

        public static List<Animal> MostraAnimais()
        {
            return Animais.Listaanimais;
        }

        public static bool ApagarAnimal(int id)
        {
            if(id <= 0) return false;
            return Animais.ApagarAnimal(id) ;
        }

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