using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PrimaryStatisticProcessingApp.Views.Controls
{
    public partial class FileListControl : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<string> _filePathList = new List<string>();

        private string _filter = "Tables (*.csv)|*.csv";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> FilePathList
        {
            get
            {
                return _filePathList;
            }
            set
            {
                _filePathList = value;
                _bindingSource.DataSource = _filePathList;
            }
        }

        public string SelectedFilePath
        {
            get
            {
                if (ListBox.SelectedIndex == -1)
                {
                    return null;
                }
                else
                {
                    return FilePathList[SelectedIndex];
                }
            }
        }

        public int SelectedIndex
        {
            get
            {
                return ListBox.SelectedIndex;
            }
            set
            {
                ListBox.SelectedIndex = value;
            }
        }

        public FileListControl()
        {
            InitializeComponent();

            _bindingSource.DataSource = FilePathList;
            ListBox.DataSource = _bindingSource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = _filter;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathList.Add(fileDialog.FileName);
                _bindingSource.ResetBindings(false);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex != -1)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = _filter;
                fileDialog.FileName = FilePathList[SelectedIndex];
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePathList[SelectedIndex] = fileDialog.FileName;
                    _bindingSource.ResetBindings(false);
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex != -1)
            {
                FilePathList.RemoveAt(SelectedIndex);
                _bindingSource.ResetBindings(false);
            }
        }
    }
}
