namespace Ejercicio2
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
            this.rbSmoking = new System.Windows.Forms.RadioButton();
            this.rbNonSmoking = new System.Windows.Forms.RadioButton();
            this.btnReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbSmoking
            // 
            this.rbSmoking.AutoSize = true;
            this.rbSmoking.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmoking.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbSmoking.Location = new System.Drawing.Point(57, 56);
            this.rbSmoking.Name = "rbSmoking";
            this.rbSmoking.Size = new System.Drawing.Size(120, 26);
            this.rbSmoking.TabIndex = 0;
            this.rbSmoking.TabStop = true;
            this.rbSmoking.Text = "Fumadores";
            this.rbSmoking.UseVisualStyleBackColor = true;
            // 
            // rbNonSmoking
            // 
            this.rbNonSmoking.AutoSize = true;
            this.rbNonSmoking.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNonSmoking.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbNonSmoking.Location = new System.Drawing.Point(57, 96);
            this.rbNonSmoking.Name = "rbNonSmoking";
            this.rbNonSmoking.Size = new System.Drawing.Size(149, 26);
            this.rbNonSmoking.TabIndex = 1;
            this.rbNonSmoking.TabStop = true;
            this.rbNonSmoking.Text = "No Fumadores";
            this.rbNonSmoking.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReserve.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(67, 140);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(110, 40);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "Reservar";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 265);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.rbNonSmoking);
            this.Controls.Add(this.rbSmoking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSmoking;
        private System.Windows.Forms.RadioButton rbNonSmoking;
        private System.Windows.Forms.Button btnReserve;
    }
}

