namespace DrugConsume.WindowsFormUI
{
    partial class GenericForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxGeneric = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDrug = new System.Windows.Forms.TextBox();
            this.llblSkip = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jenerik Adı";
            // 
            // tbxGeneric
            // 
            this.tbxGeneric.Location = new System.Drawing.Point(12, 73);
            this.tbxGeneric.Name = "tbxGeneric";
            this.tbxGeneric.Size = new System.Drawing.Size(287, 20);
            this.tbxGeneric.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlaç Adı";
            // 
            // tbxDrug
            // 
            this.tbxDrug.Location = new System.Drawing.Point(12, 25);
            this.tbxDrug.Name = "tbxDrug";
            this.tbxDrug.Size = new System.Drawing.Size(287, 20);
            this.tbxDrug.TabIndex = 3;
            // 
            // llblSkip
            // 
            this.llblSkip.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llblSkip.AutoSize = true;
            this.llblSkip.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llblSkip.Location = new System.Drawing.Point(259, 9);
            this.llblSkip.Name = "llblSkip";
            this.llblSkip.Size = new System.Drawing.Size(40, 13);
            this.llblSkip.TabIndex = 2;
            this.llblSkip.TabStop = true;
            this.llblSkip.Text = "Atla >>";
            this.llblSkip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSkip_LinkClicked);
            // 
            // GenericForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 141);
            this.Controls.Add(this.llblSkip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxGeneric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxDrug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GenericForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eksik Jenerik Bilgisi Giriş Ekranı";
            this.Load += new System.EventHandler(this.GenericForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxGeneric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDrug;
        private System.Windows.Forms.LinkLabel llblSkip;
    }
}