using Microsoft.VisualStudio.TestTools.UnitTesting;
using GooLabDotNet.Test.DependencyInjection;
using System.Collections.Generic;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.Test.UnitTests
{
    [TestClass]
    public class MorphemeConversionServiceTest
    {
        private MorphemeConversionService morphemeConversionService;

        [TestInitialize]
        public void Initialize() {
            DependencyHelper dependencyHelper = new DependencyHelper();
            morphemeConversionService = dependencyHelper.GetMorphemeConversionService();
        }

        [TestMethod]
        public void HasPropertiesAfterConvertingToMorpheme()
        {
            var testJsonMorpheme = new List<string>()
            {
                "文章",
                "ブンショウ"
            };
            var result = morphemeConversionService.ConvertToMorpheme(testJsonMorpheme);
            Assert.AreEqual("ブンショウ", result.KatakanaReading);
            Assert.AreEqual(PartOfSpeech.NotRecognized, result.PartOfSpeech);
            Assert.AreEqual("文章", result.Kanji);
        }
    }
}