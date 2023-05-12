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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txt_CodigoSerie = new TextBox();
            txt_Presupuesto = new TextBox();
            txt_Precio = new TextBox();
            cmb_Estado = new ComboBox();
            btn_Aceptar = new Button();
            btn_Buscar = new Button();
            dtg_Reparaciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_Reparaciones).BeginInit();
            SuspendLayout();
            // 
            // txt_CodigoSerie
            // 
            txt_CodigoSerie.BackColor = Color.SteelBlue;
            txt_CodigoSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CodigoSerie.ForeColor = Color.White;
            txt_CodigoSerie.Location = new Point(22, 283);
            txt_CodigoSerie.Name = "txt_CodigoSerie";
            txt_CodigoSerie.Size = new Size(100, 29);
            txt_CodigoSerie.TabIndex = 2;
            txt_CodigoSerie.Text = "CODIGO";
            // 
            // txt_Presupuesto
            // 
            txt_Presupuesto.BackColor = Color.SteelBlue;
            txt_Presupuesto.Enabled = false;
            txt_Presupuesto.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Presupuesto.ForeColor = Color.White;
            txt_Presupuesto.Location = new Point(22, 330);
            txt_Presupuesto.Name = "txt_Presupuesto";
            txt_Presupuesto.Size = new Size(117, 29);
            txt_Presupuesto.TabIndex = 4;
            txt_Presupuesto.Text = "PRESUPUESTO";
            // 
            // txt_Precio
            // 
            txt_Precio.BackColor = Color.SteelBlue;
            txt_Precio.Enabled = false;
            txt_Precio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Precio.ForeColor = Color.White;
            txt_Precio.Location = new Point(154, 330);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(100, 29);
            txt_Precio.TabIndex = 6;
            txt_Precio.Text = "PRECIO";
            // 
            // cmb_Estado
            // 
            cmb_Estado.BackColor = Color.SteelBlue;
            cmb_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Estado.Enabled = false;
            cmb_Estado.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Estado.ForeColor = Color.White;
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Location = new Point(78, 365);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(121, 29);
            cmb_Estado.TabIndex = 8;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.White;
            btn_Aceptar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Aceptar.ForeColor = Color.SteelBlue;
            btn_Aceptar.Location = new Point(353, 288);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(121, 71);
            btn_Aceptar.TabIndex = 9;
            btn_Aceptar.Text = "ACEPTAR";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.White;
            btn_Buscar.FlatAppearance.BorderSize = 0;
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Buscar.ForeColor = Color.SteelBlue;
            btn_Buscar.Location = new Point(128, 284);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(105, 28);
            btn_Buscar.TabIndex = 10;
            btn_Buscar.Text = "MODIFICAR";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // dtg_Reparaciones
            // 
            dtg_Reparaciones.AllowUserToAddRows = false;
            dtg_Reparaciones.AllowUserToDeleteRows = false;
            dtg_Reparaciones.AllowUserToResizeColumns = false;
            dtg_Reparaciones.AllowUserToResizeRows = false;
            dtg_Reparaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Reparaciones.BackgroundColor = Color.SteelBlue;
            dtg_Reparaciones.BorderStyle = BorderStyle.None;
            dtg_Reparaciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_Reparaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_Reparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_Reparaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_Reparaciones.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_Reparaciones.EnableHeadersVisualStyles = false;
            dtg_Reparaciones.GridColor = Color.White;
            dtg_Reparaciones.Location = new Point(12, 12);
            dtg_Reparaciones.Name = "dtg_Reparaciones";
            dtg_Reparaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtg_Reparaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtg_Reparaciones.RowHeadersVisible = false;
            dtg_Reparaciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_Reparaciones.RowTemplate.Height = 25;
            dtg_Reparaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Reparaciones.Size = new Size(569, 256);
            dtg_Reparaciones.TabIndex = 11;
            dtg_Reparaciones.CellContentClick += dtg_Reparaciones_CellContentClick;
            // 
            // Form_ModificarReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(666, 657);
            Controls.Add(dtg_Reparaciones);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Aceptar);
            Controls.Add(cmb_Estado);
            Controls.Add(txt_Precio);
            Controls.Add(txt_Presupuesto);
            Controls.Add(txt_CodigoSerie);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ModificarReparacion";
            Text = "Form_ModificarReparacion";
            Load += Form_ModificarReparacion_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Reparaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_CodigoSerie;
        private TextBox txt_Presupuesto;
        private TextBox txt_Precio;
        private ComboBox cmb_Estado;
        private Button btn_Aceptar;
        private Button btn_Buscar;
        private DataGridView dtg_Reparaciones;
    }
}