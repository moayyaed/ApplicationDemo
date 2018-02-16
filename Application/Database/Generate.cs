// Do not modify this file. It's generated by BuildTool generate command.
//
namespace Database.dbo
{
    using Framework.DataAccessLayer;
    using System;

    [SqlTable("dbo", "Airline")]
    public partial class Airline : Row
    {
        [SqlColumn("Id", typeof(Airline_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Text", typeof(Airline_Text))]
        public string Text { get; set; }

        [SqlColumn("Code", typeof(Airline_Code))]
        public string Code { get; set; }

        [SqlColumn("Country", typeof(Airline_Country))]
        public string Country { get; set; }
    }

    public partial class Airline_Id : Cell<Airline> { }

    public partial class Airline_Text : Cell<Airline> { }

    public partial class Airline_Code : Cell<Airline> { }

    public partial class Airline_Country : Cell<Airline> { }

    [ConfigGrid("AirportCodeLookup", 0, true, false, false)]
    [ConfigGrid("AirportTextLookup", 0, true, false, false)]
    [ConfigGrid("Master", 0, true, false, false)]
    [SqlTable("dbo", "Airport")]
    public partial class Airport : Row
    {
        [SqlColumn("Id", typeof(Airport_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Text", typeof(Airport_Text))]
        public string Text { get; set; }

        [SqlColumn("Code", typeof(Airport_Code))]
        public string Code { get; set; }

        [SqlColumn("CountryId", typeof(Airport_CountryId))]
        public int? CountryId { get; set; }
    }

    public partial class Airport_Id : Cell<Airport> { }

    public partial class Airport_Text : Cell<Airport> { }

    [ConfigColumn(gridName: "Master", text: "Text", description: "Description", isVisible: true, isVisibleIsNull: false, isReadOnly: true, isReadOnlyIsNull: false, sort: 22, sortIsNull: false, widthPercent: 55, widthPercentIsNull: false)]
    public partial class Airport_Code : Cell<Airport> { }

    public partial class Airport_CountryId : Cell<Airport> { }

    [SqlTable("dbo", "AirportDisplay")]
    public partial class AirportDisplay : Row
    {
        [SqlColumn("AirportId", typeof(AirportDisplay_AirportId))]
        public int AirportId { get; set; }

        [SqlColumn("AirportText", typeof(AirportDisplay_AirportText))]
        public string AirportText { get; set; }

        [SqlColumn("AirportCode", typeof(AirportDisplay_AirportCode))]
        public string AirportCode { get; set; }

        [SqlColumn("CountryId", typeof(AirportDisplay_CountryId))]
        public int? CountryId { get; set; }

        [SqlColumn("CountryText", typeof(AirportDisplay_CountryText))]
        public string CountryText { get; set; }

        [SqlColumn("CountryContinent", typeof(AirportDisplay_CountryContinent))]
        public string CountryContinent { get; set; }
    }

    public partial class AirportDisplay_AirportId : Cell<AirportDisplay> { }

    public partial class AirportDisplay_AirportText : Cell<AirportDisplay> { }

    public partial class AirportDisplay_AirportCode : Cell<AirportDisplay> { }

    public partial class AirportDisplay_CountryId : Cell<AirportDisplay> { }

    public partial class AirportDisplay_CountryText : Cell<AirportDisplay> { }

    public partial class AirportDisplay_CountryContinent : Cell<AirportDisplay> { }

    [SqlTable("dbo", "Country")]
    public partial class Country : Row
    {
        [SqlColumn("Id", typeof(Country_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Text", typeof(Country_Text))]
        public string Text { get; set; }

        [SqlColumn("TextShort", typeof(Country_TextShort))]
        public string TextShort { get; set; }

        [SqlColumn("Continent", typeof(Country_Continent))]
        public string Continent { get; set; }
    }

    public partial class Country_Id : Cell<Country> { }

    public partial class Country_Text : Cell<Country> { }

    public partial class Country_TextShort : Cell<Country> { }

    public partial class Country_Continent : Cell<Country> { }

    [ConfigGrid(null, 0, true, true, false)]
    [ConfigGrid("Detail", 5, false, true, false)]
    [SqlTable("dbo", "Flight")]
    public partial class Flight : Row
    {
        [SqlColumn("Id", typeof(Flight_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Date", typeof(Flight_Date))]
        public DateTime? Date { get; set; }

        [SqlColumn("Number", typeof(Flight_Number))]
        public double? Number { get; set; }

        [SqlColumn("AirlineCode", typeof(Flight_AirlineCode))]
        public string AirlineCode { get; set; }

        [SqlColumn("AirlineText", typeof(Flight_AirlineText))]
        public string AirlineText { get; set; }

        [SqlColumn("AirlineValid", typeof(Flight_AirlineValid))]
        public string AirlineValid { get; set; }

        [SqlColumn("AirportCode", typeof(Flight_AirportCode))]
        public string AirportCode { get; set; }

        [SqlColumn("AirportText", typeof(Flight_AirportText))]
        public string AirportText { get; set; }

        [SqlColumn("AirportValid", typeof(Flight_AirportValid))]
        public string AirportValid { get; set; }
    }

    public partial class Flight_Id : Cell<Flight> { }

    [ConfigColumn(gridName: "Detail", text: "DATE", description: null, isVisible: false, isVisibleIsNull: true, isReadOnly: false, isReadOnlyIsNull: true, sort: 0, sortIsNull: true, widthPercent: 0, widthPercentIsNull: true)]
    public partial class Flight_Date : Cell<Flight> { }

    [ConfigColumn(gridName: "Detail", text: null, description: null, isVisible: false, isVisibleIsNull: false, isReadOnly: false, isReadOnlyIsNull: true, sort: 0, sortIsNull: true, widthPercent: 0, widthPercentIsNull: true)]
    public partial class Flight_Number : Cell<Flight> { }

    [ConfigColumn(gridName: "Detail", text: "Airline Code", description: null, isVisible: false, isVisibleIsNull: false, isReadOnly: false, isReadOnlyIsNull: true, sort: 0, sortIsNull: true, widthPercent: 0, widthPercentIsNull: true)]
    public partial class Flight_AirlineCode : Cell<Flight> { }

    [ConfigColumn(gridName: "Detail", text: "Airline", description: null, isVisible: false, isVisibleIsNull: true, isReadOnly: false, isReadOnlyIsNull: false, sort: 0, sortIsNull: true, widthPercent: 0, widthPercentIsNull: true)]
    public partial class Flight_AirlineText : Cell<Flight> { }

    [ConfigColumn(gridName: "Detail", text: null, description: null, isVisible: false, isVisibleIsNull: false, isReadOnly: false, isReadOnlyIsNull: true, sort: 0, sortIsNull: true, widthPercent: 0, widthPercentIsNull: true)]
    public partial class Flight_AirlineValid : Cell<Flight> { }

    [ConfigColumn(gridName: "Detail", text: "AirportCode", description: null, isVisible: false, isVisibleIsNull: true, isReadOnly: true, isReadOnlyIsNull: false, sort: 0, sortIsNull: true, widthPercent: 0, widthPercentIsNull: true)]
    public partial class Flight_AirportCode : Cell<Flight> { }

    [ConfigColumn(gridName: "Detail", text: "Airport", description: null, isVisible: false, isVisibleIsNull: true, isReadOnly: false, isReadOnlyIsNull: true, sort: 0, sortIsNull: true, widthPercent: 0, widthPercentIsNull: true)]
    public partial class Flight_AirportText : Cell<Flight> { }

    [ConfigColumn(gridName: "Detail", text: "Valid", description: null, isVisible: false, isVisibleIsNull: true, isReadOnly: true, isReadOnlyIsNull: false, sort: 0, sortIsNull: true, widthPercent: 0, widthPercentIsNull: true)]
    public partial class Flight_AirportValid : Cell<Flight> { }

    [SqlTable("dbo", "LoLoation")]
    public partial class LoLoation : Row
    {
        [SqlColumn("Id", typeof(LoLoation_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Name", typeof(LoLoation_Name))]
        public string Name { get; set; }
    }

    public partial class LoLoation_Id : Cell<LoLoation> { }

    public partial class LoLoation_Name : Cell<LoLoation> { }

    [SqlTable("dbo", "LoRole")]
    public partial class LoRole : Row
    {
        [SqlColumn("Id", typeof(LoRole_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Name", typeof(LoRole_Name))]
        public string Name { get; set; }

        [SqlColumn("IsAdmin", typeof(LoRole_IsAdmin))]
        public bool IsAdmin { get; set; }
    }

    public partial class LoRole_Id : Cell<LoRole> { }

    public partial class LoRole_Name : Cell<LoRole> { }

    public partial class LoRole_IsAdmin : Cell<LoRole> { }

    [SqlTable("dbo", "LoRoleAccess")]
    public partial class LoRoleAccess : Row
    {
        [SqlColumn("UserId", typeof(LoRoleAccess_UserId))]
        public int UserId { get; set; }

        [SqlColumn("UserName", typeof(LoRoleAccess_UserName))]
        public string UserName { get; set; }

        [SqlColumn("LoationId", typeof(LoRoleAccess_LoationId))]
        public int? LoationId { get; set; }

        [SqlColumn("LoationName", typeof(LoRoleAccess_LoationName))]
        public string LoationName { get; set; }
    }

    public partial class LoRoleAccess_UserId : Cell<LoRoleAccess> { }

    public partial class LoRoleAccess_UserName : Cell<LoRoleAccess> { }

    public partial class LoRoleAccess_LoationId : Cell<LoRoleAccess> { }

    public partial class LoRoleAccess_LoationName : Cell<LoRoleAccess> { }

    [SqlTable("dbo", "LoRoleLoation")]
    public partial class LoRoleLoation : Row
    {
        [SqlColumn("Id", typeof(LoRoleLoation_Id), true)]
        public int Id { get; set; }

        [SqlColumn("RoleId", typeof(LoRoleLoation_RoleId))]
        public int? RoleId { get; set; }

        [SqlColumn("UserId", typeof(LoRoleLoation_UserId))]
        public int? UserId { get; set; }

        [SqlColumn("LoationId", typeof(LoRoleLoation_LoationId))]
        public int LoationId { get; set; }

        [SqlColumn("IsActive", typeof(LoRoleLoation_IsActive))]
        public bool IsActive { get; set; }
    }

    public partial class LoRoleLoation_Id : Cell<LoRoleLoation> { }

    public partial class LoRoleLoation_RoleId : Cell<LoRoleLoation> { }

    public partial class LoRoleLoation_UserId : Cell<LoRoleLoation> { }

    public partial class LoRoleLoation_LoationId : Cell<LoRoleLoation> { }

    public partial class LoRoleLoation_IsActive : Cell<LoRoleLoation> { }

    [SqlTable("dbo", "LoRoleMatrix")]
    public partial class LoRoleMatrix : Row
    {
        [SqlColumn("UserId", typeof(LoRoleMatrix_UserId))]
        public int UserId { get; set; }

        [SqlColumn("UserName", typeof(LoRoleMatrix_UserName))]
        public string UserName { get; set; }

        [SqlColumn("LoationId", typeof(LoRoleMatrix_LoationId))]
        public int LoationId { get; set; }

        [SqlColumn("LoationName", typeof(LoRoleMatrix_LoationName))]
        public string LoationName { get; set; }

        [SqlColumn("RoleId", typeof(LoRoleMatrix_RoleId))]
        public int RoleId { get; set; }

        [SqlColumn("RoleName", typeof(LoRoleMatrix_RoleName))]
        public string RoleName { get; set; }

        [SqlColumn("IsRole", typeof(LoRoleMatrix_IsRole))]
        public bool? IsRole { get; set; }

        [SqlColumn("IsDirect", typeof(LoRoleMatrix_IsDirect))]
        public bool? IsDirect { get; set; }

        [SqlColumn("IsAdmin", typeof(LoRoleMatrix_IsAdmin))]
        public bool? IsAdmin { get; set; }

        [SqlColumn("IsAdminModule", typeof(LoRoleMatrix_IsAdminModule))]
        public bool? IsAdminModule { get; set; }

        [SqlColumn("IsAccess", typeof(LoRoleMatrix_IsAccess))]
        public int? IsAccess { get; set; }
    }

    public partial class LoRoleMatrix_UserId : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_UserName : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_LoationId : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_LoationName : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_RoleId : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_RoleName : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_IsRole : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_IsDirect : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_IsAdmin : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_IsAdminModule : Cell<LoRoleMatrix> { }

    public partial class LoRoleMatrix_IsAccess : Cell<LoRoleMatrix> { }

    [SqlTable("dbo", "LoRoleUser")]
    public partial class LoRoleUser : Row
    {
        [SqlColumn("Id", typeof(LoRoleUser_Id), true)]
        public int Id { get; set; }

        [SqlColumn("UserId", typeof(LoRoleUser_UserId))]
        public int UserId { get; set; }

        [SqlColumn("RoleId", typeof(LoRoleUser_RoleId))]
        public int RoleId { get; set; }

        [SqlColumn("IsActive", typeof(LoRoleUser_IsActive))]
        public bool IsActive { get; set; }
    }

    public partial class LoRoleUser_Id : Cell<LoRoleUser> { }

    public partial class LoRoleUser_UserId : Cell<LoRoleUser> { }

    public partial class LoRoleUser_RoleId : Cell<LoRoleUser> { }

    public partial class LoRoleUser_IsActive : Cell<LoRoleUser> { }

    [SqlTable("dbo", "MyRow")]
    public partial class MyRow : Row
    {
        [SqlColumn("Id", typeof(MyRow_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Text", typeof(MyRow_Text))]
        public string Text { get; set; }

        [SqlColumn("X", typeof(MyRow_X))]
        public string X { get; set; }

        [SqlColumn("Y", typeof(MyRow_Y))]
        public bool? Y { get; set; }
    }

    public partial class MyRow_Id : Cell<MyRow> { }

    public partial class MyRow_Text : Cell<MyRow> { }

    public partial class MyRow_X : Cell<MyRow> { }

    public partial class MyRow_Y : Cell<MyRow> { }

    [SqlTable("dbo", "SyRole")]
    public partial class SyRole : Row
    {
        [SqlColumn("Id", typeof(SyRole_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Name", typeof(SyRole_Name))]
        public string Name { get; set; }

        [SqlColumn("IsAdmin", typeof(SyRole_IsAdmin))]
        public bool? IsAdmin { get; set; }
    }

    public partial class SyRole_Id : Cell<SyRole> { }

    public partial class SyRole_Name : Cell<SyRole> { }

    public partial class SyRole_IsAdmin : Cell<SyRole> { }

    [SqlTable("dbo", "SyRoleAccess")]
    public partial class SyRoleAccess : Row
    {
        [SqlColumn("UserId", typeof(SyRoleAccess_UserId))]
        public int UserId { get; set; }

        [SqlColumn("UserName", typeof(SyRoleAccess_UserName))]
        public string UserName { get; set; }

        [SqlColumn("RoleId", typeof(SyRoleAccess_RoleId))]
        public int? RoleId { get; set; }

        [SqlColumn("RoleName", typeof(SyRoleAccess_RoleName))]
        public string RoleName { get; set; }

        [SqlColumn("IsAdmin", typeof(SyRoleAccess_IsAdmin))]
        public bool? IsAdmin { get; set; }
    }

    public partial class SyRoleAccess_UserId : Cell<SyRoleAccess> { }

    public partial class SyRoleAccess_UserName : Cell<SyRoleAccess> { }

    public partial class SyRoleAccess_RoleId : Cell<SyRoleAccess> { }

    public partial class SyRoleAccess_RoleName : Cell<SyRoleAccess> { }

    public partial class SyRoleAccess_IsAdmin : Cell<SyRoleAccess> { }

    [SqlTable("dbo", "SyRoleUser")]
    public partial class SyRoleUser : Row
    {
        [SqlColumn("Id", typeof(SyRoleUser_Id), true)]
        public int Id { get; set; }

        [SqlColumn("UserId", typeof(SyRoleUser_UserId))]
        public int UserId { get; set; }

        [SqlColumn("RoleId", typeof(SyRoleUser_RoleId))]
        public int RoleId { get; set; }

        [SqlColumn("IsActive", typeof(SyRoleUser_IsActive))]
        public bool IsActive { get; set; }
    }

    public partial class SyRoleUser_Id : Cell<SyRoleUser> { }

    public partial class SyRoleUser_UserId : Cell<SyRoleUser> { }

    public partial class SyRoleUser_RoleId : Cell<SyRoleUser> { }

    public partial class SyRoleUser_IsActive : Cell<SyRoleUser> { }

    [SqlTable("dbo", "SyUser")]
    public partial class SyUser : Row
    {
        [SqlColumn("Id", typeof(SyUser_Id), true)]
        public int Id { get; set; }

        [SqlColumn("Name", typeof(SyUser_Name))]
        public string Name { get; set; }
    }

    public partial class SyUser_Id : Cell<SyUser> { }

    public partial class SyUser_Name : Cell<SyUser> { }

    [SqlTable("dbo", "TableName")]
    public partial class TableName : Row
    {
        [SqlColumn("TableName2", typeof(TableName_TableName2))]
        public string TableName2 { get; set; }

        [SqlColumn("IsView", typeof(TableName_IsView))]
        public bool? IsView { get; set; }
    }

    public partial class TableName_TableName2 : Cell<TableName> { }

    public partial class TableName_IsView : Cell<TableName> { }
}
