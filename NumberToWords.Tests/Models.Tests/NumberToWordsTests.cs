using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords;

namespace NumberToWords.TestTools
{
    [TestClass]
    public class NumberToWordsTest
    {
        [TestMethod]
        public void ConvertOnesToWords_ConvertOnesDigit_One()
        {
            string correctNumWord = "one";
            char[] newArray = {'1'};
            string numWord = NumberConvert.ConvertOnesToWords(newArray);
            Assert.AreEqual(correctNumWord, numWord);
        }
        [TestMethod]
        public void ConvertTensToWords_ConvertTensDigit_21()
        {
            
            string correctNumWord = "twentyone";
            char[] newArray = {'2','1'};
            string numWord = NumberConvert.ConvertOnesToWords(newArray);
            Assert.AreEqual(correctNumWord, numWord);
        }
    }
}