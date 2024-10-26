/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>26/10/2024 16:24:23</date>
*	<description></description>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 26/10/2024 16:24:23
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public enum ZONA
    {
        Savana,
        Deserto,
        Aquática
    }
    public enum TIPOBILHETE
    {
        Passeio,
        Espetáculo,
        Completo
    }
    public class Bilhete
    {
        #region Attributes 

        ZONA zona;
        TIPOBILHETE tipobilhete;
        double preço;

        #endregion

        #region Methods

        #region Constructors 
        public Bilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            this.zona = zona;
            this.preço = preço;
            this.tipobilhete = tipobilhete;

        }
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public void VerBilhete()
        {
            Console.WriteLine($"O teu bilhete do tipo {tipobilhete} custou {preço} euros para a zona: {zona}");
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
       

        

        

    }
}