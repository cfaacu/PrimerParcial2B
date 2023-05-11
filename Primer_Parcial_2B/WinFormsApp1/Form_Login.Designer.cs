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
            btn_Ingresar = new Button();
            lbl_Usuario = new Label();
            lbl_Password = new Label();
            txt_Usuario = new TextBox();
            txt_Password = new TextBox();
            btn_Registrarse = new Button();
            btn_Admin = new Button();
            btn_Empleado = new Button();
            SuspendLayout();
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(52, 345);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(187, 74);
            btn_Ingresar.TabIndex = 0;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Location = new Point(119, 55);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(47, 15);
            lbl_Usuario.TabIndex = 2;
            lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(108, 145);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(67, 15);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Contraseña";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(91, 84);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(100, 23);
            txt_Usuario.TabIndex = 4;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(91, 174);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(100, 23);
            txt_Password.TabIndex = 5;
            // 
            // btn_Registrarse
            // 
            btn_Registrarse.Location = new Point(103, 232);
            btn_Registrarse.Name = "btn_Registrarse";
            btn_Registrarse.Size = new Size(75, 23);
            btn_Registrarse.TabIndex = 6;
            btn_Registrarse.Text = "Registrarse";
            btn_Registrarse.UseVisualStyleBackColor = true;
            btn_Registrarse.Click += btn_Registrarse_Click;
            // 
            // btn_Admin
            // 
            btn_Admin.Location = new Point(318, 124);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(75, 23);
            btn_Admin.TabIndex = 7;
            btn_Admin.Text = "Admin";
            btn_Admin.UseVisualStyleBackColor = true;
            btn_Admin.Click += btn_Admin_Click;
            // 
            // btn_Empleado
            // 
            btn_Empleado.Location = new Point(318, 174);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(75, 23);
            btn_Empleado.TabIndex = 8;
            btn_Empleado.Text = "Empleado";
            btn_Empleado.UseVisualStyleBackColor = true;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 450);
            Controls.Add(btn_Empleado);
            Controls.Add(btn_Admin);
            Controls.Add(btn_Registrarse);
            Controls.Add(txt_Password);
            Controls.Add(txt_Usuario);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Usuario);
            Controls.Add(btn_Ingresar);
            Name = "Form_Login";
            Text = "Log In";
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
    }
}