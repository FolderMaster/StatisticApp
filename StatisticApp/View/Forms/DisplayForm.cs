using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StatisticApp.Model;
using StatisticApp.Model.Births;
using StatisticApp.Model.Shedules;

namespace StatisticApp.View.Forms
{
    public partial class DisplayForm : Form
    {
        public DisplayForm(List<string> filePathList)
        {
            InitializeComponent();

            List<BirthDataSet> birthDataSets = new List<BirthDataSet>();
            foreach (string filePath in filePathList)
            {
                birthDataSets.Add(CsvReader.ReadBitrhDataSet(filePath));
            }
            DisplayControl.Schedule = GetSchedule(birthDataSets);
        }

        private Schedule GetSchedule(List<BirthDataSet> birthDataSets)
        {
            Schedule result = new Schedule();
            result.Axises.Add(new Axis(new LogScale()));
            result.Axises.Add(new Axis(new LinearScale()));
            foreach(BirthDataSet birthData in birthDataSets)
            {
                result.Axises[0].Values.Add(birthData.Count);
                result.Axises[1].Values.Add(birthData.SexRatio);
            }
            return result;
        }
    }
}
