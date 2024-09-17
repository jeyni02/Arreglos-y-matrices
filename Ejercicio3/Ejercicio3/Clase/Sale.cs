using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Clase
{
    public class Sale
    {
        private decimal[,] sale = new decimal[4, 5]; // Arreglo de ventas: 4 vendedores x 5 productos

        // Método para agregar ventas
        public void AddSale(int vendor, int product, decimal amount)
        {
            if (vendor < 1 || vendor > 4 || product < 1 || product > 5)
            {
                throw new ArgumentException("Número de vendedor o producto fuera de rango.");
            }

            sale[vendor - 1, product - 1] += amount;
        }

        // Método para obtener el total de ventas por vendedor
        public decimal GetVendorTotal(int vendor)
        {
            decimal total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += sale[vendor - 1, i];
            }
            return total;
        }

        // Método para obtener el total de ventas por producto
        public decimal GetProductTotal(int product)
        {
            decimal total = 0;
            for (int i = 0; i < 4; i++)
            {
                total += sale[i, product - 1];
            }
            return total;
        }

        // Método para obtener todos los datos de ventas
        public decimal[,] GetSalesData()
        {
            return sale;
        }
    }
}
