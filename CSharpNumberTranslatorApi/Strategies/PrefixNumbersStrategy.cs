using System.Collections.Generic;
using CSharpNumberTranslatorApi.RepositoryContracts;
using CSharpNumberTranslatorApi.ServiceContracts;
using CSharpNumberTranslatorApi.StrategyContracts;

namespace CSharpNumberTranslatorApi.Strategies
{
    public class PrefixNumbersStrategy : PrefixStrategyBase, IPrefixStrategy
    {
        private readonly INumberPrefixRepository _numberPrefixRepository;

        public PrefixNumbersStrategy(INumberPrefixRepository numberPrefixRepository,
                                     IDigitService digitService) : base(digitService)
        {
            _numberPrefixRepository = numberPrefixRepository;
        }

        public bool CanExecute(int number)
        {
            var startNumber = GetStartNumber(number);
            var prefixNumbers = new List<int> { 2, 3, 5, 8 };
            return prefixNumbers.Contains(startNumber);
        }

        public string Execute(int number)
        {
            var startNumber = GetStartNumber(number);
            return _numberPrefixRepository.Get(startNumber);
        }
    }
}