using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NanoCompiler.Parser
{
    class NanoParser : INanoParser
    {
        private const string WhiteSpace = " ";

        private readonly IEnumerable<RgxParser> _rgxParsers;

        public NanoParser(
            IParserConfigurator parserConfigurator)
        {
            _rgxParsers = parserConfigurator.ProvideRgx();
        }

        public IEnumerable<ParsedDataBag> Parse(string input)
        {
            var normalized = Normalize(input);
            return ProcessParsing(normalized);
        }

        private IEnumerable<ParsedDataBag> ProcessParsing(string input)
        {
            var stringBuilder = new StringBuilder(input);
            var bagList = new List<ParsedDataBag>();

            while (stringBuilder.ToString() != string.Empty)
            {
                var parser = _rgxParsers.First(e => e.CanParseFromStart(input));
                var dataBag = parser.Parse(input);
                bagList.Add(dataBag);
                stringBuilder.Remove(0, dataBag.Value.Length);
            }

            return bagList;
        }
        

        private string Normalize(string input)
        {
            return input.Replace(WhiteSpace, string.Empty);
        }
    }
}
