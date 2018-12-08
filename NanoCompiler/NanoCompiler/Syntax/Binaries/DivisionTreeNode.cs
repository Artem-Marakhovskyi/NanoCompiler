using System.Linq.Expressions;

namespace NanoCompiler.Syntax.Binaries
{
    class DivisionTreeNode : BinaryTreeNodeBase
    {
        public DivisionTreeNode(
            SyntaxTreeNodeBase leftLeaf, 
            SyntaxTreeNodeBase rightLeaf) 
            : base(leftLeaf, rightLeaf)
        {
        }

        public override Expression ConvertToExpression()
        {
            return Expression.Divide(
                LeftLeaf.ConvertToExpression(),
                RightLeaf.ConvertToExpression());
        }
    }
}
