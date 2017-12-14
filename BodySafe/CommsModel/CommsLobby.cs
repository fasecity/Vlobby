using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CommsModel;

namespace CommsModel
{

    [XmlRoot(ElementName = "BusinessAddress")]
    public class BusinessAddressT
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
    public class RegistrantT
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
        public BusinessAddressT BusinessAddress { get; set; }
    }

    [XmlRoot(ElementName = "LobbyistBusinessAddress")]
    public class LobbyistBusinessAddressT
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

    [XmlRoot(ElementName = "Communication")]
    public class CommunicationT
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "POH_Office")]
        public string POH_Office { get; set; }
        [XmlElement(ElementName = "POH_Type")]
        public string POH_Type { get; set; }
        [XmlElement(ElementName = "POH_Position")]
        public string POH_Position { get; set; }
        [XmlElement(ElementName = "POH_Name")]
        public string POH_Name { get; set; }
        [XmlElement(ElementName = "CommunicationMethod")]
        public string CommunicationMethod { get; set; }
        [XmlElement(ElementName = "CommunicationDate")]
        public string CommunicationDate { get; set; }
        [XmlElement(ElementName = "CommunicationGroupId")]
        public string CommunicationGroupId { get; set; }
        [XmlElement(ElementName = "LobbyistNumber")]
        public string LobbyistNumber { get; set; }
        [XmlElement(ElementName = "LobbyistType")]
        public string LobbyistType { get; set; }
        [XmlElement(ElementName = "LobbyistPrefix")]
        public string LobbyistPrefix { get; set; }
        [XmlElement(ElementName = "LobbyistFirstName")]
        public string LobbyistFirstName { get; set; }
        [XmlElement(ElementName = "LobbyistMiddleInitials")]
        public string LobbyistMiddleInitials { get; set; }
        [XmlElement(ElementName = "LobbyistLastName")]
        public string LobbyistLastName { get; set; }
        [XmlElement(ElementName = "LobbyistSuffix")]
        public string LobbyistSuffix { get; set; }
        [XmlElement(ElementName = "LobbyistBusiness")]
        public string LobbyistBusiness { get; set; }
        [XmlElement(ElementName = "LobbyistPositionTitle")]
        public string LobbyistPositionTitle { get; set; }
        [XmlElement(ElementName = "PreviousPublicOfficeHolder")]
        public string PreviousPublicOfficeHolder { get; set; }
        [XmlElement(ElementName = "PreviousPublicOfficeHoldPosition")]
        public string PreviousPublicOfficeHoldPosition { get; set; }
        [XmlElement(ElementName = "PreviousPublicOfficePositionProgramName")]
        public string PreviousPublicOfficePositionProgramName { get; set; }
        [XmlElement(ElementName = "PreviousPublicOfficeHoldLastDate")]
        public string PreviousPublicOfficeHoldLastDate { get; set; }
        [XmlElement(ElementName = "LobbyistBusinessAddress")]
        public LobbyistBusinessAddressT LobbyistBusinessAddress { get; set; }
    }

    [XmlRoot(ElementName = "Communications")]
    public class CommunicationsT
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "Communication")]
        public List<CommunicationT> Communication { get; set; }
    }

    [XmlRoot(ElementName = "Firm")]
    public class FirmT
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
        public BusinessAddressT BusinessAddress { get; set; }
    }

    [XmlRoot(ElementName = "Firms")]
    public class FirmsT
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "Firm")]
        public FirmT Firm { get; set; }
    }


    [XmlRoot(ElementName = "BENEFICIARY")]
    public class BENEFICIARYT
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
        public BusinessAddressT BusinessAddress { get; set; }
    }

    [XmlRoot(ElementName = "Beneficiaries")]
    public class BeneficiariesT
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "BENEFICIARY")]
        public List<BENEFICIARYT> BENEFICIARY { get; set; }
    }


    [XmlRoot(ElementName = "ROW")]
    public class COMMSLOBBROW
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
        public virtual RegistrantT Registrant { get; set; }
        [XmlElement(ElementName = "Communications")]
        public virtual CommunicationsT Communications { get; set; }
        [XmlElement(ElementName = "Firms")]
        public virtual FirmsT Firms { get; set; }
        [XmlElement(ElementName = "Beneficiaries")]
        public virtual BeneficiariesT Beneficiaries { get; set; }
    }

    [XmlRoot(ElementName = "ROWSET")]//--same rowset
    public class LobbyCollection //--------------------same as rowset root class
    {
        [XmlElement(ElementName = "ROW")]
        public COMMSLOBBROW[] ROW { get; set; } // -- same as ROW
    }
}

public class XMLCommLobb
{
    //--------------------------------------db static ----------------------------------------
    public static DbContextOptions<BodySafe.ApiContext> options = new DbContextOptions<BodySafe.ApiContext>();
    public static BodySafe.ApiContext db = new BodySafe.ApiContext(Options);
    public static DbContextOptions<BodySafe.ApiContext> Options { get => options; set => options = value; }
    //------------------------------------------------------------------------------------------

    public static async Task<int> Deserialize()
    {
        var x = 1;
        LobbyCollection Commlobbyist = null;
        string path = @"D:\Users\Mo\source\repos\BodySafe\BodySafe\RawData\XMLFile.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(LobbyCollection));

        using (var reader = new StreamReader(path))
        {
            Commlobbyist = (LobbyCollection)serializer.Deserialize(reader);
            reader.Close();
        }

        for (int items = 0; items < Commlobbyist.ROW.Length; items++)
        {

             db.CommsLobbActivity.AddRange(Commlobbyist.ROW[items]);

        }

        await db.SaveChangesAsync();

        return x;

    }

}

