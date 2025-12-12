using Todooo.Models;
using Todooo.ViewModel;

namespace Todooo.Mappers
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
