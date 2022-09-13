using System;
using System.Collections.Generic;
using System.Windows.Forms;

using StatisticApp.Model;

namespace StatisticApp.View.Forms
{
    public partial class MainForm : Form
    {
        private string _filePath = "Save.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> filePathList = JsonManager.Load<List<string>>(_filePath);
                if (filePathList != null)
                {
                    FileListControl.FilePathList = filePathList;
                }
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                JsonManager.Save(FileListControl.FilePathList, _filePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = new DisplayForm(FileListControl.FilePathList);
            displayForm.ShowDialog();
        }
    }
}