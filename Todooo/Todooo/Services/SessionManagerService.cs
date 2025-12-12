using System.Collections.Generic;
using System.Text.Json;
using Todooo.Models;

namespace Todooo.Services
{
    public class SessionManagerService:ISessionManagerService
    {
        public void add(string Key , object obj, HttpContext context)
        {
            context.Session.SetString(Key, JsonSerializer.Serialize(obj));
        }


    }
}
