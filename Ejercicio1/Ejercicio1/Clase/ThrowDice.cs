using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Clases
{
    public class ThrowDice
    {
        private int[] CountingSums = new int[11]; // Array para contar las sumas (de 2 a 12)
        private static Random rand = new Random(); // Instancia estática de Random

        // Método para simular una tirada de dos dados
        public Tuple<int, int, int> Throw()
        {
            int dice1 = rand.Next(1, 7); // Lanza el primer dado (1 a 6)
            int dice2 = rand.Next(1, 7); // Lanza el segundo dado (1 a 6)
            int addition = dice1 + dice2;    // Calcula la suma

            CountingSums[addition - 2]++; // Incrementa el conteo para la suma correspondiente
            return new Tuple<int, int, int>(dice1, dice2, addition); // Devuelve los valores de los dados y la suma
        }

        // Método para obtener el conteo acumulado de las sumas
        public int[] GetSumCount()
        {
            return CountingSums;
        }
    }
}
