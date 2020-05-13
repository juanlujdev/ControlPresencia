namespace ControlDePresencia
{
    partial class FormMantenimiento
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
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.btnPurga = new System.Windows.Forms.Button();
            this.txtCerrar = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(526, 24);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(91, 64);
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(526, 94);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(91, 64);
            this.btnEliminarEmpleado.TabIndex = 2;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.GridColor = System.Drawing.Color.LightBlue;
            this.dgvEmpleados.Location = new System.Drawing.Point(25, 24);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.ShowCellToolTips = false;
            this.dgvEmpleados.Size = new System.Drawing.Size(447, 203);
            this.dgvEmpleados.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dgvEmpleados, "Haz doble click en una celda para eliminar a un usuario de la base de datos");
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentDoubleClick);
            this.dgvEmpleados.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellMouseEnter);
            this.dgvEmpleados.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleados_CellMouseUp);
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.GridColor = System.Drawing.Color.LightBlue;
            this.dgvFichajes.Location = new System.Drawing.Point(25, 249);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.ReadOnly = true;
            this.dgvFichajes.RowHeadersVisible = false;
            this.dgvFichajes.ShowCellToolTips = false;
            this.dgvFichajes.Size = new System.Drawing.Size(447, 203);
            this.dgvFichajes.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dgvFichajes, "Selecciona un DNI para filtrar");
            this.dgvFichajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichajes_CellContentClick);
            // 
            // btnPurga
            // 
            this.btnPurga.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPurga.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurga.Location = new System.Drawing.Point(526, 163);
            this.btnPurga.Name = "btnPurga";
            this.btnPurga.Size = new System.Drawing.Size(91, 64);
            this.btnPurga.TabIndex = 3;
            this.btnPurga.Text = "Borrar/Purgar";
            this.btnPurga.UseVisualStyleBackColor = false;
            // 
            // txtCerrar
            // 
            this.txtCerrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtCerrar.BackgroundImage = global::ControlDePresencia.Properties.Resources.apagar;
            this.txtCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtCerrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerrar.Location = new System.Drawing.Point(511, 375);
            this.txtCerrar.Name = "txtCerrar";
            this.txtCerrar.Size = new System.Drawing.Size(119, 77);
            this.txtCerrar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtCerrar, "Cerrar aplicacion");
            this.txtCerrar.UseVisualStyleBackColor = false;
            this.txtCerrar.Click += new System.EventHandler(this.txtCerrar_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalida.BackgroundImage = global::ControlDePresencia.Properties.Resources.volver2;
            this.btnSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalida.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(526, 303);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(91, 64);
            this.btnSalida.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSalida, "Pulsa para volver");
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInforme.BackgroundImage = global::ControlDePresencia.Properties.Resources.consulta_busqueda1;
            this.btnInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInforme.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInforme.Location = new System.Drawing.Point(526, 233);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(91, 64);
            this.btnInforme.TabIndex = 4;
            this.btnInforme.TabStop = false;
            this.toolTip1.SetToolTip(this.btnInforme, "Visualiza datos");
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // FormMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(657, 463);
            this.ControlBox = false;
            this.Controls.Add(this.btnPurga);
            this.Controls.Add(this.txtCerrar);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.dgvFichajes);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMantenimiento";
            this.Text = "Panel De Mantenimiento";
            this.Load += new System.EventHandler(this.FormMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvFichajes;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button txtCerrar;
        private System.Windows.Forms.Button btnPurga;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}