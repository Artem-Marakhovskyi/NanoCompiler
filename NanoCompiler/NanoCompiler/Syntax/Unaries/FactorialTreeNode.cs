using System.Linq.Expressions;

namespace NanoCompiler.Syntax.Unaries
{
    class FactorialTreeNode : UnaryTreeNodeBase
    {
        public FactorialTreeNode(SyntaxTreeNodeBase leaf) : base(leaf)
        {
        }

        public override Expression ConvertToExpression()
        {
            return Leaf.ConvertToExpression();
        }
    }
}
