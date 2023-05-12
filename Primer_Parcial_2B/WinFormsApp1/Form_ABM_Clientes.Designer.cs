namespace Formularios
{
    partial class Form_ABM_Clientes
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
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            txt_Nombre = new TextBox();
            txt_DNI = new TextBox();
            btn_Continuar = new Button();
            txt_Apellido = new TextBox();
            btn_Buscar = new Button();
            SuspendLayout();
            // 
            // txt_Direccion
            // 
            txt_Direccion.BackColor = Color.SteelBlue;
            txt_Direccion.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Direccion.ForeColor = Color.White;
            txt_Direccion.Location = new Point(306, 138);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(162, 29);
            txt_Direccion.TabIndex = 16;
            txt_Direccion.Text = "DIRECCION";
            // 
            // txt_Telefono
            // 
            txt_Telefono.BackColor = Color.SteelBlue;
            txt_Telefono.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Telefono.ForeColor = Color.White;
            txt_Telefono.Location = new Point(306, 83);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(162, 29);
            txt_Telefono.TabIndex = 14;
            txt_Telefono.Text = "TELEFONO";
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SteelBlue;
            txt_Nombre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(96, 108);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(161, 29);
            txt_Nombre.TabIndex = 12;
            txt_Nombre.Text = "NOMBRE";
            // 
            // txt_DNI
            // 
            txt_DNI.BackColor = Color.SteelBlue;
            txt_DNI.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DNI.ForeColor = Color.White;
            txt_DNI.Location = new Point(96, 53);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(161, 29);
            txt_DNI.TabIndex = 10;
            txt_DNI.Text = "DNI";
            // 
            // btn_Continuar
            // 
            btn_Continuar.BackColor = Color.White;
            btn_Continuar.FlatAppearance.BorderSize = 0;
            btn_Continuar.FlatStyle = FlatStyle.Flat;
            btn_Continuar.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Continuar.Location = new Point(143, 219);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(291, 46);
            btn_Continuar.TabIndex = 24;
            btn_Continuar.Text = "CONTINUAR";
            btn_Continuar.UseVisualStyleBackColor = false;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.SteelBlue;
            txt_Apellido.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Apellido.ForeColor = Color.White;
            txt_Apellido.Location = new Point(96, 163);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(162, 29);
            txt_Apellido.TabIndex = 26;
            txt_Apellido.Text = "APELLIDO";
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.White;
            btn_Buscar.Location = new Point(269, 55);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(24, 23);
            btn_Buscar.TabIndex = 27;
            btn_Buscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // Form_ABM_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(638, 465);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_Apellido);
            Controls.Add(btn_Continuar);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_DNI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ABM_Clientes";
            Text = "Clientes";
            Load += Form_ABM_Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
        private TextBox txt_Nombre;
        private TextBox txt_DNI;
        private Button btn_Continuar;
        private TextBox txt_Apellido;
        private Button btn_Buscar;
    }
}