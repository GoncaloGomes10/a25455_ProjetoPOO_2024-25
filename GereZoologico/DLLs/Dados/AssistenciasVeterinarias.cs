/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>14/12/2024 18:10:46</date>
*	<description></description>
*/


using System;
using ObjetosZoo;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 14/12/2024 18:10:46
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class AssistenciasVeterinarias
    {
        #region Attributes
        private static List<AssistenciaVeterinaria> listaassistenciaveterinaria = new List<AssistenciaVeterinaria>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<AssistenciaVeterinaria> Listaassistenciaveterinaria
        {
            get { return listaassistenciaveterinaria; }
        }
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Regista uma nova assistência veterinária para um animal específico no seu habitat.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal se encontra.</param>
        /// <param name="animal">O animal que receberá assistência veterinária.</param>
        /// <returns>Retorna true se o registo for adicionado com sucesso, false caso contrário.</returns>
        public static bool RegistaAssistenciaVeterinaria(Habitat habitat, Animal animal, DateTime datadotratamento)
        {
            // Verifica se o animal está no habitat
            if (habitat.ContemAnimal(animal))
            {
                AssistenciaVeterinaria tratamento = new AssistenciaVeterinaria(habitat, animal, datadotratamento);
                listaassistenciaveterinaria.Add(tratamento);
                return true;
            }
            return false;

        }

        /// <summary>
        /// Apaga os registos de assistência veterinária para um animal específico no habitat dado.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal se encontra.</param>
        /// <param name="animal">O animal cujos registos serão apagados.</param>
        /// <returns>Retorna true se houver registos apagados, false caso contrário.</returns>
        public static int ApagaRegistos(Habitat habitat, Animal animal)
        {
            // Verifica se o animal está no habitat antes de tentar apagar o registo
            if (habitat.ContemAnimal(animal))
            {
                int removidos = listaassistenciaveterinaria.RemoveAll(tratamento => tratamento.Habitat == habitat && tratamento.Animal == animal);
                if (removidos > 0) return 1;
                return -1;

            }
            return -2;
        }

        /// <summary>
        /// Mostra os registos de assistência veterinária para um animal específico.
        /// </summary>
        /// <param name="animal">O animal cujos registos serão exibidos.</param>
        public static bool MostraRegistosDeAnimal(Animal animal)
        {
            // Filtra os registos que correspondem ao animal especificado
            var registos = listaassistenciaveterinaria.Where(tratamento => tratamento.Animal == animal).ToList();

            if (registos.Any())
            {
                foreach (var registo in registos)
                {
                    Console.WriteLine(registo.ToString());
                }
                return true;
            }
            return false;

        }

        /// <summary>
        /// Apaga todos os registos de assistência veterinária.
        /// </summary>
        /// <returns>Retorna true se algum registo for apagado, false caso contrário.</returns>
        public static bool ApagarTodosRegistos()
        {
            int removidos = listaassistenciaveterinaria.Count;
            listaassistenciaveterinaria.Clear();

            if (removidos > 0) return true;
            return false;
        }

        /// <summary>
        /// Remove uma assistência veterinária com base no id do habitat.
        /// </summary>
        /// <param name="idHabitat">O ID do habitat cuja assistência será removida.</param>
        /// <returns>Retorna true se a assistência for removida com sucesso, false caso contrário.</returns>
        public static bool RemoveAssistenciaVeterinaria(int idHabitat)
        {
            // Encontra a assistência relacionada ao habitat pelo id
            var assistenciaARemover = listaassistenciaveterinaria
                .Find(a => a.Habitat.IdHabitat == idHabitat);

            if (assistenciaARemover != null)
            {
                listaassistenciaveterinaria.Remove(assistenciaARemover);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Edita a data de um registo de assistência veterinária.
        /// </summary>
        /// <param name="habitat">O habitat do registo a ser editado.</param>
        /// <param name="animal">O animal do registo a ser editado.</param>
        /// <param name="novaData">A nova data do tratamento.</param>
        /// <returns>Retorna true se o registo for editado, false caso contrário.</returns>
        public static bool EditaDataRegistoAssistencia(Habitat habitat, Animal animal, DateTime novaData)
        {
            // Encontra o registo correspondente
            var registo = listaassistenciaveterinaria.Find(tratamento => tratamento.Habitat == habitat && tratamento.Animal == animal);

            if (registo != null)
            {
                // Atualiza a data do tratamento
                registo.Datadotratamento = novaData;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Carrega as assistências veterinárias a partir de um ficheiro de texto especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro contendo os dados das assistências veterinárias.</param>
        /// <returns>Retorna verdadeiro se as assistências veterinárias foram carregadas com sucesso.</returns>
        /// <exception cref="Exception">Lança uma exceção se o formato do ficheiro for inválido ou se houver erro ao buscar os habitats ou animais.</exception>
        public static bool CarregarAssistenciasVeterinarias(string filePath)
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
                    // Identificadores do ficheiro
                    int idHabitat = int.Parse(partes[0]); // ID do habitat
                    int idAnimal = int.Parse(partes[1]); // ID do animal
                    DateTime dataDoTratamento = DateTime.Parse(partes[2]); // Data e hora do tratamento

                    // Busca o objeto Habitat correspondente
                    Habitat? habitat = Habitats.Listahabitats.Find(h => h.IdHabitat == idHabitat);
                    if (habitat == null)
                    {
                        throw new Exception($"Habitat com ID {idHabitat} não encontrado.");
                    }

                    // Busca o objeto Animal correspondente
                    Animal? animal = Animais.Listaanimais.Find(a => a.Id == idAnimal);
                    if (animal == null)
                    {
                        throw new Exception($"Animal com ID {idAnimal} não encontrado.");
                    }

                    // Verifica se o animal pertence ao habitat
                    if (!habitat.ContemAnimal(animal))
                    {
                        throw new Exception($"Animal com ID {idAnimal} não pertence ao habitat com ID {idHabitat}.");
                    }

                    // Registra a assistência usando a função existente
                    AssistenciasVeterinarias.RegistaAssistenciaVeterinaria(habitat, animal, dataDoTratamento);
                }
                else
                {
                    throw new Exception("Formato inválido na linha do ficheiro.");
                }
            }

            return true; // Indica sucesso
        }
        /// <summary>
        /// Guarda as assistências veterinárias num ficheiro de texto especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro onde as assistências veterinárias serão guardadas.</param>
        /// <returns>Retorna verdadeiro se as assistências veterinárias foram guardadas com sucesso.</returns>
        public static bool GuardarAssistenciasVeterinarias(string filePath)
        {
            // Lista para armazenar as linhas que serão gravadas no ficheiro
            List<string> linhas = new List<string>();

            // Itera pela lista de assistências veterinárias
            foreach (AssistenciaVeterinaria assistencia in AssistenciasVeterinarias.listaassistenciaveterinaria)
            {
                // Formata os dados da assistência em uma linha
                string linha = $"{assistencia.Habitat.IdHabitat};{assistencia.Animal.Id};{assistencia.Datadotratamento:yyyy-MM-ddTHH:mm:ss}";

                // Adiciona a linha à lista de linhas
                linhas.Add(linha);
            }

            // Sobrescreve o conteúdo do ficheiro com as novas linhas
            File.WriteAllLines(filePath, linhas);
           
            return true;
            
            
        }





        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}
            
