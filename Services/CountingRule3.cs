using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CBA.Services
{
    public class CountingRule3 : CountingService
    {
        private LogService LogService;
        /// <summary>
        /// For all the words starts with 'a' or 'b' or 'c', get the longest length of the words,
        /// save the result to file "longest_words_starting_with_abc.txt"
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns>longestLength</returns>
        public override async Task<double> Count(string inputText)
        {
            double longestLength = 0;
            string pattern = @"\b[a|b|c]\w*\b"; //word boundary begins with 'a' or 'b' or 'c'
            MatchCollection matches = Regex.Matches(inputText, pattern);
            longestLength = matches.Count == 0 ? 0 : matches.Max(x => x.Length);
            LogService = new LogService("longest_words_starting_with_abc.txt");
            await LogService.Log(longestLength.ToString());
            return longestLength;
        }
    }
}