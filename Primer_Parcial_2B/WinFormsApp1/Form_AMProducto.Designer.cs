namespace Formularios
{
    partial class Form_AMProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AMProducto));
            txt_Cantidad = new TextBox();
            txt_PrecioVenta = new TextBox();
            txt_PrecioCompra = new TextBox();
            btn_Modificar = new Button();
            cmb_Categoria = new ComboBox();
            txt_Nombre = new TextBox();
            txt_Codigo = new TextBox();
            btn_Cerrar = new PictureBox();
            lbl_Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.BackColor = Color.SteelBlue;
            txt_Cantidad.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Cantidad.ForeColor = Color.White;
            txt_Cantidad.Location = new Point(29, 238);
            txt_Cantidad.Margin = new Padding(3, 4, 3, 4);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.PlaceholderText = "CANTIDAD";
            txt_Cantidad.Size = new Size(181, 34);
            txt_Cantidad.TabIndex = 38;
            // 
            // txt_PrecioVenta
            // 
            txt_PrecioVenta.BackColor = Color.SteelBlue;
            txt_PrecioVenta.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PrecioVenta.ForeColor = Color.White;
            txt_PrecioVenta.Location = new Point(272, 185);
            txt_PrecioVenta.Margin = new Padding(3, 4, 3, 4);
            txt_PrecioVenta.Name = "txt_PrecioVenta";
            txt_PrecioVenta.PlaceholderText = "PRECIO DE VENTA";
            txt_PrecioVenta.Size = new Size(189, 34);
            txt_PrecioVenta.TabIndex = 37;
            // 
            // txt_PrecioCompra
            // 
            txt_PrecioCompra.BackColor = Color.SteelBlue;
            txt_PrecioCompra.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PrecioCompra.ForeColor = Color.White;
            txt_PrecioCompra.Location = new Point(272, 134);
            txt_PrecioCompra.Margin = new Padding(3, 4, 3, 4);
            txt_PrecioCompra.Name = "txt_PrecioCompra";
            txt_PrecioCompra.PlaceholderText = "PRECIO DE COMPRA";
            txt_PrecioCompra.Size = new Size(189, 34);
            txt_PrecioCompra.TabIndex = 36;
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.White;
            btn_Modificar.ForeColor = Color.SteelBlue;
            btn_Modificar.Location = new Point(518, 175);
            btn_Modificar.Margin = new Padding(3, 4, 3, 4);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(188, 55);
            btn_Modificar.TabIndex = 35;
            btn_Modificar.Text = "MODIFICAR";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // cmb_Categoria
            // 
            cmb_Categoria.BackColor = Color.SteelBlue;
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categoria.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Categoria.ForeColor = Color.White;
            cmb_Categoria.FormattingEnabled = true;
            cmb_Categoria.Items.AddRange(new object[] { "CATEGORIA" });
            cmb_Categoria.Location = new Point(272, 238);
            cmb_Categoria.Margin = new Padding(3, 4, 3, 4);
            cmb_Categoria.Name = "cmb_Categoria";
            cmb_Categoria.Size = new Size(189, 36);
            cmb_Categoria.TabIndex = 34;
            cmb_Categoria.MouseClick += cmb_Categoria_MouseClick;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SteelBlue;
            txt_Nombre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(29, 185);
            txt_Nombre.Margin = new Padding(3, 4, 3, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "NOMBRE";
            txt_Nombre.Size = new Size(181, 34);
            txt_Nombre.TabIndex = 33;
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = Color.SteelBlue;
            txt_Codigo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Codigo.ForeColor = Color.White;
            txt_Codigo.Location = new Point(29, 134);
            txt_Codigo.Margin = new Padding(3, 4, 3, 4);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.PlaceholderText = "CODIGO";
            txt_Codigo.Size = new Size(181, 34);
            txt_Codigo.TabIndex = 32;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(714, 1);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(25, 25);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Cerrar.TabIndex = 39;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Titulo.ForeColor = Color.WhiteSmoke;
            lbl_Titulo.Location = new Point(108, 26);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(551, 69);
            lbl_Titulo.TabIndex = 40;
            lbl_Titulo.Text = "MODIFICAR PRODUCTO";
            lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_AMProducto
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(739, 303);
            Controls.Add(lbl_Titulo);
            Controls.Add(btn_Cerrar);
            Controls.Add(txt_Cantidad);
            Controls.Add(txt_PrecioVenta);
            Controls.Add(txt_PrecioCompra);
            Controls.Add(btn_Modificar);
            Controls.Add(cmb_Categoria);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Codigo);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form_AMProducto";
            Text = "Form_AMProducto";
            Load += Form_AMProducto_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Cantidad;
        private TextBox txt_PrecioVenta;
        private TextBox txt_PrecioCompra;
        private Button btn_Modificar;
        private ComboBox cmb_Categoria;
        private TextBox txt_Nombre;
        private TextBox txt_Codigo;
        private PictureBox btn_Cerrar;
        private Label lbl_Titulo;
    }
}