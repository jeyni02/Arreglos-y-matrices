using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Clase
{
    public class SalesManager
    {
        private int[] salaryRanges = new int[9]; // Arreglo de contadores de salarios por rango

        // Método para calcular el salario y aumentar el contador de rangos
        public void ProcessSales(SalesManager salesperson)
        {
            decimal salary = salesperson.CalculateSalary();
            int truncatedSalary = (int)salary; // Truncar el salario a una cantidad entera

            // Determinar el rango de salario y aumentar el contador correspondiente
            if (truncatedSalary >= 1000)
                salaryRanges[8]++;
            else if (truncatedSalary >= 900)
                salaryRanges[7]++;
            else if (truncatedSalary >= 800)
                salaryRanges[6]++;
            else if (truncatedSalary >= 700)
                salaryRanges[5]++;
            else if (truncatedSalary >= 600)
                salaryRanges[4]++;
            else if (truncatedSalary >= 500)
                salaryRanges[3]++;
            else if (truncatedSalary >= 400)
                salaryRanges[2]++;
            else if (truncatedSalary >= 300)
                salaryRanges[1]++;
            else
                salaryRanges[0]++;
        }

        // Método para obtener los resultados de los rangos de salario
        public int[] GetSalaryRanges()
        {
            return salaryRanges;
        }
    }
}
