using Ejercicio3.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private Sale salesData;
        public Form1()
        {
            InitializeComponent();
            salesData = new Sale(); //Inicializamos el objeto de ventas

            // Agregar datos de ventas iniciales
            salesData.AddSale(1, 1, 100);
            salesData.AddSale(1, 2, 150);
            salesData.AddSale(2, 1, 200);
            salesData.AddSale(3, 5, 300);
            salesData.AddSale(4, 3, 250);

            // Muestra los datos del DataGridView
            DisplaySalesData();
        }

        private void SetupDataGridView(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            dataGridViewSales.Columns.Clear();

            // Agregar columnas (vendedores)
            for (int i = 1; i <= 4; i++)
            {
                dataGridViewSales.Columns.Add($"Vendor{i}", $"Vendedor {i}");
            }

            // Agregar columna de total por producto
            dataGridViewSales.Columns.Add("TotalProduct", "Total Producto");
        }

        // Mostrar los datos de ventas en el DataGridView
        private void DisplaySalesData()
        {
            // Limpiar las filas actuales del DataGridView
            dataGridViewSales.Rows.Clear();

            // Iterar por los productos (1 a 5)
            for (int product = 1; product <= 5; product++)
            {
                // Agregar una nueva fila para cada producto
                int rowIndex = dataGridViewSales.Rows.Add();
                dataGridViewSales.Rows[rowIndex].HeaderCell.Value = $"Producto {product}"; // Título de la fila

                // Variable para calcular el total por producto
                decimal totalProduct = 0;

                // Iterar por los vendedores (1 a 4)
                for (int vendor = 1; vendor <= 4; vendor++)
                {
                    // Obtener las ventas del vendedor para ese producto
                    decimal sales = salesData.GetSalesData()[vendor - 1, product - 1];

                    // Asignar la venta al DataGridView
                    dataGridViewSales.Rows[rowIndex].Cells[vendor - 1].Value = sales;

                    // Sumar al total del producto
                    totalProduct += sales;
                }

                // Mostrar el total de ventas por producto
                dataGridViewSales.Rows[rowIndex].Cells[dataGridViewSales.Columns.Count - 1].Value = totalProduct;
            }

            // Agregar una fila de totales por vendedor
            int totalRowIndex = dataGridViewSales.Rows.Add();
            dataGridViewSales.Rows[totalRowIndex].HeaderCell.Value = "Totales Vendedores";

            // Variable para calcular el total general
            decimal totalGeneral = 0;

            // Calcular los totales por vendedor
            for (int vendor = 1; vendor <= 4; vendor++)
            {
                decimal totalVendor = salesData.GetVendorTotal(vendor);
                dataGridViewSales.Rows[totalRowIndex].Cells[vendor - 1].Value = totalVendor;
                totalGeneral += totalVendor;
            }

            // Mostrar el total general en la última celda
            dataGridViewSales.Rows[totalRowIndex].Cells[dataGridViewSales.Columns.Count - 1].Value = totalGeneral;
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                int vendor = int.Parse(txtVendor.Text);
                int product = int.Parse(txtProduct.Text);
                decimal amount = decimal.Parse(txtAmount.Text);

                // Agregar la venta al sistema
                salesData.AddSale(vendor, product, amount);

                // Actualizar la tabla
                DisplaySalesData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}

