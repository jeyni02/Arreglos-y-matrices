using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Clase
{
    public class SalesPerson
    {
        private decimal weeklySales; // Variable para almacenar ventas semanales

        // Método para asignar las ventas semanales
        public void SetWeeklySales(decimal sales)
        {
            weeklySales = sales;
        }

        // Método para calcular el salario basado en $200 de base y el 9% de las ventas
        public decimal CalculateSalary()
        {
            const decimal baseSalary = 200;
            const decimal commissionRate = 0.09m;
            return baseSalary + (weeklySales * commissionRate);
        }
    }
}
