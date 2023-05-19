namespace Formularios
{
    partial class Form_Ventas
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
            btn_Confirmar = new Button();
            txt_DNI = new TextBox();
            lbl_Total = new Label();
            txt_Codigo = new TextBox();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            txt_Cantidad = new TextBox();
            btn_Agregar = new Button();
            dtg_Productos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Lbl_PrecioTotal = new Label();
            btn_Buscar = new Button();
            txt_Nombre = new TextBox();
            btn_Listar = new Button();
            btn_ListarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_Productos).BeginInit();
            SuspendLayout();
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.White;
            btn_Confirmar.FlatAppearance.BorderSize = 0;
            btn_Confirmar.FlatStyle = FlatStyle.Flat;
            btn_Confirmar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Confirmar.ForeColor = Color.SteelBlue;
            btn_Confirmar.Location = new Point(373, 375);
            btn_Confirmar.Margin = new Padding(3, 4, 3, 4);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(143, 71);
            btn_Confirmar.TabIndex = 0;
            btn_Confirmar.Text = "CONFIRMAR";
            btn_Confirmar.UseVisualStyleBackColor = false;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // txt_DNI
            // 
            txt_DNI.BackColor = Color.SteelBlue;
            txt_DNI.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DNI.ForeColor = Color.White;
            txt_DNI.Location = new Point(24, 23);
            txt_DNI.Margin = new Padding(3, 4, 3, 4);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.PlaceholderText = "DNI";
            txt_DNI.Size = new Size(114, 34);
            txt_DNI.TabIndex = 2;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Total.ForeColor = Color.White;
            lbl_Total.Location = new Point(57, 375);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(81, 41);
            lbl_Total.TabIndex = 3;
            lbl_Total.Text = "Total";
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = Color.SteelBlue;
            txt_Codigo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Codigo.ForeColor = Color.White;
            txt_Codigo.Location = new Point(24, 73);
            txt_Codigo.Margin = new Padding(3, 4, 3, 4);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.PlaceholderText = "CODIGO";
            txt_Codigo.Size = new Size(114, 34);
            txt_Codigo.TabIndex = 7;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Column1";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Column1";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.BackColor = Color.SteelBlue;
            txt_Cantidad.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Cantidad.ForeColor = Color.White;
            txt_Cantidad.Location = new Point(157, 73);
            txt_Cantidad.Margin = new Padding(3, 4, 3, 4);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.PlaceholderText = "CANTIDAD";
            txt_Cantidad.Size = new Size(114, 34);
            txt_Cantidad.TabIndex = 9;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.White;
            btn_Agregar.FlatAppearance.BorderSize = 0;
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Agregar.ForeColor = Color.SteelBlue;
            btn_Agregar.Location = new Point(297, 70);
            btn_Agregar.Margin = new Padding(3, 4, 3, 4);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(119, 40);
            btn_Agregar.TabIndex = 10;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // dtg_Productos
            // 
            dtg_Productos.AllowUserToAddRows = false;
            dtg_Productos.AllowUserToDeleteRows = false;
            dtg_Productos.AllowUserToResizeColumns = false;
            dtg_Productos.AllowUserToResizeRows = false;
            dtg_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Productos.BackgroundColor = Color.SteelBlue;
            dtg_Productos.BorderStyle = BorderStyle.None;
            dtg_Productos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_Productos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_Productos.ColumnHeadersHeight = 29;
            dtg_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtg_Productos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Cantidad, PrecioVenta });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_Productos.EnableHeadersVisualStyles = false;
            dtg_Productos.GridColor = Color.White;
            dtg_Productos.Location = new Point(12, 132);
            dtg_Productos.Margin = new Padding(3, 4, 3, 4);
            dtg_Productos.Name = "dtg_Productos";
            dtg_Productos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtg_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtg_Productos.RowHeadersVisible = false;
            dtg_Productos.RowHeadersWidth = 51;
            dtg_Productos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_Productos.RowTemplate.Height = 25;
            dtg_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Productos.Size = new Size(563, 239);
            dtg_Productos.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "CODIGO";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "CANTIDAD";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PRECIO VENTA";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Lbl_PrecioTotal
            // 
            Lbl_PrecioTotal.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_PrecioTotal.ForeColor = Color.White;
            Lbl_PrecioTotal.Location = new Point(38, 416);
            Lbl_PrecioTotal.Name = "Lbl_PrecioTotal";
            Lbl_PrecioTotal.Size = new Size(131, 40);
            Lbl_PrecioTotal.TabIndex = 12;
            Lbl_PrecioTotal.Text = "$";
            Lbl_PrecioTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.White;
            btn_Buscar.FlatAppearance.BorderSize = 0;
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Buscar.ForeColor = Color.SteelBlue;
            btn_Buscar.Location = new Point(297, 17);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(94, 40);
            btn_Buscar.TabIndex = 13;
            btn_Buscar.Text = "BUSCAR";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click_1;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SteelBlue;
            txt_Nombre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(157, 23);
            txt_Nombre.Margin = new Padding(3, 4, 3, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "NOMBRE";
            txt_Nombre.ReadOnly = true;
            txt_Nombre.Size = new Size(114, 34);
            txt_Nombre.TabIndex = 14;
            // 
            // btn_Listar
            // 
            btn_Listar.BackColor = Color.White;
            btn_Listar.FlatAppearance.BorderSize = 0;
            btn_Listar.FlatStyle = FlatStyle.Flat;
            btn_Listar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Listar.ForeColor = Color.SteelBlue;
            btn_Listar.Location = new Point(406, 17);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(94, 40);
            btn_Listar.TabIndex = 15;
            btn_Listar.Text = "LISTAR";
            btn_Listar.UseVisualStyleBackColor = false;
            btn_Listar.Click += btn_Listar_Click;
            // 
            // btn_ListarProducto
            // 
            btn_ListarProducto.BackColor = Color.White;
            btn_ListarProducto.FlatAppearance.BorderSize = 0;
            btn_ListarProducto.FlatStyle = FlatStyle.Flat;
            btn_ListarProducto.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ListarProducto.ForeColor = Color.SteelBlue;
            btn_ListarProducto.Location = new Point(431, 70);
            btn_ListarProducto.Name = "btn_ListarProducto";
            btn_ListarProducto.Size = new Size(94, 40);
            btn_ListarProducto.TabIndex = 16;
            btn_ListarProducto.Text = "LISTAR";
            btn_ListarProducto.UseVisualStyleBackColor = false;
            btn_ListarProducto.Click += btn_ListarProducto_Click;
            // 
            // Form_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(615, 553);
            Controls.Add(btn_ListarProducto);
            Controls.Add(btn_Listar);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Buscar);
            Controls.Add(Lbl_PrecioTotal);
            Controls.Add(dtg_Productos);
            Controls.Add(btn_Agregar);
            Controls.Add(txt_Cantidad);
            Controls.Add(txt_Codigo);
            Controls.Add(txt_DNI);
            Controls.Add(lbl_Total);
            Controls.Add(btn_Confirmar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Ventas";
            Text = "Form_Ventas";
            Load += Form_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Confirmar;
        private TextBox txt_DNI;
        private Label lbl_Total;
        private TextBox txt_Codigo;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private TextBox txt_Cantidad;
        private Button btn_Agregar;
        private DataGridView dtg_Productos;
        private Label Lbl_PrecioTotal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioVenta;
        private Button btn_Buscar;
        private TextBox txt_Nombre;
        private Button btn_Listar;
        private Button btn_ListarProducto;
    }
}