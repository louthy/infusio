﻿using Newtonsoft.Json;

namespace Infusio.Compiler.Parsing
{
    public class PropertyTypeItems
    {
        public string Type { get; set; }
        public string Format { get; set; }

        [JsonProperty("$ref")] public string Ref { get; set; }
    }
}