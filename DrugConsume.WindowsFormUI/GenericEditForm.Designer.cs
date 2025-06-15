namespace DrugConsume.WindowsFormUI
{
    partial class GenericEditForm
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
            this.dgwGenerics = new System.Windows.Forms.DataGridView();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgwGenerics1 = new System.Windows.Forms.DataGridView();
            this.clmnName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSearch1 = new DrugConsume.WindowsFormUI.TextboxUC();
            this.tbxSearch = new DrugConsume.WindowsFormUI.TextboxUC();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenerics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenerics1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGenerics
            // 
            this.dgwGenerics.AllowUserToAddRows = false;
            this.dgwGenerics.AllowUserToDeleteRows = false;
            this.dgwGenerics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGenerics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGenerics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnName});
            this.dgwGenerics.Location = new System.Drawing.Point(23, 45);
            this.dgwGenerics.MultiSelect = false;
            this.dgwGenerics.Name = "dgwGenerics";
            this.dgwGenerics.ReadOnly = true;
            this.dgwGenerics.Size = new System.Drawing.Size(565, 416);
            this.dgwGenerics.TabIndex = 0;
            this.dgwGenerics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGenerics_CellClick);
            // 
            // clmnName
            // 
            this.clmnName.HeaderText = "Jenerik Adı";
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(565, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgwGenerics1
            // 
            this.dgwGenerics1.AllowUserToAddRows = false;
            this.dgwGenerics1.AllowUserToDeleteRows = false;
            this.dgwGenerics1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGenerics1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGenerics1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnName1});
            this.dgwGenerics1.Location = new System.Drawing.Point(612, 45);
            this.dgwGenerics1.MultiSelect = false;
            this.dgwGenerics1.Name = "dgwGenerics1";
            this.dgwGenerics1.ReadOnly = true;
            this.dgwGenerics1.Size = new System.Drawing.Size(565, 416);
            this.dgwGenerics1.TabIndex = 4;
            // 
            // clmnName1
            // 
            this.clmnName1.HeaderText = "Jeneric Adı";
            this.clmnName1.Name = "clmnName1";
            this.clmnName1.ReadOnly = true;
            // 
            // tbxSearch1
            // 
            this.tbxSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch1.Location = new System.Drawing.Point(782, 12);
            this.tbxSearch1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSearch1.Name = "tbxSearch1";
            this.tbxSearch1.Size = new System.Drawing.Size(230, 27);
            this.tbxSearch1.TabIndex = 5;
            this.tbxSearch1.Texts = "Ara...";
            this.tbxSearch1._TextChanged += new System.EventHandler(this.tbxSearch1__TextChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(192, 12);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(230, 27);
            this.tbxSearch.TabIndex = 3;
            this.tbxSearch.Texts = "Ara...";
            this.tbxSearch._TextChanged += new System.EventHandler(this.tbxSearch__TextChanged);
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Önceki Değer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(618, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yeni Değer";
            // 
            // GenericEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1208, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch1);
            this.Controls.Add(this.dgwGenerics1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgwGenerics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GenericEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jenerik Tanımlama Ekranı";
            this.Load += new System.EventHandler(this.GenericEditForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GenericEditForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenerics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenerics1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGenerics;
        private System.Windows.Forms.Button btnSave;
        private TextboxUC tbxSearch;
        private System.Windows.Forms.DataGridView dgwGenerics1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName1;
        private TextboxUC tbxSearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}