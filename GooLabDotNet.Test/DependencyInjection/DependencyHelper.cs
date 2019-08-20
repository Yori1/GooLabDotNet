
using GooLabDotNet.MorphologicalAnalysis.Logic.CharacterSetDetection;
using GooLabDotNet.MorphologicalAnalysis.Logic.MorphemeFieldConversion;


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

    }
}