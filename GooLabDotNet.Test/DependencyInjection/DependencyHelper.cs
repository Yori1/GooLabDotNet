using GooLabDotNet.MorphologicalAnalysis.Logic;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.CharacterSetDetection;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion;

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

        public ApiKeyService GetApiKeyService()
        {
            return new ApiKeyService();
        }

        public MorphemeFieldService GetMorphemeInformationService()
        {
            return new MorphemeFieldService();
        }

        public PartOfSpeechToJsonService GetPartOfSpeechToJsonService()
        {
            return new PartOfSpeechToJsonService();
        }
            

    }
}