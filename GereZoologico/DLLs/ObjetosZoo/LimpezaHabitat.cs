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
    /// Representa o registo de limpeza de um habitat, incluindo o habitat e a hora da limpeza.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    public class LimpezaHabitat
    {
        #region Attributes

        private Habitat habitat;
        private DateTime horalimpeza;

        public string Display => $"{Habitat} - {HoraLimpeza}";

        #endregion

        #region Methods

        #region Constructors  

        /// <summary>
        /// Construtor da classe LimpezaHabitat, que associa um habitat e a hora da limpeza.
        /// </summary>
        /// <param name="habitat">O habitat que foi limpo.</param>
        /// <param name="horalimpeza">A hora em que a limpeza ocorreu.</param>
        public LimpezaHabitat(Habitat habitat, DateTime horalimpeza)
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





        #endregion
    }


    #region Destructor
    #endregion

    #endregion
}
