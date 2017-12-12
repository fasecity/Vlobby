//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace BodySafe.ViewModels { 



//public class LobbyWatcherViewModel {
//        private BodySafe.Beneficiaries beneficiaries;
//        private BodySafe.Communications communications;
//        private BodySafe.Registrant registrant;

//        private List<BodySafe.Firm> firms;

//        public LobbyWatcherViewModel()
//        {

//        }

//        public LobbyWatcherViewModel(string sMNumber, BodySafe.Beneficiaries beneficiaries, BodySafe.Communications communications, BodySafe.Registrant registrant, string effectiveDate, string initialApprovalDate, string proposedStartDate, string subjectMatter, string particulars, string status, string type)
//        {
//            SMNumber = sMNumber;
//            this.beneficiaries = beneficiaries;
//            this.communications = communications;
//            this.registrant = registrant;

//            this.Firms = LobbyWatchers.FirmStatic;

      

//            EffectiveDate = effectiveDate;
//            InitialApprovalDate = initialApprovalDate;
//            ProposedStartDate = proposedStartDate;
//            SubjectMatter = subjectMatter;
//            Particulars = particulars;
//            Status = status;
//            Type = type;
//        }

//        //-------------------------------------

//        //public properties-----------------------------
//        public string SMNumber { get; set; }

//        public Beneficiaries Beneficiaries { get;set; }
//        public Communications Communications { get; set; }
//        public Registrant Registrant { get; set; }
//        //public Firms Firms { get; set; }
//        public List<BodySafe.Firm> Firms { get; set; }

//        public string EffectiveDate { get; set; }
//        public string InitialApprovalDate { get; set; }
//        public string ProposedStartDate { get; set; }
//        public string ProposedEndDate { get; set; }
       
//        public string Particulars { get; set; }
//        public string SubjectMatter { get; set; }

//        public string Status { get; set; }
//        public string Type { get; set; }
//        //-----------------------------------------------
//}
    

//    public class Registrant
//    {
//        public BusinessAddress BusinessAddress { get; set; }
//        public string EffectiveDate { get; set; }//---need
//        public string FirstName { get; set; } //--need
//        public string LastName { get; set; }//--need
//        public string MiddleInitials { get; set; }
//        public string PositionTitle { get; set; }//--need
//        public string Prefix { get; set; }
//        public string PreviousPublicOfficeHoldLastDate { get; set; }//--need
//        public string PreviousPublicOfficeHoldPosition { get; set; }//--need
//        public string PreviousPublicOfficeHolder { get; set; }//--need
//        public string PreviousPublicOfficePositionProgramName { get; set; }//--need
//        public string RegistrationNUmber { get; set; }//--need
//        public string RegistrationNUmberWithSoNum { get; set; }
//        public string Status { get; set; }//---need
//        public string Suffix { get; set; }
//        public string Type { get; set; }//--need
//    }

//    //public class Firms
//    //{
//    //    public Firm Firm { get; set; }
//    //}

//    public class Communications
//    {
//        public List<Communication> Communication { get; set; }
//    }

//    public class Communication
//    {
//        public string CommunicationDate { get; set; }//--need
//        public string CommunicationGroupId { get; set; }
//        public string CommunicationMethod { get; set; }//
//        public string LobbyistBusiness { get; set; }
//        public BusinessAddress LobbyistBusinessAddress { get; set; }
//        public string LobbyistFirstName { get; set; }
//        public string LobbyistLastName { get; set; }
//        public string LobbyistMiddleInitials { get; set; }
//        public string LobbyistNumber { get; set; }
//        public string LobbyistPositionTitle { get; set; }
//        public string LobbyistPrefix { get; set; }
//        public string LobbyistSuffix { get; set; }
//        public string LobbyistType { get; set; }
//        public string POHName { get; set; }
//        public string POHOffice { get; set; }
//        public string POHPosition { get; set; }
//        public string POHType { get; set; }
//        public string PreviousPublicOfficeHoldLastDate { get; set; }
//        public string PreviousPublicOfficeHoldPosition { get; set; }
//        public string PreviousPublicOfficeHolder { get; set; }
//        public string PreviousPublicOfficePositionProgramName { get; set; }
//    }

//    public class Beneficiaries
//    {
//        public List<BodySafe.Firm> BENEFICIARY { get; set; }//---
//    }

//    //public class Firm
//    //{
//    //    public BusinessAddress BusinessAddress { get; set; }
//    //    public string BusinessType { get; set; }
//    //    public string Description { get; set; }
//    //    public string FiscalEnd { get; set; }
//    //    public string FiscalStart { get; set; }
//    //    public string Name { get; set; }
//    //    public string TradeName { get; set; }
//    //    public string Type { get; set; }
//    //}

//    public class BusinessAddress
//    {
//        public string AddressLine1 { get; set; }
//        public string AddressLine2 { get; set; }
//        public string City { get; set; }
//        public string Country { get; set; }
//        public string Phone { get; set; }
//        public string PostalCode { get; set; }
//        public string Province { get; set; }
//    }
//}
