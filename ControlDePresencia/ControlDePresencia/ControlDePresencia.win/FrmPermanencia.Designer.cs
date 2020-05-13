namespace ControlDePresencia
{
    partial class FrmPermanencia
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
            this.components = new System.ComponentModel.Container();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.dgvPermanencia = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblMostrarDni = new System.Windows.Forms.Label();
            this.errPemanencia = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermanencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPemanencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(166, 21);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha1.TabIndex = 0;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(390, 21);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha2.TabIndex = 1;
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.Location = new System.Drawing.Point(52, 21);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(73, 20);
            this.lblFecha1.TabIndex = 2;
            this.lblFecha1.Text = "1ª Fecha";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.Location = new System.Drawing.Point(290, 21);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(73, 20);
            this.lblFecha2.TabIndex = 3;
            this.lblFecha2.Text = "2ª Fecha";
            // 
            // dgvPermanencia
            // 
            this.dgvPermanencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermanencia.Location = new System.Drawing.Point(47, 105);
            this.dgvPermanencia.Name = "dgvPermanencia";
            this.dgvPermanencia.Size = new System.Drawing.Size(440, 249);
            this.dgvPermanencia.TabIndex = 4;
            this.dgvPermanencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermanencia_CellClick);
            this.dgvPermanencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermanencia_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(95, 369);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 41);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(320, 369);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 41);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(69, 73);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(139, 16);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "DNI del Empleado:";
            // 
            // lblMostrarDni
            // 
            this.lblMostrarDni.AutoSize = true;
            this.lblMostrarDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDni.Location = new System.Drawing.Point(253, 73);
            this.lblMostrarDni.Name = "lblMostrarDni";
            this.lblMostrarDni.Size = new System.Drawing.Size(45, 16);
            this.lblMostrarDni.TabIndex = 8;
            this.lblMostrarDni.Text = "label1";
            // 
            // errPemanencia
            // 
            this.errPemanencia.ContainerControl = this;
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 446);
            this.ControlBox = false;
            this.Controls.Add(this.lblMostrarDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvPermanencia);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.dtpFecha1);
            this.Name = "FrmPermanencia";
            this.Text = "Ventana Permanencia";
            this.Load += new System.EventHandler(this.FrmPermanencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermanencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPemanencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.DataGridView dgvPermanencia;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblMostrarDni;
        private System.Windows.Forms.ErrorProvider errPemanencia;
    }
}