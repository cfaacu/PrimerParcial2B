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
            btn_Ingresar.Location = new Point(375, 269);
            btn_Ingresar.Margin = new Padding(3, 4, 3, 4);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(451, 53);
            btn_Ingresar.TabIndex = 3;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Location = new Point(643, 24);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(59, 20);
            lbl_Usuario.TabIndex = 2;
            lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(631, 144);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(83, 20);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Contraseña";
            // 
            // txt_Usuario
            // 
            txt_Usuario.BackColor = Color.FromArgb(15, 15, 15);
            txt_Usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_Usuario.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Usuario.ForeColor = Color.Gray;
            txt_Usuario.Location = new Point(375, 83);
            txt_Usuario.Margin = new Padding(3, 4, 3, 4);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.PlaceholderText = "USUARIO";
            txt_Usuario.Size = new Size(451, 34);
            txt_Usuario.TabIndex = 1;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.FromArgb(15, 15, 15);
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.ForeColor = Color.Gray;
            txt_Password.Location = new Point(375, 183);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.PlaceholderText = "CONTRASEÑA";
            txt_Password.Size = new Size(451, 34);
            txt_Password.TabIndex = 2;
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
            btn_Admin.Location = new Point(786, 404);
            btn_Admin.Margin = new Padding(3, 4, 3, 4);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(106, 36);
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
            btn_Empleado.Location = new Point(288, 409);
            btn_Empleado.Margin = new Padding(3, 4, 3, 4);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(110, 31);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 440);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 96);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(553, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 46);
            label1.TabIndex = 10;
            label1.Text = "LOGIN";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(871, 0);
            btn_Cerrar.Margin = new Padding(3, 4, 3, 4);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(21, 24);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Cerrar.TabIndex = 11;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(891, 440);
            Controls.Add(btn_Empleado);
            Controls.Add(btn_Admin);
            Controls.Add(btn_Cerrar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txt_Password);
            Controls.Add(txt_Usuario);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Usuario);
            Controls.Add(btn_Ingresar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
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
        private Button btn_Admin;
        private Button btn_Empleado;
        private Panel panel1;
        private Label label1;
        private PictureBox btn_Cerrar;
        private PictureBox pictureBox1;
    }
}