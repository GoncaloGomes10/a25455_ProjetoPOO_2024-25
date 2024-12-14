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
        public static bool RegistaAssistenciaVeterinaria(Habitat habitat, Animal animal)
        {
            // Verifica se o animal está no habitat
            if (habitat.ContemAnimal(animal))
            {
                AssistenciaVeterinaria tratamento = new AssistenciaVeterinaria(habitat, animal);
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
        /// Exibe os registos de assistência veterinária para um animal específico.
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
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}