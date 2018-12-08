namespace NanoCompiler.Syntax.Unaries
{
    abstract class UnaryTreeNodeBase : SyntaxTreeNodeBase
    {
        protected SyntaxTreeNodeBase Leaf { get; set; }

        public UnaryTreeNodeBase(
            SyntaxTreeNodeBase leaf)
        {
            Leaf = leaf;
        }
    }
}
