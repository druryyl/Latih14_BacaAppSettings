using Microsoft.Extensions.Configuration;

namespace Latih14_BacaAppSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadConfiguration();
        }
        private void LoadConfiguration()
        {
            var appSettings = Program.Configuration.GetSection("AppSettings");
            var connectionString = Program.Configuration.GetConnectionString("DefaultConnection");

            string appName = appSettings["ApplicationName"];
            string version = appSettings["Version"];
            string theme = appSettings.GetSection("Settings")["Theme"];
            string language = appSettings.GetSection("Settings")["Language"];

            MessageBox.Show($"App Name: {appName}\nVersion: {version}\nTheme: {theme}\nLanguage: {language}\nConnection String: {connectionString}");
        }
    }
}
