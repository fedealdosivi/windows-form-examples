using System;
using System.Collections.Generic;

namespace IsraSoft.BindingDataGridView.Clases
{
    /// <summary>
    /// Clase Productos
    /// </summary>
    internal class Productos
    {
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string nombre { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        public int cantidad { get; set; }
        /// <summary>
        /// Precio
        /// </summary>
        public decimal precio { get; set; }
        /// <summary>
        /// Porcentaje de impuestos
        /// </summary>
        public decimal iva { get; private set; }
        /// <summary>
        /// Porcentaje de descuento
        /// </summary>
        public decimal descuento { get; set; }
        /// <summary>
        /// Costo total
        /// </summary>
        public decimal total
        {
            get
            {
                var t = (cantidad * (precio * (1 + (iva / 100))));
                return t - (t * (descuento / 100));
            }
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Productos()
        {
            nombre = "";
            cantidad = 0;
            precio = 0;
            iva = 16;
            descuento = 0;
        }
    }
}