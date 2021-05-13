namespace ING
{
    partial class Mesas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesas));
            this.Caja_bt = new System.Windows.Forms.Button();
            this.facturar_bt = new System.Windows.Forms.Button();
            this.articulos_bt = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.config_bt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.caja_bt1 = new System.Windows.Forms.Button();
            this.mesas_bt = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Caja_bt
            // 
            this.Caja_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Caja_bt.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Caja_bt.ForeColor = System.Drawing.Color.DarkGreen;
            this.Caja_bt.Location = new System.Drawing.Point(1318, 828);
            this.Caja_bt.Name = "Caja_bt";
            this.Caja_bt.Size = new System.Drawing.Size(200, 105);
            this.Caja_bt.TabIndex = 0;
            this.Caja_bt.Text = "Caja";
            this.Caja_bt.UseVisualStyleBackColor = false;
            // 
            // facturar_bt
            // 
            this.facturar_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.facturar_bt.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facturar_bt.ForeColor = System.Drawing.Color.DarkGreen;
            this.facturar_bt.Image = ((System.Drawing.Image)(resources.GetObject("facturar_bt.Image")));
            this.facturar_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facturar_bt.Location = new System.Drawing.Point(669, 831);
            this.facturar_bt.Name = "facturar_bt";
            this.facturar_bt.Size = new System.Drawing.Size(200, 105);
            this.facturar_bt.TabIndex = 0;
            this.facturar_bt.Text = "Facturar";
            this.facturar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.facturar_bt.UseVisualStyleBackColor = false;
            this.facturar_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // articulos_bt
            // 
            this.articulos_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.articulos_bt.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.articulos_bt.ForeColor = System.Drawing.Color.DarkGreen;
            this.articulos_bt.Location = new System.Drawing.Point(1100, 830);
            this.articulos_bt.Name = "articulos_bt";
            this.articulos_bt.Size = new System.Drawing.Size(200, 105);
            this.articulos_bt.TabIndex = 0;
            this.articulos_bt.Text = "Articulos";
            this.articulos_bt.UseVisualStyleBackColor = false;
            this.articulos_bt.Click += new System.EventHandler(this.articulos_bt_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(456, 101);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1241, 712);
            this.panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 354);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 35);
            this.comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.config_bt);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(-1, -16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 1101);
            this.panel2.TabIndex = 1;
            // 
            // config_bt
            // 
            this.config_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.config_bt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.config_bt.ForeColor = System.Drawing.Color.DarkGreen;
            this.config_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.config_bt.Location = new System.Drawing.Point(12, 846);
            this.config_bt.Name = "config_bt";
            this.config_bt.Size = new System.Drawing.Size(163, 84);
            this.config_bt.TabIndex = 0;
            this.config_bt.Text = "Configuración";
            this.config_bt.UseVisualStyleBackColor = false;
            this.config_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 179);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 386);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(370, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 42);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // caja_bt1
            // 
            this.caja_bt1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.caja_bt1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caja_bt1.ForeColor = System.Drawing.Color.DarkGreen;
            this.caja_bt1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caja_bt1.Location = new System.Drawing.Point(885, 830);
            this.caja_bt1.Name = "caja_bt1";
            this.caja_bt1.Size = new System.Drawing.Size(200, 105);
            this.caja_bt1.TabIndex = 0;
            this.caja_bt1.Text = "Caja";
            this.caja_bt1.UseVisualStyleBackColor = false;
            this.caja_bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mesas_bt
            // 
            this.mesas_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mesas_bt.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mesas_bt.ForeColor = System.Drawing.Color.DarkGreen;
            this.mesas_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mesas_bt.Location = new System.Drawing.Point(456, 831);
            this.mesas_bt.Name = "mesas_bt";
            this.mesas_bt.Size = new System.Drawing.Size(200, 105);
            this.mesas_bt.TabIndex = 0;
            this.mesas_bt.Text = "Mesas";
            this.mesas_bt.UseVisualStyleBackColor = false;
            this.mesas_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mesas_bt);
            this.Controls.Add(this.caja_bt1);
            this.Controls.Add(this.articulos_bt);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.facturar_bt);
            this.Controls.Add(this.Caja_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Mesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IBD TECH SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Caja_bt;
        private System.Windows.Forms.Button facturar_bt;
        private System.Windows.Forms.Button articulos_bt;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button config_bt;
        private System.Windows.Forms.Button caja_bt1;
        private System.Windows.Forms.Button mesas_bt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listView1;
    }
}

