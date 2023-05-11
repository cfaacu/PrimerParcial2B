namespace Formularios
{
    partial class Form_AltaReparacion
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
            lbl_NumeroSerie = new Label();
            txt_NumeroSerie = new TextBox();
            lbl_Tipo = new Label();
            cmb_Tipo = new ComboBox();
            grp_Cliente = new GroupBox();
            txt_Apellido = new TextBox();
            lbl_Apellido = new Label();
            btn_Buscar = new Button();
            txt_Direccion = new TextBox();
            lbl_Direccion = new Label();
            txt_Telefono = new TextBox();
            lbl_Telefono = new Label();
            txt_Nombre = new TextBox();
            lbl_Nombre = new Label();
            txt_DNI = new TextBox();
            lbl_DNI = new Label();
            txt_Falla = new TextBox();
            lbl_Falla = new Label();
            btn_Crear = new Button();
            grp_Cliente.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_NumeroSerie
            // 
            lbl_NumeroSerie.AutoSize = true;
            lbl_NumeroSerie.Location = new Point(268, 47);
            lbl_NumeroSerie.Name = "lbl_NumeroSerie";
            lbl_NumeroSerie.Size = new Size(96, 15);
            lbl_NumeroSerie.TabIndex = 0;
            lbl_NumeroSerie.Text = "Numero De Serie";
            // 
            // txt_NumeroSerie
            // 
            txt_NumeroSerie.Location = new Point(268, 65);
            txt_NumeroSerie.Name = "txt_NumeroSerie";
            txt_NumeroSerie.Size = new Size(121, 23);
            txt_NumeroSerie.TabIndex = 1;
            // 
            // lbl_Tipo
            // 
            lbl_Tipo.AutoSize = true;
            lbl_Tipo.Location = new Point(268, 111);
            lbl_Tipo.Name = "lbl_Tipo";
            lbl_Tipo.Size = new Size(108, 15);
            lbl_Tipo.TabIndex = 2;
            lbl_Tipo.Text = "Tipo de Reparacion";
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Location = new Point(268, 129);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(121, 23);
            cmb_Tipo.TabIndex = 3;
            // 
            // grp_Cliente
            // 
            grp_Cliente.Controls.Add(txt_Apellido);
            grp_Cliente.Controls.Add(lbl_Apellido);
            grp_Cliente.Controls.Add(btn_Buscar);
            grp_Cliente.Controls.Add(txt_Direccion);
            grp_Cliente.Controls.Add(lbl_Direccion);
            grp_Cliente.Controls.Add(txt_Telefono);
            grp_Cliente.Controls.Add(lbl_Telefono);
            grp_Cliente.Controls.Add(txt_Nombre);
            grp_Cliente.Controls.Add(lbl_Nombre);
            grp_Cliente.Controls.Add(txt_DNI);
            grp_Cliente.Controls.Add(lbl_DNI);
            grp_Cliente.Location = new Point(29, 27);
            grp_Cliente.Name = "grp_Cliente";
            grp_Cliente.Size = new Size(164, 271);
            grp_Cliente.TabIndex = 4;
            grp_Cliente.TabStop = false;
            grp_Cliente.Text = "Datos del cliente";
            // 
            // txt_Apellido
            // 
            txt_Apellido.Enabled = false;
            txt_Apellido.Location = new Point(16, 143);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(100, 23);
            txt_Apellido.TabIndex = 11;
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(16, 124);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 10;
            lbl_Apellido.Text = "Apellido";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(130, 49);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(24, 21);
            btn_Buscar.TabIndex = 9;
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Enabled = false;
            txt_Direccion.Location = new Point(16, 237);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(100, 23);
            txt_Direccion.TabIndex = 8;
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(16, 219);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(57, 15);
            lbl_Direccion.TabIndex = 7;
            lbl_Direccion.Text = "Direccion";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Enabled = false;
            txt_Telefono.Location = new Point(17, 189);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(100, 23);
            txt_Telefono.TabIndex = 6;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(17, 171);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(52, 15);
            lbl_Telefono.TabIndex = 5;
            lbl_Telefono.Text = "Telefono";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Enabled = false;
            txt_Nombre.Location = new Point(17, 98);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 4;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(17, 80);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre";
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(17, 50);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(100, 23);
            txt_DNI.TabIndex = 2;
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Location = new Point(17, 32);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(27, 15);
            lbl_DNI.TabIndex = 1;
            lbl_DNI.Text = "DNI";
            // 
            // txt_Falla
            // 
            txt_Falla.Location = new Point(268, 189);
            txt_Falla.Name = "txt_Falla";
            txt_Falla.Size = new Size(121, 23);
            txt_Falla.TabIndex = 6;
            // 
            // lbl_Falla
            // 
            lbl_Falla.AutoSize = true;
            lbl_Falla.Location = new Point(268, 171);
            lbl_Falla.Name = "lbl_Falla";
            lbl_Falla.Size = new Size(31, 15);
            lbl_Falla.TabIndex = 5;
            lbl_Falla.Text = "Falla";
            // 
            // btn_Crear
            // 
            btn_Crear.Location = new Point(268, 247);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(132, 54);
            btn_Crear.TabIndex = 7;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = true;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // Form_AltaReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 329);
            Controls.Add(btn_Crear);
            Controls.Add(txt_Falla);
            Controls.Add(lbl_Falla);
            Controls.Add(grp_Cliente);
            Controls.Add(cmb_Tipo);
            Controls.Add(lbl_Tipo);
            Controls.Add(txt_NumeroSerie);
            Controls.Add(lbl_NumeroSerie);
            Name = "Form_AltaReparacion";
            Text = "Form_AltaReparacion";
            Load += Form_AltaReparacion_Load;
            grp_Cliente.ResumeLayout(false);
            grp_Cliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_NumeroSerie;
        private TextBox txt_NumeroSerie;
        private Label lbl_Tipo;
        private ComboBox cmb_Tipo;
        private GroupBox grp_Cliente;
        private TextBox txt_Apellido;
        private Label lbl_Apellido;
        private Button btn_Buscar;
        private TextBox txt_Direccion;
        private Label lbl_Direccion;
        private TextBox txt_Telefono;
        private Label lbl_Telefono;
        private TextBox txt_Nombre;
        private Label lbl_Nombre;
        private TextBox txt_DNI;
        private Label lbl_DNI;
        private TextBox txt_Falla;
        private Label lbl_Falla;
        private Button btn_Crear;
    }
}