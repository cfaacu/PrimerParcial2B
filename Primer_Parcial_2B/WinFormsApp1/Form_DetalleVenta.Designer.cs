namespace Formularios
{
    partial class Form_DetalleVenta
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dtg_Listado = new DataGridView();
            lbl_NumeroVenta = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_Listado).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtg_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtg_Listado.ColumnHeadersHeight = 29;
            dtg_Listado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.SteelBlue;
            dataGridViewCellStyle5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtg_Listado.DefaultCellStyle = dataGridViewCellStyle5;
            dtg_Listado.EnableHeadersVisualStyles = false;
            dtg_Listado.GridColor = Color.White;
            dtg_Listado.Location = new Point(37, 58);
            dtg_Listado.Name = "dtg_Listado";
            dtg_Listado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SteelBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtg_Listado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtg_Listado.RowHeadersVisible = false;
            dtg_Listado.RowHeadersWidth = 51;
            dtg_Listado.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_Listado.RowTemplate.Height = 25;
            dtg_Listado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Listado.Size = new Size(613, 238);
            dtg_Listado.TabIndex = 1;
            // 
            // lbl_NumeroVenta
            // 
            lbl_NumeroVenta.AutoSize = true;
            lbl_NumeroVenta.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NumeroVenta.Location = new Point(37, 21);
            lbl_NumeroVenta.Name = "lbl_NumeroVenta";
            lbl_NumeroVenta.Size = new Size(63, 25);
            lbl_NumeroVenta.TabIndex = 2;
            lbl_NumeroVenta.Text = "label1";
            // 
            // Form_DetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_NumeroVenta);
            Controls.Add(dtg_Listado);
            Name = "Form_DetalleVenta";
            Text = "Form_DetalleVenta";
            Load += Form_DetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Listado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_Listado;
        private Label lbl_NumeroVenta;
    }
}