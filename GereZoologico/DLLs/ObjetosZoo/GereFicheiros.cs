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
    public static class GereFicheiros
    {
        #region Methods

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

                    if (partes.Length == 6) // Verifica se há exatamente 6 partes
                    {
                        string nome = partes[0];
                        string especie = partes[1];
                        int idade = int.Parse(partes[2]);
                        double peso = double.Parse(partes[3]);
                        DIETA dieta = (DIETA)Enum.Parse(typeof(DIETA), partes[4]);
                        int id = int.Parse((partes[5]));

                        // Cria o objeto Animal e coloca-o na lista
                        Animal x = new Animal(nome, especie, idade, peso, dieta);
                        Animal.animais.Add(x);

                        Habitat? h = Habitat.habitats.Find(habitat => habitat.IdHabitat == id);
                        if(h != null)
                        {
                            h.AdicionaAnimalHabitat(x);
                        }
                        else
                        {
                            Console.WriteLine("Não foi encontrado o habitat");
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
                throw new FileNotFoundException("Ficheiro não encontrado.");
            }

            return true;
        }

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

                    if (partes.Length == 3) // Verifica se há exatamente 3 partes
                    {
                        string nomecomida = partes[0];
                        double calorias = double.Parse(partes[1]);
                        DIETA dieta = (DIETA)Enum.Parse(typeof(DIETA), partes[2]);
                       

                        // Cria o objeto TipoComida e coloca-o na lista
                        TipoComida x = new TipoComida(nomecomida,calorias, dieta);
                        TipoComida.tipocomidas.Add(x);
                    }
                    else
                    {
                        throw new Exception("Formato da linha inválido.");
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Ficheiro não encontrado.");
            }

            return true;
        }

        #endregion




    }
}
