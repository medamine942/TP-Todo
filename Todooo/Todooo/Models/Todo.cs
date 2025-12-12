using System.ComponentModel.DataAnnotations;
using Todoo.Enum;

namespace Todoo.Models
{
    public class Todo
    {
        public string Libele { get; set; }
        
        public string Description { get; set; }
  
        public DateTime Datelimite { get; set; }
  
        public State Statut { get; set; }
    }
}
