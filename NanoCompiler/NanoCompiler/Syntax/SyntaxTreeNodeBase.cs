using System.Linq.Expressions;
using NanoCompiler.LambaBuilder;

namespace NanoCompiler.Syntax
{
    abstract class SyntaxTreeNodeBase
    {
        public abstract Expression ConvertToExpression();
    }
}
