namespace SistemaTienda.VISTA.DetalleVentaVistas
{
    partial class DetalleVentaInsertarVista
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(387, 103);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(110, 22);
            button4.TabIndex = 77;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(387, 58);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(110, 22);
            button3.TabIndex = 76;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(245, 287);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 75;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(95, 287);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 74;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 237);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(282, 23);
            textBox5.TabIndex = 71;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(99, 193);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 23);
            textBox4.TabIndex = 70;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 147);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 23);
            textBox3.TabIndex = 69;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 103);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 23);
            textBox2.TabIndex = 68;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 57);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 245);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 66;
            label5.Text = "TOTALDETALLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 200);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 65;
            label4.Text = "PRECIOUNITARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 155);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 64;
            label3.Text = "CANTIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 110);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 63;
            label2.Text = "IDPRODUCTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 65);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 62;
            label1.Text = "IDVENTA";
            // 
            // DetalleVentaInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 353);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleVentaInsertarVista";
            Text = "DetalleVentaInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}