
using GooLabDotNet.MorphologicalAnalysis.Logic.CharacterSetDetection;
using GooLabDotNet.MorphologicalAnalysis.Logic.MorphemeConversion;



namespace GooLabDotNet.Test.DependencyInjection
{
    internal class DependencyHelper
    {
        public ExactCharacterSetDetectionService GetExactCharacterSetDetectionService()
        {
            return new ExactCharacterSetDetectionService();
        }

        public KatakanaRecognitionService GetKatakanaRecognitionService()
        {
            return new KatakanaRecognitionService(GetExactCharacterSetDetectionService());
        }

        public MorphemeFieldConversionService GetMorphemeFieldConversionService()
        {
            return new MorphemeFieldConversionService();
        }

        public PartOfSpeechDetectionService GetPartOfSpeechDetectionService() {
            return new PartOfSpeechDetectionService();
        }

        public MorphemeConversionService GetMorphemeConversionService() {
            return new MorphemeConversionService(GetMorphemeFieldConversionService(), GetKatakanaRecognitionService(), GetPartOfSpeechDetectionService());
        }

    }
}