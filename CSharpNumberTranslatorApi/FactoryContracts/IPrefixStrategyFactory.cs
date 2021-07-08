using CSharpNumberTranslatorApi.StrategyContracts;

namespace CSharpNumberTranslatorApi.FactoryContracts
{
    public interface IPrefixStrategyFactory
    {
        IPrefixStrategy CreatePrefixStrategy(int number);
    }
}