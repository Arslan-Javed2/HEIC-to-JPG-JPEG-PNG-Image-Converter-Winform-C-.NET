using ImageConverter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
        }

        private void pictureBoxAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set filter options and filter index
            openFileDialog.Filter = "Image (*.heic)|*.heic|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath=openFileDialog.FileName;
                //string fileName=Path.GetFileName(filePath);
                FileInfo fileInfo = new FileInfo(filePath);
                string fileName = fileInfo.Name;
                double fileSize = fileInfo.Length / (1024.0 * 1024.0);

                List<FileInformation> fileInformation = new List<FileInformation>();
                FileInformation infoFile = new FileInformation()
                {
                    FileName = fileName,
                    FileSize = fileSize.ToString(),
                    FilePath = filePath
                };
                for(int i = 0; i<5;i++)
                {
                    fileInformation.Add(infoFile);
                }
                dataGridView1.DataSource = fileInformation;
                MessageBox.Show($"File Path: {filePath} \nFile Name: {fileName} \nFile Size: {fileSize:F2} MB");
            }
        }

        private void imageClearAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
            }
        }

        private void imageAddOutPutPath_Click(object sender, EventArgs e)
        {

        }
    }
}
