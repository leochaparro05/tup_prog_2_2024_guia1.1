namespace ejercicio1._1._3
{
    partial class Cargapeaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.tbCantautos = new System.Windows.Forms.TextBox();
            this.numdias = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numdias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cantidad de autos";
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.Location = new System.Drawing.Point(207, 238);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(112, 60);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(381, 238);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(120, 60);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // tbCantautos
            // 
            this.tbCantautos.Location = new System.Drawing.Point(401, 145);
            this.tbCantautos.Name = "tbCantautos";
            this.tbCantautos.Size = new System.Drawing.Size(100, 20);
            this.tbCantautos.TabIndex = 4;
            // 
            // numdias
            // 
            this.numdias.Location = new System.Drawing.Point(401, 97);
            this.numdias.Name = "numdias";
            this.numdias.Size = new System.Drawing.Size(120, 20);
            this.numdias.TabIndex = 5;
            // 
            // Cargapeaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 351);
            this.Controls.Add(this.numdias);
            this.Controls.Add(this.tbCantautos);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cargapeaje";
            this.Text = "Cargapeaje";
            ((System.ComponentModel.ISupportInitialize)(this.numdias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnaceptar;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox tbCantautos;
        public System.Windows.Forms.NumericUpDown numdias;
    }
}