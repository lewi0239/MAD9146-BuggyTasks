using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace BuggyTasks.Views
{
    public partial class DeviceInfoPage : ContentPage
    {
        public DeviceInfoPage()
        {
            InitializeComponent();

            // Set label texts with device info
            modelLabel.Text = $"Model: {DeviceInfo.Model}";
            platformLabel.Text = $"Platform: {DeviceInfo.Platform}";
        }
    }
}
