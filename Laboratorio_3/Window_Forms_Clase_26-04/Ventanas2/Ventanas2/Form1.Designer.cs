namespace Ventanas2
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
            BTN_Nuevo = new Button();
            label1 = new Label();
            TB_name = new TextBox();
            panel1 = new Panel();
            bt_borrar = new Button();
            bt_Modificar = new Button();
            bt_Buscar = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Nuevo
            // 
            BTN_Nuevo.Location = new Point(326, 33);
            BTN_Nuevo.Name = "BTN_Nuevo";
            BTN_Nuevo.Size = new Size(75, 23);
            BTN_Nuevo.TabIndex = 0;
            BTN_Nuevo.Text = "Nuevo";
            BTN_Nuevo.UseVisualStyleBackColor = true;
            BTN_Nuevo.Click += BTN_Nuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // TB_name
            // 
            TB_name.Location = new Point(104, 35);
            TB_name.Name = "TB_name";
            TB_name.Size = new Size(100, 23);
            TB_name.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(bt_borrar);
            panel1.Controls.Add(bt_Modificar);
            panel1.Controls.Add(bt_Buscar);
            panel1.Controls.Add(TB_name);
            panel1.Controls.Add(BTN_Nuevo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 3;
            // 
            // bt_borrar
            // 
            bt_borrar.Location = new Point(495, 32);
            bt_borrar.Name = "bt_borrar";
            bt_borrar.Size = new Size(75, 23);
            bt_borrar.TabIndex = 5;
            bt_borrar.Text = "Borrar";
            bt_borrar.UseVisualStyleBackColor = true;
            bt_borrar.Click += bt_borrar_Click;
            // 
            // bt_Modificar
            // 
            bt_Modificar.Location = new Point(414, 32);
            bt_Modificar.Name = "bt_Modificar";
            bt_Modificar.Size = new Size(75, 23);
            bt_Modificar.TabIndex = 4;
            bt_Modificar.Text = "Modificar";
            bt_Modificar.UseVisualStyleBackColor = true;
            bt_Modificar.Click += bt_Modificar_Click;
            // 
            // bt_Buscar
            // 
            bt_Buscar.Location = new Point(211, 32);
            bt_Buscar.Name = "bt_Buscar";
            bt_Buscar.Size = new Size(75, 23);
            bt_Buscar.TabIndex = 3;
            bt_Buscar.Text = "Buscar";
            bt_Buscar.UseVisualStyleBackColor = true;
            bt_Buscar.Click += bt_Buscar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 386);
            panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 386);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Inicio";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_Nuevo;
        private Label label1;
        private TextBox TB_name;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button bt_Buscar;
        private Button bt_borrar;
        private Button bt_Modificar;
    }
}