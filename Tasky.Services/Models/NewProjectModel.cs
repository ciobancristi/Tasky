using System;
using System.Collections.Generic;
using Tasky.Entities;

namespace Tasky.Services.Models
{
    public class NewProjectModel
    {
        public string Name { get; set; }
        public int ClientId { get; set; }
        public List<int> TaskIds { get; set; }
        public List<Guid> UserIds { get; set; }
    }
}
