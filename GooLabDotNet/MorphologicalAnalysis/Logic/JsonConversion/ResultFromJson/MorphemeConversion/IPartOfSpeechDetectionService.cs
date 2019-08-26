using System;
using System.Collections.Generic;
using System.Text;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion
{
    internal interface IPartOfSpeechDetectionService
    {
        PartOfSpeech DetectPartOfSpeech(string jsonPartOfSpeech);
    }
}
