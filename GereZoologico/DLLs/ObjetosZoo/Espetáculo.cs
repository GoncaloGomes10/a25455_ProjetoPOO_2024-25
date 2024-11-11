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
        public List<Animal> animaisparticipantes; // Lista de animais para o espetáculo


        #endregion

        #region Methods

        #region Constructors

        public Espetáculo(int id, TIPOESPETÁCULO tipoespetaculo, string nome, DateTime horario)
        {
            Id = id;
            TipoEspetaculo = tipoespetaculo;
            Nome = nome;
            Horario = horario;
            animaisparticipantes = new List<Animal>(); // Inicializa a lista de animais
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

        #endregion

        #region Operators
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"Espetáculo Id: {Id}, Tipo Espetáculo: {TipoEspetaculo}, Hora: {Horario}, Nome Espetáculo: {Nome}";
        }
        #endregion

        #region OtherMethods

        public static Espetáculo CriarEspetaculo(int id, TIPOESPETÁCULO tipoespetaculo, string nome, DateTime horario, Habitat habitat, string especiedesejada)
        {
            // Cria um novo espetáculo
            Espetáculo espetaculo = new Espetáculo(id, tipoespetaculo, nome, horario);

            // Filtra os animais da espécie desejada no habitat
            var animaisespecie = habitat.animaishabitat.Where(a => a.Especie == especiedesejada).ToList();

            if (animaisespecie.Count == 0)
            {
                Console.WriteLine($"Nenhum animal da espécie '{especiedesejada}' encontrado no habitat {habitat.NomeHabitat}.");
                return espetaculo; // Retorna o espetáculo vazio se não há animais da espécie desejada
            }

            // Seleciona um animal aleatório da espécie desejada
            Random random = new Random();
            Animal animalselecionado = animaisespecie[random.Next(animaisespecie.Count)];

            // Adiciona o animal selecionado ao espetáculo
            espetaculo.AdicionarAnimalAoEspetaculo(animalselecionado);
            Console.WriteLine($"Espetáculo '{nome}' criado com o animal '{animalselecionado.Nome}'.");

            return espetaculo;
        }

        
        public void AdicionarAnimalAoEspetaculo(Animal animal)
        {
            if (!animaisparticipantes.Contains(animal))
            {
                animaisparticipantes.Add(animal);
                Console.WriteLine($"Animal {animal.Nome} foi adicionado ao espetáculo.");
            }
            else
            {
                Console.WriteLine($"Animal {animal.Nome} já está no espetáculo.");
            }
        }

        
        public static void ExibirDetalhesEspetaculo()
        {
            foreach (var espetaculo in animaisparticipantes)
            {
                Console.WriteLine();
            }
        }
        #endregion

        #region Destructor
        #endregion

        #endregion



    }
}
