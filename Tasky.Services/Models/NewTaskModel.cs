using System;

namespace Tasky.Services.Models
{
    public class NewTaskModel
    {
        public int ProjectId { get; set; }
        public int ProjectTaskId { get; set; }
        public double Hours { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
