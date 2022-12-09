using System;
using System.Windows.Forms;

using PrimaryStatisticProcessingApp.Services.App;
using PrimaryStatisticProcessingApp.Services.IO;

namespace PrimaryStatisticProcessingApp.Views.Forms
{
    public partial class MainForm : Form
    {
        private Session _session = new Session();

        private Settings _settings = new Settings();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveFormat save = new SaveFormat();
            try
            {
                save = JsonManager.Load<SaveFormat>(_settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
            finally
            {
                _session = save == null ? _session : save.Session;
                MainTab.FilePathList = _session.FilePathList;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFormat save = new SaveFormat(_session);
            try
            {
                JsonManager.Save(save, _settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}