namespace DrugConsume.WindowsFormUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veriÇekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jenerikVerileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimumMaksimumÇarpanıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwGeneric = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new DrugConsume.WindowsFormUI.TextboxUC();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGeneric)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriÇekToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1840, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veriÇekToolStripMenuItem
            // 
            this.veriÇekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaYükleToolStripMenuItem});
            this.veriÇekToolStripMenuItem.Name = "veriÇekToolStripMenuItem";
            this.veriÇekToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.veriÇekToolStripMenuItem.Text = "Veri Çek";
            // 
            // dosyaYükleToolStripMenuItem
            // 
            this.dosyaYükleToolStripMenuItem.Name = "dosyaYükleToolStripMenuItem";
            this.dosyaYükleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dosyaYükleToolStripMenuItem.Text = "Dosya Yükle";
            this.dosyaYükleToolStripMenuItem.Click += new System.EventHandler(this.dosyaYükleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jenerikVerileriToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // jenerikVerileriToolStripMenuItem
            // 
            this.jenerikVerileriToolStripMenuItem.Name = "jenerikVerileriToolStripMenuItem";
            this.jenerikVerileriToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.jenerikVerileriToolStripMenuItem.Text = "Jenerik Verileri";
            this.jenerikVerileriToolStripMenuItem.Click += new System.EventHandler(this.jenerikVerileriToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimumMaksimumÇarpanıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // minimumMaksimumÇarpanıToolStripMenuItem
            // 
            this.minimumMaksimumÇarpanıToolStripMenuItem.Name = "minimumMaksimumÇarpanıToolStripMenuItem";
            this.minimumMaksimumÇarpanıToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.minimumMaksimumÇarpanıToolStripMenuItem.Text = "Min-Maks Çarpan Değeri";
            this.minimumMaksimumÇarpanıToolStripMenuItem.Click += new System.EventHandler(this.minimumMaksimumÇarpanıToolStripMenuItem_Click);
            // 
            // cbxYear
            // 
            this.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(1242, 27);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(80, 21);
            this.cbxYear.TabIndex = 18;
            this.cbxYear.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1182, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Geçerli Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Jenerik İlaç Tüketim Verileri";
            // 
            // dgwGeneric
            // 
            this.dgwGeneric.AllowDrop = true;
            this.dgwGeneric.AllowUserToAddRows = false;
            this.dgwGeneric.AllowUserToDeleteRows = false;
            this.dgwGeneric.AllowUserToOrderColumns = true;
            this.dgwGeneric.AllowUserToResizeColumns = false;
            this.dgwGeneric.AllowUserToResizeRows = false;
            this.dgwGeneric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwGeneric.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwGeneric.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwGeneric.Location = new System.Drawing.Point(25, 61);
            this.dgwGeneric.Name = "dgwGeneric";
            this.dgwGeneric.Size = new System.Drawing.Size(1815, 853);
            this.dgwGeneric.TabIndex = 21;
            this.dgwGeneric.DataSourceChanged += new System.EventHandler(this.dgwGeneric_DataSourceChanged);
            this.dgwGeneric.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwGeneric_ColumnHeaderMouseDoubleClick);
            this.dgwGeneric.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgwGeneric_DragDrop);
            this.dgwGeneric.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgwGeneric_DragEnter);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(558, 17);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(254, 31);
            this.tbxSearch.TabIndex = 22;
            this.tbxSearch.Texts = "Ara...";
            this.tbxSearch._TextChanged += new System.EventHandler(this.tbxSearch__TextChanged);
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgwGeneric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "İlaç Tüketim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGeneric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veriÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaYükleToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwGeneric;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jenerikVerileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumMaksimumÇarpanıToolStripMenuItem;
        private TextboxUC tbxSearch;
    }
}