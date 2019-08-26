using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.JsonToResult.MorphemeConversion;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

[assembly:InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion
{
    internal class FieldConversionService: IFieldConversionService
    {
        private Dictionary<string, MorphemeField> jsonFieldAndEnumDictionary = new Dictionary<string, MorphemeField>();

        public FieldConversionService()
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