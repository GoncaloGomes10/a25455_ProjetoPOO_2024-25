/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>07/12/2024 17:51:37</date>
*	<description></description>
*/


using ObjetosZoo;
using System;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 07/12/2024 17:51:37
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Alimentacoes
    {
        #region Attributes
        private static List<Alimentacao> listaalimentacoes = new List<Alimentacao>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<Alimentacao> Listaalimentacoes
        {
            get { return listaalimentacoes; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Método para registar uma nova alimentação de um animal.
        /// </summary>
        /// <param name="animal">Animal que foi alimentado.</param>
        /// <param name="tempoAlimentacao">Data e hora da alimentação.</param>
        /// <param name="quantidade">Quantidade de comida consumida.</param>
        /// <param name="tipocomida">Tipo de comida fornecida ao animal.</param>
        /// <returns>Retorna true se o registo for adicionado com sucesso.</returns>
        public static bool RegistraAlimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipodeComida tipocomida)
        {
            Alimentacao alimentacao = new Alimentacao(animal, tempoAlimentacao, quantidade, tipocomida);
            listaalimentacoes.Add(alimentacao);
            return true;
        }


        /// <summary>
        /// Remove um registo de alimentação a partir do ID.
        /// </summary>
        /// <param name="id">ID do registo de alimentação a ser apagado.</param>
        /// <returns>Retorna true se o registo foi encontrado e apagado, ou false caso contrário.</returns>
        public static bool ApagarAlimentacao(int id)
        {
            Alimentacao? alimentacao = listaalimentacoes.Find(alimentacao => alimentacao.Id == id);
            if (alimentacao != null)
            {
                listaalimentacoes.Remove(alimentacao);
                return true;
            }
          
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ApagarTodasAlimentacoes(int id)
        {
            int removidos = listaalimentacoes.Count;
            listaalimentacoes.Clear();

            if (removidos > 0) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novaquantidade"></param>
        /// <returns></returns>
        public static bool EditarAlimentacao(int id,double novaQuantidade)
        {
            // Encontrar o item na lista
            var alimentacao = listaalimentacoes.Find(a => a.Id == id);
            if (alimentacao != null)
            {
                alimentacao.Quantidade= novaQuantidade;
                return true;
            }
            return false;
        }


        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}