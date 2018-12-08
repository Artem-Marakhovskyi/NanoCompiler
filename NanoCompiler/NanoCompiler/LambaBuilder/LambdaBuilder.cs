using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NanoCompiler.Parser;
using NanoCompiler.Syntax;

namespace NanoCompiler.LambaBuilder
{
    class LambdaBuilder
    {
        private readonly INanoParser _parser;
        

        public LambdaBuilder(
            INanoParser parser)
        {
            _parser = parser;
        }

        public T Build<T>(string input) where T : MulticastDelegate
        {
            var list = _parser.Parse(input);
            return (T)Expression
                .Lambda(
                    BuildTree(list, new PrioritiesProvider())
                        .ConvertToExpression())
                .Compile();
        }

        private SyntaxTreeNodeBase BuildTree(
            IEnumerable<ParsedDataBag> bagList,
            PrioritiesProvider prioritiesProvider)
        {
            var bagArray = bagList.ToArray();
            var syntaxElementsList = new SyntaxTreeNodeBase[bagList.Count()];

            foreach (var priorityElement in prioritiesProvider.Priorities)
            {
                for (int i = 0; i < bagArray.Length; i++)
                {
                    if (priorityElement.Contains(bagArray[i].Kind))
                    {
                        syntaxElementsList[i] = 
                    }
                }
            }
        }
    }
}

