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
    public partial class MinMaxForm : Form
    {
        public MinMaxForm()
        {
            InitializeComponent();

        }

        private void MinMaxForm_Load(object sender, EventArgs e)
        {
            nudMin.Value = Properties.Settings.Default.min;
            nudMax.Value = Properties.Settings.Default.max;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.min = nudMin.Value;
            Properties.Settings.Default.max = nudMax.Value;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void nudMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nudMax.Focus();
            }

        }

        private void nudMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void nudMin_Enter(object sender, EventArgs e)
        {
            nudMin.Select(0, nudMin.Text.Length);
        }

        private void nudMax_Enter(object sender, EventArgs e)
        {
            nudMax.Select(0,nudMax.Text.Length);
        }
    }
}
