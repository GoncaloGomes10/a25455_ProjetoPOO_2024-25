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

        private int idhabitat;
        private string nomehabitat;
        public List<Animal> animaishabitat;
        public static List<Habitat> habitats = new List<Habitat>();

        #endregion

        #region Methods

        #region Constructors   
        public Habitat(int idhabitat, string nomehabitat)
        {
            IdHabitat = idhabitat;
            animaishabitat = new List<Animal>();
            NomeHabitat = nomehabitat;
        }

        #endregion

        #region Properties
        public int IdHabitat
        {
            get { return idhabitat; }
            set { idhabitat = value; }
        }
        public string NomeHabitat
        {
            get { return nomehabitat; }
            set { nomehabitat = value; }
        }

        #endregion

        #region Operators 
        #endregion

        #region Overrides 
        public override string ToString()  
        {
            string outStr = String.Format("IDHabitat: {0} Nome Habitat: {1}",IdHabitat,NomeHabitat);
            return outStr;
        }
        #endregion

        #region OtherMethods

        public static bool CriarHabitat(int idhabitat,string nomehabitat)
        {
            Habitat habitat = new Habitat(idhabitat, nomehabitat);
            habitats.Add(habitat);
            return true;

        }
        public void MostraHabitat()
        {
            Console.WriteLine($"Habitat dos/as {NomeHabitat} com ID:{IdHabitat}");
        }

        public static void MostraTodosHabitats()
        {
            foreach(var habitat in habitats)
            {
                habitat.MostraHabitat();
            }
        }

        public bool AdicionaAnimalHabitat(Animal animal)
        {
            if (animaishabitat.Contains(animal))
            {
                Console.WriteLine("O animal já está no habitat");
            }
            else
            {
                Console.WriteLine("Animal adicionado no habitat");
                animaishabitat.Add(animal);
            }

            return true;

        }
        
        #endregion

        #region Destructor
        #endregion

        #endregion
        



     

       


    }
}
