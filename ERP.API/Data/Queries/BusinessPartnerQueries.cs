using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.API.Data.Queries
{
    public static class BusinessPartnerQueries
    {
        public static readonly string SelectAll = "select * from business_partners;";
        public static readonly string SelectById = "select * from business_partners where Id=@Id;";
        public static readonly string SelectByName = "select * from business_partners where `Name`=@Name;";
        public static readonly string Insert = @"INSERT INTO `business_partners`
                                                (
                                                `Name`,
                                                `PointofContact`,
                                                `MobileNo`,
                                                `EmailId`,
                                                `Address`,
                                                `BusinessPartnerTypeId`,
                                                `VATNo`)
                                                VALUES
                                                (
                                                @Name, @PointofContact, @MobileNo, @EmailId, @Address, @BusinessPartnerTypeId, @VATNo
                                                );SELECT LAST_INSERT_ID();";
        public static readonly string InsertContact = @"INSERT INTO `business_partner_contacts`
                                                (
                                                `Name`,
                                                `Email`,
                                                `ContactNo`,
                                                `BusinessPartnerId`)
                                                VALUES
                                                (
                                                @Name, @Email, @ContactNo, @BusinessPartnerId
                                                );SELECT LAST_INSERT_ID();";
        public static readonly string SelectAllContacts = "select * from business_partner_contacts;";
        public static readonly string SelectAllContactsByBusinessPartnerId = "select * from business_partner_contacts where BusinessPartnerId=@BusinessPartnerId;";
        public static readonly string SelectContactById = "select * from business_partner_contacts where Id=@Id;";
        public static readonly string Update = @"UPDATE `erp`.`business_partners`
                                                SET
                                                `Name` = @Name,
                                                `PointofContact` = @PointofContact,
                                                `MobileNo` = @MobileNo,
                                                `EmailId` = @EmailId,
                                                `Address` = @Address,
                                                `VATNo` = @VATNo
                                                WHERE `Id` = @Id;";
        public static readonly string SelectAllCompanies = "select * from `erp`.`business_partners` where BusinessPartnerTypeId=@BusinessPartnerTypeId";

    }
}
