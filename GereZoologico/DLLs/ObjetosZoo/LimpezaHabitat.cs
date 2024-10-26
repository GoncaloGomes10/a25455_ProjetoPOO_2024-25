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
    public class LimpezaHabitat
    {
        #region Attributes
        Habitat habitat;
        DateTime horalimpeza;

        #endregion

        #region Methods

        #region Constructors  
        public LimpezaHabitat (Habitat habitat, DateTime horalimpeza)
        {
            this.habitat = habitat;
            this.horalimpeza = horalimpeza;
        }
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public void HabitatLimpo()
        {
            Console.WriteLine($"{habitat} foi limpa: {horalimpeza}");
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
        

      

        
        
        


    }
}