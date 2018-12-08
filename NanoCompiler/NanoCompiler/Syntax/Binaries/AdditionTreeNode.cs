using System.Linq.Expressions;

namespace NanoCompiler.Syntax.Binaries
{
    class AdditionTreeNode : BinaryTreeNodeBase
    {
        public AdditionTreeNode(
            SyntaxTreeNodeBase leftLeaf, 
            SyntaxTreeNodeBase rightLeaf) 
            : base(leftLeaf, rightLeaf)
        {
        }

        public override Expression ConvertToExpression()
        {
            return Expression.Add(
                LeftLeaf.ConvertToExpression(), 
                RightLeaf.ConvertToExpression());
        }
    }
}
