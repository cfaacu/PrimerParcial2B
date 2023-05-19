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
            btn_AdministrarUsuario = new Button();
            btn_MostrarVentas = new Button();
            panelSubMenuReparaciones = new Panel();
            btn_MostrarReparaciones = new Button();
            btn_ModificarReparacion = new Button();
            btn_AgregarReparacion = new Button();
            btn_Reparacion = new Button();
            btn_Clientes = new Button();
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
            panelMenuLateral.Controls.Add(btn_AdministrarUsuario);
            panelMenuLateral.Controls.Add(btn_MostrarVentas);
            panelMenuLateral.Controls.Add(panelSubMenuReparaciones);
            panelMenuLateral.Controls.Add(btn_Reparacion);
            panelMenuLateral.Controls.Add(btn_Clientes);
            panelMenuLateral.Controls.Add(btn_Productos);
            panelMenuLateral.Controls.Add(btn_GenerarVenta);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 711);
            panelMenuLateral.TabIndex = 1;
            // 
            // btn_AdministrarUsuario
            // 
            btn_AdministrarUsuario.Dock = DockStyle.Top;
            btn_AdministrarUsuario.FlatAppearance.BorderSize = 0;
            btn_AdministrarUsuario.FlatStyle = FlatStyle.Flat;
            btn_AdministrarUsuario.ForeColor = Color.White;
            btn_AdministrarUsuario.Location = new Point(0, 458);
            btn_AdministrarUsuario.Name = "btn_AdministrarUsuario";
            btn_AdministrarUsuario.Padding = new Padding(10, 0, 0, 0);
            btn_AdministrarUsuario.Size = new Size(250, 45);
            btn_AdministrarUsuario.TabIndex = 9;
            btn_AdministrarUsuario.Text = "ADMINISTRAR USUARIO";
            btn_AdministrarUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btn_AdministrarUsuario.UseVisualStyleBackColor = true;
            btn_AdministrarUsuario.Visible = false;
            btn_AdministrarUsuario.Click += btn_AdministrarUsuario_Click;
            // 
            // btn_MostrarVentas
            // 
            btn_MostrarVentas.Dock = DockStyle.Top;
            btn_MostrarVentas.FlatAppearance.BorderSize = 0;
            btn_MostrarVentas.FlatStyle = FlatStyle.Flat;
            btn_MostrarVentas.ForeColor = Color.White;
            btn_MostrarVentas.Location = new Point(0, 413);
            btn_MostrarVentas.Name = "btn_MostrarVentas";
            btn_MostrarVentas.Padding = new Padding(10, 0, 0, 0);
            btn_MostrarVentas.Size = new Size(250, 45);
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
            panelSubMenuReparaciones.Location = new Point(0, 280);
            panelSubMenuReparaciones.Name = "panelSubMenuReparaciones";
            panelSubMenuReparaciones.Size = new Size(250, 133);
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
            btn_MostrarReparaciones.Size = new Size(250, 40);
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
            btn_ModificarReparacion.Size = new Size(250, 40);
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
            btn_AgregarReparacion.Size = new Size(250, 40);
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
            btn_Reparacion.Location = new Point(0, 235);
            btn_Reparacion.Name = "btn_Reparacion";
            btn_Reparacion.Padding = new Padding(10, 0, 0, 0);
            btn_Reparacion.Size = new Size(250, 45);
            btn_Reparacion.TabIndex = 6;
            btn_Reparacion.Text = "REPARACIONES";
            btn_Reparacion.TextAlign = ContentAlignment.MiddleLeft;
            btn_Reparacion.UseVisualStyleBackColor = true;
            btn_Reparacion.Click += btn_Reparacion_Click;
            // 
            // btn_Clientes
            // 
            btn_Clientes.Dock = DockStyle.Top;
            btn_Clientes.FlatAppearance.BorderSize = 0;
            btn_Clientes.FlatStyle = FlatStyle.Flat;
            btn_Clientes.ForeColor = Color.White;
            btn_Clientes.Location = new Point(0, 190);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Padding = new Padding(10, 0, 0, 0);
            btn_Clientes.Size = new Size(250, 45);
            btn_Clientes.TabIndex = 4;
            btn_Clientes.Text = "CLIENTES";
            btn_Clientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_Clientes.UseVisualStyleBackColor = true;
            btn_Clientes.Click += btn_Clientes_Click;
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
            btn_Productos.Size = new Size(250, 45);
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
            btn_GenerarVenta.Size = new Size(250, 45);
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
            panelLogo.Size = new Size(250, 100);
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
            panelContenedor.Size = new Size(903, 711);
            panelContenedor.TabIndex = 2;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.DodgerBlue;
            panelBarraTitulo.Controls.Add(btn_Salir);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(903, 40);
            panelBarraTitulo.TabIndex = 1;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // btn_Salir
            // 
            btn_Salir.Image = (Image)resources.GetObject("btn_Salir.Image");
            btn_Salir.Location = new Point(873, 0);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(30, 30);
            btn_Salir.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Salir.TabIndex = 0;
            btn_Salir.TabStop = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(213, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(530, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 711);
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
        private Button btn_Clientes;
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
        private Button btn_AdministrarUsuario;
    }
}