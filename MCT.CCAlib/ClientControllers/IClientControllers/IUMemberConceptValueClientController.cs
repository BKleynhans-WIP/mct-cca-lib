using MCT.CCAlib.Models.ckoltp;

namespace MCT.CCAlib.ClientControllers.IClientControllers
{
    public interface IUMemberConceptValueClientController
    {
        UMemberConceptValue GetUMemberConceptValue(int cid, int conceptId);
    }
}