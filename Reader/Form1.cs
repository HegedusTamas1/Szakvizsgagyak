using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Common.MyWorldDbContext;

namespace Reader
{
    public partial class Form1 : Form
    {
        private MyWorldDbContext.SQL dbContext;
        private DataTable dataTable;
        private DataView dataView;

        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();
            FillComboBoxWithColumnHeaders(); // This will work now
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            button2.Enabled = false; // Initially disabled
        }

        private void PopulateDataGridView()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("CorrelationId", typeof(string));
            dataTable.Columns.Add("DateUtc", typeof(DateTime));
            dataTable.Columns.Add("Thread", typeof(int));
            dataTable.Columns.Add("Level", typeof(string));
            dataTable.Columns.Add("Logger", typeof(string));
            dataTable.Columns.Add("Message", typeof(string));
            dataTable.Columns.Add("Exception", typeof(string));

            int errorCount = 0;
            int debugCount = 0;
            using (SQL sql = new SQL())
            {
                foreach (var entry in sql.LogEntries)
                {
                    dataTable.Rows.Add(entry.id, entry.CorrelationId, entry.DateUTC, entry.Thread, entry.Level, entry.Logger, entry.Message, entry.Exception);
                    if (entry.Level.ToLower() == "error")
                        errorCount++;
                    else if (entry.Level.ToLower() == "debug")
                        debugCount++;
                }
            }

            dataView = dataTable.DefaultView;
            dataGridView1.DataSource = dataView;
            FillComboBoxWithColumnHeaders();
            label2.Text = $"{dataGridView1.RowCount}";
            label3.Text = $"{debugCount}";
            label4.Text = $"{errorCount}";
        }

        private void FillComboBoxWithColumnHeaders()
        {
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filterField = comboBox1.SelectedItem?.ToString();
            string filterValue = textBox1.Text;

            if (!string.IsNullOrEmpty(filterField) && !string.IsNullOrEmpty(filterValue))
            {
                dataView.RowFilter = string.Format("{0} LIKE '%{1}%'", filterField, filterValue);
                dataGridView1.DataSource = dataView;

                button2.Enabled = dataView.Count > 0;

                // Ellenõrizd, hogy a DataGridView-ban található-e kiválasztott sor
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    textBox2.Text = selectedRow.Cells["Message"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["Exception"].Value.ToString();
                }
                else
                {
                    // Ha nincs kiválasztott sor, ürítsd a TextBox-ok tartalmát
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                dataView.RowFilter = "";
                dataGridView1.DataSource = dataView;
                button2.Enabled = false;
            }
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataView.RowFilter = "";
            dataGridView1.DataSource = dataView;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFilteredDataToCSV();
        }

        private void SaveFilteredDataToCSV()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Save as CSV"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    var headers = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    sw.WriteLine(string.Join(";", headers));

                    foreach (DataRowView rowView in dataView)
                    {
                        var row = rowView.Row;
                        var items = row.ItemArray.Select(item => item.ToString());
                        sw.WriteLine(string.Join(";", items));
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox2.Text = selectedRow.Cells["Message"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Exception"].Value.ToString();
            }
        }

        private void Keresés_Click(object sender, EventArgs e)
        {
            buttonSearch_Click(sender, e);
        }
    }
}
