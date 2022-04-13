namespace ConsultasSQL
{
    partial class FrmCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorreo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorreoA = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pcCorreo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHostA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPortA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSslA = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblSsl = new System.Windows.Forms.Label();
            this.cmbSsl = new System.Windows.Forms.ComboBox();
            this.linkPassword = new System.Windows.Forms.LinkLabel();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblErrorMessagge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcCorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo del remitente";
            // 
            // lblCorreoA
            // 
            this.lblCorreoA.AutoSize = true;
            this.lblCorreoA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoA.ForeColor = System.Drawing.Color.White;
            this.lblCorreoA.Location = new System.Drawing.Point(24, 127);
            this.lblCorreoA.Name = "lblCorreoA";
            this.lblCorreoA.Size = new System.Drawing.Size(138, 22);
            this.lblCorreoA.TabIndex = 2;
            this.lblCorreoA.Text = "Correo actual";
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnCambiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCambiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCambiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.Silver;
            this.btnCambiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiar.Image")));
            this.btnCambiar.Location = new System.Drawing.Point(73, 366);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(105, 34);
            this.btnCambiar.TabIndex = 29;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(283, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 27);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Visible = false;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(509, 201);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(186, 27);
            this.txtClave.TabIndex = 5;
            this.txtClave.Visible = false;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.LightGray;
            this.lblCorreo.Location = new System.Drawing.Point(279, 81);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(67, 21);
            this.lblCorreo.TabIndex = 32;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.Visible = false;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.LightGray;
            this.lblContraseña.Location = new System.Drawing.Point(505, 167);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(107, 21);
            this.lblContraseña.TabIndex = 33;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(297, 356);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pcCorreo
            // 
            this.pcCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pcCorreo.Location = new System.Drawing.Point(244, 73);
            this.pcCorreo.Name = "pcCorreo";
            this.pcCorreo.Size = new System.Drawing.Size(3, 327);
            this.pcCorreo.TabIndex = 35;
            this.pcCorreo.TabStop = false;
            this.pcCorreo.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(529, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(26, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Host";
            // 
            // lblHostA
            // 
            this.lblHostA.AutoSize = true;
            this.lblHostA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostA.ForeColor = System.Drawing.Color.White;
            this.lblHostA.Location = new System.Drawing.Point(24, 188);
            this.lblHostA.Name = "lblHostA";
            this.lblHostA.Size = new System.Drawing.Size(48, 22);
            this.lblHostA.TabIndex = 38;
            this.lblHostA.Text = "host";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(24, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Puerto";
            // 
            // lblPortA
            // 
            this.lblPortA.AutoSize = true;
            this.lblPortA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortA.ForeColor = System.Drawing.Color.White;
            this.lblPortA.Location = new System.Drawing.Point(26, 245);
            this.lblPortA.Name = "lblPortA";
            this.lblPortA.Size = new System.Drawing.Size(46, 22);
            this.lblPortA.TabIndex = 40;
            this.lblPortA.Text = "Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(26, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "SSL";
            // 
            // lblSslA
            // 
            this.lblSslA.AutoSize = true;
            this.lblSslA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSslA.ForeColor = System.Drawing.Color.White;
            this.lblSslA.Location = new System.Drawing.Point(26, 301);
            this.lblSslA.Name = "lblSslA";
            this.lblSslA.Size = new System.Drawing.Size(27, 22);
            this.lblSslA.TabIndex = 42;
            this.lblSslA.Text = "ssl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(18, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 43;
            this.label10.Text = "Detalles ";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.ForeColor = System.Drawing.Color.LightGray;
            this.lblHost.Location = new System.Drawing.Point(279, 167);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(48, 21);
            this.lblHost.TabIndex = 44;
            this.lblHost.Text = "Host:";
            this.lblHost.Visible = false;
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(283, 201);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(186, 27);
            this.txtHost.TabIndex = 2;
            this.txtHost.Visible = false;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.ForeColor = System.Drawing.Color.LightGray;
            this.lblPuerto.Location = new System.Drawing.Point(279, 246);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(65, 21);
            this.lblPuerto.TabIndex = 46;
            this.lblPuerto.Text = "Puerto:";
            this.lblPuerto.Visible = false;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(283, 277);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(189, 27);
            this.txtPort.TabIndex = 3;
            this.txtPort.Visible = false;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // lblSsl
            // 
            this.lblSsl.AutoSize = true;
            this.lblSsl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSsl.ForeColor = System.Drawing.Color.LightGray;
            this.lblSsl.Location = new System.Drawing.Point(505, 81);
            this.lblSsl.Name = "lblSsl";
            this.lblSsl.Size = new System.Drawing.Size(37, 21);
            this.lblSsl.TabIndex = 48;
            this.lblSsl.Text = "SSL:";
            this.lblSsl.Visible = false;
            // 
            // cmbSsl
            // 
            this.cmbSsl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSsl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSsl.FormattingEnabled = true;
            this.cmbSsl.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbSsl.Location = new System.Drawing.Point(513, 115);
            this.cmbSsl.Name = "cmbSsl";
            this.cmbSsl.Size = new System.Drawing.Size(121, 25);
            this.cmbSsl.TabIndex = 4;
            this.cmbSsl.Visible = false;
            // 
            // linkPassword
            // 
            this.linkPassword.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.linkPassword.AutoSize = true;
            this.linkPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkPassword.Location = new System.Drawing.Point(629, 231);
            this.linkPassword.Name = "linkPassword";
            this.linkPassword.Size = new System.Drawing.Size(66, 17);
            this.linkPassword.TabIndex = 50;
            this.linkPassword.TabStop = true;
            this.linkPassword.Text = "Cambiar";
            this.linkPassword.Visible = false;
            this.linkPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPassword_LinkClicked);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.ForeColor = System.Drawing.Color.LightGray;
            this.lblConfirmar.Location = new System.Drawing.Point(505, 243);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(185, 21);
            this.lblConfirmar.TabIndex = 52;
            this.lblConfirmar.Text = "Confirmar contraseña:";
            this.lblConfirmar.Visible = false;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.Location = new System.Drawing.Point(509, 277);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(186, 27);
            this.txtConfirmar.TabIndex = 6;
            this.txtConfirmar.Visible = false;
            // 
            // lblErrorMessagge
            // 
            this.lblErrorMessagge.AutoSize = true;
            this.lblErrorMessagge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessagge.ForeColor = System.Drawing.Color.DarkGray;
            this.lblErrorMessagge.Image = global::ConsultasSQL.Properties.Resources.exclamation_mark;
            this.lblErrorMessagge.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMessagge.Location = new System.Drawing.Point(280, 316);
            this.lblErrorMessagge.Name = "lblErrorMessagge";
            this.lblErrorMessagge.Size = new System.Drawing.Size(115, 18);
            this.lblErrorMessagge.TabIndex = 53;
            this.lblErrorMessagge.Text = "Error Messagge";
            this.lblErrorMessagge.Visible = false;
            // 
            // FrmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorMessagge);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.linkPassword);
            this.Controls.Add(this.cmbSsl);
            this.Controls.Add(this.lblSsl);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSslA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPortA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHostA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pcCorreo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblCorreoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCorreo";
            this.Text = "FrmCorreo";
            this.Load += new System.EventHandler(this.FrmCorreo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcCorreo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorreoA;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pcCorreo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHostA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPortA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSslA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblSsl;
        private System.Windows.Forms.ComboBox cmbSsl;
        private System.Windows.Forms.LinkLabel linkPassword;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblErrorMessagge;
    }
}