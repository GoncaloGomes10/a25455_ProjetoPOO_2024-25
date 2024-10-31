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
    public class Alimentacao
    {
        #region Attributes  

        private int id;
        private static int idstatic;
        private Animal animal;
        private DateTime tempoAlimentacao;
        private double quantidade;
        private TipoComida tipocomida;
        public static List<Alimentacao>alimentacoes = new List<Alimentacao>();
       

        #endregion

        #region Methods

        #region Constructors
        public Alimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipoComida tipocomida)
        {
            idstatic++;
            Id = idstatic;
            Animal = animal;
            TempoAlimentacao = tempoAlimentacao;
            Quantidade = quantidade;
            TipoComida = tipocomida;

        }

        #endregion

        #region Properties
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Animal Animal
        {
            get { return animal; }
            set { animal = value; }
        }

        public DateTime TempoAlimentacao
        {
            get { return tempoAlimentacao; }
            set { tempoAlimentacao = value; }
        }

        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public TipoComida TipoComida
        {
            get { return tipocomida; }
            set { tipocomida = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public static bool RegistraAlimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipoComida tipocomida)
        {
            Alimentacao alimentacao = new Alimentacao(animal,tempoAlimentacao,quantidade,tipocomida);
            alimentacoes.Add(alimentacao);
            return true;
        }

        public void MostraAlimentacao()
        {
            Console.WriteLine($"{animal}\n DD/MM/AA HORAS: {TempoAlimentacao}, Comeu:{TipoComida}\n Quantidade(kg): {Quantidade}");
        }

        public static void MostraTodasAlimentacoes()
        {
            foreach( var alimentacao in alimentacoes)
            {
                alimentacao.MostraAlimentacao();
            }
        }

        public static bool ApagarAlimentacao(int id)
        {
            Alimentacao? alimentacao = alimentacoes.Find(alimentacao => alimentacao.Id == id);
            if( alimentacao != null)
            {
                alimentacoes.Remove(alimentacao);
                Console.WriteLine("Alimentação apagada");
                return true;
            }
            else
            {
                Console.WriteLine("Alimentação não existe");
                return false;
            }
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
     


        


       
    }
}
