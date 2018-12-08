namespace NanoCompiler.Syntax.Binaries
{
    abstract class BinaryTreeNodeBase : SyntaxTreeNodeBase
    {
        protected SyntaxTreeNodeBase LeftLeaf { get; set; }

        public SyntaxTreeNodeBase RightLeaf { get; set; }

        public BinaryTreeNodeBase(
            SyntaxTreeNodeBase leftLeaf,
            SyntaxTreeNodeBase rightLeaf)
        {
            LeftLeaf = leftLeaf;
            RightLeaf = rightLeaf;
        }
    }
}
