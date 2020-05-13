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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblMostrarDni = new System.Windows.Forms.Label();
            this.errPemanencia = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermanencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPemanencia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(105, 19);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(97, 24);
            this.dtpFecha1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dtpFecha1, "Introduce fecha");
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(303, 20);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(97, 24);
            this.dtpFecha2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dtpFecha2, "Introduce fecha");
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha1.Location = new System.Drawing.Point(24, 24);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(68, 19);
            this.lblFecha1.TabIndex = 0;
            this.lblFecha1.Text = "1ª Fecha";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha2.Location = new System.Drawing.Point(222, 25);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(68, 19);
            this.lblFecha2.TabIndex = 2;
            this.lblFecha2.Text = "2ª Fecha";
            // 
            // dgvPermanencia
            // 
            this.dgvPermanencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermanencia.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPermanencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermanencia.GridColor = System.Drawing.Color.LightBlue;
            this.dgvPermanencia.Location = new System.Drawing.Point(47, 122);
            this.dgvPermanencia.Name = "dgvPermanencia";
            this.dgvPermanencia.ShowCellToolTips = false;
            this.dgvPermanencia.Size = new System.Drawing.Size(440, 232);
            this.dgvPermanencia.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dgvPermanencia, "Haz click para calcular tiempo");
            this.dgvPermanencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermanencia_CellClick);
            this.dgvPermanencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermanencia_CellContentClick);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDni.Location = new System.Drawing.Point(24, 71);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(139, 19);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI del Empleado:";
            // 
            // lblMostrarDni
            // 
            this.lblMostrarDni.AutoSize = true;
            this.lblMostrarDni.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMostrarDni.Location = new System.Drawing.Point(222, 71);
            this.lblMostrarDni.Name = "lblMostrarDni";
            this.lblMostrarDni.Size = new System.Drawing.Size(51, 19);
            this.lblMostrarDni.TabIndex = 5;
            this.lblMostrarDni.Text = "label1";
            // 
            // errPemanencia
            // 
            this.errPemanencia.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblMostrarDni);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblFecha2);
            this.panel1.Controls.Add(this.lblFecha1);
            this.panel1.Controls.Add(this.dtpFecha2);
            this.panel1.Controls.Add(this.dtpFecha1);
            this.panel1.Location = new System.Drawing.Point(47, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 103);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCerrar.BackgroundImage = global::ControlDePresencia.Properties.Resources.volver2;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(313, 360);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(79, 65);
            this.btnCerrar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCerrar, "Pulsa para volver");
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConsultar.BackgroundImage = global::ControlDePresencia.Properties.Resources.consulta_busqueda1;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(133, 360);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(79, 65);
            this.btnConsultar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnConsultar, "Visualiza datos");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(546, 446);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvPermanencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPermanencia";
            this.Text = "Ventana Permanencia";
            this.Load += new System.EventHandler(this.FrmPermanencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermanencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPemanencia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}