/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>28/10/2024 15:25:57</date>
*	<description></description>
*/


using System;

namespace ObjetosZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 28/10/2024 15:25:57
    /// </summary>
    public class Cliente : Utilizador
    {
        #region Attributes
        private double saldo;

        #endregion

        #region Methods

        #region Constructors
        public Cliente(string username, string password, string email, string nome, string nif, double saldo)
            : base(username, password, email, nome, nif)
        {
         Saldo = saldo;
        }

        #endregion

        #region Properties

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

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