namespace Todoo.Services
{
    public interface ISessionManagerService
    {
        public void add(string Key, object list, HttpContext context);
    }
}
