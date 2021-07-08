using System;
using System.Collections.Generic;
using System.Linq;
using CSharpNumberTranslatorApi.FactoryContracts;
using CSharpNumberTranslatorApi.StrategyContracts;

namespace CSharpNumberTranslatorApi.Factories
{
    public class PrefixStrategyFactory : IPrefixStrategyFactory
    {
        private readonly IEnumerable<IPrefixStrategy> _prefixStrategies;

        public PrefixStrategyFactory(IEnumerable<IPrefixStrategy> prefixStrategies)
                                     
        {
            _prefixStrategies = prefixStrategies;
        }

        public IPrefixStrategy CreatePrefixStrategy(int number)
        {
            var strategy = _prefixStrategies.FirstOrDefault(x => x.CanExecute(number));
            if (strategy != null)
                return strategy;

            throw new Exception($"Can't find prefix strategy for: {number}");
        }
    }
}