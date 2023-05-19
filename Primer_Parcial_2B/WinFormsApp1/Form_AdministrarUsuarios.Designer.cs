namespace Formularios
{
    partial class Form_AdministrarUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtg_ListadoUsuarios = new DataGridView();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Admin = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewImageColumn();
            lbl_Titulo = new Label();
            btn_Continuar = new Button();
            txt_Apellido = new TextBox();
            txt_Password = new TextBox();
            txt_Usuario = new TextBox();
            txt_Nombre = new TextBox();
            txt_DNI = new TextBox();
            chk_Admin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtg_ListadoUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dtg_ListadoUsuarios
            // 
            dtg_ListadoUsuarios.AllowUserToAddRows = false;
            dtg_ListadoUsuarios.AllowUserToDeleteRows = false;
            dtg_ListadoUsuarios.AllowUserToResizeColumns = false;
            dtg_ListadoUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dtg_ListadoUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtg_ListadoUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ListadoUsuarios.BackgroundColor = Color.SteelBlue;
            dtg_ListadoUsuarios.BorderStyle = BorderStyle.None;
            dtg_ListadoUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_ListadoUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtg_ListadoUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg_ListadoUsuarios.ColumnHeadersHeight = 29;
            dtg_ListadoUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtg_ListadoUsuarios.Columns.AddRange(new DataGridViewColumn[] { Dni, Nombre, Apellido, Usuario, Admin, Modificar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtg_ListadoUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dtg_ListadoUsuarios.EnableHeadersVisualStyles = false;
            dtg_ListadoUsuarios.GridColor = Color.White;
            dtg_ListadoUsuarios.Location = new Point(84, 84);
            dtg_ListadoUsuarios.Margin = new Padding(3, 4, 3, 4);
            dtg_ListadoUsuarios.Name = "dtg_ListadoUsuarios";
            dtg_ListadoUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtg_ListadoUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtg_ListadoUsuarios.RowHeadersVisible = false;
            dtg_ListadoUsuarios.RowHeadersWidth = 51;
            dtg_ListadoUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_ListadoUsuarios.RowTemplate.Height = 25;
            dtg_ListadoUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListadoUsuarios.Size = new Size(738, 314);
            dtg_ListadoUsuarios.TabIndex = 9;
            dtg_ListadoUsuarios.CellClick += dtg_ListadoUsuarios_CellClick;
            // 
            // Dni
            // 
            Dni.HeaderText = "DNI";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "NOMBRE";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "APELLIDO";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "USUARIO";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            // 
            // Admin
            // 
            Admin.HeaderText = "ES ADMIN";
            Admin.MinimumWidth = 6;
            Admin.Name = "Admin";
            // 
            // Modificar
            // 
            Modificar.HeaderText = "MODIFICAR";
            Modificar.Image = Properties.Resources.edit_pencil_paper_modify_write_icon_141958;
            Modificar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Modificar.MinimumWidth = 6;
            Modificar.Name = "Modificar";
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(166, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(562, 62);
            lbl_Titulo.TabIndex = 10;
            lbl_Titulo.Text = "ADMINISTRAR USUARIOS";
            // 
            // btn_Continuar
            // 
            btn_Continuar.BackColor = Color.White;
            btn_Continuar.FlatAppearance.BorderSize = 0;
            btn_Continuar.FlatStyle = FlatStyle.Flat;
            btn_Continuar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Continuar.ForeColor = Color.SteelBlue;
            btn_Continuar.Location = new Point(665, 490);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(185, 58);
            btn_Continuar.TabIndex = 40;
            btn_Continuar.Text = "CONTINUAR";
            btn_Continuar.UseVisualStyleBackColor = false;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.SteelBlue;
            txt_Apellido.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Apellido.ForeColor = Color.White;
            txt_Apellido.Location = new Point(527, 430);
            txt_Apellido.Margin = new Padding(3, 4, 3, 4);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = "APELLIDO";
            txt_Apellido.Size = new Size(185, 34);
            txt_Apellido.TabIndex = 39;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.SteelBlue;
            txt_Password.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.ForeColor = Color.White;
            txt_Password.Location = new Point(303, 502);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "CONTRASEÑA";
            txt_Password.Size = new Size(185, 34);
            txt_Password.TabIndex = 38;
            // 
            // txt_Usuario
            // 
            txt_Usuario.BackColor = Color.SteelBlue;
            txt_Usuario.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Usuario.ForeColor = Color.White;
            txt_Usuario.Location = new Point(68, 502);
            txt_Usuario.Margin = new Padding(3, 4, 3, 4);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.PlaceholderText = "USUARIO";
            txt_Usuario.Size = new Size(185, 34);
            txt_Usuario.TabIndex = 37;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SteelBlue;
            txt_Nombre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(305, 430);
            txt_Nombre.Margin = new Padding(3, 4, 3, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "NOMBRE";
            txt_Nombre.Size = new Size(183, 34);
            txt_Nombre.TabIndex = 36;
            // 
            // txt_DNI
            // 
            txt_DNI.BackColor = Color.SteelBlue;
            txt_DNI.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DNI.ForeColor = Color.White;
            txt_DNI.Location = new Point(68, 430);
            txt_DNI.Margin = new Padding(3, 4, 3, 4);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.PlaceholderText = "DNI";
            txt_DNI.Size = new Size(183, 34);
            txt_DNI.TabIndex = 35;
            // 
            // chk_Admin
            // 
            chk_Admin.AutoSize = true;
            chk_Admin.ForeColor = Color.DimGray;
            chk_Admin.Location = new Point(527, 504);
            chk_Admin.Name = "chk_Admin";
            chk_Admin.Size = new Size(99, 32);
            chk_Admin.TabIndex = 41;
            chk_Admin.Text = "ADMIN";
            chk_Admin.UseVisualStyleBackColor = true;
            // 
            // Form_AdministrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(883, 601);
            Controls.Add(chk_Admin);
            Controls.Add(btn_Continuar);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Password);
            Controls.Add(txt_Usuario);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_DNI);
            Controls.Add(lbl_Titulo);
            Controls.Add(dtg_ListadoUsuarios);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Form_AdministrarUsuarios";
            Text = "Administrar Usuarios";
            Load += Form_AdministrarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_ListadoUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_ListadoUsuarios;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Admin;
        private DataGridViewImageColumn Modificar;
        private Label lbl_Titulo;
        private Button btn_Continuar;
        private TextBox txt_Apellido;
        private TextBox txt_Password;
        private TextBox txt_Usuario;
        private TextBox txt_Nombre;
        private TextBox txt_DNI;
        private CheckBox chk_Admin;
    }
}