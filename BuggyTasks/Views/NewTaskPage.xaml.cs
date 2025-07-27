using BuggyTasks.ViewModels;  

namespace BuggyTasks.Views;

public partial class NewTaskPage : ContentPage
{
    public NewTaskPage()
    {
        InitializeComponent();

        BindingContext = new NewTaskViewModel();
    }
}