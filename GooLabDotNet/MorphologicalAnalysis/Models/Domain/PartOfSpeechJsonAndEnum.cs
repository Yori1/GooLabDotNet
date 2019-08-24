using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Models.Domain {
    public class PartOfSpeechJsonAndEnum {
        private string jsonValue;
        private PartOfSpeech enumValue;
        public PartOfSpeechJsonAndEnum (string jsonValue, PartOfSpeech enumValue) {
            this.jsonValue = jsonValue;
            this.enumValue = enumValue;
        }

    }
}