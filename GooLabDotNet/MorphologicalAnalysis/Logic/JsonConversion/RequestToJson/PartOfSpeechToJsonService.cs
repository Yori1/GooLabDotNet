using System.Collections.Generic;
using System.Linq;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion
{
    public class PartOfSpeechToJsonService
    {
        public string ConvertToJsonReadyPartOfSpeech(IEnumerable<PartOfSpeech> partsOfSpeech)
        {
            var result = "";


            for (var x = 0; x < partsOfSpeech.Count(); x++)
            {
                var partOfSpeech = partsOfSpeech.ElementAt(x);
                if (x > 0)
                {
                    result += "|";
                }

                result += GetJsonStringRepresentation(PartOfSpeech.CaseMarkingParticle);

            }

            return result;
        }

        private string GetJsonStringRepresentation(PartOfSpeech partOfSpeech)
        {
            string result = "";
            switch (partOfSpeech)
            {
                case PartOfSpeech.CaseMarkingParticle:
                    result = "格助詞";
                    break;

                case PartOfSpeech.SentenceEndingParticle:
                    result = "終動詞";
                    break;

                case PartOfSpeech.VerbSuffix:
                    result = "動詞接尾辞";
                    break;
            }
            return result;

        }
    }
}