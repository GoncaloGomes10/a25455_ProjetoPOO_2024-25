/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>28/10/2024 15:25:57</date>
*	<description></description>
*/


using System;

namespace ObjetosZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 28/10/2024 15:25:57
    /// </summary>
    public class Cliente : Utilizador
    {
        #region Attributes

        public override int Tipo => 2;

        private double saldo = 0;


        #endregion

        #region Methods

        #region Constructors
        public Cliente(string username, string password, string email, string nome, string nif, double saldo)
            : base(username, password, email, nome, nif)
        {

        }

        #endregion

        #region Properties

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Adiciona um valor ao saldo atual do cliente.
        /// </summary>
        /// <param name="valor">O valor a ser adicionado ao saldo.</param>
        /// <exception cref="ArgumentException">Lançado quando o valor fornecido é negativo.</exception>
        public bool AdicionarSaldo(double valor)
        {
            if (valor < 0)
            {
                return false;
                throw new ArgumentException("O valor a adicionar não pode ser negativo.", nameof(valor));
            }
            
            Saldo += valor;
            return true;
        }

        /// <summary>
        /// Remove um valor do saldo atual do cliente.
        /// </summary>
        /// <param name="valor">O valor a ser removido do saldo.</param>
        /// <exception cref="ArgumentException">Lançado quando o valor fornecido é negativo ou maior que o saldo atual.</exception>
        public bool RemoverSaldo(double valor)
        {
            if (valor < 0)
            {
                return false;
                throw new ArgumentException("O valor a remover não pode ser negativo.", nameof(valor));
            }

            if (valor > Saldo)
            {
                return false;
                throw new ArgumentException("O valor a remover não pode ser maior que o saldo atual.", nameof(valor));
            }

            Saldo -= valor;
            return true;
        }

        /// <summary>
        /// Retorna o saldo atual do cliente.
        /// </summary>
        /// <returns>O saldo atual como uma string formatada.</returns>
        public string MostrarSaldo()
        {
            return $"Saldo atual: {Saldo:C}";
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}