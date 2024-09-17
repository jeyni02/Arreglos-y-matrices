using Ejercicio1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private ThrowDice LanzarDados;

        public Form1()
        {
            InitializeComponent();
            LanzarDados = new ThrowDice(); // Inicializa la clase LanzarDados
        }

        // Este método se ejecuta cuando el usuario hace clic en el botón "Lanzar Dados"
        private void btnThrowDice_Click(object sender, EventArgs e)
        {
            // Realiza un lanzamiento
            Tuple<int, int, int> resultado = LanzarDados.Throw();
            int dice1 = resultado.Item1;
            int dice2 = resultado.Item2;
            int addition = resultado.Item3;

            // Actualiza las etiquetas con los resultados
            lblDice1.Text = $"Dado 1: {dice1}";
            lblDice2.Text = $"Dado 2: {dice2}";
            lblAddition.Text = $"Suma: {addition}";

            // Mostrar el conteo acumulado de sumas
            MostrarConteoSumas();

        }

        // Método para mostrar el conteo acumulado de las sumas
        private void MostrarConteoSumas()
        {
            int[] conteoSumas = LanzarDados.GetSumCount();

            // Limpiar el ListBox antes de mostrar los conteos actualizados
            lstCountingSums.Items.Clear();
            lstCountingSums.Items.Add("Suma\tCantidad");

            for (int i = 0; i < conteoSumas.Length; i++)
            {
                int suma = i + 2;
                int cantidad = conteoSumas[i];
                lstCountingSums.Items.Add($"{suma}\t{cantidad}");
            }
        }
    }
}
