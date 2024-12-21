/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>14/12/2024 18:11:54</date>
*	<description></description>
*/


using ObjetosZoo;
using System;
using Dados;

namespace RegrasZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 14/12/2024 18:11:54
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasAssistenciasVeterinarias
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Regista uma assistência veterinária para um animal num determinado habitat, com a data e hora do tratamento.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal está localizado.</param>
        /// <param name="animal">O animal que recebeu a assistência veterinária.</param>
        /// <param name="datadotratamento">A data e hora em que o tratamento foi realizado.</param>
        /// <returns>Retorna verdadeiro se a assistência foi registada com sucesso, caso contrário, retorna falso.</returns>
        public static bool RegistaAssistenciaVeterinaria(Habitat habitat, Animal animal, DateTime datadotratamento)
        {
           if(habitat != null && animal != null) return AssistenciasVeterinarias.RegistaAssistenciaVeterinaria(habitat,animal,datadotratamento);
           return false;
        }
        /// <summary>
        /// Mostra todos os registos de assistências veterinárias.
        /// </summary>
        /// <returns>Retorna uma lista com todas as assistências veterinárias registadas.</returns>
        public static List<AssistenciaVeterinaria> MostraTodosRegistosAssistenciaVeterinaria()
        {
            return AssistenciasVeterinarias.Listaassistenciaveterinaria;
        }
        /// <summary>
        /// Apaga os registos de assistência veterinária para um animal específico num determinado habitat.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal está localizado.</param>
        /// <param name="animal">O animal cujos registos de assistência serão apagados.</param>
        /// <returns>Retorna o número de registos apagados, ou -3 se algum parâmetro for inválido.</returns>
        public static int ApagaRegistos(Habitat habitat, Animal animal)
        {
            if (habitat != null && animal != null) return AssistenciasVeterinarias.ApagaRegistos(habitat, animal);
            return -3;
        }

        /// <summary>
        /// Mostra os registos de assistência veterinária para um animal específico.
        /// </summary>
        /// <param name="animal">O animal cujos registos de assistência serão mostrados.</param>
        /// <returns>Retorna verdadeiro se os registos de assistência para o animal foram encontrados, caso contrário, retorna falso.</returns>
        public static bool MostraRegistosDeAnimal(Animal animal)
        {
            if (animal != null) return AssistenciasVeterinarias.MostraRegistosDeAnimal(animal);
            return false;

        }
        /// <summary>
        /// Remove uma assistência veterinária com base no ID do habitat.
        /// </summary>
        /// <param name="idHabitat">ID do habitat associado à assistência veterinária a ser removida.</param>
        /// <returns>Retorna verdadeiro se a assistência foi removida com sucesso, caso contrário, retorna falso.</returns>
        public static bool RemoveAssistenciaVeterinaria(int idHabitat)
        {
            if(idHabitat <= 0) return false;
            return AssistenciasVeterinarias.RemoveAssistenciaVeterinaria(idHabitat);
        }
        /// <summary>
        /// Apaga todos os registos de assistência veterinária.
        /// </summary>
        /// <returns>Retorna verdadeiro se todos os registos foram apagados com sucesso.</returns>
        public static bool ApagarTodosRegistos()
        {
            return AssistenciasVeterinarias.ApagarTodosRegistos();
        }
        /// <summary>
        /// Edita a data de registo de uma assistência veterinária para um animal específico num habitat.
        /// </summary>
        /// <param name="habitat">O habitat onde o animal está localizado.</param>
        /// <param name="animal">O animal cuja data de assistência será editada.</param>
        /// <param name="novaData">A nova data e hora do tratamento.</param>
        /// <returns>Retorna verdadeiro se a data foi editada com sucesso, caso contrário, retorna falso.</returns>
        public static bool EditaDataRegistoAssistencia(Habitat habitat, Animal animal, DateTime novaData)
        {
           if(habitat != null && animal != null) return AssistenciasVeterinarias.EditaDataRegistoAssistencia(habitat, animal, novaData);
           return false;
        }
        /// <summary>
        /// Carrega as assistências veterinárias a partir de um ficheiro especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro contendo os registos das assistências veterinárias.</param>
        /// <returns>Retorna verdadeiro se as assistências foram carregadas com sucesso.</returns>
        /// <exception cref="FileNotFoundException">Lança uma exceção se o ficheiro não for encontrado.</exception>
        public static bool CarregarAssistenciasVeterinarias(string filePath)
        {
            if (File.Exists(filePath))
            {
               AssistenciasVeterinarias.CarregarAssistenciasVeterinarias(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }
        /// <summary>
        /// Guarda as assistências veterinárias num ficheiro especificado.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro onde os registos das assistências veterinárias serão guardados.</param>
        /// <returns>Retorna verdadeiro se as assistências veterinárias foram guardadas com sucesso, caso contrário, retorna falso.</returns>
        public static bool GuardarAssistenciasVeterinarias(string filePath)
        {
            if (File.Exists(filePath)) return AssistenciasVeterinarias.GuardarAssistenciasVeterinarias(filePath);
            return false;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}