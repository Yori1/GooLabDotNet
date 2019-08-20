using Microsoft.VisualStudio.TestTools.UnitTesting;
using GooLabDotNet.Test.DependencyInjection;
using GooLabDotNet.MorphologicalAnalysis.Logic.MorphemeConversion;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.Test.UnitTests
{
    [TestClass]
    public class MorphemeFieldConversionServiceTest
    {
        private MorphemeFieldConversionService service;

        [TestInitialize]
        public void TestInitialize() {
            DependencyHelper dependencyHelper = new DependencyHelper();
            service = dependencyHelper.GetMorphemeFieldConversionService();
        }

        [TestMethod]
        public void TestPos(){
            string val = "pos";
            MorphemeField result = service.DetermineField(val);
            Assert.AreEqual(result, MorphemeField.PartOfSpeech);
        }


        [TestMethod]
        public void TestForm() {
                        string val = "form";
            MorphemeField result = service.DetermineField(val);
            Assert.AreEqual(result, MorphemeField.OriginalInput);
        }

        [TestMethod]

        public void TestRead() {
                        string val = "read";
            MorphemeField result = service.DetermineField(val);
            Assert.AreEqual(result, MorphemeField.Katakana);
        }
    }
}