namespace OISproje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.öğrenciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.anasayfaToolStripMenuItem.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.dersToolStripMenuItem.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.dersToolStripMenuItem.Text = "Ders";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.girişToolStripMenuItem.Text = "Giriş";
            this.girişToolStripMenuItem.Click += new System.EventHandler(this.girişToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem1,
            this.listeleToolStripMenuItem1});
            this.personelToolStripMenuItem.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // girişToolStripMenuItem1
            // 
            this.girişToolStripMenuItem1.Name = "girişToolStripMenuItem1";
            this.girişToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.girişToolStripMenuItem1.Text = "Giriş";
            this.girişToolStripMenuItem1.Click += new System.EventHandler(this.girişToolStripMenuItem1_Click);
            // 
            // listeleToolStripMenuItem1
            // 
            this.listeleToolStripMenuItem1.Name = "listeleToolStripMenuItem1";
            this.listeleToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.listeleToolStripMenuItem1.Text = "Listele";
            this.listeleToolStripMenuItem1.Click += new System.EventHandler(this.listeleToolStripMenuItem1_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem2,
            this.listeleToolStripMenuItem2,
            this.derslerToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // girişToolStripMenuItem2
            // 
            this.girişToolStripMenuItem2.Name = "girişToolStripMenuItem2";
            this.girişToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.girişToolStripMenuItem2.Text = "Giriş";
            this.girişToolStripMenuItem2.Click += new System.EventHandler(this.girişToolStripMenuItem2_Click);
            // 
            // listeleToolStripMenuItem2
            // 
            this.listeleToolStripMenuItem2.Name = "listeleToolStripMenuItem2";
            this.listeleToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.listeleToolStripMenuItem2.Text = "Listele";
            this.listeleToolStripMenuItem2.Click += new System.EventHandler(this.listeleToolStripMenuItem2_Click);
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.derslerToolStripMenuItem.Text = "Dersler";
            this.derslerToolStripMenuItem.Click += new System.EventHandler(this.derslerToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Thistle;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(742, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Ders",
            "Personel",
            "Öğrenci",
            "Öğrenci Ders"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Thistle;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Durum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.ImageKey = "(yok)";
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Okul İdare Sistemine Hoşgeldiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 202);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

