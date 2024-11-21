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
    /// Classe para gerenciamento de ficheiros relacionados ao zoológico.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    public static class GereFicheiros
    {
        #region Methods

        /// <summary>
        /// Carrega informações dos animais de um ficheiro para a lista de animais.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro com informações dos animais.</param>
        /// <returns>Retorna true se o carregamento for bem-sucedido.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro não for encontrado.</exception>
        /// <exception cref="Exception">Lançada se o formato de uma linha do ficheiro estiver incorreto.</exception>
        public static bool CarregaAnimais(string filePath)
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

                    // Verifica se há exatamente 6 partes
                    if (partes.Length == 6)
                    {
                        string nome = partes[0];
                        string especie = partes[1];
                        int idade = int.Parse(partes[2]);
                        double peso = double.Parse(partes[3]);
                        DIETA dieta = (DIETA)Enum.Parse(typeof(DIETA), partes[4]);
                        int idHabitat = int.Parse(partes[5]);

                        // Cria o objeto Animal e adiciona-o à lista de animais
                        Animal animal = new Animal(nome, especie, idade, peso, dieta);
                        Animal.animais.Add(animal);
                       

                        // Procura o habitat correspondente ao ID e adiciona o animal ao habitat
                        Habitat? habitat = Habitat.habitats.Find(h => h.IdHabitat == idHabitat);
                        if (habitat != null)
                        {
                            habitat.AdicionaAnimalHabitat(animal);
                        }
                        else
                        {
                            Console.WriteLine($"Não foi encontrado o habitat com ID {idHabitat}.");
                        }
                    }
                    else
                    {
                        throw new Exception("Formato da linha inválido.");
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Ficheiro de animais não encontrado.");
            }

            return true;
        }

        /// <summary>
        /// Carrega informações dos tipos de comida de um ficheiro para a lista de tipos de comida.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro com informações dos tipos de comida.</param>
        /// <returns>Retorna true se o carregamento for bem-sucedido.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro não for encontrado.</exception>
        /// <exception cref="Exception">Lançada se o formato de uma linha do ficheiro estiver incorreto.</exception>
        public static bool CarregaTiposdeComida(string filePath)
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

                    // Verifica se há exatamente 3 partes
                    if (partes.Length == 3)
                    {
                        string nomeComida = partes[0];
                        double calorias = double.Parse(partes[1]);
                        DIETA dieta = (DIETA)Enum.Parse(typeof(DIETA), partes[2]);

                        // Cria o objeto TipoComida e adiciona-o à lista de tipos de comida pela função
                        TipoComida.CriarTipoComida(nomeComida,calorias, dieta);
                    }
                    else
                    {
                        throw new Exception("Formato da linha inválido.");
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Ficheiro de tipos de comida não encontrado.");
            }

            return true;
        }

        #endregion
    }



}
