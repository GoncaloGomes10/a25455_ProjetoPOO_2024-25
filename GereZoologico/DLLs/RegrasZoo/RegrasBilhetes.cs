/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>14/12/2024 18:56:02</date>
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
    /// Created on: 14/12/2024 18:56:02
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasBilhetes
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
        public static bool ComprarBilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            if(preço <= 0) return false;
            return Bilhetes.ComprarBilhete(zona, tipobilhete,preço);
        }

        public static List<Bilhete> VerTodosBilhetes()
        {
            return Bilhetes.Listabilhetes;
        }


        public static bool ApagarTodosBilhetes()
        {
            return Bilhetes.ApagarTodosBilhetes();
        }

        public static bool ApagarBilhete(Bilhete bilheterecebido)
        {
            if(bilheterecebido == null) return false;
            return Bilhetes.ApagarBilhete(bilheterecebido);
        }

        public static bool GuardarBilhetes(string filePath)
        {
            if (File.Exists(filePath)) Bilhetes.GuardarBilhetes(filePath);
            return false;
        }

        public static bool CarregarBilhetes(string filePath)
        {
            if (File.Exists(filePath))
            {
                Bilhetes.CarregarBilhetes(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }

        public static bool CarregarPrecosBilhetes(string filePath)
        {
            if (File.Exists(filePath))
            {
                Bilhetes.CarregarPrecosBilhetes((string)filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }
        public static decimal ObterPreco(TIPOBILHETE tipoBilhete)
        {
            return Bilhetes.ObterPreco(tipoBilhete);
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}