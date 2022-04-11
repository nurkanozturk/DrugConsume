using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugConsume.WindowsFormUI
{
    public partial class GenericForm : Form
    {
        public GenericForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string file = @"DrugConsumeData\ilaç-jenerik bilgileri.xls";
            File.AppendAllText(file,tbxDrug.Text + Convert.ToChar(9) + tbxGeneric.Text + "\n", Encoding.GetEncoding("iso-8859-9"));

            this.Tag = tbxGeneric.Text;
            this.Close();
        }

        private void GenericForm_Load(object sender, EventArgs e)
        {
            tbxDrug.Text = Tag.ToString();
           
        }

        private void llblSkip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.Skipped = true;
            this.Tag = "";
            this.Close();
        }
    }
}
