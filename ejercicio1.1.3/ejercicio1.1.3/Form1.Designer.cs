namespace ejercicio1._1._3
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
            this.btnregistrarpeaje = new System.Windows.Forms.Button();
            this.btnverresumen = new System.Windows.Forms.Button();
            this.lbagregar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnregistrarpeaje
            // 
            this.btnregistrarpeaje.Location = new System.Drawing.Point(633, 53);
            this.btnregistrarpeaje.Name = "btnregistrarpeaje";
            this.btnregistrarpeaje.Size = new System.Drawing.Size(131, 45);
            this.btnregistrarpeaje.TabIndex = 0;
            this.btnregistrarpeaje.Text = "registrar peaje";
            this.btnregistrarpeaje.UseVisualStyleBackColor = true;
            this.btnregistrarpeaje.Click += new System.EventHandler(this.btnregistrarpeaje_Click);
            // 
            // btnverresumen
            // 
            this.btnverresumen.Location = new System.Drawing.Point(633, 104);
            this.btnverresumen.Name = "btnverresumen";
            this.btnverresumen.Size = new System.Drawing.Size(131, 51);
            this.btnverresumen.TabIndex = 1;
            this.btnverresumen.Text = "ver resumen";
            this.btnverresumen.UseVisualStyleBackColor = true;
            this.btnverresumen.Click += new System.EventHandler(this.btnverresumen_Click);
            // 
            // lbagregar
            // 
            this.lbagregar.FormattingEnabled = true;
            this.lbagregar.Location = new System.Drawing.Point(42, 27);
            this.lbagregar.Name = "lbagregar";
            this.lbagregar.Size = new System.Drawing.Size(550, 420);
            this.lbagregar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbagregar);
            this.Controls.Add(this.btnverresumen);
            this.Controls.Add(this.btnregistrarpeaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregistrarpeaje;
        private System.Windows.Forms.Button btnverresumen;
        private System.Windows.Forms.ListBox lbagregar;
    }
}

