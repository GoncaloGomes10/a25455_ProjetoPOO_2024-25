/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>14/12/2024 18:55:33</date>
*	<description></description>
*/


using System;
using ObjetosZoo;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 14/12/2024 18:55:33
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Bilhetes
    {
        #region Attributes
        private static List<Bilhete> listabilhetes = new List<Bilhete>();
        private static Dictionary<TIPOBILHETE, decimal> precoBilhetes = new Dictionary<TIPOBILHETE, decimal>();

        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<Bilhete> Listabilhetes
        {
            get { return listabilhetes; }
        }
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
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
            listabilhetes.Add(bilhete);
            return true;
        }
        /// <summary>
        /// Apaga todos os bilhetes da lista.
        /// </summary>
        /// <returns>Retorna verdadeiro se existirem bilhetes removidos, caso contrário, retorna falso.</returns>
        public static bool ApagarTodosBilhetes()
        {
            int removidos = listabilhetes.Count;
            listabilhetes.Clear();

            if (removidos > 0) return true;
            return false;
        }
        /// <summary>
        /// Apaga um bilhete específico da lista, com base no ID do bilhete recebido.
        /// </summary>
        /// <param name="bilheterecebido">Bilhete a ser removido.</param>
        /// <returns>Retorna verdadeiro se o bilhete foi removido, caso contrário, retorna falso.</returns>
        public static bool ApagarBilhete(Bilhete bilheterecebido)
        {
            Bilhete? bilhete = listabilhetes.Find(a => a.Id == bilheterecebido.Id);
            if (bilhete != null)
            {
                listabilhetes.Remove(bilhete);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Carrega os bilhetes a partir de um ficheiro de texto especificado e adiciona à lista.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro contendo os dados dos bilhetes.</param>
        /// <returns>Retorna verdadeiro se os bilhetes foram carregados com sucesso.</returns>
        /// <exception cref="Exception">Lança uma exceção se o formato do ficheiro for inválido.</exception>
        public static bool CarregarBilhetes(string filePath)
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
                    TIPOBILHETE tipobilhete = (TIPOBILHETE)Enum.Parse(typeof(TIPOBILHETE), partes[0]);
                    ZONA zona = (ZONA)Enum.Parse(typeof(ZONA), partes[1]);
                    double preço = double.Parse(partes[2]);

                    Bilhetes.ComprarBilhete(zona, tipobilhete, preço);
                }
                else
                {
                    throw new Exception();
                }
            }

            return true;
        }
        /// <summary>
        /// Guarda todos os bilhetes da lista num ficheiro de texto.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro onde os bilhetes serão armazenados.</param>
        /// <returns>Retorna verdadeiro se os bilhetes foram guardados com sucesso.</returns>
        public static bool GuardarBilhetes(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath)) //Open the file to write
            {
                foreach (Bilhete bilhete in listabilhetes)
                {
                    writer.WriteLine($"{bilhete.TipoBilhete};{bilhete.Zona};{bilhete.Preço}");
                }
            }
            return true;
        }

        /// <summary>
        /// Carrega os preços dos bilhetes a partir de um ficheiro de texto especificado.
        /// </summary>
        /// <param name="filepath">Caminho do ficheiro contendo os preços dos bilhetes.</param>
        public static void CarregarPrecosBilhetes(string filepath)
        {

            var linhas = File.ReadAllLines(filepath);

            foreach (var linha in linhas)
            {
                // Separa a linha em duas partes: tipo de bilhete e preço
                var partes = linha.Split(',');

                if (partes.Length == 2)
                {
                    // Converte a primeira parte para o tipo de bilhete (TIPOBILHETE)
                    var tipoBilhete = (TIPOBILHETE)Enum.Parse(typeof(TIPOBILHETE), partes[0].Trim());

                    // Converte a segunda parte para o preço (decimal)
                    var preco = decimal.Parse(partes[1].Trim());

                    // Armazena o tipo de bilhete e o preço no dicionário
                    precoBilhetes[tipoBilhete] = preco;
                }
            }
        }

        /// <summary>
        /// Obtém o preço de um bilhete com base no seu tipo.
        /// </summary>
        /// <param name="tipoBilhete">Tipo de bilhete para o qual se deseja obter o preço.</param>
        /// <returns>Retorna o preço do bilhete, ou 0 se o preço não estiver definido.</returns>
        public static decimal ObterPreco(TIPOBILHETE tipoBilhete)
        {
            if (precoBilhetes.ContainsKey(tipoBilhete))
            {
                return precoBilhetes[tipoBilhete];
            }
            return 0; // Retorna 0 caso o tipo de bilhete não tenha preço definido
        }
    

        #endregion


        #region Destructor
        #endregion


        #endregion
    }







   





}
