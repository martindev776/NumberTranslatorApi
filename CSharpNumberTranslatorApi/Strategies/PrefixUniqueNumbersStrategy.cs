using System.Collections.Generic;
using CSharpNumberTranslatorApi.RepositoryContracts;
using CSharpNumberTranslatorApi.ServiceContracts;
using CSharpNumberTranslatorApi.StrategyContracts;

namespace CSharpNumberTranslatorApi.Strategies
{
    public class PrefixUniqueNumbersStrategy : PrefixStrategyBase, IPrefixStrategy
    {
        private readonly IUniqueNumberRepository _uniqueNumberRepository;

        public PrefixUniqueNumbersStrategy(IUniqueNumberRepository uniqueNumberRepository,
                                           IDigitService digitService) : base(digitService)
        {
            _uniqueNumberRepository = uniqueNumberRepository;
        }

        public bool CanExecute(int number)
        {
            var startNumber = GetStartNumber(number);
            var validNumbers = new List<int> { 4, 6, 7, 9 };
            return validNumbers.Contains(startNumber);
        }

        public string Execute(int number)
        {
            var startNumber = GetStartNumber(number);
            return _uniqueNumberRepository.Get(startNumber);
        }
    }
}