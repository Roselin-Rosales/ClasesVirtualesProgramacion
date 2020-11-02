namespace ClasesVirtualesProgramacion.Dialogs
{
    partial class GastosDialog
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label subcategoriaLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label formapagoLabel;
            System.Windows.Forms.Label descripcionLabel;
            this.dsClasesVirtuales = new ClasesVirtualesProgramacion.Data.dsClasesVirtuales();
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.valorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.formapagoComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            fechaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            subcategoriaLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            formapagoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesVirtuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(344, 236);
            this.btnGuardar.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(447, 236);
            this.btnCancelar.TabIndex = 7;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(12, 59);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(12, 88);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 5;
            categoriaLabel.Text = "Categoria:";
            // 
            // subcategoriaLabel
            // 
            subcategoriaLabel.AutoSize = true;
            subcategoriaLabel.Location = new System.Drawing.Point(12, 125);
            subcategoriaLabel.Name = "subcategoriaLabel";
            subcategoriaLabel.Size = new System.Drawing.Size(73, 13);
            subcategoriaLabel.TabIndex = 7;
            subcategoriaLabel.Text = "Subcategoria:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(201, 59);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 11;
            valorLabel.Text = "valor:";
            // 
            // formapagoLabel
            // 
            formapagoLabel.AutoSize = true;
            formapagoLabel.Location = new System.Drawing.Point(335, 59);
            formapagoLabel.Name = "formapagoLabel";
            formapagoLabel.Size = new System.Drawing.Size(81, 13);
            formapagoLabel.TabIndex = 13;
            formapagoLabel.Text = "Forma de pago:";
            // 
            // dsClasesVirtuales
            // 
            this.dsClasesVirtuales.DataSetName = "dsClasesVirtuales";
            this.dsClasesVirtuales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataMember = "Gastos";
            this.gastosBindingSource.DataSource = this.dsClasesVirtuales;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gastosBindingSource, "fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(89, 59);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.fechaDateTimePicker.TabIndex = 0;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastosBindingSource, "categoria", true));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Alimentos",
            "Transporte",
            "Hogar",
            "Lavanderia",
            "Diversion",
            "Personal"});
            this.categoriaComboBox.Location = new System.Drawing.Point(89, 88);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(433, 21);
            this.categoriaComboBox.TabIndex = 3;
            // 
            // subcategoriaComboBox
            // 
            this.subcategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastosBindingSource, "subcategoria", true));
            this.subcategoriaComboBox.FormattingEnabled = true;
            this.subcategoriaComboBox.Items.AddRange(new object[] {
            "Supermercado",
            "Kiosko",
            "Restaurante",
            "Taxi",
            "Bus",
            "Mototaxi",
            "Electricidad",
            "Agua",
            "Telefono",
            "Jabon",
            "Detergente",
            "Suavizante",
            "azistin",
            "Cine",
            "Viaje",
            "Otros"});
            this.subcategoriaComboBox.Location = new System.Drawing.Point(89, 125);
            this.subcategoriaComboBox.Name = "subcategoriaComboBox";
            this.subcategoriaComboBox.Size = new System.Drawing.Size(433, 21);
            this.subcategoriaComboBox.TabIndex = 4;
            // 
            // valorNumericUpDown
            // 
            this.valorNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gastosBindingSource, "valor", true));
            this.valorNumericUpDown.Location = new System.Drawing.Point(249, 59);
            this.valorNumericUpDown.Name = "valorNumericUpDown";
            this.valorNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.valorNumericUpDown.TabIndex = 1;
            // 
            // formapagoComboBox
            // 
            this.formapagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastosBindingSource, "formapago", true));
            this.formapagoComboBox.FormattingEnabled = true;
            this.formapagoComboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Credito",
            "Tarjeta de credito"});
            this.formapagoComboBox.Location = new System.Drawing.Point(419, 59);
            this.formapagoComboBox.Name = "formapagoComboBox";
            this.formapagoComboBox.Size = new System.Drawing.Size(103, 21);
            this.formapagoComboBox.TabIndex = 2;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 174);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 14;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastosBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(89, 174);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(433, 45);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // GastosDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 285);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(subcategoriaLabel);
            this.Controls.Add(this.subcategoriaComboBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorNumericUpDown);
            this.Controls.Add(formapagoLabel);
            this.Controls.Add(this.formapagoComboBox);
            this.Name = "GastosDialog";
            this.Text = "INFORMACION DE GASTOS";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.formapagoComboBox, 0);
            this.Controls.SetChildIndex(formapagoLabel, 0);
            this.Controls.SetChildIndex(this.valorNumericUpDown, 0);
            this.Controls.SetChildIndex(valorLabel, 0);
            this.Controls.SetChildIndex(this.subcategoriaComboBox, 0);
            this.Controls.SetChildIndex(subcategoriaLabel, 0);
            this.Controls.SetChildIndex(this.categoriaComboBox, 0);
            this.Controls.SetChildIndex(categoriaLabel, 0);
            this.Controls.SetChildIndex(this.fechaDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesVirtuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.dsClasesVirtuales dsClasesVirtuales;
        private System.Windows.Forms.BindingSource gastosBindingSource;
        public System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        public System.Windows.Forms.ComboBox categoriaComboBox;
        public System.Windows.Forms.ComboBox subcategoriaComboBox;
        public System.Windows.Forms.NumericUpDown valorNumericUpDown;
        public System.Windows.Forms.ComboBox formapagoComboBox;
        public System.Windows.Forms.TextBox descripcionTextBox;
    }
}