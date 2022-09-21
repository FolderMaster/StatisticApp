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
using StatisticApp.Model.Schedules;

using Point = StatisticApp.Model.Schedules.Point;

namespace StatisticApp.View.Forms
{
    public partial class DisplayForm : Form
    {
        public DisplayForm(List<string> filePathList, SettingsFormat settings)
        {
            InitializeComponent();

            DisplayControl.Settings = settings;
            if(filePathList != null)
            {
                List<BirthDataSet> birthDataSets = new List<BirthDataSet>();
                foreach (string filePath in filePathList)
                {
                    if (filePath.EndsWith(".csv"))
                    {
                        birthDataSets.Add(CsvManager.ReadBitrhDataSet(filePath));
                    }
                    else if (filePath.EndsWith(".xlsx"))
                    {
                        birthDataSets.Add(XlsxManager.ReadBitrhDataSet(filePath));
                    }
                }
                DisplayControl.Schedule = GetSchedule(birthDataSets);
                DisplayControl.DefaultDisplay();
            }
        }

        private Schedule GetSchedule(List<BirthDataSet> birthDataSets)
        {
            Schedule result = new Schedule();
            result.Axises.Add(new Axis(new LogScale()));
            result.Axises.Add(new Axis(new LinearScale()));
            foreach(BirthDataSet birthData in birthDataSets)
            {
                result.Shapes.Add(new Point(new List<double>{birthData.Count,
                    birthData.SexRatio}));
            }
            
            double generalSexRatio = BirthDataSet.GetGeneralSexRatio(birthDataSets);
            result.Shapes.Add(new LineSegment(
                new Point(new List<double> {result.GetMin(0), generalSexRatio}),
                new Point(new List<double> {result.GetMax(0), generalSexRatio })));
            return result;
        }
    }
}