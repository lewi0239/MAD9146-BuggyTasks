using Microsoft.Maui.Controls;
using System;

namespace BuggyTasks.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnGoToTaskList(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TaskListPage");
        }

        async void OnAddTask(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("NewTaskPage");
        }

        async void OnGetLocation(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("LocationPage");
        }

        async void OnDeviceInfo(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("DeviceInfoPage");
        }
    }
}
