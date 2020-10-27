//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            //Precondicion
            if (step == null)
            {
                throw new Exception("Se debe ingresar un paso válido");
            } 
            //Invariante
            int oldAmountSteps = steps.Count; 
            //Operacion            
            this.steps.Add(step);
            //Poscondicion
            if (!(steps.Count == oldAmountSteps + 1))
            {
                throw new Exception("No se agregó correctamente el paso solicitado");
            }
        }

        public void RemoveStep(Step step)
        {
            //Precondicion
            if (!steps.Contains(step))
            {
                throw new Exception("Se debe ingresar un paso que ya este agregado");
            }

            //Invariante
            int oldAmountSteps = steps.Count; 

            //Operacion
            this.steps.Remove(step);
        
            //Poscondicion
            if (!(steps.Count == oldAmountSteps - 1))
            {
                throw new Exception("No se eliminó correctamente el paso solicitado");
            }
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}