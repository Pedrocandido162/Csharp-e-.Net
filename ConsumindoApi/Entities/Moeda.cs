﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApi.Entities
{
    public class Moeda
    {
        
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public decimal Buy { get; set; }

        [JsonProperty(PropertyName = "sell")]
        public decimal Sell { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public decimal Variation { get; set; }
    }
}
    

