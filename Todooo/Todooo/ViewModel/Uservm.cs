using System.ComponentModel.DataAnnotations;

namespace Todoo.ViewModel
{
    public class Uservm
    {
        [Required(ErrorMessage ="le champ est oblig ")]
   
        public string Email {  get; set; }
        [Required(ErrorMessage = "le champ est oblig ")]
        public string Password { get; set; }

    }
}
