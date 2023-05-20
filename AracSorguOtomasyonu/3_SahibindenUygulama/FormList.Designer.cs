namespace _3_SahibindenUygulama
{
    partial class FormList
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbBrand = new System.Windows.Forms.GroupBox();
            this.gbModel = new System.Windows.Forms.GroupBox();
            this.panelModel = new System.Windows.Forms.Panel();
            this.gbYear = new System.Windows.Forms.GroupBox();
            this.panelYear = new System.Windows.Forms.Panel();
            this.gbKm = new System.Windows.Forms.GroupBox();
            this.tbMaxKm = new System.Windows.Forms.TextBox();
            this.tbMinKm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.tbMaxPrice = new System.Windows.Forms.TextBox();
            this.tbMinPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.gbCity = new System.Windows.Forms.GroupBox();
            this.panelCity = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbBrand.SuspendLayout();
            this.gbModel.SuspendLayout();
            this.gbYear.SuspendLayout();
            this.gbKm.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.gbCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Location = new System.Drawing.Point(169, 38);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(495, 524);
            this.dgv.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonList.ForeColor = System.Drawing.Color.Blue;
            this.buttonList.Location = new System.Drawing.Point(45, 534);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(73, 28);
            this.buttonList.TabIndex = 1;
            this.buttonList.Text = "Listele";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Türkiye\'nin 1 Numaralı 2. El Otomobil Uygulaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Araç Sorgula";
            // 
            // panelBrand
            // 
            this.panelBrand.AutoScroll = true;
            this.panelBrand.Location = new System.Drawing.Point(4, 17);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(137, 39);
            this.panelBrand.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ara:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(45, 48);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(115, 20);
            this.tbSearch.TabIndex = 7;
            // 
            // gbBrand
            // 
            this.gbBrand.Controls.Add(this.panelBrand);
            this.gbBrand.Location = new System.Drawing.Point(15, 74);
            this.gbBrand.Name = "gbBrand";
            this.gbBrand.Size = new System.Drawing.Size(148, 62);
            this.gbBrand.TabIndex = 8;
            this.gbBrand.TabStop = false;
            this.gbBrand.Text = "Marka";
            // 
            // gbModel
            // 
            this.gbModel.Controls.Add(this.panelModel);
            this.gbModel.Location = new System.Drawing.Point(16, 140);
            this.gbModel.Name = "gbModel";
            this.gbModel.Size = new System.Drawing.Size(148, 61);
            this.gbModel.TabIndex = 8;
            this.gbModel.TabStop = false;
            this.gbModel.Text = "Model";
            // 
            // panelModel
            // 
            this.panelModel.AutoScroll = true;
            this.panelModel.Location = new System.Drawing.Point(4, 17);
            this.panelModel.Name = "panelModel";
            this.panelModel.Size = new System.Drawing.Size(137, 39);
            this.panelModel.TabIndex = 5;
            // 
            // gbYear
            // 
            this.gbYear.Controls.Add(this.panelYear);
            this.gbYear.Location = new System.Drawing.Point(17, 205);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(148, 63);
            this.gbYear.TabIndex = 8;
            this.gbYear.TabStop = false;
            this.gbYear.Text = "Yıl";
            // 
            // panelYear
            // 
            this.panelYear.AutoScroll = true;
            this.panelYear.Location = new System.Drawing.Point(4, 17);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(137, 38);
            this.panelYear.TabIndex = 5;
            // 
            // gbKm
            // 
            this.gbKm.Controls.Add(this.tbMaxKm);
            this.gbKm.Controls.Add(this.tbMinKm);
            this.gbKm.Controls.Add(this.label6);
            this.gbKm.Controls.Add(this.label7);
            this.gbKm.Location = new System.Drawing.Point(16, 273);
            this.gbKm.Name = "gbKm";
            this.gbKm.Size = new System.Drawing.Size(148, 59);
            this.gbKm.TabIndex = 8;
            this.gbKm.TabStop = false;
            this.gbKm.Text = "Km";
            // 
            // tbMaxKm
            // 
            this.tbMaxKm.Location = new System.Drawing.Point(41, 35);
            this.tbMaxKm.Name = "tbMaxKm";
            this.tbMaxKm.Size = new System.Drawing.Size(100, 20);
            this.tbMaxKm.TabIndex = 5;
            // 
            // tbMinKm
            // 
            this.tbMinKm.Location = new System.Drawing.Point(41, 12);
            this.tbMinKm.Name = "tbMinKm";
            this.tbMinKm.Size = new System.Drawing.Size(100, 20);
            this.tbMinKm.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Min:";
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.tbMaxPrice);
            this.gbPrice.Controls.Add(this.tbMinPrice);
            this.gbPrice.Controls.Add(this.label5);
            this.gbPrice.Controls.Add(this.label3);
            this.gbPrice.Location = new System.Drawing.Point(16, 338);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(148, 59);
            this.gbPrice.TabIndex = 8;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Fiyat";
            // 
            // tbMaxPrice
            // 
            this.tbMaxPrice.Location = new System.Drawing.Point(39, 36);
            this.tbMaxPrice.Name = "tbMaxPrice";
            this.tbMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbMaxPrice.TabIndex = 2;
            // 
            // tbMinPrice
            // 
            this.tbMinPrice.Location = new System.Drawing.Point(39, 13);
            this.tbMinPrice.Name = "tbMinPrice";
            this.tbMinPrice.Size = new System.Drawing.Size(100, 20);
            this.tbMinPrice.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min:";
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.panelColor);
            this.gbColor.Location = new System.Drawing.Point(17, 403);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(148, 59);
            this.gbColor.TabIndex = 8;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Renk";
            // 
            // panelColor
            // 
            this.panelColor.AutoScroll = true;
            this.panelColor.Location = new System.Drawing.Point(4, 17);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(137, 37);
            this.panelColor.TabIndex = 5;
            // 
            // gbCity
            // 
            this.gbCity.Controls.Add(this.panelCity);
            this.gbCity.Location = new System.Drawing.Point(17, 468);
            this.gbCity.Name = "gbCity";
            this.gbCity.Size = new System.Drawing.Size(148, 59);
            this.gbCity.TabIndex = 8;
            this.gbCity.TabStop = false;
            this.gbCity.Text = "Şehir";
            // 
            // panelCity
            // 
            this.panelCity.AutoScroll = true;
            this.panelCity.Location = new System.Drawing.Point(4, 17);
            this.panelCity.Name = "panelCity";
            this.panelCity.Size = new System.Drawing.Size(137, 37);
            this.panelCity.TabIndex = 5;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(669, 567);
            this.Controls.Add(this.gbCity);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.gbKm);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.gbModel);
            this.Controls.Add(this.gbBrand);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.dgv);
            this.Name = "FormList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbBrand.ResumeLayout(false);
            this.gbModel.ResumeLayout(false);
            this.gbYear.ResumeLayout(false);
            this.gbKm.ResumeLayout(false);
            this.gbKm.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbCity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button buttonList;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbBrand;
        private System.Windows.Forms.GroupBox gbModel;
        private System.Windows.Forms.Panel panelModel;
        private System.Windows.Forms.GroupBox gbYear;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.GroupBox gbKm;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.GroupBox gbCity;
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.TextBox tbMaxPrice;
        private System.Windows.Forms.TextBox tbMinPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaxKm;
        private System.Windows.Forms.TextBox tbMinKm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

