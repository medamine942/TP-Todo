using System.ComponentModel.DataAnnotations;
using Todoo.Enum;

namespace Todoo.ViewModel
{
    public class TodoAddvm
    {
        [Required(ErrorMessage ="Ce champ est obligatoire")]
        public string Libele { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [DataType(DataType.Date)]
        public DateTime Datelimite { get; set; }
        [Required]
        public State Statut {  get; set; }

    }
}
