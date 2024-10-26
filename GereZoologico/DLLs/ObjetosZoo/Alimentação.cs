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

        Animal animal;
        DateTime tempoAlimentacao;
        double quantidade;
        TipoComida tipocomida;

        #endregion

        #region Methods

        #region Constructors
        public Alimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipoComida tipocomida)
        {
            this.animal = animal;
            this.tempoAlimentacao = tempoAlimentacao;
            this.quantidade = quantidade;
            this.tipocomida = tipocomida;
        }
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public void RegistraAlimentacao()
        {
            Console.WriteLine($"{animal}\n DD/MM/AA HORAS: {tempoAlimentacao}, Comeu:{tipocomida}\n Quantidade(kg): {quantidade}");

        }
        #endregion

        #region Destructor
        #endregion

        #endregion
     


        


       
    }
}
