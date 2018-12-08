using System.Linq.Expressions;

namespace NanoCompiler.Syntax.Terminals
{
    class ConstantTreeNode : TerminalTreeNodeBase
    {
        private double Value { get; set; }

        public ConstantTreeNode(double value)
        {
            Value = value;
        }

        public override Expression ConvertToExpression()
        {
            return Expression.Constant(Value);
        }
    }
}
