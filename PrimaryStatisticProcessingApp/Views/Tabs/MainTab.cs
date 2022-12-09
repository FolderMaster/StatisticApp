using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using PrimaryStatisticProcessingApp.Models;
using PrimaryStatisticProcessingApp.Services.Factories;

namespace PrimaryStatisticProcessingApp.Views.Tabs
{
    public partial class MainTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> FilePathList
        {
            get => FileListControl.FilePathList;
            set => FileListControl.FilePathList = value;
        }

        public MainTab()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            List<Sample> samples = new List<Sample>();
            foreach(string filePath in FilePathList)
            {
                samples.Add(SampleFactory.LoadSample(filePath));
            }
            SampleListControl.Samples = samples;
        }

        private void SampleListControl_SelectedSampleChanged(object sender, EventArgs e)
        {
            SampleControl.Sample = SampleListControl.SelectedSample;
        }
    }
}