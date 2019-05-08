using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CBA.Services
{
    public class CountingRule4 : CountingService
    {
        private LogService LogService;
        /// <summary>
        /// For all the words starts with 'c' or 'C', if the next word starts with 'a' or 'A',
        /// count the number of this sequence,
        /// save the result to "count_of_sequence_of_words_starting_with_c_and_a.txt"
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns>countSequence</returns>
        public override async Task<double> Count(string inputText)
        {
            double countSequence = 0;
            string pattern = @"\b([c|C]\w+\s?\w*)\b[a|A]\w*"; //word boundary begins with 'c' or 'C' and next word starts with 'a' or 'A'
            MatchCollection matches = Regex.Matches(inputText, pattern);
            countSequence = matches.Count;
            LogService = new LogService("count_of_sequence_of_words_starting_with_c_and_a.txt");
            await LogService.Log(countSequence.ToString());
            return countSequence;
        }
    }
}