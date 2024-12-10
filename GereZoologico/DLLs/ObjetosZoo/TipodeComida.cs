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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    /// <summary>
    /// Esta classe gerencia uma lista de tipos de comida e fornece métodos para criar, mostrar e apagar tipos de comida.
    /// Created by: gonca
    /// Created on: 26/10/2024 16:24:23
    /// </summary>
    public class TipoComida
    {
        #region Attributes
        private int id;
        private static int idstatic;
        DIETA dieta;
        private string nomecomida;
        private double calorias;
        public static List<TipoComida> tipocomidas = new List<TipoComida>();

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Construtor para criar um novo tipo de comida, atribuindo valores e gerando um ID único.
        /// </summary>
        /// <param name="nomecomida">Nome do tipo de comida.</param>
        /// <param name="calorias">Quantidade de calorias do tipo de comida.</param>
        /// <param name="dieta">Dieta associada ao tipo de comida.</param>
        public TipoComida(string nomecomida, double calorias, DIETA dieta)
        {
            idstatic++;
            Id = idstatic;
            NomeComida = nomecomida;
            Calorias = calorias;
            Dieta = dieta;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeComida
        {
            get { return nomecomida; }
            set { nomecomida = value; }
        }

        public double Calorias
        {
            get { return calorias; }
            set { calorias = value; }
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
        /// <summary>
        /// Retorna uma representação em string do tipo de comida, mostrando seu nome e calorias.
        /// </summary>
        /// <returns>Representação em string do tipo de comida.</returns>
        public override string ToString()
        {
            string outStr = String.Format(" {0} ,Calorias: {1}", NomeComida, Calorias);
            return outStr;
        }
        #endregion

        #region OtherMethods
        /// <summary>
        /// Mostra os detalhes do tipo de comida, incluindo nome e calorias.
        /// </summary>
        /// <returns>Retorna true após exibir os detalhes.</returns>
        public bool MostraDetalhesTipodeComida()
        {

            Console.WriteLine($"Comida: {NomeComida}, Calorias: {Calorias}");
            return true;
        }

        /// <summary>
        /// Cria um novo tipo de comida e o adiciona à lista de tipos de comida.
        /// </summary>
        /// <param name="nomecomida">Nome do tipo de comida.</param>
        /// <param name="calorias">Quantidade de calorias.</param>
        /// <param name="dieta">Dieta associada ao tipo de comida.</param>
        /// <returns>Retorna true após criar o tipo de comida.</returns>
        public static bool CriarTipoComida(string nomecomida, double calorias, DIETA dieta)
        {
            TipoComida tipo = new TipoComida(nomecomida, calorias, dieta);
            tipocomidas.Add(tipo);
            return true;
        }

        /// <summary>
        /// Mostra todos os tipos de comida registados.
        /// </summary>
        /// <returns>Retorna true após exibir todos os tipos de comida.</returns>
        public static bool MostraTodosTipodeComida()
        {

            foreach (var tipo in tipocomidas)
            {
                tipo.MostraDetalhesTipodeComida();
            }
            return true;
        }
        /// <summary>
        /// Apaga um tipo de comida da lista com base no nome.
        /// </summary>
        /// <param name="nomecomida">Nome do tipo de comida a ser apagado.</param>
        /// <returns>Retorna true se o tipo de comida foi apagado, ou false se não encontrado.</returns>
        public static bool ApagarTipoComida(string nomecomida)
        {
            // Procura o tipo de comida pelo nome
            TipoComida? tipo = tipocomidas.Find(tipo => tipo.nomecomida == nomecomida);
            if (tipo != null)
            {
                tipocomidas.Remove(tipo);
                Console.WriteLine("Tipo de comida apagada");
                return true;
            }
            else
            {
                Console.WriteLine("Tipo de comida não existe");
                return false;
            }
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
                        TipoComida.CriarTipoComida(nomeComida, calorias, dieta);
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

        #region Destructor
        #endregion

        #endregion

    }
    






}

