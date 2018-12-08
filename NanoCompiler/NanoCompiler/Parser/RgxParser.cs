using NanoCompiler.LambaBuilder;
using System.Text.RegularExpressions;

namespace NanoCompiler.Parser
{
    class RgxParser
    {
        private readonly Regex _regex;
        private readonly SyntaxElementType _kind;

        public RgxParser(
            string regex, 
            SyntaxElementType kind)
        {
            _regex = new Regex(regex, RegexOptions.Compiled);
            _kind = kind;
        }


        public bool CanParseFromStart(string input)
        {
            var match = _regex.Match(input);

            return match.Success && _regex.Match(input).Index == 0;
        }

        public ParsedDataBag Parse(string input)
        {
            var match = _regex.Match(input);
            var dataBag = new ParsedDataBag(_kind);
            dataBag.Value = match.Value;

            return dataBag;
        }
    }
}
