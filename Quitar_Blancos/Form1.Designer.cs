namespace Quitar_Blancos
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
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnOrigen = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(116, 50);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(425, 20);
            this.txtOrigen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORIGEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DESTINO";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(116, 76);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(425, 20);
            this.txtDestino.TabIndex = 3;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(658, 50);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(169, 46);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultado.Location = new System.Drawing.Point(36, 106);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(800, 361);
            this.txtResultado.TabIndex = 5;
            // 
            // btnOrigen
            // 
            this.btnOrigen.Location = new System.Drawing.Point(547, 48);
            this.btnOrigen.Name = "btnOrigen";
            this.btnOrigen.Size = new System.Drawing.Size(92, 23);
            this.btnOrigen.TabIndex = 6;
            this.btnOrigen.Text = "Buscar Origen";
            this.btnOrigen.UseVisualStyleBackColor = true;
            this.btnOrigen.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(547, 73);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(92, 23);
            this.btnDestino.TabIndex = 7;
            this.btnDestino.Text = "Buscar destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quitar Espacios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnOrigen);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnOrigen;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Label label3;
    }
}

