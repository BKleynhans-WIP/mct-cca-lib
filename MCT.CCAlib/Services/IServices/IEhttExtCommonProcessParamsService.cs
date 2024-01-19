using System.Threading.Tasks;

namespace MCT.CCAlib.Services.IServices
{
    public interface IEhttExtCommonProcessParamsService
    {
        Task<T> GetCommonProcessParamsSync<T>();
        Task<T> GetCommonProcessParamsSync<T>(string processName);
    }
}