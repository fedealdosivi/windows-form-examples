namespace CambiarColor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCambiarFuente = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(33, 36);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(128, 23);
            this.btnCambiar.TabIndex = 0;
            this.btnCambiar.Text = "Cambiar Color";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCambiarFuente
            // 
            this.btnCambiarFuente.Location = new System.Drawing.Point(33, 65);
            this.btnCambiarFuente.Name = "btnCambiarFuente";
            this.btnCambiarFuente.Size = new System.Drawing.Size(128, 23);
            this.btnCambiarFuente.TabIndex = 1;
            this.btnCambiarFuente.Text = "Cambiar Fuente";
            this.btnCambiarFuente.UseVisualStyleBackColor = true;
            this.btnCambiarFuente.Click += new System.EventHandler(this.btnCambiarFuente_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(33, 94);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 137);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCambiarFuente);
            this.Controls.Add(this.btnCambiar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnCambiarFuente;
        private System.Windows.Forms.Button btnImprimir;
    }
}

