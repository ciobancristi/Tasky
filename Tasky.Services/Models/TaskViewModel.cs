namespace Tasky.Services.Models
{
    public class TaskViewModel
    {
        public int TaskId { get; set; }
        public string ProjectName { get; set; }
        public string TaskName { get; set; }
        public double Hours { get; set; }
        public string Comments { get; set; }
    }
}
