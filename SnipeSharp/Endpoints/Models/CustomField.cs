using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SnipeSharp.Common;

namespace SnipeSharp.Endpoints.Models
{
    public class CustomField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("db_column_name")]
        public string DbColumnName { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("required")]
        public int? Required { get; set; }

        [JsonProperty("created_at")]
        public ResponseDate CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public ResponseDate UpdatedAt { get; set; }


    }
}
