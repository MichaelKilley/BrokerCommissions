using CsvHelper;
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

namespace BrokerCommissions
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        // CsvReadWrite Can Read a CSV File
        // or write Required CSV Files
        CsvReadWrite csvreadwrite = new CsvReadWrite();

        Broker b = new Broker();


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnRead_Click(object sender, EventArgs e)
        {
            // Use the OpenfileDialog so that a user can can select the CSV to perform all the actions on.
            // Use the CsvReadWrite Class

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        DataTable table = new DataTable();

                        table = csvreadwrite.CsvRead(ofd.FileName);
                        dataGridView.DataSource = new BindingSource(table, null);

                        btnBaseCSV.Enabled = true;
                        btnBonus1New.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ex1. " + ex.Message);
                    }
                }

            }
            dataGridView.Columns["Total commission in £"].Width = 140;
            dataGridView.Columns["commission in £"].Width = 140;

        }

        private void btnBaseCSV_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "CSV|*.csv";
            sfd.Title = "Save  CSV File";
            sfd.FileName = "Base Bonus";

            string tempFileName = "";
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    tempFileName = sfd.FileName;
                    WriteAllCSV(tempFileName, 0);

                    MessageBox.Show(tempFileName, "CSV file Created");
                }
            }
        }


        private void btnBonus2_Click(object sender, EventArgs e)
        {
            // Bonus 2
            if (!this.dataGridView.Columns.Contains("CalcBonus2"))
            {
                this.dataGridView.Columns.Add("CalcBonus2", "Bonus 2 £");
            }


            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)

            {

                string temp = "";
                DataGridViewRow row = dataGridView.Rows[i];
                temp = (row.Cells["CaseValue"].Value).ToString();

                decimal BonusAmout = b.BonusCalculation(temp, 50000, 250000);
                row.Cells["CalcBonus2"].Value = BonusAmout;

                string tcalc = (row.Cells["CalcBonus1"].Value).ToString();
                row.Cells["Total commission in £"].Value = b.TotalCommissionCalculation(decimal.Parse(tcalc), BonusAmout, 0);

            }

            btnCsvBonus2.Enabled = true;
        }

        private void btnCsvBonus1_Click(object sender, EventArgs e)
        {
            // btnCsvBonus1

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "CSV|*.csv";
            sfd.Title = "Save  CSV File";
            sfd.FileName = "Commission bonus1";

            string tempFileName = "";
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    tempFileName = sfd.FileName;

                    WriteAllCSV(tempFileName, 1);
                    MessageBox.Show(tempFileName, "CSV file Created");
                }
            }

        }

        private void btnBonus3_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView.Columns.Contains("CalcBonus3"))
            {
                this.dataGridView.Columns.Add("CalcBonus3", "Bonus 3 £");
            }

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)

            {

                string temp = "";
                DataGridViewRow row = dataGridView.Rows[i];
                temp = (row.Cells["CaseValue"].Value).ToString();

                decimal BonusAmout = b.BonusCalculation(temp, 75000, 250000);

                row.Cells["CalcBonus3"].Value = BonusAmout;

                string tcalc = (row.Cells["CalcBonus1"].Value).ToString();
                string tcalc2 = (row.Cells["CalcBonus2"].Value).ToString();
                row.Cells["Total commission in £"].Value = b.TotalCommissionCalculation(decimal.Parse(tcalc), decimal.Parse(tcalc2), BonusAmout);

            }
            btnCsvBonus3.Enabled = true;
        }

        private void btnCsvBonus2_Click(object sender, EventArgs e)
        {
            // btnCsvBonus2
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "CSV|*.csv";
            sfd.Title = "Save  CSV File";
            sfd.FileName = "Bonus 2";

            string tempFileName = "";
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    tempFileName = sfd.FileName;

                    WriteAllCSV(tempFileName, 2);
                    MessageBox.Show(tempFileName, "CSV file Created");
                    btnBonus3.Enabled = true;
                }
            }


        }

        private void btnCsvBonus3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "CSV|*.csv";
            sfd.Title = "Save  CSV File";
            sfd.FileName = "Bonus 3";

            string tempFileName = "";
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    tempFileName = sfd.FileName;

                    WriteAllCSV(tempFileName, 3);
                    MessageBox.Show(tempFileName, "CSV file Created");
                }
            }
        }

        private void btnBonus1New_Click(object sender, EventArgs e)
        {

            if (!this.dataGridView.Columns.Contains("CalcBonus1"))
            {
                this.dataGridView.Columns.Add("CalcBonus1", "Commission bonus in £");
                dataGridView.Columns["CalcBonus1"].Width = 140;
            }

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)

            {

                string temp = "";
                DataGridViewRow row = dataGridView.Rows[i];

                temp = (row.Cells["CaseValue"].Value).ToString();
                decimal BonusAmout = b.BonusCalculation(temp, 10000, 100000);

                // row.Cells[4].Value = BonusAmout;
                row.Cells["CalcBonus1"].Value = BonusAmout;

                row.Cells["Total commission in £"].Value = b.TotalCommissionCalculation(BonusAmout, 0, 0);

            }
            btnBonus2.Enabled = true;
            btnCsvBonus1.Enabled = true;
        }

        #region Write all the csv Files
        //// create csv file base CSV = 0, bonus 1 = 1, bonus 2 = 2, bonus 3 = 3, 
        private void WriteAllCSV(string tempFileName, int Bfile)
        {
            StreamWriter sw = new StreamWriter(tempFileName, false, new UTF8Encoding(true)); // to rectify "Â"

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                string header = dataGridView.Columns[i].HeaderText;
                if (Bfile == 0 && (header == "CaseValue" | header == "Total commission in £" | header == "Commission bonus in £" | header == "Bonus 2 £" | header == "Bonus 3 £")) { continue; }
                if (Bfile == 1 && (header == "CaseValue" | header == "Total commission in £" | header == "Bonus 2 £" | header == "Bonus 3 £")) { continue; }

                if ((Bfile == 2 | Bfile == 3) && (header == "CaseValue" | header == "Case ID" | header == "commission in £" | header == "Commission bonus in £" | header == "Bonus 2 £" | header == "Bonus 3 £")) { continue; }

                sw.Write(dataGridView.Columns[i].HeaderText);
                if (i != dataGridView.Columns.Count)
                {
                    sw.Write(",");
                }
            }

            sw.Write(sw.NewLine);

            foreach (DataGridViewRow dr in dataGridView.Rows)
            {

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    string header = dataGridView.Columns[i].HeaderText;
                    if (Bfile == 0 && (header == "CaseValue" | header == "Total commission in £" | header == "Commission bonus in £" | header == "Bonus 2 £" | header == "Bonus 3 £")) { continue; }
                    if (Bfile == 1 && (header == "CaseValue" | header == "Total commission in £" | header == "Bonus 2 £" | header == "Bonus 3 £")) { continue; }

                    if ((Bfile == 2 | Bfile == 3) && (header == "CaseValue" | header == "Case ID" | header == "commission in £" | header == "Commission bonus in £" | header == "Bonus 2 £" | header == "Bonus 3 £")) { continue; }

                    sw.Write(dr.Cells[i].Value);

                    if (i != dataGridView.Columns.Count)
                    {
                        sw.Write(",");
                    }

                }
                sw.Write(sw.NewLine);
            }
            sw.Flush();
            sw.Close();

        }
        // End of create csv file base CSV = 0, bonus 1 = 1, bonus 2 = 2, bonus 3 = 3, 
        #endregion

    }
}
