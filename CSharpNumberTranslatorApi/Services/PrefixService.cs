using CSharpNumberTranslatorApi.FactoryContracts;
using CSharpNumberTranslatorApi.ServiceContracts;

namespace CSharpNumberTranslatorApi.Services
{
    public class PrefixService : IPrefixService
    {
        private readonly IPrefixStrategyFactory _prefixStrategyFactory;

        public PrefixService(IPrefixStrategyFactory prefixStrategyFactory)
        {
            _prefixStrategyFactory = prefixStrategyFactory;
        }

        public string GetPrefix(int number)
        {
            return _prefixStrategyFactory
                .CreatePrefixStrategy(number)
                .Execute(number);
        }
    }
}