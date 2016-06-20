using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MultiTiffCounterAMF
{
    public partial class frmTiff : Form
    {
        public frmTiff()
        {
            InitializeComponent();
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void frmTiff_Load(object sender, EventArgs e)
        {
          
        }


        private static IEnumerable<String> DirSearch(string sDir)
        {
            var files = new List<String>();
            var noError = true;
            try
            {
                files.AddRange(Directory.GetFiles(sDir));
                foreach (var d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(DirSearch(d));
                }
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            return files;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This tools does a deep search on the folder, do you really want to count this folder?",
                                     "Confirm Count!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var dirList = DirSearch(txtPath.Text);
                var finalList = dirList.Select(filepath => new Item(filepath, PageCounter(filepath))).ToList();
                lstResultados.View = View.Details;
                lstResultados.Columns.Clear();
                lstResultados.Columns.Add("Path");
                lstResultados.Columns.Add("Total");
                var totalPages = 0;
                foreach (var item in finalList)
                {
                    lstResultados.Items.Add(new ListViewItem(new string[] { item.Path, item.TotalPages.ToString() }));
                    totalPages += item.TotalPages;
                }
                txtTotalPages.Text = totalPages.ToString();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private static int PageCounter(string file)
        {
            var count = 0;
            try
            {
                using (var bmpImage = new Bitmap(file))
                {
                    count = bmpImage.GetFrameCount(FrameDimension.Page);
                }
            }
            catch (Exception)
            {
                count = 0;
            }
           

            return count;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sInfo = new ProcessStartInfo("http://www.andresmeza.com");
            Process.Start(sInfo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
    }
}
