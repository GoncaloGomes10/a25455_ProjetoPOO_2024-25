/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>28/10/2024 15:24:43</date>
*	<description></description>
*/


using System;
using System.Globalization;

namespace ObjetosZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 28/10/2024 15:24:43
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Funcionário : Utilizador
    {
        #region Attributes
        public static List<Funcionário>funcionários = new List<Funcionário> ();

        #endregion

        #region Methods

        #region Constructors
        public Funcionário(string username, string password, string email ,string nome, string nif)
            :base(username,password,email,nome,nif)
        {

        }
 
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}