namespace DrugConsume.WindowsFormUI
{
    partial class TextboxUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextboxUC));
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.ForeColor = System.Drawing.Color.Gray;
            this.tbxSearch.Location = new System.Drawing.Point(3, 2);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 13);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.Text = "Ara...";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            this.tbxSearch.Leave += new System.EventHandler(this.tbxSearch_Leave);
            // 
            // flp
            // 
            this.flp.BackColor = System.Drawing.SystemColors.Window;
            this.flp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp.Controls.Add(this.tbxSearch);
            this.flp.Controls.Add(this.pictureBox1);
            this.flp.Location = new System.Drawing.Point(3, 3);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(125, 20);
            this.flp.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(106, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TextboxUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp);
            this.Name = "TextboxUC";
            this.Size = new System.Drawing.Size(132, 27);
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
