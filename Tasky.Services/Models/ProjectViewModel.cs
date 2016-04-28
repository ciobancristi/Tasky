namespace Tasky.Services.Models
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public System.DateTime Created { get; set; }
        public string Client { get; set; }
        public bool HasFinished { get; set; }
    }
}
