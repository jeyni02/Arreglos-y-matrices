using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clase
{
    public class Reservation
    {
        private bool[] seats = new bool[10]; // Array para marcar si el asiento está ocupado

        // Método para reservar un asiento
        public bool ReserveSeat(int section, out int seatNumber)
        {
            int start = section == 1 ? 0 : 5; // Sección de fumar (0-4) o no fumar (5-9)
            int end = section == 1 ? 5 : 10; // Límites de los índices del array

            // Buscar un asiento disponible en la sección solicitada
            for (int i = start; i < end; i++)
            {
                if (!seats[i])
                {
                    seats[i] = true; // Marcar el asiento como ocupado
                    seatNumber = i + 1; // Asiento en base 1
                    return true;
                }
            }

            // Si la sección está llena, indicar que no hay asientos disponibles
            seatNumber = -1;
            return false;
        }

    }
}
