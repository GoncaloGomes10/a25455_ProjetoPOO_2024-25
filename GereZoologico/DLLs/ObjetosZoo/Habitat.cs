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
    /// Representa um habitat de animais, contendo informações sobre a zona e os animais presentes.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    public class Habitat
    {
        #region Attributes

        private ZONA zona;
        private int idhabitat;
        private string nomehabitat;
        private List<Animal> listaanimaishabitat;

        #endregion

        #region Methods

        #region Constructors 

        /// <summary>
        /// Construtor da classe Habitat.
        /// </summary>
        /// <param name="idhabitat">ID único do habitat.</param>
        /// <param name="nomehabitat">Nome do habitat.</param>
        /// <param name="zona">Zona à qual o habitat pertence.</param>
        public Habitat(int idhabitat, string nomehabitat, ZONA zona)
        {
            IdHabitat = idhabitat;
            NomeHabitat = nomehabitat;
            Zona = zona;
            listaanimaishabitat = new List<Animal>(); // Inicializa a lista de animais para o habitat
        }

        #endregion

        #region Properties

        public List<Animal> ListaAnimaisHabitat
        {
            get { return listaanimaishabitat; }
        }

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

        /// <summary>
        /// Retorna uma representação textual do habitat.
        /// </summary>
        /// <returns>Uma string com as informações do habitat.</returns>
        public override string ToString()
        {
            return String.Format("IDHabitat: {0} Nome Habitat: {1} Zona: {2}", IdHabitat, NomeHabitat, Zona);
        }

        #endregion

        #region OtherMethods
        public bool ContemAnimal(Animal animal)
        {
            // Verifica se o animal está na lista de animais do habitat
            return listaanimaishabitat.Contains(animal);
        }

        #endregion

        #region Destructor
        #endregion


        #endregion

    }
}
