using System.ComponentModel.DataAnnotations;

namespace Todooo.ViewModel
{
    public class Uservm
    {
        [Required(ErrorMessage ="Ce champ est obligatoire ")]
   
        public string email {  get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire ")]
        public string password { get; set; }

    }
}
