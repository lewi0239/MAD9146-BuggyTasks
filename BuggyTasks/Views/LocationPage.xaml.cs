using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices.Sensors;
using System;

namespace BuggyTasks.Views
{
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent();
        }

        async void OnGetLocation(object sender, EventArgs e)

        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                var location = await Geolocation.Default.GetLocationAsync(request);

                if (location != null)
                {
                    locationLabel.Text = $"Latitude: {location.Latitude:F6}, Longitude: {location.Longitude:F6}";
                }
                else
                {
                    locationLabel.Text = "Location was located.";
                }
            }
            catch (Exception ex)
            {
                locationLabel.Text = $"Error: {ex.Message}";
            }
        }
    }
}
