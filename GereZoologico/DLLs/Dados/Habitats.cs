/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>07/12/2024 17:51:07</date>
*	<description></description>
*/


using ObjetosZoo;
using System;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 07/12/2024 17:51:07
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Habitats
    {
        #region Attributes
        private static List<Habitat> listahabitats = new List<Habitat>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<Habitat> Listahabitats
        {
            get { return listahabitats; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Cria um novo habitat e adiciona à lista estática de habitats.
        /// </summary>
        /// <param name="idhabitat">ID único do habitat.</param>
        /// <param name="nomehabitat">Nome do habitat.</param>
        /// <param name="zona">Zona à qual o habitat pertence.</param>
        /// <returns>Retorna true após criar e adicionar o habitat.</returns>
        public static bool CriarHabitat(int idhabitat, string nomehabitat, ZONA zona)
        {
            Habitat habitat = new Habitat(idhabitat, nomehabitat, zona);
            listahabitats.Add(habitat);
            return true;
        }


        // Método para adicionar um animal a um habitat
        public static bool AdicionarAnimal(int idhabitat, Animal animal)
        {
            var habitat = listahabitats.Find(h => h.IdHabitat == idhabitat);
            if (habitat != null)
            {
                habitat.ListaAnimaisHabitat.Add(animal);
                return true;
            }
            return false;
        }

        // Método para remover um animal de um habitat
        public static int RemoverAnimal(int idhabitat, int idAnimal)
        {
            var habitat = listahabitats.Find(h => h.IdHabitat == idhabitat);
            if (habitat != null)
            {
                var animal = habitat.ListaAnimaisHabitat.Find(a => a.Id == idAnimal);
                if (animal != null)
                {
                    habitat.ListaAnimaisHabitat.Remove(animal);
                    return 1;
                }
                return -1;
            }
            return -2;
        }

        // Método para listar os animais de um habitat
        public static List<Animal>? MostrarAnimais(int idhabitat)
        {
            var habitat = listahabitats.Find(h => h.IdHabitat == idhabitat);
            if (habitat != null) return habitat.ListaAnimaisHabitat;
            return null;

        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}