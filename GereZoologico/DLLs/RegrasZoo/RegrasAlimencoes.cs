/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/12/2024 21:57:52</date>
*	<description></description>
*/


using Dados;
using ObjetosZoo;
using System;

namespace RegrasZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 12/12/2024 21:57:52
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasAlimencoes
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static bool RegistraAlimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipodeComida tipocomida)
        {
            if (animal == null && tempoAlimentacao == null && quantidade <= 0 && tipocomida == null) return false;
            return Alimentacoes.RegistraAlimentacao(animal, tempoAlimentacao, quantidade, tipocomida);
        }

        public static List<Alimentacao> MostraTodasAlimentacoes()
        {
            return Alimentacoes.Listaalimentacoes;
        }

        public static bool ApagarAlimentacao(int id)
        {
            if (id <= 0) return false;
            return Alimentacoes.ApagarAlimentacao(id);
        }

        public static bool ApagarTodasAlimentacoees(int id)
        {
            if(id <= 0) return false;
            return Alimentacoes.ApagarTodasAlimentacoes(id);
        }

        public static bool EditarAlimentacao(int id, double novaQuantidade)
        {
            if(id <= 0 && novaQuantidade <= 0) return false;
            return Alimentacoes.EditarAlimentacao(id, novaQuantidade);
        }

        public static bool CarregaAlimentacoes(string filePath)
        {
            if (File.Exists(filePath))
            {
                Alimentacoes.CarregaAlimentacoes(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }

        public static bool GuardarAlimentacoes(string filePath)
        {
            if(File.Exists(filePath)) return Alimentacoes.GuardarAlimentacoes(filePath);
            return false;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}