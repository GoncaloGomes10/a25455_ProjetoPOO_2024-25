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
    public enum TIPOESPETÁCULO
    {
        Elefante,
        Golfinho,
        Tubarão,
        Leão
    }
    public class Espetáculo
    {
        #region Attributes 

        private int id;
        private TIPOESPETÁCULO tipoespetaculo;

        #endregion

        #region Methods

        #region Constructors

        public Espetáculo(int id, TIPOESPETÁCULO tipoespetaculo)
        {
            Id = id;
            TipoEspetaculo = tipoespetaculo;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public TIPOESPETÁCULO TipoEspetaculo
        {
            get { return tipoespetaculo; }
            set { tipoespetaculo = value; }
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
