namespace SistemaTienda.VISTA.ProductoVistas
{
    partial class ProductoInsertarVista
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
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(242, 153);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 83;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(92, 153);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 82;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HotTrack;
            label6.Font = new Font("Wide Latin", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 19);
            label6.Name = "label6";
            label6.Size = new Size(285, 33);
            label6.TabIndex = 80;
            label6.Text = "AGREGAR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label2.Location = new Point(9, 121);
            label2.Name = "label2";
            label2.Size = new Size(110, 16);
            label2.TabIndex = 77;
            label2.Text = "PRECIOUNITARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label1.Location = new Point(9, 88);
            label1.Name = "label1";
            label1.Size = new Size(127, 16);
            label1.TabIndex = 76;
            label1.Text = "NOMBREPRODUCTO";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.HotTrack;
            label5.Location = new Point(-2, 0);
            label5.Name = "label5";
            label5.Size = new Size(488, 68);
            label5.TabIndex = 81;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 84;
            // 
            // ProductoInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 208);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "ProductoInsertarVista";
            Text = "ProductoInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label6;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox2;
    }
}