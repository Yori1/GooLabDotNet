using System.Collections.Generic;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.MorphemeConversion
{
    internal class MorphemeFieldConversionService
    {
        private Dictionary<string, MorphemeField> jsonFieldAndEnumDictionary = new Dictionary<string, MorphemeField>();

        public MorphemeFieldConversionService()
        {
            initializeDictionary();
        }
        private void initializeDictionary()
        {
            jsonFieldAndEnumDictionary.Add("form", MorphemeField.OriginalInput);
            jsonFieldAndEnumDictionary.Add("read", MorphemeField.Katakana);
            jsonFieldAndEnumDictionary.Add("pos", MorphemeField.PartOfSpeech);
        }

        public MorphemeField DetermineField(string jsonField)
        {
            return jsonFieldAndEnumDictionary[jsonField];
        }
    }
}