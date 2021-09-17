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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.dlgImport = new System.Windows.Forms.OpenFileDialog();
            this.dlgExport = new System.Windows.Forms.SaveFileDialog();
            this.dlgGenerate = new System.Windows.Forms.SaveFileDialog();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(446, 23);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(302, 42);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 36);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(221, 42);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 36);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(383, 42);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 36);
            this.btnGen.TabIndex = 3;
            this.btnGen.Text = "Generate JSON";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // dgvFields
            // 
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colKey,
            this.colVal});
            this.dgvFields.Location = new System.Drawing.Point(13, 84);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.Size = new System.Drawing.Size(445, 239);
            this.dgvFields.TabIndex = 4;
            // 
            // dlgImport
            // 
            this.dlgImport.FileName = "openFileDialog1";
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No.";
            this.colNo.Name = "colNo";
            // 
            // colKey
            // 
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.Width = 150;
            // 
            // colVal
            // 
            this.colVal.HeaderText = "Value";
            this.colVal.Name = "colVal";
            this.colVal.Width = 150;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.dgvFields);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtFilePath);
            this.Name = "FMain";
            this.Text = "FMain";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVal;
    }
}