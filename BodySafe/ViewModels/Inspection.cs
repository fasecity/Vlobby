//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace BodySafe
//{
//    public class Inspection
//    {
//        public int rowNo { get; set; }
//        public int estID { get; set; }

//        public string estName { get; set; }//-------need
//        public int addrID { get; set; }
//        public string addr { get; set; }//-------need
//        public string unit { get; set; }//-------need
//        public string postal { get; set; }

//        public double lat { get; set; }//--------need
//        public double lon { get; set; }//--------need

//        public string estStatusCD { get; set; }//-----MUST need pass/fl
//        public string estStatusDesc { get; set; }

//        public int servID { get; set; }
//        public string servTypeCD { get; set; }
//        public string servTypeDesc { get; set; }//---says what they do eg.barber

//        public int inspID { get; set; }
//        public string inspDate { get; set; }// date of inspection
//        public string inspStatusDesc { get; set; }// conditional pass eg

//        public string infrID { get; set; }
//        public string infrTypeCD { get; set; }
//        public string infrTypeDesc { get; set; }//------description of bad stuff
//        public string infrAction { get; set; }

//        public string enfrID { get; set; }//---------------------enforment outcome
//        public string enfrAmountFined { get; set; }
//        public string enfrOutcomeDate { get; set; }


//    }
//}
////{"rowNo":2114,
////"estID":4003546,
////"estName":"SKINZ BARBER SHOP",--------------------------*
////"addrID":2906484,
////"addr":"2627 LAWRENCE AVE E" --------------------------*
////,"unit":null,
////"postal":"M1P",
////"lat":43.7515302117, --------------------------*
////"lon":-79.2638714695, --------------------------*
////"estStatusCD":"PASS",--------------------------*
////"estStatusDesc":"Pass",--------------------------*
////"servID":559169,
////"servTypeCD":"7016",
////"servTypeDesc":"Barbering & Hairdressing",--------------------------*
////"inspID":3009172,
////"inspDate":"2017-11-24",--------------------------*
////"inspStatusDesc":"Conditional",--------------------------*
////"infrID":368249,
////"infrTypeCD":"10015",
////"infrTypeDesc":"Work surfaces cleaned then disinfected with a LLD daily",--------------------------*
////"infrAction":"Notice to Comply",--------------------------*
////"enfrID":null,
////"enfrAmountFined":null,
////"enfrOutcomeDate":null,
////"enfrOutcome":null}





////-------------------New viewModel Class----------------//
////time and place
////"lat":43.7515302117, -----------------lat---------*double
////"lon":-79.2638714695, -----------------lon---------*double
////"inspDate":"2017-11-24",----------DateInspected----------------*DateTime tostring

////name and address
////"estName":"SKINZ BARBER SHOP",----------Name----------------*string
////"addr":"2627 LAWRENCE AVE E" ---------address-----------------*string


////"servTypeDesc":"Barbering & Hairdressing",-------------TypeOfComoany-------------*string



////"infrTypeDesc":"Work surfaces cleaned then disinfected with a LLD daily",----------Infraction----------------*
////"infrAction":"Notice to Comply",---------InfractionAction-----------------*
////"inspStatusDesc":"Conditional",---------Insspection status-----------------* string
////"estStatusDesc":"Pass",-------------Status-------------*string


