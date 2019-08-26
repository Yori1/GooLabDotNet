using System;
using System.Collections.Generic;
using System.Text;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.CharacterSetDetection;
using GooLabDotNet.Test.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GooLabDotNet.Test.UnitTests
{
    [TestClass]
    public class ExactCharacterSetDetectionServiceTest
    {
        private ExactCharacterSetDetectionService exactCharacterSetDetectionService;

        [TestInitialize]
        public void Initialize()
        {
            DependencyHelper dependencyHelper = new DependencyHelper();
            exactCharacterSetDetectionService = dependencyHelper.GetExactCharacterSetDetectionService();
        }

        [TestMethod]
        public void TestKanji()
        {
            char kanji = '漢';
            exactCharacterSetDetectionService.IsExactlyKanji(kanji);
            Assert.IsTrue(exactCharacterSetDetectionService.IsExactlyKanji(kanji));
            Assert.IsFalse(exactCharacterSetDetectionService.IsExactlyHiragana(kanji));
            Assert.IsFalse(exactCharacterSetDetectionService.IsExactlyKatakana(kanji));

        }
    }
}
