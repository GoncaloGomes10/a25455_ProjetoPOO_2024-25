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
        ZONA zona;
        private int idhabitat;
        private string nomehabitat;
        public List<Animal> animaishabitat;
        public static List<Habitat> habitats = new List<Habitat>();

        #endregion

        #region Methods

        #region Constructors   
        public Habitat(int idhabitat, string nomehabitat, ZONA zona)
        {
            IdHabitat = idhabitat;
            animaishabitat = new List<Animal>();
            NomeHabitat = nomehabitat;
            Zona = zona;   
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
        public ZONA Zona
        {
            get { return zona; }
            set { zona = value; }
        }
        #endregion

        #region Operators 
        #endregion

        #region Overrides 
        public override string ToString()  
        {
            string outStr = String.Format("IDHabitat: {0} Nome Habitat: {1} Zona: {2}",IdHabitat,NomeHabitat,Zona);
            return outStr;
        }
        #endregion

        #region OtherMethods

        public static bool CriarHabitat(int idhabitat,string nomehabitat,ZONA zona)
        {
            Habitat habitat = new Habitat(idhabitat, nomehabitat, zona);
            habitats.Add(habitat);
            return true;

        }
        public void MostraHabitat()
        {
            Console.WriteLine(this.ToString());
        }

        public static void MostraTodosHabitats()
        {
            foreach(var habitat in habitats)
            {
                habitat.MostraHabitat();
            }
        }

        public static void MostraHabitatsAnimais()
        {
            foreach (Habitat habitat in habitats)
            {
                Console.WriteLine(habitat);  // Imprime o habitat

                // Verifica o número de animais no habitat
                Console.WriteLine($"Número de animais no habitat {habitat.NomeHabitat}: {habitat.animaishabitat.Count}");

                if (habitat.animaishabitat.Count > 0)
                {
                    foreach (Animal animal in habitat.animaishabitat)
                    {
                        Console.WriteLine("  - " + animal);  // Imprime cada animal do habitat
                    }
                }
                else
                {
                    Console.WriteLine("  Nenhum animal neste habitat.");
                }
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
            
            
        public bool RemoverAnimalHabitat(Animal animalrecebido)
        {
            Animal? animal = this.animaishabitat.Find(animal => animal.Id == animalrecebido.Id);
            if (animal != null)
            {
                animaishabitat.Remove(animal);
                Console.WriteLine("Animal retirado do habitat");
                return true;
            }
            else
            {
                Console.WriteLine("Animal não está no habitat");
                return false;
            }
        }

        public bool ContemAnimal(Animal animal)
        {
            return animaishabitat.Contains(animal);
        }

        #endregion

        #region Destructor
        #endregion

        #endregion









    }
}
