using Microsoft.VisualStudio.TestTools.UnitTesting;
using GooLabDotNet.MorphologicalAnalysis.Logic.MorphemeConversion;
using GooLabDotNet.Test.DependencyInjection;
using System.Collections.Generic;

namespace GooLabDotNet.Test.UnitTests
{
    public class MorphemeConversionServiceTest
    {
        private MorphemeConversionService morphemeConversionService;

        [TestInitialize]
        public void Initialize() {
            DependencyHelper dependencyHelper = new DependencyHelper();
            morphemeConversionService = dependencyHelper.GetMorphemeConversionService();
        }

        [TestMethod]
        public void HasPropertiesAfterConvertingToMorpheme() {
            
        }

        private List<List<string>> GetTestJsonMorphemes() {
            var result = new List<List<string>>();
            result.Add(new List<string>() {
                "文章",
                "",
                "助詞"
            });
            return result;
        }
    }
}