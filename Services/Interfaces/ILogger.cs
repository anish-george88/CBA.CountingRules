using System.Threading.Tasks;

namespace CBA.Services.Interfaces
{
    public interface ILogger
    {
        Task Log(string message);
    }
}
