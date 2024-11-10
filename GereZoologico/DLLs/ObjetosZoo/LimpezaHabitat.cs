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
    public class LimpezaHabitat
    {
        #region Attributes

        private Habitat habitat;
        private DateTime horalimpeza;
        public static List<LimpezaHabitat> limpezahabitats = new List<LimpezaHabitat>();

        #endregion

        #region Methods

        #region Constructors  
        public LimpezaHabitat (Habitat habitat, DateTime horalimpeza)
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
        public static bool RegistarHabitatLimpo(Habitat habitat, DateTime horalimpeza)
        {
            LimpezaHabitat limpeza = new LimpezaHabitat(habitat, horalimpeza);
            limpezahabitats.Add(limpeza);
            return true;
        }

        public void MostrarHabitatLimpo()
        {
            Console.WriteLine($"O habitat {Habitat} foi limpo às {HoraLimpeza}");

        }

        public static bool MostraTodosHabitatsLimpos()
        {
            foreach (var limpeza in limpezahabitats)
            {
                limpeza.MostrarHabitatLimpo();
            }
            return true;
        }

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

        #region Destructor
        #endregion

        #endregion









    }
}