using CBA.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CBA.Services
{
    public class CountingService : ICounting
    {
        public virtual async Task<double> Count(string inputText)
        {
            return 0;
        }

        public async Task<bool> RunCountingRules(string inputText)
        {
            List<CountingService> countingServics = new List<CountingService>();
            countingServics.Add(new CountingRule1());
            countingServics.Add(new CountingRule2());
            countingServics.Add(new CountingRule3());
            countingServics.Add(new CountingRule4());

            foreach (CountingService countingService in countingServics)
            {
                double count = await countingService.Count(inputText);
            }
            return true;
        }
    }
}