using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NanoCompiler.Parser;

namespace NanoCompiler.LambaBuilder
{
    public class PrioritiesProvider
    {
        internal IEnumerable<IEnumerable<SyntaxElementType>> Priorities
            = new List<List<SyntaxElementType>>()
            {
                new List<SyntaxElementType>()
                {
                    SyntaxElementType.Parameter,
                    SyntaxElementType.Constant
                },
                new List<SyntaxElementType>()
                {
                    SyntaxElementType.Factorial
                },
                new List<SyntaxElementType>()
                {
                    SyntaxElementType.Exponentiation
                },
                new List<SyntaxElementType>()
                {
                    SyntaxElementType.Multiplication,
                    SyntaxElementType.Division
                },
                new List<SyntaxElementType>()
                {
                    SyntaxElementType.Subtraction,
                    SyntaxElementType.Addition
                },
            };
    }
}
