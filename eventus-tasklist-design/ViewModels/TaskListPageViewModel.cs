using eventus_tasklist_design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;

namespace eventus_tasklist_design.ViewModels
{
    public class TaskListPageViewModel
    {
        public List<TasklistItem> Tasks {
            get => new List<TasklistItem> {
                new TasklistItem{
                    IsError = Visibility.Visible,
                    PriorityColor = Color.FromArgb(255,76,175,80)
                },
                new TasklistItem{
                    IsLocked = Visibility.Visible,
                    PriorityColor = Color.FromArgb(255,255,235,59)
                },
                new TasklistItem{
                    IsNew = Visibility.Visible,
                    PriorityColor = Color.FromArgb(255,255,152,0)
                },
                new TasklistItem{
                    IsSaved = Visibility.Visible
                },
                new TasklistItem{
                    IsSaved = Visibility.Visible,
                    IsError = Visibility.Visible,
                    PriorityColor = Color.FromArgb(255,244,67,54)
                },
                new TasklistItem{
                    IsSaved = Visibility.Visible,
                    IsError = Visibility.Visible,
                    IsLocked = Visibility.Visible,
                    PriorityColor = Color.FromArgb(255,255,193,7),
                    TaskName = "Nagyon hosszu fajlnev, ami amit az angol billentyuzeten nem tudok leirni rendesen Nagyon hosszu fajlnev, ami amit az angol billentyuzeten nem tudok leirni rendesen Nagyon hosszu fajlnev, ami amit az angol billentyuzeten nem tudok leirni rendesen"
                },
            };
        }
    }
}