/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 16:13:17</date>
*	<description></description>
*/


using ObjetosZoo;
using System;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 16/12/2024 16:13:17
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class LimpezaHabitats
    {
        #region Attributes
        private static List<LimpezaHabitat> listalimpezahabitats = new List<LimpezaHabitat>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<LimpezaHabitat> Listalimpezahabitats
        {
            get { return listalimpezahabitats; }
        }
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Registra uma limpeza de habitat e adiciona o registo à lista de limpezas.
        /// </summary>
        /// <param name="habitat">O habitat que foi limpo.</param>
        /// <param name="horalimpeza">A hora em que a limpeza ocorreu.</param>
        /// <returns>Retorna true após registar a limpeza.</returns>
        public static bool RegistarHabitatLimpo(Habitat habitat, DateTime horalimpeza)
        {
            LimpezaHabitat limpeza = new LimpezaHabitat(habitat, horalimpeza);
            listalimpezahabitats.Add(limpeza);
            return true;
        }

        /// <summary>
        /// Apaga todos os registos de limpeza para um habitat específico.
        /// </summary>
        /// <param name="habitat">O habitat cujos registos de limpeza serão apagados.</param>
        /// <returns>Retorna true se a limpeza foi apagada, ou false caso contrário.</returns>
        public static bool ApagarTodoRegistoLimpezaHabitat(Habitat habitat)
        {

            int removidos = listalimpezahabitats.RemoveAll(limpeza => limpeza.Habitat == habitat);
            if (removidos > 0) return true;
            return false;
        }

        /// <summary>
        /// Apaga todos os registos de limpeza existentes.
        /// </summary>
        /// <returns>Retorna true se algum registo foi apagado, ou false caso contrário.</returns>
        public static bool ApagarTodosRegistosdeLimpeza()
        {
            int removidos = listalimpezahabitats.Count;
            listalimpezahabitats.Clear();

            if (removidos > 0) return true;
            return false;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}