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
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    /// <summary>
    /// Enumerado dos tipos de espetáculo disponíveis.
    /// </summary>
    public enum TIPOESPETACULO
    {
        Elefante,
        Golfinho,
        Tubarão,
        Leão,
        Gorila
    }

    /// <summary>
    /// Classe que representa um Espetáculo no zoológico.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    public class Espetaculo
    {
        #region Attributes 

        private int id;
        private TIPOESPETACULO tipoespetaculo;
        private string nome;
        private DateTime horario;
        private Animal animalespetaculo;

        public string Display
        {
            get
            {
                // Verifica se o animal do espetáculo é válido
                string detalhesAnimal = animalespetaculo != null
                    ? $"{animalespetaculo.Nome} (: {animalespetaculo.Especie})"
                    : "Sem animal associado";

                // Retorna o formato desejado
                return $"{Id} - {TipoEspetaculo} - {Nome} - {Horario:yyyy-MM-dd HH:mm} - Animal: {detalhesAnimal}";
            }
        }


        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Construtor para inicializar um novo espetáculo com os detalhes especificados.
        /// </summary>
        /// <param name="id">ID único do espetáculo.</param>
        /// <param name="tipoespetaculo">Tipo de espetáculo (Elefante, Golfinho, etc.).</param>
        /// <param name="nome">Nome do espetáculo.</param>
        /// <param name="horario">Horário do espetáculo.</param>
        /// <param name="animalespetaculo">Animal que participa no espetáculo.</param>
        public Espetaculo(int id, TIPOESPETACULO tipoespetaculo, string nome, DateTime horario, Animal animalespetaculo)
        {
            Id = id;
            TipoEspetaculo = tipoespetaculo;
            Nome = nome;
            Horario = horario;
            AnimalEspetaculo = animalespetaculo;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public TIPOESPETACULO TipoEspetaculo
        {
            get { return tipoespetaculo; }
            set { tipoespetaculo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public Animal AnimalEspetaculo
        {
            get { return animalespetaculo; }
            set { animalespetaculo = value; }
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

