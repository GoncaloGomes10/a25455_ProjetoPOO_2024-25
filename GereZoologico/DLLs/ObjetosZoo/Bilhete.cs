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
    /// Enumerado que representa as diferentes zonas do zoológico.
    /// </summary>
    public enum ZONA
    {
        Savana,
        Deserto,
        Aquática,
        Floresta
    }
    /// <summary>
    /// Enumerado para os tipos de bilhetes disponíveis.
    /// </summary>
    public enum TIPOBILHETE
    {
        Passeio,
        Espetáculo,
        Completo  // Inclui passeio e espetáculo
    }

    /// <summary>
    /// Classe que representa um bilhete do zoológico.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    public class Bilhete
    {
        #region Attributes 

        private ZONA zona;
        private TIPOBILHETE tipobilhete;
        private double preço;
        private int id;
        private static int idstatic;

        public string Display => $"{Id} - {Zona} - {TipoBilhete} - {Preço}";

        #endregion

        #region Methods

        #region Constructors 
        /// <summary>
        /// Construtor para criar um novo bilhete com uma zona, tipo de bilhete e preço.
        /// </summary>
        /// <param name="zona">Zona do zoológico para a qual o bilhete é válido.</param>
        /// <param name="tipobilhete">Tipo do bilhete (Passeio, Espetáculo, Completo).</param>
        /// <param name="preço">Preço do bilhete.</param>
        public Bilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            idstatic++;
            id = idstatic;
            TipoBilhete = tipobilhete;
            Zona = zona;
            Preço = preço;
        }
        #endregion

        #region Properties
        public double Preço
        {
            get { return preço; }
            set { preço = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public ZONA Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public TIPOBILHETE TipoBilhete
        {
            get { return tipobilhete; }
            set { tipobilhete = value; }
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
    }

    #endregion

}
