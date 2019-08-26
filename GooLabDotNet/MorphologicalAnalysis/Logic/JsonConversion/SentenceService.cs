using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion;
using GooLabDotNet.MorphologicalAnalysis.Models.Domain;

[assembly:InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion
{
    internal class SentenceService
    {
        private readonly MorphemeConversionService morphemeConversionService;

        public SentenceService(MorphemeConversionService morphemeConversionService)
        {
            this.morphemeConversionService = morphemeConversionService;
        }

        public List<Sentence> JsonSentencesToSentences(List<List<List<string>>> jsonReturnedSentences) {
            List<Sentence> sentences = new List<Sentence>();
            foreach(List<List<string>> jsonSentence in jsonReturnedSentences) {
                sentences.Add(JsonSentenceToSentence(jsonSentence));
            }

            return sentences;
        }

        private Sentence JsonSentenceToSentence(List<List<string>> jsonSentence) {
            List<Morpheme> morphemes = new List<Morpheme>();

            foreach(List<string> jsonMorpheme in jsonSentence) {
                var morpheme = morphemeConversionService.ConvertToMorpheme(jsonMorpheme);
                morphemes.Add(morpheme);
            }

            return new Sentence(morphemes);
        }
    }
}