namespace ControlDePresencia
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblReloj = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.errPrincpial = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errPrincpial)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(53, 43);
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(214, 33);
            this.txtDni.TabIndex = 0;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtDni, "Introduce DNI");
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(122, 98);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(71, 27);
            this.lblReloj.TabIndex = 7;
            this.lblReloj.Text = "label1";
            this.lblReloj.Click += new System.EventHandler(this.lblReloj_Click);
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick_1);
            // 
            // errPrincpial
            // 
            this.errPrincpial.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPrincpial.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.ToolTipText = "Accede al panel de mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPermanencia.BackgroundImage = global::ControlDePresencia.Properties.Resources.permanencia;
            this.btnPermanencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPermanencia.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(179, 230);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(88, 75);
            this.btnPermanencia.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnPermanencia, "Accede a Permanencia");
            this.btnPermanencia.UseVisualStyleBackColor = false;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPresencia.BackgroundImage = global::ControlDePresencia.Properties.Resources.presencia;
            this.btnPresencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPresencia.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(53, 230);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(88, 75);
            this.btnPresencia.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnPresencia, "Accede a Presencia");
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalida.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalida.BackgroundImage = global::ControlDePresencia.Properties.Resources.btonsalida1__2_;
            this.btnSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalida.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalida.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(179, 148);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(88, 75);
            this.btnSalida.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSalida, "Pulsa para terminar el fichaje");
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // lblEntrada
            // 
            this.lblEntrada.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblEntrada.BackgroundImage = global::ControlDePresencia.Properties.Resources.btonentrada1;
            this.lblEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lblEntrada.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(53, 148);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(88, 75);
            this.lblEntrada.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lblEntrada, "Pulsa para fichar");
            this.lblEntrada.UseVisualStyleBackColor = false;
            this.lblEntrada.Click += new System.EventHandler(this.lblEntrada_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(322, 329);
            this.ControlBox = false;
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Control De Presencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPrincpial)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Button lblEntrada;

        private System.Windows.Forms.Timer tmrReloj;

        private System.Windows.Forms.ErrorProvider errPrincpial;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

