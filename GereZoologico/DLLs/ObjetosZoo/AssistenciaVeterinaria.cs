/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>26/10/2024 17:05:05</date>
*	<description></description>
*/


using System;

namespace ObjetosZoo
{
    /// <summary>
    /// Classe que representa um registo de assistência veterinária a um animal.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 17:05:05
    /// </summary>
    public class AssistenciaVeterinaria
    {
        #region Attributes

        private Habitat habitat;
        private Animal animal;
        DateTime datadotratamento;

        public string Display => $"{Habitat} - {Animal} - {Datadotratamento}";

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Construtor para criar um registo de assistência veterinária.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal se encontra.</param>
        /// <param name="animal">O animal que recebeu assistência veterinária.</param>
        public AssistenciaVeterinaria(Habitat habitat, Animal animal, DateTime datadotratamento)
        {
            Habitat = habitat;
            Animal = animal;
            Datadotratamento = datadotratamento;
        }

        #endregion

        #region Properties
        public Habitat Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public Animal Animal
        {
            get { return animal; }
            set { animal = value; }
        }

        public DateTime Datadotratamento
        {
            get { return datadotratamento; }
            set { datadotratamento = value; }
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