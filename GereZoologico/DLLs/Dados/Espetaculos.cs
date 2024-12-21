/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 15:33:20</date>
*	<description></description>
*/


using ObjetosZoo;
using System;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 16/12/2024 15:33:20
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Espetaculos
    {
        #region Attributes
        private static List<Espetaculo> listaespetaculos = new List<Espetaculo>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<Espetaculo> Listaespetaculos
        {
            get { return listaespetaculos;}
        }
        #endregion

        #region Operators
        #endregion

        #region Overrides
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
            Animal? animalescolhido = Animais.EscolherAnimalAleatorio(especie);

            // Verifica se foi encontrado um animal para a espécie
            if (animalescolhido == null) return false;

            // Cria uma nova instância de Espetáculo com o animal selecionado
            Espetaculo espetáculo = new Espetaculo(id, tipoespetaculo, nome, horario, animalescolhido);

            // Adiciona o novo espetáculo à lista estática de espetáculos
            listaespetaculos.Add(espetáculo);

            return true;
        }
        /// <summary>
        /// Apaga todos os espetáculos da lista.
        /// </summary>
        /// <returns>
        /// Retorna True se ao menos um espetáculo foi removido com sucesso;
        /// False se não houver espetáculos para remover (lista vazia).
        /// </returns>
        public static bool ApagarTodosEspetaculos()
        {
            int removidos = listaespetaculos.Count;
            listaespetaculos.Clear();

            if (removidos > 0) return true;
            return false;
        }
        /// <summary>
        /// Apaga um espetáculo específico da lista, dado o objeto de espetáculo fornecido.
        /// </summary>
        /// <param name="espetaculorecebido">O objeto do tipo Espetáculo a ser apagado, identificado pelo seu ID.</param>
        /// <returns>
        /// Retorna True se o espetáculo foi removido com sucesso;
        /// False se o espetáculo não for encontrado na lista (caso o ID não corresponda a nenhum existente).
        /// </returns>
        public static bool ApagarEspetaculo(Espetaculo espetaculorecebido)
        {
            Espetaculo? espetáculo = listaespetaculos.Find(a => a.Id == espetaculorecebido.Id);
            if (espetáculo != null)
            {
                listaespetaculos.Remove(espetáculo);
                return true;
            }
            return false;
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
                        Espetaculos.CriarEspetaculo(id, tipoespetaculo, nome, horario);

                    }
                    else
                    {
                        throw new Exception("Formato da linha inválido.");
                    }
                }
            return true;
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}