
namespace WindowsBootstrap
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBoxGeneros = new System.Windows.Forms.GroupBox();
            this.radioButtonHombre = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.listBoxDeportes = new System.Windows.Forms.ListBox();
            this.comboBoxFrutas = new System.Windows.Forms.ComboBox();
            this.groupBoxGeneros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe aqui:";
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.textBoxMensaje.Location = new System.Drawing.Point(146, 36);
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(322, 24);
            this.textBoxMensaje.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.buttonShow.Location = new System.Drawing.Point(12, 301);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(456, 47);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Mostrar";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBoxGeneros
            // 
            this.groupBoxGeneros.Controls.Add(this.radioButtonMujer);
            this.groupBoxGeneros.Controls.Add(this.radioButtonHombre);
            this.groupBoxGeneros.Location = new System.Drawing.Point(32, 83);
            this.groupBoxGeneros.Name = "groupBoxGeneros";
            this.groupBoxGeneros.Size = new System.Drawing.Size(142, 84);
            this.groupBoxGeneros.TabIndex = 3;
            this.groupBoxGeneros.TabStop = false;
            // 
            // radioButtonHombre
            // 
            this.radioButtonHombre.AutoSize = true;
            this.radioButtonHombre.Location = new System.Drawing.Point(6, 21);
            this.radioButtonHombre.Name = "radioButtonHombre";
            this.radioButtonHombre.Size = new System.Drawing.Size(79, 21);
            this.radioButtonHombre.TabIndex = 0;
            this.radioButtonHombre.TabStop = true;
            this.radioButtonHombre.Text = "Hombre";
            this.radioButtonHombre.UseVisualStyleBackColor = true;
            this.radioButtonHombre.Click += new System.EventHandler(this.radioButtonHombre_Click);
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(6, 48);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(64, 21);
            this.radioButtonMujer.TabIndex = 1;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            this.radioButtonMujer.Click += new System.EventHandler(this.radioButtonMujer_Click);
            // 
            // listBoxDeportes
            // 
            this.listBoxDeportes.FormattingEnabled = true;
            this.listBoxDeportes.ItemHeight = 16;
            this.listBoxDeportes.Items.AddRange(new object[] {
            "Baloncesto",
            "Basket",
            "Futbol",
            "Soccer"});
            this.listBoxDeportes.Location = new System.Drawing.Point(282, 83);
            this.listBoxDeportes.Name = "listBoxDeportes";
            this.listBoxDeportes.Size = new System.Drawing.Size(166, 84);
            this.listBoxDeportes.TabIndex = 4;
            this.listBoxDeportes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBoxFrutas
            // 
            this.comboBoxFrutas.FormattingEnabled = true;
            this.comboBoxFrutas.Items.AddRange(new object[] {
            "Platano",
            "Manzana",
            "Pera",
            "Melocoton"});
            this.comboBoxFrutas.Location = new System.Drawing.Point(81, 204);
            this.comboBoxFrutas.Name = "comboBoxFrutas";
            this.comboBoxFrutas.Size = new System.Drawing.Size(322, 24);
            this.comboBoxFrutas.TabIndex = 5;
            this.comboBoxFrutas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 360);
            this.Controls.Add(this.comboBoxFrutas);
            this.Controls.Add(this.listBoxDeportes);
            this.Controls.Add(this.groupBoxGeneros);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxMensaje);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Modal molon";
            this.groupBoxGeneros.ResumeLayout(false);
            this.groupBoxGeneros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.GroupBox groupBoxGeneros;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.RadioButton radioButtonHombre;
        private System.Windows.Forms.ListBox listBoxDeportes;
        private System.Windows.Forms.ComboBox comboBoxFrutas;
    }
}

