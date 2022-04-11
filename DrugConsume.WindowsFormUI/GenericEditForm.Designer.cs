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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxSearch = new DrugConsume.WindowsFormUI.TextboxUC();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenerics)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGenerics
            // 
            this.dgwGenerics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGenerics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGenerics.Location = new System.Drawing.Point(23, 45);
            this.dgwGenerics.Name = "dgwGenerics";
            this.dgwGenerics.Size = new System.Drawing.Size(652, 416);
            this.dgwGenerics.TabIndex = 0;
            this.dgwGenerics.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgwGenerics_CellBeginEdit);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(600, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(236, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(226, 27);
            this.tbxSearch.TabIndex = 3;
            this.tbxSearch.Texts = "Ara...";
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress_1);
            // 
            // GenericEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(716, 502);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgwGenerics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GenericEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jenerik Tanımlama Ekranı";
            this.Load += new System.EventHandler(this.GenericEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenerics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGenerics;
        private System.Windows.Forms.Button btnSave;
        private TextboxUC tbxSearch;
    }
}