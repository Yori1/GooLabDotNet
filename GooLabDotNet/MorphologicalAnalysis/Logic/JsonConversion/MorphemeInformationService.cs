using System.Collections.Generic;
using System.Linq;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion
{
    public class MorphemeInformationService
    {
        public string GetJsonRepresentationOfMorphemeInformationEnumerable(IEnumerable<MorphemeField> morphemeInformation) {
            string result = "";
            for(var x = 0; x<morphemeInformation.Count(); x++) {
                var info = morphemeInformation.ElementAt(x);
                if(x > 0) {
                    result += " |";
                }
                result += GetJsonRepresentationOfMorphemeInformation(info);
            }
            return result;
        }

        private string GetJsonRepresentationOfMorphemeInformation(MorphemeField morphemeInformation) {
            string result = "";
            switch(morphemeInformation) {
                case MorphemeField.OriginalInput:
                result = "form";
                break;

                case MorphemeField.Katakana:
                result = "read";
                break;

                case MorphemeField.PartOfSpeech:
                result = "pos";
                break;
            }
            return result;
        }
    }
}