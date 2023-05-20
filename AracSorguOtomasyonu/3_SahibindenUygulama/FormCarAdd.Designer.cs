namespace _3_SahibindenUygulama
{
    partial class FormCarAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.buttonBrandAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.buttonColorAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(66, 117);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(170, 20);
            this.tbPrice.TabIndex = 4;
            this.tbPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPrice_KeyDown);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(66, 39);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(170, 20);
            this.tbModel.TabIndex = 1;
            this.tbModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbModel_KeyDown);
            // 
            // buttonBrandAdd
            // 
            this.buttonBrandAdd.Location = new System.Drawing.Point(242, 12);
            this.buttonBrandAdd.Name = "buttonBrandAdd";
            this.buttonBrandAdd.Size = new System.Drawing.Size(74, 21);
            this.buttonBrandAdd.TabIndex = 0;
            this.buttonBrandAdd.Text = "Marka Ekle";
            this.buttonBrandAdd.UseVisualStyleBackColor = true;
            this.buttonBrandAdd.Click += new System.EventHandler(this.buttonBrandAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yıl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Km:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fiyat:";
            // 
            // cbBrand
            // 
            this.cbBrand.ContextMenuStrip = this.contextMenuStrip1;
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(66, 12);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(170, 21);
            this.cbBrand.TabIndex = 0;
            this.cbBrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBrand_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // cbColor
            // 
            this.cbColor.ContextMenuStrip = this.contextMenuStrip2;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(66, 143);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(170, 21);
            this.cbColor.TabIndex = 5;
            this.cbColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbColor_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Renk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şehir:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(66, 65);
            this.tbYear.MaxLength = 4;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(170, 20);
            this.tbYear.TabIndex = 2;
            this.tbYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbYear_KeyDown);
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            // 
            // tbKm
            // 
            this.tbKm.Location = new System.Drawing.Point(66, 91);
            this.tbKm.Name = "tbKm";
            this.tbKm.Size = new System.Drawing.Size(170, 20);
            this.tbKm.TabIndex = 3;
            this.tbKm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKm_KeyDown);
            this.tbKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKm_KeyPress);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(66, 170);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(170, 20);
            this.tbCity.TabIndex = 6;
            this.tbCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCity_KeyDown);
            // 
            // buttonColorAdd
            // 
            this.buttonColorAdd.Location = new System.Drawing.Point(242, 143);
            this.buttonColorAdd.Name = "buttonColorAdd";
            this.buttonColorAdd.Size = new System.Drawing.Size(74, 21);
            this.buttonColorAdd.TabIndex = 5;
            this.buttonColorAdd.Text = "Renk Ekle";
            this.buttonColorAdd.UseVisualStyleBackColor = true;
            this.buttonColorAdd.Click += new System.EventHandler(this.buttonColorAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(160, 196);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(76, 21);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonSave_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3_SahibindenUygulama.Properties.Resources.b;
            this.pictureBox1.Location = new System.Drawing.Point(242, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem1,
            this.silToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 70);
            // 
            // güncelleToolStripMenuItem1
            // 
            this.güncelleToolStripMenuItem1.Name = "güncelleToolStripMenuItem1";
            this.güncelleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem1.Text = "Güncelle";
            this.güncelleToolStripMenuItem1.Click += new System.EventHandler(this.güncelleToolStripMenuItem1_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // FormCarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 223);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonColorAdd);
            this.Controls.Add(this.buttonBrandAdd);
            this.Controls.Add(this.tbKm);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCarAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Ekle";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrandAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonColorAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox tbPrice;
        public System.Windows.Forms.TextBox tbModel;
        public System.Windows.Forms.ComboBox cbBrand;
        public System.Windows.Forms.ComboBox cbColor;
        public System.Windows.Forms.TextBox tbYear;
        public System.Windows.Forms.TextBox tbKm;
        public System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
    }
}