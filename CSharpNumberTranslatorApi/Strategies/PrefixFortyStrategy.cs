using CSharpNumberTranslatorApi.RepositoryContracts;
using CSharpNumberTranslatorApi.ServiceContracts;
using CSharpNumberTranslatorApi.StrategyContracts;

namespace CSharpNumberTranslatorApi.Strategies
{
    public class PrefixFortyStrategy : PrefixStrategyBase, IPrefixStrategy
    {
        private readonly INumberPrefixRepository _numberPrefixRepository;

        public PrefixFortyStrategy(INumberPrefixRepository numberPrefixRepository,
                                   IDigitService digitService) : base(digitService)
        {
            _numberPrefixRepository = numberPrefixRepository;
        }

        public bool CanExecute(int number)
        {
            var startNumber = GetStartNumber(number);
            return startNumber == 4 && number > 14;
        }

        public string Execute(int number)
        {
            var startNumber = GetStartNumber(number);
            return _numberPrefixRepository.Get(startNumber);
        }
    }
}