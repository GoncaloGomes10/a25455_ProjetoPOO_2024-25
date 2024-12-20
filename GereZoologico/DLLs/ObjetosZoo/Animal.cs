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
using System.Threading.Channels;
using System.Threading.Tasks;


namespace ObjetosZoo
{
    /// <summary>
    /// Enumerado de tipos de dieta que um animal pode ter.
    /// </summary>
    public enum DIETA
    {
        Carnivoro,
        Herbivoro,
        Omnivoro
    }

    /// <summary>
    /// Class que representa um animal no zoológico.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    
    public class Animal
    {
        #region Attributes

        private DIETA dieta; 
        private int id; 
        private static int idstatic; 
        private string nome; 
        private string especie; 
        private int idade; 
        private double peso;
        public string Display => $"{Id} - {Nome} - {Especie} - {Idade} Anos - {Peso}Kg - {Dieta}";
        public string Display1 =>$"{Nome} - {Especie} - {Idade} Anos - {Peso}Kg - {Dieta}";


        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Constructor para criar um animal com os atributos principais.
        /// </summary>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="especie">Espécie do animal.</param>
        /// <param name="idade">Idade do animal em anos.</param>
        /// <param name="peso">Peso do animal em quilogramas.</param>
        /// <param name="dieta">Tipo de dieta do animal.</param>
        public Animal(string nome, string especie, int idade, double peso, DIETA dieta)
        {
            idstatic++;
            id = idstatic;
            Nome = nome;
            Especie = especie;
            Idade = idade;
            Peso = peso;
            Dieta = dieta;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
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

        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        #endregion

        #endregion


    }

}
