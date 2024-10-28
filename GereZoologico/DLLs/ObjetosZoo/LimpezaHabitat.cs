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
    public class LimpezaHabitat
    {
        #region Attributes

        private Habitat habitat;
        private DateTime horalimpeza;

        #endregion

        #region Methods

        #region Constructors  
        public LimpezaHabitat (Habitat habitat, DateTime horalimpeza)
        {
            Habitat = habitat;
            HoraLimpeza = horalimpeza;
        }
        #endregion

        #region Properties

        public Habitat Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public DateTime HoraLimpeza
        {
            get { return horalimpeza; }
            set { horalimpeza = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public void RegistrarHabitatLimpo()
        {
            Console.WriteLine($"{Habitat} foi limpa: {HoraLimpeza}");
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
        

      

        
        
        


    }
}