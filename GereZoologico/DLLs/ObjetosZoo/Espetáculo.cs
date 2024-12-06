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
    public enum TIPOESPETÁCULO
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
        /// <summary>
        /// Construtor para inicializar um novo espetáculo com os detalhes especificados.
        /// </summary>
        /// <param name="id">ID único do espetáculo.</param>
        /// <param name="tipoespetaculo">Tipo de espetáculo (Elefante, Golfinho, etc.).</param>
        /// <param name="nome">Nome do espetáculo.</param>
        /// <param name="horario">Horário do espetáculo.</param>
        /// <param name="animalespetaculo">Animal que participa no espetáculo.</param>
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
        /// <summary>
        /// Representação em string do espetáculo, com informações detalhadas.
        /// </summary>
        /// <returns>Uma string contendo detalhes do espetáculo.</returns>
        public override string ToString()
        {
            return $"Espetáculo Id: {Id}, Tipo: {TipoEspetaculo}, Nome: {Nome}, Horário: {Horario}, " +
                   $"Animal: {AnimalEspetaculo?.Nome ?? "Nenhum"} ({AnimalEspetaculo?.Especie ?? "N/A"})";
        }

        #endregion

        #region OtherMethods
        /// <summary>
        /// Cria um novo espetáculo e adiciona-o à lista de espetáculos.
        /// </summary>
        /// <param name="id">ID do espetáculo.</param>
        /// <param name="tipoespetaculo">Tipo de espetáculo (Elefante, Golfinho, Tubarão, Leão).</param>
        /// <param name="nome">Nome do espetáculo.</param>
        /// <param name="horario">Horário do espetáculo.</param>
        /// <returns>Retorna true se o espetáculo for criado com sucesso.</returns>
        public static bool CriarEspetaculo(int id, TIPOESPETÁCULO tipoespetaculo, string nome, DateTime horario)
        {
            // Converte o tipo de espetáculo para o nome da espécie correspondente
            string especie = tipoespetaculo.ToString();

            // Seleciona aleatoriamente um animal da espécie especificada
            Animal animalescolhido = Animal.EscolherAnimalAleatorio(especie);

            // Verifica se foi encontrado um animal para a espécie
            if (animalescolhido == null)
            {
                Console.WriteLine($"Espetáculo não pode ser criado. Nenhum animal disponível para a espécie {especie}.");
                return false;
            }

            // Cria uma nova instância de Espetáculo com o animal selecionado
            Espetáculo espetáculo = new Espetáculo(id, tipoespetaculo, nome, horario, animalescolhido);

            // Adiciona o novo espetáculo à lista estática de espetáculos
            espetaculos.Add(espetáculo);

            return true;
        }

        /// <summary>
        /// Exibe a lista de todos os espetáculos cadastrados.
        /// </summary>
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

        public static bool ApagarTodosEspetaculos()
        {
            int removidos = espetaculos.Count;
            espetaculos.Clear();

            if (removidos > 0)
            {
                Console.WriteLine($"{removidos} espetaculos foram removidos.");
                return true;
            }
            else
            {
                Console.WriteLine("Nenhum espetaculo para apagar.");
                return false;
            }
        }

        public static bool ApagarEspetaculo(Espetáculo espetaculorecebido)
        {
            Espetáculo? espetáculo = espetaculos.Find(a => a.Id == espetaculorecebido.Id);
            if (espetáculo != null)
            {
                espetaculos.Remove(espetáculo);
                Console.WriteLine($"{espetaculorecebido} apagado");
                return true;
            }
            else
            {
                Console.WriteLine($"Espetaculo não encontrado");
                return false;
            }
        }

        #endregion
    }

    

    #region Destructor
    #endregion

    #endregion



}

