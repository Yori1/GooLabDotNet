using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using GooLabDotNet.MorphologicalAnalysis.Models.Domain;

[assembly:InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion
{
    internal  interface IMorphemeConversionService
    {
        Morpheme ConvertToMorpheme(List<string> morphemeJsonArray);
    }
}
