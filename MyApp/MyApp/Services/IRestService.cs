using MyApp.Models;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public interface IRestService
    {
        Task<MyModel> GetItem(string id);
    }
}
