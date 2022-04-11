using DrugConsume.Business.Concrete;
using DrugConsume.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DrugConsume.WindowsFormUI
{
    public partial class GenericEditForm : Form
    {
        public GenericEditForm()
        {
            InitializeComponent();
        }

        string filePath = "DrugConsumeData";
        private List<GenericOfDrug> generics;
        private void GenericEditForm_Load(object sender, EventArgs e)
        {
            generics = GenericService.ListGenericDatas(filePath);
            dgwGenerics.DataSource = generics;

        }

        private void dgwGenerics_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Form1.Edited = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string file = filePath + @"\ilaç-jenerik bilgileri.xls";
            if (Form1.Edited)
            {
                File.WriteAllText(file, "");
                foreach (DataGridViewRow row in dgwGenerics.Rows)
                {
                    File.AppendAllText(file, row.Cells[0].Value.ToString() + Convert.ToChar(9) + row.Cells[1].Value.ToString() + "\n", Encoding.GetEncoding("iso-8859-9"));
                }
                dgwGenerics.DataSource = GenericService.ListGenericDatas(filePath);
                this.Close();
            }
        }


        private void tbxSearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgwGenerics.DataSource = GenericService.ListGenericDatas(filePath);
                dgwGenerics.CurrentCell = null;
                List<int> hiddenRows = new List<int>();
                foreach (DataGridViewRow row in dgwGenerics.Rows)
                {
                    if (!row.Cells[0].Value.ToString().ToLower().Contains(tbxSearch.Texts.ToLower()) && !row.Cells[1].Value.ToString().ToLower().Contains(tbxSearch.Texts.ToLower()))
                    {
                        hiddenRows.Add(row.Index);
                    }

                }
                foreach (int index in hiddenRows)
                {
                    if (dgwGenerics.Rows[index] != dgwGenerics.CurrentRow)
                    {
                        dgwGenerics.Rows[index].Visible = false;
                    }

                }

                tbxSearch.Texts = "";
            }
        }
    }
}
