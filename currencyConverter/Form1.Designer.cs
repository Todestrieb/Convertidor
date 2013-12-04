namespace Convertidor
{
    partial class currencyConverter
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
        	this.dolares = new System.Windows.Forms.Label();
        	this.dolaresForma = new System.Windows.Forms.TextBox();
        	this.pesosForma = new System.Windows.Forms.TextBox();
        	this.tipoCambioForma = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.button2 = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// dolares
        	// 
        	this.dolares.AutoSize = true;
        	this.dolares.BackColor = System.Drawing.Color.White;
        	this.dolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dolares.ForeColor = System.Drawing.Color.Black;
        	this.dolares.Location = new System.Drawing.Point(415, 59);
        	this.dolares.Name = "dolares";
        	this.dolares.Size = new System.Drawing.Size(210, 25);
        	this.dolares.TabIndex = 0;
        	this.dolares.Text = "Cantidad convertida:";
        	this.dolares.Click += new System.EventHandler(this.label1_Click);
        	// 
        	// dolaresForma
        	// 
        	this.dolaresForma.BackColor = System.Drawing.Color.White;
        	this.dolaresForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dolaresForma.ForeColor = System.Drawing.Color.Black;
        	this.dolaresForma.Location = new System.Drawing.Point(415, 115);
        	this.dolaresForma.Name = "dolaresForma";
        	this.dolaresForma.ReadOnly = true;
        	this.dolaresForma.Size = new System.Drawing.Size(237, 38);
        	this.dolaresForma.TabIndex = 3;
        	// 
        	// pesosForma
        	// 
        	this.pesosForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.pesosForma.ForeColor = System.Drawing.Color.Black;
        	this.pesosForma.Location = new System.Drawing.Point(8, 49);
        	this.pesosForma.Name = "pesosForma";
        	this.pesosForma.Size = new System.Drawing.Size(259, 35);
        	this.pesosForma.TabIndex = 0;
        	// 
        	// tipoCambioForma
        	// 
        	this.tipoCambioForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.tipoCambioForma.ForeColor = System.Drawing.Color.Black;
        	this.tipoCambioForma.Location = new System.Drawing.Point(8, 155);
        	this.tipoCambioForma.Name = "tipoCambioForma";
        	this.tipoCambioForma.Size = new System.Drawing.Size(141, 35);
        	this.tipoCambioForma.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.BackColor = System.Drawing.Color.White;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.Black;
        	this.label1.Location = new System.Drawing.Point(8, 115);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(165, 25);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Tipo de cambio:";
        	this.label1.Click += new System.EventHandler(this.label1_Click);
        	// 
        	// button2
        	// 
        	this.button2.BackColor = System.Drawing.Color.White;
        	this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button2.ForeColor = System.Drawing.Color.Black;
        	this.button2.Location = new System.Drawing.Point(490, 281);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(184, 39);
        	this.button2.TabIndex = 2;
        	this.button2.Text = "Convertir";
        	this.button2.UseVisualStyleBackColor = false;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.BackColor = System.Drawing.Color.White;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.Black;
        	this.label2.Location = new System.Drawing.Point(8, 11);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(211, 25);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "Cantidad a convertir:";
        	this.label2.Click += new System.EventHandler(this.label1_Click);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.BackColor = System.Drawing.Color.White;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        	this.label3.Location = new System.Drawing.Point(386, 124);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(24, 25);
        	this.label3.TabIndex = 0;
        	this.label3.Text = "$";
        	this.label3.Click += new System.EventHandler(this.label1_Click);
        	// 
        	// currencyConverter
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.ClientSize = new System.Drawing.Size(686, 332);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.tipoCambioForma);
        	this.Controls.Add(this.pesosForma);
        	this.Controls.Add(this.dolaresForma);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.dolares);
        	this.Name = "currencyConverter";
        	this.Text = "Convertidor";
        	this.Load += new System.EventHandler(this.currencyConverter_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label dolares;
        private System.Windows.Forms.TextBox dolaresForma;
        private System.Windows.Forms.TextBox pesosForma;
        private System.Windows.Forms.TextBox tipoCambioForma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

