using System.Collections.Generic;

namespace NanoCompiler.Parser
{
    interface IParserConfigurator
    {
        IEnumerable<RgxParser> ProvideRgx();
    }
}
