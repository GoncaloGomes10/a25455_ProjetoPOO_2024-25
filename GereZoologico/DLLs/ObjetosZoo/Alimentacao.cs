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
    /// Purpose: Representa o registro da alimentação de um animal no zoológico.
    /// Created by: gonca
    /// Created on: 26/10/2024 16:24:23
    /// </summary>
   
    public class Alimentacao
    {
        #region Attributes  

        private int id; 
        private static int idstatic; 
        private Animal animal; 
        private DateTime tempoAlimentacao; 
        private double quantidade; 
        private TipodeComida tipocomida; 
        

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Construtor para criar um novo registo de alimentação para um animal.
        /// </summary>
        /// <param name="animal">Animal que foi alimentado.</param>
        /// <param name="tempoAlimentacao">Data e hora em que o animal foi alimentado.</param>
        /// <param name="quantidade">Quantidade de comida consumida em kg.</param>
        /// <param name="tipocomida">Tipo de comida consumida pelo animal.</param>
        public Alimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipodeComida tipocomida)
        {
            idstatic++;
            Id = idstatic;
            Animal = animal;
            TempoAlimentacao = tempoAlimentacao;
            Quantidade = quantidade;
            TipoComida = tipocomida;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Animal Animal
        {
            get { return animal; }
            set { animal = value; }
        }

        public DateTime TempoAlimentacao
        {
            get { return tempoAlimentacao; }
            set { tempoAlimentacao = value; }
        }

        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public TipodeComida TipoComida
        {
            get { return tipocomida; }
            set { tipocomida = value; }
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
