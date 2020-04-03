using Entites;

namespace DalContract
{
    public interface ICompanyDAO : IContractEntites<Company>
    {
        Company GetByNumberKey(int numberKay);
        Company GetByFeature(Feature feature);
    }
}
