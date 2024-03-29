namespace S1_Lab02___Manejo_de_Clases
{
    partial class frmEmpleado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMinutosTardanza = new System.Windows.Forms.Label();
            this.lblLlamadasAtencion = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbMinutosTardanza = new System.Windows.Forms.TextBox();
            this.txtbLLamadasAtencion = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.dgEmpleado = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinutosTardanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlamadasAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(80, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(80, 75);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMinutosTardanza
            // 
            this.lblMinutosTardanza.AutoSize = true;
            this.lblMinutosTardanza.Location = new System.Drawing.Point(298, 41);
            this.lblMinutosTardanza.Name = "lblMinutosTardanza";
            this.lblMinutosTardanza.Size = new System.Drawing.Size(107, 13);
            this.lblMinutosTardanza.TabIndex = 2;
            this.lblMinutosTardanza.Text = "Minutos de Tardanza";
            // 
            // lblLlamadasAtencion
            // 
            this.lblLlamadasAtencion.AutoSize = true;
            this.lblLlamadasAtencion.Location = new System.Drawing.Point(298, 75);
            this.lblLlamadasAtencion.Name = "lblLlamadasAtencion";
            this.lblLlamadasAtencion.Size = new System.Drawing.Size(112, 13);
            this.lblLlamadasAtencion.TabIndex = 3;
            this.lblLlamadasAtencion.Text = "Llamadas de Atencion";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(152, 38);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 4;
            // 
            // txtbMinutosTardanza
            // 
            this.txtbMinutosTardanza.Location = new System.Drawing.Point(424, 39);
            this.txtbMinutosTardanza.Name = "txtbMinutosTardanza";
            this.txtbMinutosTardanza.Size = new System.Drawing.Size(100, 20);
            this.txtbMinutosTardanza.TabIndex = 5;
            // 
            // txtbLLamadasAtencion
            // 
            this.txtbLLamadasAtencion.Location = new System.Drawing.Point(424, 76);
            this.txtbLLamadasAtencion.Name = "txtbLLamadasAtencion";
            this.txtbLLamadasAtencion.Size = new System.Drawing.Size(100, 20);
            this.txtbLLamadasAtencion.TabIndex = 6;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbCategoria.Location = new System.Drawing.Point(152, 73);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(100, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // dgEmpleado
            // 
            this.dgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Categoria,
            this.MinutosTardanza,
            this.LlamadasAtencion,
            this.Pago});
            this.dgEmpleado.Location = new System.Drawing.Point(37, 121);
            this.dgEmpleado.Name = "dgEmpleado";
            this.dgEmpleado.Size = new System.Drawing.Size(542, 211);
            this.dgEmpleado.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(356, 367);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(407, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(97, 362);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(163, 23);
            this.btnProcesar.TabIndex = 11;
            this.btnProcesar.Text = "Procesar Empleado";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // MinutosTardanza
            // 
            this.MinutosTardanza.HeaderText = "MinutosTardanza";
            this.MinutosTardanza.Name = "MinutosTardanza";
            // 
            // LlamadasAtencion
            // 
            this.LlamadasAtencion.HeaderText = "LlamadasAtencion";
            this.LlamadasAtencion.Name = "LlamadasAtencion";
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 419);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgEmpleado);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtbLLamadasAtencion);
            this.Controls.Add(this.txtbMinutosTardanza);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblLlamadasAtencion);
            this.Controls.Add(this.lblMinutosTardanza);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMinutosTardanza;
        private System.Windows.Forms.Label lblLlamadasAtencion;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbMinutosTardanza;
        private System.Windows.Forms.TextBox txtbLLamadasAtencion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridView dgEmpleado;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinutosTardanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlamadasAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
    }
}

