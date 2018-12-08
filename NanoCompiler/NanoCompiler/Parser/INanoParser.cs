using System.Collections.Generic;

namespace NanoCompiler.Parser
{
    interface INanoParser
    {
        IEnumerable<ParsedDataBag> Parse(string input);
    }
}
