﻿/*
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
        public static List<Bilhete> bilhetes = new List<Bilhete>();

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
        /// <summary>
        /// Mostra as informações do bilhete na consola.
        /// </summary>
        public void VerBilhete()
        {
            Console.WriteLine($"O teu bilhete {Id} do tipo {TipoBilhete} custou {Preço} euros para a zona: {Zona}");
        }

        /// <summary>
        /// Permite comprar um bilhete e adicioná-lo à lista de bilhetes comprados.
        /// </summary>
        /// <param name="zona">Zona do zoológico para a qual o bilhete é válido.</param>
        /// <param name="tipobilhete">Tipo do bilhete (Passeio, Espetáculo, Completo).</param>
        /// <param name="preço">Preço do bilhete.</param>
        /// <returns>Retorna true se o bilhete for comprado com sucesso.</returns>
        public static bool ComprarBilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            Bilhete bilhete = new Bilhete(zona, tipobilhete, preço);
            bilhetes.Add(bilhete);
            Console.WriteLine("Bilhete comprado com sucesso");
            return true;
        }

        /// <summary>
        /// Mostra todos os bilhetes comprados na consola.
        /// </summary>
        /// <returns>Retorna true após mostrar todos os bilhetes.</returns>
        public static bool VerTodosBilhetes()
        {
            foreach (var bilhete in bilhetes)
            {
                bilhete.VerBilhete();
            }
            return true;
        }

        public static bool ApagarTodosBilhetes()
        {
            int removidos = bilhetes.Count;
            bilhetes.Clear();

            if (removidos > 0)
            {
                Console.WriteLine($"{removidos} bilhetes foram apagados.");
                return true;
            }
            else
            {
                Console.WriteLine("Nenhum bilhete para apagar.");
                return false;
            }
        }

        public static bool ApagarBilhete(Bilhete bilheterecebido) 
        {
            Bilhete? bilhete = bilhetes.Find(a => a.Id == bilheterecebido.Id);
            if (bilhete != null)
            {
                bilhetes.Remove(bilhete);
                Console.WriteLine("Bilhete apagado");
                return true;
            }
            else
            {
                Console.WriteLine($"Bilhete não encontrado");
                return false;
            }
        }

        #endregion
    }

    #region Destructor
    #endregion

    #endregion

}
