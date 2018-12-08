using System.Linq.Expressions;
using NanoCompiler.LambaBuilder;

namespace NanoCompiler.Syntax
{
    abstract class SyntaxTreeNodeBase
    {
        public SyntaxElementType NodeType { get; private set; }
        public abstract Expression ConvertToExpression();
    }
}
