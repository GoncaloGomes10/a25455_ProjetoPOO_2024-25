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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
    public class TipoComida
    {
        #region Attributes

        public string nome;
        public double calorias;

        #endregion

        #region Methods

        #region Constructors
        public TipoComida(string nome, double calorias)
        {
            this.nome = nome;
            this.calorias = calorias;
        }
        
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides 
        public override string ToString()  
        {
            string outStr = String.Format(" {0} ,Calorias: {1}",nome,calorias);
            return outStr;
        }
        #endregion

        #region OtherMethods
        public bool MostraDetalhesTipodeComida()
        {
            Console.WriteLine($"Comida: {nome}, Calorias: {calorias}");
            return true;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
        
        
       
        
    }
}
