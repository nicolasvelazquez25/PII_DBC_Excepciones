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
            //Precondicion
            if (string.IsNullOrEmpty(description))
            {
                throw new System.Exception("Ingrese una descripción válida");
            }
            //Operación
            this.Description = description;
            //Poscondicion
            if (!(this.Description == description))
            {
                throw new System.Exception("No se pudo guardar la descripción");
            }

            //Precondicion
            if (unitCost <= 0)
            {
                throw new System.Exception("No puede ingresar cantidades negativas o iguales a cero");
            }
            //Operación
            this.UnitCost = unitCost;
            //Poscondicion
            if (!(this.UnitCost == unitCost))
            {
                throw new System.Exception("No se pudo guardar la cantidad de las unidades");
            }
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}