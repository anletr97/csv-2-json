using CsvHelper;
using L2AutoTestGenerator.Common;
using L2AutoTestGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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

            var fields = new List<Field>();
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                var records = csv.GetRecords<Field>();
                int i = 1;
                foreach (Field field in records)
                {
                    fields.Add(field);
                    // TODO check and overrided old values
                    dgvFields.Rows.Add(i, field.Key, field.Value);
                    i++;
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
                    var key = row.Cells[1].Value;
                    var value = row.Cells[2].Value;

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


    }
}
