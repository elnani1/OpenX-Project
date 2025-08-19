namespace OpenX_Interfaces
{
    partial class FormularioReglamentario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioReglamentario));
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.cbxUsuarios = new System.Windows.Forms.ComboBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnGuardarRegla = new System.Windows.Forms.Button();
            this.dgvReglas = new System.Windows.Forms.DataGridView();
            this.btnEliminarRegla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReglas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(303, 714);
            this.cbxDispositivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(160, 29);
            this.cbxDispositivos.TabIndex = 0;
            // 
            // cbxUsuarios
            // 
            this.cbxUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsuarios.FormattingEnabled = true;
            this.cbxUsuarios.Location = new System.Drawing.Point(61, 714);
            this.cbxUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxUsuarios.Name = "cbxUsuarios";
            this.cbxUsuarios.Size = new System.Drawing.Size(160, 29);
            this.cbxUsuarios.TabIndex = 1;
            // 
            // txtHorario
            // 
            this.txtHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(192, 784);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(132, 29);
            this.txtHorario.TabIndex = 2;
            // 
            // btnGuardarRegla
            // 
            this.btnGuardarRegla.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardarRegla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarRegla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRegla.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRegla.Location = new System.Drawing.Point(39, 838);
            this.btnGuardarRegla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarRegla.Name = "btnGuardarRegla";
            this.btnGuardarRegla.Size = new System.Drawing.Size(133, 28);
            this.btnGuardarRegla.TabIndex = 3;
            this.btnGuardarRegla.Text = "Guardar Regla";
            this.btnGuardarRegla.UseVisualStyleBackColor = false;
            this.btnGuardarRegla.Click += new System.EventHandler(this.btnGuardarRegla_Click);
            // 
            // dgvReglas
            // 
            this.dgvReglas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReglas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReglas.GridColor = System.Drawing.Color.Black;
            this.dgvReglas.Location = new System.Drawing.Point(55, 463);
            this.dgvReglas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReglas.Name = "dgvReglas";
            this.dgvReglas.ReadOnly = true;
            this.dgvReglas.RowHeadersWidth = 51;
            this.dgvReglas.Size = new System.Drawing.Size(403, 185);
            this.dgvReglas.TabIndex = 5;
            // 
            // btnEliminarRegla
            // 
            this.btnEliminarRegla.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarRegla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarRegla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegla.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegla.Location = new System.Drawing.Point(357, 838);
            this.btnEliminarRegla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarRegla.Name = "btnEliminarRegla";
            this.btnEliminarRegla.Size = new System.Drawing.Size(133, 28);
            this.btnEliminarRegla.TabIndex = 6;
            this.btnEliminarRegla.Text = "Eliminar Regla";
            this.btnEliminarRegla.UseVisualStyleBackColor = false;
            this.btnEliminarRegla.Click += new System.EventHandler(this.btnEliminarRegla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(61, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 311);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(227, 905);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 17);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = ".";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(192, 838);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(133, 28);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar Regla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormularioReglamentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(512, 1013);
            this.ControlBox = false;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarRegla);
            this.Controls.Add(this.dgvReglas);
            this.Controls.Add(this.btnGuardarRegla);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.cbxUsuarios);
            this.Controls.Add(this.cbxDispositivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioReglamentario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioReglamentario";
            this.Load += new System.EventHandler(this.FormularioReglamentario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReglas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.ComboBox cbxUsuarios;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnGuardarRegla;
        private System.Windows.Forms.DataGridView dgvReglas;
        private System.Windows.Forms.Button btnEliminarRegla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
    }
}