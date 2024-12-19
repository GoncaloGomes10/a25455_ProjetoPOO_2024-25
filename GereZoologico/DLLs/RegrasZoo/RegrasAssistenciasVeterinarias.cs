/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>14/12/2024 18:11:54</date>
*	<description></description>
*/


using ObjetosZoo;
using System;
using Dados;

namespace RegrasZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 14/12/2024 18:11:54
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasAssistenciasVeterinarias
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
        public static bool RegistaAssistenciaVeterinaria(Habitat habitat, Animal animal, DateTime datadotratamento)
        {
           if(habitat != null && animal != null) return AssistenciasVeterinarias.RegistaAssistenciaVeterinaria(habitat,animal,datadotratamento);
           return false;
        }

        public static List<AssistenciaVeterinaria> MostraTodosRegistosAssistenciaVeterinaria()
        {
            return AssistenciasVeterinarias.Listaassistenciaveterinaria;
        }

        public static int ApagaRegistos(Habitat habitat, Animal animal)
        {
            if(habitat != null && animal != null) return AssistenciasVeterinarias.ApagaRegistos(habitat, animal);
            return -3;
        }

        public static bool MostraRegistosDeAnimal(Animal animal)
        {
            if (animal != null) return AssistenciasVeterinarias.MostraRegistosDeAnimal(animal);
            return false;

        }

        public static int ApagarRegistoAssistencia(Animal animal)
        {
            if(animal !=null) return AssistenciasVeterinarias.ApagarRegistoAssistencia(animal);
            return -2;
        }

        public static bool ApagarTodosRegistos()
        {
            return AssistenciasVeterinarias.ApagarTodosRegistos();
        }
        public static bool EditaDataRegistoAssistencia(Habitat habitat, Animal animal, DateTime novaData)
        {
           if(habitat != null && animal != null) return AssistenciasVeterinarias.EditaDataRegistoAssistencia(habitat, animal, novaData);
           return false;
        }

        public static bool CarregarAssistenciasVeterinarias(string filePath)
        {
            if (File.Exists(filePath))
            {
               AssistenciasVeterinarias.CarregarAssistenciasVeterinarias(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }

        public static bool GuardarAssistenciasVeterinarias(string filePath)
        {
            if (File.Exists(filePath)) return AssistenciasVeterinarias.GuardarAssistenciasVeterinarias(filePath);
            return false;
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}