using NanoCompiler.LambaBuilder;
using System.Collections.Generic;

namespace NanoCompiler.Parser
{
    class ParserConfigurator : IParserConfigurator
    {
        public IEnumerable<RgxParser> ProvideRgx()
        {
            return new List<RgxParser>()
            {
                new RgxParser(@"^\d*[\.\d*]*|^(\.\d+)", SyntaxElementType.Constant),
                new RgxParser(@"^[a-zA-Z]+", SyntaxElementType.Parameter),
                new RgxParser(@"^\+", SyntaxElementType.Addition),
                new RgxParser(@"^\/", SyntaxElementType.Division),
                new RgxParser(@"^\^\^", SyntaxElementType.Exponentiation),
                new RgxParser(@"^\!", SyntaxElementType.Factorial),
                new RgxParser(@"^\*", SyntaxElementType.Multiplication),
                new RgxParser(@"^-", SyntaxElementType.Subtraction),
            };
        }
    }
}
