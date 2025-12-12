using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using Todoo.Mappers;
using Todoo.Models;
using Todoo.Services;
using Todoo.ViewModel;

namespace Todoo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ISessionManagerService _session;

        public TodoController(ISessionManagerService session)
        {
            _session = session;
        }

        
        public IActionResult Index()
        {
            string todoJson = HttpContext.Session.GetString("todo");
            List<Todo> list = (todoJson == null)
                ? new List<Todo>()
                : JsonSerializer.Deserialize<List<Todo>>(todoJson);

            return View(list);
        }

        
        [HttpGet]
        public IActionResult Add()
        {
            if (HttpContext.Session.GetString("user") == null)
                return RedirectToAction("Login", "User");

            return View(new TodoAddvm());
        }

        [HttpPost]
        public IActionResult Add(TodoAddvm vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            string todoJson = HttpContext.Session.GetString("todo");
            List<Todo> list = (todoJson == null)
                ? new List<Todo>()
                : JsonSerializer.Deserialize<List<Todo>>(todoJson);

            Todo todo = Todomapper.GetTodoFromAddvm(vm);
            list.Add(todo);

            _session.add("todo", list, HttpContext);

            return RedirectToAction("Index"); 
        }

        
        [HttpPost]
        public IActionResult Delete(int index)
        {
            string todoJson = HttpContext.Session.GetString("todo");
            if (todoJson != null)
            {
                var list = JsonSerializer.Deserialize<List<Todo>>(todoJson);
                if (index >= 0 && index < list.Count)
                {
                    list.RemoveAt(index);
                    _session.add("todo", list, HttpContext);
                }
            }
            return RedirectToAction("Index");
        }

        
        [HttpGet]
        public IActionResult Edit(int index)
        {
            string todoJson = HttpContext.Session.GetString("todo");
            if (todoJson != null)
            {
                var list = JsonSerializer.Deserialize<List<Todo>>(todoJson);
                if (index >= 0 && index < list.Count)
                {
                    var todo = list[index];
                    var vm = new TodoAddvm
                    {
                        Libele = todo.Libele,
                        Description = todo.Description,
                        Datelimite = todo.Datelimite,
                        Statut = todo.Statut
                    };
                    ViewBag.Index = index; 
                    return View(vm);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(int index, TodoAddvm vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Index = index;
                return View(vm);
            }

            string todoJson = HttpContext.Session.GetString("todo");
            if (todoJson != null)
            {
                var list = JsonSerializer.Deserialize<List<Todo>>(todoJson);
                if (index >= 0 && index < list.Count)
                {
                    list[index].Libele = vm.Libele;
                    list[index].Description = vm.Description;
                    list[index].Datelimite = vm.Datelimite;
                    list[index].Statut = vm.Statut;

                    _session.add("todo", list, HttpContext);
                }
            }

            return RedirectToAction("Index"); 
        }
    }
}
