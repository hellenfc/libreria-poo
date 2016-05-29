namespace Proyecto_POO
{
    partial class ModificarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarLibro));
            this.listBoxisbn = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarL = new System.Windows.Forms.Button();
            this.buttonBuscarP = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelPdf = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPortada = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelPaginas = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.labelEdicion = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.numericAño = new System.Windows.Forms.NumericUpDown();
            this.labelAño = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxisbn
            // 
            this.listBoxisbn.FormattingEnabled = true;
            this.listBoxisbn.Location = new System.Drawing.Point(61, 69);
            this.listBoxisbn.Name = "listBoxisbn";
            this.listBoxisbn.Size = new System.Drawing.Size(146, 277);
            this.listBoxisbn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN: ";
            // 
            // buttonBuscarL
            // 
            this.buttonBuscarL.Location = new System.Drawing.Point(642, 337);
            this.buttonBuscarL.Name = "buttonBuscarL";
            this.buttonBuscarL.Size = new System.Drawing.Size(84, 27);
            this.buttonBuscarL.TabIndex = 49;
            this.buttonBuscarL.Text = "Buscar Libro";
            this.buttonBuscarL.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarP
            // 
            this.buttonBuscarP.Location = new System.Drawing.Point(629, 45);
            this.buttonBuscarP.Name = "buttonBuscarP";
            this.buttonBuscarP.Size = new System.Drawing.Size(92, 28);
            this.buttonBuscarP.TabIndex = 48;
            this.buttonBuscarP.Text = "Buscar Portada";
            this.buttonBuscarP.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(588, 400);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 33);
            this.buttonCancelar.TabIndex = 47;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelPdf
            // 
            this.labelPdf.AutoSize = true;
            this.labelPdf.BackColor = System.Drawing.Color.Transparent;
            this.labelPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPdf.Location = new System.Drawing.Point(561, 342);
            this.labelPdf.Name = "labelPdf";
            this.labelPdf.Size = new System.Drawing.Size(75, 17);
            this.labelPdf.TabIndex = 46;
            this.labelPdf.Text = "Libro PDF:";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(441, 400);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(93, 33);
            this.buttonEliminar.TabIndex = 45;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(564, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 214);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // labelPortada
            // 
            this.labelPortada.AutoSize = true;
            this.labelPortada.BackColor = System.Drawing.Color.Transparent;
            this.labelPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPortada.Location = new System.Drawing.Point(561, 51);
            this.labelPortada.Name = "labelPortada";
            this.labelPortada.Size = new System.Drawing.Size(62, 17);
            this.labelPortada.TabIndex = 43;
            this.labelPortada.Text = "Portada:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(332, 327);
            this.txtPrecio.MaxLength = 1000000;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(183, 20);
            this.txtPrecio.TabIndex = 42;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrecio.Location = new System.Drawing.Point(268, 327);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(52, 17);
            this.labelPrecio.TabIndex = 41;
            this.labelPrecio.Text = "Precio:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(411, 278);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 40;
            // 
            // labelPaginas
            // 
            this.labelPaginas.AutoSize = true;
            this.labelPaginas.BackColor = System.Drawing.Color.Transparent;
            this.labelPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaginas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPaginas.Location = new System.Drawing.Point(268, 278);
            this.labelPaginas.Name = "labelPaginas";
            this.labelPaginas.Size = new System.Drawing.Size(137, 17);
            this.labelPaginas.TabIndex = 39;
            this.labelPaginas.Text = "Número de Paginas:";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(332, 231);
            this.txtEdicion.MaxLength = 255;
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(183, 20);
            this.txtEdicion.TabIndex = 38;
            // 
            // labelEdicion
            // 
            this.labelEdicion.AutoSize = true;
            this.labelEdicion.BackColor = System.Drawing.Color.Transparent;
            this.labelEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdicion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEdicion.Location = new System.Drawing.Point(268, 231);
            this.labelEdicion.Name = "labelEdicion";
            this.labelEdicion.Size = new System.Drawing.Size(58, 17);
            this.labelEdicion.TabIndex = 37;
            this.labelEdicion.Text = "Edición:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Literatura Clásica",
            "Ciencia Ficción",
            "Música",
            "Romance",
            "Comedia",
            "Aventura",
            "Acción",
            "Misterio",
            "Terror",
            "Novela ",
            "Literatura",
            "Historia",
            "Filosofía",
            "Salud",
            "Cocina",
            "Religión",
            "DIY",
            "Programación",
            "Matemáticas",
            "Física",
            "Química",
            "Biografía"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(348, 183);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCategoria.TabIndex = 36;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCategoria.Location = new System.Drawing.Point(268, 183);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(73, 17);
            this.labelCategoria.TabIndex = 35;
            this.labelCategoria.Text = "Categoría:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(320, 135);
            this.txtAutor.MaxLength = 255;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(195, 20);
            this.txtAutor.TabIndex = 34;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.BackColor = System.Drawing.Color.Transparent;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAutor.Location = new System.Drawing.Point(268, 135);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(46, 17);
            this.labelAutor.TabIndex = 33;
            this.labelAutor.Text = "Autor:";
            // 
            // numericAño
            // 
            this.numericAño.Location = new System.Drawing.Point(311, 86);
            this.numericAño.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericAño.Name = "numericAño";
            this.numericAño.Size = new System.Drawing.Size(120, 20);
            this.numericAño.TabIndex = 32;
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.BackColor = System.Drawing.Color.Transparent;
            this.labelAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAño.Location = new System.Drawing.Point(268, 86);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(37, 17);
            this.labelAño.TabIndex = 31;
            this.labelAño.Text = "Año:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(336, 40);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombre.Location = new System.Drawing.Point(268, 40);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 17);
            this.labelNombre.TabIndex = 27;
            this.labelNombre.Text = "Nombre:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(299, 400);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(93, 33);
            this.buttonGuardar.TabIndex = 50;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ModificarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_POO.Properties.Resources.fondoazul3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonBuscarL);
            this.Controls.Add(this.buttonBuscarP);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelPdf);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPortada);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelPaginas);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.labelEdicion);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.numericAño);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxisbn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarLibro";
            this.Text = "Modificar Libro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModificarLibro_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxisbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarL;
        private System.Windows.Forms.Button buttonBuscarP;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelPdf;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPortada;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelPaginas;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label labelEdicion;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.NumericUpDown numericAño;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonGuardar;
    }
}