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
    /// Representa o registo de limpeza de um habitat, incluindo o habitat e a hora da limpeza.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    public class LimpezaHabitat
    {
        #region Attributes

        private Habitat habitat;
        private DateTime horalimpeza;
        public static List<LimpezaHabitat> limpezahabitats = new List<LimpezaHabitat>();

        #endregion

        #region Methods

        #region Constructors  

        /// <summary>
        /// Construtor da classe LimpezaHabitat, que associa um habitat e a hora da limpeza.
        /// </summary>
        /// <param name="habitat">O habitat que foi limpo.</param>
        /// <param name="horalimpeza">A hora em que a limpeza ocorreu.</param>
        public LimpezaHabitat(Habitat habitat, DateTime horalimpeza)
        {
            Habitat = habitat; 
            HoraLimpeza = horalimpeza; 
        }

        #endregion

        #region Properties

     
        public Habitat Habitat
        {
            get { return habitat; } 
            set { habitat = value; } 
        }

        public DateTime HoraLimpeza
        {
            get { return horalimpeza; } 
            set { horalimpeza = value; } 
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
            limpezahabitats.Add(limpeza); 
            return true; 
        }

        /// <summary>
        /// Mostra informações sobre a limpeza de um habitat específico.
        /// </summary>
        public void MostrarHabitatLimpo()
        {
            
            Console.WriteLine($"O habitat {Habitat.NomeHabitat} foi limpo às {HoraLimpeza}");
        }

        /// <summary>
        /// Mostra todos os registos de limpeza de habitats.
        /// </summary>
        /// <returns>Retorna true após exibir todos os registos.</returns>
        public static bool MostraTodosHabitatsLimpos()
        {
            
            foreach (var limpeza in limpezahabitats)
            {
                limpeza.MostrarHabitatLimpo(); 
            }
            return true; 
        }

        /// <summary>
        /// Apaga todos os registos de limpeza para um habitat específico.
        /// </summary>
        /// <param name="habitat">O habitat cujos registos de limpeza serão apagados.</param>
        /// <returns>Retorna true se a limpeza foi apagada, ou false caso contrário.</returns>
        public static bool ApagarTodoRegistoLimpezaHabitat(Habitat habitat)
        {
            
            int removidos = limpezahabitats.RemoveAll(limpeza => limpeza.Habitat == habitat);

            if (removidos > 0)
            {
                
                Console.WriteLine($"{removidos} registos de limpeza removidos para o habitat com ID {habitat.IdHabitat}.");
                return true; 
            }
            else
            {
                
                Console.WriteLine("Nenhum registo de limpeza encontrado para o habitat.");
                return false; 
            }
        }

        /// <summary>
        /// Apaga todos os registos de limpeza existentes.
        /// </summary>
        /// <returns>Retorna true se algum registo foi apagado, ou false caso contrário.</returns>
        public static bool ApagarTodosRegistosdeLimpeza()
        {
            int removidos = limpezahabitats.Count; 
            limpezahabitats.Clear(); 

            if (removidos > 0)
            {
               
                Console.WriteLine($"{removidos} registo(s) de limpeza foram apagados.");
                return true;
            }
            else
            {
                
                Console.WriteLine("Nenhum registo de limpeza para apagar.");
                return false; 
            }
        }

        #endregion
    }


    #region Destructor
    #endregion

    #endregion
}
