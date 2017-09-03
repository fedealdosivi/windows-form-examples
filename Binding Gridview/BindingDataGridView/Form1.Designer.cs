namespace IsraSoft.BindingDataGridView
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNombre,
            this.columnCantidad,
            this.columnPrecio,
            this.columnIva,
            this.columnDescuento,
            this.columnTotal});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // columnNombre
            // 
            this.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNombre.DataPropertyName = "nombre";
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            // 
            // columnCantidad
            // 
            this.columnCantidad.DataPropertyName = "cantidad";
            this.columnCantidad.HeaderText = "Cantidad";
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.Width = 80;
            // 
            // columnPrecio
            // 
            this.columnPrecio.DataPropertyName = "precio";
            dataGridViewCellStyle5.Format = "C";
            this.columnPrecio.DefaultCellStyle = dataGridViewCellStyle5;
            this.columnPrecio.HeaderText = "Precio";
            this.columnPrecio.Name = "columnPrecio";
            this.columnPrecio.Width = 80;
            // 
            // columnIva
            // 
            this.columnIva.DataPropertyName = "iva";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "00.00";
            this.columnIva.DefaultCellStyle = dataGridViewCellStyle6;
            this.columnIva.HeaderText = "IVA";
            this.columnIva.Name = "columnIva";
            this.columnIva.Width = 80;
            // 
            // columnDescuento
            // 
            this.columnDescuento.DataPropertyName = "descuento";
            dataGridViewCellStyle7.Format = "N2";
            this.columnDescuento.DefaultCellStyle = dataGridViewCellStyle7;
            this.columnDescuento.HeaderText = "Descuento";
            this.columnDescuento.Name = "columnDescuento";
            this.columnDescuento.Width = 80;
            // 
            // columnTotal
            // 
            this.columnTotal.DataPropertyName = "total";
            dataGridViewCellStyle8.Format = "C";
            this.columnTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.columnTotal.HeaderText = "Total";
            this.columnTotal.Name = "columnTotal";
            this.columnTotal.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Producto actual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Uso de BindingSource en DataGridView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.Button button1;
    }
}

