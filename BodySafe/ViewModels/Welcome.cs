//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
////
////    using BodySafe;
////
////    var data = Welcome.FromJson(jsonString);
////



////////////////////////////////////////////////////////
//// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
////
////    using BodySafe;
////
////    var data = Welcome.FromJson(jsonString);
////
//namespace BodySafe
//{
//    using System;
//    using System.Net;
//    using System.Collections.Generic;

//    using Newtonsoft.Json;

//    public partial class Welcome
//    {
//        [JsonProperty("Beneficiaries")]
//        public Beneficiaries Beneficiaries { get; set; }

//        [JsonProperty("EffectiveDate")]
//        public string EffectiveDate { get; set; }

//        [JsonProperty("Firms")]
//        public Firms Firms { get; set; }

//        [JsonProperty("InitialApprovalDate")]
//        public string InitialApprovalDate { get; set; }

//        [JsonProperty("Particulars")]
//        public string Particulars { get; set; }

//        [JsonProperty("ProposedEndDate")]
//        public string ProposedEndDate { get; set; }

//        [JsonProperty("ProposedStartDate")]
//        public string ProposedStartDate { get; set; }

//        [JsonProperty("Registrant")]
//        public Registrant Registrant { get; set; }

//        [JsonProperty("SMNumber")]
//        public string SMNumber { get; set; }

//        [JsonProperty("Status")]
//        public string Status { get; set; }

//        [JsonProperty("SubjectMatter")]
//        public string SubjectMatter { get; set; }

//        [JsonProperty("Type")]
//        public string Type { get; set; }
//    }

//    public partial class Registrant
//    {
//        [JsonProperty("BusinessAddress")]
//        public BusinessAddress BusinessAddress { get; set; }

//        [JsonProperty("EffectiveDate")]
//        public string EffectiveDate { get; set; }

//        [JsonProperty("FirstName")]
//        public string FirstName { get; set; }

//        [JsonProperty("LastName")]
//        public string LastName { get; set; }

//        [JsonProperty("MiddleInitials")]
//        public string MiddleInitials { get; set; }

//        [JsonProperty("PositionTitle")]
//        public string PositionTitle { get; set; }

//        [JsonProperty("Prefix")]
//        public List<object> Prefix { get; set; }

//        [JsonProperty("PreviousPublicOfficeHoldLastDate")]
//        public List<object> PreviousPublicOfficeHoldLastDate { get; set; }

//        [JsonProperty("PreviousPublicOfficeHoldPosition")]
//        public List<object> PreviousPublicOfficeHoldPosition { get; set; }

//        [JsonProperty("PreviousPublicOfficeHolder")]
//        public string PreviousPublicOfficeHolder { get; set; }

//        [JsonProperty("PreviousPublicOfficePositionProgramName")]
//        public List<object> PreviousPublicOfficePositionProgramName { get; set; }

//        [JsonProperty("RegistrationNUmber")]
//        public string RegistrationNUmber { get; set; }

//        [JsonProperty("RegistrationNUmberWithSoNum")]
//        public string RegistrationNUmberWithSoNum { get; set; }

//        [JsonProperty("Status")]
//        public string Status { get; set; }

//        [JsonProperty("Suffix")]
//        public string Suffix { get; set; }

//        [JsonProperty("Type")]
//        public string Type { get; set; }
//    }

//    public partial class Firms
//    {
//        [JsonProperty("Firm")]
//        public Firm Firm { get; set; }
//    }

//    public partial class Firm
//    {
//        [JsonProperty("BusinessAddress")]
//        public BusinessAddress BusinessAddress { get; set; }

//        [JsonProperty("BusinessType")]
//        public List<object> BusinessType { get; set; }

//        [JsonProperty("Description")]
//        public List<object> Description { get; set; }

//        [JsonProperty("FiscalEnd")]
//        public List<object> FiscalEnd { get; set; }

//        [JsonProperty("FiscalStart")]
//        public List<object> FiscalStart { get; set; }

//        [JsonProperty("Name")]
//        public string Name { get; set; }

//        [JsonProperty("TradeName")]
//        public List<object> TradeName { get; set; }

//        [JsonProperty("Type")]
//        public string Type { get; set; }
//    }

//    public partial class BusinessAddress
//    {
//        [JsonProperty("AddressLine1")]
//        public string AddressLine1 { get; set; }

//        [JsonProperty("AddressLine2")]
//        public string AddressLine2 { get; set; }

//        [JsonProperty("City")]
//        public string City { get; set; }

//        [JsonProperty("Country")]
//        public string Country { get; set; }

//        [JsonProperty("Phone")]
//        public string Phone { get; set; }

//        [JsonProperty("PostalCode")]
//        public string PostalCode { get; set; }

//        [JsonProperty("Province")]
//        public string Province { get; set; }
//    }

//    public partial class Beneficiaries
//    {

//    }

//    public partial class Welcome
//    {
//        public static List<Welcome> FromJson(string json) => JsonConvert.DeserializeObject<List<Welcome>>(json, Converter.Settings);
//    }

//    public static class Serialize
//    {
//        public static string ToJson(this List<Welcome> self) => JsonConvert.SerializeObject(self, Converter.Settings);
//    }

//    public class Converter
//    {
//        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//        {
//            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//            DateParseHandling = DateParseHandling.None,
//        };
//    }
//}


