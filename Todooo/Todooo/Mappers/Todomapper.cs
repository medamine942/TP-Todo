using Todoo.Models;
using Todoo.ViewModel;

namespace Todoo.Mappers
{
    public class Todomapper
    {
        public static Todo GetTodoFromAddvm(TodoAddvm vm)
        {
            return new Todo
            {
                Libele = vm.Libele,
                Description = vm.Description,
                Datelimite = vm.Datelimite,
                Statut = vm.Statut,
            };
        }
    }
}
