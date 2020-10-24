//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new System.Exception("Ingrese una descripción válida");
            }
            this.Description = description;

            if (unitCost <= 0)
            {
                throw new System.Exception("No puede ingresar cantidades negativas o iguales a cero");
            }
            this.UnitCost = unitCost;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}