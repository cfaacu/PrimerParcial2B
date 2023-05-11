namespace Formularios
{
    partial class Form_ModificarReparacion
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
            dtg_Reparaciones = new DataGridView();
            lbl_CodigoSerie = new Label();
            txt_CodigoSerie = new TextBox();
            txt_Presupuesto = new TextBox();
            lbl_Presupuesto = new Label();
            txt_Precio = new TextBox();
            lbl_Precio = new Label();
            cmb_Estado = new ComboBox();
            lbl_Estado = new Label();
            btn_Aceptar = new Button();
            btn_Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_Reparaciones).BeginInit();
            SuspendLayout();
            // 
            // dtg_Reparaciones
            // 
            dtg_Reparaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Reparaciones.Location = new Point(23, 37);
            dtg_Reparaciones.Name = "dtg_Reparaciones";
            dtg_Reparaciones.RowTemplate.Height = 25;
            dtg_Reparaciones.Size = new Size(355, 347);
            dtg_Reparaciones.TabIndex = 0;
            // 
            // lbl_CodigoSerie
            // 
            lbl_CodigoSerie.AutoSize = true;
            lbl_CodigoSerie.Location = new Point(413, 37);
            lbl_CodigoSerie.Name = "lbl_CodigoSerie";
            lbl_CodigoSerie.Size = new Size(91, 15);
            lbl_CodigoSerie.TabIndex = 1;
            lbl_CodigoSerie.Text = "Codigo De Serie";
            // 
            // txt_CodigoSerie
            // 
            txt_CodigoSerie.Location = new Point(413, 55);
            txt_CodigoSerie.Name = "txt_CodigoSerie";
            txt_CodigoSerie.Size = new Size(100, 23);
            txt_CodigoSerie.TabIndex = 2;
            // 
            // txt_Presupuesto
            // 
            txt_Presupuesto.Enabled = false;
            txt_Presupuesto.Location = new Point(413, 122);
            txt_Presupuesto.Name = "txt_Presupuesto";
            txt_Presupuesto.Size = new Size(100, 23);
            txt_Presupuesto.TabIndex = 4;
            // 
            // lbl_Presupuesto
            // 
            lbl_Presupuesto.AutoSize = true;
            lbl_Presupuesto.Location = new Point(413, 104);
            lbl_Presupuesto.Name = "lbl_Presupuesto";
            lbl_Presupuesto.Size = new Size(72, 15);
            lbl_Presupuesto.TabIndex = 3;
            lbl_Presupuesto.Text = "Presupuesto";
            // 
            // txt_Precio
            // 
            txt_Precio.Enabled = false;
            txt_Precio.Location = new Point(413, 193);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(100, 23);
            txt_Precio.TabIndex = 6;
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Location = new Point(413, 175);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(40, 15);
            lbl_Precio.TabIndex = 5;
            lbl_Precio.Text = "Precio";
            // 
            // cmb_Estado
            // 
            cmb_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Estado.Enabled = false;
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Location = new Point(413, 270);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(121, 23);
            cmb_Estado.TabIndex = 8;
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Location = new Point(413, 252);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(42, 15);
            lbl_Estado.TabIndex = 7;
            lbl_Estado.Text = "Estado";
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(409, 332);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(121, 71);
            btn_Aceptar.TabIndex = 9;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(531, 53);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(24, 25);
            btn_Buscar.TabIndex = 10;
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // Form_ModificarReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 450);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Aceptar);
            Controls.Add(cmb_Estado);
            Controls.Add(lbl_Estado);
            Controls.Add(txt_Precio);
            Controls.Add(lbl_Precio);
            Controls.Add(txt_Presupuesto);
            Controls.Add(lbl_Presupuesto);
            Controls.Add(txt_CodigoSerie);
            Controls.Add(lbl_CodigoSerie);
            Controls.Add(dtg_Reparaciones);
            Name = "Form_ModificarReparacion";
            Text = "Form_ModificarReparacion";
            Load += Form_ModificarReparacion_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Reparaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_Reparaciones;
        private Label lbl_CodigoSerie;
        private TextBox txt_CodigoSerie;
        private TextBox txt_Presupuesto;
        private Label lbl_Presupuesto;
        private TextBox txt_Precio;
        private Label lbl_Precio;
        private ComboBox cmb_Estado;
        private Label lbl_Estado;
        private Button btn_Aceptar;
        private Button btn_Buscar;
    }
}