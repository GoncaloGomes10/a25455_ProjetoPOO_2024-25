﻿/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 16:13:17</date>
*	<description></description>
*/


using ObjetosZoo;
using System;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 16/12/2024 16:13:17
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class LimpezaHabitats
    {
        #region Attributes
        private static List<LimpezaHabitat> listalimpezahabitats = new List<LimpezaHabitat>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<LimpezaHabitat> Listalimpezahabitats
        {
            get { return listalimpezahabitats; }
        }
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Registra uma limpeza de habitat e adiciona o registo à lista de limpezas.
        /// </summary>
        /// <param name="habitat">O habitat que foi limpo.</param>
        /// <param name="horalimpeza">A hora em que a limpeza ocorreu.</param>
        /// <returns>Retorna true após registar a limpeza.</returns>
        public static bool RegistarHabitatLimpo(Habitat habitat, DateTime horalimpeza)
        {
            LimpezaHabitat limpeza = new LimpezaHabitat(habitat, horalimpeza);
            listalimpezahabitats.Add(limpeza);
            return true;
        }

        /// <summary>
        /// Apaga todos os registos de limpeza para um habitat específico.
        /// </summary>
        /// <param name="habitat">O habitat cujos registos de limpeza serão apagados.</param>
        /// <returns>Retorna true se a limpeza foi apagada, ou false caso contrário.</returns>
        public static bool ApagarTodoRegistoLimpezaHabitat(Habitat habitat)
        {

            int removidos = listalimpezahabitats.RemoveAll(limpeza => limpeza.Habitat == habitat);
            if (removidos > 0) return true;
            return false;
        }

        /// <summary>
        /// Apaga todos os registos de limpeza existentes.
        /// </summary>
        /// <returns>Retorna true se algum registo foi apagado, ou false caso contrário.</returns>
        public static bool ApagarTodosRegistosdeLimpeza()
        {
            int removidos = listalimpezahabitats.Count;
            listalimpezahabitats.Clear();

            if (removidos > 0) return true;
            return false;
        }

        /// <summary>
        /// Apaga um registro de limpeza com base no ID do habitat.
        /// </summary>
        /// <param name="idHabitat">O ID do habitat cujo registro de limpeza será removido.</param>
        /// <returns>Retorna 1 se o registro for removido com sucesso, -1 caso contrário.</returns>
        public static int ApagarRegistoLimpeza(int idHabitat)
        {
            // Encontra o registro de limpeza correspondente ao idHabitat
            LimpezaHabitat? removerlimpeza = listalimpezahabitats.Find(x => x.Habitat.IdHabitat == idHabitat);

            if (removerlimpeza != null)
            {
                listalimpezahabitats.Remove(removerlimpeza);
                return 1;
            }
            return -1;
        }

        /// <summary>
        /// Carrega os registos de limpezas de habitats a partir de um ficheiro especificado. 
        /// Cada linha do ficheiro deve conter o ID do habitat e a data/hora da limpeza, separados por ';'.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro que contém os dados das limpezas.</param>
        /// <returns>True se os dados forem carregados com sucesso.</returns>
        /// <exception cref="Exception">
        /// Lançada se o formato de uma linha do ficheiro for inválido ou se o habitat especificado não for encontrado.
        /// </exception>
        public static bool CarregarLimpezasHabitats(string filePath)
        {
            // Lê todas as linhas do ficheiro
            string[] linhas = File.ReadAllLines(filePath);

            // Para cada linha no ficheiro, processa o conteúdo
            foreach (string linha in linhas)
            {
                // Divide a linha em partes
                string[] partes = linha.Split(';');

                // Verifica se há exatamente 2 partes
                if (partes.Length == 2)
                {
                    // Identificadores do ficheiro
                    int idHabitat = int.Parse(partes[0]); // ID do habitat
                    DateTime horaLimpeza = DateTime.Parse(partes[1]); // Data e hora da limpeza

                    // Busca o objeto Habitat correspondente
                    Habitat? habitat = Habitats.Listahabitats.Find(h => h.IdHabitat == idHabitat);
                    if (habitat == null)
                    {
                        throw new Exception($"Habitat com ID {idHabitat} não encontrado.");
                    }

                    // Registra a limpeza usando a função existente
                    LimpezaHabitats.RegistarHabitatLimpo(habitat, horaLimpeza);
                }
                else
                {
                    throw new Exception("Formato inválido na linha do ficheiro.");
                }
            }

            return true; 
        }
        /// <summary>
        /// Guarda os registos de limpezas de habitats num ficheiro especificado.
        /// Cada linha no ficheiro será formatada com o ID do habitat e a data/hora da limpeza.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro onde os dados serão guardados.</param>
        /// <returns>True se os dados forem guardados com sucesso; False caso ocorra um erro.</returns>
        public static bool GuardarLimpezasHabitats(string filePath)
        {
            try
            {
                // Lista para armazenar as linhas que serão gravadas no ficheiro
                List<string> linhas = new List<string>();

                // Itera pela lista de limpezas
                foreach (LimpezaHabitat limpeza in LimpezaHabitats.listalimpezahabitats)
                {
                    // Formata os dados da limpeza em uma linha
                    string linha = $"{limpeza.Habitat.IdHabitat};{limpeza.HoraLimpeza:yyyy-MM-ddTHH:mm:ss}";

                    // Adiciona a linha à lista de linhas
                    linhas.Add(linha);
                }

                // Escreve todas as linhas no ficheiro
                File.WriteAllLines(filePath, linhas);

                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao guardar limpezas: {ex.Message}");
                return false; 
            }
        }



        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}