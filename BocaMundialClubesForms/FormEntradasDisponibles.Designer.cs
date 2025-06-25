namespace BocaMundialClubesForms
{
    partial class FormEntradasDisponibles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.btnComprarEntrada = new System.Windows.Forms.Button();
            this.btnInformeVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(233, 51);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.Size = new System.Drawing.Size(457, 335);
            this.dgvEntradas.TabIndex = 0;
            // 
            // btnComprarEntrada
            // 
            this.btnComprarEntrada.Location = new System.Drawing.Point(53, 51);
            this.btnComprarEntrada.Name = "btnComprarEntrada";
            this.btnComprarEntrada.Size = new System.Drawing.Size(155, 53);
            this.btnComprarEntrada.TabIndex = 1;
            this.btnComprarEntrada.Text = "Comprar Entrada";
            this.btnComprarEntrada.UseVisualStyleBackColor = true;
            this.btnComprarEntrada.Click += new System.EventHandler(this.btnComprarEntrada_Click);
            // 
            // btnInformeVentas
            // 
            this.btnInformeVentas.Location = new System.Drawing.Point(53, 148);
            this.btnInformeVentas.Name = "btnInformeVentas";
            this.btnInformeVentas.Size = new System.Drawing.Size(159, 53);
            this.btnInformeVentas.TabIndex = 2;
            this.btnInformeVentas.Text = "Informe de Ventas";
            this.btnInformeVentas.UseVisualStyleBackColor = true;
            this.btnInformeVentas.Click += new System.EventHandler(this.btnInformeVentas_Click);
            // 
            // FormEntradasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInformeVentas);
            this.Controls.Add(this.btnComprarEntrada);
            this.Controls.Add(this.dgvEntradas);
            this.Name = "FormEntradasDisponibles";
            this.Text = "FormEntradasDisponibles";
            this.Load += new System.EventHandler(this.FormEntradasDisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Button btnComprarEntrada;
        private System.Windows.Forms.Button btnInformeVentas;
    }
}