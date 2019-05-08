using CBA.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class CountingTest
    {
        #region CountingRule1
        [TestMethod]
        public async Task CountingRule1_Count_Input_Contains_NOWords_StartWith_A_Returns_AverageLength_Zero()
        {
            double expected = 0;
            string inputText = "This text contains no words starts with the mentioned character";
            CountingService CountingService = new CountingRule1();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule1_Count_Input_Contains_FiveWords_StartWith_A_Returns_AverageLength()
        {
            double expected = 3.2;
            string inputText = "This text contains a minimum of five words starts with the alphabet a or A mentioned above";
            CountingService CountingService = new CountingRule1();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region CountingRule2
        [TestMethod]
        public async Task CountingRule2_Count_Input_Contains_NOWords_StartWith_B_Returns_E_Count_Zero()
        {
            double expected = 0;
            string inputText = "This text contains no words starts with the mentioned character";
            CountingService CountingService = new CountingRule2();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule2_Count_Input_Contains_Words_StartWith_B_But_Contains_NO_E_Returns_E_Count_Zero()
        {
            double expected = 0;
            string inputText = "This text contains two words ball and bat, but there is no e in that words";
            CountingService CountingService = new CountingRule2();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule2_Count_Input_Contains_Words_StartWith_B_Also_Contains_E_Returns_E_Count()
        {
            double expected = 2;
            string inputText = "This text contains two words bell and bet, which has e on them";
            CountingService CountingService = new CountingRule2();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region CountingRule3
        [TestMethod]
        public async Task CountingRule3_Count_Input_Contains_NOWords_StartWith_abc_Returns_Longest_Zero()
        {
            double expected = 0;
            string inputText = "This text includes no words starts with the mentioned ones";
            CountingService CountingService = new CountingRule3();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule3_Count_Input_Contains_Words_StartWith_abc_WordStartsWith_a_Is_Longest_Returns_Length_Of_a_Longest()
        {
            double expected = 5;
            string inputText = "This text has three words anish ball and bat, in this word starts with a is the longest";
            CountingService CountingService = new CountingRule3();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule3_Count_Input_Contains_Words_StartWith_abc_WordStartsWith_b_Is_Longest_Returns_Length_Of_b_Longest()
        {
            double expected = 6;
            string inputText = "This text has three words apple battle and cat, in this word starts with b is the longest";
            CountingService CountingService = new CountingRule3();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule3_Count_Input_Contains_Words_StartWith_abc_WordStartsWith_c_Is_Longest_Returns_Length_Of_c_Longest()
        {
            double expected = 6;
            string inputText = "This text has three words anish ball and castle, in this word starts with c is the longest";
            CountingService CountingService = new CountingRule3();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule3_Count_Input_Contains_Words_StartWith_abc_All_Words_SameLength_Returns_Length_Of_One_Longest()
        {
            double expected = 5;
            string inputText = "This text has three words apple bells and calls, in this all three words has same length";
            CountingService CountingService = new CountingRule3();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region CountingRule4
        [TestMethod]
        public async Task CountingRule4_Count_Input_Contains_NOWords_StartWith_C_Returns_Pattern_Count_Zero()
        {
            double expected = 0;
            string inputText = "This text has no words starts with the mentioned alphabet";
            CountingService CountingService = new CountingRule4();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule4_Count_Input_Contains_Words_StartWith_C_But_Contains_NO_Consecutive_Word_StartsWith_A_Returns_Pattern_Count_Zero()
        {
            double expected = 0;
            string inputText = "This text contains two words starts with the mentioned alphabet cat, cap but there is no consecutive word starts with a";
            CountingService CountingService = new CountingRule4();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountingRule4_Count_Input_Contains_Words_StartWith_C_Also_Contains_Consecutive_Word_StartsWith_A_Returns_Pattern_Count()
        {
            double expected = 1;
            string inputText = "This text contains two words starts with the mentioned alphabet cat and cap, so there is one consecutive word which starts with a";
            CountingService CountingService = new CountingRule4();
            double result = await CountingService.Count(inputText);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region RunCountingRules
        [TestMethod]
        public async Task CountingService_RunCountingRules_Returns_True()
        {
            bool expected = true;
            string inputText = "This text has no words starts with the mentioned alphabet";
            CountingService CountingService = new CountingService();
            bool result = await CountingService.RunCountingRules(inputText);
            Assert.AreEqual(expected, result);
        }
        #endregion
    }
}