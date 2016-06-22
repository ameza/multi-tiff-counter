using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MultiTiffCounterAMF
{
    public partial class frmTiff : Form
    {
        public frmTiff()
        {
            InitializeComponent();
            CurrentList=new List<Item>();
        }

        public List<Item> CurrentList { get; set; }

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
                saveFileDialog1.InitialDirectory = txtPath.Text;
                var now = DateTime.Now;
                saveFileDialog1.FileName = Path.GetFileName(txtPath.Text)+"_"+String.Format("{0}_{1}_{2}-{3}_{4}_{5}.csv",now.Day,now.Month,now.Year,now.Hour,now.Minute,now.Second);
                var dirList = DirSearch(txtPath.Text);
              
                foreach (var path in from path in dirList let extension = Path.GetExtension(path) where extension != null && (extension.Equals(".tiff") || extension.Equals(".tif")) select path)
                {
                    CurrentList.Add(new Item(path, PageCounter(path)));
                }
                lstResultados.View = View.Details;
                lstResultados.Columns.Clear();
                lstResultados.Columns.Add("Path");
                lstResultados.Columns[0].Width = 650;
                lstResultados.Columns.Add("Total");
                var totalPages = 0;
                foreach (var item in CurrentList)
                {
                        lstResultados.Items.Add(new ListViewItem(new string[] {item.Path, item.TotalPages.ToString()}));
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var result = this.saveFileDialog1.ShowDialog();
                if (result != DialogResult.OK) return;
                WriteCsv(CurrentList, saveFileDialog1.FileName);
                MessageBox.Show("Saved!!");
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
           
        }

        public void WriteCsv<T>(IEnumerable<T> items, string path)
        {
            var itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                .OrderBy(p => p.Name);

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }


       
    }
}
