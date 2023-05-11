namespace Formularios
{
    partial class Form_ABM_Productos
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
            lbl_PrecioCompra = new Label();
            txt_Nombre = new TextBox();
            lbl_NombreProducto = new Label();
            lbl_Categoria = new Label();
            txt_Codigo = new TextBox();
            lbl_Codigo = new Label();
            btn_Continuar = new Button();
            lbl_PrecioVenta = new Label();
            cmb_Categoria = new ComboBox();
            btn_Buscar = new Button();
            txt_PrecioCompra = new TextBox();
            txt_PrecioVenta = new TextBox();
            txt_Cantidad = new TextBox();
            lbl_Cantidad = new Label();
            SuspendLayout();
            // 
            // lbl_PrecioCompra
            // 
            lbl_PrecioCompra.AutoSize = true;
            lbl_PrecioCompra.Location = new Point(73, 224);
            lbl_PrecioCompra.Name = "lbl_PrecioCompra";
            lbl_PrecioCompra.Size = new Size(103, 15);
            lbl_PrecioCompra.TabIndex = 21;
            lbl_PrecioCompra.Text = "Precio De Compra";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(73, 114);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 20;
            // 
            // lbl_NombreProducto
            // 
            lbl_NombreProducto.AutoSize = true;
            lbl_NombreProducto.Location = new Point(73, 96);
            lbl_NombreProducto.Name = "lbl_NombreProducto";
            lbl_NombreProducto.Size = new Size(51, 15);
            lbl_NombreProducto.TabIndex = 19;
            lbl_NombreProducto.Text = "Nombre";
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Location = new Point(73, 160);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(58, 15);
            lbl_Categoria.TabIndex = 15;
            lbl_Categoria.Text = "Categoria";
            // 
            // txt_Codigo
            // 
            txt_Codigo.Location = new Point(73, 50);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(100, 23);
            txt_Codigo.TabIndex = 14;
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Location = new Point(73, 32);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(46, 15);
            lbl_Codigo.TabIndex = 13;
            lbl_Codigo.Text = "Codigo";
            // 
            // btn_Continuar
            // 
            btn_Continuar.Location = new Point(66, 409);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(125, 57);
            btn_Continuar.TabIndex = 23;
            btn_Continuar.Text = "Continuar";
            btn_Continuar.UseVisualStyleBackColor = true;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // lbl_PrecioVenta
            // 
            lbl_PrecioVenta.AutoSize = true;
            lbl_PrecioVenta.Location = new Point(73, 286);
            lbl_PrecioVenta.Name = "lbl_PrecioVenta";
            lbl_PrecioVenta.Size = new Size(89, 15);
            lbl_PrecioVenta.TabIndex = 24;
            lbl_PrecioVenta.Text = "Precio De Venta";
            // 
            // cmb_Categoria
            // 
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categoria.FormattingEnabled = true;
            cmb_Categoria.Location = new Point(66, 178);
            cmb_Categoria.Name = "cmb_Categoria";
            cmb_Categoria.Size = new Size(121, 23);
            cmb_Categoria.TabIndex = 26;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(185, 53);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(24, 17);
            btn_Buscar.TabIndex = 27;
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txt_PrecioCompra
            // 
            txt_PrecioCompra.Location = new Point(73, 242);
            txt_PrecioCompra.Name = "txt_PrecioCompra";
            txt_PrecioCompra.Size = new Size(100, 23);
            txt_PrecioCompra.TabIndex = 28;
            // 
            // txt_PrecioVenta
            // 
            txt_PrecioVenta.Location = new Point(73, 304);
            txt_PrecioVenta.Name = "txt_PrecioVenta";
            txt_PrecioVenta.Size = new Size(100, 23);
            txt_PrecioVenta.TabIndex = 29;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new Point(73, 361);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(100, 23);
            txt_Cantidad.TabIndex = 31;
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new Point(73, 343);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(55, 15);
            lbl_Cantidad.TabIndex = 30;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // Form_ABM_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 487);
            Controls.Add(txt_Cantidad);
            Controls.Add(lbl_Cantidad);
            Controls.Add(txt_PrecioVenta);
            Controls.Add(txt_PrecioCompra);
            Controls.Add(btn_Buscar);
            Controls.Add(cmb_Categoria);
            Controls.Add(lbl_PrecioVenta);
            Controls.Add(btn_Continuar);
            Controls.Add(lbl_PrecioCompra);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_NombreProducto);
            Controls.Add(lbl_Categoria);
            Controls.Add(txt_Codigo);
            Controls.Add(lbl_Codigo);
            Name = "Form_ABM_Productos";
            Text = "Producto";
            Load += Form_ABM_Productos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_PrecioCompra;
        private TextBox txt_Nombre;
        private Label lbl_NombreProducto;
        private Label lbl_Categoria;
        private TextBox txt_Codigo;
        private Label lbl_Codigo;
        private Button btn_Continuar;
        private Label lbl_PrecioVenta;
        private ComboBox cmb_Categoria;
        private Button btn_Buscar;
        private TextBox txt_PrecioCompra;
        private TextBox txt_PrecioVenta;
        private TextBox txt_Cantidad;
        private Label lbl_Cantidad;
    }
}