using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CBA.Services
{
    public class CountingRule1 : CountingService
    {
        private LogService LogService;
        /// <summary>
        /// For all the words starts with 'a' or 'A', count the average length of the words,
        /// save the result to file "average_length_of_words_starting_with_a.txt"
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns>averageLength</returns>
        public override async Task<double> Count(string inputText)
        {   
            string pattern = @"\b[a|A]\w*\b"; //word boundary begins with 'a' or 'A'
            MatchCollection matches = Regex.Matches(inputText, pattern);
            double averageLength = matches.Count == 0 ? 0 : matches.Average(x => x.Length);
            LogService = new LogService("average_length_of_words_starting_with_a.txt");
            await LogService.Log(averageLength.ToString());
            return averageLength;
        }
    }
}