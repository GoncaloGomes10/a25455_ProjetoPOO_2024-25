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

        /// <summary>
        /// Mostra os habitats e seus respectivos animais.
        /// </summary>
        public static void MostraHabitatsAnimais()
        {
            foreach (Habitat habitat in listahabitats)
            {
                Console.WriteLine(habitat);  // Exibe as informações do habitat

                // Exibe o número de animais no habitat
                Console.WriteLine($"Número de animais no habitat {habitat.NomeHabitat}: {habitat.animaishabitat.Count}");

                if (habitat.animaishabitat.Count > 0)
                {
                    foreach (Animal animal in habitat.animaishabitat)
                    {
                        Console.WriteLine("  - " + animal);  // Exibe cada animal presente no habitat
                    }
                }
                else
                {
                    Console.WriteLine("  Nenhum animal neste habitat.");
                }
            }
        }



        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}