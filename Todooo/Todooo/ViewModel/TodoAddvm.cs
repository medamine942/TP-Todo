using System.ComponentModel.DataAnnotations;
using Todooo.Enum;

namespace Todooo.ViewModel
{
    public class TodoAddvm
    {
        [Required(ErrorMessage ="obligatoire")]
        public string Libele { get; set; }
        [Required(ErrorMessage ="obligatoire")]
        public string Description { get; set; }
        [Required(ErrorMessage = "obligatoire")]
        [DataType(DataType.Date)]
        public DateTime Datelimite { get; set; }
        [Required]
        public State Statut {  get; set; }

    }
}
