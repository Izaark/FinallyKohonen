namespace KohonenFinal
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquitecturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirKohonenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerArquitecturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gragicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propagarNeuronasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicarEntrenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbGrafica = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquitecturaToolStripMenuItem,
            this.gragicarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquitecturaToolStripMenuItem
            // 
            this.arquitecturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirKohonenToolStripMenuItem,
            this.leerArquitecturaToolStripMenuItem1});
            this.arquitecturaToolStripMenuItem.Name = "arquitecturaToolStripMenuItem";
            this.arquitecturaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.arquitecturaToolStripMenuItem.Text = "Arquitectura";
            // 
            // abrirKohonenToolStripMenuItem
            // 
            this.abrirKohonenToolStripMenuItem.Name = "abrirKohonenToolStripMenuItem";
            this.abrirKohonenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.abrirKohonenToolStripMenuItem.Text = "Abrir Kohonen";
            this.abrirKohonenToolStripMenuItem.Click += new System.EventHandler(this.abrirKohonenToolStripMenuItem_Click);
            // 
            // leerArquitecturaToolStripMenuItem1
            // 
            this.leerArquitecturaToolStripMenuItem1.Name = "leerArquitecturaToolStripMenuItem1";
            this.leerArquitecturaToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.leerArquitecturaToolStripMenuItem1.Text = "Leer Arquitectura";
            this.leerArquitecturaToolStripMenuItem1.Click += new System.EventHandler(this.leerArquitecturaToolStripMenuItem1_Click);
            // 
            // gragicarToolStripMenuItem
            // 
            this.gragicarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propagarNeuronasToolStripMenuItem,
            this.inicarEntrenamientoToolStripMenuItem});
            this.gragicarToolStripMenuItem.Name = "gragicarToolStripMenuItem";
            this.gragicarToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.gragicarToolStripMenuItem.Text = "Neuronas Kohonen";
            // 
            // propagarNeuronasToolStripMenuItem
            // 
            this.propagarNeuronasToolStripMenuItem.Name = "propagarNeuronasToolStripMenuItem";
            this.propagarNeuronasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.propagarNeuronasToolStripMenuItem.Text = "Graficar Neuronas";
            this.propagarNeuronasToolStripMenuItem.Click += new System.EventHandler(this.propagarNeuronasToolStripMenuItem_Click);
            // 
            // inicarEntrenamientoToolStripMenuItem
            // 
            this.inicarEntrenamientoToolStripMenuItem.Name = "inicarEntrenamientoToolStripMenuItem";
            this.inicarEntrenamientoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.inicarEntrenamientoToolStripMenuItem.Text = "Inicar Entrenamiento";
            this.inicarEntrenamientoToolStripMenuItem.Click += new System.EventHandler(this.inicarEntrenamientoToolStripMenuItem_Click);
            // 
            // pbGrafica
            // 
            this.pbGrafica.BackColor = System.Drawing.SystemColors.InfoText;
            this.pbGrafica.Location = new System.Drawing.Point(0, 61);
            this.pbGrafica.Name = "pbGrafica";
            this.pbGrafica.Size = new System.Drawing.Size(490, 280);
            this.pbGrafica.TabIndex = 7;
            this.pbGrafica.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mapas Autoorganizados de Kohonen";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(400, 27);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(89, 35);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(490, 341);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGrafica);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "te";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquitecturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirKohonenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerArquitecturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gragicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propagarNeuronasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicarEntrenamientoToolStripMenuItem;
        public System.Windows.Forms.PictureBox pbGrafica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

