using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using PrimaryStatisticProcessingApp.Models;

namespace PrimaryStatisticProcessingApp.Views.Controls
{
    public partial class SampleListControl : UserControl
    {
        private List<Sample> _samples = new List<Sample>();

        private Sample _selectedSample = null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Sample> Samples
        {
            get => _samples;
            set
            {
                _samples = value;
                ListBox.DataSource = _samples;
                if(Samples.Count > 0)
                {
                    ListBox.SelectedIndex = 0;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Sample SelectedSample
        {
            get => _selectedSample;
            set
            {
                if(value != _selectedSample)
                {
                    _selectedSample = value;
                    SelectedSampleChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler SelectedSampleChanged;

        public SampleListControl()
        {
            InitializeComponent();

            ListBox.DataSource = _samples;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBox.SelectedIndex != -1)
            {
                SelectedSample = _samples[ListBox.SelectedIndex];
            }
            else
            {
                SelectedSample = null;
            }
        }
    }
}
