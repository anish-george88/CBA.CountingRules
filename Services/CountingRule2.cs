using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CBA.Services
{
    public class CountingRule2 : CountingService
    {
        private LogService LogService;
        /// <summary>
        /// For all the words starts with 'b' or 'B', count the total number of 'e' or'E' in the words
        /// save the result to file "count_of_e_in_words_starting_with_b.txt"
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns>countOfe</returns>
        public override async Task<double> Count(string inputText)
        {
            double countOfe = 0;
            string pattern = @"\b[b|B]\w*[e|E]\w*\b"; //word boundary begins with 'b' or 'B' and contains 'e' or 'E'
            MatchCollection matches = Regex.Matches(inputText, pattern);
            countOfe = matches.Sum(x => x.Value.Where(c => c == 'e' || c == 'E').Count());
            LogService = new LogService("count_of_e_in_words_starting_with_b.txt");
            await LogService.Log(countOfe.ToString());
            return countOfe;
        }
    }
}