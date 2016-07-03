namespace MultiTiffCounterAMF
{
    partial class frmTiff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiff));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExplore = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPages = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chkJustName = new System.Windows.Forms.CheckBox();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\";
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(327, 56);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 23);
            this.btnExplore.TabIndex = 0;
            this.btnExplore.Text = "...";
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 59);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(297, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:/myFiles/";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(408, 56);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Count";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.Location = new System.Drawing.Point(13, 85);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(891, 358);
            this.lstResultados.TabIndex = 3;
            this.lstResultados.UseCompatibleStateImageBehavior = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(759, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.andresmeza.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "This tool allows to count the number of pages in all the multi-page tiff files un" +
    "der a given folder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose a folder and click Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Pages:";
            // 
            // txtTotalPages
            // 
            this.txtTotalPages.AutoSize = true;
            this.txtTotalPages.Location = new System.Drawing.Point(583, 56);
            this.txtTotalPages.Name = "txtTotalPages";
            this.txtTotalPages.Size = new System.Drawing.Size(13, 13);
            this.txtTotalPages.TabIndex = 8;
            this.txtTotalPages.Text = "0";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(829, 56);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkJustName
            // 
            this.chkJustName.AutoSize = true;
            this.chkJustName.Checked = true;
            this.chkJustName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJustName.Location = new System.Drawing.Point(714, 37);
            this.chkJustName.Name = "chkJustName";
            this.chkJustName.Size = new System.Drawing.Size(116, 17);
            this.chkJustName.TabIndex = 10;
            this.chkJustName.Text = "Just Names Report";
            this.chkJustName.UseVisualStyleBackColor = true;
            // 
            // chkFolder
            // 
            this.chkFolder.AutoSize = true;
            this.chkFolder.Location = new System.Drawing.Point(714, 61);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(90, 17);
            this.chkFolder.TabIndex = 11;
            this.chkFolder.Text = "Folder Report";
            this.chkFolder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Folder Report might not be accurate beyond one level";
            // 
            // frmTiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkFolder);
            this.Controls.Add(this.chkJustName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtTotalPages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnExplore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTiff";
            this.Text = "Multi-Tiff File Counter  v3.0";
            this.Load += new System.EventHandler(this.frmTiff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.ListView lstResultados;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotalPages;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chkJustName;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.Label label4;
    }
}

