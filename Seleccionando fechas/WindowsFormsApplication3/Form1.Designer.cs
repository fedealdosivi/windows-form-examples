namespace WindowsFormsApplication3
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnComparar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAceptarMonth = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnACEPTARORA = new System.Windows.Forms.Button();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(31, 149);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(148, 36);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar luego Comparar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 102);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(32, 191);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(147, 32);
            this.btnComparar.TabIndex = 3;
            this.btnComparar.Text = "Comparar las 2 fechas";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 11);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione dos fechas";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(246, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // btnAceptarMonth
            // 
            this.btnAceptarMonth.Location = new System.Drawing.Point(268, 175);
            this.btnAceptarMonth.Name = "btnAceptarMonth";
            this.btnAceptarMonth.Size = new System.Drawing.Size(184, 21);
            this.btnAceptarMonth.TabIndex = 8;
            this.btnAceptarMonth.Text = "Aceptar MOnthCalendar";
            this.btnAceptarMonth.UseVisualStyleBackColor = true;
            this.btnAceptarMonth.Click += new System.EventHandler(this.btnAceptarMonth_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aceptar MOnthCalendar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(497, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 160);
            this.listBox1.TabIndex = 10;
            // 
            // btnACEPTARORA
            // 
            this.btnACEPTARORA.Location = new System.Drawing.Point(173, 304);
            this.btnACEPTARORA.Name = "btnACEPTARORA";
            this.btnACEPTARORA.Size = new System.Drawing.Size(140, 27);
            this.btnACEPTARORA.TabIndex = 12;
            this.btnACEPTARORA.Text = "button2";
            this.btnACEPTARORA.UseVisualStyleBackColor = true;
            this.btnACEPTARORA.Click += new System.EventHandler(this.btnACEPTARORA_Click);
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "00:00 am",
            "01:00 am",
            "02:00 am",
            "03:00 am",
            "04:00 am",
            "05:00 am",
            "07:00 am",
            "08:00 am",
            "09:00 am",
            "10:00 am",
            "11:00 am",
            "12:00 pm",
            "13:00 pm",
            "14:00 pm",
            "15:00 pm",
            "16:00 pm",
            "17:00 pm",
            "18:00 pm ",
            "19:00 pm",
            "20:00 pm",
            "21:00 pm",
            "22:00 pm",
            "23:00 pm"});
            this.cmbHora.Location = new System.Drawing.Point(24, 308);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(136, 21);
            this.cmbHora.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 389);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.btnACEPTARORA);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceptarMonth);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAceptarMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnACEPTARORA;
        private System.Windows.Forms.ComboBox cmbHora;
    }
}

