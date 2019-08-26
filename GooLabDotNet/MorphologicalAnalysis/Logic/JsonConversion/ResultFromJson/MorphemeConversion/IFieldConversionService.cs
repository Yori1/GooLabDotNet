using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

[assembly: InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.JsonToResult.MorphemeConversion
{
    internal interface IFieldConversionService
    {
        MorphemeField DetermineField(string jsonField);
    }
}
