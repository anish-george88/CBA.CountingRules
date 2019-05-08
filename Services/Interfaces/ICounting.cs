using System.Threading.Tasks;

namespace CBA.Services.Interfaces
{
    public interface ICounting
    {
        Task<double> Count(string inputText);
    }
}