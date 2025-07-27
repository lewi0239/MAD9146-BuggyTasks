using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace BuggyTasks.ViewModels;

public partial class NewTaskViewModel : ObservableObject
{

    [ObservableProperty]
    private string newTaskTitle = string.Empty;

    public ICommand AddNewTaskCommand { get; }

    public NewTaskViewModel()
    {
        AddNewTaskCommand = new RelayCommand(OnAddTask);
    }

    void OnAddTask()
    {
        TaskListViewModel.Instance.AddTask(NewTaskTitle);
        // Simulate adding a task
        Console.WriteLine($"Added task: {NewTaskTitle}");
        NewTaskTitle = string.Empty;

    }
}
