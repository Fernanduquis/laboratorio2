
namespace laboratorio2
{
    partial class Form2
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.textBoxKilometros = new System.Windows.Forms.TextBox();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEntrega = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(399, 293);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ir a Reportes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(143, 72);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(100, 20);
            this.textBoxNit.TabIndex = 3;
            // 
            // textBoxKilometros
            // 
            this.textBoxKilometros.Location = new System.Drawing.Point(143, 296);
            this.textBoxKilometros.Name = "textBoxKilometros";
            this.textBoxKilometros.Size = new System.Drawing.Size(100, 20);
            this.textBoxKilometros.TabIndex = 4;
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(143, 114);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlaca.TabIndex = 5;
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Location = new System.Drawing.Point(143, 176);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSalida.TabIndex = 6;
            // 
            // dateTimePickerEntrega
            // 
            this.dateTimePickerEntrega.Location = new System.Drawing.Point(143, 232);
            this.dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            this.dateTimePickerEntrega.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEntrega.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NIT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Klm Recorridos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEntrega);
            this.Controls.Add(this.dateTimePickerSalida);
            this.Controls.Add(this.comboBoxPlaca);
            this.Controls.Add(this.textBoxKilometros);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxKilometros;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}