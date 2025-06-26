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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(6, 19);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.Size = new System.Drawing.Size(341, 159);
            this.dgvEntradas.TabIndex = 0;
            // 
            // btnComprarEntrada
            // 
            this.btnComprarEntrada.Location = new System.Drawing.Point(31, 32);
            this.btnComprarEntrada.Name = "btnComprarEntrada";
            this.btnComprarEntrada.Size = new System.Drawing.Size(112, 24);
            this.btnComprarEntrada.TabIndex = 1;
            this.btnComprarEntrada.Text = "Comprar Entrada";
            this.btnComprarEntrada.UseVisualStyleBackColor = true;
            this.btnComprarEntrada.Click += new System.EventHandler(this.btnComprarEntrada_Click);
            // 
            // btnInformeVentas
            // 
            this.btnInformeVentas.Location = new System.Drawing.Point(31, 72);
            this.btnInformeVentas.Name = "btnInformeVentas";
            this.btnInformeVentas.Size = new System.Drawing.Size(112, 26);
            this.btnInformeVentas.TabIndex = 2;
            this.btnInformeVentas.Text = "Informe de Ventas";
            this.btnInformeVentas.UseVisualStyleBackColor = true;
            this.btnInformeVentas.Click += new System.EventHandler(this.btnInformeVentas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEntradas);
            this.groupBox1.Location = new System.Drawing.Point(259, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partidos";
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(31, 210);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(112, 22);
            this.btnSalir2.TabIndex = 4;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnComprarEntrada);
            this.groupBox2.Controls.Add(this.btnSalir2);
            this.groupBox2.Controls.Add(this.btnInformeVentas);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 265);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Entradas De Partidos";
            // 
            // FormEntradasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEntradasDisponibles";
            this.Text = "FormEntradasDisponibles";
            this.Load += new System.EventHandler(this.FormEntradasDisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Button btnComprarEntrada;
        private System.Windows.Forms.Button btnInformeVentas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}