using CsvHelper;
using L2AutoTestGenerator.Common;
using L2AutoTestGenerator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace L2AutoTestGenerator
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        #region Handle import CSV
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgImport = new OpenFileDialog();
            dlgImport.Filter = "|*.csv";
            dlgImport.Title = "Generate config file to folder";
            String filePath = "";
            if (dlgImport.ShowDialog() == DialogResult.OK)
            {
                filePath = dlgImport.FileName;
            }

            if (filePath != "")
            {
                var fields = new List<Field>();
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
                {
                    // Clear old grid
                    dgvFields.Rows.Clear();
                    var records = csv.GetRecords<Field>();
                    foreach (Field field in records)
                    {
                        fields.Add(field);
                        // TODO check and overrided old values
                        dgvFields.Rows.Add(field.Key, field.Value);
                    }
                }
            }
        }
        #endregion

        #region Handle generate
        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                // Add to json
                Dictionary<string, string> fields = new Dictionary<string, string>();
                foreach (DataGridViewRow row in dgvFields.Rows)
                {
                    // Get data from data grid
                    var key = row.Cells[0].Value;
                    var value = row.Cells[1].Value;

                    if (null != key && null != value)
                    {
                        fields.Add(key.ToString(), value.ToString());
                    }
                }

                // Export to temp path
                Utils.ExportJson(fields);
                // Open dialog to save file
                SaveFileDialog dlgGenerate = new SaveFileDialog();
                dlgGenerate.Filter = "|*.json";
                dlgGenerate.Title = "Generate config file to folder";
                if (dlgGenerate.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(Constant.SAVE_TEMP_FILE_PATH, dlgGenerate.FileName, true);
                    MessageBox.Show("Generated",
                          "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex1)
            {
                MessageBox.Show(ex1.Message.ToString(),
                    "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            catch (NullReferenceException ex2)
            {
                MessageBox.Show(ex2.Message.ToString(),
                    "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

        }
        #endregion

        #region Handle export csv
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvFields.Rows.Count > 0)
            {
                SaveFileDialog dltExport = new SaveFileDialog();
                dltExport.Filter = "CSV (*.csv)|*.csv";
                dltExport.FileName =
                    DateTime.UtcNow.Date.ToString("yyyyMMddHHmmss") + ".csv";
                if (dltExport.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int columnCount = dgvFields.Columns.Count;
                        string columnNames = "";
                        string[] outputCsv = new string[dgvFields.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dgvFields.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCsv[0] += columnNames;

                        for (int i = 1; (i - 1) < dgvFields.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                if (dgvFields.Rows[i - 1].Cells[j].Value != null)
                                {
                                    outputCsv[i] += dgvFields.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                        }

                        File.WriteAllLines(dltExport.FileName, outputCsv, Encoding.UTF8);
                        MessageBox.Show("Data Exported Successfully !!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }
        #endregion

        private void txtFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgBatchFile = new OpenFileDialog();
            dlgBatchFile.Filter = "|*.bat";
            dlgBatchFile.Title = "Choose execute file path";
            String filePath = "";
            if (dlgBatchFile.ShowDialog() == DialogResult.OK)
            {
                filePath = dlgBatchFile.FileName;
            }
            txtFilePath.Text = filePath;
        }

        #region Handle excute bat file
        private void btnExec_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text != "")
            {
               Process.Start(txtFilePath.Text);
            } else
            {
                MessageBox.Show("Please insert file path.");
            }
        }
        #endregion
        #region handle import json
        private void btnImportJson_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlgImport = new OpenFileDialog();
            //dlgImport.Filter = "|*.json";
            //dlgImport.Title = "Generate config file to folder";
            //String filePath = "";
            //if (dlgImport.ShowDialog() == DialogResult.OK)
            //{
            //    filePath = dlgImport.FileName;
            //}
            //if (filePath != "")
            //{
            //    // deserialize JSON directly from a file
            //    using (StreamReader file = File.OpenText(filePath))
            //    {
            //        JsonSerializer serializer = new JsonSerializer();
            //        List<Field> movie2 = (List<Field>)serializer.Deserialize(file, typeof(List<Field>));
            //    }
            //}
            MessageBox.Show("Chưa làm đâu, hẹn gặp lại! :v");
        }
        #endregion
    }
}
