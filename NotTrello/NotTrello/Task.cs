using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTrello
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TicketNumber { get; set; }
        public Color TaskColor { get; set; }
        public DateTime TaskDate { get; set; }
        public object TaskStatus { get; set; }


        public Task(int taskID, string name, string description, string ticketNumber, Color color, DateTime date, object status)
        {
            TaskID = taskID;
            Name = name;
            Description = description;
            TicketNumber = ticketNumber;
            TaskColor = color;
            TaskDate = date;
            TaskStatus = status;
        }
    }
}