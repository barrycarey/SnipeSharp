using Newtonsoft.Json;
using SnipeSharp.Common;
using System.Collections.Generic;
using SnipeSharp.Attributes;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("User not found")]
    public class User : CommonEndpointModel
    {

        [JsonProperty("name")]
        [OptionalRequestHeader("name")]
        public new string Name { get; set; }

        [JsonProperty("accessories_count")]
        public long? AccessoriesCount { get; set; }

        [JsonProperty("activated")]
        [OptionalRequestHeader("activated")]
        public bool Activated { get; set; }

        [JsonProperty("address")]
        [OptionalRequestHeader("address")]
        public string Address { get; set; }

        [JsonProperty("assets_count")]
        public long? AssetsCount { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("city")]
        [OptionalRequestHeader("city")]
        public string City { get; set; }

        [JsonProperty("company")]
        [OptionalRequestHeader("company_id")]
        public Company Company { get; set; }

        [JsonProperty("consumables_count")]
        public long ConsumablesCount { get; set; }

        [JsonProperty("country")]
        [OptionalRequestHeader("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        [OptionalRequestHeader("email")]
        public string Email { get; set; }

        [JsonProperty("employee_num")]
        [OptionalRequestHeader("employee_num")]
        public string EmployeeNum { get; set; }

        [JsonProperty("firstname")]
        [RequiredRequestHeader("first_name")]
        public string Firstname { get; set; }

        [JsonProperty("jobtitle")]
        [OptionalRequestHeader("jobtitle")]
        public string Jobtitle { get; set; }

        [JsonProperty("last_login")]
        public ResponseDate LastLogin { get; set; }

        [JsonProperty("lastname")]
        [OptionalRequestHeader("last_name")]
        public string Lastname { get; set; }

        [JsonProperty("licenses_count")]
        public long? LicensesCount { get; set; }

        [JsonProperty("location")]
        [OptionalRequestHeader("location_id")]
        public Location Location { get; set; }

        [JsonProperty("manager")]
        [OptionalRequestHeader("manager_id")]
        public User Manager { get; set; }

        [JsonProperty("notes")]
        [OptionalRequestHeader("notes")]
        public string Notes { get; set; }

        [JsonProperty("permissions")]
        public Dictionary<string, string> Permissions { get; set; }

        [JsonProperty("phone")]
        [OptionalRequestHeader("phone")]
        public string Phone { get; set; }

        [JsonProperty("state")]
        [OptionalRequestHeader("state")]
        public string State { get; set; }

        [JsonProperty("two_factor_activated")]
        public bool TwoFactorActivated { get; set; }

        [JsonProperty("username")]
        [RequiredRequestHeader("username")]
        public string Username { get; set; }

        [JsonProperty("zip")]
        [OptionalRequestHeader("zip")]
        public object Zip { get; set; }

        [RequiredRequestHeader("password")]
        public string Password { get; set; }

        [JsonProperty("department")]
        [OptionalRequestHeader("department_id")]
        public Department Department { get; set; }
    }
}
