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
            txt_Nombre = new TextBox();
            lbl_Categoria = new Label();
            txt_Codigo = new TextBox();
            btn_Continuar = new Button();
            cmb_Categoria = new ComboBox();
            btn_Buscar = new Button();
            txt_PrecioCompra = new TextBox();
            txt_PrecioVenta = new TextBox();
            txt_Cantidad = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SteelBlue;
            txt_Nombre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(73, 105);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(159, 29);
            txt_Nombre.TabIndex = 20;
            txt_Nombre.Text = "NOMBRE";
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Categoria.ForeColor = Color.White;
            lbl_Categoria.Location = new Point(2, 12);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(92, 21);
            lbl_Categoria.TabIndex = 15;
            lbl_Categoria.Text = "CATEGORIA";
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = Color.SteelBlue;
            txt_Codigo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Codigo.ForeColor = Color.White;
            txt_Codigo.Location = new Point(73, 50);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(159, 29);
            txt_Codigo.TabIndex = 14;
            txt_Codigo.Text = "CODIGO";
            // 
            // btn_Continuar
            // 
            btn_Continuar.BackColor = Color.White;
            btn_Continuar.FlatAppearance.BorderSize = 0;
            btn_Continuar.FlatStyle = FlatStyle.Flat;
            btn_Continuar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Continuar.ForeColor = Color.SteelBlue;
            btn_Continuar.Location = new Point(101, 241);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(349, 57);
            btn_Continuar.TabIndex = 23;
            btn_Continuar.Text = "CONTINUAR";
            btn_Continuar.UseVisualStyleBackColor = false;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // cmb_Categoria
            // 
            cmb_Categoria.BackColor = Color.SteelBlue;
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categoria.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Categoria.ForeColor = Color.White;
            cmb_Categoria.FormattingEnabled = true;
            cmb_Categoria.Location = new Point(67, 193);
            cmb_Categoria.Name = "cmb_Categoria";
            cmb_Categoria.Size = new Size(165, 29);
            cmb_Categoria.TabIndex = 26;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.White;
            btn_Buscar.Location = new Point(251, 53);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(24, 26);
            btn_Buscar.TabIndex = 27;
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txt_PrecioCompra
            // 
            txt_PrecioCompra.BackColor = Color.SteelBlue;
            txt_PrecioCompra.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PrecioCompra.ForeColor = Color.White;
            txt_PrecioCompra.Location = new Point(290, 50);
            txt_PrecioCompra.Name = "txt_PrecioCompra";
            txt_PrecioCompra.Size = new Size(166, 29);
            txt_PrecioCompra.TabIndex = 28;
            txt_PrecioCompra.Text = "PRECIO DE COMPRA";
            // 
            // txt_PrecioVenta
            // 
            txt_PrecioVenta.BackColor = Color.SteelBlue;
            txt_PrecioVenta.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PrecioVenta.ForeColor = Color.White;
            txt_PrecioVenta.Location = new Point(290, 105);
            txt_PrecioVenta.Name = "txt_PrecioVenta";
            txt_PrecioVenta.Size = new Size(166, 29);
            txt_PrecioVenta.TabIndex = 29;
            txt_PrecioVenta.Text = "PRECIO DE VENTA";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.BackColor = Color.SteelBlue;
            txt_Cantidad.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Cantidad.ForeColor = Color.White;
            txt_Cantidad.Location = new Point(290, 160);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(166, 29);
            txt_Cantidad.TabIndex = 31;
            txt_Cantidad.Text = "CANTIDAD";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_Categoria);
            groupBox1.Location = new Point(70, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(162, 36);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // Form_ABM_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(668, 497);
            Controls.Add(groupBox1);
            Controls.Add(txt_Cantidad);
            Controls.Add(txt_PrecioVenta);
            Controls.Add(txt_PrecioCompra);
            Controls.Add(btn_Buscar);
            Controls.Add(cmb_Categoria);
            Controls.Add(btn_Continuar);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Codigo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ABM_Productos";
            Text = "Producto";
            Load += Form_ABM_Productos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Nombre;
        private Label lbl_Categoria;
        private TextBox txt_Codigo;
        private Button btn_Continuar;
        private ComboBox cmb_Categoria;
        private Button btn_Buscar;
        private TextBox txt_PrecioCompra;
        private TextBox txt_PrecioVenta;
        private TextBox txt_Cantidad;
        private GroupBox groupBox1;
    }
}