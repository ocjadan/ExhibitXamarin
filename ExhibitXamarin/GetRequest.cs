using System.Threading.Tasks;

namespace ExhibitXamarin
{
    public interface GetRequest<T> : Request
    {
        Task<T> GetAsync();
    }
}
