using Ejercicio4.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer las ventas del TextBox (ej. txtSales es el nombre del TextBox donde el usuario ingresa las ventas)
                decimal weeklySales = decimal.Parse(txtSales.Text);

                // Crear un nuevo vendedor y asignar las ventas
                Salesperson salesperson = new Salesperson(); // Crear una instancia de la clase Salesperson
                salesperson.SetWeeklySales(weeklySales); // Asignar las ventas semanales

                // Calcular el salario del vendedor
                decimal salary = salesperson.CalculateSalary();

                // Mostrar el salario calculado en un MessageBox o en un Label
                MessageBox.Show($"Ventas agregadas correctamente. Salario calculado: {salary}", "Salario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el TextBox después de agregar la venta
                txtSales.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
      
