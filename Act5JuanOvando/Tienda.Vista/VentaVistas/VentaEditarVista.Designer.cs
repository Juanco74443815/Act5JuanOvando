namespace SistemaTienda.VISTA.VentaVistas
{
    partial class VentaEditarVista
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
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HotTrack;
            label6.Font = new Font("Wide Latin", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(116, 19);
            label6.Name = "label6";
            label6.Size = new Size(226, 33);
            label6.TabIndex = 64;
            label6.Text = "EDITAR";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 23);
            dateTimePicker1.TabIndex = 63;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label2.Location = new Point(11, 119);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 61;
            label2.Text = "TOTALVENTA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label1.Location = new Point(11, 86);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 60;
            label1.Text = "FECHAVENTA";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.HotTrack;
            label5.Location = new Point(0, -2);
            label5.Name = "label5";
            label5.Size = new Size(488, 68);
            label5.TabIndex = 65;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(244, 151);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 67;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(94, 151);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 66;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VentaEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 202);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "VentaEditarVista";
            Text = "VentaEditarVista";
            Load += VentaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}