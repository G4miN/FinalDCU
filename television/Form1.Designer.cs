namespace television
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblCountry = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.botoncircular10 = new television.botoncircular();
            this.dos = new television.botoncircular();
            this.cuatro = new television.botoncircular();
            this.uno = new television.botoncircular();
            this.seis = new television.botoncircular();
            this.tres = new television.botoncircular();
            this.cinco = new television.botoncircular();
            this.botoncircular2 = new television.botoncircular();
            this.botoncircular3 = new television.botoncircular();
            this.botoncircular1 = new television.botoncircular();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.siete = new television.botoncircular();
            this.ocho = new television.botoncircular();
            this.nueve = new television.botoncircular();
            this.cero = new television.botoncircular();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Black;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblCountry.Location = new System.Drawing.Point(522, 19);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(0, 29);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(437, 8);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(554, 338);
            this.Media.TabIndex = 0;
            this.Media.Enter += new System.EventHandler(this.Media_Enter);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.AliceBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(452, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(75, 29);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Canal";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(904, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 58);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(999, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 58);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // botoncircular10
            // 
            this.botoncircular10.BackColor = System.Drawing.Color.Transparent;
            this.botoncircular10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncircular10.ForeColor = System.Drawing.SystemColors.Control;
            this.botoncircular10.Location = new System.Drawing.Point(154, 145);
            this.botoncircular10.Name = "botoncircular10";
            this.botoncircular10.Size = new System.Drawing.Size(32, 30);
            this.botoncircular10.TabIndex = 29;
            this.botoncircular10.Text = "OK";
            this.botoncircular10.UseVisualStyleBackColor = false;
            this.botoncircular10.Click += new System.EventHandler(this.botoncircular10_Click);
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.Color.Transparent;
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dos.ForeColor = System.Drawing.SystemColors.Control;
            this.dos.Location = new System.Drawing.Point(161, 263);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(21, 25);
            this.dos.TabIndex = 28;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // cuatro
            // 
            this.cuatro.BackColor = System.Drawing.Color.Transparent;
            this.cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuatro.ForeColor = System.Drawing.SystemColors.Control;
            this.cuatro.Location = new System.Drawing.Point(133, 285);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(22, 23);
            this.cuatro.TabIndex = 27;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = false;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // uno
            // 
            this.uno.BackColor = System.Drawing.Color.Transparent;
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uno.ForeColor = System.Drawing.SystemColors.Control;
            this.uno.Location = new System.Drawing.Point(134, 263);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(23, 25);
            this.uno.TabIndex = 26;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            this.uno.Click += new System.EventHandler(this.botoncircular7_Click);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.Color.Transparent;
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seis.ForeColor = System.Drawing.SystemColors.Control;
            this.seis.Location = new System.Drawing.Point(188, 285);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(21, 21);
            this.seis.TabIndex = 25;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.Color.Transparent;
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tres.ForeColor = System.Drawing.SystemColors.Control;
            this.tres.Location = new System.Drawing.Point(187, 264);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(22, 22);
            this.tres.TabIndex = 24;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.Color.Transparent;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinco.ForeColor = System.Drawing.SystemColors.Control;
            this.cinco.Location = new System.Drawing.Point(159, 285);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(23, 22);
            this.cinco.TabIndex = 23;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // botoncircular2
            // 
            this.botoncircular2.BackColor = System.Drawing.Color.Transparent;
            this.botoncircular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncircular2.Location = new System.Drawing.Point(132, 148);
            this.botoncircular2.Name = "botoncircular2";
            this.botoncircular2.Size = new System.Drawing.Size(23, 24);
            this.botoncircular2.TabIndex = 10;
            this.botoncircular2.Text = "<";
            this.botoncircular2.UseVisualStyleBackColor = false;
            this.botoncircular2.Click += new System.EventHandler(this.botoncircular2_Click);
            // 
            // botoncircular3
            // 
            this.botoncircular3.BackColor = System.Drawing.Color.Transparent;
            this.botoncircular3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncircular3.Location = new System.Drawing.Point(187, 147);
            this.botoncircular3.Name = "botoncircular3";
            this.botoncircular3.Size = new System.Drawing.Size(22, 26);
            this.botoncircular3.TabIndex = 11;
            this.botoncircular3.Text = ">";
            this.botoncircular3.UseVisualStyleBackColor = false;
            this.botoncircular3.Click += new System.EventHandler(this.botoncircular3_Click);
            // 
            // botoncircular1
            // 
            this.botoncircular1.BackColor = System.Drawing.Color.Red;
            this.botoncircular1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncircular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncircular1.ForeColor = System.Drawing.Color.Black;
            this.botoncircular1.Location = new System.Drawing.Point(131, 21);
            this.botoncircular1.Name = "botoncircular1";
            this.botoncircular1.Size = new System.Drawing.Size(20, 18);
            this.botoncircular1.TabIndex = 8;
            this.botoncircular1.UseVisualStyleBackColor = false;
            this.botoncircular1.Click += new System.EventHandler(this.botoncircular1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = global::television.Properties.Resources.Calidad_superior_m_s_nuevo_universal_control;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(-48, -39);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(417, 482);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 30;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = global::television.Properties.Resources.apple_tv_template;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(432, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(596, 409);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 20;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.Color.Transparent;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siete.ForeColor = System.Drawing.SystemColors.Control;
            this.siete.Location = new System.Drawing.Point(133, 309);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(21, 21);
            this.siete.TabIndex = 31;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.Color.Transparent;
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocho.ForeColor = System.Drawing.SystemColors.Control;
            this.ocho.Location = new System.Drawing.Point(161, 309);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(21, 21);
            this.ocho.TabIndex = 32;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // nueve
            // 
            this.nueve.BackColor = System.Drawing.Color.Transparent;
            this.nueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nueve.ForeColor = System.Drawing.SystemColors.Control;
            this.nueve.Location = new System.Drawing.Point(188, 309);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(21, 21);
            this.nueve.TabIndex = 33;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = false;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // cero
            // 
            this.cero.BackColor = System.Drawing.Color.Transparent;
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cero.ForeColor = System.Drawing.SystemColors.Control;
            this.cero.Location = new System.Drawing.Point(161, 325);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(21, 21);
            this.cero.TabIndex = 34;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1028, 409);
            this.Controls.Add(this.botoncircular10);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.botoncircular2);
            this.Controls.Add(this.botoncircular3);
            this.Controls.Add(this.botoncircular1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCountry;
        public AxWMPLib.AxWindowsMediaPlayer Media;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private botoncircular botoncircular2;
        private botoncircular botoncircular3;
        private botoncircular botoncircular1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private botoncircular botoncircular10;
        private botoncircular dos;
        private botoncircular cuatro;
        private botoncircular uno;
        private botoncircular seis;
        private botoncircular tres;
        private botoncircular cinco;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private botoncircular cero;
        private botoncircular nueve;
        private botoncircular ocho;
        private botoncircular siete;
    }
}

