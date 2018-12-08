using System.Linq.Expressions;

namespace NanoCompiler.Syntax.Terminals
{
    class ParameterTreeNode : TerminalTreeNodeBase
    {
        private string Name { get; set; }

        public ParameterTreeNode(string name)
        {
            Name = name;
        }

        public override Expression ConvertToExpression()
        {
            return Expression.Parameter(
                typeof(double),
                Name);
        }
    }
}
