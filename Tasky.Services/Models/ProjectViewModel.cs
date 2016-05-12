namespace Tasky.Services.Models
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string ClientName { get; set; }
        public System.DateTime Created { get; set; }
        public bool HasFinished { get; set; }
    }
}
