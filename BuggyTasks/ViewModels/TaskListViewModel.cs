using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using BuggyTasks.Models;

namespace BuggyTasks.ViewModels;

public partial class TaskListViewModel : ObservableObject
{
    public ObservableCollection<TaskItem> Tasks { get; set; }

    public TaskListViewModel()
    {
        Tasks = new ObservableCollection<TaskItem>
        {
            new TaskItem { Title = "Test Task 1" },
            new TaskItem { Title = "Test Task 2" }
        };
    }
}
