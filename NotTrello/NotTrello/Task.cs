using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NotTrello
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TicketNumber { get; set; }
        public Color TaskColor { get; set; }
        public DateTime Date { get; set; }
        public object Status { get; set; }

        public Task(int taskID, string name, string description, string ticketNumber, Color color, DateTime date, object status)
        {
            TaskID = taskID;
            Name = name;
            Description = description;
            TicketNumber = ticketNumber;
            TaskColor = color;
            Date = date;
            Status = status;
        }

        public Task()
        {
            TaskID = 00000000;
            Name = "New Task";
            Description = "Description...";
            TicketNumber = "XXXXXXXX";
            TaskColor = (Color)ColorConverter.ConvertFromString("LimeGreen");
            Date = DateTime.Today;
            Status = 0;
        }

        public Task(int taskID)
        {
            TaskID = taskID;
            Name = "New Task";
            Description = "Description...";
            TicketNumber = "XXXXXXXX";
            TaskColor = (Color)ColorConverter.ConvertFromString("LimeGreen");
            Date = DateTime.Today;
            Status = 0;
        }

        public Task(int taskID, object status)
        {
            TaskID = taskID;
            Name = "New Task";
            Description = "Description...";
            TicketNumber = "XXXXXXXX";
            TaskColor = (Color)ColorConverter.ConvertFromString("LimeGreen");
            Date = DateTime.Today;
            Status = status;
        }
    }
}