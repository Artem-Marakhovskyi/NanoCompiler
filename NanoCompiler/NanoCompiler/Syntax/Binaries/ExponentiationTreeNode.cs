using System.Linq.Expressions;

namespace NanoCompiler.Syntax.Binaries
{
    class ExponentiationTreeNode : BinaryTreeNodeBase
    {
        public ExponentiationTreeNode(
            SyntaxTreeNodeBase leftLeaf, 
            SyntaxTreeNodeBase rightLeaf) 
            : base(leftLeaf, rightLeaf)
        {

        }

        public override Expression ConvertToExpression()
        {
            return Expression.Power(
                LeftLeaf.ConvertToExpression(),
                RightLeaf.ConvertToExpression());
        }
    }
}
