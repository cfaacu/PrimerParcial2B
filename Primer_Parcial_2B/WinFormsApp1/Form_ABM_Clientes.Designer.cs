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
            lbl_Direccion = new Label();
            txt_Telefono = new TextBox();
            lbl_Telefono = new Label();
            txt_Nombre = new TextBox();
            lbl_Nombre = new Label();
            txt_DNI = new TextBox();
            lbl_DNI = new Label();
            btn_Continuar = new Button();
            txt_Apellido = new TextBox();
            lbl_Apellido = new Label();
            btn_Buscar = new Button();
            SuspendLayout();
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(81, 289);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(100, 23);
            txt_Direccion.TabIndex = 16;
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(81, 271);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(57, 15);
            lbl_Direccion.TabIndex = 15;
            lbl_Direccion.Text = "Direccion";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(82, 221);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(100, 23);
            txt_Telefono.TabIndex = 14;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(82, 203);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(52, 15);
            lbl_Telefono.TabIndex = 13;
            lbl_Telefono.Text = "Telefono";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(82, 121);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 12;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(82, 103);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 11;
            lbl_Nombre.Text = "Nombre";
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(82, 53);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(100, 23);
            txt_DNI.TabIndex = 10;
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Location = new Point(82, 35);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(27, 15);
            lbl_DNI.TabIndex = 9;
            lbl_DNI.Text = "DNI";
            // 
            // btn_Continuar
            // 
            btn_Continuar.Location = new Point(69, 364);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(125, 57);
            btn_Continuar.TabIndex = 24;
            btn_Continuar.Text = "Continuar";
            btn_Continuar.UseVisualStyleBackColor = true;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(81, 169);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(100, 23);
            txt_Apellido.TabIndex = 26;
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(81, 151);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 25;
            lbl_Apellido.Text = "Apellido";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(197, 53);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(24, 23);
            btn_Buscar.TabIndex = 27;
            btn_Buscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // Form_ABM_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 450);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_Apellido);
            Controls.Add(lbl_Apellido);
            Controls.Add(btn_Continuar);
            Controls.Add(txt_Direccion);
            Controls.Add(lbl_Direccion);
            Controls.Add(txt_Telefono);
            Controls.Add(lbl_Telefono);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_DNI);
            Controls.Add(lbl_DNI);
            Name = "Form_ABM_Clientes";
            Text = "Clientes";
            Load += Form_ABM_Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Direccion;
        private Label lbl_Direccion;
        private TextBox txt_Telefono;
        private Label lbl_Telefono;
        private TextBox txt_Nombre;
        private Label lbl_Nombre;
        private TextBox txt_DNI;
        private Label lbl_DNI;
        private Button btn_Continuar;
        private TextBox txt_Apellido;
        private Label lbl_Apellido;
        private Button btn_Buscar;
    }
}