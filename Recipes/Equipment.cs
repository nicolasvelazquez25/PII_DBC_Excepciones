//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new System.Exception("Ingrese una descripción válida");
            }
            this.Description = description;

            if (hourlyCost <= 0)
            {
                throw new System.Exception("No puede ingresar cantidades negativas o iguales a cero");
            }
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }
    }
}