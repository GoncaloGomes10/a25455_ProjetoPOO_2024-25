/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>14/12/2024 18:55:33</date>
*	<description></description>
*/


using System;
using ObjetosZoo;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 14/12/2024 18:55:33
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Bilhetes
    {
        #region Attributes
        private static List<Bilhete> listabilhetes = new List<Bilhete>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<Bilhete> Listabilhetes
        {
            get { return listabilhetes; }
        }
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Permite comprar um bilhete e adicioná-lo à lista de bilhetes comprados.
        /// </summary>
        /// <param name="zona">Zona do zoológico para a qual o bilhete é válido.</param>
        /// <param name="tipobilhete">Tipo do bilhete (Passeio, Espetáculo, Completo).</param>
        /// <param name="preço">Preço do bilhete.</param>
        /// <returns>Retorna true se o bilhete for comprado com sucesso.</returns>
        public static bool ComprarBilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            Bilhete bilhete = new Bilhete(zona, tipobilhete, preço);
            listabilhetes.Add(bilhete);
            return true;
        }

        public static bool ApagarTodosBilhetes()
        {
            int removidos = listabilhetes.Count;
            listabilhetes.Clear();

            if (removidos > 0) return true;
            return false;
        }

        public static bool ApagarBilhete(Bilhete bilheterecebido)
        {
            Bilhete? bilhete = listabilhetes.Find(a => a.Id == bilheterecebido.Id);
            if (bilhete != null)
            {
                listabilhetes.Remove(bilhete);
                return true;
            }
            return false;
        }


        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}