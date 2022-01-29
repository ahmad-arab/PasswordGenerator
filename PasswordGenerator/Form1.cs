using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Entry> en = new List<Entry>();
            for(int i = 0;i<dataGridView1.Rows.Count;i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value == null || dataGridView1.Rows[i].Cells[2].Value == null)
                    continue;

                if (String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()) || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                    continue;
                string note = "";
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                    note = dataGridView1.Rows[i].Cells[3].Value.ToString();

                Entry temp = new Entry
                {
                    Username = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    Password = dataGridView1.Rows[i].Cells[2].Value.ToString(),

                    Note = note
                };
                if(dataGridView1.Rows[i].Cells[0].Value == null)
                    en.Add(temp);
            }

            if (Data.AddToDataBase(en))
                Populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            List<Entry> temp = new List<Entry>();

            temp = Data.ImportFromDataBase();

            for(int i = 0;i<temp.Count;i++)
            {
                dataGridView1.Rows.Add(temp[i].Id.ToString(), temp[i].Username, temp[i].Password, temp[i].Note);
            }
        }
        private void Populate()
        {
            dataGridView1.Rows.Clear();

            List<Entry> temp = new List<Entry>();

            temp = Data.ImportFromDataBase();

            for (int i = 0; i < temp.Count; i++)
            {
                dataGridView1.Rows.Add(temp[i].Id.ToString(), temp[i].Username, temp[i].Password, temp[i].Note);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = Data.DataSource.Substring(12);

            Data.ImportFromDataBase();

            Populate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Data.DataSource ="data source="+ textBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete the specified entries?", "Conformation", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                return;
            List<int> temp = new List<int>();
            for(int i = 0;i<dataGridView1.SelectedRows.Count;i++)
            {
                if (dataGridView1.SelectedRows[i].Cells[0].Value == null)
                    continue;

                temp.Add(int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()));
            }

            if (Data.DeleteFromDataBase(temp))
                Populate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete all entries from the database?", "Conformation", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                return;
            if (Data.ClearDataBase())
                Populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Entry> en = new List<Entry>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value == null || dataGridView1.Rows[i].Cells[2].Value == null
                    || dataGridView1.Rows[i].Cells[0].Value == null)
                    continue;

                if (String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()) || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                    continue;
                string note = "";
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                    note = dataGridView1.Rows[i].Cells[3].Value.ToString();

                Entry temp = new Entry
                {
                    Id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                    Username = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    Password = dataGridView1.Rows[i].Cells[2].Value.ToString(),

                    Note = note
                };
                en.Add(temp);
            }

            if (Data.UpdateDataBase(en))
                Populate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }

        

       public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

            //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "your header text";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
        }
    }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Generator.Length = (int)numericUpDown2.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
                Populate();

            else
            {
                dataGridView1.Rows.Clear();

                List<Entry> temp = new List<Entry>();

                temp = Data.ImportFromDataBase().Where(x=> x.Note.Contains(textBox1.Text)).ToList();

                for (int i = 0; i < temp.Count; i++)
                {
                    dataGridView1.Rows.Add(temp[i].Id.ToString(), temp[i].Username, temp[i].Password, temp[i].Note);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for(int i = 0;i<(int)numericUpDown1.Value;i++)
            {
                string u = Generator.GenerateUsername();
                while(Data.Entries.Find(x=>x.Username==u)!=null)
                {
                    u = Generator.GenerateUsername();
                }
                string p = Generator.GeneratePassword();

                dataGridView1.Rows.Add(null, u, p, " ");
            }
        }
    }
}
