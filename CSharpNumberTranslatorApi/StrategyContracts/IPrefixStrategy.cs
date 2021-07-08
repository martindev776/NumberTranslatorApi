namespace CSharpNumberTranslatorApi.StrategyContracts
{
    public interface IPrefixStrategy
    {
        bool CanExecute(int number);
        string Execute(int number);
    }
}