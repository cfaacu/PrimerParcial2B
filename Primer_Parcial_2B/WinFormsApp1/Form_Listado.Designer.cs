namespace Formularios
{
    partial class Form_Listado
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
            dtg_Listado = new DataGridView();
            lbl_Total = new Label();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_Listado.ColumnHeadersHeight = 29;
            dtg_Listado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_Listado.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_Listado.EnableHeadersVisualStyles = false;
            dtg_Listado.GridColor = Color.White;
            dtg_Listado.Location = new Point(29, 29);
            dtg_Listado.Margin = new Padding(3, 4, 3, 4);
            dtg_Listado.Name = "dtg_Listado";
            dtg_Listado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtg_Listado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtg_Listado.RowHeadersVisible = false;
            dtg_Listado.RowHeadersWidth = 51;
            dtg_Listado.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_Listado.RowTemplate.Height = 25;
            dtg_Listado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Listado.Size = new Size(701, 317);
            dtg_Listado.TabIndex = 0;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Total.ForeColor = Color.White;
            lbl_Total.Location = new Point(62, 383);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(107, 54);
            lbl_Total.TabIndex = 1;
            lbl_Total.Text = "Total";
            lbl_Total.Visible = false;
            // 
            // Form_Listado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(993, 664);
            Controls.Add(lbl_Total);
            Controls.Add(dtg_Listado);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Listado";
            Text = "Form_Listado";
            Load += Form_Listado_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Listado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_Listado;
        private Label lbl_Total;
    }
}