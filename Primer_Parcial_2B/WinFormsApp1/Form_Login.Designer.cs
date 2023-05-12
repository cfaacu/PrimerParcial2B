namespace Formularios
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            btn_Ingresar = new Button();
            lbl_Usuario = new Label();
            lbl_Password = new Label();
            txt_Usuario = new TextBox();
            txt_Password = new TextBox();
            btn_Registrarse = new Button();
            btn_Admin = new Button();
            btn_Empleado = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_Cerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.FromArgb(40, 40, 40);
            btn_Ingresar.FlatAppearance.BorderSize = 0;
            btn_Ingresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_Ingresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_Ingresar.FlatStyle = FlatStyle.Flat;
            btn_Ingresar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = Color.LightGray;
            btn_Ingresar.Location = new Point(328, 202);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(395, 40);
            btn_Ingresar.TabIndex = 3;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Location = new Point(563, 18);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(47, 15);
            lbl_Usuario.TabIndex = 2;
            lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(552, 108);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(67, 15);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Contraseña";
            // 
            // txt_Usuario
            // 
            txt_Usuario.BackColor = Color.FromArgb(15, 15, 15);
            txt_Usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_Usuario.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Usuario.ForeColor = Color.Gray;
            txt_Usuario.Location = new Point(328, 62);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(395, 29);
            txt_Usuario.TabIndex = 1;
            txt_Usuario.Text = "USUARIO";
            txt_Usuario.Enter += txt_Usuario_Enter;
            txt_Usuario.Leave += txt_Usuario_Leave;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.FromArgb(15, 15, 15);
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.ForeColor = Color.Gray;
            txt_Password.Location = new Point(328, 137);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(395, 29);
            txt_Password.TabIndex = 2;
            txt_Password.Text = "CONTRASEÑA";
            txt_Password.Enter += txt_Password_Enter;
            txt_Password.Leave += txt_Password_Leave;
            // 
            // btn_Registrarse
            // 
            btn_Registrarse.BackColor = Color.FromArgb(40, 40, 40);
            btn_Registrarse.FlatAppearance.BorderSize = 0;
            btn_Registrarse.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_Registrarse.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_Registrarse.FlatStyle = FlatStyle.Flat;
            btn_Registrarse.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Registrarse.ForeColor = Color.LightGray;
            btn_Registrarse.Location = new Point(455, 253);
            btn_Registrarse.Name = "btn_Registrarse";
            btn_Registrarse.Size = new Size(138, 40);
            btn_Registrarse.TabIndex = 0;
            btn_Registrarse.Text = "REGISTRARSE";
            btn_Registrarse.UseVisualStyleBackColor = false;
            btn_Registrarse.Click += btn_Registrarse_Click;
            // 
            // btn_Admin
            // 
            btn_Admin.BackColor = Color.FromArgb(40, 40, 40);
            btn_Admin.FlatAppearance.BorderSize = 0;
            btn_Admin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_Admin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_Admin.FlatStyle = FlatStyle.Flat;
            btn_Admin.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Admin.ForeColor = Color.LightGray;
            btn_Admin.Location = new Point(698, 303);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(82, 27);
            btn_Admin.TabIndex = 5;
            btn_Admin.Text = "ADMIN";
            btn_Admin.UseVisualStyleBackColor = false;
            btn_Admin.Click += btn_Admin_Click;
            // 
            // btn_Empleado
            // 
            btn_Empleado.BackColor = Color.FromArgb(40, 40, 40);
            btn_Empleado.FlatAppearance.BorderSize = 0;
            btn_Empleado.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_Empleado.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_Empleado.FlatStyle = FlatStyle.Flat;
            btn_Empleado.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Empleado.ForeColor = Color.LightGray;
            btn_Empleado.Location = new Point(252, 307);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(87, 23);
            btn_Empleado.TabIndex = 4;
            btn_Empleado.Text = "EMPLEADO";
            btn_Empleado.UseVisualStyleBackColor = false;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(484, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 37);
            label1.TabIndex = 10;
            label1.Text = "LOGIN";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(762, 0);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(18, 18);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Cerrar.TabIndex = 11;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btn_Empleado);
            Controls.Add(btn_Admin);
            Controls.Add(btn_Cerrar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_Registrarse);
            Controls.Add(txt_Password);
            Controls.Add(txt_Usuario);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Usuario);
            Controls.Add(btn_Ingresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            Load += Form_Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Ingresar;
        private Label lbl_Usuario;
        private Label lbl_Password;
        private TextBox txt_Usuario;
        private TextBox txt_Password;
        private Button btn_Registrarse;
        private Button btn_Admin;
        private Button btn_Empleado;
        private Panel panel1;
        private Label label1;
        private PictureBox btn_Cerrar;
        private PictureBox pictureBox1;
    }
}