namespace Proyecto_POO
{
    partial class AgregarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarLibro));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.labelAño = new System.Windows.Forms.Label();
            this.numericAño = new System.Windows.Forms.NumericUpDown();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.labelEdicion = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelPaginas = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelPortada = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelPdf = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBuscarP = new System.Windows.Forms.Button();
            this.buttonBuscarL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 29);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombre.Location = new System.Drawing.Point(41, 29);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 17);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(90, 75);
            this.txtIsbn.MaxLength = 255;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(198, 20);
            this.txtIsbn.TabIndex = 5;
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.BackColor = System.Drawing.Color.Transparent;
            this.labelIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsbn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIsbn.Location = new System.Drawing.Point(41, 75);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(43, 17);
            this.labelIsbn.TabIndex = 4;
            this.labelIsbn.Text = "ISBN:";
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.BackColor = System.Drawing.Color.Transparent;
            this.labelAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAño.Location = new System.Drawing.Point(41, 124);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(37, 17);
            this.labelAño.TabIndex = 6;
            this.labelAño.Text = "Año:";
            // 
            // numericAño
            // 
            this.numericAño.Location = new System.Drawing.Point(84, 124);
            this.numericAño.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericAño.Name = "numericAño";
            this.numericAño.Size = new System.Drawing.Size(120, 20);
            this.numericAño.TabIndex = 7;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(93, 173);
            this.txtAutor.MaxLength = 255;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(195, 20);
            this.txtAutor.TabIndex = 9;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.BackColor = System.Drawing.Color.Transparent;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAutor.Location = new System.Drawing.Point(41, 173);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(46, 17);
            this.labelAutor.TabIndex = 8;
            this.labelAutor.Text = "Autor:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCategoria.Location = new System.Drawing.Point(41, 221);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(73, 17);
            this.labelCategoria.TabIndex = 10;
            this.labelCategoria.Text = "Categoría:";
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
            this.comboBoxCategoria.Location = new System.Drawing.Point(121, 221);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCategoria.TabIndex = 11;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(105, 269);
            this.txtEdicion.MaxLength = 255;
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(183, 20);
            this.txtEdicion.TabIndex = 13;
            // 
            // labelEdicion
            // 
            this.labelEdicion.AutoSize = true;
            this.labelEdicion.BackColor = System.Drawing.Color.Transparent;
            this.labelEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdicion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEdicion.Location = new System.Drawing.Point(41, 269);
            this.labelEdicion.Name = "labelEdicion";
            this.labelEdicion.Size = new System.Drawing.Size(58, 17);
            this.labelEdicion.TabIndex = 12;
            this.labelEdicion.Text = "Edición:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(184, 316);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // labelPaginas
            // 
            this.labelPaginas.AutoSize = true;
            this.labelPaginas.BackColor = System.Drawing.Color.Transparent;
            this.labelPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaginas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPaginas.Location = new System.Drawing.Point(41, 316);
            this.labelPaginas.Name = "labelPaginas";
            this.labelPaginas.Size = new System.Drawing.Size(137, 17);
            this.labelPaginas.TabIndex = 14;
            this.labelPaginas.Text = "Número de Paginas:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(105, 365);
            this.txtPrecio.MaxLength = 1000000;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(183, 20);
            this.txtPrecio.TabIndex = 17;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrecio.Location = new System.Drawing.Point(41, 365);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(52, 17);
            this.labelPrecio.TabIndex = 16;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelPortada
            // 
            this.labelPortada.AutoSize = true;
            this.labelPortada.BackColor = System.Drawing.Color.Transparent;
            this.labelPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPortada.Location = new System.Drawing.Point(334, 40);
            this.labelPortada.Name = "labelPortada";
            this.labelPortada.Size = new System.Drawing.Size(62, 17);
            this.labelPortada.TabIndex = 18;
            this.labelPortada.Text = "Portada:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(337, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 214);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(145, 419);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(93, 33);
            this.buttonGuardar.TabIndex = 20;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelPdf
            // 
            this.labelPdf.AutoSize = true;
            this.labelPdf.BackColor = System.Drawing.Color.Transparent;
            this.labelPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPdf.Location = new System.Drawing.Point(334, 331);
            this.labelPdf.Name = "labelPdf";
            this.labelPdf.Size = new System.Drawing.Size(75, 17);
            this.labelPdf.TabIndex = 21;
            this.labelPdf.Text = "Libro PDF:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(300, 419);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 33);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscarP
            // 
            this.buttonBuscarP.Location = new System.Drawing.Point(402, 34);
            this.buttonBuscarP.Name = "buttonBuscarP";
            this.buttonBuscarP.Size = new System.Drawing.Size(92, 28);
            this.buttonBuscarP.TabIndex = 25;
            this.buttonBuscarP.Text = "Buscar Portada";
            this.buttonBuscarP.UseVisualStyleBackColor = true;
            this.buttonBuscarP.Click += new System.EventHandler(this.buttonBuscarP_Click);
            // 
            // buttonBuscarL
            // 
            this.buttonBuscarL.Location = new System.Drawing.Point(415, 326);
            this.buttonBuscarL.Name = "buttonBuscarL";
            this.buttonBuscarL.Size = new System.Drawing.Size(84, 27);
            this.buttonBuscarL.TabIndex = 26;
            this.buttonBuscarL.Text = "Buscar Libro";
            this.buttonBuscarL.UseVisualStyleBackColor = true;
            this.buttonBuscarL.Click += new System.EventHandler(this.buttonBuscarL_Click);
            // 
            // AgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 467);
            this.Controls.Add(this.buttonBuscarL);
            this.Controls.Add(this.buttonBuscarP);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelPdf);
            this.Controls.Add(this.buttonGuardar);
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
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.labelIsbn);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Libro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarLibro_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.NumericUpDown numericAño;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label labelEdicion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelPaginas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelPortada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelPdf;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscarP;
        private System.Windows.Forms.Button buttonBuscarL;
    }
}