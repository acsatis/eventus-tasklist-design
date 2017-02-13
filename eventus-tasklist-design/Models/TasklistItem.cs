using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;

namespace eventus_tasklist_design.Models
{
    public class TasklistItem
    {
        public string TicketId { get; set; } = "123456";
        public string TaskNumber { get; set; } = "12";
        public string TaskName { get; set; } = "Nagyon hosszu fajlnev, ami amit az angol billentyuzeten nem tudok leirni rendesen";
        public string Priority { get; set; } = "100";
        public Color PriorityColor { get; set; } = Color.FromArgb(255, 244, 67, 54);
        public string GroupName { get; set; } = "Sanyika groupja";
        public string ImageSource { get; set; } = "";
        public string Executor { get; set; } = "Acs attila marinénike kiskutyája";
        public string DueDate { get; set; } = "10.17";
        public string DueDateTime { get; set; } = "12:12";
        public string Distance { get; set; } = "123";
        public Visibility IsSaved { get; set; } = Visibility.Collapsed;
        public Visibility IsNew { get; set; } = Visibility.Collapsed;
        public Visibility NegateIsNew { get { return (IsNew == Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility IsLocked { get; set; } = Visibility.Collapsed;
        public Visibility IsError { get; set; } = Visibility.Collapsed;
    }
}
