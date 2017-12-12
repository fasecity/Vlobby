//// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
////
////    using BodySafe;
////
////    var data = LobbyWatcher.FromJson(jsonString);
////
//namespace BodySafe
//{
//    using System;
//    using System.Net;
//    using System.Collections.Generic;

//    using Newtonsoft.Json;

   
   


//    public partial class LobbyWatcher
//    {
       

//        [JsonProperty("Beneficiaries")]
//        public Beneficiaries Beneficiaries { get; set; }

//        [JsonProperty("Communications")]
//        public Communications Communications { get; set; }

//        [JsonProperty("EffectiveDate")]
//        public string EffectiveDate { get; set; }

//        //[JsonProperty("Firms")]
//        //public Firms Firms { get; set; }//made into list was the problem

//        [JsonProperty("Firms")]
//        public Firms Firms { get; set; }// new

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
//        public string Prefix { get; set; }

//        [JsonProperty("PreviousPublicOfficeHoldLastDate")]
//        public string PreviousPublicOfficeHoldLastDate { get; set; }

//        [JsonProperty("PreviousPublicOfficeHoldPosition")]
//        public string PreviousPublicOfficeHoldPosition { get; set; }

//        [JsonProperty("PreviousPublicOfficeHolder")]
//        public string PreviousPublicOfficeHolder { get; set; }

//        [JsonProperty("PreviousPublicOfficePositionProgramName")]
//        public string PreviousPublicOfficePositionProgramName { get; set; }

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

//    //public partial class Firms
//    //{
//    //    [JsonProperty("Firm")]
//    //    public List<Firm> FirmList { get; set; }

//    //    public Firms()
//    //    {
//    //        FirmList = new List<Firm>();
//    //    }
//    //}
//    //public partial class Firms
//    //{
//    //    [JsonProperty("Firms")]
//    //    public List<Firm> FirmsList { get; set; }
//    //}

//    public partial class Firms
//    {
//        [JsonProperty("Firm")]
//        public Firm[] Firm { get; set; }
//    }

//    public partial class Communications
//    {
//        [JsonProperty("Communication")]
//        public List<Communication> Communication { get; set; }
//    }

//    public partial class Communication
//    {
//        [JsonProperty("CommunicationDate")]
//        public string CommunicationDate { get; set; }

//        [JsonProperty("CommunicationGroupId")]
//        public string CommunicationGroupId { get; set; }

//        [JsonProperty("CommunicationMethod")]
//        public string CommunicationMethod { get; set; }

//        [JsonProperty("LobbyistBusiness")]
//        public string LobbyistBusiness { get; set; }

//        [JsonProperty("LobbyistBusinessAddress")]
//        public BusinessAddress LobbyistBusinessAddress { get; set; }

//        [JsonProperty("LobbyistFirstName")]
//        public string LobbyistFirstName { get; set; }

//        [JsonProperty("LobbyistLastName")]
//        public string LobbyistLastName { get; set; }

//        [JsonProperty("LobbyistMiddleInitials")]
//        public string LobbyistMiddleInitials { get; set; }

//        [JsonProperty("LobbyistNumber")]
//        public string LobbyistNumber { get; set; }

//        [JsonProperty("LobbyistPositionTitle")]
//        public string LobbyistPositionTitle { get; set; }

//        [JsonProperty("LobbyistPrefix")]
//        public string LobbyistPrefix { get; set; }

//        [JsonProperty("LobbyistSuffix")]
//        public string LobbyistSuffix { get; set; }

//        [JsonProperty("LobbyistType")]
//        public string LobbyistType { get; set; }

//        [JsonProperty("POH_Name")]
//        public string POHName { get; set; }

//        [JsonProperty("POH_Office")]
//        public string POHOffice { get; set; }

//        [JsonProperty("POH_Position")]
//        public string POHPosition { get; set; }

//        [JsonProperty("POH_Type")]
//        public string POHType { get; set; }

//        [JsonProperty("PreviousPublicOfficeHoldLastDate")]
//        public string PreviousPublicOfficeHoldLastDate { get; set; }

//        [JsonProperty("PreviousPublicOfficeHoldPosition")]
//        public string PreviousPublicOfficeHoldPosition { get; set; }

//        [JsonProperty("PreviousPublicOfficeHolder")]
//        public string PreviousPublicOfficeHolder { get; set; }

//        [JsonProperty("PreviousPublicOfficePositionProgramName")]
//        public string PreviousPublicOfficePositionProgramName { get; set; }
//    }

//    public partial class Beneficiaries
//    {
//        [JsonProperty("BENEFICIARY")]
//        public List<Firm> BENEFICIARY { get; set; }
//    }
//    public partial class Firm
//    {
    
//        [JsonProperty("BusinessAddress")]
//        public BusinessAddress BusinessAddress { get; set; }

//        [JsonProperty("BusinessType")]
//        public string BusinessType { get; set; }

//        [JsonProperty("Description")]
//        public string Description { get; set; }

//        [JsonProperty("FiscalEnd")]
//        public string FiscalEnd { get; set; }

//        [JsonProperty("FiscalStart")]
//        public string FiscalStart { get; set; }

//        [JsonProperty("Name")]
//        public string Name { get; set; }

//        [JsonProperty("TradeName")]
//        public string TradeName { get; set; }

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

//    public partial class LobbyWatcher
//    {

//        //arry
//      // public static List<LobbyWatcher> FromJson(string json) => JsonConvert.DeserializeObject<List<LobbyWatcher>>(json, Converter.Settings);
//        //non array
//       public static LobbyWatcher FromJson(string json) => JsonConvert.DeserializeObject<LobbyWatcher>(json, Converter.Settings);
//    }

//    public static class Serialize
//    {
//        //array
//       // public static string ToJson(this List<LobbyWatcher> self) => JsonConvert.SerializeObject(self, Converter.Settings);

//        //non array
//        public static string ToJson(this LobbyWatcher self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
