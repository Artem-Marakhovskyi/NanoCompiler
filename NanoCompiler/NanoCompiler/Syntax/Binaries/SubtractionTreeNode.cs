using System.Linq.Expressions;

namespace NanoCompiler.Syntax.Binaries
{
    class SubtractionTreeNode : BinaryTreeNodeBase
    {
        public SubtractionTreeNode(
            SyntaxTreeNodeBase leftLeaf,
            SyntaxTreeNodeBase rightLeaf)
            : base(leftLeaf, rightLeaf)
        {
        }

        public override Expression ConvertToExpression()
        {
            return Expression.Subtract(
                LeftLeaf.ConvertToExpression(),
                RightLeaf.ConvertToExpression());
        }
    }
}
