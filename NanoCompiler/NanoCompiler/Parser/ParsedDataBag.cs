using NanoCompiler.LambaBuilder;

namespace NanoCompiler.Parser
{
    class ParsedDataBag
    {
        public SyntaxElementType Kind { get; private set; }

        public string Value { get; set; }

        public ParsedDataBag(SyntaxElementType kind)
        {
            Kind = kind;
        }
    }
}
