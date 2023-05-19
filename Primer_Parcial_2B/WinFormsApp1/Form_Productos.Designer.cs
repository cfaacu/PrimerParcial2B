namespace Formularios
{
    partial class Form_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Productos));
            btn_Agregar = new Button();
            dtg_ListadoProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            btn_Cerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtg_ListadoProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.White;
            btn_Agregar.BackgroundImageLayout = ImageLayout.None;
            btn_Agregar.FlatAppearance.BorderSize = 0;
            btn_Agregar.ForeColor = Color.SteelBlue;
            btn_Agregar.Location = new Point(39, 41);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(110, 50);
            btn_Agregar.TabIndex = 7;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // dtg_ListadoProductos
            // 
            dtg_ListadoProductos.AllowUserToAddRows = false;
            dtg_ListadoProductos.AllowUserToDeleteRows = false;
            dtg_ListadoProductos.AllowUserToResizeColumns = false;
            dtg_ListadoProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dtg_ListadoProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtg_ListadoProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ListadoProductos.BackgroundColor = Color.SteelBlue;
            dtg_ListadoProductos.BorderStyle = BorderStyle.None;
            dtg_ListadoProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_ListadoProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtg_ListadoProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg_ListadoProductos.ColumnHeadersHeight = 29;
            dtg_ListadoProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtg_ListadoProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Categoria, Cantidad, PrecioVenta, PrecioCompra, Modificar, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtg_ListadoProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dtg_ListadoProductos.EnableHeadersVisualStyles = false;
            dtg_ListadoProductos.GridColor = Color.White;
            dtg_ListadoProductos.Location = new Point(12, 117);
            dtg_ListadoProductos.Margin = new Padding(3, 4, 3, 4);
            dtg_ListadoProductos.Name = "dtg_ListadoProductos";
            dtg_ListadoProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtg_ListadoProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtg_ListadoProductos.RowHeadersVisible = false;
            dtg_ListadoProductos.RowHeadersWidth = 51;
            dtg_ListadoProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_ListadoProductos.RowTemplate.Height = 25;
            dtg_ListadoProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListadoProductos.Size = new Size(738, 429);
            dtg_ListadoProductos.TabIndex = 8;
            dtg_ListadoProductos.CellClick += dtg_ListadoProductos_CellClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "CODIGO";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "NOMBRE";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "CATEGORIA";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "CANTIDAD";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "P. VENTA";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "P. COMPRA";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            // 
            // Modificar
            // 
            Modificar.HeaderText = "MODIFICAR";
            Modificar.Image = Properties.Resources.edit_pencil_paper_modify_write_icon_141958;
            Modificar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Modificar.MinimumWidth = 6;
            Modificar.Name = "Modificar";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "ELIMINAR";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(752, 0);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(25, 25);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Cerrar.TabIndex = 41;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // Form_Productos
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(778, 573);
            Controls.Add(btn_Cerrar);
            Controls.Add(dtg_ListadoProductos);
            Controls.Add(btn_Agregar);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form_Productos";
            Text = "Form_Productos";
            Load += Form_Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_ListadoProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private Button btn_Agregar;
        private DataGridView dtg_ListadoProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewImageColumn Modificar;
        private DataGridViewImageColumn Eliminar;
        private PictureBox btn_Cerrar;
    }
}