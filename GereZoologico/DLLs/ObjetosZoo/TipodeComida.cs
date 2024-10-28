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

        private string nomecomida;
        private double calorias;

        #endregion

        #region Methods

        #region Constructors
        public TipoComida(string nomecomida, double calorias)
        {
            NomeComida = nomecomida;
            Calorias = calorias;
        }

        #endregion

        #region Properties
        public string NomeComida
        {
            get { return nomecomida; }
            set { nomecomida = value; }
        }

        public double Calorias
        {
            get { return calorias; }
            set { calorias = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides 
        public override string ToString()  
        {
            string outStr = String.Format(" {0} ,Calorias: {1}",NomeComida,Calorias);
            return outStr;
        }
        #endregion

        #region OtherMethods
        public bool MostraDetalhesTipodeComida()
        {
            Console.WriteLine($"Comida: {NomeComida}, Calorias: {Calorias}");
            return true;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
        
        
       
        
    }
}
