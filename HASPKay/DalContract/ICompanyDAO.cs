using Entites;

namespace DalContract
{
    public interface ICompanyDAO : IContractEntites<Company>
    {
        Company GetByNumberKey(string numberKay);
        Company GetByFeature(Feature feature);
    }
}
