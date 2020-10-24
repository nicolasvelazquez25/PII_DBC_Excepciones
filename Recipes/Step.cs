//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            if (quantity <= 0)
            {
                throw new System.Exception("No puede tener cantidades negativas o iguales a cero");
            }
            this.Quantity = quantity;

            if (input == null)
            {
                throw new System.Exception("No se ingreso un ingrediente válido");
            }        
            this.Input = input;

            if (time <= 0)
            {
                throw new System.Exception("No puede tardar cantidades negativas o iguales a cero");
            }        
            this.Time = time;

            if (equipment == null)
            {
                throw new System.Exception("No se ingreso un equipamiento válido");
            }
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}