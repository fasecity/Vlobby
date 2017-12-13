/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using BodySafe;
using System.Threading.Tasks;

namespace ViewModels.LobbyCat
{
    [XmlRoot(ElementName = "BusinessAddress")]
    public class BusinessAddress
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "AddressLine1")]
        public string AddressLine1 { get; set; }
        [XmlElement(ElementName = "AddressLine2")]
        public string AddressLine2 { get; set; }
        [XmlElement(ElementName = "City")]
        public string City { get; set; }
        [XmlElement(ElementName = "Province")]
        public string Province { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; }
    }

    [XmlRoot(ElementName = "Registrant")]
    public class Registrant
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "RegistrationNUmber")]
        public string RegistrationNUmber { get; set; }
        [XmlElement(ElementName = "RegistrationNUmberWithSoNum")]
        public string RegistrationNUmberWithSoNum { get; set; }
        [XmlElement(ElementName = "Status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "EffectiveDate")]
        public string EffectiveDate { get; set; }
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "Prefix")]
        public string Prefix { get; set; }
        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "MiddleInitials")]
        public string MiddleInitials { get; set; }
        [XmlElement(ElementName = "LastName")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "Suffix")]
        public string Suffix { get; set; }
        [XmlElement(ElementName = "PositionTitle")]
        public string PositionTitle { get; set; }
        [XmlElement(ElementName = "PreviousPublicOfficeHolder")]
        public string PreviousPublicOfficeHolder { get; set; }
        [XmlElement(ElementName = "PreviousPublicOfficeHoldPosition")]
        public string PreviousPublicOfficeHoldPosition { get; set; }
        [XmlElement(ElementName = "PreviousPublicOfficePositionProgramName")]
        public string PreviousPublicOfficePositionProgramName { get; set; }
        [XmlElement(ElementName = "PreviousPublicOfficeHoldLastDate")]
        public string PreviousPublicOfficeHoldLastDate { get; set; }
        [XmlElement(ElementName = "BusinessAddress")]
        public BusinessAddress BusinessAddress { get; set; }
    }

    [XmlRoot(ElementName = "BENEFICIARY")]
    public class BENEFICIARY
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "TradeName")]
        public string TradeName { get; set; }
        [XmlElement(ElementName = "FiscalStart")]
        public string FiscalStart { get; set; }
        [XmlElement(ElementName = "FiscalEnd")]
        public string FiscalEnd { get; set; }
        [XmlElement(ElementName = "BusinessAddress")]
        public BusinessAddress BusinessAddress { get; set; }
    }

    [XmlRoot(ElementName = "Beneficiaries")]
    public class Beneficiaries
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "BENEFICIARY")]
        public List<BENEFICIARY> BENEFICIARY { get; set; }
    }

    [XmlRoot(ElementName = "Firm")]
    public class Firm
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "TradeName")]
        public string TradeName { get; set; }
        [XmlElement(ElementName = "FiscalStart")]
        public string FiscalStart { get; set; }
        [XmlElement(ElementName = "FiscalEnd")]
        public string FiscalEnd { get; set; }
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "BusinessType")]
        public string BusinessType { get; set; }
        [XmlElement(ElementName = "BusinessAddress")]
        public BusinessAddress BusinessAddress { get; set; }
    }

    //[XmlRoot(ElementName = "Firms")]
    //public class Firms
    //{
    //    [XmlElement(ElementName = "Firm")]
    //    public Firm Firm { get; set; }

    //}

    [XmlRoot(ElementName = "Firms")]
    public class Firms
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "Firm")]
        public virtual  List<Firm> Firm { get; set; }
    }

    [XmlRoot(ElementName = "ROW")]
    public class ROW
    { 
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "SMNumber")]
        public string SMNumber { get; set; }
        [XmlElement(ElementName = "Status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "SubjectMatter")]
        public string SubjectMatter { get; set; }
        [XmlElement(ElementName = "Particulars")]
        public string Particulars { get; set; }
        [XmlElement(ElementName = "InitialApprovalDate")]
        public string InitialApprovalDate { get; set; }
        [XmlElement(ElementName = "EffectiveDate")]
        public string EffectiveDate { get; set; }
        [XmlElement(ElementName = "ProposedStartDate")]
        public string ProposedStartDate { get; set; }
        [XmlElement(ElementName = "ProposedEndDate")]
        public string ProposedEndDate { get; set; }
        [XmlElement(ElementName = "Registrant")]
        public virtual Registrant Registrant { get; set; }
        [XmlElement(ElementName = "Beneficiaries")]
        public virtual Beneficiaries Beneficiaries { get; set; }
        [XmlElement(ElementName = "Firms")]
        public virtual Firms Firms { get; set; }
    }

    [XmlRoot(ElementName = "ROWSET")]
    public class ROWSET
    {
        
        [XmlElement(ElementName = "ROW")]
        public ROW[] ROW { get; set; }
    }


    

    public class LobbyFactory
    {
        //--------------------------------------db static ----------------------------------------
        public static DbContextOptions<ApiContext> options = new DbContextOptions<ApiContext>();
        public static ApiContext db = new ApiContext(Options);
        public static DbContextOptions<ApiContext> Options { get => options; set => options = value; }
        //------------------------------------------------------------------------------------------

        public static async Task<ROWSET> Deserialize()      
        {
           
            ROWSET lobbyist = null;
            string path = @"D:\Users\Mo\source\repos\BodySafe\BodySafe\RawData\XMLFile.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(ROWSET));

            using (var reader = new StreamReader(path))
            {
                lobbyist = (ROWSET)serializer.Deserialize(reader);
                reader.Close();               
            }
             
            for (int items = 0; items < lobbyist.ROW.Length; items++)
            {
                              
               db.LobbyActivity.AddRange(lobbyist.ROW[items]);
                          
            }

            await  db.SaveChangesAsync();

            return  lobbyist;

        }

    }

}
