namespace Formularios
{
    partial class Form_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Clientes));
            btn_Continuar = new Button();
            dtg_Listado = new DataGridView();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            btn_Cerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Listado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // btn_Continuar
            // 
            btn_Continuar.BackColor = Color.White;
            btn_Continuar.BackgroundImageLayout = ImageLayout.None;
            btn_Continuar.FlatAppearance.BorderSize = 0;
            btn_Continuar.ForeColor = Color.SteelBlue;
            btn_Continuar.Location = new Point(28, 27);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(110, 50);
            btn_Continuar.TabIndex = 5;
            btn_Continuar.Text = "AGREGAR";
            btn_Continuar.UseVisualStyleBackColor = false;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // dtg_Listado
            // 
            dtg_Listado.AllowUserToAddRows = false;
            dtg_Listado.AllowUserToDeleteRows = false;
            dtg_Listado.AllowUserToResizeColumns = false;
            dtg_Listado.AllowUserToResizeRows = false;
            dtg_Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Listado.BackgroundColor = Color.SteelBlue;
            dtg_Listado.BorderStyle = BorderStyle.None;
            dtg_Listado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_Listado.ColumnHeadersHeight = 29;
            dtg_Listado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtg_Listado.Columns.AddRange(new DataGridViewColumn[] { Dni, Nombre, Apellido, Direccion, Telefono, Editar, Eliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_Listado.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_Listado.EnableHeadersVisualStyles = false;
            dtg_Listado.GridColor = Color.White;
            dtg_Listado.Location = new Point(28, 126);
            dtg_Listado.Margin = new Padding(3, 4, 3, 4);
            dtg_Listado.Name = "dtg_Listado";
            dtg_Listado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtg_Listado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtg_Listado.RowHeadersVisible = false;
            dtg_Listado.RowHeadersWidth = 51;
            dtg_Listado.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_Listado.RowTemplate.Height = 25;
            dtg_Listado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Listado.Size = new Size(633, 392);
            dtg_Listado.TabIndex = 6;
            dtg_Listado.CellClick += dtg_Listado_CellClick;
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
            // Direccion
            // 
            Direccion.HeaderText = "DIRECCION";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "TELEFONO";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            // 
            // Editar
            // 
            Editar.HeaderText = "EDITAR";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "ELIMINAR";
            Eliminar.Image = Properties.Resources.delete_remove_bin_icon_icons_com_72400;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(685, 1);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(25, 25);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Cerrar.TabIndex = 40;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // Form_Clientes
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(711, 573);
            Controls.Add(btn_Cerrar);
            Controls.Add(dtg_Listado);
            Controls.Add(btn_Continuar);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form_Clientes";
            Text = "Form_Clientes";
            Load += Form_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Listado).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Continuar;
        private DataGridView dtg_Listado;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private PictureBox btn_Cerrar;
    }
}