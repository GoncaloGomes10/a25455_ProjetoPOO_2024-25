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
        public static List<Espetaculo> espetaculos = new List<Espetaculo>();

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
        public static bool CriarEspetaculo(int id, TIPOESPETACULO tipoespetaculo, string nome, DateTime horario)
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
            Espetaculo espetáculo = new Espetaculo(id, tipoespetaculo, nome, horario, animalescolhido);

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

        public static bool ApagarEspetaculo(Espetaculo espetaculorecebido)
        {
            Espetaculo? espetáculo = espetaculos.Find(a => a.Id == espetaculorecebido.Id);
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

        /// <summary>
        /// Carrega informações dos espetáculos de um ficheiro para a lista de espetáculos.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro com informações dos espetáculos.</param>
        /// <returns>Retorna true se o carregamento for bem-sucedido.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro não for encontrado.</exception>
        /// <exception cref="Exception">Lançada se o formato de uma linha do ficheiro estiver incorreto.</exception>
        public static bool CarregarEspetaculos(string filePath)
        {
            // Verifica se o ficheiro existe
            if (File.Exists(filePath))
            {
                // Lê todas as linhas do ficheiro
                string[] linhas = File.ReadAllLines(filePath);

                // Para cada linha no ficheiro, processa o conteúdo
                foreach (string linha in linhas)
                {
                    // Divide a linha em partes
                    string[] partes = linha.Split(';');

                    // Verifica se há exatamente 5 partes
                    if (partes.Length == 4)
                    {
                        int id = int.Parse(partes[0]);
                        TIPOESPETACULO tipoespetaculo = (TIPOESPETACULO)Enum.Parse(typeof(TIPOESPETACULO), partes[1]);
                        string nome = partes[2];
                        DateTime horario = DateTime.Parse(partes[3]);


                        //CriarEspetaculo
                        Espetaculo.CriarEspetaculo(id, tipoespetaculo, nome, horario);

                    }
                    else
                    {
                        throw new Exception("Formato da linha inválido.");
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Ficheiro de espetáculos não encontrado.");
            }

            return true;
        }

        #endregion   

        #region Destructor
        #endregion

        #endregion
    }

    

 



}

