namespace ControlDePresencia
{
    partial class FormDatos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cbxAlta = new System.Windows.Forms.CheckBox();
            this.cbxAdministrador = new System.Windows.Forms.CheckBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.errpDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errpDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(114, 51);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 24);
            this.txtNombre.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNombre, "Introduce nombre");
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(114, 81);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(157, 24);
            this.txtApellido.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtApellido, "Introduce apellido");
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(114, 113);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(157, 24);
            this.txtContraseña.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtContraseña, "Introduce contraseña");
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(21, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.Location = new System.Drawing.Point(21, 121);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(88, 19);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(21, 89);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(67, 19);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // cbxAlta
            // 
            this.cbxAlta.AutoSize = true;
            this.cbxAlta.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxAlta.Location = new System.Drawing.Point(3, 5);
            this.cbxAlta.Name = "cbxAlta";
            this.cbxAlta.Size = new System.Drawing.Size(57, 23);
            this.cbxAlta.TabIndex = 0;
            this.cbxAlta.Text = "Alta";
            this.toolTip1.SetToolTip(this.cbxAlta, "Seleccion para dar alta");
            this.cbxAlta.UseVisualStyleBackColor = true;
            // 
            // cbxAdministrador
            // 
            this.cbxAdministrador.AutoSize = true;
            this.cbxAdministrador.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxAdministrador.Location = new System.Drawing.Point(3, 43);
            this.cbxAdministrador.Name = "cbxAdministrador";
            this.cbxAdministrador.Size = new System.Drawing.Size(130, 23);
            this.cbxAdministrador.TabIndex = 1;
            this.cbxAdministrador.Text = "Administrador";
            this.toolTip1.SetToolTip(this.cbxAdministrador, "Seleccion para ser admin");
            this.cbxAdministrador.UseVisualStyleBackColor = true;
            this.cbxAdministrador.CheckedChanged += new System.EventHandler(this.cbxAdministrador_CheckedChanged);
            this.cbxAdministrador.CheckStateChanged += new System.EventHandler(this.cbxAdministrador_CheckStateChanged);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNif.Location = new System.Drawing.Point(21, 23);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(34, 19);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF";
            // 
            // txtNif
            // 
            this.txtNif.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(114, 18);
            this.txtNif.Multiline = true;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(157, 24);
            this.txtNif.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNif, "Introducir DNI");
            // 
            // errpDatos
            // 
            this.errpDatos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errpDatos.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.cbxAdministrador);
            this.panel1.Controls.Add(this.cbxAlta);
            this.panel1.Location = new System.Drawing.Point(297, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 68);
            this.panel1.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.BackgroundImage = global::ControlDePresencia.Properties.Resources.volver_48px;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(390, 99);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 54);
            this.btnSalir.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnSalir, "Pulsa para volver");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEnviar.BackgroundImage = global::ControlDePresencia.Properties.Resources.enviar1_48;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnviar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(297, 99);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(49, 54);
            this.btnEnviar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnEnviar, "Enviar datos");
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(455, 155);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDatos";
            this.ShowIcon = false;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FormDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox cbxAlta;
        private System.Windows.Forms.CheckBox cbxAdministrador;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.ErrorProvider errpDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}