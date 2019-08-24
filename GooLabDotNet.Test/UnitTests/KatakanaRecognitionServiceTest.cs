using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.CharacterSetDetection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GooLabDotNet.Test.DependencyInjection;

namespace GooLabDotNet.Test.UnitTests
{
    [TestClass]
    public class KatakanaRecognitionServiceTest
    {
        private KatakanaRecognitionService katakanaRecognitionService;

        [TestInitialize]
        public void Initialize()
        {
            DependencyHelper dependencyHelper = new DependencyHelper();
            katakanaRecognitionService = dependencyHelper.GetKatakanaRecognitionService();
        }

        [TestMethod]
        public void TrueOnFullKatakanaSentence()
        {
            string s = "コレハカタカナデカカレタブンショウデス";
            Assert.IsTrue(katakanaRecognitionService.IsSentenceWrittenInKatakana(s));
        }

        [TestMethod]
        public void TrueOnFullKatakanaSentenceWithPunctuationMarks()
        {
            string s = "コレハカタカナデカカレタブンショウデス.!?-+";
            Assert.IsTrue(katakanaRecognitionService.IsSentenceWrittenInKatakana(s));
        }

        [TestMethod]
        public void TrueOnFullKatakanaSentenceWithNumbers()
        {
            string s = "コレハカタカナデカカレタブンショウデス.!?-+";
            Assert.IsTrue(katakanaRecognitionService.IsSentenceWrittenInKatakana(s));
        }

        [TestMethod]
        public void FalseOnSentenceWithHiragana()
        {
            string s = "あコレハカタカナデカカレタブンショウデス.!?-+";
            Assert.IsFalse(katakanaRecognitionService.IsSentenceWrittenInKatakana(s));
        }

        [TestMethod]

        public void FalseOnSentenceWithKanji()
        {
            string s = "漢字あコレハカタカナデカカレタブンショウデス.!?-+";
            Assert.IsFalse(katakanaRecognitionService.IsSentenceWrittenInKatakana(s));
        }
    }
}
