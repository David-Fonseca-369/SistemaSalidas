namespace ConsultasSQL
{
    partial class FrmOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpciones));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.almacénToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaDeMaterialesParaInstalacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envíoDeMaterialAProducciónDelCLQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envíoDeMuestrasPorPaqueteríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasParaServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasParaServicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasParaServicioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacénToolStripMenuItem,
            this.producciónToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripDropDownButton1.Text = "Tipo de salida";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // almacénToolStripMenuItem
            // 
            this.almacénToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salidaDeMaterialesParaInstalacionesToolStripMenuItem});
            this.almacénToolStripMenuItem.Name = "almacénToolStripMenuItem";
            this.almacénToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.almacénToolStripMenuItem.Text = "Material de Almacén";
            // 
            // salidaDeMaterialesParaInstalacionesToolStripMenuItem
            // 
            this.salidaDeMaterialesParaInstalacionesToolStripMenuItem.Name = "salidaDeMaterialesParaInstalacionesToolStripMenuItem";
            this.salidaDeMaterialesParaInstalacionesToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.salidaDeMaterialesParaInstalacionesToolStripMenuItem.Text = "Salida de materiales para instalaciones";
            this.salidaDeMaterialesParaInstalacionesToolStripMenuItem.Click += new System.EventHandler(this.salidaDeMaterialesParaInstalacionesToolStripMenuItem_Click);
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envíoDeMaterialAProducciónDelCLQToolStripMenuItem,
            this.envíoDeMuestrasPorPaqueteríaToolStripMenuItem});
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.producciónToolStripMenuItem.Text = "material de Producción";
            // 
            // envíoDeMaterialAProducciónDelCLQToolStripMenuItem
            // 
            this.envíoDeMaterialAProducciónDelCLQToolStripMenuItem.Name = "envíoDeMaterialAProducciónDelCLQToolStripMenuItem";
            this.envíoDeMaterialAProducciónDelCLQToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.envíoDeMaterialAProducciónDelCLQToolStripMenuItem.Text = "Envío de material a producción del CLQ";
            // 
            // envíoDeMuestrasPorPaqueteríaToolStripMenuItem
            // 
            this.envíoDeMuestrasPorPaqueteríaToolStripMenuItem.Name = "envíoDeMuestrasPorPaqueteríaToolStripMenuItem";
            this.envíoDeMuestrasPorPaqueteríaToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.envíoDeMuestrasPorPaqueteríaToolStripMenuItem.Text = "Envío de muestras por paquetería";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tIToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.recursosHumanosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // tIToolStripMenuItem
            // 
            this.tIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasParaServicioToolStripMenuItem});
            this.tIToolStripMenuItem.Name = "tIToolStripMenuItem";
            this.tIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tIToolStripMenuItem.Text = "TI";
            // 
            // herramientasParaServicioToolStripMenuItem
            // 
            this.herramientasParaServicioToolStripMenuItem.Name = "herramientasParaServicioToolStripMenuItem";
            this.herramientasParaServicioToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.herramientasParaServicioToolStripMenuItem.Text = "Herramientas para servicio";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasParaServicioToolStripMenuItem1});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // herramientasParaServicioToolStripMenuItem1
            // 
            this.herramientasParaServicioToolStripMenuItem1.Name = "herramientasParaServicioToolStripMenuItem1";
            this.herramientasParaServicioToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.herramientasParaServicioToolStripMenuItem1.Text = "Herramientas para servicio";
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasParaServicioToolStripMenuItem2});
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recursosHumanosToolStripMenuItem.Text = "Recursos humanos";
            // 
            // herramientasParaServicioToolStripMenuItem2
            // 
            this.herramientasParaServicioToolStripMenuItem2.Name = "herramientasParaServicioToolStripMenuItem2";
            this.herramientasParaServicioToolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.herramientasParaServicioToolStripMenuItem2.Text = "Herramientas para servicio";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(76, 45);
            this.toolStripContainer1.Location = new System.Drawing.Point(177, 259);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(76, 70);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // FrmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmOpciones";
            this.Text = "90";
            this.Load += new System.EventHandler(this.FrmOpciones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem almacénToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem salidaDeMaterialesParaInstalacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envíoDeMaterialAProducciónDelCLQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envíoDeMuestrasPorPaqueteríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasParaServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasParaServicioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem herramientasParaServicioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}