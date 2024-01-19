using System.Threading.Tasks;

namespace MCT.CCAlib.Services.IServices
{
    public interface IUMemberConceptValueService
    {
        Task<T> GetUMemberConceptValueSync<T>(int cid, int conceptId);
    }
}