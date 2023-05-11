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
            dtg_Listado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_Listado).BeginInit();
            SuspendLayout();
            // 
            // dtg_Listado
            // 
            dtg_Listado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Listado.Location = new Point(41, 50);
            dtg_Listado.Name = "dtg_Listado";
            dtg_Listado.RowTemplate.Height = 25;
            dtg_Listado.Size = new Size(417, 353);
            dtg_Listado.TabIndex = 0;
            // 
            // Form_Listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(dtg_Listado);
            Name = "Form_Listado";
            Text = "Form_Listado";
            Load += Form_Listado_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Listado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_Listado;
    }
}