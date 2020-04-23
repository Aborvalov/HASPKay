namespace Entites
{
    public interface ICompanyDAO : IContractEntites<Company>
    {
        Company GetByNumberKey(int numberKay);
        Company GetByFeature(Feature feature);
    }
}
