using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using PrimaryStatisticProcessingApp.Models;
using PrimaryStatisticProcessingApp.Services.Factories;

namespace PrimaryStatisticProcessingApp.Views.Controls
{
    public partial class SampleControl : UserControl
    {
        private Sample _sample = new Sample();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Sample Sample
        {
            get => _sample;
            set
            {
                _sample = value;
                if(Sample != null)
                {
                    UpdateInfo();
                }
                else
                {
                    ClearInfo();
                }
            }
        }

        public SampleControl()
        {
            InitializeComponent();
        }

        private void UpdateInfo()
        {
            SortedSampleGridView.DataSource = Sample.SortedSample.IdValues.Select((list) => new
            {
                Id = list.Item1,
                Value = list.Item2
            }).ToList();
            MinTextBox.Text = Sample.Min.ToString();
            MaxTextBox.Text = Sample.Max.ToString();
            RangeTextBox.Text = Sample.Range.ToString();
            IntervalCountTextBox.Text = Sample.IntervalCount.ToString();
            IntervalRangeTextBox.Text = Sample.IntervalRange.ToString();
            VariationalTableGridView.DataSource = Sample.VariationalTable.Select((list) => new
            {
                Middle = list.Item1,
                Count = list.Item2
            }).ToList();
            MeanTextBox.Text = Sample.Mean.ToString();
            MeadianTextBox.Text = Sample.Median.ToString();
            VarianceTextBox.Text = Sample.Variance.ToString();
            StandardDeviationTextBox.Text = Sample.StandardDeviation.ToString();
            ThirdOrderMomentTextBox.Text = Sample.ThirdOrderMoment.ToString();
            FourthOrderMomentTextBox.Text = Sample.FourthOrderMoment.ToString();
            AsymmetryTextBox.Text = Sample.Asymmetry.ToString();
            ExcessTextBox.Text = Sample.Excess.ToString();
            BarChartDisplayControl.Graph = GraphFactory.CreateBarChartBySample(Sample);
        }

        private void ClearInfo()
        {
            MinTextBox.Text = MaxTextBox.Text = RangeTextBox.Text = IntervalCountTextBox.Text = 
                IntervalRangeTextBox.Text = MeanTextBox.Text = MeadianTextBox.Text = 
                VarianceTextBox.Text =  StandardDeviationTextBox.Text = 
                ThirdOrderMomentTextBox.Text = FourthOrderMomentTextBox.Text = 
                AsymmetryTextBox.Text = ExcessTextBox.Text = null;
            VariationalTableGridView.DataSource = SortedSampleGridView.DataSource = null;
            BarChartDisplayControl.Graph = null;
        }
    }
}