namespace GeometriaDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnConfirmarRegistro = new Button();
            btnLimpiar = new Button();
            tbArea = new TextBox();
            tbRadio = new TextBox();
            tbAlto = new TextBox();
            tbAncho = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Anncho = new Label();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            lvwFiguras = new ListView();
            btnEliminar = new Button();
            btnActualizar = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmarRegistro);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(tbAlto);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Anncho);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(671, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la figura";
            // 
            // btnConfirmarRegistro
            // 
            btnConfirmarRegistro.Location = new Point(521, 125);
            btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            btnConfirmarRegistro.Size = new Size(124, 49);
            btnConfirmarRegistro.TabIndex = 10;
            btnConfirmarRegistro.Text = "Confirmar Registro ";
            btnConfirmarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(521, 59);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(124, 49);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(309, 147);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(125, 27);
            tbArea.TabIndex = 8;
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(309, 114);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(125, 27);
            tbRadio.TabIndex = 7;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(309, 81);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(125, 27);
            tbAlto.TabIndex = 6;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(309, 48);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(125, 27);
            tbAncho.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 150);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 4;
            label4.Text = "Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 117);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 84);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "Alto";
            // 
            // Anncho
            // 
            Anncho.AutoSize = true;
            Anncho.Location = new Point(231, 51);
            Anncho.Name = "Anncho";
            Anncho.Size = new Size(51, 20);
            Anncho.TabIndex = 1;
            Anncho.Text = "Ancho";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(26, 47);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(139, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tipos de figura";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 78);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Circulo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Rectangulo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvwFiguras);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnActualizar);
            groupBox2.Location = new Point(12, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(671, 261);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de figuras";
            // 
            // lvwFiguras
            // 
            lvwFiguras.Location = new Point(6, 26);
            lvwFiguras.Name = "lvwFiguras";
            lvwFiguras.Size = new Size(517, 229);
            lvwFiguras.TabIndex = 3;
            lvwFiguras.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(529, 148);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 59);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar registro ";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(529, 53);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(116, 59);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar Listado ";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 534);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Anncho;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox tbArea;
        private TextBox tbRadio;
        private TextBox tbAlto;
        private TextBox tbAncho;
        private Button btnConfirmarRegistro;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private ListView lvwFiguras;
    }
}
