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
            txt_NumeroSerie = new TextBox();
            lbl_Tipo = new Label();
            cmb_Tipo = new ComboBox();
            grp_Cliente = new GroupBox();
            txt_Apellido = new TextBox();
            btn_Buscar = new Button();
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            txt_Nombre = new TextBox();
            txt_DNI = new TextBox();
            txt_Falla = new TextBox();
            btn_Crear = new Button();
            grp_Cliente.SuspendLayout();
            SuspendLayout();
            // 
            // txt_NumeroSerie
            // 
            txt_NumeroSerie.BackColor = Color.SteelBlue;
            txt_NumeroSerie.ForeColor = Color.White;
            txt_NumeroSerie.Location = new Point(345, 91);
            txt_NumeroSerie.Margin = new Padding(4, 4, 4, 4);
            txt_NumeroSerie.Name = "txt_NumeroSerie";
            txt_NumeroSerie.Size = new Size(154, 29);
            txt_NumeroSerie.TabIndex = 1;
            txt_NumeroSerie.Text = "NUMERO DE SERIE";
            // 
            // lbl_Tipo
            // 
            lbl_Tipo.AutoSize = true;
            lbl_Tipo.Location = new Point(345, 155);
            lbl_Tipo.Margin = new Padding(4, 0, 4, 0);
            lbl_Tipo.Name = "lbl_Tipo";
            lbl_Tipo.Size = new Size(143, 21);
            lbl_Tipo.TabIndex = 2;
            lbl_Tipo.Text = "Tipo de Reparacion";
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.BackColor = Color.SteelBlue;
            cmb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Tipo.ForeColor = Color.White;
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Location = new Point(345, 181);
            cmb_Tipo.Margin = new Padding(4, 4, 4, 4);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(154, 29);
            cmb_Tipo.TabIndex = 3;
            // 
            // grp_Cliente
            // 
            grp_Cliente.Controls.Add(txt_Apellido);
            grp_Cliente.Controls.Add(btn_Buscar);
            grp_Cliente.Controls.Add(txt_Direccion);
            grp_Cliente.Controls.Add(txt_Telefono);
            grp_Cliente.Controls.Add(txt_Nombre);
            grp_Cliente.Controls.Add(txt_DNI);
            grp_Cliente.ForeColor = Color.White;
            grp_Cliente.Location = new Point(37, 38);
            grp_Cliente.Margin = new Padding(4, 4, 4, 4);
            grp_Cliente.Name = "grp_Cliente";
            grp_Cliente.Padding = new Padding(4, 4, 4, 4);
            grp_Cliente.Size = new Size(211, 379);
            grp_Cliente.TabIndex = 4;
            grp_Cliente.TabStop = false;
            grp_Cliente.Text = "Datos del cliente";
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.SteelBlue;
            txt_Apellido.Enabled = false;
            txt_Apellido.ForeColor = Color.White;
            txt_Apellido.Location = new Point(21, 200);
            txt_Apellido.Margin = new Padding(4, 4, 4, 4);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(127, 29);
            txt_Apellido.TabIndex = 11;
            txt_Apellido.Text = "APELLIDO";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(167, 69);
            btn_Buscar.Margin = new Padding(4, 4, 4, 4);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(31, 29);
            btn_Buscar.TabIndex = 9;
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txt_Direccion
            // 
            txt_Direccion.BackColor = Color.SteelBlue;
            txt_Direccion.Enabled = false;
            txt_Direccion.ForeColor = Color.White;
            txt_Direccion.Location = new Point(21, 332);
            txt_Direccion.Margin = new Padding(4, 4, 4, 4);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(127, 29);
            txt_Direccion.TabIndex = 8;
            txt_Direccion.Text = "DIRECCION";
            // 
            // txt_Telefono
            // 
            txt_Telefono.BackColor = Color.SteelBlue;
            txt_Telefono.Enabled = false;
            txt_Telefono.ForeColor = Color.White;
            txt_Telefono.Location = new Point(22, 265);
            txt_Telefono.Margin = new Padding(4, 4, 4, 4);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(127, 29);
            txt_Telefono.TabIndex = 6;
            txt_Telefono.Text = "TELEFONO";
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SteelBlue;
            txt_Nombre.Enabled = false;
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(22, 137);
            txt_Nombre.Margin = new Padding(4, 4, 4, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(127, 29);
            txt_Nombre.TabIndex = 4;
            txt_Nombre.Text = "NOMBRE";
            // 
            // txt_DNI
            // 
            txt_DNI.BackColor = Color.SteelBlue;
            txt_DNI.ForeColor = Color.White;
            txt_DNI.Location = new Point(22, 70);
            txt_DNI.Margin = new Padding(4, 4, 4, 4);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(127, 29);
            txt_DNI.TabIndex = 2;
            txt_DNI.Text = "DNI";
            // 
            // txt_Falla
            // 
            txt_Falla.BackColor = Color.SteelBlue;
            txt_Falla.ForeColor = Color.White;
            txt_Falla.Location = new Point(345, 265);
            txt_Falla.Margin = new Padding(4, 4, 4, 4);
            txt_Falla.Name = "txt_Falla";
            txt_Falla.Size = new Size(154, 29);
            txt_Falla.TabIndex = 6;
            txt_Falla.Text = "FALLA";
            // 
            // btn_Crear
            // 
            btn_Crear.BackColor = Color.White;
            btn_Crear.FlatStyle = FlatStyle.Flat;
            btn_Crear.ForeColor = Color.SteelBlue;
            btn_Crear.Location = new Point(336, 323);
            btn_Crear.Margin = new Padding(4, 4, 4, 4);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(170, 76);
            btn_Crear.TabIndex = 7;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // Form_AltaReparacion
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(859, 696);
            Controls.Add(btn_Crear);
            Controls.Add(txt_Falla);
            Controls.Add(grp_Cliente);
            Controls.Add(cmb_Tipo);
            Controls.Add(lbl_Tipo);
            Controls.Add(txt_NumeroSerie);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form_AltaReparacion";
            Text = "Form_AltaReparacion";
            Load += Form_AltaReparacion_Load;
            grp_Cliente.ResumeLayout(false);
            grp_Cliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_NumeroSerie;
        private Label lbl_Tipo;
        private ComboBox cmb_Tipo;
        private GroupBox grp_Cliente;
        private TextBox txt_Apellido;
        private Button btn_Buscar;
        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
        private TextBox txt_Nombre;
        private TextBox txt_DNI;
        private TextBox txt_Falla;
        private Button btn_Crear;
    }
}