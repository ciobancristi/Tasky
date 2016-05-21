using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasky.Services.Models
{
    public class EditProjectModel
    {
        public string Name { get; set; }
        public int ClientId { get; set; }
        public List<int> TaskIds { get; set; }
        public List<Guid> UserIds { get; set; }
        public bool HasFinished { get; set; }
    }
}
