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
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 26/10/2024 16:24:23
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public enum TIPOESPETÁCULO
    {
        Elefante,
        Golfinho,
        Tubarão,
        Leão
    }
    public class Espetáculo
    {
        #region Attributes 

        private int id;
        private TIPOESPETÁCULO tipoespetaculo;
        private string nome;
        private DateTime horario;
        private Animal animalespetaculo;
        public static List<Espetáculo> espetaculos = new List<Espetáculo>();


        #endregion

        #region Methods

        #region Constructors

        public Espetáculo(int id, TIPOESPETÁCULO tipoespetaculo, string nome, DateTime horario, Animal animalespetaculo)
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

        public TIPOESPETÁCULO TipoEspetaculo
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
        public override string ToString()
        {
            return $"Espetáculo Id: {Id}, Tipo: {TipoEspetaculo}, Nome: {Nome}, Horário: {Horario}, " +
                   $"Animal: {AnimalEspetaculo?.Nome ?? "Nenhum"} ({AnimalEspetaculo?.Especie ?? "N/A"})";
        }

        #endregion

        #region OtherMethods

        public static bool CriarEspetaculo(int id, TIPOESPETÁCULO tipoespetaculo, string nome, DateTime horario)
        {
            // Converte o tipo de espetáculo para o nome da espécie correspondente
            string especie = tipoespetaculo.ToString();

            // Seleciona aleatoriamente um animal da espécie especificada
            Animal animalEscolhido = Animal.EscolherAnimalAleatorio(especie);

            // Verifica se foi encontrado um animal para a espécie
            if (animalEscolhido == null)
            {
                Console.WriteLine($"Espetáculo não pode ser criado. Nenhum animal disponível para a espécie {especie}.");
                return false;
            }

            // Cria uma nova instância de Espetáculo com o animal selecionado
            Espetáculo espetáculo = new Espetáculo(id, tipoespetaculo, nome, horario, animalEscolhido);

            // Adiciona o novo espetáculo à lista estática de espetáculos
            espetaculos.Add(espetáculo);

            return true;
        }

        public static void MostrarTodosEspetaculos()
        {
            if (espetaculos.Count == 0)
            {
                Console.WriteLine("Nenhum espetáculo disponível.");
                return;
            }

            Console.WriteLine("Lista de Espetáculos:");
            foreach (var espetáculo in espetaculos)
            {
                Console.WriteLine(espetáculo.ToString());
            }
        }
        #endregion

        #region Destructor
        #endregion

        #endregion



    }
}
