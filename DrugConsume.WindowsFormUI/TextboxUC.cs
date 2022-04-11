using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugConsume.WindowsFormUI
{
    [DefaultEvent("_TextChanged")]
    public partial class TextboxUC : UserControl
    {
        public TextboxUC()
        {
            InitializeComponent();
        }
        private bool isPlaceholder = true;

        public event EventHandler _TextChanged;

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            if (isPlaceholder)
            {
                tbxSearch.Text = "";
                tbxSearch.ForeColor = Color.Black;
                isPlaceholder = false;
            }
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (!isPlaceholder && tbxSearch.Text == "")
            {
                tbxSearch.Text = "Ara...";
                tbxSearch.ForeColor = Color.Gray;
                isPlaceholder = true;
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            flp.Width = this.Width - (int)this.Font.Size;
            tbxSearch.Width = flp.Width - (int)this.Font.Size*3;
        }
        public string Texts
        {
            get
            {
                return tbxSearch.Text;
            }

            set
            {
                tbxSearch.Text = value;
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged!=null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
    }
}
