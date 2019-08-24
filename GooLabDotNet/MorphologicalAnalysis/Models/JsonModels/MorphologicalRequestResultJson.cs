using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace GooLabDotNet.MorphologicalAnalysis.Models.JsonModels
{
    public partial class MorphologicalRequestResultJson
    {
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("word_list")]
        public List<List<List<string>>> WordList { get; set; }
    }

}
