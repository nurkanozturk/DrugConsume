using DrugConsume.Business.Concrete;
using DrugConsume.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DrugConsume.WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static bool Skipped { get; set; }
        public static bool Edited { get; set; } = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            //seçili yılı ayarlıyoruz.
            SetCbxDate();
            
        }

        private void SetCbxDate()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath);
            FileInfo[] files = directoryInfo.GetFiles("*.xml");
            if (files.Length <= 0)
            {
                return;
            }

            foreach (FileInfo file in files)
            {
                if (!cbxYear.Items.Contains(file.Name.Substring(0, 4)))
                {
                    cbxYear.Items.Add(file.Name.Substring(0, 4));
                }
            }
            cbxYear.SelectedIndex = cbxYear.Items.Count - 1;
        }

        XmlDocument xmlDocument = new XmlDocument();
        XmlElement datas;
        string filePath = "DrugConsumeData";

        private void LoadFile(string dataPath)
        {
            //.xls dosyasını okuyup .xml olarak kaydediyoruz.
            List<string> lines = File.ReadAllLines(dataPath, Encoding.GetEncoding("iso-8859-9")).ToList();
            lines.RemoveAt(0);
            lines.RemoveAt(lines.Count - 1);
            lines.RemoveAt(lines.Count - 1);
            string fileDate = lines[0].Split(Convert.ToChar(9))[6];
            string xmlFileName = fileDate.Substring(fileDate.Length - 4, 4) + ".xml";

            xmlDocument = new XmlDocument();
            datas = xmlDocument.CreateElement("datas");
            xmlDocument.AppendChild(datas);

            foreach (var line in lines)
            {
                string[] values = line.Split(Convert.ToChar(9));

                XmlElement data = xmlDocument.CreateElement("data");
                XmlAttribute name = xmlDocument.CreateAttribute("name");
                name.Value = values[9];
                data.Attributes.Append(name);

                XmlAttribute genericName = xmlDocument.CreateAttribute("genericName");
                genericName.Value = GetGenericName(values[9]);
                data.Attributes.Append(genericName);

                XmlAttribute amount = xmlDocument.CreateAttribute("amount");
                amount.Value = values[7] != "" ? values[7] : values[8];
                data.Attributes.Append(amount);

                XmlAttribute moveType = xmlDocument.CreateAttribute("moveType");
                moveType.Value = values[13];
                data.Attributes.Append(moveType);

                XmlAttribute isEntry = xmlDocument.CreateAttribute("isEntry");
                isEntry.Value = values[7] != "" ? "True" : "False";
                data.Attributes.Append(isEntry);

                XmlAttribute unitPrice = xmlDocument.CreateAttribute("unitPrice");
                unitPrice.Value = values[5];
                data.Attributes.Append(unitPrice);

                XmlAttribute date = xmlDocument.CreateAttribute("date");
                date.Value = values[6];
                data.Attributes.Append(date);

                datas.AppendChild(data);

            }
            if (File.Exists(xmlFileName))
            {
                File.Delete(xmlFileName);
            }
            xmlDocument.Save(xmlFileName);

        }


        private string GetGenericName(string drugName)
        {

            List<GenericOfDrug> genericDatas = GenericService.ListGenericDatas(filePath);
            string genericName = "";

            foreach (GenericOfDrug genericData in genericDatas)
            {
                if (drugName.Contains(genericData.DrugName))
                {
                    genericName = genericData.GenericName;
                    continue;
                }
            }
            if (genericName == "" && !Skipped)
            {
                GenericForm genericForm = new GenericForm();
                genericForm.Tag = drugName;
                genericForm.ShowDialog();
                genericName = genericForm.Tag.ToString();
                GenericService.ListGenericDatas(filePath);
            }

            return genericName;
        }

        private void dosyaYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();
            DialogResult dialogResult = oFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            string dataPath = oFileDialog.FileName;
            if (!File.Exists(filePath + @"\ilaç-jenerik bilgileri.xls"))
            {
                File.Create(filePath + @"\ilaç-jenerik bilgileri.xls").Close();

            }
            LoadFile(dataPath);
            MessageBox.Show("Veriler başarıyla çekildi.");
            SetCbxDate();

            dgwGeneric.DataSource = LoadGenerics(cbxYear.Text);

        }

        private List<GenericDrug> LoadGenerics(string year)
        {
            //tüm hareket listesindeki her bir kayıt kullanılarak dataEntities listesi oluşturuldu

            List<DataEntity> dataEntities = new List<DataEntity>();
            xmlDocument.Load(year + ".xml");
            XmlNode datas = xmlDocument.SelectSingleNode("datas");
            XmlNodeList dataList = datas.SelectNodes("data");

            foreach (XmlNode data in dataList)
            {
                DataEntity entity = new DataEntity();
                entity.Name = data.Attributes["name"].Value;
                entity.Amount = Convert.ToInt32(data.Attributes["amount"].Value);
                entity.TypeOfMove = data.Attributes["moveType"].Value;
                entity.IsEntry = Convert.ToBoolean(data.Attributes["isEntry"].Value);
                entity.UnitPrice = Convert.ToDecimal(data.Attributes["unitPrice"].Value);
                entity.Date = Convert.ToDateTime(data.Attributes["date"].Value);
                entity.GenericName = data.Attributes["genericName"].Value;

                dataEntities.Add(entity);
            }

            //Son liste oluşturuluyor
            List<GenericDrug> genericDrugs = new List<GenericDrug>();
            foreach (DataEntity data in dataEntities)
            {
                //Listeye daha önce eklenmemişse
                if (genericDrugs.Where(g => g.Name == data.GenericName).Count() == 0)
                {
                    List<DataEntity> filteredEntities = dataEntities.Where(d => d.GenericName == data.GenericName).ToList();
                    int entryAmount = 0; int exitAmount = 0; int consume = 0;

                    int consumeJan = 0; int consumeFeb = 0; int consumeMar = 0; int consumeApr = 0; int consumeMay = 0; int consumeJun = 0; int consumeJul = 0; int consumeAug = 0; int consumeSep = 0; int consumeOct = 0; int consumeNov = 0; int consumeDec = 0;

                    foreach (var entity in filteredEntities)
                    {

                        if (entity.IsEntry)
                        {
                            entryAmount += entity.Amount;
                        }
                        else
                        {
                            exitAmount += entity.Amount;
                            if (entity.TypeOfMove.StartsWith("TÜKETİM"))
                            {
                                consume += entity.Amount;

                                switch (entity.Date.Month)
                                {
                                    case 1: consumeJan += entity.Amount; break;
                                    case 2: consumeFeb += entity.Amount; break;
                                    case 3: consumeMar += entity.Amount; break;
                                    case 4: consumeApr += entity.Amount; break;
                                    case 5: consumeMay += entity.Amount; break;
                                    case 6: consumeJun += entity.Amount; break;
                                    case 7: consumeJul += entity.Amount; break;
                                    case 8: consumeAug += entity.Amount; break;
                                    case 9: consumeSep += entity.Amount; break;
                                    case 10: consumeOct += entity.Amount; break;
                                    case 11: consumeNov += entity.Amount; break;
                                    case 12: consumeDec += entity.Amount; break;
                                }
                            }
                        }
                    }
                    GenericDrug genericDrug = new GenericDrug();
                    genericDrug.Name = data.GenericName;
                    genericDrug.DrugName = data.Name;
                    genericDrug.UnitPrice = data.UnitPrice;
                    genericDrug.EntryAmount = entryAmount;
                    genericDrug.ExitAmount = exitAmount;
                    genericDrug.Amount = entryAmount - exitAmount;
                    genericDrug.Consume = consume;
                    genericDrug.OcakTuketim = consumeJan;
                    genericDrug.SubatTuketim = consumeFeb;
                    genericDrug.MartTuketim = consumeMar;
                    genericDrug.NisanTuketim = consumeApr;
                    genericDrug.MayisTuketim = consumeMay;
                    genericDrug.HaziranTuketim = consumeJun;
                    genericDrug.TemmuzTuketim = consumeJul;
                    genericDrug.AgustosTuketim = consumeAug;
                    genericDrug.EylulTuketim = consumeSep;
                    genericDrug.EkimTuketim = consumeOct;
                    genericDrug.KasimTuketim = consumeNov;
                    genericDrug.AralikTuketim = consumeDec;
                    genericDrugs.Add(genericDrug);
                }
            }

            return genericDrugs.OrderBy(g => g.Name).ToList();
        }
        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwGeneric.DataSource = LoadGenerics(cbxYear.Text);
            RevisualColumns();
        }
        enum Months
        {
            Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        private void RevisualColumns()
        {
            dgwGeneric.Columns[0].HeaderText = "Jenerik Adı";
            dgwGeneric.Columns[1].HeaderText = "Piyasa Adı";
            dgwGeneric.Columns[2].HeaderText = "Birim Fiyatı";
            dgwGeneric.Columns[3].HeaderText = "Giriş Miktarı";
            dgwGeneric.Columns[4].HeaderText = "Çıkış Miktarı";
            dgwGeneric.Columns[5].HeaderText = "Kalan";
            dgwGeneric.Columns[6].HeaderText = "Tüketim";


            for (int i = 0; i < 12; i++)
            {
                dgwGeneric.Columns[i + 7].HeaderText = ((Months)i).ToString();
            }

            dgwGeneric.RowHeadersWidth = 30;
            dgwGeneric.Columns[0].Width = dgwGeneric.Columns[1].Width = 200;

            for (int i = 2; i < 19; i++)
            {
                dgwGeneric.Columns[i].Width = 50;
            }

        }

        private void dgwGeneric_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<GenericDrug> orderedDrugs = dgwGeneric.DataSource as List<GenericDrug>;
            string headerText = orderedDrugs[0].GetType().GetProperties()[e.ColumnIndex].Name;

            //swich case yerine gettype getproperty getvalue kullanarak headertexte göre order yapabiliyoruz.
            //Property'nin parametre olarak gönderilmesi gerektiği durumlarda kullanışlı.
            orderedDrugs = orderedDrugs.OrderBy(o => typeof(GenericDrug).GetProperty(headerText).GetValue(o)).ToList();
            dgwGeneric.DataSource = orderedDrugs;

        }



        private void jenerikVerileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenericEditForm genericEditForm = new GenericEditForm();
            genericEditForm.ShowDialog();
            if (cbxYear.Text == "")
            {
                return;
            }
            if (Edited)
            {
                dgwGeneric.DataSource = LoadGenerics(cbxYear.Text);
                foreach (var item in cbxYear.Items)
                {
                    xmlDocument.Load(item.ToString() + ".xml");
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("datas");
                    XmlNodeList nodeList = xmlNode.SelectNodes("data");
                    foreach (XmlNode node in nodeList)
                    {
                        node.Attributes["genericName"].Value = GetGenericName(node.Attributes["name"].Value);
                    }
                    xmlDocument.Save(item.ToString() + ".xml");

                }
                MessageBox.Show("Veriler guncellendi.");

                dgwGeneric.DataSource = LoadGenerics(cbxYear.Text);


            }


        }


        private void CountStockLevel(DataGridViewRow row, out int minStock, out int maxStock)
        {

            int acceptedCell = 0;
            for (int j = 7; j < row.Cells.Count; j++)
            {
                if ((int)row.Cells[j].Value > 0)
                {
                    acceptedCell++;
                }
            }

            if (cbxYear.Text == DateTime.Now.Year.ToString() && DateTime.Now.Day < 20 && (int)row.Cells[DateTime.Now.Month + 6].Value > 0)
            {
                acceptedCell = acceptedCell - 1;
            }

            int avgConsume = acceptedCell > 0 ? ((int)row.Cells["Consume"].Value) / acceptedCell : 0;
            minStock = Convert.ToInt32(avgConsume * Properties.Settings.Default.min);
            maxStock = Convert.ToInt32(avgConsume * Properties.Settings.Default.max);
        }

        private void dgwGeneric_DataSourceChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgwGeneric.Rows)
            {
                int minStock, maxStock;
                CountStockLevel(row, out minStock, out maxStock);

                if ((int)row.Cells["Amount"].Value < minStock)
                {
                    row.Cells["Amount"].Style.BackColor = Color.Red;
                }
                if ((int)row.Cells["Amount"].Value > maxStock)
                {
                    row.Cells["Amount"].Style.BackColor = Color.Green;
                }
            }

            for (int i = 0; i < dgwGeneric.Rows.Count; i++)
            {
                int minStock, maxStock;
                CountStockLevel(dgwGeneric.Rows[i], out minStock, out maxStock);
                dgwGeneric.Rows[i].Cells[5].ToolTipText = String.Format("Min: {0} \nMaks: {1}", minStock, maxStock);
            }
        }


        private void minimumMaksimumÇarpanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinMaxForm minMaxForm = new MinMaxForm();
            minMaxForm.ShowDialog();
            if (cbxYear.Text == "")
            {
                return;
            }
            dgwGeneric.DataSource = LoadGenerics(cbxYear.Text);

        }

        

        private void tbxSearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbxYear.Text == "")
                {
                    return;
                }
                List<GenericDrug> searchList = LoadGenerics(cbxYear.Text).Where(g => StringMy.Parse(g.Name).RemoveLanguageSensitivity().ToLower().Contains(StringMy.Parse(tbxSearch.Texts).RemoveLanguageSensitivity().ToLower())).ToList();
                dgwGeneric.DataSource = searchList;
                tbxSearch.Texts = "";

            }
        }
    }
}
