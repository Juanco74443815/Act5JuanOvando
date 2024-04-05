namespace SistemaTienda.VISTA.DetalleVentaVistas
{
    partial class DetalleVentaListarVista
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
            button1 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(345, 20);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 25);
            button1.TabIndex = 43;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Wide Latin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 69);
            label2.Name = "label2";
            label2.Size = new Size(551, 26);
            label2.TabIndex = 42;
            label2.Text = "LISTA DE DETALLEVENTA";
            // 
            // button3
            // 
            button3.Location = new Point(121, 20);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(106, 22);
            button3.TabIndex = 40;
            button3.Text = "EDITAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(233, 20);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(106, 22);
            button4.TabIndex = 39;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(9, 20);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(106, 22);
            button2.TabIndex = 38;
            button2.Text = "AGREGAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(676, 60);
            label1.TabIndex = 41;
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 112);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(502, 320);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DetalleVentaListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(679, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DetalleVentaListarVista";
            Text = "DetalleVentaListarVista";
            Load += DetalleVentaListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}