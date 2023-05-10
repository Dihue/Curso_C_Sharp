namespace Ventanas2
{
    partial class mensaje
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
            label1 = new Label();
            tb_id = new TextBox();
            tb_Nombre = new TextBox();
            label2 = new Label();
            tb_direccion = new TextBox();
            label3 = new Label();
            tb_telefono = new TextBox();
            label4 = new Label();
            bt_aceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(210, 27);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(241, 23);
            tb_id.TabIndex = 1;
            // 
            // tb_Nombre
            // 
            tb_Nombre.Location = new Point(210, 69);
            tb_Nombre.Name = "tb_Nombre";
            tb_Nombre.Size = new Size(241, 23);
            tb_Nombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 60);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // tb_direccion
            // 
            tb_direccion.Location = new Point(210, 111);
            tb_direccion.Name = "tb_direccion";
            tb_direccion.Size = new Size(241, 23);
            tb_direccion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 102);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 4;
            label3.Text = "Direccion";
            // 
            // tb_telefono
            // 
            tb_telefono.Location = new Point(210, 153);
            tb_telefono.Name = "tb_telefono";
            tb_telefono.Size = new Size(241, 23);
            tb_telefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 144);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // bt_aceptar
            // 
            bt_aceptar.Location = new Point(376, 205);
            bt_aceptar.Name = "bt_aceptar";
            bt_aceptar.Size = new Size(75, 23);
            bt_aceptar.TabIndex = 8;
            bt_aceptar.Text = "Aceptar";
            bt_aceptar.UseVisualStyleBackColor = true;
            bt_aceptar.Click += bt_aceptar_Click;
            // 
            // mensaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 263);
            Controls.Add(bt_aceptar);
            Controls.Add(tb_telefono);
            Controls.Add(label4);
            Controls.Add(tb_direccion);
            Controls.Add(label3);
            Controls.Add(tb_Nombre);
            Controls.Add(label2);
            Controls.Add(tb_id);
            Controls.Add(label1);
            Name = "mensaje";
            Text = "mensaje";
            Load += mensaje_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_id;
        private TextBox tb_Nombre;
        private Label label2;
        private TextBox tb_direccion;
        private Label label3;
        private TextBox tb_telefono;
        private Label label4;
        private Button bt_aceptar;
    }
}