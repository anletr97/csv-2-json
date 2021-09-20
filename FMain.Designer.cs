namespace L2AutoTestGenerator
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlgImport = new System.Windows.Forms.OpenFileDialog();
            this.dlgExport = new System.Windows.Forms.SaveFileDialog();
            this.dlgGenerate = new System.Windows.Forms.SaveFileDialog();
            this.dlgBatchFile = new System.Windows.Forms.OpenFileDialog();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnImportJson = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFilePath.Location = new System.Drawing.Point(13, 322);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(445, 23);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.Text = "Click to browse...";
            this.txtFilePath.Click += new System.EventHandler(this.txtFilePath_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(92, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 36);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(252, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 36);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(173, 12);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(73, 36);
            this.btnGen.TabIndex = 3;
            this.btnGen.Text = "Export JSON";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // dgvFields
            // 
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colVal});
            this.dgvFields.Location = new System.Drawing.Point(13, 54);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.Size = new System.Drawing.Size(445, 239);
            this.dgvFields.TabIndex = 4;
            // 
            // colKey
            // 
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.Width = 200;
            // 
            // colVal
            // 
            this.colVal.HeaderText = "Value";
            this.colVal.Name = "colVal";
            this.colVal.Width = 200;
            // 
            // dlgImport
            // 
            this.dlgImport.FileName = "openFileDialog1";
            // 
            // dlgBatchFile
            // 
            this.dlgBatchFile.FileName = "openFileDialog1";
            // 
            // btnExec
            // 
            this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExec.Location = new System.Drawing.Point(12, 351);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(446, 37);
            this.btnExec.TabIndex = 5;
            this.btnExec.Text = "Execute BAT";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnImportJson
            // 
            this.btnImportJson.Location = new System.Drawing.Point(13, 12);
            this.btnImportJson.Name = "btnImportJson";
            this.btnImportJson.Size = new System.Drawing.Size(73, 36);
            this.btnImportJson.TabIndex = 6;
            this.btnImportJson.Text = "Import JSON";
            this.btnImportJson.UseVisualStyleBackColor = true;
            this.btnImportJson.Click += new System.EventHandler(this.btnImportJson_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(11, 306);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(51, 13);
            this.lblFilePath.TabIndex = 7;
            this.lblFilePath.Text = "Batch file";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 407);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnImportJson);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.dgvFields);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.Text = "L2 Auto Test Support Tool";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.OpenFileDialog dlgImport;
        private System.Windows.Forms.SaveFileDialog dlgExport;
        private System.Windows.Forms.SaveFileDialog dlgGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVal;
        private System.Windows.Forms.OpenFileDialog dlgBatchFile;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnImportJson;
        private System.Windows.Forms.Label lblFilePath;
    }
}