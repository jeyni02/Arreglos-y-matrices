using Ejercicio2.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        //Sistema de reservaciones
        private Reservation reservationSystem;
        public Form1()
        {
            InitializeComponent();
            reservationSystem = new Reservation(); // Inicializa la clase Reservation
        }

        //Evento que se ejecuta cuando el usuario hace click en el botón "Reservar"
        private void btnReserve_Click(object sender, EventArgs e)
        {
            //Determina la sección seleccionada por el usuario
            int section = rbSmoking.Checked ? 1 : (rbNonSmoking.Checked ? 2 : 0);
            int seatNumber;

            //Verifica si se ha seleccionado una sección
            if (section == 0)
            {
                MessageBox.Show("Seleccione una sección.");
                return;
            }

            //Intenta reservar un asiento en la sección seleccionada
            bool reserved = reservationSystem.ReserveSeat(section, out seatNumber);

            if (reserved)
            {
                // Muestra un mensaje con el pase de abordaje si se reservó un asiento
                MessageBox.Show($"Pase de Abordaje: Asiento {seatNumber} - Sección {(section == 1 ? "Fumar" : "No Fumar")}");
            }
            else
            {
                // Mensaje para el usuario si la sección está llena
                string message = section == 1
                    ? "La sección de fumadores está llena. ¿Desea ser colocado en la sección de no fumadores?"
                    : "La sección de no fumadores está llena. ¿Desea ser colocado en la sección de fumadores?";

                // Pregunta al usuario si desea ser colocado en la otra sección
                DialogResult result = MessageBox.Show(message, "Sección Llena", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Intentar reservar en la otra sección si el usuario acepta
                    int alternativeSection = section == 1 ? 2 : 1;
                    bool alternativeReserved = reservationSystem.ReserveSeat(alternativeSection, out seatNumber);

                    if (alternativeReserved)
                    {
                        // Muestra un mensaje con el pase de abordaje si se reservó un asiento en la otra sección
                        MessageBox.Show($"Pase de Abordaje: Asiento {seatNumber} - Sección {(alternativeSection == 1 ? "Fumar" : "No Fumar")}");
                    }
                    else
                    {
                        // Mensaje si la otra sección también está llena
                        MessageBox.Show("El siguiente vuelo sale en 3 horas.");
                    }
                }
                else
                {
                    // Mensaje si el usuario no acepta cambiar de sección
                    MessageBox.Show("El siguiente vuelo sale en 3 horas.");
                }
            }

        }
    }
}
