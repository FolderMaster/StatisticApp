using StatisticApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticApp.View.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsFormat Settings
        {
            get
            {
                return SettingsControl.Settings;
            }
            set
            {
                SettingsControl.Settings = value;
            }
        }

        public SettingsForm(SettingsFormat settings)
        {
            InitializeComponent();

            SettingsControl.Settings = settings;
        }
    }
}
