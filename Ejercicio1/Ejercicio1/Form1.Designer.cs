namespace Ejercicio1
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
            this.btnThrowDice = new System.Windows.Forms.Button();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblAddition = new System.Windows.Forms.Label();
            this.lblAdditin2 = new System.Windows.Forms.Label();
            this.lstCountingSums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnThrowDice
            // 
            this.btnThrowDice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThrowDice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThrowDice.Location = new System.Drawing.Point(80, 15);
            this.btnThrowDice.Name = "btnThrowDice";
            this.btnThrowDice.Size = new System.Drawing.Size(205, 51);
            this.btnThrowDice.TabIndex = 0;
            this.btnThrowDice.Text = "Lanzar dados";
            this.btnThrowDice.UseVisualStyleBackColor = true;
            this.btnThrowDice.Click += new System.EventHandler(this.btnThrowDice_Click);
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1.Location = new System.Drawing.Point(76, 84);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(62, 19);
            this.lblDice1.TabIndex = 1;
            this.lblDice1.Text = "Dado 1:";
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2.Location = new System.Drawing.Point(223, 84);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(62, 19);
            this.lblDice2.TabIndex = 2;
            this.lblDice2.Text = "Dado 2:";
            // 
            // lblAddition
            // 
            this.lblAddition.AutoSize = true;
            this.lblAddition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddition.Location = new System.Drawing.Point(152, 85);
            this.lblAddition.Name = "lblAddition";
            this.lblAddition.Size = new System.Drawing.Size(0, 19);
            this.lblAddition.TabIndex = 3;
            // 
            // lblAdditin2
            // 
            this.lblAdditin2.AutoSize = true;
            this.lblAdditin2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAdditin2.Location = new System.Drawing.Point(291, 85);
            this.lblAdditin2.Name = "lblAdditin2";
            this.lblAdditin2.Size = new System.Drawing.Size(0, 13);
            this.lblAdditin2.TabIndex = 4;
            // 
            // lstCountingSums
            // 
            this.lstCountingSums.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCountingSums.FormattingEnabled = true;
            this.lstCountingSums.ItemHeight = 15;
            this.lstCountingSums.Location = new System.Drawing.Point(87, 136);
            this.lstCountingSums.Name = "lstCountingSums";
            this.lstCountingSums.Size = new System.Drawing.Size(230, 214);
            this.lstCountingSums.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 454);
            this.Controls.Add(this.lstCountingSums);
            this.Controls.Add(this.lblAdditin2);
            this.Controls.Add(this.lblAddition);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.btnThrowDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThrowDice;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblAddition;
        private System.Windows.Forms.Label lblAdditin2;
        private System.Windows.Forms.ListBox lstCountingSums;
    }
}

