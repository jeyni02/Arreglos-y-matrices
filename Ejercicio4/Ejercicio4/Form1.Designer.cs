namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSales
            // 
            this.txtSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSales.Location = new System.Drawing.Point(150, 41);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(147, 26);
            this.txtSales.TabIndex = 0;
            // 
            // btnAddSales
            // 
            this.btnAddSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSales.Location = new System.Drawing.Point(93, 85);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(185, 49);
            this.btnAddSales.TabIndex = 1;
            this.btnAddSales.Text = "Agregar Ventas";
            this.btnAddSales.UseVisualStyleBackColor = true;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // btnShowResults
            // 
            this.btnShowResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResults.Location = new System.Drawing.Point(30, 165);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(220, 35);
            this.btnShowResults.TabIndex = 2;
            this.btnShowResults.Text = "Mostrar Resultados";
            this.btnShowResults.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(30, 206);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(254, 121);
            this.lstResults.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese monto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.btnAddSales);
            this.Controls.Add(this.txtSales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label1;
    }
}

