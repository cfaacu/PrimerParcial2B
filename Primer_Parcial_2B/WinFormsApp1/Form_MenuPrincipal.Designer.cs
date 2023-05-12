namespace Formularios
{
    partial class Form_MenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MenuPrincipal));
            imageList1 = new ImageList(components);
            panelMenuLateral = new Panel();
            btn_MostrarVentas = new Button();
            panelSubMenuReparaciones = new Panel();
            btn_MostrarReparaciones = new Button();
            btn_ModificarReparacion = new Button();
            btn_AgregarReparacion = new Button();
            btn_Reparacion = new Button();
            panelSubMenuClientes = new Panel();
            btn_MostrarClientes = new Button();
            btn_EliminarCliente = new Button();
            btn_ModificarCliente = new Button();
            btn_AgregarCliente = new Button();
            btn_Clientes = new Button();
            panelSubMenuProductos = new Panel();
            btn_MostrarProducto = new Button();
            btn_EliminarProducto = new Button();
            btn_ModificarProducto = new Button();
            btn_AgregarProducto = new Button();
            btn_Productos = new Button();
            btn_GenerarVenta = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            panelBarraTitulo = new Panel();
            btn_Salir = new PictureBox();
            pictureBox2 = new PictureBox();
            panelMenuLateral.SuspendLayout();
            panelSubMenuReparaciones.SuspendLayout();
            panelSubMenuClientes.SuspendLayout();
            panelSubMenuProductos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Salir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.FromArgb(0, 122, 204);
            panelMenuLateral.Controls.Add(btn_MostrarVentas);
            panelMenuLateral.Controls.Add(panelSubMenuReparaciones);
            panelMenuLateral.Controls.Add(btn_Reparacion);
            panelMenuLateral.Controls.Add(panelSubMenuClientes);
            panelMenuLateral.Controls.Add(btn_Clientes);
            panelMenuLateral.Controls.Add(panelSubMenuProductos);
            panelMenuLateral.Controls.Add(btn_Productos);
            panelMenuLateral.Controls.Add(btn_GenerarVenta);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 622);
            panelMenuLateral.TabIndex = 1;
            // 
            // btn_MostrarVentas
            // 
            btn_MostrarVentas.Dock = DockStyle.Top;
            btn_MostrarVentas.FlatAppearance.BorderSize = 0;
            btn_MostrarVentas.FlatStyle = FlatStyle.Flat;
            btn_MostrarVentas.ForeColor = Color.White;
            btn_MostrarVentas.Location = new Point(0, 763);
            btn_MostrarVentas.Name = "btn_MostrarVentas";
            btn_MostrarVentas.Padding = new Padding(10, 0, 0, 0);
            btn_MostrarVentas.Size = new Size(233, 45);
            btn_MostrarVentas.TabIndex = 8;
            btn_MostrarVentas.Text = "MOSTRAR VENTAS";
            btn_MostrarVentas.TextAlign = ContentAlignment.MiddleLeft;
            btn_MostrarVentas.UseVisualStyleBackColor = true;
            btn_MostrarVentas.Visible = false;
            btn_MostrarVentas.Click += btn_MostrarVentas_Click;
            // 
            // panelSubMenuReparaciones
            // 
            panelSubMenuReparaciones.BackColor = Color.SteelBlue;
            panelSubMenuReparaciones.Controls.Add(btn_MostrarReparaciones);
            panelSubMenuReparaciones.Controls.Add(btn_ModificarReparacion);
            panelSubMenuReparaciones.Controls.Add(btn_AgregarReparacion);
            panelSubMenuReparaciones.Dock = DockStyle.Top;
            panelSubMenuReparaciones.Location = new Point(0, 630);
            panelSubMenuReparaciones.Name = "panelSubMenuReparaciones";
            panelSubMenuReparaciones.Size = new Size(233, 133);
            panelSubMenuReparaciones.TabIndex = 7;
            // 
            // btn_MostrarReparaciones
            // 
            btn_MostrarReparaciones.Dock = DockStyle.Top;
            btn_MostrarReparaciones.FlatAppearance.BorderSize = 0;
            btn_MostrarReparaciones.FlatStyle = FlatStyle.Flat;
            btn_MostrarReparaciones.ForeColor = Color.White;
            btn_MostrarReparaciones.Location = new Point(0, 80);
            btn_MostrarReparaciones.Name = "btn_MostrarReparaciones";
            btn_MostrarReparaciones.Padding = new Padding(35, 0, 0, 0);
            btn_MostrarReparaciones.Size = new Size(233, 40);
            btn_MostrarReparaciones.TabIndex = 3;
            btn_MostrarReparaciones.Text = "MOSTRAR";
            btn_MostrarReparaciones.TextAlign = ContentAlignment.MiddleLeft;
            btn_MostrarReparaciones.UseVisualStyleBackColor = true;
            btn_MostrarReparaciones.Click += btn_MostrarReparaciones_Click;
            // 
            // btn_ModificarReparacion
            // 
            btn_ModificarReparacion.Dock = DockStyle.Top;
            btn_ModificarReparacion.FlatAppearance.BorderSize = 0;
            btn_ModificarReparacion.FlatStyle = FlatStyle.Flat;
            btn_ModificarReparacion.ForeColor = Color.White;
            btn_ModificarReparacion.Location = new Point(0, 40);
            btn_ModificarReparacion.Name = "btn_ModificarReparacion";
            btn_ModificarReparacion.Padding = new Padding(35, 0, 0, 0);
            btn_ModificarReparacion.Size = new Size(233, 40);
            btn_ModificarReparacion.TabIndex = 1;
            btn_ModificarReparacion.Text = "MODIFICAR";
            btn_ModificarReparacion.TextAlign = ContentAlignment.MiddleLeft;
            btn_ModificarReparacion.UseVisualStyleBackColor = true;
            btn_ModificarReparacion.Click += btn_ModificarReparacion_Click;
            // 
            // btn_AgregarReparacion
            // 
            btn_AgregarReparacion.Dock = DockStyle.Top;
            btn_AgregarReparacion.FlatAppearance.BorderSize = 0;
            btn_AgregarReparacion.FlatStyle = FlatStyle.Flat;
            btn_AgregarReparacion.ForeColor = Color.White;
            btn_AgregarReparacion.Location = new Point(0, 0);
            btn_AgregarReparacion.Name = "btn_AgregarReparacion";
            btn_AgregarReparacion.Padding = new Padding(35, 0, 0, 0);
            btn_AgregarReparacion.Size = new Size(233, 40);
            btn_AgregarReparacion.TabIndex = 0;
            btn_AgregarReparacion.Text = "CREAR";
            btn_AgregarReparacion.TextAlign = ContentAlignment.MiddleLeft;
            btn_AgregarReparacion.UseVisualStyleBackColor = true;
            btn_AgregarReparacion.Click += btn_AgregarReparacion_Click;
            // 
            // btn_Reparacion
            // 
            btn_Reparacion.Dock = DockStyle.Top;
            btn_Reparacion.FlatAppearance.BorderSize = 0;
            btn_Reparacion.FlatStyle = FlatStyle.Flat;
            btn_Reparacion.ForeColor = Color.White;
            btn_Reparacion.Location = new Point(0, 585);
            btn_Reparacion.Name = "btn_Reparacion";
            btn_Reparacion.Padding = new Padding(10, 0, 0, 0);
            btn_Reparacion.Size = new Size(233, 45);
            btn_Reparacion.TabIndex = 6;
            btn_Reparacion.Text = "REPARACIONES";
            btn_Reparacion.TextAlign = ContentAlignment.MiddleLeft;
            btn_Reparacion.UseVisualStyleBackColor = true;
            btn_Reparacion.Click += btn_Reparacion_Click;
            // 
            // panelSubMenuClientes
            // 
            panelSubMenuClientes.BackColor = Color.SteelBlue;
            panelSubMenuClientes.Controls.Add(btn_MostrarClientes);
            panelSubMenuClientes.Controls.Add(btn_EliminarCliente);
            panelSubMenuClientes.Controls.Add(btn_ModificarCliente);
            panelSubMenuClientes.Controls.Add(btn_AgregarCliente);
            panelSubMenuClientes.Dock = DockStyle.Top;
            panelSubMenuClientes.Location = new Point(0, 410);
            panelSubMenuClientes.Name = "panelSubMenuClientes";
            panelSubMenuClientes.Size = new Size(233, 175);
            panelSubMenuClientes.TabIndex = 5;
            // 
            // btn_MostrarClientes
            // 
            btn_MostrarClientes.Dock = DockStyle.Top;
            btn_MostrarClientes.FlatAppearance.BorderSize = 0;
            btn_MostrarClientes.FlatStyle = FlatStyle.Flat;
            btn_MostrarClientes.ForeColor = Color.White;
            btn_MostrarClientes.Location = new Point(0, 120);
            btn_MostrarClientes.Name = "btn_MostrarClientes";
            btn_MostrarClientes.Padding = new Padding(35, 0, 0, 0);
            btn_MostrarClientes.Size = new Size(233, 40);
            btn_MostrarClientes.TabIndex = 3;
            btn_MostrarClientes.Text = "MOSTRAR";
            btn_MostrarClientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_MostrarClientes.UseVisualStyleBackColor = true;
            btn_MostrarClientes.Click += btn_MostrarClientes_Click;
            // 
            // btn_EliminarCliente
            // 
            btn_EliminarCliente.Dock = DockStyle.Top;
            btn_EliminarCliente.FlatAppearance.BorderSize = 0;
            btn_EliminarCliente.FlatStyle = FlatStyle.Flat;
            btn_EliminarCliente.ForeColor = Color.White;
            btn_EliminarCliente.Location = new Point(0, 80);
            btn_EliminarCliente.Name = "btn_EliminarCliente";
            btn_EliminarCliente.Padding = new Padding(35, 0, 0, 0);
            btn_EliminarCliente.Size = new Size(233, 40);
            btn_EliminarCliente.TabIndex = 2;
            btn_EliminarCliente.Text = "ELIMINAR";
            btn_EliminarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btn_EliminarCliente.UseVisualStyleBackColor = true;
            btn_EliminarCliente.Click += btn_EliminarCliente_Click;
            // 
            // btn_ModificarCliente
            // 
            btn_ModificarCliente.Dock = DockStyle.Top;
            btn_ModificarCliente.FlatAppearance.BorderSize = 0;
            btn_ModificarCliente.FlatStyle = FlatStyle.Flat;
            btn_ModificarCliente.ForeColor = Color.White;
            btn_ModificarCliente.Location = new Point(0, 40);
            btn_ModificarCliente.Name = "btn_ModificarCliente";
            btn_ModificarCliente.Padding = new Padding(35, 0, 0, 0);
            btn_ModificarCliente.Size = new Size(233, 40);
            btn_ModificarCliente.TabIndex = 1;
            btn_ModificarCliente.Text = "MODIFICAR";
            btn_ModificarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btn_ModificarCliente.UseVisualStyleBackColor = true;
            btn_ModificarCliente.Click += btn_ModificarCliente_Click;
            // 
            // btn_AgregarCliente
            // 
            btn_AgregarCliente.Dock = DockStyle.Top;
            btn_AgregarCliente.FlatAppearance.BorderSize = 0;
            btn_AgregarCliente.FlatStyle = FlatStyle.Flat;
            btn_AgregarCliente.ForeColor = Color.White;
            btn_AgregarCliente.Location = new Point(0, 0);
            btn_AgregarCliente.Name = "btn_AgregarCliente";
            btn_AgregarCliente.Padding = new Padding(35, 0, 0, 0);
            btn_AgregarCliente.Size = new Size(233, 40);
            btn_AgregarCliente.TabIndex = 0;
            btn_AgregarCliente.Text = "AGREGAR";
            btn_AgregarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btn_AgregarCliente.UseVisualStyleBackColor = true;
            btn_AgregarCliente.Click += btn_AgregarCliente_Click;
            // 
            // btn_Clientes
            // 
            btn_Clientes.Dock = DockStyle.Top;
            btn_Clientes.FlatAppearance.BorderSize = 0;
            btn_Clientes.FlatStyle = FlatStyle.Flat;
            btn_Clientes.ForeColor = Color.White;
            btn_Clientes.Location = new Point(0, 365);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Padding = new Padding(10, 0, 0, 0);
            btn_Clientes.Size = new Size(233, 45);
            btn_Clientes.TabIndex = 4;
            btn_Clientes.Text = "CLIENTES";
            btn_Clientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_Clientes.UseVisualStyleBackColor = true;
            btn_Clientes.Click += btn_Clientes_Click;
            // 
            // panelSubMenuProductos
            // 
            panelSubMenuProductos.BackColor = Color.SteelBlue;
            panelSubMenuProductos.Controls.Add(btn_MostrarProducto);
            panelSubMenuProductos.Controls.Add(btn_EliminarProducto);
            panelSubMenuProductos.Controls.Add(btn_ModificarProducto);
            panelSubMenuProductos.Controls.Add(btn_AgregarProducto);
            panelSubMenuProductos.Dock = DockStyle.Top;
            panelSubMenuProductos.Location = new Point(0, 190);
            panelSubMenuProductos.Name = "panelSubMenuProductos";
            panelSubMenuProductos.Size = new Size(233, 175);
            panelSubMenuProductos.TabIndex = 3;
            // 
            // btn_MostrarProducto
            // 
            btn_MostrarProducto.Dock = DockStyle.Top;
            btn_MostrarProducto.FlatAppearance.BorderSize = 0;
            btn_MostrarProducto.FlatStyle = FlatStyle.Flat;
            btn_MostrarProducto.ForeColor = Color.White;
            btn_MostrarProducto.Location = new Point(0, 120);
            btn_MostrarProducto.Name = "btn_MostrarProducto";
            btn_MostrarProducto.Padding = new Padding(35, 0, 0, 0);
            btn_MostrarProducto.Size = new Size(233, 40);
            btn_MostrarProducto.TabIndex = 3;
            btn_MostrarProducto.Text = "MOSTRAR";
            btn_MostrarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btn_MostrarProducto.UseVisualStyleBackColor = true;
            btn_MostrarProducto.Click += btn_MostrarProducto_Click;
            // 
            // btn_EliminarProducto
            // 
            btn_EliminarProducto.Dock = DockStyle.Top;
            btn_EliminarProducto.FlatAppearance.BorderSize = 0;
            btn_EliminarProducto.FlatStyle = FlatStyle.Flat;
            btn_EliminarProducto.ForeColor = Color.White;
            btn_EliminarProducto.Location = new Point(0, 80);
            btn_EliminarProducto.Name = "btn_EliminarProducto";
            btn_EliminarProducto.Padding = new Padding(35, 0, 0, 0);
            btn_EliminarProducto.Size = new Size(233, 40);
            btn_EliminarProducto.TabIndex = 2;
            btn_EliminarProducto.Text = "ELIMINAR";
            btn_EliminarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btn_EliminarProducto.UseVisualStyleBackColor = true;
            btn_EliminarProducto.Click += btn_EliminarProducto_Click;
            // 
            // btn_ModificarProducto
            // 
            btn_ModificarProducto.Dock = DockStyle.Top;
            btn_ModificarProducto.FlatAppearance.BorderSize = 0;
            btn_ModificarProducto.FlatStyle = FlatStyle.Flat;
            btn_ModificarProducto.ForeColor = Color.White;
            btn_ModificarProducto.Location = new Point(0, 40);
            btn_ModificarProducto.Name = "btn_ModificarProducto";
            btn_ModificarProducto.Padding = new Padding(35, 0, 0, 0);
            btn_ModificarProducto.Size = new Size(233, 40);
            btn_ModificarProducto.TabIndex = 1;
            btn_ModificarProducto.Text = "MODIFICAR";
            btn_ModificarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btn_ModificarProducto.UseVisualStyleBackColor = true;
            btn_ModificarProducto.Click += btn_ModificarProducto_Click;
            // 
            // btn_AgregarProducto
            // 
            btn_AgregarProducto.Dock = DockStyle.Top;
            btn_AgregarProducto.FlatAppearance.BorderSize = 0;
            btn_AgregarProducto.FlatStyle = FlatStyle.Flat;
            btn_AgregarProducto.ForeColor = Color.White;
            btn_AgregarProducto.Location = new Point(0, 0);
            btn_AgregarProducto.Name = "btn_AgregarProducto";
            btn_AgregarProducto.Padding = new Padding(35, 0, 0, 0);
            btn_AgregarProducto.Size = new Size(233, 40);
            btn_AgregarProducto.TabIndex = 0;
            btn_AgregarProducto.Text = "AGREGAR";
            btn_AgregarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btn_AgregarProducto.UseVisualStyleBackColor = true;
            btn_AgregarProducto.Click += btn_AgregarProducto_Click;
            // 
            // btn_Productos
            // 
            btn_Productos.Dock = DockStyle.Top;
            btn_Productos.FlatAppearance.BorderSize = 0;
            btn_Productos.FlatStyle = FlatStyle.Flat;
            btn_Productos.ForeColor = Color.White;
            btn_Productos.Location = new Point(0, 145);
            btn_Productos.Name = "btn_Productos";
            btn_Productos.Padding = new Padding(10, 0, 0, 0);
            btn_Productos.Size = new Size(233, 45);
            btn_Productos.TabIndex = 2;
            btn_Productos.Text = "PRODUCTOS";
            btn_Productos.TextAlign = ContentAlignment.MiddleLeft;
            btn_Productos.UseVisualStyleBackColor = true;
            btn_Productos.Click += btn_Productos_Click;
            // 
            // btn_GenerarVenta
            // 
            btn_GenerarVenta.Dock = DockStyle.Top;
            btn_GenerarVenta.FlatAppearance.BorderSize = 0;
            btn_GenerarVenta.FlatStyle = FlatStyle.Flat;
            btn_GenerarVenta.ForeColor = Color.White;
            btn_GenerarVenta.Location = new Point(0, 100);
            btn_GenerarVenta.Name = "btn_GenerarVenta";
            btn_GenerarVenta.Padding = new Padding(10, 0, 0, 0);
            btn_GenerarVenta.Size = new Size(233, 45);
            btn_GenerarVenta.TabIndex = 1;
            btn_GenerarVenta.Text = "GENERAR VENTA";
            btn_GenerarVenta.TextAlign = ContentAlignment.MiddleLeft;
            btn_GenerarVenta.UseVisualStyleBackColor = true;
            btn_GenerarVenta.Click += btn_GenerarVenta_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 100);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 122, 204);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-66, -137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.SteelBlue;
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(853, 622);
            panelContenedor.TabIndex = 2;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.DodgerBlue;
            panelBarraTitulo.Controls.Add(btn_Salir);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(853, 40);
            panelBarraTitulo.TabIndex = 1;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // btn_Salir
            // 
            btn_Salir.Image = (Image)resources.GetObject("btn_Salir.Image");
            btn_Salir.Location = new Point(823, 0);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(30, 30);
            btn_Salir.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Salir.TabIndex = 0;
            btn_Salir.TabStop = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(163, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(530, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 622);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenuLateral);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimumSize = new Size(950, 600);
            Name = "Form_MenuPrincipal";
            Opacity = 0.95D;
            Text = "Menu Principal";
            Load += Form_MenuPrincipal_Load;
            panelMenuLateral.ResumeLayout(false);
            panelSubMenuReparaciones.ResumeLayout(false);
            panelSubMenuClientes.ResumeLayout(false);
            panelSubMenuProductos.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_Salir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Panel panelMenuLateral;
        private Button btn_Reparacion;
        private Panel panelSubMenuClientes;
        private Button btn_MostrarClientes;
        private Button btn_EliminarCliente;
        private Button btn_ModificarCliente;
        private Button btn_AgregarCliente;
        private Button btn_Clientes;
        private Panel panelSubMenuProductos;
        private Button btn_MostrarProducto;
        private Button btn_EliminarProducto;
        private Button btn_ModificarProducto;
        private Button btn_AgregarProducto;
        private Button btn_Productos;
        private Button btn_GenerarVenta;
        private Panel panelLogo;
        private Panel panelSubMenuReparaciones;
        private Button btn_MostrarReparaciones;
        private Button btn_ModificarReparacion;
        private Button btn_AgregarReparacion;
        private Panel panelContenedor;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panelBarraTitulo;
        private PictureBox btn_Salir;
        private Button btn_MostrarVentas;
    }
}