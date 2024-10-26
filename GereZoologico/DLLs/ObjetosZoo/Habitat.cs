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
    public class Habitat
    {
        #region Attributes

        int idhabitat;
        List<Animal> animaishabitat;

        #endregion

        #region Methods

        #region Constructors   
        public Habitat(int idhabitat)
        {
            this.idhabitat = idhabitat;
            animaishabitat = new List<Animal>();
        }

        #endregion

        #region Properties
        #endregion

        #region Operators 
        #endregion

        #region Overrides 
        public override string ToString()  
        {
            string outStr = String.Format("IDHabitat: {0}",idhabitat);
            return outStr;
        }
        #endregion

        #region OtherMethods
        public void MostraHabitat()
        {
            Console.WriteLine($"Habitat com ID:{idhabitat}");
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
        



     

       


    }
}
