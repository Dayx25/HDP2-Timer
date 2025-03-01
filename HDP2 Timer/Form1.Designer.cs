namespace HDP2_Timer
{
    partial class FormREIZ
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
            this.components = new System.ComponentModel.Container();
            this.ButtDesplazar = new System.Windows.Forms.Button();
            this.TmrDesplazar = new System.Windows.Forms.Timer(this.components);
            this.ElrashoPng = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ElrashoPng)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtDesplazar
            // 
            this.ButtDesplazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtDesplazar.Location = new System.Drawing.Point(281, 342);
            this.ButtDesplazar.Name = "ButtDesplazar";
            this.ButtDesplazar.Size = new System.Drawing.Size(263, 66);
            this.ButtDesplazar.TabIndex = 1;
            this.ButtDesplazar.Text = "Desplazar";
            this.ButtDesplazar.UseVisualStyleBackColor = true;
            this.ButtDesplazar.Click += new System.EventHandler(this.ButtDesplazar_Click);
            // 
            // TmrDesplazar
            // 
            this.TmrDesplazar.Tick += new System.EventHandler(this.TmrDesplazar_Tick);
            // 
            // ElrashoPng
            // 
            this.ElrashoPng.Image = global::HDP2_Timer.Properties.Resources._640px_Adolf_Hitler___Nazismo;
            this.ElrashoPng.Location = new System.Drawing.Point(12, 27);
            this.ElrashoPng.Name = "ElrashoPng";
            this.ElrashoPng.Size = new System.Drawing.Size(265, 260);
            this.ElrashoPng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ElrashoPng.TabIndex = 0;
            this.ElrashoPng.TabStop = false;
            // 
            // FormREIZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtDesplazar);
            this.Controls.Add(this.ElrashoPng);
            this.Name = "FormREIZ";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormREIZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElrashoPng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ElrashoPng;
        private System.Windows.Forms.Button ButtDesplazar;
        private System.Windows.Forms.Timer TmrDesplazar;
    }
}

