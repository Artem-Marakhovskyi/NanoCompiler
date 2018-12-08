using System.Linq.Expressions;

namespace NanoCompiler.Syntax.Binaries
{
    class MultiplicationTreeNode : BinaryTreeNodeBase
    {
        public MultiplicationTreeNode(
            SyntaxTreeNodeBase leftLeaf, 
            SyntaxTreeNodeBase rightLeaf) 
            : base(leftLeaf, rightLeaf)
        {
        }

        public override Expression ConvertToExpression()
        {
            return Expression.Multiply(
                LeftLeaf.ConvertToExpression(),
                RightLeaf.ConvertToExpression());
        }
    }
}
