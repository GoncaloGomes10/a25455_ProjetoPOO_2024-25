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
    public class Habitat
    {
        #region Attributes

        int idhabitat;
        string nomehabitat;
        List<Animal> animaishabitat;

        #endregion

        #region Methods

        #region Constructors   
        public Habitat(int idhabitat, string nomehabitat)
        {
            this.idhabitat = idhabitat;
            animaishabitat = new List<Animal>();
            this.nomehabitat = nomehabitat;
        }

        #endregion

        #region Properties
        #endregion

        #region Operators 
        #endregion

        #region Overrides 
        public override string ToString()  
        {
            string outStr = String.Format("IDHabitat: {0} Nome Habitat: {1}",idhabitat,nomehabitat);
            return outStr;
        }
        #endregion

        #region OtherMethods
        public void MostraHabitat()
        {
            Console.WriteLine($"Habitat dos/as {nomehabitat} com ID:{idhabitat}");
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
        



     

       


    }
}
