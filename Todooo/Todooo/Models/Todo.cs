using System.ComponentModel.DataAnnotations;
using Todooo.Enum;

namespace Todooo.Models
{
    public class Todo
    {
        public string Libele { get; set; }
        
        public string Description { get; set; }
  
        public dateTime Datelimite { get; set; }
  
        public State Statut { get; set; }
    }
}
