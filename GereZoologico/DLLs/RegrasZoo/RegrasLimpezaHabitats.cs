﻿/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 16:13:41</date>
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
    /// Created on: 16/12/2024 16:13:41
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasLimpezaHabitats
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
        public static bool RegistarHabitatLimpo(Habitat habitat, DateTime horalimpeza)
        {
            if (habitat == null) return false;
            return LimpezaHabitats.RegistarHabitatLimpo(habitat, horalimpeza);
        }

        /// <summary>
        /// Mostra todos os registos de limpeza de habitats.
        /// </summary>
        /// <returns>Retorna true após exibir todos os registos.</returns>
        public static List<LimpezaHabitat> MostraTodosHabitatsLimpos()
        {
            return LimpezaHabitats.Listalimpezahabitats;
        }

        public static bool ApagarTodoRegistoLimpezaHabitat(Habitat habitat)
        {
            if (habitat == null) return false;
            return LimpezaHabitats.ApagarTodoRegistoLimpezaHabitat(habitat);
        }

        public static bool ApagarTodosRegistosdeLimpeza()
        {
            return LimpezaHabitats.ApagarTodosRegistosdeLimpeza();
        }

        public static int ApagarRegistoLimpeza(int idHabitat)
        {
           if(idHabitat < 0 ) return -2;
           return LimpezaHabitats.ApagarRegistoLimpeza(idHabitat);
        }


        public static bool CarregarLimpezasHabitats(string filePath)
        {
            if (File.Exists(filePath))
            {
                LimpezaHabitats.CarregarLimpezasHabitats(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }

        public static bool GuardarLimpezasHabitats(string filePath)
        {
            if (File.Exists(filePath)) LimpezaHabitats.GuardarLimpezasHabitats(filePath);
            return false;
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}