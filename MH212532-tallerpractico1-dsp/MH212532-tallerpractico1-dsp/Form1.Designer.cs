
namespace MH212532_tallerpractico1_dsp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNombreCine = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnApartar = new System.Windows.Forms.Button();
            this.btnCancelarReservacion = new System.Windows.Forms.Button();
            this.lbEslogan = new System.Windows.Forms.Label();
            this.lbReservado = new System.Windows.Forms.Label();
            this.lbLibre = new System.Windows.Forms.Label();
            this.ptbButaca = new System.Windows.Forms.PictureBox();
            this.ptbCine = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbButaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5,
            this.columna6});
            this.dataGridView1.Location = new System.Drawing.Point(7, 111);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(965, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columna1
            // 
            this.columna1.HeaderText = "1";
            this.columna1.MinimumWidth = 8;
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 150;
            // 
            // columna2
            // 
            this.columna2.HeaderText = "2";
            this.columna2.MinimumWidth = 8;
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            this.columna2.Width = 150;
            // 
            // columna3
            // 
            this.columna3.HeaderText = "3";
            this.columna3.MinimumWidth = 8;
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            this.columna3.Width = 150;
            // 
            // columna4
            // 
            this.columna4.HeaderText = "4";
            this.columna4.MinimumWidth = 8;
            this.columna4.Name = "columna4";
            this.columna4.ReadOnly = true;
            this.columna4.Width = 150;
            // 
            // columna5
            // 
            this.columna5.HeaderText = "5";
            this.columna5.MinimumWidth = 8;
            this.columna5.Name = "columna5";
            this.columna5.ReadOnly = true;
            this.columna5.Width = 150;
            // 
            // columna6
            // 
            this.columna6.HeaderText = "6";
            this.columna6.MinimumWidth = 8;
            this.columna6.Name = "columna6";
            this.columna6.ReadOnly = true;
            this.columna6.Width = 150;
            // 
            // lbNombreCine
            // 
            this.lbNombreCine.AutoSize = true;
            this.lbNombreCine.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(2)))), ((int)(((byte)(7)))));
            this.lbNombreCine.Location = new System.Drawing.Point(114, 5);
            this.lbNombreCine.Name = "lbNombreCine";
            this.lbNombreCine.Size = new System.Drawing.Size(447, 54);
            this.lbNombreCine.TabIndex = 1;
            this.lbNombreCine.Text = "Cine Los Aventurados";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(118, 77);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(308, 28);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Sistema de asignación de asientos";
            // 
            // btnApartar
            // 
            this.btnApartar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.btnApartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.btnApartar.Location = new System.Drawing.Point(7, 438);
            this.btnApartar.Name = "btnApartar";
            this.btnApartar.Size = new System.Drawing.Size(194, 86);
            this.btnApartar.TabIndex = 3;
            this.btnApartar.Text = "Reservar asiento";
            this.btnApartar.UseVisualStyleBackColor = false;
            this.btnApartar.Click += new System.EventHandler(this.btnApartar_Click);
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.btnCancelarReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.btnCancelarReservacion.Location = new System.Drawing.Point(218, 438);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(222, 86);
            this.btnCancelarReservacion.TabIndex = 4;
            this.btnCancelarReservacion.Text = "Cancelar reservación";
            this.btnCancelarReservacion.UseVisualStyleBackColor = false;
            this.btnCancelarReservacion.Click += new System.EventHandler(this.btnCancelarReservacion_Click);
            // 
            // lbEslogan
            // 
            this.lbEslogan.AutoSize = true;
            this.lbEslogan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEslogan.Location = new System.Drawing.Point(118, 49);
            this.lbEslogan.Name = "lbEslogan";
            this.lbEslogan.Size = new System.Drawing.Size(658, 28);
            this.lbEslogan.TabIndex = 6;
            this.lbEslogan.Text = "\"Siempre tu opción de entretenimiento, a la punta de la tecnología\"";
            this.lbEslogan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbReservado
            // 
            this.lbReservado.AutoSize = true;
            this.lbReservado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.lbReservado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservado.Location = new System.Drawing.Point(847, 438);
            this.lbReservado.Name = "lbReservado";
            this.lbReservado.Size = new System.Drawing.Size(124, 32);
            this.lbReservado.TabIndex = 7;
            this.lbReservado.Text = "Reservado";
            // 
            // lbLibre
            // 
            this.lbLibre.AutoSize = true;
            this.lbLibre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.lbLibre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibre.Location = new System.Drawing.Point(847, 492);
            this.lbLibre.Name = "lbLibre";
            this.lbLibre.Size = new System.Drawing.Size(67, 32);
            this.lbLibre.TabIndex = 8;
            this.lbLibre.Text = "Libre";
            // 
            // ptbButaca
            // 
            this.ptbButaca.Image = global::MH212532_tallerpractico1_dsp.Properties.Resources.sillon;
            this.ptbButaca.Location = new System.Drawing.Point(726, 438);
            this.ptbButaca.Name = "ptbButaca";
            this.ptbButaca.Size = new System.Drawing.Size(100, 86);
            this.ptbButaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbButaca.TabIndex = 9;
            this.ptbButaca.TabStop = false;
            // 
            // ptbCine
            // 
            this.ptbCine.Image = global::MH212532_tallerpractico1_dsp.Properties.Resources.cine;
            this.ptbCine.Location = new System.Drawing.Point(12, 5);
            this.ptbCine.Name = "ptbCine";
            this.ptbCine.Size = new System.Drawing.Size(100, 100);
            this.ptbCine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCine.TabIndex = 5;
            this.ptbCine.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.btnSalir.Location = new System.Drawing.Point(463, 438);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(222, 86);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(201)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(984, 545);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.ptbButaca);
            this.Controls.Add(this.lbLibre);
            this.Controls.Add(this.lbReservado);
            this.Controls.Add(this.lbEslogan);
            this.Controls.Add(this.ptbCine);
            this.Controls.Add(this.btnCancelarReservacion);
            this.Controls.Add(this.btnApartar);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbNombreCine);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cine Los Aventurados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbButaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna6;
        private System.Windows.Forms.Label lbNombreCine;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnApartar;
        private System.Windows.Forms.Button btnCancelarReservacion;
        private System.Windows.Forms.PictureBox ptbCine;
        private System.Windows.Forms.Label lbEslogan;
        private System.Windows.Forms.Label lbReservado;
        private System.Windows.Forms.Label lbLibre;
        private System.Windows.Forms.PictureBox ptbButaca;
        private System.Windows.Forms.Button btnSalir;
    }
}

