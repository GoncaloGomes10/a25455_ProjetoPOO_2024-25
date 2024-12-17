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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    /// <summary>
    /// Esta classe gerencia uma lista de tipos de comida e fornece métodos para criar, mostrar e apagar tipos de comida.
    /// Created by: gonca
    /// Created on: 26/10/2024 16:24:23
    /// </summary>
    public class TipodeComida
    {
        #region Attributes
        private int id;
        private static int idstatic;
        DIETA dieta;
        private string nomecomida;
        private double calorias;
  

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Construtor para criar um novo tipo de comida, atribuindo valores e gerando um ID único.
        /// </summary>
        /// <param name="nomecomida">Nome do tipo de comida.</param>
        /// <param name="calorias">Quantidade de calorias do tipo de comida.</param>
        /// <param name="dieta">Dieta associada ao tipo de comida.</param>
        public TipodeComida(string nomecomida, double calorias, DIETA dieta)
        {
            idstatic++;
            Id = idstatic;
            NomeComida = nomecomida;
            Calorias = calorias;
            Dieta = dieta;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeComida
        {
            get { return nomecomida; }
            set { nomecomida = value; }
        }

        public double Calorias
        {
            get { return calorias; }
            set { calorias = value; }
        }

        public DIETA Dieta
        {
            get { return dieta; }
            set { dieta = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides 
        /// <summary>
        /// Retorna uma representação em string do tipo de comida, mostrando seu nome e calorias.
        /// </summary>
        /// <returns>Representação em string do tipo de comida.</returns>
        public override string ToString()
        {
            string outStr = String.Format(" {0} ,Calorias: {1}", NomeComida, Calorias);
            return outStr;
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        #endregion

        #endregion

    }
    






}

