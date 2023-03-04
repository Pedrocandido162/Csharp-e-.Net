using ConsumindoApi.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApi
{
    public class Market
    {
        public Market()
        {
            this.Usdbrl= new Brl();
            this.Eurbrl= new Brl();
        }

        [JsonProperty("USDBRL")]
        public Brl Usdbrl { get; set; }

        [JsonProperty("EURBRL")]
        public Brl Eurbrl { get; set; }
    }

}
    



