using System.Threading.Tasks;

namespace CompanySearcher.Api.Data
{
    public interface IDbInitializer
    {
        Task Initialize();
    }
}