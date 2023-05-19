namespace Formularios
{
    partial class Form_AMCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AMCliente));
            btn_Buscar = new Button();
            txt_Apellido = new TextBox();
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            txt_Nombre = new TextBox();
            txt_DNI = new TextBox();
            btn_Modificar = new Button();
            btn_Cerrar = new PictureBox();
            lbl_Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.White;
            btn_Buscar.Location = new Point(522, 262);
            btn_Buscar.Margin = new Padding(3, 4, 3, 4);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(27, 31);
            btn_Buscar.TabIndex = 33;
            btn_Buscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.SteelBlue;
            txt_Apellido.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Apellido.ForeColor = Color.White;
            txt_Apellido.Location = new Point(495, 106);
            txt_Apellido.Margin = new Padding(3, 4, 3, 4);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = "APELLIDO";
            txt_Apellido.Size = new Size(185, 34);
            txt_Apellido.TabIndex = 32;
            // 
            // txt_Direccion
            // 
            txt_Direccion.BackColor = Color.SteelBlue;
            txt_Direccion.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Direccion.ForeColor = Color.White;
            txt_Direccion.Location = new Point(271, 178);
            txt_Direccion.Margin = new Padding(3, 4, 3, 4);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.PlaceholderText = "DIRECCION";
            txt_Direccion.Size = new Size(185, 34);
            txt_Direccion.TabIndex = 31;
            // 
            // txt_Telefono
            // 
            txt_Telefono.BackColor = Color.SteelBlue;
            txt_Telefono.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Telefono.ForeColor = Color.White;
            txt_Telefono.Location = new Point(36, 178);
            txt_Telefono.Margin = new Padding(3, 4, 3, 4);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.PlaceholderText = "TELEFONO";
            txt_Telefono.Size = new Size(185, 34);
            txt_Telefono.TabIndex = 30;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SteelBlue;
            txt_Nombre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(273, 106);
            txt_Nombre.Margin = new Padding(3, 4, 3, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "NOMBRE";
            txt_Nombre.Size = new Size(183, 34);
            txt_Nombre.TabIndex = 29;
            // 
            // txt_DNI
            // 
            txt_DNI.BackColor = Color.SteelBlue;
            txt_DNI.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DNI.ForeColor = Color.White;
            txt_DNI.Location = new Point(36, 106);
            txt_DNI.Margin = new Padding(3, 4, 3, 4);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.PlaceholderText = "DNI";
            txt_DNI.ReadOnly = true;
            txt_DNI.Size = new Size(183, 34);
            txt_DNI.TabIndex = 28;
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.White;
            btn_Modificar.FlatAppearance.BorderSize = 0;
            btn_Modificar.FlatStyle = FlatStyle.Flat;
            btn_Modificar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Modificar.ForeColor = Color.SteelBlue;
            btn_Modificar.Location = new Point(495, 167);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(185, 58);
            btn_Modificar.TabIndex = 34;
            btn_Modificar.Text = "MODIFICAR";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(700, 0);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(25, 25);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Cerrar.TabIndex = 35;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Titulo.ForeColor = Color.WhiteSmoke;
            lbl_Titulo.Location = new Point(139, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(462, 69);
            lbl_Titulo.TabIndex = 36;
            lbl_Titulo.Text = "MODIFICAR CLIENTE";
            lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Titulo.Click += label1_Click;
            // 
            // Form_AMCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(726, 261);
            Controls.Add(lbl_Titulo);
            Controls.Add(btn_Cerrar);
            Controls.Add(btn_Modificar);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_DNI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_AMCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_ModificarCliente";
            Load += Form_ModificarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Buscar;
        private TextBox txt_Apellido;
        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
        private TextBox txt_Nombre;
        private TextBox txt_DNI;
        private Button btn_Modificar;
        private PictureBox btn_Cerrar;
        private Label lbl_Titulo;
    }
}