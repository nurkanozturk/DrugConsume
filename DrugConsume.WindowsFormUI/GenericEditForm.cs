using DrugConsume.Business.Concrete;
using DrugConsume.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrugConsume.WindowsFormUI
{
    public partial class GenericEditForm : Form
    {
        GenericMatchManager matchManager = new GenericMatchManager();
        public GenericEditForm()
        {
            
            InitializeComponent();
        }

        private List<string> generics;
        private List<string> generics1;
        private Dictionary<string, string> genericMatches;
        private void GenericEditForm_Load(object sender, EventArgs e)
        {
            generics = Variables.GenericNames;
            generics1 = Variables.GenericNames;
            btnSave.BackColor = Color.LightGray;

            genericMatches = matchManager.GetMatches();
            if(genericMatches != null)
            {
                foreach (var item in genericMatches.Keys)
                {
                    generics.Remove(item);
                }
            }
            
            foreach (var item in generics)
            {
                dgwGenerics.Rows.Add(item);
            }
            foreach (var item in generics1)
            {
                dgwGenerics1.Rows.Add(item);
            }

        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dgwGenerics.CurrentRow == null)
                return;

            Form1.GenericTypes
               .Add(dgwGenerics.CurrentRow.Cells[0].Value.ToString(), 
                     dgwGenerics1.CurrentRow.Cells[0].Value.ToString()
                     );
            generics.Remove(dgwGenerics.CurrentRow.Cells[0].Value.ToString());
            Dictionary<string,string> newMatch = new Dictionary<string, string>
            {
                {
                    dgwGenerics.CurrentRow.Cells[0].Value.ToString(),
                    dgwGenerics1.CurrentRow.Cells[0].Value.ToString()
                }
            };
            matchManager.SaveMatches(newMatch);

            Form1.Edited = true;
            
            dgwGenerics.Rows.Clear();
            foreach (var item in generics)
            {
                dgwGenerics.Rows.Add(item);
            }

            for (int i = 0; i < dgwGenerics1.Rows.Count; i++)
            {
                dgwGenerics1.Rows[i].Visible = true;
            }

            MessageBox.Show("Veriler kaydedildi.");

        }


        private void tbxSearch__TextChanged(object sender, EventArgs e)
        {
            Search(tbxSearch, dgwGenerics);
            Search(tbxSearch, dgwGenerics1 );
        }

        private void tbxSearch1__TextChanged(object sender, EventArgs e)
        {
            Search(tbxSearch1, dgwGenerics1);
        }
        private void Search(TextboxUC textbox, DataGridView dgw)
        {
            if (textbox.Texts == "" || textbox.Texts == "Ara...")
            {
                for (int i = 0; i < dgw.Rows.Count; i++)
                {
                    dgw.Rows[i].Visible = true;
                }
                return;
            }

            dgw.CurrentCell = null;
            for (int i = 0; i < dgw.Rows.Count; i++)
            {
                dgw.Rows[i].Visible = true;
            }
            List<int> hiddenRows = new List<int>();
            foreach (DataGridViewRow row in dgw.Rows)
            {
                if (!row.Cells[0].Value.ToString().ToLower().Contains(textbox.Texts.ToLower()))
                {
                    hiddenRows.Add(row.Index);
                }

            }
            foreach (int index in hiddenRows)
            {
                if (dgw.Rows[index] != dgw.CurrentRow)
                {
                    dgw.Rows[index].Visible = false;
                }

            }
        }

        private void dgwGenerics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.BackColor = Color.LightGray;
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightGray;

        }

        private void GenericEditForm_MouseDown(object sender, MouseEventArgs e)
        {
            btnSave.BackColor = Color.LightGray;
        }
    }
}
