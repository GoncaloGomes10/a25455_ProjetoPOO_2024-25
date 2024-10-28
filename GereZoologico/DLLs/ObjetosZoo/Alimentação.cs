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
    public class Alimentacao
    {
        #region Attributes  

        private Animal animal;
        private DateTime tempoAlimentacao;
        private double quantidade;
        private TipoComida tipocomida;
        //uma lista para registar todas as alimentações

        #endregion

        #region Methods

        #region Constructors
        public Alimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipoComida tipocomida)
        {
            Animal = animal;
            TempoAlimentacao = tempoAlimentacao;
            Quantidade = quantidade;
            TipoComida = tipocomida;

        }

        #endregion

        #region Properties
        
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

        public TipoComida TipoComida
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
        public void RegistraAlimentacao()
        {
            Console.WriteLine($"{animal}\n DD/MM/AA HORAS: {TempoAlimentacao}, Comeu:{TipoComida}\n Quantidade(kg): {Quantidade}");
        }

        public void MostraAlimentacao()
        {
            Console.WriteLine($"");
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
     


        


       
    }
}
