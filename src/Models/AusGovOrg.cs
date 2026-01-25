namespace FollowTheMoney.Models;

public class GovOrg
{
    public Guid Id { get; set; } //DB generated ID
    public string? InternalDocId {get; set; } // ID provided in the source document
    public required string DeptName {get; set; } /// Name of the Government Department
    public string? IsPortfolioDept {get; set; } //Yes or No response
    public string? Abbreviation {get; set; } // Abbreviation of the Department Name
    public string? PortfolioName {get; set; } // Name of the Portfolio the Department belongs to
    public string? Classification {get; set; } //Classification of the Department
    public string? TypeOfBody {get; set; } // Type of Government Body
    public string? GFSSectorClass {get; set; } // Government Finance Statistics Sector Class
    public string? GFSFunctionSector {get; set; } // Government Finance Statistics Function Sector
    public string? Materiality {get; set; } // Materiality threshold (Material/Small/)
    public string? Description {get; set; } // Summary description of the Department
    public string? EstablishedByOrUnder {get; set; } // Legislation or other authority under which the Department was established
    public string? EstablishedByOrUnderMoreInfo {get; set; } // Additional information on the establishment authority
    public string? PSActBody {get; set; } // Whether the body is established under the Public Service Act
    public DateTime DateEstablished {get; set; } // Date the Department was established/created
    public DateTime? DateDissolved {get; set; } // Date the Department was dissolved (if applicable)
    public string? AverageStaffingLevel {get; set; } // Average number of staff employed
    public string? MaxBoardMembers {get; set; } // Maximum number of board members allowed
    public string? HasPaidMembers {get; set; } // Whether the board has paid members
    public string? BoardCommitteeAppointedBy {get; set; } // Authority that appoints board/committee members
    public string? BoardCommitteeAppointedByMoreInfo {get; set; } // Additional info on appointing authority
    public string? Auditor {get; set; } // Name of the Auditor
    public string? AuditoOtherInfo {get; set; } // Additional info about the Auditor
    public string? ABN {get; set; } // Australian Business Number
    public string? ParentOrganisation {get; set; } // Name of the Parent Organisation
    public string? ParentBoardNonBoardTitle {get; set; } // Title of the Parent Board or Non-Board position
    public string? HeadOfficeStreetAddress {get; set; } // Street address of the Head Office
    public string? HeadOfficeSuburb {get; set; } // Suburb of the Head Office
    public string? HeadOfficeState {get; set; } // State of the Head Office
    public string? HeadOfficePostcode {get; set; } // Postcode of the Head Office
    public string? WebsiteAddress {get; set; } // Website URL of the Organisation
    public string? MainPhoneNumber {get; set; } // Main contact phone number
    public string? StrategicCorporateOrganisationalPlan {get; set; }
    public string? AnnualReport {get; set; } // Link to the latest Annual Report
    public string? BudgetDocumentation {get; set; } // Link to the latest Budget Documentation
    public string? TotalAppropriation {get; set; } //$000
    public string? TotalDeptExpenses {get; set; } //$000

    //Sources
    public List<string>? SourceDocument {get; set; } // List of source document URLs or references

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Foreign key
    public Politician? Politician { get; set; }

}